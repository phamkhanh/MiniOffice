namespace MOffice
{
    partial class ReportVanBanDiForm
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
            this.VanBanDiReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VanBanDiReportViewTableAdapter = new MOffice.MOfficeDataSetTableAdapters.VanBanDiReportViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MOfficeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanBanDiReportViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportViewVanBanDiDataSet";
            reportDataSource1.Value = this.VanBanDiReportViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MOffice.Report.ReportViewVanBanDi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(675, 446);
            this.reportViewer1.TabIndex = 1;
            // 
            // MOfficeDataSet
            // 
            this.MOfficeDataSet.DataSetName = "MOfficeDataSet";
            this.MOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VanBanDiReportViewBindingSource
            // 
            this.VanBanDiReportViewBindingSource.DataMember = "VanBanDiReportView";
            this.VanBanDiReportViewBindingSource.DataSource = this.MOfficeDataSet;
            // 
            // VanBanDiReportViewTableAdapter
            // 
            this.VanBanDiReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // ReportVanBanDiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 446);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportVanBanDiForm";
            this.Text = "ReportVanBanDiForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportVanBanDiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MOfficeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanBanDiReportViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VanBanDiReportViewBindingSource;
        private MOfficeDataSet MOfficeDataSet;
        private MOfficeDataSetTableAdapters.VanBanDiReportViewTableAdapter VanBanDiReportViewTableAdapter;
    }
}