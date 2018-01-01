namespace MOffice
{
    partial class SoVanBanDenTinhForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoVanBanDenTinhForm));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.txtTenFile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtTrichYeu = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbCoQuan = new System.Windows.Forms.ComboBox();
            this.coQuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbLoaiVanBan = new System.Windows.Forms.ComboBox();
            this.loaiVanBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoKyHieu = new System.Windows.Forms.TextBox();
            this.txtSoDen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayBanHanh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.PanelFill = new System.Windows.Forms.Panel();
            this.dgvVanBanDenTinh = new System.Windows.Forms.DataGridView();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OpenFolder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ngayDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soKyHieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trichYeuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vanBanDenTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).BeginInit();
            this.PanelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanBanDenTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenTinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.txtTenFile);
            this.PanelTop.Controls.Add(this.label9);
            this.PanelTop.Controls.Add(this.label10);
            this.PanelTop.Controls.Add(this.txtNguoiNhan);
            this.PanelTop.Controls.Add(this.btnTimKiem);
            this.PanelTop.Controls.Add(this.btnIn);
            this.PanelTop.Controls.Add(this.btnCopy);
            this.PanelTop.Controls.Add(this.btnCapNhat);
            this.PanelTop.Controls.Add(this.btnThem);
            this.PanelTop.Controls.Add(this.txtTimKiem);
            this.PanelTop.Controls.Add(this.txtGhiChu);
            this.PanelTop.Controls.Add(this.txtTrichYeu);
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.label6);
            this.PanelTop.Controls.Add(this.label7);
            this.PanelTop.Controls.Add(this.cbbCoQuan);
            this.PanelTop.Controls.Add(this.cbbLoaiVanBan);
            this.PanelTop.Controls.Add(this.label3);
            this.PanelTop.Controls.Add(this.label2);
            this.PanelTop.Controls.Add(this.txtSoKyHieu);
            this.PanelTop.Controls.Add(this.txtSoDen);
            this.PanelTop.Controls.Add(this.label4);
            this.PanelTop.Controls.Add(this.label5);
            this.PanelTop.Controls.Add(this.dtpNgayBanHanh);
            this.PanelTop.Controls.Add(this.dtpNgayDen);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1027, 206);
            this.PanelTop.TabIndex = 0;
            // 
            // txtTenFile
            // 
            this.txtTenFile.Location = new System.Drawing.Point(448, 55);
            this.txtTenFile.Name = "txtTenFile";
            this.txtTenFile.Size = new System.Drawing.Size(177, 20);
            this.txtTenFile.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(631, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Ghi chú";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 84;
            this.label10.Text = "Người nhận";
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.Location = new System.Drawing.Point(87, 149);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(355, 20);
            this.txtNguoiNhan.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(448, 175);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(448, 146);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In sổ";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(631, 53);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(44, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(448, 117);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(448, 88);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(87, 175);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(355, 20);
            this.txtTimKiem.TabIndex = 9;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(448, 3);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(177, 46);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.Text = "";
            // 
            // txtTrichYeu
            // 
            this.txtTrichYeu.Location = new System.Drawing.Point(87, 82);
            this.txtTrichYeu.Name = "txtTrichYeu";
            this.txtTrichYeu.Size = new System.Drawing.Size(355, 61);
            this.txtTrichYeu.TabIndex = 6;
            this.txtTrichYeu.Text = "";
            this.txtTrichYeu.TextChanged += new System.EventHandler(this.txtTrichYeu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Cơ quan ban hành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Trích yếu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Loại văn bản";
            // 
            // cbbCoQuan
            // 
            this.cbbCoQuan.DataSource = this.coQuanBindingSource;
            this.cbbCoQuan.DisplayMember = "Ten";
            this.cbbCoQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoQuan.FormattingEnabled = true;
            this.cbbCoQuan.Location = new System.Drawing.Point(318, 55);
            this.cbbCoQuan.Name = "cbbCoQuan";
            this.cbbCoQuan.Size = new System.Drawing.Size(124, 21);
            this.cbbCoQuan.TabIndex = 5;
            this.cbbCoQuan.ValueMember = "Id";
            // 
            // coQuanBindingSource
            // 
            this.coQuanBindingSource.DataSource = typeof(MOffice.CoQuan);
            // 
            // cbbLoaiVanBan
            // 
            this.cbbLoaiVanBan.DataSource = this.loaiVanBanBindingSource;
            this.cbbLoaiVanBan.DisplayMember = "Ten";
            this.cbbLoaiVanBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiVanBan.FormattingEnabled = true;
            this.cbbLoaiVanBan.Location = new System.Drawing.Point(87, 55);
            this.cbbLoaiVanBan.Name = "cbbLoaiVanBan";
            this.cbbLoaiVanBan.Size = new System.Drawing.Size(124, 21);
            this.cbbLoaiVanBan.TabIndex = 2;
            this.cbbLoaiVanBan.ValueMember = "Id";
            // 
            // loaiVanBanBindingSource
            // 
            this.loaiVanBanBindingSource.DataSource = typeof(MOffice.LoaiVanBan);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Số, ký hiệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Số đến";
            // 
            // txtSoKyHieu
            // 
            this.txtSoKyHieu.Location = new System.Drawing.Point(318, 29);
            this.txtSoKyHieu.Name = "txtSoKyHieu";
            this.txtSoKyHieu.Size = new System.Drawing.Size(124, 20);
            this.txtSoKyHieu.TabIndex = 4;
            this.txtSoKyHieu.TextChanged += new System.EventHandler(this.txtSoKyHieu_TextChanged);
            // 
            // txtSoDen
            // 
            this.txtSoDen.Location = new System.Drawing.Point(87, 29);
            this.txtSoDen.Name = "txtSoDen";
            this.txtSoDen.Size = new System.Drawing.Size(124, 20);
            this.txtSoDen.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Ngày ban hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Ngày đến";
            // 
            // dtpNgayBanHanh
            // 
            this.dtpNgayBanHanh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBanHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBanHanh.Location = new System.Drawing.Point(318, 3);
            this.dtpNgayBanHanh.Name = "dtpNgayBanHanh";
            this.dtpNgayBanHanh.Size = new System.Drawing.Size(124, 20);
            this.dtpNgayBanHanh.TabIndex = 3;
            this.dtpNgayBanHanh.ValueChanged += new System.EventHandler(this.dtpNgayBanHanh_ValueChanged);
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(87, 3);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(124, 20);
            this.dtpNgayDen.TabIndex = 0;
            this.dtpNgayDen.ValueChanged += new System.EventHandler(this.dtpNgayDen_ValueChanged);
            // 
            // PanelFill
            // 
            this.PanelFill.Controls.Add(this.dgvVanBanDenTinh);
            this.PanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill.Location = new System.Drawing.Point(0, 206);
            this.PanelFill.Name = "PanelFill";
            this.PanelFill.Size = new System.Drawing.Size(1027, 318);
            this.PanelFill.TabIndex = 2;
            // 
            // dgvVanBanDenTinh
            // 
            this.dgvVanBanDenTinh.AllowUserToAddRows = false;
            this.dgvVanBanDenTinh.AllowUserToDeleteRows = false;
            this.dgvVanBanDenTinh.AutoGenerateColumns = false;
            this.dgvVanBanDenTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVanBanDenTinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa,
            this.OpenFolder,
            this.ngayDenDataGridViewTextBoxColumn,
            this.soDenDataGridViewTextBoxColumn,
            this.soKyHieuDataGridViewTextBoxColumn,
            this.ngayBanHanhDataGridViewTextBoxColumn,
            this.trichYeuDataGridViewTextBoxColumn,
            this.nguoiNhanDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.updateDateDataGridViewTextBoxColumn});
            this.dgvVanBanDenTinh.DataSource = this.vanBanDenTinhBindingSource;
            this.dgvVanBanDenTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVanBanDenTinh.Location = new System.Drawing.Point(0, 0);
            this.dgvVanBanDenTinh.MultiSelect = false;
            this.dgvVanBanDenTinh.Name = "dgvVanBanDenTinh";
            this.dgvVanBanDenTinh.ReadOnly = true;
            this.dgvVanBanDenTinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVanBanDenTinh.Size = new System.Drawing.Size(1027, 318);
            this.dgvVanBanDenTinh.TabIndex = 2;
            this.dgvVanBanDenTinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVanBanDenTinh_CellContentClick);
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Xoa.Text = "X";
            this.Xoa.UseColumnTextForButtonValue = true;
            this.Xoa.Width = 35;
            // 
            // OpenFolder
            // 
            this.OpenFolder.HeaderText = "Thư mục";
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.ReadOnly = true;
            this.OpenFolder.Text = "Mở";
            this.OpenFolder.UseColumnTextForButtonValue = true;
            this.OpenFolder.Width = 55;
            // 
            // ngayDenDataGridViewTextBoxColumn
            // 
            this.ngayDenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngayDenDataGridViewTextBoxColumn.DataPropertyName = "NgayDen";
            this.ngayDenDataGridViewTextBoxColumn.HeaderText = "NgayDen";
            this.ngayDenDataGridViewTextBoxColumn.Name = "ngayDenDataGridViewTextBoxColumn";
            this.ngayDenDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayDenDataGridViewTextBoxColumn.Width = 77;
            // 
            // soDenDataGridViewTextBoxColumn
            // 
            this.soDenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soDenDataGridViewTextBoxColumn.DataPropertyName = "SoDen";
            this.soDenDataGridViewTextBoxColumn.HeaderText = "SoDen";
            this.soDenDataGridViewTextBoxColumn.Name = "soDenDataGridViewTextBoxColumn";
            this.soDenDataGridViewTextBoxColumn.ReadOnly = true;
            this.soDenDataGridViewTextBoxColumn.Width = 65;
            // 
            // soKyHieuDataGridViewTextBoxColumn
            // 
            this.soKyHieuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soKyHieuDataGridViewTextBoxColumn.DataPropertyName = "SoKyHieu";
            this.soKyHieuDataGridViewTextBoxColumn.HeaderText = "SoKyHieu";
            this.soKyHieuDataGridViewTextBoxColumn.Name = "soKyHieuDataGridViewTextBoxColumn";
            this.soKyHieuDataGridViewTextBoxColumn.ReadOnly = true;
            this.soKyHieuDataGridViewTextBoxColumn.Width = 79;
            // 
            // ngayBanHanhDataGridViewTextBoxColumn
            // 
            this.ngayBanHanhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngayBanHanhDataGridViewTextBoxColumn.DataPropertyName = "NgayBanHanh";
            this.ngayBanHanhDataGridViewTextBoxColumn.HeaderText = "NgayBanHanh";
            this.ngayBanHanhDataGridViewTextBoxColumn.Name = "ngayBanHanhDataGridViewTextBoxColumn";
            this.ngayBanHanhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayBanHanhDataGridViewTextBoxColumn.Width = 102;
            // 
            // trichYeuDataGridViewTextBoxColumn
            // 
            this.trichYeuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.trichYeuDataGridViewTextBoxColumn.DataPropertyName = "TrichYeu";
            this.trichYeuDataGridViewTextBoxColumn.HeaderText = "TrichYeu";
            this.trichYeuDataGridViewTextBoxColumn.Name = "trichYeuDataGridViewTextBoxColumn";
            this.trichYeuDataGridViewTextBoxColumn.ReadOnly = true;
            this.trichYeuDataGridViewTextBoxColumn.Width = 75;
            // 
            // nguoiNhanDataGridViewTextBoxColumn
            // 
            this.nguoiNhanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nguoiNhanDataGridViewTextBoxColumn.DataPropertyName = "NguoiNhan";
            this.nguoiNhanDataGridViewTextBoxColumn.HeaderText = "NguoiNhan";
            this.nguoiNhanDataGridViewTextBoxColumn.Name = "nguoiNhanDataGridViewTextBoxColumn";
            this.nguoiNhanDataGridViewTextBoxColumn.ReadOnly = true;
            this.nguoiNhanDataGridViewTextBoxColumn.Width = 86;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiChuDataGridViewTextBoxColumn.Width = 67;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            this.pathDataGridViewTextBoxColumn.Width = 54;
            // 
            // updateDateDataGridViewTextBoxColumn
            // 
            this.updateDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.updateDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDate";
            this.updateDateDataGridViewTextBoxColumn.HeaderText = "UpdateDate";
            this.updateDateDataGridViewTextBoxColumn.Name = "updateDateDataGridViewTextBoxColumn";
            this.updateDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.updateDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // vanBanDenTinhBindingSource
            // 
            this.vanBanDenTinhBindingSource.DataSource = typeof(MOffice.VanBanDenTinh);
            // 
            // SoVanBanDenTinhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 524);
            this.Controls.Add(this.PanelFill);
            this.Controls.Add(this.PanelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoVanBanDenTinhForm";
            this.Text = "Sổ văn bản đến - TỈNH";
            this.Load += new System.EventHandler(this.SoVanBanDenTinhForm_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).EndInit();
            this.PanelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanBanDenTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenTinhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelFill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoDen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbLoaiVanBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCoQuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoKyHieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayBanHanh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.RichTextBox txtTrichYeu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvVanBanDenTinh;
        private System.Windows.Forms.BindingSource loaiVanBanBindingSource;
        private System.Windows.Forms.BindingSource coQuanBindingSource;
        private System.Windows.Forms.BindingSource vanBanDenTinhBindingSource;
        private System.Windows.Forms.TextBox txtTenFile;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewButtonColumn OpenFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soKyHieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trichYeuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiNhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
    }
}