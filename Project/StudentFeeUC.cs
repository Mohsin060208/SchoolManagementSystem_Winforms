using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.Model;
using SMS.DAL;

namespace SMS
{
    public partial class StudentFeeUC : UserControl
    {
        private StudentFee _studentFee;
        private StudentFeesService _studentFeeService;
        public StudentFeeUC()
        {
            InitializeComponent();
            _studentFee = new StudentFee();
            _studentFeeService = new StudentFeesService();
            
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
            RollNoTb.ResetText();
            TransportDuesTb.ResetText();
            PaperDuesTb.ResetText();
            FineTb.ResetText();
            DueDateValue.ResetText();
            LastDateValue.ResetText();
            TotalFeeTb.ResetText();
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
            var dataSource = _studentFeeService.GetStudentFeesDataTable();
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
            if (TotalFeeTb.Text != "")
            {
                if (RollNoTb.Text != "")
                {
                    _studentFee.DueDate = DueDateValue.Value;
                    _studentFee.LastDate = LastDateValue.Value;
                    _studentFee.StudentId = int.Parse(RollNoTb.Text);
                    _studentFee.RemainingDues = int.Parse(RemainingDuesTb.Text);
                    _studentFee.TransportDues = int.Parse(TransportDuesTb.Text);
                    _studentFee.TotalFee = int.Parse(TotalFeeTb.Text);
                    _studentFee.Fine = int.Parse(FineTb.Text);
                    _studentFeeService.InsertStudentFee(_studentFee);
                    MessageBox.Show("Record Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TransportDuesTb.ResetText();
                    PaperDuesTb.ResetText();
                    FineTb.ResetText();
                    DueDateValue.ResetText();
                    LastDateValue.ResetText();
                    TotalFeeTb.ResetText();
                    RemainingDuesTb.ResetText();
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
            TransportDuesTb.ResetText();
            PaperDuesTb.ResetText();
            FineTb.ResetText();
            DueDateValue.ResetText();
            LastDateValue.ResetText();
            TotalFeeTb.ResetText();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (RollNoTb.Text != "")
            {
                _studentFee.StudentId = int.Parse(RollNoTb.Text);
                var studentFee = _studentFeeService.GetStudentFee(_studentFee);
                DueDateValue.Value = studentFee.DueDate;
                LastDateValue.Value = studentFee.LastDate;
                FineTb.Text = studentFee.Fine.ToString();
                TotalFeeTb.Text = studentFee.TotalFee.ToString();
                TransportDuesTb.Text = studentFee.TransportDues.ToString();
                RemainingDuesTb.Text = studentFee.RemainingDues.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a Roll Number!", "Roll Number is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (RollNo.Text != "")
            {
                _studentFeeService.DeleteStudentFee(int.Parse(RollNoTb.Text));
                MessageBox.Show("Record Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RollNoTb.ResetText();
                TransportDuesTb.ResetText();
                PaperDuesTb.ResetText();
                FineTb.ResetText();
                DueDateValue.ResetText();
                LastDateValue.ResetText();
                TotalFeeTb.ResetText();
            }
            else
            {
                MessageBox.Show("Please Enter a Roll Number!", "Roll Number is not provided", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (TotalFeeTb.Text != "")
            {
                if (RollNoTb.Text != "")
                {
                    _studentFee.DueDate = DueDateValue.Value;
                    _studentFee.LastDate = LastDateValue.Value;
                    _studentFee.StudentId = int.Parse(RollNoTb.Text);
                    _studentFee.RemainingDues = int.Parse(RemainingDuesTb.Text);
                    _studentFee.TransportDues = int.Parse(TransportDuesTb.Text);
                    _studentFee.TotalFee = int.Parse(TotalFeeTb.Text);
                    _studentFee.Fine = int.Parse(FineTb.Text);
                    _studentFeeService.UpdateStudentFee(_studentFee);
                    MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TransportDuesTb.ResetText();
                    PaperDuesTb.ResetText();
                    FineTb.ResetText();
                    DueDateValue.ResetText();
                    LastDateValue.ResetText();
                    TotalFeeTb.ResetText();
                    RemainingDuesTb.ResetText();
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
                RollNoTb.Text = row.Cells["Id"].Value.ToString();
                TotalFeeTb.Text = row.Cells["Total_Fee"].Value.ToString();
                FineTb.Text = row.Cells["Fine"].Value.ToString();
                DueDateValue.Text = row.Cells["Due_Date"].Value.ToString();
                LastDateValue.Text = row.Cells["Last_Date"].Value.ToString();
                TransportDuesTb.Text = row.Cells["Transport_Dues"].Value.ToString();
                RemainingDuesTb.Text = row.Cells["Remaining_Dues"].Value.ToString();
            }
        }

        private void StudentFeeUC_Load(object sender, EventArgs e)
        {
            DueDateValue.Format = DateTimePickerFormat.Custom;
            DueDateValue.CustomFormat = "dd/mm/yyyy";
            LastDateValue.Format = DateTimePickerFormat.Custom;
            LastDateValue.CustomFormat = "dd/mm/yyyy";
        }
    }
}
