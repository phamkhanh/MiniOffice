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
    public partial class ReportVanBanDiForm : Form
    {
        int _NamBanHanh = 0;
        int _LoaiVanBan = 0;

        public ReportVanBanDiForm()
        {
            InitializeComponent();
        }

        public ReportVanBanDiForm(int nambanhanh, int loaivb)
        {
            InitializeComponent();
            _NamBanHanh = nambanhanh;
            _LoaiVanBan = loaivb;
        }

        private void ReportVanBanDiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MOfficeDataSet.VanBanDiReportView' table. You can move, or remove it, as needed.
            this.VanBanDiReportViewTableAdapter.Fill(this.MOfficeDataSet.VanBanDiReportView, _NamBanHanh, _LoaiVanBan);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
