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
    public partial class TeacherUC : UserControl
    {
        private Teacher _teacher;
        private TeachersService _teacherService;
        public TeacherUC()
        {
            InitializeComponent();
            _teacher = new Teacher();
            _teacherService = new TeachersService();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            GenderTb.SelectedIndex = 0;
        }
        private void InsertTile_Click(object sender, EventArgs e)
        {
            InsertTile.color = Color.FromArgb(242, 242, 242);
            SelectTile.color = Color.Wheat;
            DeleteTile.color = Color.Wheat;
            UpdateTile.color = Color.Wheat;
            ViewTile.color = Color.Wheat;
            HideTile.color = Color.Wheat;
            idGB.Visible = false;
            grid.Visible = false;
            detailsGB.Visible = true;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
            InsertBtn.Visible = true;
            ClearBtn.Visible = false;
            TeacherIDTb.ResetText();
            NameTb.ResetText();
            PhoneTb.ResetText();
            AddressTb.ResetText();
            GenderTb.SelectedIndex = 0;
            SalaryTb.ResetText();
        }

        private void SelectTile_Click(object sender, EventArgs e)
        {
            SelectTile.color = Color.FromArgb(242, 242, 242);
            InsertTile.color = Color.Wheat;
            DeleteTile.color = Color.Wheat;
            UpdateTile.color = Color.Wheat;
            ViewTile.color = Color.Wheat;
            HideTile.color = Color.Wheat;
            idGB.Visible = true;
            grid.Visible = false;
            detailsGB.Visible = true;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
            InsertBtn.Visible = false;
            ClearBtn.Visible = true;
        }

        private void UpdateTile_Click(object sender, EventArgs e)
        {
            UpdateTile.color = Color.FromArgb(242, 242, 242);
            InsertTile.color = Color.Wheat;
            DeleteTile.color = Color.Wheat;
            SelectTile.color = Color.Wheat;
            ViewTile.color = Color.Wheat;
            HideTile.color = Color.Wheat;
            idGB.Visible = true;
            grid.Visible = false;
            detailsGB.Visible = true;
            UpdateBtn.Visible = true;
            DeleteBtn.Visible = false;
            InsertBtn.Visible = false;
            ClearBtn.Visible = false;
        }

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            DeleteTile.color = Color.FromArgb(242, 242, 242);
            InsertTile.color = Color.Wheat;
            SelectTile.color = Color.Wheat;
            UpdateTile.color = Color.Wheat;
            ViewTile.color = Color.Wheat;
            HideTile.color = Color.Wheat;
            idGB.Visible = true;
            grid.Visible = false;
            detailsGB.Visible = true;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = true;
            InsertBtn.Visible = false;
            ClearBtn.Visible = false;
        }

        private void ViewTile_Click(object sender, EventArgs e)
        {
            ViewTile.color = Color.FromArgb(242, 242, 242);
            InsertTile.color = Color.Wheat;
            DeleteTile.color = Color.Wheat;
            UpdateTile.color = Color.Wheat;
            SelectTile.color = Color.Wheat;
            HideTile.color = Color.Wheat;
            idGB.Visible = false;
            grid.Visible = true;
            detailsGB.Visible = true;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
            InsertBtn.Visible = false;
            ClearBtn.Visible = false;
            var dataSource = _teacherService.GetTeachersDataTable();
            if (dataSource.Rows.Count == 0)
            {
                MessageBox.Show("This table currently contains no record!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            grid.DataSource = dataSource;
        }

        private void HideTile_Click(object sender, EventArgs e)
        {
            HideTile.color = Color.FromArgb(242, 242, 242);
            InsertTile.color = Color.Wheat;
            DeleteTile.color = Color.Wheat;
            UpdateTile.color = Color.Wheat;
            ViewTile.color = Color.Wheat;
            SelectTile.color = Color.Wheat;
            idGB.Visible = false;
            grid.Visible = false;
            detailsGB.Visible = false;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
            InsertBtn.Visible = false;
            ClearBtn.Visible = false;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text != "" || PhoneTb.Text != "" || AddressTb.Text != "" || GenderTb.SelectedIndex != 0 ||SalaryTb.Text != "")
            {
            _teacher.Name = NameTb.Text;
            _teacher.Phone = PhoneTb.Text;
            _teacher.Address = AddressTb.Text;
            _teacher.Gender = GenderTb.Text;
            _teacher.Salary = int.Parse(SalaryTb.Text);
            _teacherService.InsertTeacher(_teacher);
            MessageBox.Show("Record Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NameTb.ResetText();
            PhoneTb.ResetText();
            AddressTb.ResetText();
            GenderTb.SelectedIndex = 0;
            SalaryTb.ResetText();
            }
            else
            {
                MessageBox.Show("Please Fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TeacherIDTb.ResetText();
            NameTb.ResetText();
            PhoneTb.ResetText();
            AddressTb.ResetText();
            GenderTb.SelectedIndex = 0;
            SalaryTb.ResetText();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (TeacherIDTb.Text != "")
            {
            _teacher.Id = int.Parse(TeacherIDTb.Text);
            var teacher = _teacherService.GetTeacher(_teacher);
            NameTb.Text = teacher.Name;
            PhoneTb.Text = teacher.Phone;
            AddressTb.Text = teacher.Address;
            GenderTb.SelectedText = teacher.Gender;
            SalaryTb.Text = teacher.Salary.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a Teacher Id!", "Teacher Id is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (TeacherIDTb.Text != "")
            {
                _teacherService.DeleteTeacher(int.Parse(TeacherIDTb.Text));
                MessageBox.Show("Record Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TeacherIDTb.ResetText();
                NameTb.ResetText();
                PhoneTb.ResetText();
                AddressTb.ResetText();
                GenderTb.SelectedIndex = 0;
                SalaryTb.ResetText();
            }
            else
            {
                MessageBox.Show("Please Enter a Teacher Id!", "Teacher Id is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text != "" || PhoneTb.Text != "" || AddressTb.Text != "" || GenderTb.SelectedIndex != 0 || SalaryTb.Text != "")
            {
                if (TeacherIDTb.Text != "")
                {
                    _teacher.Id = int.Parse(TeacherIDTb.Text);
                    _teacher.Name = NameTb.Text;
                    _teacher.Phone = PhoneTb.Text;
                    _teacher.Address = AddressTb.Text;
                    _teacher.Gender = GenderTb.Text;
                    _teacher.Salary = int.Parse(SalaryTb.Text);
                    _teacherService.UpdateTeacher(_teacher);
                    MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TeacherIDTb.ResetText();
                    NameTb.ResetText();
                    PhoneTb.ResetText();
                    AddressTb.ResetText();
                    GenderTb.SelectedIndex = 0;
                    SalaryTb.ResetText();
                }
                else
                {
                    MessageBox.Show("Please Enter a Teacher Id!", "Teacher Id is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grid.Rows[e.RowIndex];
                TeacherIDTb.Text = row.Cells["Id"].Value.ToString();
                NameTb.Text = row.Cells["Name"].Value.ToString();
                PhoneTb.Text = row.Cells["Phone"].Value.ToString();
                AddressTb.Text = row.Cells["Address"].Value.ToString();
                GenderTb.Text = row.Cells["Gender"].Value.ToString();
                SalaryTb.Text = row.Cells["Salary"].Value.ToString();
            }
        }
    }
}