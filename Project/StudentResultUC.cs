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
    public partial class StudentResultUC : UserControl
    {
        private StudentResult _studentResult;
        private StudentResultsService _studentResultService;
        public StudentResultUC()
        {
            InitializeComponent();
            _studentResult = new StudentResult();
            _studentResultService = new StudentResultsService();
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
            PercentageLbl.Visible = false;
            PercentageTb.Visible = false;
            RollNoTb.ResetText();
            TotalMarksTb.ResetText();
            ObtainedMarksTb.ResetText();
            PercentageTb.ResetText();
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
            PercentageLbl.Visible = false;
            PercentageTb.Visible = false;
            TotalMarksTb.ResetText();
            ObtainedMarksTb.ResetText();
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
            searchBtn.Visible = true;
            PercentageLbl.Visible = false;
            PercentageTb.Visible = false;
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
            searchBtn.Visible = true;
            PercentageTb.Visible = false;
            PercentageLbl.Visible = false;
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
            var dataSource = _studentResultService.GetStudentResultsDataTable();
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
            searchBtn.Visible = false;
            PercentageLbl.Visible = false;
            PercentageTb.Visible = false;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (TotalMarksTb.Text != "" || ObtainedMarksTb.Text != "")
            {
                if (RollNoTb.Text != "")
                {
                    _studentResult.StudentId = int.Parse(RollNoTb.Text);
                    _studentResult.TotalMarks = int.Parse(TotalMarksTb.Text);
                    _studentResult.ObtainedMarks = int.Parse(ObtainedMarksTb.Text);
                   var percentage = (float.Parse(ObtainedMarksTb.Text) / float.Parse(TotalMarksTb.Text)) * 100;
                    _studentResult.Percentage = Convert.ToInt32(percentage) + "%";
                    _studentResultService.InsertStudentResult(_studentResult);
                MessageBox.Show("Record Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RollNoTb.ResetText();
                TotalMarksTb.ResetText();
                ObtainedMarksTb.ResetText();
                }
                else
                {
                    MessageBox.Show("Please Enter Roll No.!", "Roll No. is not provided!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            RollNoTb.ResetText();
            TotalMarksTb.ResetText();
            ObtainedMarksTb.ResetText();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (RollNoTb.Text != "")
            {
                _studentResult.StudentId = int.Parse(RollNoTb.Text);
                var result = _studentResultService.GetStudentResult(_studentResult);
                TotalMarksTb.Text = result.TotalMarks.ToString();
                ObtainedMarksTb.Text = result.ObtainedMarks.ToString();
                PercentageLbl.Visible = true;
                PercentageTb.Visible = true;
                PercentageTb.Text = result.Percentage.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter Roll No.!", "Roll No. is not provided!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (RollNoTb.Text != "")
            {
                _studentResult.StudentId = int.Parse(RollNoTb.Text);
                _studentResultService.DeleteStudentResult(_studentResult.StudentId);
                MessageBox.Show("Record Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RollNoTb.ResetText();
                TotalMarksTb.ResetText();
                ObtainedMarksTb.ResetText();
            }
            else
            {
                MessageBox.Show("Please Enter Roll No.!", "Roll No. is not provided!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (TotalMarksTb.Text != "" || ObtainedMarksTb.Text != "")
            {
                if (RollNoTb.Text != "")
                {
                    _studentResult.StudentId = int.Parse(RollNoTb.Text);
                    _studentResult.TotalMarks = int.Parse(TotalMarksTb.Text);
                    _studentResult.ObtainedMarks = int.Parse(ObtainedMarksTb.Text);
                    double percentage = (double.Parse(ObtainedMarksTb.Text) / double.Parse(TotalMarksTb.Text)) * 100;
                    _studentResult.Percentage = Math.Round(percentage,2) + "%";
                    _studentResultService.UpdateStudentResult(_studentResult);
                    MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RollNoTb.ResetText();
                    TotalMarksTb.ResetText();
                    ObtainedMarksTb.ResetText();
                }
                else
                {
                    MessageBox.Show("Please Enter Roll No.!", "Roll No. is not provided!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                RollNoTb.Text = row.Cells["StudentId"].Value.ToString();
                TotalMarksTb.Text = row.Cells["TotalMarks"].Value.ToString();
                ObtainedMarksTb.Text = row.Cells["ObtainedMarks"].Value.ToString();
                PercentageTb.Text = row.Cells["Percentage"].Value.ToString();
            }
        }
        
    }
}
