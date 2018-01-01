namespace MOffice
{
    partial class NhapVanBanDenForm2
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
            this.txtSoDen = new System.Windows.Forms.TextBox();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.cbTacGia = new System.Windows.Forms.ComboBox();
            this.coQuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKyHieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayBanHanh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLoaiVanBan = new System.Windows.Forms.ComboBox();
            this.loaiVanBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rxtTrichYeu = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnDinhKem = new System.Windows.Forms.Button();
            this.dgvDinhKemFiles = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinhKemFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoDen
            // 
            this.txtSoDen.Location = new System.Drawing.Point(100, 38);
            this.txtSoDen.Name = "txtSoDen";
            this.txtSoDen.Size = new System.Drawing.Size(172, 20);
            this.txtSoDen.TabIndex = 1;
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(100, 12);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(172, 20);
            this.dtpNgayDen.TabIndex = 0;
            // 
            // cbTacGia
            // 
            this.cbTacGia.DataSource = this.coQuanBindingSource;
            this.cbTacGia.DisplayMember = "Ten";
            this.cbTacGia.FormattingEnabled = true;
            this.cbTacGia.Location = new System.Drawing.Point(100, 91);
            this.cbTacGia.Name = "cbTacGia";
            this.cbTacGia.Size = new System.Drawing.Size(172, 21);
            this.cbTacGia.TabIndex = 3;
            this.cbTacGia.ValueMember = "Id";
            // 
            // coQuanBindingSource
            // 
            this.coQuanBindingSource.DataSource = typeof(MOffice.CoQuan);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tác giả";
            // 
            // txtKyHieu
            // 
            this.txtKyHieu.Location = new System.Drawing.Point(100, 118);
            this.txtKyHieu.Name = "txtKyHieu";
            this.txtKyHieu.Size = new System.Drawing.Size(172, 20);
            this.txtKyHieu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số ký hiệu";
            // 
            // dtpNgayBanHanh
            // 
            this.dtpNgayBanHanh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBanHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBanHanh.Location = new System.Drawing.Point(100, 144);
            this.dtpNgayBanHanh.Name = "dtpNgayBanHanh";
            this.dtpNgayBanHanh.Size = new System.Drawing.Size(172, 20);
            this.dtpNgayBanHanh.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày ban hành";
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.Location = new System.Drawing.Point(100, 238);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(306, 20);
            this.txtNguoiNhan.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Người nhận";
            // 
            // cbLoaiVanBan
            // 
            this.cbLoaiVanBan.DataSource = this.loaiVanBanBindingSource;
            this.cbLoaiVanBan.DisplayMember = "Ten";
            this.cbLoaiVanBan.FormattingEnabled = true;
            this.cbLoaiVanBan.Location = new System.Drawing.Point(100, 64);
            this.cbLoaiVanBan.Name = "cbLoaiVanBan";
            this.cbLoaiVanBan.Size = new System.Drawing.Size(172, 21);
            this.cbLoaiVanBan.TabIndex = 2;
            this.cbLoaiVanBan.ValueMember = "Id";
            // 
            // loaiVanBanBindingSource
            // 
            this.loaiVanBanBindingSource.DataSource = typeof(MOffice.LoaiVanBan);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Loại văn bản";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ghi chú";
            // 
            // rxtTrichYeu
            // 
            this.rxtTrichYeu.Location = new System.Drawing.Point(100, 171);
            this.rxtTrichYeu.Name = "rxtTrichYeu";
            this.rxtTrichYeu.Size = new System.Drawing.Size(307, 61);
            this.rxtTrichYeu.TabIndex = 6;
            this.rxtTrichYeu.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Trích yếu";
            // 
            // rxtGhiChu
            // 
            this.rxtGhiChu.Location = new System.Drawing.Point(100, 264);
            this.rxtGhiChu.Name = "rxtGhiChu";
            this.rxtGhiChu.Size = new System.Drawing.Size(307, 61);
            this.rxtGhiChu.TabIndex = 8;
            this.rxtGhiChu.Text = "";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(331, 503);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 10;
            this.btnNhap.Text = "Lưu";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnDinhKem
            // 
            this.btnDinhKem.Location = new System.Drawing.Point(14, 331);
            this.btnDinhKem.Name = "btnDinhKem";
            this.btnDinhKem.Size = new System.Drawing.Size(75, 23);
            this.btnDinhKem.TabIndex = 9;
            this.btnDinhKem.Text = "Đính kèm";
            this.btnDinhKem.UseVisualStyleBackColor = true;
            this.btnDinhKem.Click += new System.EventHandler(this.btnDinhKem_Click);
            // 
            // dgvDinhKemFiles
            // 
            this.dgvDinhKemFiles.AllowUserToAddRows = false;
            this.dgvDinhKemFiles.AllowUserToDeleteRows = false;
            this.dgvDinhKemFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDinhKemFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.FileName,
            this.FullFileName});
            this.dgvDinhKemFiles.Location = new System.Drawing.Point(100, 333);
            this.dgvDinhKemFiles.Name = "dgvDinhKemFiles";
            this.dgvDinhKemFiles.ReadOnly = true;
            this.dgvDinhKemFiles.Size = new System.Drawing.Size(307, 164);
            this.dgvDinhKemFiles.TabIndex = 6;
            this.dgvDinhKemFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDinhKemFiles_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "X";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 79;
            // 
            // FullFileName
            // 
            this.FullFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FullFileName.HeaderText = "Full File Name";
            this.FullFileName.Name = "FullFileName";
            this.FullFileName.ReadOnly = true;
            this.FullFileName.Width = 98;
            // 
            // NhapVanBanDenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 533);
            this.Controls.Add(this.dgvDinhKemFiles);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnDinhKem);
            this.Controls.Add(this.rxtGhiChu);
            this.Controls.Add(this.rxtTrichYeu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLoaiVanBan);
            this.Controls.Add(this.cbTacGia);
            this.Controls.Add(this.dtpNgayBanHanh);
            this.Controls.Add(this.dtpNgayDen);
            this.Controls.Add(this.txtNguoiNhan);
            this.Controls.Add(this.txtKyHieu);
            this.Controls.Add(this.txtSoDen);
            this.Name = "NhapVanBanDenForm";
            this.Text = "NhapVanBanDenForm";
            this.Deactivate += new System.EventHandler(this.NhapVanBanDenForm_Deactivate);
            this.Load += new System.EventHandler(this.NhapVanBanDenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinhKemFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoDen;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.ComboBox cbTacGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKyHieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayBanHanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLoaiVanBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rxtTrichYeu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rxtGhiChu;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnDinhKem;
        private System.Windows.Forms.DataGridView dgvDinhKemFiles;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullFileName;
        private System.Windows.Forms.BindingSource coQuanBindingSource;
        private System.Windows.Forms.BindingSource loaiVanBanBindingSource;
    }
}