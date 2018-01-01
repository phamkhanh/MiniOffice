using MOffice.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOffice
{
    public partial class ReportVanBanDen : Form
    {
        int _year = 0;

        public ReportVanBanDen()
        {
            InitializeComponent();
        }

        public ReportVanBanDen(int year)
        {
            InitializeComponent();
            _year = year;
        }

        private void ReportVanBanDen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MOfficeDataSet.VanBanDenReportView' table. You can move, or remove it, as needed.
            this.VanBanDenReportViewTableAdapter.Fill(this.MOfficeDataSet.VanBanDenReportView, _year);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
