using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.DAL;
using SMS.Model;

namespace SMS
{
    public partial class AdminPanel : Form
    {
        private AdminService _adminService;
        private Admin _admin;
        private MainForm _mf;
        public AdminPanel()
        {
            InitializeComponent();
            _admin = new Admin();
            _adminService = new AdminService();
            _mf = new MainForm();
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            var dataSource = _adminService.GetLogínsDataTable();
            grid.DataSource = dataSource;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (IdTb.Text != "")
            {
            DialogResult result = MessageBox.Show("Do You Really Want To Delete this Account?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); 
                if (result == DialogResult.OK)
                {
                _adminService.DeleteLogín(int.Parse(IdTb.Text));
                AdminService adminService = new AdminService();
                var dataSource = adminService.GetLogínsDataTable();
                grid.DataSource = dataSource;
                MessageBox.Show("Account Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IdTb.ResetText();
                UsernameTb.ResetText();
                PasswordTb.ResetText();
                RecoveryTb.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Please Select an Id from the grid!", "Id is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTb.Text != "" || PasswordTb.Text != "" || RecoveryTb.Text != "")
            {
                if (IdTb.Text != "")
                {
                    DialogResult result = MessageBox.Show("Do You Really Want To Update this Account?", "Confirm Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        _admin.Id = int.Parse(IdTb.Text);
                        _admin.Username = UsernameTb.Text;
                        _admin.Password = PasswordTb.Text;
                        _admin.RecoveryName = RecoveryTb.Text;
                        _adminService.UpdateLogín(_admin);
                        AdminService adminService = new AdminService();
                        var dataSource = adminService.GetLogínsDataTable();
                        grid.DataSource = dataSource;
                        MessageBox.Show("Account Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IdTb.ResetText();
                        UsernameTb.ResetText();
                        PasswordTb.ResetText();
                        RecoveryTb.ResetText();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select an account from the grid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Exit_to_MainForm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Really Want To Exit?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                _mf.ShowDialog();
                this.Close();
            }
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTb.Text != "" || PasswordTb.Text != "" || RecoveryTb.Text != "")
            {
                    _admin.Username = UsernameTb.Text;
                    _admin.Password = PasswordTb.Text;
                    _admin.RecoveryName = RecoveryTb.Text;
                    _adminService.InsertLogín(_admin);
                    AdminService adminService = new AdminService();
                    var dataSource = adminService.GetLogínsDataTable();
                    grid.DataSource = dataSource;
                    MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IdTb.ResetText();
                    UsernameTb.ResetText();
                    PasswordTb.ResetText();
                    RecoveryTb.ResetText();
            }
            else
            {
                MessageBox.Show("Please Fill in the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IdTb.ResetText();
                UsernameTb.ResetText();
                PasswordTb.ResetText();
                RecoveryTb.ResetText();
            }
        }
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grid.Rows[e.RowIndex];
                IdTb.Text = row.Cells["Id"].Value.ToString() ;
                UsernameTb.Text = row.Cells["Username"].Value.ToString();
                PasswordTb.Text = row.Cells["Password"].Value.ToString();
                RecoveryTb.Text = row.Cells["Recovery_Name"].Value.ToString();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            IdTb.ResetText();
            UsernameTb.ResetText();
            PasswordTb.ResetText();
            RecoveryTb.ResetText();
        }
    }
}