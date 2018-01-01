namespace MOffice
{
    partial class QuanLyNguoiDungForm
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
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgvUserLog = new System.Windows.Forms.DataGridView();
            this.logDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTimNhatKy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelFill = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogBindingSource)).BeginInit();
            this.PanelTop.SuspendLayout();
            this.PanelFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtTenDangNhap.Location = new System.Drawing.Point(128, 12);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(149, 20);
            this.txtTenDangNhap.TabIndex = 0;
            this.txtTenDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(MOffice.User);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtMatKhau.Location = new System.Drawing.Point(128, 38);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = 'X';
            this.txtMatKhau.Size = new System.Drawing.Size(149, 20);
            this.txtMatKhau.TabIndex = 0;
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.userNameDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn});
            this.dgvUser.DataSource = this.userBindingSource;
            this.dgvUser.Location = new System.Drawing.Point(20, 92);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.Size = new System.Drawing.Size(420, 150);
            this.dgvUser.TabIndex = 3;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
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
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(446, 92);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(446, 121);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvUserLog
            // 
            this.dgvUserLog.AllowUserToAddRows = false;
            this.dgvUserLog.AllowUserToDeleteRows = false;
            this.dgvUserLog.AutoGenerateColumns = false;
            this.dgvUserLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logDateDataGridViewTextBoxColumn,
            this.logContentDataGridViewTextBoxColumn});
            this.dgvUserLog.DataSource = this.userLogBindingSource;
            this.dgvUserLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserLog.Location = new System.Drawing.Point(0, 0);
            this.dgvUserLog.Name = "dgvUserLog";
            this.dgvUserLog.ReadOnly = true;
            this.dgvUserLog.Size = new System.Drawing.Size(806, 210);
            this.dgvUserLog.TabIndex = 3;
            // 
            // logDateDataGridViewTextBoxColumn
            // 
            this.logDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.logDateDataGridViewTextBoxColumn.DataPropertyName = "LogDate";
            this.logDateDataGridViewTextBoxColumn.HeaderText = "LogDate";
            this.logDateDataGridViewTextBoxColumn.Name = "logDateDataGridViewTextBoxColumn";
            this.logDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.logDateDataGridViewTextBoxColumn.Width = 73;
            // 
            // logContentDataGridViewTextBoxColumn
            // 
            this.logContentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.logContentDataGridViewTextBoxColumn.DataPropertyName = "LogContent";
            this.logContentDataGridViewTextBoxColumn.HeaderText = "LogContent";
            this.logContentDataGridViewTextBoxColumn.Name = "logContentDataGridViewTextBoxColumn";
            this.logContentDataGridViewTextBoxColumn.ReadOnly = true;
            this.logContentDataGridViewTextBoxColumn.Width = 87;
            // 
            // userLogBindingSource
            // 
            this.userLogBindingSource.DataSource = typeof(MOffice.UserLog);
            // 
            // txtTimNhatKy
            // 
            this.txtTimNhatKy.Location = new System.Drawing.Point(85, 248);
            this.txtTimNhatKy.Name = "txtTimNhatKy";
            this.txtTimNhatKy.Size = new System.Drawing.Size(355, 20);
            this.txtTimNhatKy.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tìm nhật ký";
            // 
            // txtUserType
            // 
            this.txtUserType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserType", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtUserType.Location = new System.Drawing.Point(128, 64);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(149, 20);
            this.txtUserType.TabIndex = 0;
            this.txtUserType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.txtTenDangNhap);
            this.PanelTop.Controls.Add(this.btnCapNhat);
            this.PanelTop.Controls.Add(this.txtTimNhatKy);
            this.PanelTop.Controls.Add(this.label4);
            this.PanelTop.Controls.Add(this.btnThem);
            this.PanelTop.Controls.Add(this.txtMatKhau);
            this.PanelTop.Controls.Add(this.txtUserType);
            this.PanelTop.Controls.Add(this.dgvUser);
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.label3);
            this.PanelTop.Controls.Add(this.label2);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(806, 276);
            this.PanelTop.TabIndex = 5;
            // 
            // PanelFill
            // 
            this.PanelFill.Controls.Add(this.dgvUserLog);
            this.PanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill.Location = new System.Drawing.Point(0, 276);
            this.PanelFill.Name = "PanelFill";
            this.PanelFill.Size = new System.Drawing.Size(806, 210);
            this.PanelFill.TabIndex = 6;
            // 
            // QuanLyNguoiDungForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 486);
            this.Controls.Add(this.PanelFill);
            this.Controls.Add(this.PanelTop);
            this.Name = "QuanLyNguoiDungForm";
            this.Text = "Quản lý Người dùng";
            this.Load += new System.EventHandler(this.QuanLyNguoiDungForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogBindingSource)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgvUserLog;
        private System.Windows.Forms.TextBox txtTimNhatKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource userLogBindingSource;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelFill;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logContentDataGridViewTextBoxColumn;
    }
}