namespace SMS
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.Password = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Password_tb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Username_tb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Username = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AuthorizeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Cancelbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Black;
            this.Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Lavender;
            this.Password.Location = new System.Drawing.Point(30, 69);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(86, 19);
            this.Password.TabIndex = 32;
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
            this.Password_tb.Location = new System.Drawing.Point(155, 65);
            this.Password_tb.Margin = new System.Windows.Forms.Padding(4);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.Size = new System.Drawing.Size(328, 36);
            this.Password_tb.TabIndex = 31;
            this.Password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Username_tb.Location = new System.Drawing.Point(155, 13);
            this.Username_tb.Margin = new System.Windows.Forms.Padding(4);
            this.Username_tb.Name = "Username_tb";
            this.Username_tb.Size = new System.Drawing.Size(328, 36);
            this.Username_tb.TabIndex = 30;
            this.Username_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Black;
            this.Username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Lavender;
            this.Username.Location = new System.Drawing.Point(30, 22);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(87, 19);
            this.Username.TabIndex = 29;
            this.Username.Text = "Username";
            // 
            // AuthorizeBtn
            // 
            this.AuthorizeBtn.ActiveBorderThickness = 1;
            this.AuthorizeBtn.ActiveCornerRadius = 20;
            this.AuthorizeBtn.ActiveFillColor = System.Drawing.Color.Black;
            this.AuthorizeBtn.ActiveForecolor = System.Drawing.Color.White;
            this.AuthorizeBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.AuthorizeBtn.BackColor = System.Drawing.Color.Black;
            this.AuthorizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AuthorizeBtn.BackgroundImage")));
            this.AuthorizeBtn.ButtonText = "Authorize";
            this.AuthorizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorizeBtn.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorizeBtn.ForeColor = System.Drawing.Color.Black;
            this.AuthorizeBtn.IdleBorderThickness = 1;
            this.AuthorizeBtn.IdleCornerRadius = 20;
            this.AuthorizeBtn.IdleFillColor = System.Drawing.Color.White;
            this.AuthorizeBtn.IdleForecolor = System.Drawing.Color.Black;
            this.AuthorizeBtn.IdleLineColor = System.Drawing.Color.White;
            this.AuthorizeBtn.Location = new System.Drawing.Point(217, 120);
            this.AuthorizeBtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.AuthorizeBtn.Name = "AuthorizeBtn";
            this.AuthorizeBtn.Size = new System.Drawing.Size(123, 37);
            this.AuthorizeBtn.TabIndex = 35;
            this.AuthorizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AuthorizeBtn.Click += new System.EventHandler(this.AuthorizeBtn_Click);
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
            this.Cancelbtn.Location = new System.Drawing.Point(359, 120);
            this.Cancelbtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(123, 37);
            this.Cancelbtn.TabIndex = 36;
            this.Cancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(512, 170);
            this.ControlBox = false;
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.AuthorizeBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.Username_tb);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Password;
        private Bunifu.Framework.UI.BunifuMetroTextbox Password_tb;
        private Bunifu.Framework.UI.BunifuMetroTextbox Username_tb;
        private Bunifu.Framework.UI.BunifuCustomLabel Username;
        private Bunifu.Framework.UI.BunifuThinButton2 AuthorizeBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Cancelbtn;
    }
}