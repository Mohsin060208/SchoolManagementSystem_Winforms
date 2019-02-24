namespace SMS
{
    partial class StudentUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.HideTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.ViewTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.DeleteTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.UpdateTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.SelectTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.InsertTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idGB = new System.Windows.Forms.GroupBox();
            this.searchBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.RollNoTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.RollNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.detailsGB = new System.Windows.Forms.GroupBox();
            this.grid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.DOBvalue = new System.Windows.Forms.DateTimePicker();
            this.AdminDateValue = new System.Windows.Forms.DateTimePicker();
            this.ClearBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.InsertBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UpdateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddressTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.FatherName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Name_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.address = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.GenderTb = new System.Windows.Forms.ComboBox();
            this.Gender = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FatherNameTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.NameTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.PhoneTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Phone = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Session = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Email = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ClassTb = new System.Windows.Forms.ComboBox();
            this.Class = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SessionTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.AdminDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.EmailTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.operationsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.idGB.SuspendLayout();
            this.detailsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // operationsPanel
            // 
            this.operationsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.operationsPanel.Controls.Add(this.HideTile);
            this.operationsPanel.Controls.Add(this.ViewTile);
            this.operationsPanel.Controls.Add(this.DeleteTile);
            this.operationsPanel.Controls.Add(this.UpdateTile);
            this.operationsPanel.Controls.Add(this.SelectTile);
            this.operationsPanel.Controls.Add(this.InsertTile);
            this.operationsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.operationsPanel.Location = new System.Drawing.Point(0, 0);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(920, 80);
            this.operationsPanel.TabIndex = 70;
            // 
            // HideTile
            // 
            this.HideTile.BackColor = System.Drawing.Color.Wheat;
            this.HideTile.color = System.Drawing.Color.Wheat;
            this.HideTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.HideTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideTile.ForeColor = System.Drawing.Color.Black;
            this.HideTile.Image = global::SMS.Properties.Resources.hide;
            this.HideTile.ImagePosition = 0;
            this.HideTile.ImageZoom = 40;
            this.HideTile.LabelPosition = 27;
            this.HideTile.LabelText = "Hide";
            this.HideTile.Location = new System.Drawing.Point(589, 2);
            this.HideTile.Margin = new System.Windows.Forms.Padding(6);
            this.HideTile.Name = "HideTile";
            this.HideTile.Size = new System.Drawing.Size(114, 71);
            this.HideTile.TabIndex = 5;
            this.HideTile.Click += new System.EventHandler(this.HideTile_Click);
            // 
            // ViewTile
            // 
            this.ViewTile.BackColor = System.Drawing.Color.Wheat;
            this.ViewTile.color = System.Drawing.Color.Wheat;
            this.ViewTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ViewTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTile.ForeColor = System.Drawing.Color.Black;
            this.ViewTile.Image = global::SMS.Properties.Resources.view;
            this.ViewTile.ImagePosition = 0;
            this.ViewTile.ImageZoom = 40;
            this.ViewTile.LabelPosition = 27;
            this.ViewTile.LabelText = "View";
            this.ViewTile.Location = new System.Drawing.Point(472, 2);
            this.ViewTile.Margin = new System.Windows.Forms.Padding(6);
            this.ViewTile.Name = "ViewTile";
            this.ViewTile.Size = new System.Drawing.Size(114, 71);
            this.ViewTile.TabIndex = 4;
            this.ViewTile.Click += new System.EventHandler(this.ViewTile_Click);
            // 
            // DeleteTile
            // 
            this.DeleteTile.BackColor = System.Drawing.Color.Wheat;
            this.DeleteTile.color = System.Drawing.Color.Wheat;
            this.DeleteTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTile.ForeColor = System.Drawing.Color.Black;
            this.DeleteTile.Image = global::SMS.Properties.Resources.delete;
            this.DeleteTile.ImagePosition = 0;
            this.DeleteTile.ImageZoom = 40;
            this.DeleteTile.LabelPosition = 27;
            this.DeleteTile.LabelText = "Delete";
            this.DeleteTile.Location = new System.Drawing.Point(355, 2);
            this.DeleteTile.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteTile.Name = "DeleteTile";
            this.DeleteTile.Size = new System.Drawing.Size(114, 71);
            this.DeleteTile.TabIndex = 3;
            this.DeleteTile.Click += new System.EventHandler(this.DeleteTile_Click);
            // 
            // UpdateTile
            // 
            this.UpdateTile.BackColor = System.Drawing.Color.Wheat;
            this.UpdateTile.color = System.Drawing.Color.Wheat;
            this.UpdateTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.UpdateTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTile.ForeColor = System.Drawing.Color.Black;
            this.UpdateTile.Image = global::SMS.Properties.Resources.update;
            this.UpdateTile.ImagePosition = 0;
            this.UpdateTile.ImageZoom = 40;
            this.UpdateTile.LabelPosition = 27;
            this.UpdateTile.LabelText = "Update";
            this.UpdateTile.Location = new System.Drawing.Point(238, 2);
            this.UpdateTile.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateTile.Name = "UpdateTile";
            this.UpdateTile.Size = new System.Drawing.Size(114, 71);
            this.UpdateTile.TabIndex = 2;
            this.UpdateTile.Click += new System.EventHandler(this.UpdateTile_Click);
            // 
            // SelectTile
            // 
            this.SelectTile.BackColor = System.Drawing.Color.Wheat;
            this.SelectTile.color = System.Drawing.Color.Wheat;
            this.SelectTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SelectTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTile.ForeColor = System.Drawing.Color.Black;
            this.SelectTile.Image = global::SMS.Properties.Resources.edit;
            this.SelectTile.ImagePosition = 0;
            this.SelectTile.ImageZoom = 40;
            this.SelectTile.LabelPosition = 27;
            this.SelectTile.LabelText = "Select";
            this.SelectTile.Location = new System.Drawing.Point(121, 2);
            this.SelectTile.Margin = new System.Windows.Forms.Padding(6);
            this.SelectTile.Name = "SelectTile";
            this.SelectTile.Size = new System.Drawing.Size(114, 71);
            this.SelectTile.TabIndex = 1;
            this.SelectTile.Click += new System.EventHandler(this.SelectTile_Click);
            // 
            // InsertTile
            // 
            this.InsertTile.BackColor = System.Drawing.Color.Wheat;
            this.InsertTile.color = System.Drawing.Color.Wheat;
            this.InsertTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.InsertTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertTile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertTile.ForeColor = System.Drawing.Color.Black;
            this.InsertTile.Image = global::SMS.Properties.Resources.insert;
            this.InsertTile.ImagePosition = 0;
            this.InsertTile.ImageZoom = 40;
            this.InsertTile.LabelPosition = 27;
            this.InsertTile.LabelText = "Insert";
            this.InsertTile.Location = new System.Drawing.Point(4, 2);
            this.InsertTile.Margin = new System.Windows.Forms.Padding(6);
            this.InsertTile.Name = "InsertTile";
            this.InsertTile.Size = new System.Drawing.Size(114, 71);
            this.InsertTile.TabIndex = 0;
            this.InsertTile.Click += new System.EventHandler(this.InsertTile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idGB);
            this.panel1.Controls.Add(this.detailsGB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 408);
            this.panel1.TabIndex = 71;
            // 
            // idGB
            // 
            this.idGB.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.idGB.Controls.Add(this.searchBtn);
            this.idGB.Controls.Add(this.RollNoTb);
            this.idGB.Controls.Add(this.RollNo);
            this.idGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.idGB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idGB.ForeColor = System.Drawing.Color.Black;
            this.idGB.Location = new System.Drawing.Point(0, 0);
            this.idGB.Name = "idGB";
            this.idGB.Size = new System.Drawing.Size(920, 67);
            this.idGB.TabIndex = 63;
            this.idGB.TabStop = false;
            this.idGB.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.ActiveBorderThickness = 1;
            this.searchBtn.ActiveCornerRadius = 20;
            this.searchBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.searchBtn.ActiveForecolor = System.Drawing.Color.White;
            this.searchBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.searchBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.searchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBtn.BackgroundImage")));
            this.searchBtn.ButtonText = "Search";
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.searchBtn.IdleBorderThickness = 1;
            this.searchBtn.IdleCornerRadius = 20;
            this.searchBtn.IdleFillColor = System.Drawing.Color.White;
            this.searchBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.searchBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.searchBtn.Location = new System.Drawing.Point(424, 21);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(98, 37);
            this.searchBtn.TabIndex = 33;
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // RollNoTb
            // 
            this.RollNoTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.RollNoTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollNoTb.ForeColor = System.Drawing.Color.Black;
            this.RollNoTb.Location = new System.Drawing.Point(164, 25);
            this.RollNoTb.Name = "RollNoTb";
            this.RollNoTb.Size = new System.Drawing.Size(249, 29);
            this.RollNoTb.TabIndex = 15;
            // 
            // RollNo
            // 
            this.RollNo.AutoSize = true;
            this.RollNo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.RollNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollNo.ForeColor = System.Drawing.Color.Black;
            this.RollNo.Location = new System.Drawing.Point(74, 28);
            this.RollNo.Name = "RollNo";
            this.RollNo.Size = new System.Drawing.Size(67, 22);
            this.RollNo.TabIndex = 0;
            this.RollNo.Text = "RollNo";
            // 
            // detailsGB
            // 
            this.detailsGB.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.detailsGB.Controls.Add(this.grid);
            this.detailsGB.Controls.Add(this.DOBvalue);
            this.detailsGB.Controls.Add(this.AdminDateValue);
            this.detailsGB.Controls.Add(this.ClearBtn);
            this.detailsGB.Controls.Add(this.InsertBtn);
            this.detailsGB.Controls.Add(this.DeleteBtn);
            this.detailsGB.Controls.Add(this.UpdateBtn);
            this.detailsGB.Controls.Add(this.AddressTb);
            this.detailsGB.Controls.Add(this.FatherName);
            this.detailsGB.Controls.Add(this.Name_lbl);
            this.detailsGB.Controls.Add(this.address);
            this.detailsGB.Controls.Add(this.GenderTb);
            this.detailsGB.Controls.Add(this.Gender);
            this.detailsGB.Controls.Add(this.FatherNameTb);
            this.detailsGB.Controls.Add(this.NameTb);
            this.detailsGB.Controls.Add(this.PhoneTb);
            this.detailsGB.Controls.Add(this.Phone);
            this.detailsGB.Controls.Add(this.Session);
            this.detailsGB.Controls.Add(this.bunifuCustomLabel1);
            this.detailsGB.Controls.Add(this.Email);
            this.detailsGB.Controls.Add(this.ClassTb);
            this.detailsGB.Controls.Add(this.Class);
            this.detailsGB.Controls.Add(this.SessionTb);
            this.detailsGB.Controls.Add(this.AdminDate);
            this.detailsGB.Controls.Add(this.EmailTb);
            this.detailsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsGB.ForeColor = System.Drawing.Color.Black;
            this.detailsGB.Location = new System.Drawing.Point(0, 0);
            this.detailsGB.Name = "detailsGB";
            this.detailsGB.Size = new System.Drawing.Size(920, 408);
            this.detailsGB.TabIndex = 62;
            this.detailsGB.TabStop = false;
            this.detailsGB.Visible = false;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.DoubleBuffered = true;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.BlanchedAlmond;
            this.grid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.grid.HeaderForeColor = System.Drawing.Color.White;
            this.grid.Location = new System.Drawing.Point(3, 18);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid.Size = new System.Drawing.Size(914, 387);
            this.grid.TabIndex = 87;
            this.grid.Visible = false;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // DOBvalue
            // 
            this.DOBvalue.Location = new System.Drawing.Point(548, 126);
            this.DOBvalue.Name = "DOBvalue";
            this.DOBvalue.Size = new System.Drawing.Size(328, 22);
            this.DOBvalue.TabIndex = 86;
            // 
            // AdminDateValue
            // 
            this.AdminDateValue.Location = new System.Drawing.Point(549, 252);
            this.AdminDateValue.Name = "AdminDateValue";
            this.AdminDateValue.Size = new System.Drawing.Size(327, 22);
            this.AdminDateValue.TabIndex = 87;
            // 
            // ClearBtn
            // 
            this.ClearBtn.ActiveBorderThickness = 1;
            this.ClearBtn.ActiveCornerRadius = 20;
            this.ClearBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ClearBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ClearBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ClearBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClearBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearBtn.BackgroundImage")));
            this.ClearBtn.ButtonText = "Clear";
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.ClearBtn.IdleBorderThickness = 1;
            this.ClearBtn.IdleCornerRadius = 20;
            this.ClearBtn.IdleFillColor = System.Drawing.Color.White;
            this.ClearBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ClearBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ClearBtn.Location = new System.Drawing.Point(480, 333);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(13, 8, 13, 8);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(115, 45);
            this.ClearBtn.TabIndex = 82;
            this.ClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClearBtn.Visible = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.ActiveBorderThickness = 1;
            this.InsertBtn.ActiveCornerRadius = 20;
            this.InsertBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.InsertBtn.ActiveForecolor = System.Drawing.Color.White;
            this.InsertBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.InsertBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.InsertBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InsertBtn.BackgroundImage")));
            this.InsertBtn.ButtonText = "Insert";
            this.InsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.InsertBtn.IdleBorderThickness = 1;
            this.InsertBtn.IdleCornerRadius = 20;
            this.InsertBtn.IdleFillColor = System.Drawing.Color.White;
            this.InsertBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.InsertBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.InsertBtn.Location = new System.Drawing.Point(480, 333);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(13, 8, 13, 8);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(115, 45);
            this.InsertBtn.TabIndex = 83;
            this.InsertBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InsertBtn.Visible = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ActiveBorderThickness = 1;
            this.DeleteBtn.ActiveCornerRadius = 20;
            this.DeleteBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DeleteBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.ButtonText = "Delete";
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleCornerRadius = 20;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.White;
            this.DeleteBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.Location = new System.Drawing.Point(480, 333);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(115, 45);
            this.DeleteBtn.TabIndex = 84;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.ActiveBorderThickness = 1;
            this.UpdateBtn.ActiveCornerRadius = 20;
            this.UpdateBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.UpdateBtn.ActiveForecolor = System.Drawing.Color.White;
            this.UpdateBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.UpdateBtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.ButtonText = "Update";
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.UpdateBtn.IdleBorderThickness = 1;
            this.UpdateBtn.IdleCornerRadius = 20;
            this.UpdateBtn.IdleFillColor = System.Drawing.Color.White;
            this.UpdateBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.UpdateBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.UpdateBtn.Location = new System.Drawing.Point(480, 333);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(115, 45);
            this.UpdateBtn.TabIndex = 85;
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddressTb
            // 
            this.AddressTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.AddressTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTb.ForeColor = System.Drawing.Color.Black;
            this.AddressTb.Location = new System.Drawing.Point(163, 221);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(248, 64);
            this.AddressTb.TabIndex = 74;
            // 
            // FatherName
            // 
            this.FatherName.AutoSize = true;
            this.FatherName.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.FatherName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatherName.ForeColor = System.Drawing.Color.Black;
            this.FatherName.Location = new System.Drawing.Point(21, 120);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(133, 22);
            this.FatherName.TabIndex = 68;
            this.FatherName.Text = "Father\'s Name";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Name_lbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.ForeColor = System.Drawing.Color.Black;
            this.Name_lbl.Location = new System.Drawing.Point(21, 86);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(60, 22);
            this.Name_lbl.TabIndex = 69;
            this.Name_lbl.Text = "Name";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.address.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.Black;
            this.address.Location = new System.Drawing.Point(21, 221);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(82, 22);
            this.address.TabIndex = 70;
            this.address.Text = "Address";
            // 
            // GenderTb
            // 
            this.GenderTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderTb.ForeColor = System.Drawing.Color.Black;
            this.GenderTb.FormattingEnabled = true;
            this.GenderTb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderTb.Location = new System.Drawing.Point(164, 152);
            this.GenderTb.Name = "GenderTb";
            this.GenderTb.Size = new System.Drawing.Size(249, 30);
            this.GenderTb.TabIndex = 77;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Gender.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.ForeColor = System.Drawing.Color.Black;
            this.Gender.Location = new System.Drawing.Point(21, 152);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(74, 22);
            this.Gender.TabIndex = 71;
            this.Gender.Text = "Gender";
            // 
            // FatherNameTb
            // 
            this.FatherNameTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.FatherNameTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatherNameTb.ForeColor = System.Drawing.Color.Black;
            this.FatherNameTb.Location = new System.Drawing.Point(165, 119);
            this.FatherNameTb.Name = "FatherNameTb";
            this.FatherNameTb.Size = new System.Drawing.Size(248, 29);
            this.FatherNameTb.TabIndex = 72;
            // 
            // NameTb
            // 
            this.NameTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.NameTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTb.ForeColor = System.Drawing.Color.Black;
            this.NameTb.Location = new System.Drawing.Point(165, 86);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(248, 29);
            this.NameTb.TabIndex = 73;
            // 
            // PhoneTb
            // 
            this.PhoneTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PhoneTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTb.ForeColor = System.Drawing.Color.Black;
            this.PhoneTb.Location = new System.Drawing.Point(163, 186);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(249, 29);
            this.PhoneTb.TabIndex = 75;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Phone.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.Color.Black;
            this.Phone.Location = new System.Drawing.Point(21, 186);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(65, 22);
            this.Phone.TabIndex = 76;
            this.Phone.Text = "Phone";
            // 
            // Session
            // 
            this.Session.AutoSize = true;
            this.Session.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Session.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Session.ForeColor = System.Drawing.Color.Black;
            this.Session.Location = new System.Drawing.Point(449, 89);
            this.Session.Name = "Session";
            this.Session.Size = new System.Drawing.Size(79, 22);
            this.Session.TabIndex = 11;
            this.Session.Text = "Session";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(455, 126);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(52, 22);
            this.bunifuCustomLabel1.TabIndex = 56;
            this.bunifuCustomLabel1.Text = "DOB";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Email.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Black;
            this.Email.Location = new System.Drawing.Point(449, 214);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(57, 22);
            this.Email.TabIndex = 35;
            this.Email.Text = "Email";
            // 
            // ClassTb
            // 
            this.ClassTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassTb.ForeColor = System.Drawing.Color.Black;
            this.ClassTb.FormattingEnabled = true;
            this.ClassTb.Items.AddRange(new object[] {
            "Play Group",
            "Nursery",
            "Prep",
            "One",
            "Two ",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten"});
            this.ClassTb.Location = new System.Drawing.Point(549, 167);
            this.ClassTb.Name = "ClassTb";
            this.ClassTb.Size = new System.Drawing.Size(327, 30);
            this.ClassTb.TabIndex = 55;
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Class.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.ForeColor = System.Drawing.Color.Black;
            this.Class.Location = new System.Drawing.Point(449, 170);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(58, 22);
            this.Class.TabIndex = 8;
            this.Class.Text = "Class";
            // 
            // SessionTb
            // 
            this.SessionTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.SessionTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionTb.ForeColor = System.Drawing.Color.Black;
            this.SessionTb.Location = new System.Drawing.Point(549, 86);
            this.SessionTb.Name = "SessionTb";
            this.SessionTb.Size = new System.Drawing.Size(327, 29);
            this.SessionTb.TabIndex = 19;
            // 
            // AdminDate
            // 
            this.AdminDate.AutoSize = true;
            this.AdminDate.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.AdminDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDate.ForeColor = System.Drawing.Color.Black;
            this.AdminDate.Location = new System.Drawing.Point(439, 252);
            this.AdminDate.Name = "AdminDate";
            this.AdminDate.Size = new System.Drawing.Size(104, 22);
            this.AdminDate.TabIndex = 24;
            this.AdminDate.Text = "AdminDate";
            // 
            // EmailTb
            // 
            this.EmailTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.EmailTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTb.ForeColor = System.Drawing.Color.Black;
            this.EmailTb.Location = new System.Drawing.Point(549, 207);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(328, 29);
            this.EmailTb.TabIndex = 36;
            // 
            // StudentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.operationsPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "StudentUC";
            this.Size = new System.Drawing.Size(920, 488);
            this.Load += new System.EventHandler(this.Student_Load);
            this.operationsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.idGB.ResumeLayout(false);
            this.idGB.PerformLayout();
            this.detailsGB.ResumeLayout(false);
            this.detailsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel operationsPanel;
        private Bunifu.Framework.UI.BunifuTileButton HideTile;
        private Bunifu.Framework.UI.BunifuTileButton ViewTile;
        private Bunifu.Framework.UI.BunifuTileButton DeleteTile;
        private Bunifu.Framework.UI.BunifuTileButton UpdateTile;
        private Bunifu.Framework.UI.BunifuTileButton SelectTile;
        private Bunifu.Framework.UI.BunifuTileButton InsertTile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox idGB;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox RollNoTb;
        private Bunifu.Framework.UI.BunifuCustomLabel RollNo;
        private System.Windows.Forms.GroupBox detailsGB;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox AddressTb;
        private Bunifu.Framework.UI.BunifuCustomLabel FatherName;
        private Bunifu.Framework.UI.BunifuCustomLabel Name_lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel address;
        private System.Windows.Forms.ComboBox GenderTb;
        private Bunifu.Framework.UI.BunifuCustomLabel Gender;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox FatherNameTb;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox NameTb;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox PhoneTb;
        private Bunifu.Framework.UI.BunifuCustomLabel Phone;
        private Bunifu.Framework.UI.BunifuCustomLabel Session;
        private Bunifu.Framework.UI.BunifuCustomLabel Email;
        private System.Windows.Forms.ComboBox ClassTb;
        private Bunifu.Framework.UI.BunifuCustomLabel Class;
        private Bunifu.Framework.UI.BunifuCustomLabel AdminDate;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox EmailTb;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 searchBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 ClearBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 InsertBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateBtn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox SessionTb;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grid;
        private System.Windows.Forms.DateTimePicker DOBvalue;
        private System.Windows.Forms.DateTimePicker AdminDateValue;

    }
}