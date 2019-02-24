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
    public partial class StudentUC : UserControl
    {
        private Student _student;
        private StudentsService _studentService;
        public StudentUC()
        {
            InitializeComponent();
            _student = new Student();
            _studentService = new StudentsService();
        }
        private void Student_Load(object sender, EventArgs e)
        {
            DOBvalue.Format = DateTimePickerFormat.Custom;
            DOBvalue.CustomFormat = "dd/MM/yyyy";
            AdminDateValue.Format = DateTimePickerFormat.Custom;
            AdminDateValue.CustomFormat = "dd/MM/yyyy";
            ClassTb.Text = "Select One";
            GenderTb.Text = "Select One";
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
            RollNoTb.ResetText();
            NameTb.ResetText();
            FatherNameTb.ResetText();
            GenderTb.Text = "Select One";
            PhoneTb.ResetText();
            AddressTb.ResetText();
            SessionTb.ResetText();
            AdminDateValue.ResetText();
            ClassTb.Text = "Select One";
            EmailTb.ResetText();
            DOBvalue.ResetText();
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
            var dataSource = _studentService.GetStudentsDataTable();
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
            if (NameTb.Text != "" || PhoneTb.Text != "" || AddressTb.Text != "" || FatherNameTb.Text != "" || PhoneTb.Text != "" || SessionTb.Text != "")
            {
                _student.Name = NameTb.Text;
                _student.FatherName = FatherNameTb.Text;
                _student.Phone = PhoneTb.Text;
                _student.Address = AddressTb.Text;
                _student.Session = SessionTb.Text;
                _student.Class = ClassTb.Text;
                _student.Email = EmailTb.Text;
                _student.Dob = DOBvalue.Value;
                _student.AdminDate = AdminDateValue.Value;
                _student.Gender = GenderTb.Text;
                _studentService.InsertStudent(_student);
                MessageBox.Show("Record Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RollNoTb.ResetText();
                NameTb.ResetText();
                FatherNameTb.ResetText();
                GenderTb.Text = "Select One";
                PhoneTb.ResetText();
                AddressTb.ResetText();
                SessionTb.ResetText();
                AdminDateValue.ResetText();
                ClassTb.Text = "Select One";
                EmailTb.ResetText();
                DOBvalue.ResetText();
            }
            else
            {
                MessageBox.Show("Please Fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            RollNoTb.ResetText();
            NameTb.ResetText();
            FatherNameTb.ResetText();
            GenderTb.Text = "Select One";
            PhoneTb.ResetText();
            AddressTb.ResetText();
            SessionTb.ResetText();
            AdminDateValue.ResetText();
            ClassTb.Text = "Select One";
            EmailTb.ResetText();
            DOBvalue.ResetText();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (RollNoTb.Text != "")
            {
                _student.Id = int.Parse(RollNoTb.Text);
                var student = _studentService.GetStudent(_student);
                NameTb.Text = student.Name;
                FatherNameTb.Text = student.FatherName;
                GenderTb.Text = student.Gender;
                PhoneTb.Text = student.Phone;
                AddressTb.Text = student.Address;
                SessionTb.Text = student.Session;
                AdminDateValue.Value = student.AdminDate;
                ClassTb.Text = student.Class;
                EmailTb.Text = student.Email;
                DOBvalue.Value = student.Dob;
            }
            else
            {
                MessageBox.Show("Please Enter a RollNo!", "RollNo. is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (RollNoTb.Text != "")
            {
                _studentService.DeleteStudent(int.Parse(RollNoTb.Text));
                MessageBox.Show("Record Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NameTb.ResetText();
                FatherNameTb.ResetText();
                GenderTb.Text = "Select One";
                PhoneTb.ResetText();
                AddressTb.ResetText();
                SessionTb.ResetText();
                AdminDateValue.ResetText();
                ClassTb.Text = "Select One";
                EmailTb.ResetText();
                DOBvalue.ResetText();
            }
            else
            {
                MessageBox.Show("Please Enter a RollNo!", "RollNo. is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text != "" || PhoneTb.Text != "" || AddressTb.Text != "" || FatherNameTb.Text != "" || PhoneTb.Text != "" || SessionTb.Text != "")
            {
                if (RollNoTb.Text != "")
                {
                    _student.Id = int.Parse(RollNoTb.Text);
                    _student.Name = NameTb.Text;
                    _student.FatherName = FatherNameTb.Text;
                    _student.Phone = PhoneTb.Text;
                    _student.Address = AddressTb.Text;
                    _student.Session = SessionTb.Text;
                    _student.Class = ClassTb.Text;
                    _student.Email = EmailTb.Text;
                    _student.Dob = DOBvalue.Value;
                    _student.AdminDate = AdminDateValue.Value;
                    _student.Gender = GenderTb.Text;
                    _studentService.UpdateStudent(_student);
                    MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RollNoTb.ResetText();
                    NameTb.ResetText();
                    FatherNameTb.ResetText();
                    GenderTb.Text = "Select One";
                    PhoneTb.ResetText();
                    AddressTb.ResetText();
                    SessionTb.ResetText();
                    AdminDateValue.ResetText();
                    ClassTb.Text = "Select One";
                    EmailTb.ResetText();
                    DOBvalue.ResetText();
                }
                else
                {
                    MessageBox.Show("Please Enter a RollNo!", "RollNo. is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                RollNoTb.Text = row.Cells["Id"].Value.ToString();
                NameTb.Text = row.Cells["Name"].Value.ToString();
                FatherNameTb.Text = row.Cells["FatherName"].Value.ToString();
                GenderTb.Text = row.Cells["Gender"].Value.ToString();
                PhoneTb.Text = row.Cells["Phone"].Value.ToString();
                AddressTb.Text = row.Cells["Address"].Value.ToString();
                SessionTb.Text = row.Cells["Session"].Value.ToString();
                AdminDateValue.Text = row.Cells["AdminDate"].Value.ToString();
                ClassTb.Text = row.Cells["Class"].Value.ToString();
                EmailTb.Text = row.Cells["Email"].Value.ToString();
                DOBvalue.Text = row.Cells["DOB"].Value.ToString();
            }
        }
    }
}
