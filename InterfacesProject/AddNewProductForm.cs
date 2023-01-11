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
    public partial class AddNewProductForm : Form
    {
        public AddNewProductForm()
        {
            InitializeComponent();
        }

        private void addNewProduct_btn_Click(object sender, EventArgs e)
        {
            string id = code_tbox.Text;
            string name = name_tbox.Text;
            string description = description_tbox.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description))
            {
                string message = "Please fill out all fields!";
                MessageBox.Show(message, "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string message;
                if (DBHelper.IsProductWithIdPresent(Convert.ToDecimal(id)))
                {
                    message = "Product with such code exists already!";
                    MessageBox.Show(message, "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DBHelper.IsProductWithName(name))
                {
                    message = "This material has been already added!";
                    MessageBox.Show(message, "Duplicate name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                this.productTableAdapter1.Insert(Convert.ToDecimal(id),
                   name,
                   description);

                message = $"Added product {name} successfully";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                code_tbox.Text = "";
                name_tbox.Text = "";
                description_tbox.Text = "";
            }
        }
    }
}
