namespace SMS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.Content = new System.Windows.Forms.Panel();
            this.Modules_Panel = new System.Windows.Forms.Panel();
            this.TeacherAttendanceTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.HomeWorkTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.ScheduleTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.TeacherTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.ResultTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.FeeTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.StudentAttendanceTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.StudentTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.Modules_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.logoutToolStripMenuItem.Text = "logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.versionToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.aboutToolStripMenuItem.Text = "About SMS";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // studentInformationToolStripMenuItem
            // 
            this.studentInformationToolStripMenuItem.Name = "studentInformationToolStripMenuItem";
            this.studentInformationToolStripMenuItem.Size = new System.Drawing.Size(172, 23);
            this.studentInformationToolStripMenuItem.Text = "Student Information";
            this.studentInformationToolStripMenuItem.Click += new System.EventHandler(this.studentInformationToolStripMenuItem_Click);
            // 
            // teacherInformationToolStripMenuItem
            // 
            this.teacherInformationToolStripMenuItem.Name = "teacherInformationToolStripMenuItem";
            this.teacherInformationToolStripMenuItem.Size = new System.Drawing.Size(173, 23);
            this.teacherInformationToolStripMenuItem.Text = "Teacher Information";
            this.teacherInformationToolStripMenuItem.Click += new System.EventHandler(this.teacherInformationToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherInformationToolStripMenuItem,
            this.studentInformationToolStripMenuItem,
            this.versionToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.adminPanelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 27);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminPanelToolStripMenuItem
            // 
            this.adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            this.adminPanelToolStripMenuItem.Size = new System.Drawing.Size(117, 23);
            this.adminPanelToolStripMenuItem.Text = "Admin Panel";
            this.adminPanelToolStripMenuItem.Click += new System.EventHandler(this.adminPanelToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dashboardPanel);
            this.mainPanel.Controls.Add(this.menuStrip1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(924, 661);
            this.mainPanel.TabIndex = 1;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.Transparent;
            this.dashboardPanel.BackgroundImage = global::SMS.Properties.Resources.mainfrm;
            this.dashboardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardPanel.Controls.Add(this.Content);
            this.dashboardPanel.Controls.Add(this.Modules_Panel);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 27);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(924, 634);
            this.dashboardPanel.TabIndex = 32;
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.Transparent;
            this.Content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 83);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(924, 551);
            this.Content.TabIndex = 56;
            this.Content.Visible = false;
            // 
            // Modules_Panel
            // 
            this.Modules_Panel.BackColor = System.Drawing.Color.YellowGreen;
            this.Modules_Panel.Controls.Add(this.TeacherAttendanceTile);
            this.Modules_Panel.Controls.Add(this.HomeWorkTile);
            this.Modules_Panel.Controls.Add(this.ScheduleTile);
            this.Modules_Panel.Controls.Add(this.TeacherTile);
            this.Modules_Panel.Controls.Add(this.ResultTile);
            this.Modules_Panel.Controls.Add(this.FeeTile);
            this.Modules_Panel.Controls.Add(this.StudentAttendanceTile);
            this.Modules_Panel.Controls.Add(this.StudentTile);
            this.Modules_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Modules_Panel.Location = new System.Drawing.Point(0, 0);
            this.Modules_Panel.Name = "Modules_Panel";
            this.Modules_Panel.Size = new System.Drawing.Size(924, 83);
            this.Modules_Panel.TabIndex = 54;
            this.Modules_Panel.Visible = false;
            // 
            // TeacherAttendanceTile
            // 
            this.TeacherAttendanceTile.BackColor = System.Drawing.Color.Wheat;
            this.TeacherAttendanceTile.color = System.Drawing.Color.Wheat;
            this.TeacherAttendanceTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TeacherAttendanceTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeacherAttendanceTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherAttendanceTile.ForeColor = System.Drawing.Color.Black;
            this.TeacherAttendanceTile.Image = global::SMS.Properties.Resources.attendance;
            this.TeacherAttendanceTile.ImagePosition = 0;
            this.TeacherAttendanceTile.ImageZoom = 40;
            this.TeacherAttendanceTile.LabelPosition = 26;
            this.TeacherAttendanceTile.LabelText = "Attendance";
            this.TeacherAttendanceTile.Location = new System.Drawing.Point(124, 6);
            this.TeacherAttendanceTile.Margin = new System.Windows.Forms.Padding(6);
            this.TeacherAttendanceTile.Name = "TeacherAttendanceTile";
            this.TeacherAttendanceTile.Size = new System.Drawing.Size(114, 71);
            this.TeacherAttendanceTile.TabIndex = 7;
            this.TeacherAttendanceTile.Click += new System.EventHandler(this.TeacherAttendanceTile_Click);
            // 
            // HomeWorkTile
            // 
            this.HomeWorkTile.BackColor = System.Drawing.Color.Wheat;
            this.HomeWorkTile.color = System.Drawing.Color.Wheat;
            this.HomeWorkTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.HomeWorkTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeWorkTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeWorkTile.ForeColor = System.Drawing.Color.Black;
            this.HomeWorkTile.Image = global::SMS.Properties.Resources.Schedule;
            this.HomeWorkTile.ImagePosition = 0;
            this.HomeWorkTile.ImageZoom = 40;
            this.HomeWorkTile.LabelPosition = 26;
            this.HomeWorkTile.LabelText = "HomeWork";
            this.HomeWorkTile.Location = new System.Drawing.Point(123, 6);
            this.HomeWorkTile.Margin = new System.Windows.Forms.Padding(6);
            this.HomeWorkTile.Name = "HomeWorkTile";
            this.HomeWorkTile.Size = new System.Drawing.Size(114, 71);
            this.HomeWorkTile.TabIndex = 7;
            this.HomeWorkTile.Click += new System.EventHandler(this.HomeWorkTile_Click);
            // 
            // ScheduleTile
            // 
            this.ScheduleTile.BackColor = System.Drawing.Color.Wheat;
            this.ScheduleTile.color = System.Drawing.Color.Wheat;
            this.ScheduleTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ScheduleTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScheduleTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleTile.ForeColor = System.Drawing.Color.Black;
            this.ScheduleTile.Image = global::SMS.Properties.Resources.Schedule;
            this.ScheduleTile.ImagePosition = 0;
            this.ScheduleTile.ImageZoom = 40;
            this.ScheduleTile.LabelPosition = 26;
            this.ScheduleTile.LabelText = "Schedule";
            this.ScheduleTile.Location = new System.Drawing.Point(240, 6);
            this.ScheduleTile.Margin = new System.Windows.Forms.Padding(6);
            this.ScheduleTile.Name = "ScheduleTile";
            this.ScheduleTile.Size = new System.Drawing.Size(114, 71);
            this.ScheduleTile.TabIndex = 7;
            this.ScheduleTile.Click += new System.EventHandler(this.ScheduleTile_Click);
            // 
            // TeacherTile
            // 
            this.TeacherTile.BackColor = System.Drawing.Color.Wheat;
            this.TeacherTile.color = System.Drawing.Color.Wheat;
            this.TeacherTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TeacherTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeacherTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherTile.ForeColor = System.Drawing.Color.Black;
            this.TeacherTile.Image = global::SMS.Properties.Resources.teacher;
            this.TeacherTile.ImagePosition = 0;
            this.TeacherTile.ImageZoom = 40;
            this.TeacherTile.LabelPosition = 26;
            this.TeacherTile.LabelText = "Teacher";
            this.TeacherTile.Location = new System.Drawing.Point(7, 6);
            this.TeacherTile.Margin = new System.Windows.Forms.Padding(6);
            this.TeacherTile.Name = "TeacherTile";
            this.TeacherTile.Size = new System.Drawing.Size(114, 71);
            this.TeacherTile.TabIndex = 6;
            this.TeacherTile.Click += new System.EventHandler(this.Teacherbtn_Click);
            // 
            // ResultTile
            // 
            this.ResultTile.BackColor = System.Drawing.Color.Wheat;
            this.ResultTile.color = System.Drawing.Color.Wheat;
            this.ResultTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ResultTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResultTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTile.ForeColor = System.Drawing.Color.Black;
            this.ResultTile.Image = global::SMS.Properties.Resources.result;
            this.ResultTile.ImagePosition = 0;
            this.ResultTile.ImageZoom = 40;
            this.ResultTile.LabelPosition = 27;
            this.ResultTile.LabelText = "Result";
            this.ResultTile.Location = new System.Drawing.Point(473, 6);
            this.ResultTile.Margin = new System.Windows.Forms.Padding(6);
            this.ResultTile.Name = "ResultTile";
            this.ResultTile.Size = new System.Drawing.Size(114, 71);
            this.ResultTile.TabIndex = 4;
            this.ResultTile.Click += new System.EventHandler(this.ResultTile_Click);
            // 
            // FeeTile
            // 
            this.FeeTile.BackColor = System.Drawing.Color.Wheat;
            this.FeeTile.color = System.Drawing.Color.Wheat;
            this.FeeTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.FeeTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FeeTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeTile.ForeColor = System.Drawing.Color.Black;
            this.FeeTile.Image = global::SMS.Properties.Resources.fee;
            this.FeeTile.ImagePosition = 0;
            this.FeeTile.ImageZoom = 40;
            this.FeeTile.LabelPosition = 27;
            this.FeeTile.LabelText = "Fee";
            this.FeeTile.Location = new System.Drawing.Point(357, 6);
            this.FeeTile.Margin = new System.Windows.Forms.Padding(6);
            this.FeeTile.Name = "FeeTile";
            this.FeeTile.Size = new System.Drawing.Size(114, 71);
            this.FeeTile.TabIndex = 3;
            this.FeeTile.Click += new System.EventHandler(this.FeeTile_Click);
            // 
            // StudentAttendanceTile
            // 
            this.StudentAttendanceTile.BackColor = System.Drawing.Color.Wheat;
            this.StudentAttendanceTile.color = System.Drawing.Color.Wheat;
            this.StudentAttendanceTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.StudentAttendanceTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentAttendanceTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentAttendanceTile.ForeColor = System.Drawing.Color.Black;
            this.StudentAttendanceTile.Image = global::SMS.Properties.Resources.attendance;
            this.StudentAttendanceTile.ImagePosition = 0;
            this.StudentAttendanceTile.ImageZoom = 40;
            this.StudentAttendanceTile.LabelPosition = 27;
            this.StudentAttendanceTile.LabelText = "Attendance";
            this.StudentAttendanceTile.Location = new System.Drawing.Point(240, 6);
            this.StudentAttendanceTile.Margin = new System.Windows.Forms.Padding(6);
            this.StudentAttendanceTile.Name = "StudentAttendanceTile";
            this.StudentAttendanceTile.Size = new System.Drawing.Size(114, 71);
            this.StudentAttendanceTile.TabIndex = 2;
            this.StudentAttendanceTile.Click += new System.EventHandler(this.StudentAttendanceTile_Click);
            // 
            // StudentTile
            // 
            this.StudentTile.BackColor = System.Drawing.Color.Wheat;
            this.StudentTile.color = System.Drawing.Color.Wheat;
            this.StudentTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.StudentTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentTile.ForeColor = System.Drawing.Color.Black;
            this.StudentTile.Image = global::SMS.Properties.Resources.student;
            this.StudentTile.ImagePosition = 0;
            this.StudentTile.ImageZoom = 40;
            this.StudentTile.LabelPosition = 27;
            this.StudentTile.LabelText = "Student";
            this.StudentTile.Location = new System.Drawing.Point(6, 6);
            this.StudentTile.Margin = new System.Windows.Forms.Padding(6);
            this.StudentTile.Name = "StudentTile";
            this.StudentTile.Size = new System.Drawing.Size(114, 71);
            this.StudentTile.TabIndex = 0;
            this.StudentTile.Click += new System.EventHandler(this.StudentTile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.dashboardPanel.ResumeLayout(false);
            this.Modules_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherInformationToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Bunifu.Framework.UI.BunifuTileButton ResultTile;
        private Bunifu.Framework.UI.BunifuTileButton FeeTile;
        private Bunifu.Framework.UI.BunifuTileButton StudentAttendanceTile;
        private Bunifu.Framework.UI.BunifuTileButton StudentTile;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Panel Modules_Panel;
        private System.Windows.Forms.Panel mainPanel;
        private Bunifu.Framework.UI.BunifuTileButton ScheduleTile;
        private Bunifu.Framework.UI.BunifuTileButton TeacherAttendanceTile;
        private Bunifu.Framework.UI.BunifuTileButton TeacherTile;
        private Bunifu.Framework.UI.BunifuTileButton HomeWorkTile;
        private System.Windows.Forms.ToolStripMenuItem adminPanelToolStripMenuItem;
    }
}