namespace MOffice
{
    partial class TienIchThoMoiForm
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
            this.clbThanhPhan = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.ckbXungDanh = new System.Windows.Forms.CheckBox();
            this.txtXungDanh = new System.Windows.Forms.TextBox();
            this.canboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ckbTatCaThanhPhan = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.canboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clbThanhPhan
            // 
            this.clbThanhPhan.CheckOnClick = true;
            this.clbThanhPhan.FormattingEnabled = true;
            this.clbThanhPhan.Location = new System.Drawing.Point(15, 76);
            this.clbThanhPhan.Name = "clbThanhPhan";
            this.clbThanhPhan.Size = new System.Drawing.Size(172, 364);
            this.clbThanhPhan.TabIndex = 0;
            this.clbThanhPhan.Click += new System.EventHandler(this.clbThanhPhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thành phần tham dự";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(250, 25);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(248, 20);
            this.dtpThoiGian.TabIndex = 3;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(250, 51);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(248, 20);
            this.txtDiaDiem.TabIndex = 4;
            this.txtDiaDiem.Text = "Hội trường UBND thị trấn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(250, 77);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(248, 20);
            this.txtNoiDung.TabIndex = 4;
            this.txtNoiDung.Text = "Họp UBND định kỳ";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(423, 136);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // ckbXungDanh
            // 
            this.ckbXungDanh.AutoSize = true;
            this.ckbXungDanh.Checked = true;
            this.ckbXungDanh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbXungDanh.Location = new System.Drawing.Point(15, 27);
            this.ckbXungDanh.Name = "ckbXungDanh";
            this.ckbXungDanh.Size = new System.Drawing.Size(78, 17);
            this.ckbXungDanh.TabIndex = 6;
            this.ckbXungDanh.Text = "Danh xưng";
            this.ckbXungDanh.UseVisualStyleBackColor = true;
            // 
            // txtXungDanh
            // 
            this.txtXungDanh.Location = new System.Drawing.Point(99, 25);
            this.txtXungDanh.Name = "txtXungDanh";
            this.txtXungDanh.Size = new System.Drawing.Size(88, 20);
            this.txtXungDanh.TabIndex = 7;
            this.txtXungDanh.Text = "Đ/c";
            // 
            // canboBindingSource
            // 
            this.canboBindingSource.DataSource = typeof(MOffice.CanBo);
            // 
            // ckbTatCaThanhPhan
            // 
            this.ckbTatCaThanhPhan.AutoSize = true;
            this.ckbTatCaThanhPhan.Location = new System.Drawing.Point(15, 53);
            this.ckbTatCaThanhPhan.Name = "ckbTatCaThanhPhan";
            this.ckbTatCaThanhPhan.Size = new System.Drawing.Size(81, 17);
            this.ckbTatCaThanhPhan.TabIndex = 6;
            this.ckbTatCaThanhPhan.Text = "Chọn tất cả";
            this.ckbTatCaThanhPhan.UseVisualStyleBackColor = true;
            this.ckbTatCaThanhPhan.CheckStateChanged += new System.EventHandler(this.ckbTatCaThanhPhan_CheckStateChanged);
            // 
            // TienIchThoMoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 457);
            this.Controls.Add(this.txtXungDanh);
            this.Controls.Add(this.ckbTatCaThanhPhan);
            this.Controls.Add(this.ckbXungDanh);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbThanhPhan);
            this.Name = "TienIchThoMoiForm";
            this.Text = "Tạo thơ mời";
            this.Load += new System.EventHandler(this.TienIchThoMoiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canboBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbThanhPhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource canboBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.CheckBox ckbXungDanh;
        private System.Windows.Forms.TextBox txtXungDanh;
        private System.Windows.Forms.CheckBox ckbTatCaThanhPhan;
    }
}