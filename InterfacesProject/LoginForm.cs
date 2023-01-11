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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = password_textbox.Text;

            if (string.IsNullOrEmpty(username))
            {
                string message = "Please enter a username!";
                MessageBox.Show(message, "Empty username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(password))
            {
                string message = "Please enter a password!";
                MessageBox.Show(message, "Empty password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!"admin".Equals(username))
            {
                string message = $"Invalid username: {username}";
                MessageBox.Show(message, "Unkown user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!"adm1n".Equals(password))
            {
                string message = "Invalid password!";
                MessageBox.Show(message, "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string message = $"Welcome, {username}!";
                MessageBox.Show(message, "Successful login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Visible = false;
            }
        }
    }
    
}
