namespace MOffice
{
    partial class SoVanBanDenHuyenForm
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
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.vanBanDenHuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTrichYeu = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayBanHanh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoKyHieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCoQuanBanHanh = new System.Windows.Forms.ComboBox();
            this.coQuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cbLoaiVanBan = new System.Windows.Forms.ComboBox();
            this.loaiVanBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoDen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.PanelGrid = new System.Windows.Forms.Panel();
            this.dgvVanBanDenHuyen = new System.Windows.Forms.DataGridView();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OpenFolder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ngayDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soKyHieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trichYeuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelButton = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.PanelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenHuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).BeginInit();
            this.PanelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanBanDenHuyen)).BeginInit();
            this.PanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAdd
            // 
            this.PanelAdd.Controls.Add(this.label6);
            this.PanelAdd.Controls.Add(this.txtNguoiNhan);
            this.PanelAdd.Controls.Add(this.txtGhiChu);
            this.PanelAdd.Controls.Add(this.label8);
            this.PanelAdd.Controls.Add(this.txtTrichYeu);
            this.PanelAdd.Controls.Add(this.label9);
            this.PanelAdd.Controls.Add(this.label1);
            this.PanelAdd.Controls.Add(this.dtpNgayBanHanh);
            this.PanelAdd.Controls.Add(this.label4);
            this.PanelAdd.Controls.Add(this.txtSoKyHieu);
            this.PanelAdd.Controls.Add(this.label3);
            this.PanelAdd.Controls.Add(this.cbbCoQuanBanHanh);
            this.PanelAdd.Controls.Add(this.label7);
            this.PanelAdd.Controls.Add(this.cbLoaiVanBan);
            this.PanelAdd.Controls.Add(this.label2);
            this.PanelAdd.Controls.Add(this.txtSoDen);
            this.PanelAdd.Controls.Add(this.label5);
            this.PanelAdd.Controls.Add(this.dtpNgayDen);
            this.PanelAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelAdd.Location = new System.Drawing.Point(0, 0);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(458, 524);
            this.PanelAdd.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Người nhận";
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanBanDenHuyenBindingSource, "NguoiNhan", true));
            this.txtNguoiNhan.Location = new System.Drawing.Point(136, 228);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(307, 20);
            this.txtNguoiNhan.TabIndex = 7;
            // 
            // vanBanDenHuyenBindingSource
            // 
            this.vanBanDenHuyenBindingSource.DataSource = typeof(MOffice.VanBanDenHuyen);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanBanDenHuyenBindingSource, "GhiChu", true));
            this.txtGhiChu.Location = new System.Drawing.Point(136, 254);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(307, 61);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Ghi chú";
            // 
            // txtTrichYeu
            // 
            this.txtTrichYeu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanBanDenHuyenBindingSource, "TrichYeu", true));
            this.txtTrichYeu.Location = new System.Drawing.Point(136, 161);
            this.txtTrichYeu.Name = "txtTrichYeu";
            this.txtTrichYeu.Size = new System.Drawing.Size(307, 61);
            this.txtTrichYeu.TabIndex = 6;
            this.txtTrichYeu.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Trích yếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Ngày ban hành";
            // 
            // dtpNgayBanHanh
            // 
            this.dtpNgayBanHanh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBanHanh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vanBanDenHuyenBindingSource, "NgayBanHanh", true));
            this.dtpNgayBanHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBanHanh.Location = new System.Drawing.Point(136, 135);
            this.dtpNgayBanHanh.Name = "dtpNgayBanHanh";
            this.dtpNgayBanHanh.Size = new System.Drawing.Size(307, 20);
            this.dtpNgayBanHanh.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Số ký hiệu";
            // 
            // txtSoKyHieu
            // 
            this.txtSoKyHieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanBanDenHuyenBindingSource, "SoKyHieu", true));
            this.txtSoKyHieu.Location = new System.Drawing.Point(136, 109);
            this.txtSoKyHieu.Name = "txtSoKyHieu";
            this.txtSoKyHieu.Size = new System.Drawing.Size(307, 20);
            this.txtSoKyHieu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Cơ quan ban hành";
            // 
            // cbbCoQuanBanHanh
            // 
            this.cbbCoQuanBanHanh.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.vanBanDenHuyenBindingSource, "CoQuan", true));
            this.cbbCoQuanBanHanh.DataSource = this.coQuanBindingSource;
            this.cbbCoQuanBanHanh.DisplayMember = "Ten";
            this.cbbCoQuanBanHanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoQuanBanHanh.FormattingEnabled = true;
            this.cbbCoQuanBanHanh.Location = new System.Drawing.Point(136, 82);
            this.cbbCoQuanBanHanh.Name = "cbbCoQuanBanHanh";
            this.cbbCoQuanBanHanh.Size = new System.Drawing.Size(307, 21);
            this.cbbCoQuanBanHanh.TabIndex = 3;
            this.cbbCoQuanBanHanh.ValueMember = "Id";
            // 
            // coQuanBindingSource
            // 
            this.coQuanBindingSource.DataSource = typeof(MOffice.CoQuan);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Loại văn bản";
            // 
            // cbLoaiVanBan
            // 
            this.cbLoaiVanBan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.vanBanDenHuyenBindingSource, "LoaiVanBan", true));
            this.cbLoaiVanBan.DataSource = this.loaiVanBanBindingSource;
            this.cbLoaiVanBan.DisplayMember = "Ten";
            this.cbLoaiVanBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiVanBan.FormattingEnabled = true;
            this.cbLoaiVanBan.Location = new System.Drawing.Point(136, 55);
            this.cbLoaiVanBan.Name = "cbLoaiVanBan";
            this.cbLoaiVanBan.Size = new System.Drawing.Size(307, 21);
            this.cbLoaiVanBan.TabIndex = 2;
            this.cbLoaiVanBan.ValueMember = "Id";
            // 
            // loaiVanBanBindingSource
            // 
            this.loaiVanBanBindingSource.DataSource = typeof(MOffice.LoaiVanBan);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Số đến";
            // 
            // txtSoDen
            // 
            this.txtSoDen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanBanDenHuyenBindingSource, "SoDen", true));
            this.txtSoDen.Location = new System.Drawing.Point(136, 29);
            this.txtSoDen.Name = "txtSoDen";
            this.txtSoDen.Size = new System.Drawing.Size(307, 20);
            this.txtSoDen.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Ngày đến";
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vanBanDenHuyenBindingSource, "NgayDen", true));
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(136, 3);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(307, 20);
            this.dtpNgayDen.TabIndex = 0;
            this.dtpNgayDen.ValueChanged += new System.EventHandler(this.dtpNgayDen_ValueChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(87, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(6, 3);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 10;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // PanelGrid
            // 
            this.PanelGrid.Controls.Add(this.dgvVanBanDenHuyen);
            this.PanelGrid.Controls.Add(this.PanelButton);
            this.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGrid.Location = new System.Drawing.Point(458, 0);
            this.PanelGrid.Name = "PanelGrid";
            this.PanelGrid.Size = new System.Drawing.Size(569, 524);
            this.PanelGrid.TabIndex = 1;
            // 
            // dgvVanBanDenHuyen
            // 
            this.dgvVanBanDenHuyen.AllowUserToAddRows = false;
            this.dgvVanBanDenHuyen.AllowUserToDeleteRows = false;
            this.dgvVanBanDenHuyen.AutoGenerateColumns = false;
            this.dgvVanBanDenHuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVanBanDenHuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa,
            this.OpenFolder,
            this.ngayDenDataGridViewTextBoxColumn,
            this.soDenDataGridViewTextBoxColumn,
            this.soKyHieuDataGridViewTextBoxColumn,
            this.ngayBanHanhDataGridViewTextBoxColumn,
            this.trichYeuDataGridViewTextBoxColumn,
            this.nguoiNhanDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.Path,
            this.updateDateDataGridViewTextBoxColumn});
            this.dgvVanBanDenHuyen.DataSource = this.vanBanDenHuyenBindingSource;
            this.dgvVanBanDenHuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVanBanDenHuyen.Location = new System.Drawing.Point(0, 59);
            this.dgvVanBanDenHuyen.MultiSelect = false;
            this.dgvVanBanDenHuyen.Name = "dgvVanBanDenHuyen";
            this.dgvVanBanDenHuyen.ReadOnly = true;
            this.dgvVanBanDenHuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVanBanDenHuyen.Size = new System.Drawing.Size(569, 465);
            this.dgvVanBanDenHuyen.TabIndex = 1;
            this.dgvVanBanDenHuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVanBanDenHuyen_CellContentClick);
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
            this.nguoiNhanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.nguoiNhanDataGridViewTextBoxColumn.DataPropertyName = "NguoiNhan";
            this.nguoiNhanDataGridViewTextBoxColumn.HeaderText = "NguoiNhan";
            this.nguoiNhanDataGridViewTextBoxColumn.Name = "nguoiNhanDataGridViewTextBoxColumn";
            this.nguoiNhanDataGridViewTextBoxColumn.ReadOnly = true;
            this.nguoiNhanDataGridViewTextBoxColumn.Width = 5;
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
            // Path
            // 
            this.Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 54;
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
            // PanelButton
            // 
            this.PanelButton.Controls.Add(this.txtTimKiem);
            this.PanelButton.Controls.Add(this.lblMsg);
            this.PanelButton.Controls.Add(this.btnTimKiem);
            this.PanelButton.Controls.Add(this.btnTaoMoi);
            this.PanelButton.Controls.Add(this.btnPrint);
            this.PanelButton.Controls.Add(this.btnCancel);
            this.PanelButton.Controls.Add(this.btnLuu);
            this.PanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelButton.Location = new System.Drawing.Point(0, 0);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(569, 59);
            this.PanelButton.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(87, 34);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(307, 20);
            this.txtTimKiem.TabIndex = 14;
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMsg.Location = new System.Drawing.Point(330, 4);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(236, 23);
            this.lblMsg.TabIndex = 13;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(6, 32);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(249, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(168, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SoVanBanDenHuyenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 524);
            this.Controls.Add(this.PanelGrid);
            this.Controls.Add(this.PanelAdd);
            this.Name = "SoVanBanDenHuyenForm";
            this.Text = "SoVanBanDenHuyenForm";
            this.Load += new System.EventHandler(this.SoVanBanDenHuyenForm_Load);
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenHuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).EndInit();
            this.PanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanBanDenHuyen)).EndInit();
            this.PanelButton.ResumeLayout(false);
            this.PanelButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtTrichYeu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayBanHanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoKyHieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCoQuanBanHanh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbLoaiVanBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoDen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Panel PanelGrid;
        private System.Windows.Forms.Panel PanelButton;
        private System.Windows.Forms.DataGridView dgvVanBanDenHuyen;
        private System.Windows.Forms.BindingSource coQuanBindingSource;
        private System.Windows.Forms.BindingSource loaiVanBanBindingSource;
        private System.Windows.Forms.BindingSource vanBanDenHuyenBindingSource;
        private System.Windows.Forms.Button btnCancel;
        //private System.Windows.Forms.DataGridViewTextBoxColumn coQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewButtonColumn OpenFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soKyHieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trichYeuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiNhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPrint;
    }
}