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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            initialSignoutDesign();
        }

        private void initialSignoutDesign()
        {
            signout_btn.Visible = false;
        }

        private void showButton(Button btn)
        {
            if (signout_btn.Visible)
            {
                signout_btn.Visible = false;
            }
            else if (signout_btn.Visible == false)
            {
                signout_btn.Visible = true;
            }
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to sign out?", "Sign out",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void userLogo_pictureBox_Click(object sender, EventArgs e)
        {
            showButton(signout_btn);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void openExpense_Btn_Click(object sender, EventArgs e)
        {
            ExpenseMainForm form = new ExpenseMainForm(this);
            this.Visible = false;
            form.ShowDialog();
        }

        private void openMaterials_Btn_Click(object sender, EventArgs e)
        {
            MaterialMainForm form = new MaterialMainForm(this);
            this.Visible = false;
            form.ShowDialog();
        }

        private void openProducts_btn_Click(object sender, EventArgs e)
        {
            ProductMainForm form = new ProductMainForm(this);
            this.Visible = false;
            form.ShowDialog();
        }

        public void ShowVisibleAgain()
        {
            this.Visible = true;
        }
    }
}
