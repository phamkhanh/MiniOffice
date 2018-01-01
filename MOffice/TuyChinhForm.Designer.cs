namespace MOffice
{
    partial class TuyChinhForm
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
            this.btnThuMucVanBan = new System.Windows.Forms.Button();
            this.lblThuMucVanBan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThuMucVanBan
            // 
            this.btnThuMucVanBan.Location = new System.Drawing.Point(13, 13);
            this.btnThuMucVanBan.Name = "btnThuMucVanBan";
            this.btnThuMucVanBan.Size = new System.Drawing.Size(132, 23);
            this.btnThuMucVanBan.TabIndex = 0;
            this.btnThuMucVanBan.Text = "Thư mục lưu trữ văn bản";
            this.btnThuMucVanBan.UseVisualStyleBackColor = true;
            this.btnThuMucVanBan.Click += new System.EventHandler(this.btnThuMucVanBan_Click);
            // 
            // lblThuMucVanBan
            // 
            this.lblThuMucVanBan.AutoSize = true;
            this.lblThuMucVanBan.Location = new System.Drawing.Point(151, 18);
            this.lblThuMucVanBan.Name = "lblThuMucVanBan";
            this.lblThuMucVanBan.Size = new System.Drawing.Size(0, 13);
            this.lblThuMucVanBan.TabIndex = 1;
            // 
            // TuyChinhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 403);
            this.Controls.Add(this.lblThuMucVanBan);
            this.Controls.Add(this.btnThuMucVanBan);
            this.Name = "TuyChinhForm";
            this.Text = "Tủy chỉnh";
            this.Load += new System.EventHandler(this.TuyChinhForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThuMucVanBan;
        private System.Windows.Forms.Label lblThuMucVanBan;
    }
}