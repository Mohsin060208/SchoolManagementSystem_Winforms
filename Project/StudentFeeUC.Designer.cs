namespace SMS
{
    partial class StudentFeeUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentFeeUC));
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.HideTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.ViewTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.DeleteTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.UpdateTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.SelectTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.InsertTile = new Bunifu.Framework.UI.BunifuTileButton();
            this.detailsGB = new System.Windows.Forms.GroupBox();
            this.grid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.RemainingDues = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RemainingDuesTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.ClearBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.InsertBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UpdateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.searchBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.FineTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.RollNoTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TotalFee = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RollNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PaperDuesTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Fine = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PaperDues = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TotalFeeTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TransportDuesTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TransportDues = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LastDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FeeDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DueDateValue = new System.Windows.Forms.DateTimePicker();
            this.LastDateValue = new System.Windows.Forms.DateTimePicker();
            this.operationsPanel.SuspendLayout();
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
            this.operationsPanel.TabIndex = 69;
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
            // detailsGB
            // 
            this.detailsGB.Controls.Add(this.grid);
            this.detailsGB.Controls.Add(this.LastDateValue);
            this.detailsGB.Controls.Add(this.DueDateValue);
            this.detailsGB.Controls.Add(this.RemainingDues);
            this.detailsGB.Controls.Add(this.RemainingDuesTb);
            this.detailsGB.Controls.Add(this.ClearBtn);
            this.detailsGB.Controls.Add(this.InsertBtn);
            this.detailsGB.Controls.Add(this.DeleteBtn);
            this.detailsGB.Controls.Add(this.UpdateBtn);
            this.detailsGB.Controls.Add(this.searchBtn);
            this.detailsGB.Controls.Add(this.FineTb);
            this.detailsGB.Controls.Add(this.RollNoTb);
            this.detailsGB.Controls.Add(this.TotalFee);
            this.detailsGB.Controls.Add(this.RollNo);
            this.detailsGB.Controls.Add(this.PaperDuesTb);
            this.detailsGB.Controls.Add(this.Fine);
            this.detailsGB.Controls.Add(this.PaperDues);
            this.detailsGB.Controls.Add(this.TotalFeeTb);
            this.detailsGB.Controls.Add(this.TransportDuesTb);
            this.detailsGB.Controls.Add(this.TransportDues);
            this.detailsGB.Controls.Add(this.LastDate);
            this.detailsGB.Controls.Add(this.FeeDate);
            this.detailsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsGB.Location = new System.Drawing.Point(0, 80);
            this.detailsGB.Name = "detailsGB";
            this.detailsGB.Size = new System.Drawing.Size(920, 408);
            this.detailsGB.TabIndex = 70;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.grid.TabIndex = 89;
            this.grid.Visible = false;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // RemainingDues
            // 
            this.RemainingDues.AutoSize = true;
            this.RemainingDues.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingDues.ForeColor = System.Drawing.Color.Black;
            this.RemainingDues.Location = new System.Drawing.Point(66, 218);
            this.RemainingDues.Name = "RemainingDues";
            this.RemainingDues.Size = new System.Drawing.Size(145, 22);
            this.RemainingDues.TabIndex = 5;
            this.RemainingDues.Text = "RemainingDues";
            // 
            // RemainingDuesTb
            // 
            this.RemainingDuesTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.RemainingDuesTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingDuesTb.ForeColor = System.Drawing.Color.Black;
            this.RemainingDuesTb.Location = new System.Drawing.Point(227, 215);
            this.RemainingDuesTb.Name = "RemainingDuesTb";
            this.RemainingDuesTb.Size = new System.Drawing.Size(295, 29);
            this.RemainingDuesTb.TabIndex = 16;
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
            this.ClearBtn.Location = new System.Drawing.Point(409, 302);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(13, 8, 13, 8);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(115, 45);
            this.ClearBtn.TabIndex = 51;
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
            this.InsertBtn.Location = new System.Drawing.Point(409, 302);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(13, 8, 13, 8);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(115, 45);
            this.InsertBtn.TabIndex = 52;
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
            this.DeleteBtn.Location = new System.Drawing.Point(409, 302);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(115, 45);
            this.DeleteBtn.TabIndex = 53;
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
            this.UpdateBtn.Location = new System.Drawing.Point(409, 302);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(115, 45);
            this.UpdateBtn.TabIndex = 54;
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
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
            this.searchBtn.Location = new System.Drawing.Point(531, 24);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(98, 37);
            this.searchBtn.TabIndex = 34;
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // FineTb
            // 
            this.FineTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.FineTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FineTb.ForeColor = System.Drawing.Color.Black;
            this.FineTb.Location = new System.Drawing.Point(227, 179);
            this.FineTb.Name = "FineTb";
            this.FineTb.Size = new System.Drawing.Size(295, 29);
            this.FineTb.TabIndex = 15;
            // 
            // RollNoTb
            // 
            this.RollNoTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.RollNoTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollNoTb.ForeColor = System.Drawing.Color.Black;
            this.RollNoTb.Location = new System.Drawing.Point(226, 29);
            this.RollNoTb.Name = "RollNoTb";
            this.RollNoTb.Size = new System.Drawing.Size(298, 29);
            this.RollNoTb.TabIndex = 15;
            // 
            // TotalFee
            // 
            this.TotalFee.AutoSize = true;
            this.TotalFee.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFee.ForeColor = System.Drawing.Color.Black;
            this.TotalFee.Location = new System.Drawing.Point(122, 148);
            this.TotalFee.Name = "TotalFee";
            this.TotalFee.Size = new System.Drawing.Size(89, 22);
            this.TotalFee.TabIndex = 4;
            this.TotalFee.Text = "Total Fee";
            // 
            // RollNo
            // 
            this.RollNo.AutoSize = true;
            this.RollNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollNo.ForeColor = System.Drawing.Color.Black;
            this.RollNo.Location = new System.Drawing.Point(144, 32);
            this.RollNo.Name = "RollNo";
            this.RollNo.Size = new System.Drawing.Size(67, 22);
            this.RollNo.TabIndex = 13;
            this.RollNo.Text = "RollNo";
            // 
            // PaperDuesTb
            // 
            this.PaperDuesTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.PaperDuesTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaperDuesTb.Location = new System.Drawing.Point(227, 109);
            this.PaperDuesTb.Name = "PaperDuesTb";
            this.PaperDuesTb.Size = new System.Drawing.Size(295, 29);
            this.PaperDuesTb.TabIndex = 34;
            // 
            // Fine
            // 
            this.Fine.AutoSize = true;
            this.Fine.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fine.ForeColor = System.Drawing.Color.Black;
            this.Fine.Location = new System.Drawing.Point(130, 182);
            this.Fine.Name = "Fine";
            this.Fine.Size = new System.Drawing.Size(47, 22);
            this.Fine.TabIndex = 7;
            this.Fine.Text = "Fine";
            // 
            // PaperDues
            // 
            this.PaperDues.AutoSize = true;
            this.PaperDues.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaperDues.Location = new System.Drawing.Point(100, 112);
            this.PaperDues.Name = "PaperDues";
            this.PaperDues.Size = new System.Drawing.Size(111, 22);
            this.PaperDues.TabIndex = 33;
            this.PaperDues.Text = "Paper Dues";
            // 
            // TotalFeeTb
            // 
            this.TotalFeeTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.TotalFeeTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFeeTb.ForeColor = System.Drawing.Color.Black;
            this.TotalFeeTb.Location = new System.Drawing.Point(227, 144);
            this.TotalFeeTb.Name = "TotalFeeTb";
            this.TotalFeeTb.Size = new System.Drawing.Size(295, 29);
            this.TotalFeeTb.TabIndex = 14;
            // 
            // TransportDuesTb
            // 
            this.TransportDuesTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.TransportDuesTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransportDuesTb.ForeColor = System.Drawing.Color.Black;
            this.TransportDuesTb.Location = new System.Drawing.Point(226, 74);
            this.TransportDuesTb.Name = "TransportDuesTb";
            this.TransportDuesTb.Size = new System.Drawing.Size(296, 29);
            this.TransportDuesTb.TabIndex = 30;
            // 
            // TransportDues
            // 
            this.TransportDues.AutoSize = true;
            this.TransportDues.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransportDues.ForeColor = System.Drawing.Color.Black;
            this.TransportDues.Location = new System.Drawing.Point(80, 77);
            this.TransportDues.Name = "TransportDues";
            this.TransportDues.Size = new System.Drawing.Size(140, 22);
            this.TransportDues.TabIndex = 27;
            this.TransportDues.Text = "Transport Dues";
            // 
            // LastDate
            // 
            this.LastDate.AutoSize = true;
            this.LastDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastDate.ForeColor = System.Drawing.Color.Black;
            this.LastDate.Location = new System.Drawing.Point(105, 277);
            this.LastDate.Name = "LastDate";
            this.LastDate.Size = new System.Drawing.Size(91, 22);
            this.LastDate.TabIndex = 29;
            this.LastDate.Text = "Last Date";
            // 
            // FeeDate
            // 
            this.FeeDate.AutoSize = true;
            this.FeeDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeDate.ForeColor = System.Drawing.Color.Black;
            this.FeeDate.Location = new System.Drawing.Point(105, 250);
            this.FeeDate.Name = "FeeDate";
            this.FeeDate.Size = new System.Drawing.Size(90, 22);
            this.FeeDate.TabIndex = 28;
            this.FeeDate.Text = "Due Date";
            // 
            // DueDateValue
            // 
            this.DueDateValue.Location = new System.Drawing.Point(226, 250);
            this.DueDateValue.Name = "DueDateValue";
            this.DueDateValue.Size = new System.Drawing.Size(298, 22);
            this.DueDateValue.TabIndex = 88;
            // 
            // LastDateValue
            // 
            this.LastDateValue.Location = new System.Drawing.Point(226, 278);
            this.LastDateValue.Name = "LastDateValue";
            this.LastDateValue.Size = new System.Drawing.Size(298, 22);
            this.LastDateValue.TabIndex = 88;
            // 
            // StudentFeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.detailsGB);
            this.Controls.Add(this.operationsPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "StudentFeeUC";
            this.Size = new System.Drawing.Size(920, 488);
            this.Load += new System.EventHandler(this.StudentFeeUC_Load);
            this.operationsPanel.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox detailsGB;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grid;
        private Bunifu.Framework.UI.BunifuCustomLabel RemainingDues;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox RemainingDuesTb;
        private Bunifu.Framework.UI.BunifuThinButton2 ClearBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 InsertBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 searchBtn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox FineTb;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox RollNoTb;
        private Bunifu.Framework.UI.BunifuCustomLabel TotalFee;
        private Bunifu.Framework.UI.BunifuCustomLabel RollNo;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox PaperDuesTb;
        private Bunifu.Framework.UI.BunifuCustomLabel Fine;
        private Bunifu.Framework.UI.BunifuCustomLabel PaperDues;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TotalFeeTb;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TransportDuesTb;
        private Bunifu.Framework.UI.BunifuCustomLabel TransportDues;
        private Bunifu.Framework.UI.BunifuCustomLabel LastDate;
        private Bunifu.Framework.UI.BunifuCustomLabel FeeDate;
        private System.Windows.Forms.DateTimePicker LastDateValue;
        private System.Windows.Forms.DateTimePicker DueDateValue;

    }
}