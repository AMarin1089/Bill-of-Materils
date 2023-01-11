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
    public partial class ProductDetails : Form
    {
        decimal productId;
        bool hasSpecification;

        public ProductDetails()
        {
            InitializeComponent();
        }

        public ProductDetails(decimal productId, bool hasSpecificaiton)
        {
            InitializeComponent();
            this.productId = productId;
            this.hasSpecification = hasSpecificaiton;
            handleVisibility();
            fillData();
            calculateMaterialExpenses();
            calculateOtherExpenses();
            calculateTotal();
        }

        private void handleVisibility()
        {
            if (hasSpecification)
            {
                exists_lbl.Visible = false;
            }
            else
            {
                costs_gbox.Visible = false;
            }
        }

        private void fillData()
        {
            code_tbox.Text = this.productId.ToString();

            BillOfMaterialsDBDataSet.PRODUCTDataTable pRODUCTDataTable = this.productTableAdapter1.GetDataByIdOnly(this.productId);
            foreach (DataRow row in pRODUCTDataTable.Rows)
            {
                name_tbox.Text = row["PRODUCT_NAME"].ToString();
                description_tbox.Text = row["PRODUCT_DESCRIPTION"].ToString();
            }
        }

        private void calculateMaterialExpenses()
        {
            if (this.hasSpecification)
            {
                string productName = name_tbox.Text;
                //decimal value = CreateSpecificationForm.expenseForMaterials[productName];
                decimal value = CreateSpecificationForm.getKeyFromMaterials(productName);
                value = Math.Round(value, 2);
                material_textbox.Text = value.ToString();
            }
        }

        private void calculateOtherExpenses()
        {
            if (this.hasSpecification)
            {
                string productName = name_tbox.Text;
                //decimal value = CreateSpecificationForm.expenseForOther[productName];
                decimal value = CreateSpecificationForm.getKeyFromOtherExpenses(productName);
                value = Math.Round(value, 2);
                other_textbox.Text = value.ToString();
            }
        }



        private void calculateTotal()
        {
            if (this.hasSpecification)
            {
                totalCosts_tbox.Text = (Decimal.Parse(material_textbox.Text) + Decimal.Parse(other_textbox.Text)).ToString();
            }
        }
    }
}
