namespace MOffice
{
    partial class SoVanBanDenTinhReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoVanBanDenTinhReport));
            this.VanBanDenTinhDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MOfficeDataSet = new MOffice.MOfficeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VanBanDenTinhTableAdapter = new MOffice.MOfficeDataSetTableAdapters.VanBanDenTinhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VanBanDenTinhDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MOfficeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VanBanDenTinhDataTableBindingSource
            // 
            this.VanBanDenTinhDataTableBindingSource.DataMember = "VanBanDenTinhDataTable";
            this.VanBanDenTinhDataTableBindingSource.DataSource = this.MOfficeDataSet;
            // 
            // MOfficeDataSet
            // 
            this.MOfficeDataSet.DataSetName = "MOfficeDataSet";
            this.MOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "VanBanDenTinhReportDataSet";
            reportDataSource1.Value = this.VanBanDenTinhDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MOffice.Report.ReportViewSoVanBanDenTinh.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // VanBanDenTinhTableAdapter
            // 
            this.VanBanDenTinhTableAdapter.ClearBeforeFill = true;
            // 
            // SoVanBanDenTinhReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoVanBanDenTinhReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In sổ văn bản đến - TỈNH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SoVanBanDenTinhReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VanBanDenTinhDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MOfficeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VanBanDenTinhDataTableBindingSource;
        private MOfficeDataSet MOfficeDataSet;
        private MOfficeDataSetTableAdapters.VanBanDenTinhTableAdapter VanBanDenTinhTableAdapter;
    }
}