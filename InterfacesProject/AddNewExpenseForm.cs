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
    public partial class AddNewExpenseForm : Form
    {
        public AddNewExpenseForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string newExpenseName = expense_tbox.Text.ToString();
            if (string.IsNullOrEmpty(newExpenseName))
            {
                string message = "Please enter a name for the expense!";
                MessageBox.Show(message, "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (newExpenseName.Any(x => char.IsNumber(x)))
            {
                string message = "Only letters are allowed!";
                MessageBox.Show(message, "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DBHelper.ExistsExpenseTypeByName(newExpenseName))
            {
                string message = "There is already an expense with that name!";
                MessageBox.Show(message, "Duplicate expense type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string capitalizedExpenseName = newExpenseName.First().ToString().ToUpper() + String.Join("", newExpenseName.Skip(1));
                DBHelper.InsertExpense(capitalizedExpenseName);
                string message = $"Successfully added expense {newExpenseName}";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.expense_tbox.Text = "";
            }
        }
    }
}
