using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOffice
{
    public partial class SoVanBanHuyenDenReport : Form
    {
        int _Year = 0;

        public SoVanBanHuyenDenReport()
        {
            InitializeComponent();
        }

        public SoVanBanHuyenDenReport(int year)
        {
            InitializeComponent();
            _Year = year;
        }

        private void SoVanBanHuyenDenReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MOfficeDataSet.VanBanDenHuyenReportDataTable' table. You can move, or remove it, as needed.
            this.VanBanDenHuyenReportTableAdapter.Fill(this.MOfficeDataSet.VanBanDenHuyenReportDataTable, _Year);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
