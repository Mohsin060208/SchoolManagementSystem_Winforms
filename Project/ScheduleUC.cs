using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.DAL;
using SMS.Model;

namespace SMS
{
    public partial class ScheduleUC : UserControl
    {
        private TimeTable _timeTable;
        private TimeTablesService _timeTableService;
        public ScheduleUC()
        {
            InitializeComponent();
            _timeTable = new TimeTable();
            _timeTableService = new TimeTablesService();
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
            Searchbtn.Visible = false;
            TeacherIdTb.ResetText();
            MondayTb.ResetText();
            TuesdayTb.ResetText();
            WednesdayTb.ResetText();
            ThursdayTb.ResetText();
            FridayTb.ResetText();
            SaturdayTb.ResetText();
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
            Searchbtn.Visible = true;
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
            Searchbtn.Visible = false;
            var dataSource = _timeTableService.GetTimeTablesDataTable();
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

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (TeacherIdTb.Text != "")
            {
                _timeTable.TeacherId = int.Parse(TeacherIdTb.Text);
                var timetable = _timeTableService.GetTimeTable(_timeTable);
                MondayTb.Text = timetable.Monday;
                TuesdayTb.Text = timetable.Tuesday;
                WednesdayTb.Text = timetable.Wednesday;
                ThursdayTb.Text = timetable.Thursday;
                FridayTb.Text = timetable.Friday;
                SaturdayTb.Text = timetable.Saturday;
            }
            else
            {
                MessageBox.Show("Please Enter a Teacher Id!", "Teacher Id is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TeacherIdTb.ResetText();
            MondayTb.ResetText();
            TuesdayTb.ResetText();
            WednesdayTb.ResetText();
            ThursdayTb.ResetText();
            FridayTb.ResetText();
            SaturdayTb.ResetText();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (TeacherIdTb.Text != "")
            {
                _timeTableService.DeleteTimeTable(int.Parse(TeacherIdTb.Text));
                MessageBox.Show("Record Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TeacherIdTb.ResetText();
                MondayTb.ResetText();
                TuesdayTb.ResetText();
                WednesdayTb.ResetText();
                ThursdayTb.ResetText();
                FridayTb.ResetText();
                SaturdayTb.ResetText();
            }
            else
            {
                MessageBox.Show("Please Enter a Teacher Id!", "Teacher Id is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (MondayTb.Text != "" || TuesdayTb.Text != "" || WednesdayTb.Text != "" || ThursdayTb.Text != "" || FridayTb.Text != "")
            {
                if (TeacherIdTb.Text != "")
                {
                    _timeTable.TeacherId = int.Parse(TeacherIdTb.Text);
                    _timeTable.Monday = MondayTb.Text;
                    _timeTable.Tuesday = TuesdayTb.Text;
                    _timeTable.Wednesday = WednesdayTb.Text;
                    _timeTable.Thursday = ThursdayTb.Text;
                    _timeTable.Friday = FridayTb.Text;
                    _timeTable.Saturday = SaturdayTb.Text;
                    _timeTableService.UpdateTimeTable(_timeTable);
                    MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TeacherIdTb.ResetText();
                    MondayTb.ResetText();
                    TuesdayTb.ResetText();
                    WednesdayTb.ResetText();
                    ThursdayTb.ResetText();
                    FridayTb.ResetText();
                    SaturdayTb.ResetText();
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

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (TeacherIdTb.Text != "")
            {
                _timeTable.TeacherId = int.Parse(TeacherIdTb.Text);
                _timeTable.Monday = MondayTb.Text;
                _timeTable.Tuesday = TuesdayTb.Text;
                _timeTable.Wednesday = WednesdayTb.Text;
                _timeTable.Thursday = ThursdayTb.Text;
                _timeTable.Friday = FridayTb.Text;
                _timeTable.Saturday = SaturdayTb.Text;
                _timeTableService.InsertTimeTable(_timeTable);
                MessageBox.Show("Record Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TeacherIdTb.ResetText();
                MondayTb.ResetText();
                TuesdayTb.ResetText();
                WednesdayTb.ResetText();
                ThursdayTb.ResetText();
                FridayTb.ResetText();
                SaturdayTb.ResetText();
            }
            else
            {
                MessageBox.Show("Please Enter a Teacher Id!", "Teacher Id is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grid.Rows[e.RowIndex];
                TeacherIdTb.Text = row.Cells["Teacher_Id"].Value.ToString();
                MondayTb.Text = row.Cells["Monday"].Value.ToString();
                TuesdayTb.Text = row.Cells["Tuesday"].Value.ToString();
                WednesdayTb.Text = row.Cells["Wednesday"].Value.ToString();
                ThursdayTb.Text = row.Cells["Thursday"].Value.ToString();
                FridayTb.Text = row.Cells["Friday"].Value.ToString();
                SaturdayTb.Text = row.Cells["Saturday"].Value.ToString();
            }
        }
    }
}
