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
    public partial class ProductMainForm : Form
    {
        MainForm form;
        public ProductMainForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void ProductMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billOfMaterialsDBDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.billOfMaterialsDBDataSet.PRODUCT);

        }

        private void search_Btn_Click(object sender, EventArgs e)
        {
            string id = id_tbox.Text;
            string name = name_tbox.Text;
            string description = desc_tbox.Text;

            if (string.IsNullOrEmpty(id) && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(description))
            {
                string message = "No search criteria";
                MessageBox.Show(message, "Invalid parameters", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrEmpty(id) && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(description))
            {
                if (decimal.TryParse(id, out decimal n))
                {
                    this.pRODUCTTableAdapter.FillByIdOnly(this.billOfMaterialsDBDataSet.PRODUCT, Convert.ToInt32(id));
                }
                else
                {
                    string message = "Code must be a number";
                    MessageBox.Show(message, "Invalid parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(name) && string.IsNullOrEmpty(description))
            {
                this.pRODUCTTableAdapter.FillByNameOnly(this.billOfMaterialsDBDataSet.PRODUCT, name);
            }
            else if (string.IsNullOrEmpty(id) && string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
            {
                this.pRODUCTTableAdapter.FillByDescriptionOnly(this.billOfMaterialsDBDataSet.PRODUCT, '%' + description + '%');
            }
            else if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
            {
                if (decimal.TryParse(id, out decimal result))
                {
                    this.pRODUCTTableAdapter.FillByIdAndNameAndDescription(this.billOfMaterialsDBDataSet.PRODUCT,
                        Convert.ToInt32(id), name, '%' + description + '%');
                }
                else
                {
                    string message = "ID must be a number";
                    MessageBox.Show(message, "Invalid parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(name) && string.IsNullOrEmpty(description))
            {
                if (decimal.TryParse(id, out decimal result))
                {
                    this.pRODUCTTableAdapter.FillByIdAndName(this.billOfMaterialsDBDataSet.PRODUCT,
                        Convert.ToInt32(id), name); ;
                }
                else
                {
                 
                    string message = "ID must be a number";
                    MessageBox.Show(message, "Invalid parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(id) && string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
            {
                if (decimal.TryParse(id, out decimal result))
                {
                    this.pRODUCTTableAdapter.FillByIdAndDescription(this.billOfMaterialsDBDataSet.PRODUCT,
                        Convert.ToInt32(id), '%' + description + '%');
                }
                else
                {
                    string message = "ID must be a number";
                    MessageBox.Show(message, "Invalid parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.pRODUCTTableAdapter.FillByNameAndDescription(this.billOfMaterialsDBDataSet.PRODUCT,
                        name, '%' + description + '%');
            }
        }

        private void clear_Btn_Click(object sender, EventArgs e)
        {
            id_tbox.Text = "";
            name_tbox.Text = "";
            desc_tbox.Text = "";
            this.pRODUCTTableAdapter.Fill(this.billOfMaterialsDBDataSet.PRODUCT);
        }

        private void addNew_Btn_Click(object sender, EventArgs e)
        {
            AddNewProductForm form = new AddNewProductForm();
            form.ShowDialog();
            while (Application.OpenForms.OfType<AddNewMaterialForm>().Count() != 0)
            {
                //do nothing
            }
            this.pRODUCTTableAdapter.Fill(this.billOfMaterialsDBDataSet.PRODUCT);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name.Equals("CreateSpec"))
            {
                decimal id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bool alreadyHasSpecification = DBHelper.AlreadyHasSpecificationById(id);
                if (alreadyHasSpecification)
                {
                    string message = "You can view the existing specification through Details";
                    MessageBox.Show(message, "Specification already created", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CreateSpecificationForm form = new CreateSpecificationForm(id);
                form.ShowDialog();
            } else if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name.Equals("Details"))
            {
                decimal id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bool HasSpecification = DBHelper.AlreadyHasSpecificationById(id);
                ProductDetails productDetails = new ProductDetails(id, HasSpecification);
                productDetails.ShowDialog();
            }
        }

        private void ProductMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form.ShowVisibleAgain();
        }
    }
}
