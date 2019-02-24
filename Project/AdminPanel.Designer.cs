namespace SMS
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CreateAccountBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UpdateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PasswordLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RecoveryName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Exit_to_MainForm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.grid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.UsernameTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.IdTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.PasswordTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.RecoveryTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ClearBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateAccountBtn
            // 
            this.CreateAccountBtn.ActiveBorderThickness = 1;
            this.CreateAccountBtn.ActiveCornerRadius = 20;
            this.CreateAccountBtn.ActiveFillColor = System.Drawing.Color.Black;
            this.CreateAccountBtn.ActiveForecolor = System.Drawing.Color.White;
            this.CreateAccountBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.CreateAccountBtn.BackColor = System.Drawing.Color.Black;
            this.CreateAccountBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateAccountBtn.BackgroundImage")));
            this.CreateAccountBtn.ButtonText = "Create New Account";
            this.CreateAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccountBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountBtn.ForeColor = System.Drawing.Color.Black;
            this.CreateAccountBtn.IdleBorderThickness = 1;
            this.CreateAccountBtn.IdleCornerRadius = 20;
            this.CreateAccountBtn.IdleFillColor = System.Drawing.Color.White;
            this.CreateAccountBtn.IdleForecolor = System.Drawing.Color.Black;
            this.CreateAccountBtn.IdleLineColor = System.Drawing.Color.White;
            this.CreateAccountBtn.Location = new System.Drawing.Point(24, 197);
            this.CreateAccountBtn.Margin = new System.Windows.Forms.Padding(13, 8, 13, 8);
            this.CreateAccountBtn.Name = "CreateAccountBtn";
            this.CreateAccountBtn.Size = new System.Drawing.Size(190, 45);
            this.CreateAccountBtn.TabIndex = 47;
            this.CreateAccountBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateAccountBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ActiveBorderThickness = 1;
            this.DeleteBtn.ActiveCornerRadius = 20;
            this.DeleteBtn.ActiveFillColor = System.Drawing.Color.Black;
            this.DeleteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DeleteBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.DeleteBtn.BackColor = System.Drawing.Color.Black;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.ButtonText = "Delete";
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleCornerRadius = 20;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.White;
            this.DeleteBtn.IdleForecolor = System.Drawing.Color.Black;
            this.DeleteBtn.IdleLineColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(338, 195);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(112, 45);
            this.DeleteBtn.TabIndex = 49;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            this.UpdateBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.Black;
            this.UpdateBtn.IdleBorderThickness = 1;
            this.UpdateBtn.IdleCornerRadius = 20;
            this.UpdateBtn.IdleFillColor = System.Drawing.Color.White;
            this.UpdateBtn.IdleForecolor = System.Drawing.Color.Black;
            this.UpdateBtn.IdleLineColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(218, 195);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(115, 45);
            this.UpdateBtn.TabIndex = 50;
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.Color.Lavender;
            this.PasswordLbl.Location = new System.Drawing.Point(20, 117);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(94, 22);
            this.PasswordLbl.TabIndex = 51;
            this.PasswordLbl.Text = "Password";
            // 
            // RecoveryName
            // 
            this.RecoveryName.AutoSize = true;
            this.RecoveryName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryName.ForeColor = System.Drawing.Color.Lavender;
            this.RecoveryName.Location = new System.Drawing.Point(20, 159);
            this.RecoveryName.Name = "RecoveryName";
            this.RecoveryName.Size = new System.Drawing.Size(96, 22);
            this.RecoveryName.TabIndex = 51;
            this.RecoveryName.Text = "NickName";
            // 
            // Exit_to_MainForm
            // 
            this.Exit_to_MainForm.ActiveBorderThickness = 1;
            this.Exit_to_MainForm.ActiveCornerRadius = 20;
            this.Exit_to_MainForm.ActiveFillColor = System.Drawing.Color.Black;
            this.Exit_to_MainForm.ActiveForecolor = System.Drawing.Color.White;
            this.Exit_to_MainForm.ActiveLineColor = System.Drawing.Color.Black;
            this.Exit_to_MainForm.BackColor = System.Drawing.Color.Black;
            this.Exit_to_MainForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_to_MainForm.BackgroundImage")));
            this.Exit_to_MainForm.ButtonText = "Exit";
            this.Exit_to_MainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_to_MainForm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_to_MainForm.ForeColor = System.Drawing.Color.Black;
            this.Exit_to_MainForm.IdleBorderThickness = 1;
            this.Exit_to_MainForm.IdleCornerRadius = 20;
            this.Exit_to_MainForm.IdleFillColor = System.Drawing.Color.White;
            this.Exit_to_MainForm.IdleForecolor = System.Drawing.Color.Black;
            this.Exit_to_MainForm.IdleLineColor = System.Drawing.Color.White;
            this.Exit_to_MainForm.Location = new System.Drawing.Point(338, 242);
            this.Exit_to_MainForm.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Exit_to_MainForm.Name = "Exit_to_MainForm";
            this.Exit_to_MainForm.Size = new System.Drawing.Size(110, 49);
            this.Exit_to_MainForm.TabIndex = 49;
            this.Exit_to_MainForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_to_MainForm.Click += new System.EventHandler(this.Exit_to_MainForm_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(67, 31);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(27, 22);
            this.bunifuCustomLabel1.TabIndex = 51;
            this.bunifuCustomLabel1.Text = "Id";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.DoubleBuffered = true;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.Lavender;
            this.grid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.grid.HeaderForeColor = System.Drawing.Color.Lavender;
            this.grid.Location = new System.Drawing.Point(459, 17);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid.Size = new System.Drawing.Size(563, 274);
            this.grid.TabIndex = 56;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // UsernameTb
            // 
            this.UsernameTb.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.UsernameTb.BorderColorIdle = System.Drawing.Color.Lavender;
            this.UsernameTb.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.UsernameTb.BorderThickness = 1;
            this.UsernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.UsernameTb.ForeColor = System.Drawing.Color.Lavender;
            this.UsernameTb.isPassword = false;
            this.UsernameTb.Location = new System.Drawing.Point(120, 59);
            this.UsernameTb.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.Size = new System.Drawing.Size(330, 36);
            this.UsernameTb.TabIndex = 58;
            this.UsernameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(20, 73);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(97, 22);
            this.bunifuCustomLabel2.TabIndex = 51;
            this.bunifuCustomLabel2.Text = "Username";
            // 
            // IdTb
            // 
            this.IdTb.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.IdTb.BorderColorIdle = System.Drawing.Color.Lavender;
            this.IdTb.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.IdTb.BorderThickness = 1;
            this.IdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.IdTb.ForeColor = System.Drawing.Color.Lavender;
            this.IdTb.isPassword = false;
            this.IdTb.Location = new System.Drawing.Point(120, 17);
            this.IdTb.Margin = new System.Windows.Forms.Padding(4);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(330, 36);
            this.IdTb.TabIndex = 58;
            this.IdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PasswordTb
            // 
            this.PasswordTb.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.PasswordTb.BorderColorIdle = System.Drawing.Color.Lavender;
            this.PasswordTb.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.PasswordTb.BorderThickness = 1;
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PasswordTb.ForeColor = System.Drawing.Color.Lavender;
            this.PasswordTb.isPassword = false;
            this.PasswordTb.Location = new System.Drawing.Point(120, 103);
            this.PasswordTb.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(330, 36);
            this.PasswordTb.TabIndex = 58;
            this.PasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // RecoveryTb
            // 
            this.RecoveryTb.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.RecoveryTb.BorderColorIdle = System.Drawing.Color.Lavender;
            this.RecoveryTb.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.RecoveryTb.BorderThickness = 1;
            this.RecoveryTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RecoveryTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RecoveryTb.ForeColor = System.Drawing.Color.Lavender;
            this.RecoveryTb.isPassword = false;
            this.RecoveryTb.Location = new System.Drawing.Point(120, 146);
            this.RecoveryTb.Margin = new System.Windows.Forms.Padding(4);
            this.RecoveryTb.Name = "RecoveryTb";
            this.RecoveryTb.Size = new System.Drawing.Size(330, 36);
            this.RecoveryTb.TabIndex = 58;
            this.RecoveryTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ClearBtn
            // 
            this.ClearBtn.ActiveBorderThickness = 1;
            this.ClearBtn.ActiveCornerRadius = 20;
            this.ClearBtn.ActiveFillColor = System.Drawing.Color.Black;
            this.ClearBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ClearBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.ClearBtn.BackColor = System.Drawing.Color.Black;
            this.ClearBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearBtn.BackgroundImage")));
            this.ClearBtn.ButtonText = "Clear";
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.Black;
            this.ClearBtn.IdleBorderThickness = 1;
            this.ClearBtn.IdleCornerRadius = 20;
            this.ClearBtn.IdleFillColor = System.Drawing.Color.White;
            this.ClearBtn.IdleForecolor = System.Drawing.Color.Black;
            this.ClearBtn.IdleLineColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(218, 242);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(115, 45);
            this.ClearBtn.TabIndex = 50;
            this.ClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1033, 316);
            this.ControlBox = false;
            this.Controls.Add(this.RecoveryTb);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.UsernameTb);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.RecoveryName);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.CreateAccountBtn);
            this.Controls.Add(this.Exit_to_MainForm);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.UpdateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 CreateAccountBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel PasswordLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel RecoveryName;
        private Bunifu.Framework.UI.BunifuThinButton2 Exit_to_MainForm;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grid;
        private Bunifu.Framework.UI.BunifuMetroTextbox UsernameTb;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox IdTb;
        private Bunifu.Framework.UI.BunifuMetroTextbox PasswordTb;
        private Bunifu.Framework.UI.BunifuMetroTextbox RecoveryTb;
        private Bunifu.Framework.UI.BunifuThinButton2 ClearBtn;
    }
}