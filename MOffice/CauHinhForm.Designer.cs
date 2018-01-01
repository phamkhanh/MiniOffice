namespace MOffice
{
    partial class CauHinhForm
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
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnCheckConnect = new System.Windows.Forms.Button();
            this.radWindowsAuth = new System.Windows.Forms.RadioButton();
            this.radSqlServerAuth = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(108, 12);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(183, 20);
            this.txtServerName.TabIndex = 0;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(108, 84);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(183, 20);
            this.txtAccount.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(108, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'X';
            this.txtPassword.Size = new System.Drawing.Size(183, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(108, 136);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(183, 20);
            this.txtDatabase.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Máy chủ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cơ sở dữ liệu";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(216, 162);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Lưu";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCheckConnect
            // 
            this.btnCheckConnect.Location = new System.Drawing.Point(108, 162);
            this.btnCheckConnect.Name = "btnCheckConnect";
            this.btnCheckConnect.Size = new System.Drawing.Size(102, 23);
            this.btnCheckConnect.TabIndex = 6;
            this.btnCheckConnect.Text = "Kiểm tra kết nối";
            this.btnCheckConnect.UseVisualStyleBackColor = true;
            this.btnCheckConnect.Click += new System.EventHandler(this.btnCheckConnect_Click);
            // 
            // radWindowsAuth
            // 
            this.radWindowsAuth.AutoSize = true;
            this.radWindowsAuth.Location = new System.Drawing.Point(108, 38);
            this.radWindowsAuth.Name = "radWindowsAuth";
            this.radWindowsAuth.Size = new System.Drawing.Size(120, 17);
            this.radWindowsAuth.TabIndex = 1;
            this.radWindowsAuth.TabStop = true;
            this.radWindowsAuth.Text = "Tài khoản Windows";
            this.radWindowsAuth.UseVisualStyleBackColor = true;
            // 
            // radSqlServerAuth
            // 
            this.radSqlServerAuth.AutoSize = true;
            this.radSqlServerAuth.Location = new System.Drawing.Point(108, 61);
            this.radSqlServerAuth.Name = "radSqlServerAuth";
            this.radSqlServerAuth.Size = new System.Drawing.Size(131, 17);
            this.radSqlServerAuth.TabIndex = 2;
            this.radSqlServerAuth.TabStop = true;
            this.radSqlServerAuth.Text = "Tài khoản SQL Server";
            this.radSqlServerAuth.UseVisualStyleBackColor = true;
            this.radSqlServerAuth.CheckedChanged += new System.EventHandler(this.radSqlServerAuth_CheckedChanged);
            // 
            // CauHinhForm
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 194);
            this.Controls.Add(this.radSqlServerAuth);
            this.Controls.Add(this.radWindowsAuth);
            this.Controls.Add(this.btnCheckConnect);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CauHinhForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình máy chủ";
            this.Load += new System.EventHandler(this.CauHinhForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnCheckConnect;
        private System.Windows.Forms.RadioButton radWindowsAuth;
        private System.Windows.Forms.RadioButton radSqlServerAuth;
    }
}