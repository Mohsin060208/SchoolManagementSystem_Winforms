using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SMS.DAL;
using SMS.Model;

namespace SMS
{
    public partial class Login : Form
    {
        private Int32 id;
        private Admin _admin;
        private AdminService _adminService;
        public Login()
        {
            InitializeComponent();
            _admin = new Admin();
            _adminService = new AdminService();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            _admin.Username = Username_tb.Text;
            _admin.Password = Password_tb.Text;

            bool flag = _adminService.GetLogín(_admin);
                if (flag == true)
                {
                    GlobalAuthorizationControl.Auth = _adminService.Get(Username_tb.Text, Password_tb.Text);
                    DialogResult result = MessageBox.Show("You are Logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Incorrect Username or Password!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Cancel)
                    {
                        string message = "Do You Really Want To Cancel?";
                        string title = "Confirm Your Action";
                        DialogResult res = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    Username_tb.ResetText();
                    Password_tb.ResetText();
                }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Really Want To Exit?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginBtn.Visible = false;
            CPassGb.Visible = true;
            cPwd_lbl.Visible = true;
            cPwd_tb.Visible = true;
            ForgetPwd.Visible = false;
            RecoveryGb.Visible = true;
            Exit.Visible = false;
            Cancelbtn.Visible = true;
            UpdateBtn.Visible = false;
        }
        private void ForgetPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsernameGb.Visible = false;
            PasswordGb.Visible = false;
            CPassGb.Visible = false;
            RecoveryGb.Visible = true;
            LoginBtn.Visible = false;
            Exit.Visible = false;
            UpdateBtn.Visible = false;
            Cancelbtn.Visible = true;
            SearchBtn.Visible = true;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Username_tb.ResetText();
            Password_tb.ResetText();
            UsernameGb.Visible = true;
            PasswordGb.Visible = true;
            LoginBtn.Visible = true;
            CPassGb.Visible = true;
            cPwd_lbl.Visible = false;
            cPwd_tb.Visible = false;
            ForgetPwd.Visible = true;
            RecoveryGb.Visible = false;
            SearchBtn.Visible = false;
            Cancelbtn.Visible = false;
            Exit.Visible = true;
            UpdateBtn.Visible = false;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (Password_tb.Text == cPwd_tb.Text)
            {
            _admin.Id = id;
            _admin.Username = Username_tb.Text;
            _admin.Password = Password_tb.Text;
            _admin.RecoveryName = NickTb.Text;
            _adminService.UpdateLogín(_admin);
            DialogResult dialog = MessageBox.Show("Account Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Username_tb.ResetText();
            Password_tb.ResetText();
            UsernameGb.Visible = true;
            PasswordGb.Visible = true;
            LoginBtn.Visible = true;
            CPassGb.Visible = true;
            cPwd_lbl.Visible = false;
            cPwd_tb.Visible = false;
            ForgetPwd.Visible = true;
            RecoveryGb.Visible = false;
            SearchBtn.Visible = false;
            Cancelbtn.Visible = false;
            Exit.Visible = true;
            UpdateBtn.Visible = false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Passwords do not match!!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                {
                    string message = "Do You Really Want To Cancel?";
                    string title = "Confirm Your Action";
                    DialogResult res = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                Password_tb.ResetText();
                cPwd_tb.ResetText();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var admin = _adminService.FindAccount(NickTb.Text);
            if (admin.Username != null)
            {
                id = admin.Id;
                DialogResult dialog = MessageBox.Show("We found your account, Now update your account and login again","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                UsernameGb.Visible = true;
                Username_tb.Text = admin.Username;
                PasswordGb.Visible = true;
                CPassGb.Visible = true;
                ForgetPwd.Visible = false;
                cPwd_lbl.Visible = true;
                cPwd_tb.Visible = true;
                RecoveryGb.Visible = true;
                LoginBtn.Visible = false;
                UpdateBtn.Visible = true;
                Exit.Visible = false;
                Cancelbtn.Visible = true;
                SearchBtn.Visible = false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Incorrect NickName!!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                {
                    string message = "Do You Really Want To Cancel?";
                    string title = "Confirm Your Action";
                    DialogResult res = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.Yes)
                    {
                        Username_tb.ResetText();
                        Password_tb.ResetText();
                        UsernameGb.Visible = true;
                        PasswordGb.Visible = true;
                        LoginBtn.Visible = true;
                        CPassGb.Visible = true;
                        cPwd_lbl.Visible = false;
                        cPwd_tb.Visible = false;
                        ForgetPwd.Visible = true;
                        RecoveryGb.Visible = false;
                        SearchBtn.Visible = false;
                        Cancelbtn.Visible = false;
                        Exit.Visible = true;
                        UpdateBtn.Visible = false;
                    }
                }
            }
        }
    }
}
