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
    public partial class TeacherAttendanceUC : UserControl
    {
        private TeacherAttendance _teacherAttendance;
        private TeacherAttendancesService _teacherAttendanceService;
        public TeacherAttendanceUC()
        {
            InitializeComponent();
            _teacherAttendance = new TeacherAttendance();
            _teacherAttendanceService = new TeacherAttendancesService();
        }

        private void InsertTile_Click(object sender, EventArgs e)
        {
            InsertTile.color = Color.FromArgb(242, 242, 242);
            SelectTile.color = Color.Wheat;
            DeleteTile.color = Color.Wheat;
            UpdateTile.color = Color.Wheat;
            ViewTile.color = Color.Wheat;
            HideTile.color = Color.Wheat;
            grid.Visible = false;
            detailsGB.Visible = true;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
            InsertBtn.Visible = true;
            ClearBtn.Visible = false;
            searchBtn.Visible = false;
            IdTb.ResetText();
            TotalAttendanceTb.ResetText();
            PresentTb.ResetText();
            AbsenteesTb.ResetText();
        }

        private void SelectTile_Click(object sender, EventArgs e)
        {
            SelectTile.color = Color.FromArgb(242, 242, 242);
            InsertTile.color = Color.Wheat;
            DeleteTile.color = Color.Wheat;
            UpdateTile.color = Color.Wheat;
            ViewTile.color = Color.Wheat;
            HideTile.color = Color.Wheat;
            grid.Visible = false;
            detailsGB.Visible = true;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
            InsertBtn.Visible = false;
            ClearBtn.Visible = true;
            searchBtn.Visible = true;
        }

        private void UpdateTile_Click(object sender, EventArgs e)
        {
            UpdateTile.color = Color.FromArgb(242, 242, 242);
            InsertTile.color = Color.Wheat;
            DeleteTile.color = Color.Wheat;
            SelectTile.color = Color.Wheat;
            ViewTile.color = Color.Wheat;
            HideTile.color = Color.Wheat;
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
            grid.Visible = true;
            detailsGB.Visible = true;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
            InsertBtn.Visible = false;
            ClearBtn.Visible = false;
            searchBtn.Visible = false;
            var dataSource = _teacherAttendanceService.GetTeacherAttendancesDataTable();
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
            grid.Visible = false;
            detailsGB.Visible = false;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
            InsertBtn.Visible = false;
            ClearBtn.Visible = false;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (IdTb.Text != "" || TotalAttendanceTb.Text != "" || PresentTb.Text != "" || AbsenteesTb.Text != "")
            {
                _teacherAttendance.TeacherId = int.Parse(IdTb.Text);
                _teacherAttendance.Presence = int.Parse(PresentTb.Text);
                _teacherAttendance.Absentees = int.Parse(AbsenteesTb.Text);
                _teacherAttendance.TotalAttendance = int.Parse(TotalAttendanceTb.Text);
                _teacherAttendanceService.InsertTeacherAttendance(_teacherAttendance);
                MessageBox.Show("Record Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IdTb.ResetText();
                TotalAttendanceTb.ResetText();
                PresentTb.ResetText();
                AbsenteesTb.ResetText();
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
                IdTb.Text = row.Cells["Teacher_Id"].Value.ToString();
                TotalAttendanceTb.Text = row.Cells["Total_Attendance"].Value.ToString();
                PresentTb.Text = row.Cells["Presence"].Value.ToString();
                AbsenteesTb.Text = row.Cells["Absentees"].Value.ToString();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (IdTb.Text != "")
            {
                _teacherAttendance.TeacherId = int.Parse(IdTb.Text);
                var teacherAttendance = _teacherAttendanceService.GetTeacherAttendance(_teacherAttendance);
                TotalAttendanceTb.Text = teacherAttendance.TotalAttendance.ToString();
                PresentTb.Text = teacherAttendance.Presence.ToString();
                AbsenteesTb.Text = teacherAttendance.Absentees.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a Teacher Id!", "Teacher Id is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (TotalAttendanceTb.Text != "" || PresentTb.Text != "" || AbsenteesTb.Text != "")
            {
                if (IdTb.Text != "")
                {
                    _teacherAttendance.TeacherId = int.Parse(IdTb.Text);
                    _teacherAttendance.Presence = int.Parse(PresentTb.Text);
                    _teacherAttendance.Absentees = int.Parse(AbsenteesTb.Text);
                    _teacherAttendance.TotalAttendance = int.Parse(TotalAttendanceTb.Text);
                    _teacherAttendanceService.UpdateTeacherAttendance(_teacherAttendance);
                    MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IdTb.ResetText();
                    TotalAttendanceTb.ResetText();
                    PresentTb.ResetText();
                    AbsenteesTb.ResetText();
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (IdTb.Text != "")
            {
                _teacherAttendanceService.DeleteTeacherAttendance(int.Parse(IdTb.Text));
                MessageBox.Show("Record Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IdTb.ResetText();
                TotalAttendanceTb.ResetText();
                PresentTb.ResetText();
                AbsenteesTb.ResetText();
            }
            else
            {
                MessageBox.Show("Please Enter a Teacher Id!", "Teacher Id is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            IdTb.ResetText();
            TotalAttendanceTb.ResetText();
            PresentTb.ResetText();
            AbsenteesTb.ResetText();
        }
    }
}