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

namespace MOffice
{
    public partial class SoVanBanDenTinhReport : Form
    {
        int _Year = 0;

        public SoVanBanDenTinhReport()
        {
            InitializeComponent();
        }

        public SoVanBanDenTinhReport(int year)
        {
            InitializeComponent();
            _Year = year;
        }

        private void SoVanBanDenTinhReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MOfficeDataSet.VanBanDenTinhDataTable' table. You can move, or remove it, as needed.
            this.VanBanDenTinhTableAdapter.Fill(this.MOfficeDataSet.VanBanDenTinhDataTable, _Year);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
