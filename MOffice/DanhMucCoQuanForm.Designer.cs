namespace MOffice
{
    partial class DanhMucCoQuanForm
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
            this.txtCoQuanId = new System.Windows.Forms.TextBox();
            this.coQuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCoQuan = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTenCoQuan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbXa = new System.Windows.Forms.RadioButton();
            this.rdbHuyen = new System.Windows.Forms.RadioButton();
            this.rdbTinh = new System.Windows.Forms.RadioButton();
            this.rdbKhac = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCoQuanId
            // 
            this.txtCoQuanId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coQuanBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtCoQuanId.Location = new System.Drawing.Point(86, 12);
            this.txtCoQuanId.Name = "txtCoQuanId";
            this.txtCoQuanId.ReadOnly = true;
            this.txtCoQuanId.Size = new System.Drawing.Size(231, 20);
            this.txtCoQuanId.TabIndex = 0;
            this.txtCoQuanId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coQuanBindingSource
            // 
            this.coQuanBindingSource.DataSource = typeof(MOffice.CoQuan);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã cơ quan";
            // 
            // dgvCoQuan
            // 
            this.dgvCoQuan.AllowUserToAddRows = false;
            this.dgvCoQuan.AutoGenerateColumns = false;
            this.dgvCoQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoQuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.tenDataGridViewTextBoxColumn});
            this.dgvCoQuan.DataSource = this.coQuanBindingSource;
            this.dgvCoQuan.Location = new System.Drawing.Point(16, 93);
            this.dgvCoQuan.Name = "dgvCoQuan";
            this.dgvCoQuan.ReadOnly = true;
            this.dgvCoQuan.Size = new System.Drawing.Size(302, 297);
            this.dgvCoQuan.TabIndex = 2;
            this.dgvCoQuan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoQuan_CellContentClick);
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
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(324, 93);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(324, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTenCoQuan
            // 
            this.txtTenCoQuan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coQuanBindingSource, "Ten", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtTenCoQuan.Location = new System.Drawing.Point(86, 38);
            this.txtTenCoQuan.Name = "txtTenCoQuan";
            this.txtTenCoQuan.Size = new System.Drawing.Size(231, 20);
            this.txtTenCoQuan.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên cơ quan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cấp";
            // 
            // rdbXa
            // 
            this.rdbXa.AutoSize = true;
            this.rdbXa.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.coQuanBindingSource, "Xa", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.rdbXa.Location = new System.Drawing.Point(86, 64);
            this.rdbXa.Name = "rdbXa";
            this.rdbXa.Size = new System.Drawing.Size(38, 17);
            this.rdbXa.TabIndex = 4;
            this.rdbXa.TabStop = true;
            this.rdbXa.Text = "Xã";
            this.rdbXa.UseVisualStyleBackColor = true;
            // 
            // rdbHuyen
            // 
            this.rdbHuyen.AutoSize = true;
            this.rdbHuyen.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.coQuanBindingSource, "Huyen", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.rdbHuyen.Location = new System.Drawing.Point(130, 64);
            this.rdbHuyen.Name = "rdbHuyen";
            this.rdbHuyen.Size = new System.Drawing.Size(56, 17);
            this.rdbHuyen.TabIndex = 4;
            this.rdbHuyen.TabStop = true;
            this.rdbHuyen.Text = "Huyện";
            this.rdbHuyen.UseVisualStyleBackColor = true;
            // 
            // rdbTinh
            // 
            this.rdbTinh.AutoSize = true;
            this.rdbTinh.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.coQuanBindingSource, "Tinh", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.rdbTinh.Location = new System.Drawing.Point(192, 64);
            this.rdbTinh.Name = "rdbTinh";
            this.rdbTinh.Size = new System.Drawing.Size(46, 17);
            this.rdbTinh.TabIndex = 4;
            this.rdbTinh.TabStop = true;
            this.rdbTinh.Text = "Tỉnh";
            this.rdbTinh.UseVisualStyleBackColor = true;
            // 
            // rdbKhac
            // 
            this.rdbKhac.AutoSize = true;
            this.rdbKhac.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.coQuanBindingSource, "Khac", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.rdbKhac.Location = new System.Drawing.Point(244, 64);
            this.rdbKhac.Name = "rdbKhac";
            this.rdbKhac.Size = new System.Drawing.Size(50, 17);
            this.rdbKhac.TabIndex = 4;
            this.rdbKhac.TabStop = true;
            this.rdbKhac.Text = "Khác";
            this.rdbKhac.UseVisualStyleBackColor = true;
            // 
            // DanhMucCoQuanForm
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 404);
            this.Controls.Add(this.rdbKhac);
            this.Controls.Add(this.rdbTinh);
            this.Controls.Add(this.rdbHuyen);
            this.Controls.Add(this.rdbXa);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvCoQuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenCoQuan);
            this.Controls.Add(this.txtCoQuanId);
            this.Name = "DanhMucCoQuanForm";
            this.Text = "Danh mục Cơ quan";
            this.Load += new System.EventHandler(this.DanhMucCoQuanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coQuanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCoQuanId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCoQuan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource coQuanBindingSource;
        private System.Windows.Forms.TextBox txtTenCoQuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbXa;
        private System.Windows.Forms.RadioButton rdbHuyen;
        private System.Windows.Forms.RadioButton rdbTinh;
        private System.Windows.Forms.RadioButton rdbKhac;
    }
}