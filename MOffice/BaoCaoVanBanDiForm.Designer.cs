namespace MOffice
{
    partial class BaoCaoVanBanDiForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvVanBanDi = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.soKyHieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trichYeuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vanBanDiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiVanBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbLoaiVanBan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoKyHieu = new System.Windows.Forms.TextBox();
            this.txtTrichYeu = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNamReport = new System.Windows.Forms.DateTimePicker();
            this.btnInReport = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanBanDi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvVanBanDi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1162, 520);
            this.panel2.TabIndex = 1;
            // 
            // dgvVanBanDi
            // 
            this.dgvVanBanDi.AllowUserToAddRows = false;
            this.dgvVanBanDi.AllowUserToDeleteRows = false;
            this.dgvVanBanDi.AutoGenerateColumns = false;
            this.dgvVanBanDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVanBanDi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.View,
            this.soKyHieuDataGridViewTextBoxColumn,
            this.ngayBanHanhDataGridViewTextBoxColumn,
            this.trichYeuDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.updateDateDataGridViewTextBoxColumn});
            this.dgvVanBanDi.DataSource = this.vanBanDiBindingSource;
            this.dgvVanBanDi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVanBanDi.Location = new System.Drawing.Point(0, 0);
            this.dgvVanBanDi.Name = "dgvVanBanDi";
            this.dgvVanBanDi.ReadOnly = true;
            this.dgvVanBanDi.Size = new System.Drawing.Size(1162, 520);
            this.dgvVanBanDi.TabIndex = 0;
            this.dgvVanBanDi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVanBanDi_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "X";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 40;
            // 
            // View
            // 
            this.View.HeaderText = "Xem";
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Text = "Xem";
            this.View.UseColumnTextForButtonValue = true;
            this.View.Width = 40;
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
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiChuDataGridViewTextBoxColumn.Width = 67;
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
            // vanBanDiBindingSource
            // 
            this.vanBanDiBindingSource.DataSource = typeof(MOffice.VanBanDi);
            // 
            // loaiVanBanBindingSource
            // 
            this.loaiVanBanBindingSource.DataSource = typeof(MOffice.LoaiVanBan);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(MOffice.User);
            // 
            // cbbLoaiVanBan
            // 
            this.cbbLoaiVanBan.DataSource = this.loaiVanBanBindingSource;
            this.cbbLoaiVanBan.DisplayMember = "Ten";
            this.cbbLoaiVanBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiVanBan.FormattingEnabled = true;
            this.cbbLoaiVanBan.Location = new System.Drawing.Point(78, 3);
            this.cbbLoaiVanBan.Name = "cbbLoaiVanBan";
            this.cbbLoaiVanBan.Size = new System.Drawing.Size(121, 21);
            this.cbbLoaiVanBan.TabIndex = 0;
            this.cbbLoaiVanBan.ValueMember = "Id";
            this.cbbLoaiVanBan.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiVanBan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại văn bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số ký hiệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trích yếu";
            // 
            // txtSoKyHieu
            // 
            this.txtSoKyHieu.Location = new System.Drawing.Point(268, 3);
            this.txtSoKyHieu.Name = "txtSoKyHieu";
            this.txtSoKyHieu.Size = new System.Drawing.Size(100, 20);
            this.txtSoKyHieu.TabIndex = 2;
            // 
            // txtTrichYeu
            // 
            this.txtTrichYeu.Location = new System.Drawing.Point(78, 33);
            this.txtTrichYeu.Name = "txtTrichYeu";
            this.txtTrichYeu.Size = new System.Drawing.Size(371, 20);
            this.txtTrichYeu.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(374, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNamReport);
            this.panel1.Controls.Add(this.btnInReport);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtTrichYeu);
            this.panel1.Controls.Add(this.txtSoKyHieu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbLoaiVanBan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 59);
            this.panel1.TabIndex = 0;
            // 
            // dtpNamReport
            // 
            this.dtpNamReport.CustomFormat = "yyyy";
            this.dtpNamReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamReport.Location = new System.Drawing.Point(455, 4);
            this.dtpNamReport.Name = "dtpNamReport";
            this.dtpNamReport.ShowUpDown = true;
            this.dtpNamReport.Size = new System.Drawing.Size(62, 20);
            this.dtpNamReport.TabIndex = 19;
            // 
            // btnInReport
            // 
            this.btnInReport.Location = new System.Drawing.Point(523, 4);
            this.btnInReport.Name = "btnInReport";
            this.btnInReport.Size = new System.Drawing.Size(75, 23);
            this.btnInReport.TabIndex = 18;
            this.btnInReport.Text = "In";
            this.btnInReport.UseVisualStyleBackColor = true;
            this.btnInReport.Click += new System.EventHandler(this.btnInReport_Click);
            // 
            // BaoCaoVanBanDiForm
            // 
            this.AcceptButton = this.btnTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BaoCaoVanBanDiForm";
            this.Text = "BaoCaoVanBanDiForm";
            this.Load += new System.EventHandler(this.BaoCaoVanBanDiForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanBanDi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvVanBanDi;
        private System.Windows.Forms.BindingSource loaiVanBanBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ComboBox cbbLoaiVanBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoKyHieu;
        private System.Windows.Forms.TextBox txtTrichYeu;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource vanBanDiBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewTextBoxColumn soKyHieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trichYeuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpNamReport;
        private System.Windows.Forms.Button btnInReport;

    }
}