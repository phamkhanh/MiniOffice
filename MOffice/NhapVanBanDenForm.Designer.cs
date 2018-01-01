namespace MOffice
{
    partial class NhapVanBanDenForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoDen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLoaiVanBan = new System.Windows.Forms.ComboBox();
            this.loaiVanBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCoQuanBanHanh = new System.Windows.Forms.ComboBox();
            this.coQuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoKyHieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayBanHanh = new System.Windows.Forms.DateTimePicker();
            this.txtTrichYeu = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDinhKemFiles = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ShortFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vanBanDenFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDinhKem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.vanBanDenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinhKemFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày đến";
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(136, 12);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(172, 20);
            this.dtpNgayDen.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Số đến";
            // 
            // txtSoDen
            // 
            this.txtSoDen.Location = new System.Drawing.Point(136, 38);
            this.txtSoDen.Name = "txtSoDen";
            this.txtSoDen.Size = new System.Drawing.Size(172, 20);
            this.txtSoDen.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Loại văn bản";
            // 
            // cbLoaiVanBan
            // 
            this.cbLoaiVanBan.DataSource = this.loaiVanBanBindingSource;
            this.cbLoaiVanBan.DisplayMember = "Ten";
            this.cbLoaiVanBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiVanBan.FormattingEnabled = true;
            this.cbLoaiVanBan.Location = new System.Drawing.Point(136, 64);
            this.cbLoaiVanBan.Name = "cbLoaiVanBan";
            this.cbLoaiVanBan.Size = new System.Drawing.Size(172, 21);
            this.cbLoaiVanBan.TabIndex = 23;
            this.cbLoaiVanBan.ValueMember = "Id";
            // 
            // loaiVanBanBindingSource
            // 
            this.loaiVanBanBindingSource.DataSource = typeof(MOffice.LoaiVanBan);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cơ quan ban hành";
            // 
            // cbbCoQuanBanHanh
            // 
            this.cbbCoQuanBanHanh.DataSource = this.coQuanBindingSource;
            this.cbbCoQuanBanHanh.DisplayMember = "Ten";
            this.cbbCoQuanBanHanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoQuanBanHanh.FormattingEnabled = true;
            this.cbbCoQuanBanHanh.Location = new System.Drawing.Point(136, 91);
            this.cbbCoQuanBanHanh.Name = "cbbCoQuanBanHanh";
            this.cbbCoQuanBanHanh.Size = new System.Drawing.Size(172, 21);
            this.cbbCoQuanBanHanh.TabIndex = 25;
            this.cbbCoQuanBanHanh.ValueMember = "Id";
            // 
            // coQuanBindingSource
            // 
            this.coQuanBindingSource.DataSource = typeof(MOffice.CoQuan);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số ký hiệu";
            // 
            // txtSoKyHieu
            // 
            this.txtSoKyHieu.Location = new System.Drawing.Point(136, 118);
            this.txtSoKyHieu.Name = "txtSoKyHieu";
            this.txtSoKyHieu.Size = new System.Drawing.Size(172, 20);
            this.txtSoKyHieu.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ngày ban hành";
            // 
            // dtpNgayBanHanh
            // 
            this.dtpNgayBanHanh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBanHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBanHanh.Location = new System.Drawing.Point(136, 144);
            this.dtpNgayBanHanh.Name = "dtpNgayBanHanh";
            this.dtpNgayBanHanh.Size = new System.Drawing.Size(172, 20);
            this.dtpNgayBanHanh.TabIndex = 29;
            // 
            // txtTrichYeu
            // 
            this.txtTrichYeu.Location = new System.Drawing.Point(136, 170);
            this.txtTrichYeu.Name = "txtTrichYeu";
            this.txtTrichYeu.Size = new System.Drawing.Size(307, 61);
            this.txtTrichYeu.TabIndex = 31;
            this.txtTrichYeu.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Trích yếu";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(136, 263);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(307, 61);
            this.txtGhiChu.TabIndex = 33;
            this.txtGhiChu.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ghi chú";
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
            this.dgvDinhKemFiles.DataSource = this.vanBanDenFileBindingSource;
            this.dgvDinhKemFiles.Location = new System.Drawing.Point(136, 330);
            this.dgvDinhKemFiles.Name = "dgvDinhKemFiles";
            this.dgvDinhKemFiles.ReadOnly = true;
            this.dgvDinhKemFiles.Size = new System.Drawing.Size(307, 164);
            this.dgvDinhKemFiles.TabIndex = 36;
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
            // vanBanDenFileBindingSource
            // 
            this.vanBanDenFileBindingSource.DataSource = typeof(MOffice.VanBanDenFile);
            // 
            // btnDinhKem
            // 
            this.btnDinhKem.Location = new System.Drawing.Point(55, 330);
            this.btnDinhKem.Name = "btnDinhKem";
            this.btnDinhKem.Size = new System.Drawing.Size(75, 23);
            this.btnDinhKem.TabIndex = 35;
            this.btnDinhKem.Text = "Đính kèm";
            this.btnDinhKem.UseVisualStyleBackColor = true;
            this.btnDinhKem.Click += new System.EventHandler(this.btnDinhKem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(368, 500);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Người nhận";
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.Location = new System.Drawing.Point(136, 237);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(307, 20);
            this.txtNguoiNhan.TabIndex = 38;
            // 
            // vanBanDenBindingSource
            // 
            this.vanBanDenBindingSource.DataSource = typeof(MOffice.VanBanDen);
            // 
            // NhapVanBanDenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 533);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNguoiNhan);
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
            this.Name = "NhapVanBanDenForm";
            this.Text = "NhapVanBanDenForm";
            this.Load += new System.EventHandler(this.NhapVanBanDenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinhKemFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoDen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbLoaiVanBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCoQuanBanHanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoKyHieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayBanHanh;
        private System.Windows.Forms.RichTextBox txtTrichYeu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDinhKemFiles;
        private System.Windows.Forms.Button btnDinhKem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.BindingSource loaiVanBanBindingSource;
        private System.Windows.Forms.BindingSource coQuanBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vanBanDenFileBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.BindingSource vanBanDenBindingSource;
    }
}