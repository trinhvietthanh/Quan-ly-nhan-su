namespace GUI.UC.Tab
{
    partial class MuonTra
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
            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                ctrl.Dispose();
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.grbPMT = new System.Windows.Forms.GroupBox();
            this.dateTra = new System.Windows.Forms.DateTimePicker();
            this.dateHtra = new System.Windows.Forms.DateTimePicker();
            this.dateLap = new System.Windows.Forms.DateTimePicker();
            this.txtMTT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMDG2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoPMT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbDG = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMDG1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbPM = new System.Windows.Forms.GroupBox();
            this.dgvPMT = new System.Windows.Forms.DataGridView();
            this.grbCTM = new System.Windows.Forms.GroupBox();
            this.dgvCTM = new System.Windows.Forms.DataGridView();
            this.cmsPMT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlmXemPhieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmSuaChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCTM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlmTrangThai = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmHong = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmMat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiNhan = new GUI.ComponentForm.Thin_Button();
            this.btnXoa = new GUI.ComponentForm.Thin_Button();
            this.btnSua = new GUI.ComponentForm.Thin_Button();
            this.btnTra = new GUI.ComponentForm.Thin_Button();
            this.btnMuon = new GUI.ComponentForm.Thin_Button();
            this.btnXem = new GUI.ComponentForm.Thin_Button();
            this.pnlTool.SuspendLayout();
            this.grbPMT.SuspendLayout();
            this.grbDG.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPMT)).BeginInit();
            this.grbCTM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTM)).BeginInit();
            this.cmsPMT.SuspendLayout();
            this.cmsCTM.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.Controls.Add(this.grbPMT);
            this.pnlTool.Controls.Add(this.grbDG);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(1096, 228);
            this.pnlTool.TabIndex = 0;
            // 
            // grbPMT
            // 
            this.grbPMT.Controls.Add(this.dateTra);
            this.grbPMT.Controls.Add(this.dateHtra);
            this.grbPMT.Controls.Add(this.dateLap);
            this.grbPMT.Controls.Add(this.btnGhiNhan);
            this.grbPMT.Controls.Add(this.btnXoa);
            this.grbPMT.Controls.Add(this.btnSua);
            this.grbPMT.Controls.Add(this.txtMTT);
            this.grbPMT.Controls.Add(this.label11);
            this.grbPMT.Controls.Add(this.label10);
            this.grbPMT.Controls.Add(this.txtMDG2);
            this.grbPMT.Controls.Add(this.label9);
            this.grbPMT.Controls.Add(this.label8);
            this.grbPMT.Controls.Add(this.label7);
            this.grbPMT.Controls.Add(this.txtSoPMT);
            this.grbPMT.Controls.Add(this.label5);
            this.grbPMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPMT.Location = new System.Drawing.Point(548, 0);
            this.grbPMT.Margin = new System.Windows.Forms.Padding(4);
            this.grbPMT.Name = "grbPMT";
            this.grbPMT.Padding = new System.Windows.Forms.Padding(4);
            this.grbPMT.Size = new System.Drawing.Size(548, 228);
            this.grbPMT.TabIndex = 1;
            this.grbPMT.TabStop = false;
            this.grbPMT.Text = "Thông tin phiếu mượn trả";
            // 
            // dateTra
            // 
            this.dateTra.CustomFormat = " ";
            this.dateTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTra.Location = new System.Drawing.Point(275, 96);
            this.dateTra.Margin = new System.Windows.Forms.Padding(4);
            this.dateTra.Name = "dateTra";
            this.dateTra.Size = new System.Drawing.Size(232, 22);
            this.dateTra.TabIndex = 20;
            this.dateTra.ValueChanged += new System.EventHandler(this.dateTra_ValueChanged);
            // 
            // dateHtra
            // 
            this.dateHtra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHtra.Location = new System.Drawing.Point(8, 150);
            this.dateHtra.Margin = new System.Windows.Forms.Padding(4);
            this.dateHtra.Name = "dateHtra";
            this.dateHtra.Size = new System.Drawing.Size(232, 22);
            this.dateHtra.TabIndex = 19;
            // 
            // dateLap
            // 
            this.dateLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLap.Location = new System.Drawing.Point(8, 96);
            this.dateLap.Margin = new System.Windows.Forms.Padding(4);
            this.dateLap.Name = "dateLap";
            this.dateLap.Size = new System.Drawing.Size(232, 22);
            this.dateLap.TabIndex = 18;
            this.dateLap.ValueChanged += new System.EventHandler(this.dateLap_ValueChanged);
            // 
            // txtMTT
            // 
            this.txtMTT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMTT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMTT.Location = new System.Drawing.Point(275, 149);
            this.txtMTT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMTT.MaxLength = 10;
            this.txtMTT.Name = "txtMTT";
            this.txtMTT.Size = new System.Drawing.Size(232, 22);
            this.txtMTT.TabIndex = 13;
            this.txtMTT.TextChanged += new System.EventHandler(this.txtMTT_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 129);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Mã thủ thư";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ngày trả";
            // 
            // txtMDG2
            // 
            this.txtMDG2.Location = new System.Drawing.Point(275, 46);
            this.txtMDG2.Margin = new System.Windows.Forms.Padding(4);
            this.txtMDG2.MaxLength = 10;
            this.txtMDG2.Name = "txtMDG2";
            this.txtMDG2.Size = new System.Drawing.Size(232, 22);
            this.txtMDG2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã độc giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày hẹn trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày lập";
            // 
            // txtSoPMT
            // 
            this.txtSoPMT.Location = new System.Drawing.Point(8, 46);
            this.txtSoPMT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoPMT.MaxLength = 10;
            this.txtSoPMT.Name = "txtSoPMT";
            this.txtSoPMT.Size = new System.Drawing.Size(232, 22);
            this.txtSoPMT.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số phiếu mượn trả";
            // 
            // grbDG
            // 
            this.grbDG.Controls.Add(this.btnTra);
            this.grbDG.Controls.Add(this.btnMuon);
            this.grbDG.Controls.Add(this.btnXem);
            this.grbDG.Controls.Add(this.txtSDT);
            this.grbDG.Controls.Add(this.label6);
            this.grbDG.Controls.Add(this.txtLoai);
            this.grbDG.Controls.Add(this.label4);
            this.grbDG.Controls.Add(this.groupBox2);
            this.grbDG.Controls.Add(this.txtNgaySinh);
            this.grbDG.Controls.Add(this.label3);
            this.grbDG.Controls.Add(this.txtTenDG);
            this.grbDG.Controls.Add(this.label2);
            this.grbDG.Controls.Add(this.txtMDG1);
            this.grbDG.Controls.Add(this.label1);
            this.grbDG.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbDG.Location = new System.Drawing.Point(0, 0);
            this.grbDG.Margin = new System.Windows.Forms.Padding(4);
            this.grbDG.Name = "grbDG";
            this.grbDG.Padding = new System.Windows.Forms.Padding(4);
            this.grbDG.Size = new System.Drawing.Size(548, 228);
            this.grbDG.TabIndex = 0;
            this.grbDG.TabStop = false;
            this.grbDG.Text = "Thông tin độc giả";
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(292, 46);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(232, 22);
            this.txtSDT.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số điện thoại";
            // 
            // txtLoai
            // 
            this.txtLoai.Enabled = false;
            this.txtLoai.Location = new System.Drawing.Point(292, 150);
            this.txtLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(232, 22);
            this.txtLoai.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại độc giả";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbNu);
            this.groupBox2.Controls.Add(this.rdbNam);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(292, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(181, 44);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(97, 20);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(47, 21);
            this.rdbNu.TabIndex = 1;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(8, 20);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(58, 21);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Enabled = false;
            this.txtNgaySinh.Location = new System.Drawing.Point(8, 149);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(232, 22);
            this.txtNgaySinh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // txtTenDG
            // 
            this.txtTenDG.Enabled = false;
            this.txtTenDG.Location = new System.Drawing.Point(8, 96);
            this.txtTenDG.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(232, 22);
            this.txtTenDG.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên độc giả";
            // 
            // txtMDG1
            // 
            this.txtMDG1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMDG1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMDG1.Location = new System.Drawing.Point(8, 46);
            this.txtMDG1.Margin = new System.Windows.Forms.Padding(4);
            this.txtMDG1.MaxLength = 10;
            this.txtMDG1.Name = "txtMDG1";
            this.txtMDG1.Size = new System.Drawing.Size(232, 22);
            this.txtMDG1.TabIndex = 1;
            this.txtMDG1.TextChanged += new System.EventHandler(this.txtMDG1_TextChanged);
            this.txtMDG1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMDG1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // grbPM
            // 
            this.grbPM.Controls.Add(this.dgvPMT);
            this.grbPM.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbPM.Location = new System.Drawing.Point(0, 228);
            this.grbPM.Margin = new System.Windows.Forms.Padding(4);
            this.grbPM.Name = "grbPM";
            this.grbPM.Padding = new System.Windows.Forms.Padding(4);
            this.grbPM.Size = new System.Drawing.Size(548, 317);
            this.grbPM.TabIndex = 4;
            this.grbPM.TabStop = false;
            this.grbPM.Text = "Phiếu mượn trả";
            // 
            // dgvPMT
            // 
            this.dgvPMT.AllowUserToAddRows = false;
            this.dgvPMT.AllowUserToDeleteRows = false;
            this.dgvPMT.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvPMT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPMT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPMT.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPMT.ColumnHeadersHeight = 29;
            this.dgvPMT.Location = new System.Drawing.Point(4, 19);
            this.dgvPMT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPMT.MultiSelect = false;
            this.dgvPMT.Name = "dgvPMT";
            this.dgvPMT.ReadOnly = true;
            this.dgvPMT.RowHeadersVisible = false;
            this.dgvPMT.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvPMT.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPMT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPMT.Size = new System.Drawing.Size(540, 294);
            this.dgvPMT.TabIndex = 5;
            this.dgvPMT.TabStop = false;
            this.dgvPMT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPMT_CellClick);
            this.dgvPMT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPMT_MouseClick);
            // 
            // grbCTM
            // 
            this.grbCTM.Controls.Add(this.dgvCTM);
            this.grbCTM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCTM.Location = new System.Drawing.Point(548, 228);
            this.grbCTM.Margin = new System.Windows.Forms.Padding(4);
            this.grbCTM.Name = "grbCTM";
            this.grbCTM.Padding = new System.Windows.Forms.Padding(4);
            this.grbCTM.Size = new System.Drawing.Size(548, 317);
            this.grbCTM.TabIndex = 8;
            this.grbCTM.TabStop = false;
            this.grbCTM.Text = "Chi tiết mượn";
            // 
            // dgvCTM
            // 
            this.dgvCTM.AllowUserToAddRows = false;
            this.dgvCTM.AllowUserToDeleteRows = false;
            this.dgvCTM.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvCTM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCTM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCTM.ColumnHeadersHeight = 29;
            this.dgvCTM.Location = new System.Drawing.Point(4, 19);
            this.dgvCTM.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCTM.MultiSelect = false;
            this.dgvCTM.Name = "dgvCTM";
            this.dgvCTM.ReadOnly = true;
            this.dgvCTM.RowHeadersVisible = false;
            this.dgvCTM.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvCTM.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCTM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTM.Size = new System.Drawing.Size(540, 294);
            this.dgvCTM.TabIndex = 5;
            this.dgvCTM.TabStop = false;
            this.dgvCTM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCTM_MouseClick);
            // 
            // cmsPMT
            // 
            this.cmsPMT.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPMT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmXemPhieu,
            this.tlmSuaChiTiet});
            this.cmsPMT.Name = "cmsPMT";
            this.cmsPMT.Size = new System.Drawing.Size(199, 52);
            // 
            // tlmXemPhieu
            // 
            this.tlmXemPhieu.Name = "tlmXemPhieu";
            this.tlmXemPhieu.Size = new System.Drawing.Size(198, 24);
            this.tlmXemPhieu.Text = "Xem chi tiết phiếu";
            this.tlmXemPhieu.Click += new System.EventHandler(this.tlmXemPhieu_Click);
            // 
            // tlmSuaChiTiet
            // 
            this.tlmSuaChiTiet.Name = "tlmSuaChiTiet";
            this.tlmSuaChiTiet.Size = new System.Drawing.Size(198, 24);
            this.tlmSuaChiTiet.Text = "Sửa chi tiết phiếu";
            // 
            // cmsCTM
            // 
            this.cmsCTM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCTM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmTrangThai});
            this.cmsCTM.Name = "contextMenuStrip1";
            this.cmsCTM.Size = new System.Drawing.Size(205, 28);
            // 
            // tlmTrangThai
            // 
            this.tlmTrangThai.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmHong,
            this.tlmMat});
            this.tlmTrangThai.Name = "tlmTrangThai";
            this.tlmTrangThai.Size = new System.Drawing.Size(204, 24);
            this.tlmTrangThai.Text = "Sửa trạng thái sách";
            // 
            // tlmHong
            // 
            this.tlmHong.Name = "tlmHong";
            this.tlmHong.Size = new System.Drawing.Size(129, 26);
            this.tlmHong.Text = "Hỏng";
            this.tlmHong.Click += new System.EventHandler(this.tlmHong_Click);
            // 
            // tlmMat
            // 
            this.tlmMat.Name = "tlmMat";
            this.tlmMat.Size = new System.Drawing.Size(129, 26);
            this.tlmMat.Text = "Mất";
            this.tlmMat.Click += new System.EventHandler(this.tlmMat_Click);
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.Active = false;
            this.btnGhiNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnGhiNhan.BoderColorDisable = System.Drawing.Color.Empty;
            this.btnGhiNhan.BorderColorClick = System.Drawing.Color.Empty;
            this.btnGhiNhan.BorderColorHover = System.Drawing.Color.Empty;
            this.btnGhiNhan.BorderColorNomal = System.Drawing.Color.Green;
            this.btnGhiNhan.ForeColor = System.Drawing.Color.Black;
            this.btnGhiNhan.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGhiNhan.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnGhiNhan.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGhiNhan.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnGhiNhan.Location = new System.Drawing.Point(8, 192);
            this.btnGhiNhan.Margin = new System.Windows.Forms.Padding(5);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(100, 28);
            this.btnGhiNhan.SizeBorder = 1;
            this.btnGhiNhan.TabIndex = 17;
            this.btnGhiNhan.Text = "Ghi nhận";
            this.btnGhiNhan.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnGhiNhan.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnGhiNhan.TextColorClick = System.Drawing.Color.Empty;
            this.btnGhiNhan.TextColorDisable = System.Drawing.Color.Empty;
            this.btnGhiNhan.TextColorHover = System.Drawing.Color.Empty;
            this.btnGhiNhan.TextColorNomal = System.Drawing.Color.Black;
            this.btnGhiNhan.UseActive = false;
            this.btnGhiNhan.UseBorderColorHoverClick = false;
            this.btnGhiNhan.UseInnerColorHoverClick = true;
            this.btnGhiNhan.UseTextColorHoverClick = false;
            this.btnGhiNhan.Click += new System.EventHandler(this.btnGhiNhan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Active = false;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BoderColorDisable = System.Drawing.Color.Empty;
            this.btnXoa.BorderColorClick = System.Drawing.Color.Empty;
            this.btnXoa.BorderColorHover = System.Drawing.Color.Empty;
            this.btnXoa.BorderColorNomal = System.Drawing.Color.Green;
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnXoa.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnXoa.Location = new System.Drawing.Point(408, 192);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.SizeBorder = 1;
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnXoa.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnXoa.TextColorClick = System.Drawing.Color.Empty;
            this.btnXoa.TextColorDisable = System.Drawing.Color.Empty;
            this.btnXoa.TextColorHover = System.Drawing.Color.Empty;
            this.btnXoa.TextColorNomal = System.Drawing.Color.Black;
            this.btnXoa.UseActive = false;
            this.btnXoa.UseBorderColorHoverClick = false;
            this.btnXoa.UseInnerColorHoverClick = true;
            this.btnXoa.UseTextColorHoverClick = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Active = false;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BoderColorDisable = System.Drawing.Color.Red;
            this.btnSua.BorderColorClick = System.Drawing.Color.Empty;
            this.btnSua.BorderColorHover = System.Drawing.Color.Empty;
            this.btnSua.BorderColorNomal = System.Drawing.Color.Green;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSua.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnSua.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnSua.Location = new System.Drawing.Point(275, 192);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.SizeBorder = 1;
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnSua.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnSua.TextColorClick = System.Drawing.Color.Empty;
            this.btnSua.TextColorDisable = System.Drawing.Color.Black;
            this.btnSua.TextColorHover = System.Drawing.Color.Empty;
            this.btnSua.TextColorNomal = System.Drawing.Color.Black;
            this.btnSua.UseActive = true;
            this.btnSua.UseBorderColorHoverClick = false;
            this.btnSua.UseInnerColorHoverClick = true;
            this.btnSua.UseTextColorHoverClick = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTra
            // 
            this.btnTra.Active = false;
            this.btnTra.BackColor = System.Drawing.Color.Transparent;
            this.btnTra.BoderColorDisable = System.Drawing.Color.Empty;
            this.btnTra.BorderColorClick = System.Drawing.Color.Empty;
            this.btnTra.BorderColorHover = System.Drawing.Color.Empty;
            this.btnTra.BorderColorNomal = System.Drawing.Color.Green;
            this.btnTra.ForeColor = System.Drawing.Color.Black;
            this.btnTra.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTra.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnTra.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTra.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnTra.Location = new System.Drawing.Point(425, 192);
            this.btnTra.Margin = new System.Windows.Forms.Padding(5);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(100, 28);
            this.btnTra.SizeBorder = 1;
            this.btnTra.TabIndex = 17;
            this.btnTra.Text = "Trả sách";
            this.btnTra.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnTra.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnTra.TextColorClick = System.Drawing.Color.Empty;
            this.btnTra.TextColorDisable = System.Drawing.Color.Empty;
            this.btnTra.TextColorHover = System.Drawing.Color.Empty;
            this.btnTra.TextColorNomal = System.Drawing.Color.Black;
            this.btnTra.UseActive = false;
            this.btnTra.UseBorderColorHoverClick = false;
            this.btnTra.UseInnerColorHoverClick = true;
            this.btnTra.UseTextColorHoverClick = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.Active = false;
            this.btnMuon.BackColor = System.Drawing.Color.Transparent;
            this.btnMuon.BoderColorDisable = System.Drawing.Color.Empty;
            this.btnMuon.BorderColorClick = System.Drawing.Color.Empty;
            this.btnMuon.BorderColorHover = System.Drawing.Color.Empty;
            this.btnMuon.BorderColorNomal = System.Drawing.Color.Green;
            this.btnMuon.ForeColor = System.Drawing.Color.Black;
            this.btnMuon.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMuon.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnMuon.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMuon.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnMuon.Location = new System.Drawing.Point(292, 192);
            this.btnMuon.Margin = new System.Windows.Forms.Padding(5);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(100, 28);
            this.btnMuon.SizeBorder = 1;
            this.btnMuon.TabIndex = 16;
            this.btnMuon.Text = "Mượn sách";
            this.btnMuon.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnMuon.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnMuon.TextColorClick = System.Drawing.Color.Empty;
            this.btnMuon.TextColorDisable = System.Drawing.Color.Empty;
            this.btnMuon.TextColorHover = System.Drawing.Color.Empty;
            this.btnMuon.TextColorNomal = System.Drawing.Color.Black;
            this.btnMuon.UseActive = false;
            this.btnMuon.UseBorderColorHoverClick = false;
            this.btnMuon.UseInnerColorHoverClick = true;
            this.btnMuon.UseTextColorHoverClick = false;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // btnXem
            // 
            this.btnXem.Active = false;
            this.btnXem.BackColor = System.Drawing.Color.Transparent;
            this.btnXem.BoderColorDisable = System.Drawing.Color.Empty;
            this.btnXem.BorderColorClick = System.Drawing.Color.Empty;
            this.btnXem.BorderColorHover = System.Drawing.Color.Empty;
            this.btnXem.BorderColorNomal = System.Drawing.Color.Green;
            this.btnXem.ForeColor = System.Drawing.Color.Black;
            this.btnXem.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXem.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnXem.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXem.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnXem.Location = new System.Drawing.Point(8, 192);
            this.btnXem.Margin = new System.Windows.Forms.Padding(5);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 28);
            this.btnXem.SizeBorder = 1;
            this.btnXem.TabIndex = 15;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnXem.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnXem.TextColorClick = System.Drawing.Color.Empty;
            this.btnXem.TextColorDisable = System.Drawing.Color.Empty;
            this.btnXem.TextColorHover = System.Drawing.Color.Empty;
            this.btnXem.TextColorNomal = System.Drawing.Color.Black;
            this.btnXem.UseActive = false;
            this.btnXem.UseBorderColorHoverClick = false;
            this.btnXem.UseInnerColorHoverClick = true;
            this.btnXem.UseTextColorHoverClick = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // MuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbCTM);
            this.Controls.Add(this.grbPM);
            this.Controls.Add(this.pnlTool);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MuonTra";
            this.Size = new System.Drawing.Size(1096, 545);
            this.Load += new System.EventHandler(this.MuonTra_Load);
            this.Resize += new System.EventHandler(this.MuonTra_Resize);
            this.pnlTool.ResumeLayout(false);
            this.grbPMT.ResumeLayout(false);
            this.grbPMT.PerformLayout();
            this.grbDG.ResumeLayout(false);
            this.grbDG.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPMT)).EndInit();
            this.grbCTM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTM)).EndInit();
            this.cmsPMT.ResumeLayout(false);
            this.cmsCTM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.GroupBox grbDG;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMDG1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbPMT;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoPMT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private ComponentForm.Thin_Button btnGhiNhan;
        private ComponentForm.Thin_Button btnXoa;
        private ComponentForm.Thin_Button btnSua;
        private System.Windows.Forms.TextBox txtMTT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMDG2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private ComponentForm.Thin_Button btnTra;
        private ComponentForm.Thin_Button btnMuon;
        private ComponentForm.Thin_Button btnXem;
        private System.Windows.Forms.GroupBox grbPM;
        private System.Windows.Forms.DataGridView dgvPMT;
        private System.Windows.Forms.GroupBox grbCTM;
        private System.Windows.Forms.DataGridView dgvCTM;
        private System.Windows.Forms.DateTimePicker dateTra;
        private System.Windows.Forms.DateTimePicker dateHtra;
        private System.Windows.Forms.DateTimePicker dateLap;
        private System.Windows.Forms.ContextMenuStrip cmsPMT;
        private System.Windows.Forms.ToolStripMenuItem tlmXemPhieu;
        private System.Windows.Forms.ToolStripMenuItem tlmSuaChiTiet;
        private System.Windows.Forms.ContextMenuStrip cmsCTM;
        private System.Windows.Forms.ToolStripMenuItem tlmTrangThai;
        private System.Windows.Forms.ToolStripMenuItem tlmHong;
        private System.Windows.Forms.ToolStripMenuItem tlmMat;
    }
}
