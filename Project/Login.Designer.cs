namespace SMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsernameGb = new System.Windows.Forms.GroupBox();
            this.Username_tb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Username = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PasswordGb = new System.Windows.Forms.GroupBox();
            this.Password = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Password_tb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cancelbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UpdateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SearchBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Exit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LoginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ForgetPwd = new System.Windows.Forms.LinkLabel();
            this.CPassGb = new System.Windows.Forms.GroupBox();
            this.cPwd_tb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cPwd_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.NickLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.NickTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.RecoveryGb = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UsernameGb.SuspendLayout();
            this.PasswordGb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.CPassGb.SuspendLayout();
            this.RecoveryGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 512);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UsernameGb
            // 
            this.UsernameGb.Controls.Add(this.Username_tb);
            this.UsernameGb.Controls.Add(this.Username);
            this.UsernameGb.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsernameGb.Location = new System.Drawing.Point(371, 0);
            this.UsernameGb.Name = "UsernameGb";
            this.UsernameGb.Size = new System.Drawing.Size(435, 100);
            this.UsernameGb.TabIndex = 29;
            this.UsernameGb.TabStop = false;
            // 
            // Username_tb
            // 
            this.Username_tb.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Username_tb.BorderColorIdle = System.Drawing.Color.Lavender;
            this.Username_tb.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Username_tb.BorderThickness = 1;
            this.Username_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Username_tb.ForeColor = System.Drawing.Color.Lavender;
            this.Username_tb.isPassword = false;
            this.Username_tb.Location = new System.Drawing.Point(63, 39);
            this.Username_tb.Margin = new System.Windows.Forms.Padding(4);
            this.Username_tb.Name = "Username_tb";
            this.Username_tb.Size = new System.Drawing.Size(328, 36);
            this.Username_tb.TabIndex = 25;
            this.Username_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Black;
            this.Username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Lavender;
            this.Username.Location = new System.Drawing.Point(58, 16);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(87, 19);
            this.Username.TabIndex = 23;
            this.Username.Text = "Username";
            // 
            // PasswordGb
            // 
            this.PasswordGb.Controls.Add(this.Password);
            this.PasswordGb.Controls.Add(this.Password_tb);
            this.PasswordGb.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasswordGb.Location = new System.Drawing.Point(371, 100);
            this.PasswordGb.Name = "PasswordGb";
            this.PasswordGb.Size = new System.Drawing.Size(435, 100);
            this.PasswordGb.TabIndex = 30;
            this.PasswordGb.TabStop = false;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Black;
            this.Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Lavender;
            this.Password.Location = new System.Drawing.Point(58, 16);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(86, 19);
            this.Password.TabIndex = 26;
            this.Password.Text = "Password";
            // 
            // Password_tb
            // 
            this.Password_tb.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Password_tb.BorderColorIdle = System.Drawing.Color.Lavender;
            this.Password_tb.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Password_tb.BorderThickness = 1;
            this.Password_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Password_tb.ForeColor = System.Drawing.Color.Lavender;
            this.Password_tb.isPassword = true;
            this.Password_tb.Location = new System.Drawing.Point(60, 39);
            this.Password_tb.Margin = new System.Windows.Forms.Padding(4);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.Size = new System.Drawing.Size(328, 36);
            this.Password_tb.TabIndex = 25;
            this.Password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cancelbtn);
            this.groupBox1.Controls.Add(this.UpdateBtn);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.Exit);
            this.groupBox1.Controls.Add(this.LoginBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(371, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 112);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.ActiveBorderThickness = 1;
            this.Cancelbtn.ActiveCornerRadius = 20;
            this.Cancelbtn.ActiveFillColor = System.Drawing.Color.Black;
            this.Cancelbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Cancelbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.Cancelbtn.BackColor = System.Drawing.Color.Black;
            this.Cancelbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancelbtn.BackgroundImage")));
            this.Cancelbtn.ButtonText = "Cancel";
            this.Cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelbtn.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.ForeColor = System.Drawing.Color.Black;
            this.Cancelbtn.IdleBorderThickness = 1;
            this.Cancelbtn.IdleCornerRadius = 20;
            this.Cancelbtn.IdleFillColor = System.Drawing.Color.White;
            this.Cancelbtn.IdleForecolor = System.Drawing.Color.Black;
            this.Cancelbtn.IdleLineColor = System.Drawing.Color.White;
            this.Cancelbtn.Location = new System.Drawing.Point(267, 20);
            this.Cancelbtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(123, 37);
            this.Cancelbtn.TabIndex = 35;
            this.Cancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancelbtn.Visible = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.ActiveBorderThickness = 1;
            this.UpdateBtn.ActiveCornerRadius = 20;
            this.UpdateBtn.ActiveFillColor = System.Drawing.Color.Black;
            this.UpdateBtn.ActiveForecolor = System.Drawing.Color.White;
            this.UpdateBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.UpdateBtn.BackColor = System.Drawing.Color.Black;
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.ButtonText = "Update";
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.Black;
            this.UpdateBtn.IdleBorderThickness = 1;
            this.UpdateBtn.IdleCornerRadius = 20;
            this.UpdateBtn.IdleFillColor = System.Drawing.Color.White;
            this.UpdateBtn.IdleForecolor = System.Drawing.Color.Black;
            this.UpdateBtn.IdleLineColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(136, 20);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(123, 37);
            this.UpdateBtn.TabIndex = 34;
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.ActiveBorderThickness = 1;
            this.SearchBtn.ActiveCornerRadius = 20;
            this.SearchBtn.ActiveFillColor = System.Drawing.Color.Black;
            this.SearchBtn.ActiveForecolor = System.Drawing.Color.White;
            this.SearchBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.SearchBtn.BackColor = System.Drawing.Color.Black;
            this.SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.BackgroundImage")));
            this.SearchBtn.ButtonText = "Search";
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchBtn.IdleBorderThickness = 1;
            this.SearchBtn.IdleCornerRadius = 20;
            this.SearchBtn.IdleFillColor = System.Drawing.Color.White;
            this.SearchBtn.IdleForecolor = System.Drawing.Color.Black;
            this.SearchBtn.IdleLineColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(136, 20);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(123, 37);
            this.SearchBtn.TabIndex = 34;
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchBtn.Visible = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Exit
            // 
            this.Exit.ActiveBorderThickness = 1;
            this.Exit.ActiveCornerRadius = 20;
            this.Exit.ActiveFillColor = System.Drawing.Color.Black;
            this.Exit.ActiveForecolor = System.Drawing.Color.White;
            this.Exit.ActiveLineColor = System.Drawing.Color.Black;
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.ButtonText = "Exit";
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.IdleBorderThickness = 1;
            this.Exit.IdleCornerRadius = 20;
            this.Exit.IdleFillColor = System.Drawing.Color.White;
            this.Exit.IdleForecolor = System.Drawing.Color.Black;
            this.Exit.IdleLineColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(267, 20);
            this.Exit.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(123, 37);
            this.Exit.TabIndex = 31;
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.ActiveBorderThickness = 1;
            this.LoginBtn.ActiveCornerRadius = 20;
            this.LoginBtn.ActiveFillColor = System.Drawing.Color.Black;
            this.LoginBtn.ActiveForecolor = System.Drawing.Color.White;
            this.LoginBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.LoginBtn.BackColor = System.Drawing.Color.Black;
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.ButtonText = "Login";
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.Black;
            this.LoginBtn.IdleBorderThickness = 1;
            this.LoginBtn.IdleCornerRadius = 20;
            this.LoginBtn.IdleFillColor = System.Drawing.Color.White;
            this.LoginBtn.IdleForecolor = System.Drawing.Color.Black;
            this.LoginBtn.IdleLineColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(136, 20);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(123, 37);
            this.LoginBtn.TabIndex = 30;
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // ForgetPwd
            // 
            this.ForgetPwd.AutoSize = true;
            this.ForgetPwd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPwd.LinkColor = System.Drawing.Color.Lavender;
            this.ForgetPwd.Location = new System.Drawing.Point(57, 16);
            this.ForgetPwd.Name = "ForgetPwd";
            this.ForgetPwd.Size = new System.Drawing.Size(122, 16);
            this.ForgetPwd.TabIndex = 26;
            this.ForgetPwd.TabStop = true;
            this.ForgetPwd.Text = "Forgot Password?";
            this.ForgetPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgetPwd_LinkClicked);
            // 
            // CPassGb
            // 
            this.CPassGb.Controls.Add(this.ForgetPwd);
            this.CPassGb.Controls.Add(this.cPwd_tb);
            this.CPassGb.Controls.Add(this.cPwd_lbl);
            this.CPassGb.Dock = System.Windows.Forms.DockStyle.Top;
            this.CPassGb.Location = new System.Drawing.Point(371, 200);
            this.CPassGb.Name = "CPassGb";
            this.CPassGb.Size = new System.Drawing.Size(435, 100);
            this.CPassGb.TabIndex = 31;
            this.CPassGb.TabStop = false;
            // 
            // cPwd_tb
            // 
            this.cPwd_tb.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cPwd_tb.BorderColorIdle = System.Drawing.Color.Lavender;
            this.cPwd_tb.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cPwd_tb.BorderThickness = 1;
            this.cPwd_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cPwd_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cPwd_tb.ForeColor = System.Drawing.Color.Lavender;
            this.cPwd_tb.isPassword = true;
            this.cPwd_tb.Location = new System.Drawing.Point(63, 39);
            this.cPwd_tb.Margin = new System.Windows.Forms.Padding(4);
            this.cPwd_tb.Name = "cPwd_tb";
            this.cPwd_tb.Size = new System.Drawing.Size(327, 36);
            this.cPwd_tb.TabIndex = 25;
            this.cPwd_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cPwd_tb.Visible = false;
            // 
            // cPwd_lbl
            // 
            this.cPwd_lbl.AutoSize = true;
            this.cPwd_lbl.BackColor = System.Drawing.Color.Black;
            this.cPwd_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPwd_lbl.ForeColor = System.Drawing.Color.Lavender;
            this.cPwd_lbl.Location = new System.Drawing.Point(56, 16);
            this.cPwd_lbl.Name = "cPwd_lbl";
            this.cPwd_lbl.Size = new System.Drawing.Size(151, 19);
            this.cPwd_lbl.TabIndex = 24;
            this.cPwd_lbl.Text = "Confirm Password";
            this.cPwd_lbl.Visible = false;
            // 
            // NickLbl
            // 
            this.NickLbl.AutoSize = true;
            this.NickLbl.BackColor = System.Drawing.Color.Black;
            this.NickLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NickLbl.ForeColor = System.Drawing.Color.Lavender;
            this.NickLbl.Location = new System.Drawing.Point(58, 16);
            this.NickLbl.Name = "NickLbl";
            this.NickLbl.Size = new System.Drawing.Size(91, 19);
            this.NickLbl.TabIndex = 27;
            this.NickLbl.Text = "Nick Name";
            // 
            // NickTb
            // 
            this.NickTb.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.NickTb.BorderColorIdle = System.Drawing.Color.Lavender;
            this.NickTb.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.NickTb.BorderThickness = 1;
            this.NickTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NickTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NickTb.ForeColor = System.Drawing.Color.Lavender;
            this.NickTb.isPassword = false;
            this.NickTb.Location = new System.Drawing.Point(62, 39);
            this.NickTb.Margin = new System.Windows.Forms.Padding(4);
            this.NickTb.Name = "NickTb";
            this.NickTb.Size = new System.Drawing.Size(327, 36);
            this.NickTb.TabIndex = 28;
            this.NickTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // RecoveryGb
            // 
            this.RecoveryGb.Controls.Add(this.NickTb);
            this.RecoveryGb.Controls.Add(this.NickLbl);
            this.RecoveryGb.Dock = System.Windows.Forms.DockStyle.Top;
            this.RecoveryGb.Location = new System.Drawing.Point(371, 300);
            this.RecoveryGb.Name = "RecoveryGb";
            this.RecoveryGb.Size = new System.Drawing.Size(435, 100);
            this.RecoveryGb.TabIndex = 32;
            this.RecoveryGb.TabStop = false;
            this.RecoveryGb.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RecoveryGb);
            this.Controls.Add(this.CPassGb);
            this.Controls.Add(this.PasswordGb);
            this.Controls.Add(this.UsernameGb);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UsernameGb.ResumeLayout(false);
            this.UsernameGb.PerformLayout();
            this.PasswordGb.ResumeLayout(false);
            this.PasswordGb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.CPassGb.ResumeLayout(false);
            this.CPassGb.PerformLayout();
            this.RecoveryGb.ResumeLayout(false);
            this.RecoveryGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox UsernameGb;
        private Bunifu.Framework.UI.BunifuMetroTextbox Username_tb;
        private Bunifu.Framework.UI.BunifuCustomLabel Username;
        private System.Windows.Forms.GroupBox PasswordGb;
        private Bunifu.Framework.UI.BunifuCustomLabel Password;
        private Bunifu.Framework.UI.BunifuMetroTextbox Password_tb;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 Exit;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Cancelbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 SearchBtn;
        private System.Windows.Forms.LinkLabel ForgetPwd;
        private System.Windows.Forms.GroupBox CPassGb;
        private Bunifu.Framework.UI.BunifuMetroTextbox cPwd_tb;
        private Bunifu.Framework.UI.BunifuCustomLabel cPwd_lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel NickLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox NickTb;
        private System.Windows.Forms.GroupBox RecoveryGb;
    }
}