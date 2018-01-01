namespace MOffice.eVanBanDenHuyen
{
    partial class SoVanBanDenHuyenReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoVanBanDenHuyenReport));
            this.vanBanDenHuyenReportDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOfficeDataSet = new MOffice.MOfficeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vanBanDenHuyenReportTableAdapter = new MOffice.MOfficeDataSetTableAdapters.VanBanDenHuyenReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenHuyenReportDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOfficeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vanBanDenHuyenReportDataTableBindingSource
            // 
            this.vanBanDenHuyenReportDataTableBindingSource.DataMember = "VanBanDenHuyenReportDataTable";
            this.vanBanDenHuyenReportDataTableBindingSource.DataSource = this.mOfficeDataSet;
            // 
            // mOfficeDataSet
            // 
            this.mOfficeDataSet.DataSetName = "MOfficeDataSet";
            this.mOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "VanBanDenHuyenReportDataSet";
            reportDataSource1.Value = this.vanBanDenHuyenReportDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MOffice.Report.ReportViewSoVanBanDenHuyen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // vanBanDenHuyenReportTableAdapter
            // 
            this.vanBanDenHuyenReportTableAdapter.ClearBeforeFill = true;
            // 
            // SoVanBanDenHuyenReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoVanBanDenHuyenReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In sổ văn bản đến - HUYỆN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SoVanBanDenHuyenReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenHuyenReportDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOfficeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vanBanDenHuyenReportDataTableBindingSource;
        private MOfficeDataSet mOfficeDataSet;
        private MOfficeDataSetTableAdapters.VanBanDenHuyenReportTableAdapter vanBanDenHuyenReportTableAdapter;
    }
}