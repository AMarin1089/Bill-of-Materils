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
    public partial class AddNewMaterialForm : Form
    {
        private Dictionary<DateTime, decimal> map;
        public AddNewMaterialForm()
        {
            InitializeComponent();
            map = new Dictionary<DateTime, decimal>();
            fillComboBox();
        }

        private void fillComboBox()
        {
            measure_cbox.SelectedIndex = -1;
            measure_cbox.Items.Add("Plank");
            measure_cbox.Items.Add("Sheet");
            measure_cbox.Items.Add("Liters");
        }

        
        private void addPriceBtn_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            string price = price_tbox.Text;

            if (string.IsNullOrEmpty(price))
            {
                string message = "Please enter a price!";
                MessageBox.Show(message, "Empty price", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (Decimal.TryParse(price, out decimal value))
            {
                decimal priceDecimal = value;
                if (map.ContainsKey(date))
                {
                    string message = "You've already entered a price for that day. Do you want to override it?";
                    DialogResult dr = MessageBox.Show(message, "Duplicate Date", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        decimal oldValue = map[date];
                        map[date] = priceDecimal;
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

                    allPrices_richBox.Text = allPrices_richBox.Text + "Date: " + date.ToShortDateString() + ", Price: " + priceDecimal.ToString("0.############################")
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

 
        private void addNewMaterial_btn_Click(object sender, EventArgs e)
        {
            string id = code_tbox.Text;
            string name = name_tbox.Text;
            string description = description_tbox.Text;
            string measure = measure_cbox.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(measure))
            {
                string message = "Please fill out all fields!";
                MessageBox.Show(message, "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string message;
                if (DBHelper.IsMaterialWithIdPresent(Convert.ToDecimal(id)))
                {
                    message = "Material with such code exists already!";
                    MessageBox.Show(message, "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DBHelper.IsMaterialWithName(name))
                {
                    message = "This material has been already added!";
                    MessageBox.Show(message, "Duplicate name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                this.materialsTableAdapter1.InsertNewMaterial(Convert.ToDecimal(id),
                   name,
                   description,
                   measure);

                message = $"Added material {name} successfully";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (map.Count > 0)
                {
                    foreach(KeyValuePair<DateTime, decimal> entry in map)
                    {
                        this.pricE_LISTTableAdapter1.Insert(Convert.ToDecimal(id), entry.Key, entry.Value);
                    }
                }
                map.Clear();
                code_tbox.Text = "";
                name_tbox.Text = "";
                description_tbox.Text = "";
                measure_cbox.Text = "";
                measure_cbox.SelectedIndex = -1;
                allPrices_richBox.Text = "";
            }
        }

        private void AddNewMaterialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //just in case
            map.Clear();
        }
    }
}
