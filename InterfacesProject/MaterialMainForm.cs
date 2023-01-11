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
    public partial class MaterialMainForm : Form
    {
        MainForm form;
        public MaterialMainForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void MaterialMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billOfMaterialsDBDataSet.MATERIALS' table. You can move, or remove it, as needed.
            this.mATERIALSTableAdapter.Fill(this.billOfMaterialsDBDataSet.MATERIALS);

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
                    this.mATERIALSTableAdapter.FillByIdOnly(this.billOfMaterialsDBDataSet.MATERIALS, Convert.ToInt32(id));    
                }
                else
                {
                    string message = "Code must be a number";
                    MessageBox.Show(message, "Invalid parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(name) && string.IsNullOrEmpty(description))
            {
                this.mATERIALSTableAdapter.FillByNameOnly(this.billOfMaterialsDBDataSet.MATERIALS, name);
            }
            else if (string.IsNullOrEmpty(id) && string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
            {
                this.mATERIALSTableAdapter.FillByDescriptionOnly(this.billOfMaterialsDBDataSet.MATERIALS, '%' + description + '%');
            }
            else if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
            {
                if (decimal.TryParse(id, out decimal n))
                {
                    this.mATERIALSTableAdapter.FillByIdAndNameAndDescription(this.billOfMaterialsDBDataSet.MATERIALS,
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
                if (decimal.TryParse(id, out decimal n))
                {
                    this.mATERIALSTableAdapter.FillByIdAndName(this.billOfMaterialsDBDataSet.MATERIALS,
                        Convert.ToInt32(id), name);
                    
                }
                else
                {
                    string message = "ID must be a number";
                    MessageBox.Show(message, "Invalid parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(id) && string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
            {
                if (decimal.TryParse(id, out decimal n))
                {
                    this.mATERIALSTableAdapter.FillByIdAndDescription(this.billOfMaterialsDBDataSet.MATERIALS,
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
                this.mATERIALSTableAdapter.FillByNameAndDescription(this.billOfMaterialsDBDataSet.MATERIALS,
                        name, '%' + description + '%');
            }
        }

        private void clear_Btn_Click(object sender, EventArgs e)
        {
            id_tbox.Text = "";
            name_tbox.Text = "";
            desc_tbox.Text = "";
            this.mATERIALSTableAdapter.Fill(this.billOfMaterialsDBDataSet.MATERIALS);
        }

        private void addNew_Btn_Click(object sender, EventArgs e)
        {
            AddNewMaterialForm form = new AddNewMaterialForm();
            form.ShowDialog();

            while (Application.OpenForms.OfType<AddNewMaterialForm>().Count() != 0)
            {
                //do nothing
            }
            this.mATERIALSTableAdapter.Fill(this.billOfMaterialsDBDataSet.MATERIALS);
        }

        private void materialDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && materialDataGridView.Columns[e.ColumnIndex].Name.Equals("Edit"))
            {
                decimal id = Convert.ToInt32(materialDataGridView.CurrentRow.Cells[0].Value);
                bool isUsedInProduct = DBHelper.IsMaterialUsedInProduct(id);
                EditMaterialForm form = new EditMaterialForm(id, isUsedInProduct);
                form.ShowDialog();
            }
            while (Application.OpenForms.OfType<EditMaterialForm>().Count() != 0)
            {
                //do nothing
            }
            this.mATERIALSTableAdapter.Fill(this.billOfMaterialsDBDataSet.MATERIALS);
        }

        private void MaterialMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form.ShowVisibleAgain();
        }
    }
}
