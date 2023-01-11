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
    public partial class CreateSpecificationForm : Form
    {
        private decimal productId;
        //Materials
        Dictionary<string, decimal> materialsMap;
        Dictionary<string, decimal> materialsPriceMap;
        Dictionary<string, DateTime> mostRecentDateMap;
        //Expenses
        Dictionary<string, List<decimal>> expensesMap;

        //OTHER
        public static Dictionary<string, decimal> expenseForMaterials = new Dictionary<string, decimal>();
        public static Dictionary<string, decimal> expenseForOther = new Dictionary<string, decimal>();

        public CreateSpecificationForm()
        {
            InitializeComponent();
        }
        public CreateSpecificationForm(decimal productId)
        {
            InitializeComponent();
            materialsMap = new Dictionary<string, decimal>();
            materialsPriceMap = new Dictionary<string, decimal>();
            mostRecentDateMap = new Dictionary<string, DateTime>();
            expensesMap = new Dictionary<string, List<decimal>>();
            this.productId = productId;
            currentTotal_label.Text = "0.00";
            fillData();
            getPricesForMaterials();
            getExpenses();
        }

        private void fillData()
        {
            // Product
            BillOfMaterialsDBDataSet.PRODUCTDataTable pRODUCTDataTable = this.productTableAdapter1.GetDataByIdOnly(this.productId);
            foreach (DataRow row in pRODUCTDataTable.Rows)
            {
                product_tbox.Text = row["PRODUCT_NAME"].ToString();
            }

            //Materials
            materials_Combobox.SelectedIndex = -1;
            BillOfMaterialsDBDataSet.MATERIALSDataTable mATERIALSDataTable = this.materialsTableAdapter1.GetData();
            foreach (DataRow row in mATERIALSDataTable.Rows)
            {
                string materialName = row["MATERIAL_NAME"].ToString();
                materials_Combobox.Items.Add(materialName);
            }
        }

        private void getPricesForMaterials()
        {
            //BillOfMaterialsDBDataSet.PRICE_LISTDataTable pRICE_LISTDataTable = this.pricE_LISTTableAdapter1.GetAllPrices();
            DataTable dataTable = DBHelper.GetAllPrices();
            foreach (DataRow row in dataTable.Rows)
            {
                string materialName = row["MATERIAL_NAME"].ToString();
                decimal price = (decimal)row["PRICE_PRICE"];
                DateTime date = (DateTime)row["PRICE_DATE"];
                bool hasNewerPrice = false;

                if (mostRecentDateMap.ContainsKey(materialName))
                {
                    if (date.CompareTo(mostRecentDateMap[materialName]) > 0)
                    {
                        mostRecentDateMap[materialName] = date;
                        hasNewerPrice = true;
                    }
                }
                else
                {
                    mostRecentDateMap.Add(materialName, date);
                }

                if (materialsPriceMap.ContainsKey(materialName))
                {
                    if (hasNewerPrice)
                    {
                        materialsPriceMap[materialName] = price;
                    }
                }
                else
                {
                    materialsPriceMap.Add(materialName, price);
                }
            }
        }

        private void getExpenses()
        {
            BillOfMaterialsDBDataSet.EXPENCESDataTable eXPENCESDataTable = this.expencesTableAdapter1.GetData();
            foreach (DataRow row in eXPENCESDataTable.Rows)
            {
                string expenseName = row["EXPENCE_NAME"].ToString();
                expenseType_cbox.Items.Add(expenseName);
            }
        }

        private void addMaterial_btn_Click(object sender, EventArgs e)
        {
            string quantity = matQuantity_Tbox.Text;
            string material = materials_Combobox.Text;
            if (materials_Combobox.SelectedIndex < 0)
            {
                string message = "Please choose a material";
                MessageBox.Show(message, "Invalid material", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(quantity))
            {
                string message = "Please enter the quantity of the material needed";
                MessageBox.Show(message, "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (decimal.TryParse(quantity, out decimal res))
            {
                if (res <= 0)
                {
                    string message = "Quantity must be a positive integer";
                    MessageBox.Show(message, "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.materialsMap.ContainsKey(material))
                    {
                        materialsMap[material] = materialsMap[material] + res;
                    }
                    else
                    {
                        materialsMap.Add(material, res);
                    }
                    materials_richBox.Text = materials_richBox.Text + material + " x " + quantity + Environment.NewLine;

                    decimal total = decimal.Parse(currentTotal_label.Text);
                    decimal temp = 0;
                    foreach (KeyValuePair<string, decimal> entry in materialsMap)
                    {
                        string materialKey = entry.Key;
                        decimal quantityValue = entry.Value;
                        temp += quantityValue * materialsPriceMap[materialKey];
                        total += quantityValue * materialsPriceMap[materialKey];
                    }
                    string productName = product_tbox.Text;
                    if (expenseForMaterials.ContainsKey(productName))
                    {
                        expenseForMaterials[productName] = expenseForMaterials[productName] + total;
                    }
                    else
                    {
                        expenseForMaterials.Add(productName, temp);
                    }
                    currentTotal_label.Text = Math.Round(total, 2).ToString();
                    matQuantity_Tbox.Text = "";
                    materials_Combobox.SelectedIndex = -1;
                }
            }
            else
            {
                string message = "Quantity may contain only numbers";
                MessageBox.Show(message, "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        ////////!!!!!!!!!!
        private void addExpense_Btn_Click(object sender, EventArgs e)
        {
            string value = expensesValue_tbox.Text;
            string expense = expenseType_cbox.Text;

            if (expenseType_cbox.SelectedIndex < 0)
            {
                string message = "Please choose an expense";
                MessageBox.Show(message, "Invalid expense", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(value))
            {
                string message = "Please enter the value of the expense";
                MessageBox.Show(message, "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (decimal.TryParse(value, out decimal res))
            {
                if (res <= 0)
                {
                    string message = "Value must be a positive integer";
                    MessageBox.Show(message, "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.expensesMap.ContainsKey(expense))
                    {
                        expensesMap[expense].Add(res);
                    }
                    else
                    {
                        expensesMap[expense] = new List<decimal> { res };
                    }
                    richTextBox1.Text = richTextBox1.Text + expense + " -> " + res + Environment.NewLine;

                    decimal total = decimal.Parse(currentTotal_label.Text);
                    decimal curr = 0;
                    foreach (KeyValuePair<string, List<decimal>> entry in expensesMap)
                    {
                        decimal expenseValue = 0;
                        foreach (decimal expenseKVP in entry.Value)
                        {
                            expenseValue += expenseKVP;
                        }

                        total += expenseValue;
                        curr += expenseValue;
                    }
                    string productName = product_tbox.Text;
                    if (expenseForOther.ContainsKey(productName))
                    {
                        expenseForOther[productName] = expenseForOther[productName] + curr;
                    }
                    else
                    {
                        expenseForOther.Add(productName, curr);
                    }
                    
                    currentTotal_label.Text = Math.Round(total, 2).ToString();
                    expenseType_cbox.SelectedIndex = -1;
                    expensesValue_tbox.Text = "";
                }
            }
            else
            {
                string message = "Value may contain only numbers";
                MessageBox.Show(message, "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void createSpec_btn_Click(object sender, EventArgs e)
        {
            insertExpenses();
            insertMaterials();
            string message = $"Successfully created a specification for {this.product_tbox.Text}";
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void insertExpenses()
        {
            Dictionary<string, decimal> tempMap = new Dictionary<string, decimal>();
            foreach (KeyValuePair<string, List<decimal>> entry in expensesMap)
            {
                string expenseName = entry.Key;
                decimal expenseValue = 0;
                foreach (decimal expenseKVP in entry.Value)
                {
                    expenseValue += expenseKVP;
                }
                tempMap.Add(expenseName, expenseValue);
            }

            foreach (KeyValuePair<string, decimal> entry in tempMap)
            {
                string expenseName = entry.Key;
                decimal expenseValue = entry.Value;

                /////////////////////////
                //BillOfMaterialsDBDataSet.EXPENCESDataTable eXPENCESDataTable = expencesTableAdapter1.GetIdByName(expenseName);
                DataTable dataTable = DBHelper.GetExpenseIdByExpenseName(expenseName);
                decimal expenseId = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    expenseId = (decimal)row["EXPENCE_ID"];
                }

                DBHelper.InsertOtherExpenses(productId, expenseId, expenseValue);
            }

        }

        private void insertMaterials()
        {
            foreach (KeyValuePair<string, decimal> entry in materialsMap)
            {
                string materialName = entry.Key;
                decimal materialValue = entry.Value;

                ///////////////
                //BillOfMaterialsDBDataSet.MATERIALSDataTable mATERIALSDataTable = materialsTableAdapter1.GetMaterialIdByName(materialName);
                DataTable dataTable = DBHelper.GetMaterialIdByMaterialName(materialName);

                decimal materialId = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    materialId = (decimal)row["MATERIAL_ID"];
                }

                DBHelper.InsertIntoBom(productId, materialId, materialValue);
            }
        }



        public static decimal getKeyFromMaterials(string name)
        {
            return expenseForMaterials[name];
        }

        public static Dictionary<string,decimal> getMaterialsMap()
        {
            return expenseForMaterials;
        }

        public static Dictionary<string, decimal> getOtherMap()
        {
            return expenseForOther;
        }

        public static decimal getKeyFromOtherExpenses(string name)
        {
            return expenseForOther[name];
        }

    }
}
