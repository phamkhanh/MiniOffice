using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOffice.eVanBanDenHuyen
{
    public partial class SoVanBanDenHuyenReport : Form
    {
        int _Year = 0;

        public SoVanBanDenHuyenReport()
        {
            InitializeComponent();
        }

        public SoVanBanDenHuyenReport(int year)
        {
            InitializeComponent();
            _Year = year;
        }

        private void SoVanBanDenHuyenReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOfficeDataSet.VanBanDenHuyenReportDataTable' table. You can move, or remove it, as needed.
            this.vanBanDenHuyenReportTableAdapter.Fill(this.mOfficeDataSet.VanBanDenHuyenReportDataTable, _Year);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
