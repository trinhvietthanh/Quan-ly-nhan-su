﻿namespace Library_Manager
{
    partial class BookForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem4 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem5 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem6 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chếĐộToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptbImg = new System.Windows.Forms.PictureBox();
            this.oFDImage = new System.Windows.Forms.OpenFileDialog();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timeSystem = new System.Windows.Forms.Timer(this.components);
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPH = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lblMode = new System.Windows.Forms.ToolStripLabel();
            this.lblAccount = new System.Windows.Forms.ToolStripLabel();
            this.lblTimeSys = new System.Windows.Forms.ToolStripLabel();
            this.btnMode = new System.Windows.Forms.Button();
            this.tsbtnFindMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAddMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDelMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnUpdateMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.rbtnFindbySerial = new System.Windows.Forms.RadioButton();
            this.rbtnFindbyName = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
            this.barLargeButtonItem3,
            this.barLargeButtonItem4,
            this.barLargeButtonItem5,
            this.barLargeButtonItem6,
            this.barStaticItem1});
            this.barManager1.MaxItemId = 12;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(1101, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 793);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1101, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 793);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1101, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 793);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Tìm sách";
            this.barLargeButtonItem1.Id = 0;
            this.barLargeButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.LargeImage")));
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "Thêm sách";
            this.barLargeButtonItem2.Id = 1;
            this.barLargeButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem2.ImageOptions.LargeImage")));
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // barLargeButtonItem3
            // 
            this.barLargeButtonItem3.Caption = "Xóa sách";
            this.barLargeButtonItem3.Id = 2;
            this.barLargeButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem3.ImageOptions.LargeImage")));
            this.barLargeButtonItem3.Name = "barLargeButtonItem3";
            // 
            // barLargeButtonItem4
            // 
            this.barLargeButtonItem4.Caption = "Cập nhật sách";
            this.barLargeButtonItem4.Id = 3;
            this.barLargeButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem4.ImageOptions.LargeImage")));
            this.barLargeButtonItem4.Name = "barLargeButtonItem4";
            // 
            // barLargeButtonItem5
            // 
            this.barLargeButtonItem5.Caption = "Cập nhật dữ liệu";
            this.barLargeButtonItem5.Id = 4;
            this.barLargeButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem5.ImageOptions.LargeImage")));
            this.barLargeButtonItem5.Name = "barLargeButtonItem5";
            this.barLargeButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barLargeButtonItem6
            // 
            this.barLargeButtonItem6.Caption = "Đóng của sổ";
            this.barLargeButtonItem6.Id = 5;
            this.barLargeButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem6.ImageOptions.LargeImage")));
            this.barLargeButtonItem6.Name = "barLargeButtonItem6";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 11;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.chếĐộToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // chếĐộToolStripMenuItem
            // 
            this.chếĐộToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmToolStripMenuItem,
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.sửaToolStripMenuItem});
            this.chếĐộToolStripMenuItem.Name = "chếĐộToolStripMenuItem";
            this.chếĐộToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.chếĐộToolStripMenuItem.Text = "Chế độ";
            // 
            // tìmToolStripMenuItem
            // 
            this.tìmToolStripMenuItem.Name = "tìmToolStripMenuItem";
            this.tìmToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.tìmToolStripMenuItem.Text = "Tìm...";
            this.tìmToolStripMenuItem.Click += new System.EventHandler(this.tìmToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.thêmToolStripMenuItem.Text = "Thêm...";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // ptbImg
            // 
            this.ptbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbImg.ErrorImage")));
            this.ptbImg.Image = ((System.Drawing.Image)(resources.GetObject("ptbImg.Image")));
            this.ptbImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptbImg.InitialImage")));
            this.ptbImg.Location = new System.Drawing.Point(623, 174);
            this.ptbImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ptbImg.Name = "ptbImg";
            this.ptbImg.Size = new System.Drawing.Size(403, 486);
            this.ptbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImg.TabIndex = 10;
            this.ptbImg.TabStop = false;
            this.ptbImg.Click += new System.EventHandler(this.ptbImg_Click);
            // 
            // oFDImage
            // 
            this.oFDImage.FileName = "openFileDialog1";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(770, 695);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(110, 35);
            this.btnAddImage.TabIndex = 7;
            this.btnAddImage.Text = "Thêm hình";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 382);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nhà xuất bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 452);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 521);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Thể loại";
            // 
            // timeSystem
            // 
            this.timeSystem.Enabled = true;
            this.timeSystem.Interval = 1000;
            this.timeSystem.Tick += new System.EventHandler(this.timeSystem_Tick);
            // 
            // txtSerial
            // 
            this.txtSerial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSerial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSerial.Location = new System.Drawing.Point(220, 174);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSerial.MaxLength = 15;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(329, 30);
            this.txtSerial.TabIndex = 1;
            this.txtSerial.TextChanged += new System.EventHandler(this.VerifyInput_TextChanged);
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Location = new System.Drawing.Point(220, 243);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(329, 30);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.VerifyInput_TextChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(220, 313);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(329, 30);
            this.txtAuthor.TabIndex = 3;
            this.txtAuthor.TextChanged += new System.EventHandler(this.VerifyInput_TextChanged);
            // 
            // txtPH
            // 
            this.txtPH.Location = new System.Drawing.Point(220, 382);
            this.txtPH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPH.Name = "txtPH";
            this.txtPH.Size = new System.Drawing.Size(329, 30);
            this.txtPH.TabIndex = 4;
            this.txtPH.TextChanged += new System.EventHandler(this.VerifyInput_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(220, 452);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(73, 30);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(220, 521);
            this.txtTag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTag.Multiline = true;
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(329, 138);
            this.txtTag.TabIndex = 6;
            this.txtTag.TextChanged += new System.EventHandler(this.VerifyInput_TextChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Silver;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMode,
            this.lblAccount,
            this.lblTimeSys});
            this.toolStrip2.Location = new System.Drawing.Point(0, 758);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(1101, 35);
            this.toolStrip2.TabIndex = 36;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lblMode
            // 
            this.lblMode.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblMode.ForeColor = System.Drawing.Color.Green;
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(54, 32);
            this.lblMode.Text = "Mode";
            // 
            // lblAccount
            // 
            this.lblAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblAccount.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblAccount.ForeColor = System.Drawing.Color.Maroon;
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(74, 32);
            this.lblAccount.Text = "Account";
            // 
            // lblTimeSys
            // 
            this.lblTimeSys.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblTimeSys.Name = "lblTimeSys";
            this.lblTimeSys.Size = new System.Drawing.Size(83, 32);
            this.lblTimeSys.Text = "Thời gian";
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(330, 695);
            this.btnMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(110, 35);
            this.btnMode.TabIndex = 8;
            this.btnMode.Text = "mode";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // tsbtnFindMode
            // 
            this.tsbtnFindMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFindMode.Image")));
            this.tsbtnFindMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnFindMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFindMode.Name = "tsbtnFindMode";
            this.tsbtnFindMode.Size = new System.Drawing.Size(68, 108);
            this.tsbtnFindMode.Text = "Tìm";
            this.tsbtnFindMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnFindMode.Click += new System.EventHandler(this.tsbtnFindMode_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 111);
            // 
            // tsbtnAddMode
            // 
            this.tsbtnAddMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddMode.Image")));
            this.tsbtnAddMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAddMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddMode.Name = "tsbtnAddMode";
            this.tsbtnAddMode.Size = new System.Drawing.Size(68, 108);
            this.tsbtnAddMode.Text = "Thêm";
            this.tsbtnAddMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAddMode.Click += new System.EventHandler(this.tsbtnAddMode_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 111);
            // 
            // tsbtnDelMode
            // 
            this.tsbtnDelMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelMode.Image")));
            this.tsbtnDelMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnDelMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelMode.Name = "tsbtnDelMode";
            this.tsbtnDelMode.Size = new System.Drawing.Size(68, 108);
            this.tsbtnDelMode.Text = "Xóa";
            this.tsbtnDelMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelMode.Click += new System.EventHandler(this.tsbtnDelMode_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 111);
            // 
            // tsbtnUpdateMode
            // 
            this.tsbtnUpdateMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpdateMode.Image")));
            this.tsbtnUpdateMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnUpdateMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdateMode.Name = "tsbtnUpdateMode";
            this.tsbtnUpdateMode.Size = new System.Drawing.Size(68, 108);
            this.tsbtnUpdateMode.Text = "Sửa";
            this.tsbtnUpdateMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnUpdateMode.Click += new System.EventHandler(this.tsbtnUpdateMode_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 111);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(68, 108);
            this.tsbtnExit.Text = "Thoát";
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 111);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(68, 108);
            this.btnReset.Text = "Đặt lại";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReset.ToolTipText = "Đặt lại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFindMode,
            this.toolStripSeparator1,
            this.tsbtnAddMode,
            this.toolStripSeparator2,
            this.tsbtnDelMode,
            this.toolStripSeparator3,
            this.tsbtnUpdateMode,
            this.toolStripSeparator4,
            this.tsbtnExit,
            this.toolStripSeparator5,
            this.btnReset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1101, 111);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // rbtnFindbySerial
            // 
            this.rbtnFindbySerial.AutoSize = true;
            this.rbtnFindbySerial.Location = new System.Drawing.Point(220, 208);
            this.rbtnFindbySerial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnFindbySerial.Name = "rbtnFindbySerial";
            this.rbtnFindbySerial.Size = new System.Drawing.Size(173, 26);
            this.rbtnFindbySerial.TabIndex = 42;
            this.rbtnFindbySerial.TabStop = true;
            this.rbtnFindbySerial.Text = "Tìm bằng mã sách";
            this.rbtnFindbySerial.UseVisualStyleBackColor = true;
            this.rbtnFindbySerial.CheckedChanged += new System.EventHandler(this.rbtnFindbySerial_CheckedChanged);
            // 
            // rbtnFindbyName
            // 
            this.rbtnFindbyName.AutoSize = true;
            this.rbtnFindbyName.Location = new System.Drawing.Point(220, 278);
            this.rbtnFindbyName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnFindbyName.Name = "rbtnFindbyName";
            this.rbtnFindbyName.Size = new System.Drawing.Size(173, 26);
            this.rbtnFindbyName.TabIndex = 43;
            this.rbtnFindbyName.TabStop = true;
            this.rbtnFindbyName.Text = "Tìm bằng tên sách";
            this.rbtnFindbyName.UseVisualStyleBackColor = true;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 793);
            this.Controls.Add(this.rbtnFindbyName);
            this.Controls.Add(this.rbtnFindbySerial);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPH);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.ptbImg);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("BookForm.IconOptions.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "BookForm";
            this.Text = "Thao tác với sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookForm_FormClosing);
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem3;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem4;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem5;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem6;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox ptbImg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog oFDImage;
        //private DevExpress.XtraBars.BarStaticItem txtTime;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.TextBox txtPH;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timeSystem;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lblMode;
        private System.Windows.Forms.ToolStripLabel lblAccount;
        private System.Windows.Forms.ToolStripLabel lblTimeSys;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chếĐộToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnFindMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnAddMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnDelMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnUpdateMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.RadioButton rbtnFindbyName;
        private System.Windows.Forms.RadioButton rbtnFindbySerial;
    }
}