namespace MOffice
{
    partial class DanhMucLoaiVanBanForm
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
            this.txtLoaiVbId = new System.Windows.Forms.TextBox();
            this.loaiVanBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvLoaiVb = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KyHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtKyHieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiVb)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoaiVbId
            // 
            this.txtLoaiVbId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiVanBanBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtLoaiVbId.Location = new System.Drawing.Point(85, 13);
            this.txtLoaiVbId.Name = "txtLoaiVbId";
            this.txtLoaiVbId.ReadOnly = true;
            this.txtLoaiVbId.Size = new System.Drawing.Size(231, 20);
            this.txtLoaiVbId.TabIndex = 4;
            this.txtLoaiVbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loaiVanBanBindingSource
            // 
            this.loaiVanBanBindingSource.DataSource = typeof(MOffice.LoaiVanBan);
            // 
            // dgvLoaiVb
            // 
            this.dgvLoaiVb.AllowUserToAddRows = false;
            this.dgvLoaiVb.AutoGenerateColumns = false;
            this.dgvLoaiVb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiVb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.tenDataGridViewTextBoxColumn,
            this.KyHieu});
            this.dgvLoaiVb.DataSource = this.loaiVanBanBindingSource;
            this.dgvLoaiVb.Location = new System.Drawing.Point(15, 94);
            this.dgvLoaiVb.Name = "dgvLoaiVb";
            this.dgvLoaiVb.ReadOnly = true;
            this.dgvLoaiVb.Size = new System.Drawing.Size(302, 297);
            this.dgvLoaiVb.TabIndex = 8;
            this.dgvLoaiVb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiVb_CellContentClick);
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
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // KyHieu
            // 
            this.KyHieu.DataPropertyName = "KyHieu";
            this.KyHieu.HeaderText = "KyHieu";
            this.KyHieu.Name = "KyHieu";
            this.KyHieu.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã loại";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(323, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(323, 94);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên loại";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiVanBanBindingSource, "Ten", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtTenLoai.Location = new System.Drawing.Point(85, 39);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(231, 20);
            this.txtTenLoai.TabIndex = 5;
            // 
            // txtKyHieu
            // 
            this.txtKyHieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiVanBanBindingSource, "KyHieu", true));
            this.txtKyHieu.Location = new System.Drawing.Point(85, 65);
            this.txtKyHieu.Name = "txtKyHieu";
            this.txtKyHieu.Size = new System.Drawing.Size(231, 20);
            this.txtKyHieu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ký hiệu";
            // 
            // DanhMucLoaiVanBanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 456);
            this.Controls.Add(this.txtLoaiVbId);
            this.Controls.Add(this.dgvLoaiVb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKyHieu);
            this.Controls.Add(this.txtTenLoai);
            this.Name = "DanhMucLoaiVanBanForm";
            this.Text = "Danh mục Loại văn bản";
            this.Load += new System.EventHandler(this.DanhMucLoaiVanBanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiVb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoaiVbId;
        private System.Windows.Forms.DataGridView dgvLoaiVb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.BindingSource loaiVanBanBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KyHieu;
        private System.Windows.Forms.TextBox txtKyHieu;
        private System.Windows.Forms.Label label3;
    }
}