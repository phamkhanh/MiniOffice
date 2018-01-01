using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOffice.eVanBanDi
{
    public partial class VanBanDiReport : Form
    {
        int _LoaiVanBanId = 0;
        int _Year = 0;

        public VanBanDiReport()
        {
            InitializeComponent();
        }

        public VanBanDiReport(int loaiVanBanId, int year)
        {
            InitializeComponent();
            _LoaiVanBanId = loaiVanBanId;
            _Year = year;
        }

        private void VanBanDiReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOfficeDataSet.VanBanDiReportViewDataTable' table. You can move, or remove it, as needed.
            this.vanBanDiReportViewDataTableTableAdapter.Fill(this.mOfficeDataSet.VanBanDiReportViewDataTable, _Year, _LoaiVanBanId);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
