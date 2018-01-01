namespace MOffice
{
    partial class NhapVanBanDiForm
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
            this.dgvDinhKemFiles = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ShortFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vanBanDiFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDinhKem = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtTrichYeu = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLoaiVanBan = new System.Windows.Forms.ComboBox();
            this.loaiVanBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpNgayBanHanh = new System.Windows.Forms.DateTimePicker();
            this.txtNguoiKy = new System.Windows.Forms.TextBox();
            this.txtSoDi = new System.Windows.Forms.TextBox();
            this.txtSoKyHieu = new System.Windows.Forms.TextBox();
            this.cbbCoQuanBanHanh = new System.Windows.Forms.ComboBox();
            this.coQuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinhKemFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDiFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDinhKemFiles
            // 
            this.dgvDinhKemFiles.AllowUserToAddRows = false;
            this.dgvDinhKemFiles.AllowUserToDeleteRows = false;
            this.dgvDinhKemFiles.AutoGenerateColumns = false;
            this.dgvDinhKemFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDinhKemFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.ShortFileName,
            this.fileNameDataGridViewTextBoxColumn});
            this.dgvDinhKemFiles.DataSource = this.vanBanDiFileBindingSource;
            this.dgvDinhKemFiles.Location = new System.Drawing.Point(133, 304);
            this.dgvDinhKemFiles.Name = "dgvDinhKemFiles";
            this.dgvDinhKemFiles.ReadOnly = true;
            this.dgvDinhKemFiles.Size = new System.Drawing.Size(307, 164);
            this.dgvDinhKemFiles.TabIndex = 27;
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
            // ShortFileName
            // 
            this.ShortFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ShortFileName.DataPropertyName = "ShortFileName";
            this.ShortFileName.HeaderText = "ShortFileName";
            this.ShortFileName.Name = "ShortFileName";
            this.ShortFileName.ReadOnly = true;
            this.ShortFileName.Width = 101;
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
            // vanBanDiFileBindingSource
            // 
            this.vanBanDiFileBindingSource.DataSource = typeof(MOffice.VanBanDiFile);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(364, 474);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDinhKem
            // 
            this.btnDinhKem.Location = new System.Drawing.Point(52, 304);
            this.btnDinhKem.Name = "btnDinhKem";
            this.btnDinhKem.Size = new System.Drawing.Size(75, 23);
            this.btnDinhKem.TabIndex = 8;
            this.btnDinhKem.Text = "Đính kèm";
            this.btnDinhKem.UseVisualStyleBackColor = true;
            this.btnDinhKem.Click += new System.EventHandler(this.btnDinhKem_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(133, 237);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(307, 61);
            this.txtGhiChu.TabIndex = 7;
            this.txtGhiChu.Text = "";
            // 
            // txtTrichYeu
            // 
            this.txtTrichYeu.Location = new System.Drawing.Point(133, 144);
            this.txtTrichYeu.Name = "txtTrichYeu";
            this.txtTrichYeu.Size = new System.Drawing.Size(307, 61);
            this.txtTrichYeu.TabIndex = 5;
            this.txtTrichYeu.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ghi chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Trích yếu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Người ký";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số ký hiệu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Loại văn bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cơ quan ban hành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Số đi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ngày ban hành";
            // 
            // cbLoaiVanBan
            // 
            this.cbLoaiVanBan.DataSource = this.loaiVanBanBindingSource;
            this.cbLoaiVanBan.DisplayMember = "Ten";
            this.cbLoaiVanBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiVanBan.FormattingEnabled = true;
            this.cbLoaiVanBan.Location = new System.Drawing.Point(133, 12);
            this.cbLoaiVanBan.Name = "cbLoaiVanBan";
            this.cbLoaiVanBan.Size = new System.Drawing.Size(172, 21);
            this.cbLoaiVanBan.TabIndex = 0;
            this.cbLoaiVanBan.ValueMember = "Id";
            this.cbLoaiVanBan.SelectedIndexChanged += new System.EventHandler(this.cbLoaiVanBan_SelectedIndexChanged);
            // 
            // loaiVanBanBindingSource
            // 
            this.loaiVanBanBindingSource.DataSource = typeof(MOffice.LoaiVanBan);
            // 
            // dtpNgayBanHanh
            // 
            this.dtpNgayBanHanh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBanHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBanHanh.Location = new System.Drawing.Point(133, 91);
            this.dtpNgayBanHanh.Name = "dtpNgayBanHanh";
            this.dtpNgayBanHanh.Size = new System.Drawing.Size(172, 20);
            this.dtpNgayBanHanh.TabIndex = 3;
            // 
            // txtNguoiKy
            // 
            this.txtNguoiKy.Location = new System.Drawing.Point(133, 211);
            this.txtNguoiKy.Name = "txtNguoiKy";
            this.txtNguoiKy.Size = new System.Drawing.Size(306, 20);
            this.txtNguoiKy.TabIndex = 6;
            // 
            // txtSoDi
            // 
            this.txtSoDi.Location = new System.Drawing.Point(133, 39);
            this.txtSoDi.Name = "txtSoDi";
            this.txtSoDi.Size = new System.Drawing.Size(172, 20);
            this.txtSoDi.TabIndex = 1;
            // 
            // txtSoKyHieu
            // 
            this.txtSoKyHieu.Location = new System.Drawing.Point(133, 65);
            this.txtSoKyHieu.Name = "txtSoKyHieu";
            this.txtSoKyHieu.Size = new System.Drawing.Size(172, 20);
            this.txtSoKyHieu.TabIndex = 2;
            // 
            // cbbCoQuanBanHanh
            // 
            this.cbbCoQuanBanHanh.DataSource = this.coQuanBindingSource;
            this.cbbCoQuanBanHanh.DisplayMember = "Ten";
            this.cbbCoQuanBanHanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoQuanBanHanh.FormattingEnabled = true;
            this.cbbCoQuanBanHanh.Location = new System.Drawing.Point(133, 117);
            this.cbbCoQuanBanHanh.Name = "cbbCoQuanBanHanh";
            this.cbbCoQuanBanHanh.Size = new System.Drawing.Size(172, 21);
            this.cbbCoQuanBanHanh.TabIndex = 4;
            this.cbbCoQuanBanHanh.ValueMember = "Id";
            // 
            // coQuanBindingSource
            // 
            this.coQuanBindingSource.DataSource = typeof(MOffice.CoQuan);
            // 
            // NhapVanBanDiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 508);
            this.Controls.Add(this.dgvDinhKemFiles);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnDinhKem);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtTrichYeu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbCoQuanBanHanh);
            this.Controls.Add(this.cbLoaiVanBan);
            this.Controls.Add(this.dtpNgayBanHanh);
            this.Controls.Add(this.txtNguoiKy);
            this.Controls.Add(this.txtSoKyHieu);
            this.Controls.Add(this.txtSoDi);
            this.Name = "NhapVanBanDiForm";
            this.Text = "NhanVanBanDiForm";
            this.Load += new System.EventHandler(this.NhapVanBanDiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinhKemFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDiFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDinhKemFiles;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDinhKem;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.RichTextBox txtTrichYeu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLoaiVanBan;
        private System.Windows.Forms.DateTimePicker dtpNgayBanHanh;
        private System.Windows.Forms.TextBox txtNguoiKy;
        private System.Windows.Forms.TextBox txtSoDi;
        private System.Windows.Forms.TextBox txtSoKyHieu;
        private System.Windows.Forms.ComboBox cbbCoQuanBanHanh;
        private System.Windows.Forms.BindingSource loaiVanBanBindingSource;
        private System.Windows.Forms.BindingSource coQuanBindingSource;
        private System.Windows.Forms.BindingSource vanBanDiFileBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;

    }
}