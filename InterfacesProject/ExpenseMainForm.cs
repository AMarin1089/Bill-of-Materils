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
    public partial class ExpenseMainForm : Form
    {
        MainForm form;
        public ExpenseMainForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void ExpenseMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billOfMaterialsDBDataSet.EXPENCES' table. You can move, or remove it, as needed.
            this.eXPENCESTableAdapter.Fill(this.billOfMaterialsDBDataSet.EXPENCES);

        }

        private void addNew_Btn_Click(object sender, EventArgs e)
        {
            AddNewExpenseForm form = new AddNewExpenseForm();
            form.ShowDialog();
            while (Application.OpenForms.OfType<AddNewExpenseForm>().Count() != 0)
            {

            }
            this.eXPENCESTableAdapter.Fill(this.billOfMaterialsDBDataSet.EXPENCES);
        }

        private void ExpenseMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form.ShowVisibleAgain();
        }
    }
}
