namespace MOffice
{
    partial class DanhMucLoaiTrichYeuForm
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.loaiTrichYeuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvLoaiTrichYeu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrichYeu = new System.Windows.Forms.RichTextBox();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.trichYeuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.loaiTrichYeuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTrichYeu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiTrichYeuBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtId.Location = new System.Drawing.Point(88, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(503, 20);
            this.txtId.TabIndex = 11;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loaiTrichYeuBindingSource
            // 
            this.loaiTrichYeuBindingSource.DataSource = typeof(MOffice.LoaiTrichYeu);
            // 
            // dgvLoaiTrichYeu
            // 
            this.dgvLoaiTrichYeu.AllowUserToAddRows = false;
            this.dgvLoaiTrichYeu.AutoGenerateColumns = false;
            this.dgvLoaiTrichYeu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTrichYeu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.trichYeuDataGridViewTextBoxColumn});
            this.dgvLoaiTrichYeu.DataSource = this.loaiTrichYeuBindingSource;
            this.dgvLoaiTrichYeu.Location = new System.Drawing.Point(17, 140);
            this.dgvLoaiTrichYeu.Name = "dgvLoaiTrichYeu";
            this.dgvLoaiTrichYeu.ReadOnly = true;
            this.dgvLoaiTrichYeu.Size = new System.Drawing.Size(574, 297);
            this.dgvLoaiTrichYeu.TabIndex = 17;
            this.dgvLoaiTrichYeu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiTrichYeu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã loại";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(597, 169);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(597, 140);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên loại";
            // 
            // txtTrichYeu
            // 
            this.txtTrichYeu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiTrichYeuBindingSource, "TrichYeu", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtTrichYeu.Location = new System.Drawing.Point(88, 38);
            this.txtTrichYeu.Name = "txtTrichYeu";
            this.txtTrichYeu.Size = new System.Drawing.Size(503, 96);
            this.txtTrichYeu.TabIndex = 20;
            this.txtTrichYeu.Text = "";
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
            // trichYeuDataGridViewTextBoxColumn
            // 
            this.trichYeuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trichYeuDataGridViewTextBoxColumn.DataPropertyName = "TrichYeu";
            this.trichYeuDataGridViewTextBoxColumn.HeaderText = "TrichYeu";
            this.trichYeuDataGridViewTextBoxColumn.Name = "trichYeuDataGridViewTextBoxColumn";
            this.trichYeuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DanhMucLoaiTrichYeuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 456);
            this.Controls.Add(this.txtTrichYeu);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvLoaiTrichYeu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Name = "DanhMucLoaiTrichYeuForm";
            this.Text = "Danh mục Loại trích yếu";
            this.Load += new System.EventHandler(this.DanhMucLoaiTrichYeuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaiTrichYeuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTrichYeu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvLoaiTrichYeu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtTrichYeu;
        private System.Windows.Forms.BindingSource loaiTrichYeuBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn trichYeuDataGridViewTextBoxColumn;
    }
}