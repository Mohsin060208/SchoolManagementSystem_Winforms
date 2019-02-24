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
    public partial class MainForm : Form
    {
        private Authorization _authorization;
        private StudentAttendanceUC _studentAttendance;
        private StudentResultUC _studentResult;
        private StudentFeeUC _studentFee;
        private HomeWorkUC _homework;
        private StudentUC _student;
        private ScheduleUC _schedule;
        private TeacherAttendanceUC _teacherAttendance;
        private TeacherUC _teacher;
        public MainForm()
        {
            InitializeComponent();
        }

        private void teacherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Content.Visible = false;
            Modules_Panel.Visible = true;
            FeeTile.Visible = false;
            ResultTile.Visible = false;
            StudentTile.Visible = false;
            StudentAttendanceTile.Visible = false;
            TeacherTile.Visible = true;
            TeacherAttendanceTile.Visible = true;
            ScheduleTile.Visible = true;
            HomeWorkTile.Visible = false;
            TeacherTile.color = Color.Wheat;
            TeacherAttendanceTile.color = Color.Wheat;
            ScheduleTile.color = Color.Wheat;
        }
        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Content.Visible = false;
            Modules_Panel.Visible = true;
            FeeTile.Visible = true;
            ResultTile.Visible = true;
            StudentTile.Visible = true;
            StudentAttendanceTile.Visible = true;
            TeacherTile.Visible = false;
            TeacherAttendanceTile.Visible = false;
            ScheduleTile.Visible = false;
            HomeWorkTile.Visible = true;
            StudentAttendanceTile.color = Color.Wheat;
            HomeWorkTile.color = Color.Wheat;
            ResultTile.color = Color.Wheat;
            FeeTile.color = Color.Wheat;
            StudentTile.color = Color.Wheat;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Teacherbtn_Click(object sender, EventArgs e)
        {
            _teacher = new TeacherUC();
            TeacherTile.color = Color.FromArgb(242, 242, 242);
            TeacherAttendanceTile.color = Color.Wheat;
            ScheduleTile.color = Color.Wheat;
            navigator(_teacher);
        }
        private void navigator(UserControl uc)
        {
            Content.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            Content.Controls.Add(uc);
            Content.Visible = true;
        }

        private void TeacherAttendanceTile_Click(object sender, EventArgs e)
        {
            _teacherAttendance = new TeacherAttendanceUC();
            TeacherTile.color = Color.Wheat;
            TeacherAttendanceTile.color = Color.FromArgb(242, 242, 242);
            ScheduleTile.color = Color.Wheat;
            navigator(_teacherAttendance);
        }

        private void ScheduleTile_Click(object sender, EventArgs e)
        {
            _schedule = new ScheduleUC();
            TeacherTile.color = Color.Wheat;
            ScheduleTile.color = Color.FromArgb(242, 242, 242);
            TeacherAttendanceTile.color = Color.Wheat;
            navigator(_schedule);
        }

        private void StudentTile_Click(object sender, EventArgs e)
        {
            _student = new StudentUC();
            StudentTile.color = Color.FromArgb(242, 242, 242);
            HomeWorkTile.color = Color.Wheat;
            ResultTile.color = Color.Wheat;
            FeeTile.color = Color.Wheat;
            StudentAttendanceTile.color = Color.Wheat;
            navigator(_student);
        }

        private void HomeWorkTile_Click(object sender, EventArgs e)
        {
            _homework = new HomeWorkUC();
            HomeWorkTile.color = Color.FromArgb(242, 242, 242);
            StudentTile.color = Color.Wheat;
            ResultTile.color = Color.Wheat;
            FeeTile.color = Color.Wheat;
            StudentAttendanceTile.color = Color.Wheat;
            navigator(_homework);
        }

        private void FeeTile_Click(object sender, EventArgs e)
        {
            _studentFee = new StudentFeeUC();
            FeeTile.color = Color.FromArgb(242, 242, 242);
            HomeWorkTile.color = Color.Wheat;
            ResultTile.color = Color.Wheat;
            StudentTile.color = Color.Wheat;
            StudentAttendanceTile.color = Color.Wheat;
            navigator(_studentFee);
        }

        private void ResultTile_Click(object sender, EventArgs e)
        {
            _studentResult = new StudentResultUC();
            ResultTile.color = Color.FromArgb(242, 242, 242);
            HomeWorkTile.color = Color.Wheat;
            StudentTile.color = Color.Wheat;
            FeeTile.color = Color.Wheat;
            navigator(_studentResult);
        }

        private void StudentAttendanceTile_Click(object sender, EventArgs e)
        {
            _studentAttendance = new StudentAttendanceUC();
            StudentAttendanceTile.color = Color.FromArgb(242, 242, 242);
            HomeWorkTile.color = Color.Wheat;
            ResultTile.color = Color.Wheat;
            FeeTile.color = Color.Wheat;
            StudentTile.color = Color.Wheat;
            navigator(_studentAttendance);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Verify Your Credentials!","Authorization Required");
            this.Hide();
            _authorization.ShowDialog();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _authorization = new Authorization();
        }
    }
}
