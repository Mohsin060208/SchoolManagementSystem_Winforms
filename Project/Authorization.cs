using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class Authorization : Form
    {
        private AdminPanel _adminPanel;
        private MainForm _mainForm;
        public Authorization()
        {
            InitializeComponent();
            _adminPanel = new AdminPanel();
            _mainForm = new MainForm();
        }

        private void AuthorizeBtn_Click(object sender, EventArgs e)
        {
            if (Username_tb.Text == GlobalAuthorizationControl.Auth.Username && Password_tb.Text == GlobalAuthorizationControl.Auth.Password)
            {
                this.Hide();
                _adminPanel.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Provide credentials with which you are logged in now!", "Incorrect Username or Password");
                Username_tb.ResetText();
                Password_tb.ResetText();
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainForm.ShowDialog();
            this.Close();
        }
    }
}