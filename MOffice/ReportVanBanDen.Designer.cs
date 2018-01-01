namespace MOffice
{
    partial class ReportVanBanDen
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MOfficeDataSet = new MOffice.MOfficeDataSet();
            this.VanBanDenReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VanBanDenReportViewTableAdapter = new MOffice.MOfficeDataSetTableAdapters.VanBanDenReportViewTableAdapter();
            this.VanBanDenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MOfficeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanBanDenReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanBanDenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportViewVanBanDenDataSet";
            reportDataSource1.Value = this.VanBanDenReportViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MOffice.Report.ReportViewVanBanDen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(675, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // MOfficeDataSet
            // 
            this.MOfficeDataSet.DataSetName = "MOfficeDataSet";
            this.MOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VanBanDenReportViewBindingSource
            // 
            this.VanBanDenReportViewBindingSource.DataMember = "VanBanDenReportView";
            this.VanBanDenReportViewBindingSource.DataSource = this.MOfficeDataSet;
            // 
            // VanBanDenReportViewTableAdapter
            // 
            this.VanBanDenReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // VanBanDenBindingSource
            // 
            this.VanBanDenBindingSource.DataSource = typeof(MOffice.VanBanDen);
            // 
            // ReportVanBanDen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 446);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportVanBanDen";
            this.Text = "ReportVanBanDen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportVanBanDen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MOfficeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanBanDenReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanBanDenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource VanBanDenBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VanBanDenReportViewBindingSource;
        private MOfficeDataSet MOfficeDataSet;
        private MOfficeDataSetTableAdapters.VanBanDenReportViewTableAdapter VanBanDenReportViewTableAdapter;
    }
}