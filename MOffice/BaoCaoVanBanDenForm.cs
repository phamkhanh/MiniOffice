using MOffice.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOffice
{
    public partial class BaoCaoVanBanDenForm : Form
    {
        private void FCbbLoaiVanBanLoading()
        {
            loaiVanBanBindingSource.DataSource = AppContext.Instance.LoaiVanBans.ToList();
            cbbLoaiVanBan.SelectedIndex = -1;
        }

        private void FSearch(LoaiVanBan loaivb, string sokyhieu, string trichyeu)
        {
            if (loaivb != null)
            {
                List<VanBanDen> listVbDen = (from vbden in AppContext.Instance.VanBanDens
                             where (vbden.SoKyHieu.Contains(sokyhieu) &&
                                     vbden.TrichYeu.Contains(trichyeu)) &&
                                     vbden.LoaiVanBanId == loaivb.Id
                             select vbden).ToList<VanBanDen>();
                vanBanDenBindingSource.DataSource = listVbDen;
            }
            else
            {
                vanBanDenBindingSource.DataSource = (from vbden in AppContext.Instance.VanBanDens
                                                     where vbden.SoKyHieu.Contains(sokyhieu) &&
                                                             vbden.TrichYeu.Contains(trichyeu)
                                                     select vbden).ToList();
            }
        }

        public BaoCaoVanBanDenForm()
        {
            InitializeComponent();
        }

        private void BaoCaoVanBanDenForm_Load(object sender, EventArgs e)
        {
            FCbbLoaiVanBanLoading();
            FSearch(cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtSoKyHieu.Text, txtTrichYeu.Text);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            FSearch(cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtSoKyHieu.Text, txtTrichYeu.Text);
        }

        private void cbbLoaiVanBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            FSearch(cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtSoKyHieu.Text, txtTrichYeu.Text);
        }

        private void cbbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            FSearch(cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtSoKyHieu.Text, txtTrichYeu.Text);
        }

        private void dgvVanBanDen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVanBanDen.Columns[e.ColumnIndex].Name == "Delete")
            {
                AppContext.Instance.VanBanDenFiles.RemoveRange((vanBanDenBindingSource.Current as VanBanDen).VanBanDenFiles);
                AppContext.Instance.VanBanDens.Remove(vanBanDenBindingSource.Current as VanBanDen);
                AppContext.Instance.SaveChanges();
                vanBanDenBindingSource.RemoveAt(e.RowIndex);
            }

            if (dgvVanBanDen.Columns[e.ColumnIndex].Name == "View")
            {
                //List<VanBan> listVanBanDenFile = vanBanDenFileBindingSource.List.OfType<VanBanDenFile>().ToList();
                Process.Start(Path.GetDirectoryName((vanBanDenBindingSource.Current as VanBanDen).Path));
            }
        }

        private void btnInReport_Click(object sender, EventArgs e)
        {
            ReportVanBanDenForm reportFrm = new ReportVanBanDenForm(dtpNamReport.Value.Year);
            reportFrm.ShowDialog();
        }
    }
}
