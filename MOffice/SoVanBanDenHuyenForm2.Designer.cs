namespace MOffice
{
    partial class SoVanBanDenHuyenForm2
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.vanBanDenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvDinhKemFiles = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.shortFileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vanBanDenFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDinhKem = new System.Windows.Forms.Button();
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
            this.dgvVanBanDen = new System.Windows.Forms.DataGridView();
            this.DeleteVanBanDen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FolderVanBanDen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ngayDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soKyHieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trichYeuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiVanBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vanBanDenFilesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinhKemFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanBanDen)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Người nhận";
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanBanDenBindingSource, "NguoiNhan", true));
            this.txtNguoiNhan.Location = new System.Drawing.Point(142, 237);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(307, 20);
            this.txtNguoiNhan.TabIndex = 7;
            // 
            // vanBanDenBindingSource
            // 
            this.vanBanDenBindingSource.DataSource = typeof(MOffice.VanBanDen);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(374, 500);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Thêm";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvDinhKemFiles
            // 
            this.dgvDinhKemFiles.AllowUserToAddRows = false;
            this.dgvDinhKemFiles.AllowUserToDeleteRows = false;
            this.dgvDinhKemFiles.AutoGenerateColumns = false;
            this.dgvDinhKemFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDinhKemFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.shortFileNameDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn});
            this.dgvDinhKemFiles.DataSource = this.vanBanDenFileBindingSource;
            this.dgvDinhKemFiles.Location = new System.Drawing.Point(142, 330);
            this.dgvDinhKemFiles.Name = "dgvDinhKemFiles";
            this.dgvDinhKemFiles.ReadOnly = true;
            this.dgvDinhKemFiles.Size = new System.Drawing.Size(307, 164);
            this.dgvDinhKemFiles.TabIndex = 57;
            this.dgvDinhKemFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDinhKemFiles_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "X";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // shortFileNameDataGridViewTextBoxColumn
            // 
            this.shortFileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shortFileNameDataGridViewTextBoxColumn.DataPropertyName = "ShortFileName";
            this.shortFileNameDataGridViewTextBoxColumn.HeaderText = "ShortFileName";
            this.shortFileNameDataGridViewTextBoxColumn.Name = "shortFileNameDataGridViewTextBoxColumn";
            this.shortFileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.shortFileNameDataGridViewTextBoxColumn.Width = 101;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.Width = 76;
            // 
            // vanBanDenFileBindingSource
            // 
            this.vanBanDenFileBindingSource.DataSource = typeof(MOffice.VanBanDenFile);
            // 
            // btnDinhKem
            // 
            this.btnDinhKem.Location = new System.Drawing.Point(61, 330);
            this.btnDinhKem.Name = "btnDinhKem";
            this.btnDinhKem.Size = new System.Drawing.Size(75, 23);
            this.btnDinhKem.TabIndex = 9;
            this.btnDinhKem.Text = "Đính kèm";
            this.btnDinhKem.UseVisualStyleBackColor = true;
            this.btnDinhKem.Click += new System.EventHandler(this.btnDinhKem_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanBanDenBindingSource, "GhiChu", true));
            this.txtGhiChu.Location = new System.Drawing.Point(142, 263);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(307, 61);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Ghi chú";
            // 
            // txtTrichYeu
            // 
            this.txtTrichYeu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanBanDenBindingSource, "TrichYeu", true));
            this.txtTrichYeu.Location = new System.Drawing.Point(142, 170);
            this.txtTrichYeu.Name = "txtTrichYeu";
            this.txtTrichYeu.Size = new System.Drawing.Size(307, 61);
            this.txtTrichYeu.TabIndex = 6;
            this.txtTrichYeu.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Trích yếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Ngày ban hành";
            // 
            // dtpNgayBanHanh
            // 
            this.dtpNgayBanHanh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBanHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBanHanh.Location = new System.Drawing.Point(142, 144);
            this.dtpNgayBanHanh.Name = "dtpNgayBanHanh";
            this.dtpNgayBanHanh.Size = new System.Drawing.Size(172, 20);
            this.dtpNgayBanHanh.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Số ký hiệu";
            // 
            // txtSoKyHieu
            // 
            this.txtSoKyHieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanBanDenBindingSource, "SoKyHieu", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtSoKyHieu.Location = new System.Drawing.Point(142, 118);
            this.txtSoKyHieu.Name = "txtSoKyHieu";
            this.txtSoKyHieu.Size = new System.Drawing.Size(172, 20);
            this.txtSoKyHieu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Cơ quan ban hành";
            // 
            // cbbCoQuanBanHanh
            // 
            this.cbbCoQuanBanHanh.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.vanBanDenBindingSource, "CoQuan", true));
            this.cbbCoQuanBanHanh.DataSource = this.coQuanBindingSource;
            this.cbbCoQuanBanHanh.DisplayMember = "Ten";
            this.cbbCoQuanBanHanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoQuanBanHanh.FormattingEnabled = true;
            this.cbbCoQuanBanHanh.Location = new System.Drawing.Point(142, 91);
            this.cbbCoQuanBanHanh.Name = "cbbCoQuanBanHanh";
            this.cbbCoQuanBanHanh.Size = new System.Drawing.Size(172, 21);
            this.cbbCoQuanBanHanh.TabIndex = 3;
            this.cbbCoQuanBanHanh.ValueMember = "Id";
            this.cbbCoQuanBanHanh.SelectedIndexChanged += new System.EventHandler(this.cbbCoQuanBanHanh_SelectedIndexChanged);
            // 
            // coQuanBindingSource
            // 
            this.coQuanBindingSource.DataSource = typeof(MOffice.CoQuan);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Loại văn bản";
            // 
            // cbLoaiVanBan
            // 
            this.cbLoaiVanBan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.vanBanDenBindingSource, "LoaiVanBan", true));
            this.cbLoaiVanBan.DataSource = this.loaiVanBanBindingSource;
            this.cbLoaiVanBan.DisplayMember = "Ten";
            this.cbLoaiVanBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiVanBan.FormattingEnabled = true;
            this.cbLoaiVanBan.Location = new System.Drawing.Point(142, 64);
            this.cbLoaiVanBan.Name = "cbLoaiVanBan";
            this.cbLoaiVanBan.Size = new System.Drawing.Size(172, 21);
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
            this.label2.Location = new System.Drawing.Point(18, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Số đến";
            // 
            // txtSoDen
            // 
            this.txtSoDen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vanBanDenBindingSource, "SoDen", true));
            this.txtSoDen.Location = new System.Drawing.Point(142, 38);
            this.txtSoDen.Name = "txtSoDen";
            this.txtSoDen.Size = new System.Drawing.Size(172, 20);
            this.txtSoDen.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ngày đến";
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vanBanDenBindingSource, "NgayDen", true));
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(142, 12);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(172, 20);
            this.dtpNgayDen.TabIndex = 0;
            this.dtpNgayDen.ValueChanged += new System.EventHandler(this.dtpNgayDen_ValueChanged);
            // 
            // dgvVanBanDen
            // 
            this.dgvVanBanDen.AllowUserToAddRows = false;
            this.dgvVanBanDen.AllowUserToDeleteRows = false;
            this.dgvVanBanDen.AutoGenerateColumns = false;
            this.dgvVanBanDen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVanBanDen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteVanBanDen,
            this.FolderVanBanDen,
            this.ngayDenDataGridViewTextBoxColumn,
            this.soDenDataGridViewTextBoxColumn,
            this.soKyHieuDataGridViewTextBoxColumn,
            this.ngayBanHanhDataGridViewTextBoxColumn,
            this.trichYeuDataGridViewTextBoxColumn,
            this.nguoiNhanDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.updateDateDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.coQuanDataGridViewTextBoxColumn,
            this.loaiVanBanDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.vanBanDenFilesDataGridViewTextBoxColumn});
            this.dgvVanBanDen.DataSource = this.vanBanDenBindingSource;
            this.dgvVanBanDen.Location = new System.Drawing.Point(455, 12);
            this.dgvVanBanDen.Name = "dgvVanBanDen";
            this.dgvVanBanDen.ReadOnly = true;
            this.dgvVanBanDen.Size = new System.Drawing.Size(649, 482);
            this.dgvVanBanDen.TabIndex = 61;
            this.dgvVanBanDen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVanBanDen_CellContentClick);
            // 
            // DeleteVanBanDen
            // 
            this.DeleteVanBanDen.HeaderText = "Xóa";
            this.DeleteVanBanDen.Name = "DeleteVanBanDen";
            this.DeleteVanBanDen.ReadOnly = true;
            this.DeleteVanBanDen.Text = "X";
            this.DeleteVanBanDen.UseColumnTextForButtonValue = true;
            this.DeleteVanBanDen.Width = 40;
            // 
            // FolderVanBanDen
            // 
            this.FolderVanBanDen.HeaderText = "Thư mục";
            this.FolderVanBanDen.Name = "FolderVanBanDen";
            this.FolderVanBanDen.ReadOnly = true;
            this.FolderVanBanDen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FolderVanBanDen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FolderVanBanDen.Text = "Mở";
            this.FolderVanBanDen.UseColumnTextForButtonValue = true;
            this.FolderVanBanDen.Width = 40;
            // 
            // ngayDenDataGridViewTextBoxColumn
            // 
            this.ngayDenDataGridViewTextBoxColumn.DataPropertyName = "NgayDen";
            this.ngayDenDataGridViewTextBoxColumn.HeaderText = "NgayDen";
            this.ngayDenDataGridViewTextBoxColumn.Name = "ngayDenDataGridViewTextBoxColumn";
            this.ngayDenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soDenDataGridViewTextBoxColumn
            // 
            this.soDenDataGridViewTextBoxColumn.DataPropertyName = "SoDen";
            this.soDenDataGridViewTextBoxColumn.HeaderText = "SoDen";
            this.soDenDataGridViewTextBoxColumn.Name = "soDenDataGridViewTextBoxColumn";
            this.soDenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soKyHieuDataGridViewTextBoxColumn
            // 
            this.soKyHieuDataGridViewTextBoxColumn.DataPropertyName = "SoKyHieu";
            this.soKyHieuDataGridViewTextBoxColumn.HeaderText = "SoKyHieu";
            this.soKyHieuDataGridViewTextBoxColumn.Name = "soKyHieuDataGridViewTextBoxColumn";
            this.soKyHieuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayBanHanhDataGridViewTextBoxColumn
            // 
            this.ngayBanHanhDataGridViewTextBoxColumn.DataPropertyName = "NgayBanHanh";
            this.ngayBanHanhDataGridViewTextBoxColumn.HeaderText = "NgayBanHanh";
            this.ngayBanHanhDataGridViewTextBoxColumn.Name = "ngayBanHanhDataGridViewTextBoxColumn";
            this.ngayBanHanhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trichYeuDataGridViewTextBoxColumn
            // 
            this.trichYeuDataGridViewTextBoxColumn.DataPropertyName = "TrichYeu";
            this.trichYeuDataGridViewTextBoxColumn.HeaderText = "TrichYeu";
            this.trichYeuDataGridViewTextBoxColumn.Name = "trichYeuDataGridViewTextBoxColumn";
            this.trichYeuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nguoiNhanDataGridViewTextBoxColumn
            // 
            this.nguoiNhanDataGridViewTextBoxColumn.DataPropertyName = "NguoiNhan";
            this.nguoiNhanDataGridViewTextBoxColumn.HeaderText = "NguoiNhan";
            this.nguoiNhanDataGridViewTextBoxColumn.Name = "nguoiNhanDataGridViewTextBoxColumn";
            this.nguoiNhanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateDateDataGridViewTextBoxColumn
            // 
            this.updateDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDate";
            this.updateDateDataGridViewTextBoxColumn.HeaderText = "UpdateDate";
            this.updateDateDataGridViewTextBoxColumn.Name = "updateDateDataGridViewTextBoxColumn";
            this.updateDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coQuanDataGridViewTextBoxColumn
            // 
            this.coQuanDataGridViewTextBoxColumn.DataPropertyName = "CoQuan";
            this.coQuanDataGridViewTextBoxColumn.HeaderText = "CoQuan";
            this.coQuanDataGridViewTextBoxColumn.Name = "coQuanDataGridViewTextBoxColumn";
            this.coQuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loaiVanBanDataGridViewTextBoxColumn
            // 
            this.loaiVanBanDataGridViewTextBoxColumn.DataPropertyName = "LoaiVanBan";
            this.loaiVanBanDataGridViewTextBoxColumn.HeaderText = "LoaiVanBan";
            this.loaiVanBanDataGridViewTextBoxColumn.Name = "loaiVanBanDataGridViewTextBoxColumn";
            this.loaiVanBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vanBanDenFilesDataGridViewTextBoxColumn
            // 
            this.vanBanDenFilesDataGridViewTextBoxColumn.DataPropertyName = "VanBanDenFiles";
            this.vanBanDenFilesDataGridViewTextBoxColumn.HeaderText = "VanBanDenFiles";
            this.vanBanDenFilesDataGridViewTextBoxColumn.Name = "vanBanDenFilesDataGridViewTextBoxColumn";
            this.vanBanDenFilesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(293, 500);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // SoVanBanDenHuyenForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 538);
            this.Controls.Add(this.dgvVanBanDen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNguoiNhan);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvDinhKemFiles);
            this.Controls.Add(this.btnDinhKem);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTrichYeu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayBanHanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoKyHieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbCoQuanBanHanh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbLoaiVanBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoDen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNgayDen);
            this.Name = "SoVanBanDenHuyenForm2";
            this.Text = "SoVanBanDenHuyenForm";
            this.Load += new System.EventHandler(this.SoVanBanDenHuyenForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinhKemFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanBanDen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvDinhKemFiles;
        private System.Windows.Forms.Button btnDinhKem;
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
        private System.Windows.Forms.BindingSource coQuanBindingSource;
        private System.Windows.Forms.BindingSource loaiVanBanBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortFileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vanBanDenFileBindingSource;
        private System.Windows.Forms.DataGridView dgvVanBanDen;
        private System.Windows.Forms.BindingSource vanBanDenBindingSource;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteVanBanDen;
        private System.Windows.Forms.DataGridViewButtonColumn FolderVanBanDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soKyHieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trichYeuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiNhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiVanBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vanBanDenFilesDataGridViewTextBoxColumn;
    }
}