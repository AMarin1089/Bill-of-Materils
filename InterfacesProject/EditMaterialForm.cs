using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesProject
{
    public partial class EditMaterialForm : Form
    {
        private decimal ogID;
        private Dictionary<DateTime, decimal> map;
        bool isUsed = false;
        BillOfMaterialsDBDataSet.MATERIALSDataTable originaltable;
        BillOfMaterialsDBDataSet.PRICE_LISTDataTable OGpriceTable;
        public EditMaterialForm()
        {
            InitializeComponent();
            map = new Dictionary<DateTime, decimal>();
        }

        public EditMaterialForm(decimal id, bool isUsed)
        {
            InitializeComponent();
            this.ogID = id;
            map = new Dictionary<DateTime, decimal>();
            code_tbox.ReadOnly = true;
            fillHowMuchIsPresent(isUsed);
            this.isUsed = isUsed;
            limitAccess(isUsed);
            fillComboBox();
            fillData(id);
        }
        #region Initial
        private void fillHowMuchIsPresent(bool isUsed)
        {
            int number = 0;
            if (isUsed)
            {
                number = DBHelper.HowManyProductsMaterialIsPresent(this.ogID);
                expand_button.Visible = true;

                BillOfMaterialsDBDataSet.BOMDataTable bOMDataTable = this.bomTableAdapter1.GetProductNamesByMaterialId(this.ogID);

                foreach (DataRow row in bOMDataTable)
                {
                    tbox_Present.Text = tbox_Present.Text + row["PRODUCT_NAME"].ToString() + Environment.NewLine;
                }

            }
            presentLabel.Text = $"This material is used in {number} products.";
        }

        private void limitAccess(bool isUsed)
        {
            if (isUsed)
            {
                string message = "Since this material is used in a product specification, you can only edit the price list.";
                MessageBox.Show(message, "Material is used", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                name_tbox.ReadOnly = true;
                description_tbox.ReadOnly = true;
                measure_cbox.Enabled = false;
            }
        }

        private void fillComboBox()
        {
            measure_cbox.Items.Add("Plank");
            measure_cbox.Items.Add("Sheet");
            measure_cbox.Items.Add("Liters");
        }

        private void fillData(decimal id)
        {
            code_tbox.Text = id.ToString();
            BillOfMaterialsDBDataSet.MATERIALSDataTable mATERIALSDataTable =
                this.materialsTableAdapter1.GetDataByIdOnly(id);

            this.originaltable = this.materialsTableAdapter1.GetDataByIdOnly(id);

            foreach (DataRow row in mATERIALSDataTable.Rows)
            {
                name_tbox.Text = row["MATERIAL_NAME"].ToString();
                description_tbox.Text = row["MATERIAL_DESCRIPTION"].ToString();
                measure_cbox.Text = row["MATERIAL_MEASURE"].ToString();
            }

            BillOfMaterialsDBDataSet.PRICE_LISTDataTable pRICE_LISTDataTable =
                this.pricE_LISTTableAdapter1.GetDataByMaterialId(id);
            this.OGpriceTable = this.pricE_LISTTableAdapter1.GetDataByMaterialId(id);

            foreach (DataRow row in pRICE_LISTDataTable.Rows)
            {
                DateTime key = (DateTime)row["PRICE_DATE"];
                decimal value = (decimal)row["PRICE_PRICE"];

                map[key] = value;

                allPrices_richBox.Text = allPrices_richBox.Text + "Date: " + key.ToShortDateString() + ", Price: " + value.ToString()
                       + Environment.NewLine;
            }
        }


        #endregion

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (!this.isUsed)
            {
                string name = name_tbox.Text;
                string description = description_tbox.Text;
                string measure = measure_cbox.Text;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(measure))
                {
                    string message = "Please fill out all fields!";
                    MessageBox.Show(message, "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (DataRow row in this.originaltable.Rows)
                    {
                        row["MATERIAL_NAME"] = name;
                        row["MATERIAL_DESCRIPTION"] = description;
                        row["MATERIAL_MEASURE"] = measure;
                    }

                    this.materialsTableAdapter1.Update(originaltable);
                    string message = $"Successfully updated {name}";
                    MessageBox.Show(message, "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            DBHelper.DeleteAllPricesByMaterialId(this.ogID);

            if (map.Count > 0)
            {
                foreach (KeyValuePair<DateTime, decimal> entry in map)
                {
                    this.pricE_LISTTableAdapter1.Insert(this.ogID, entry.Key, entry.Value);
                }
            }

            this.Close();
        }

        private void addPriceBtn_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            DateTime realDate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
            string price = price_tbox.Text;

            if (string.IsNullOrEmpty(price))
            {
                string message = "Please enter a price!";
                MessageBox.Show(message, "Empty price", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Decimal.TryParse(price, out decimal value))
            {
                decimal priceDecimal = value;
                if (map.ContainsKey(realDate))
                {
                    string message = "You've already entered a price for that day. Do you want to override it?";
                    DialogResult dr = MessageBox.Show(message, "Duplicate Date", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        decimal oldValue = map[realDate];
                        map[realDate] = priceDecimal;
                        allPrices_richBox.Text = allPrices_richBox.Text
                            .Replace("Date: " + date.ToShortDateString() + ", Price: " + oldValue.ToString(),
                            "Date: " + date.ToShortDateString() + ", Price: " + priceDecimal.ToString());
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    map[date] = priceDecimal;

                    allPrices_richBox.Text = allPrices_richBox.Text + "Date: " + date.ToShortDateString() + ", Price: " + priceDecimal.ToString()
                        + Environment.NewLine;

                    price_tbox.Text = "";
                }
            }
            else
            {
                string message = "Please enter a valid price!";
                MessageBox.Show(message, "Invalid price", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void expand_button_Click(object sender, EventArgs e)
        {
            if (tbox_Present.Visible == false)
            {
                tbox_Present.Visible = true;
                expand_button.Text = "Hide";
            }
            else
            {
                tbox_Present.Visible = false;
                expand_button.Text = "Details";
            }
        }
    }
}
