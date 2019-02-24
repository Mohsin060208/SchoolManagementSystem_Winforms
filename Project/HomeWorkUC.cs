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
    public partial class HomeWorkUC : UserControl
    {
        private HomeWork _homeWork;
        private HomeWorksService _homeWorkService;
        public HomeWorkUC()
        {
            InitializeComponent();
            _homeWork = new HomeWork();
            _homeWorkService = new HomeWorksService();
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
            RollNoTb.ResetText();
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
            var dataSource = _homeWorkService.GetHomeWorksDataTable();
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
            if (RollNoTb.Text != "")
            {
                _homeWork.StudentId = int.Parse(RollNoTb.Text);
                var HomeWork = _homeWorkService.GetHomeWork(_homeWork);
                MondayTb.Text = HomeWork.Monday;
                TuesdayTb.Text = HomeWork.Tuesday;
                WednesdayTb.Text = HomeWork.Wednesday;
                ThursdayTb.Text = HomeWork.Thursday;
                FridayTb.Text = HomeWork.Friday;
                SaturdayTb.Text = HomeWork.Saturday;
            }
            else
            {
                MessageBox.Show("Please Enter a Roll Number!", "Roll Number is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            RollNoTb.ResetText();
            MondayTb.ResetText();
            TuesdayTb.ResetText();
            WednesdayTb.ResetText();
            ThursdayTb.ResetText();
            FridayTb.ResetText();
            SaturdayTb.ResetText();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (RollNoTb.Text != "")
            {
                _homeWorkService.DeleteHomeWork(int.Parse(RollNoTb.Text));
                MessageBox.Show("Record Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RollNoTb.ResetText();
                MondayTb.ResetText();
                TuesdayTb.ResetText();
                WednesdayTb.ResetText();
                ThursdayTb.ResetText();
                FridayTb.ResetText();
                SaturdayTb.ResetText();
            }
            else
            {
                MessageBox.Show("Please Enter a Roll Number!", "Roll Number is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (MondayTb.Text != "" || TuesdayTb.Text != "" || WednesdayTb.Text != "" || ThursdayTb.Text != "" || FridayTb.Text != "")
            {
                if (RollNoTb.Text != "")
                {
                _homeWork.StudentId = int.Parse(RollNoTb.Text);
                _homeWork.Monday = MondayTb.Text;
                _homeWork.Tuesday = TuesdayTb.Text;
                _homeWork.Wednesday = WednesdayTb.Text;
                _homeWork.Thursday = ThursdayTb.Text;
                _homeWork.Friday = FridayTb.Text;
                _homeWork.Saturday = SaturdayTb.Text;
                _homeWorkService.UpdateHomeWork(_homeWork);
                MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RollNoTb.ResetText();
                MondayTb.ResetText();
                TuesdayTb.ResetText();
                WednesdayTb.ResetText();
                ThursdayTb.ResetText();
                FridayTb.ResetText();
                SaturdayTb.ResetText();
                }
                else
                {
                    MessageBox.Show("Please Enter a Roll Number!", "Roll Number is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
                if (RollNoTb.Text != "")
                {
                _homeWork.StudentId = int.Parse(RollNoTb.Text);
                _homeWork.Monday = MondayTb.Text;
                _homeWork.Tuesday = TuesdayTb.Text;
                _homeWork.Wednesday = WednesdayTb.Text;
                _homeWork.Thursday = ThursdayTb.Text;
                _homeWork.Friday = FridayTb.Text;
                _homeWork.Saturday = SaturdayTb.Text;
                _homeWorkService.InsertHomeWork(_homeWork);
                MessageBox.Show("Record Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RollNoTb.ResetText();
                MondayTb.ResetText();
                TuesdayTb.ResetText();
                WednesdayTb.ResetText();
                ThursdayTb.ResetText();
                FridayTb.ResetText();
                SaturdayTb.ResetText();
                }
                else
                {
                    MessageBox.Show("Please Enter a Roll Number!", "Roll Number is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grid.Rows[e.RowIndex];
                RollNoTb.Text = row.Cells["Student_Id"].Value.ToString();
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
