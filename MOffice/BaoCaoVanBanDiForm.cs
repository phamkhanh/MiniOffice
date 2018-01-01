using MOffice.Context;
using MOffice.Helper;
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
    public partial class BaoCaoVanBanDiForm : Form
    {
        private void FCbbLoaiVanBanLoading()
        {
            loaiVanBanBindingSource.DataSource = AppContext.Instance.LoaiVanBans.ToList();
        }

        private void FCbbUserLoading()
        {
            userBindingSource.DataSource = AppContext.Instance.Users.ToList();
        }

        private void FSearch(LoaiVanBan loaivb, string sokyhieu, string trichyeu)
        {
            if (loaivb != null)
            {
                List<VanBanDi> listVbDi = (from vbdi in AppContext.Instance.VanBanDis
                                           where (vbdi.SoKyHieu.Contains(sokyhieu) &&
                                                     vbdi.TrichYeu.Contains(trichyeu)) &&
                                                     vbdi.LoaiVanBanId == loaivb.Id
                                           select vbdi).ToList<VanBanDi>();
                vanBanDiBindingSource.DataSource = listVbDi;
            }
            else
            {
                vanBanDiBindingSource.DataSource = (from vbdi in AppContext.Instance.VanBanDis
                                                    where vbdi.SoKyHieu.Contains(sokyhieu) &&
                                                             vbdi.TrichYeu.Contains(trichyeu)
                                                    select vbdi).ToList();
            }
        }

        public BaoCaoVanBanDiForm()
        {
            InitializeComponent();
        }

        private void BaoCaoVanBanDiForm_Load(object sender, EventArgs e)
        {
            FCbbLoaiVanBanLoading();
            FCbbUserLoading();
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

        private void dgvVanBanDi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVanBanDi.Columns[e.ColumnIndex].Name == "Delete")
            {
                AppContext.Instance.VanBanDiFiles.RemoveRange((vanBanDiBindingSource.Current as VanBanDi).VanBanDiFiles);
                AppContext.Instance.VanBanDis.Remove(vanBanDiBindingSource.Current as VanBanDi);
                AppContext.Instance.SaveChanges();
                vanBanDiBindingSource.RemoveAt(e.RowIndex);
            }

            if (dgvVanBanDi.Columns[e.ColumnIndex].Name == "View")
            {
                Process.Start(Path.GetDirectoryName((vanBanDiBindingSource.Current as VanBanDi).Path));
            }
        }

        private void btnInReport_Click(object sender, EventArgs e)
        {
            //ReportVanBanDiForm reportFrm = new ReportVanBanDiForm(dtpNamReport.Value.Year, (cbbLoaiVanBan.SelectedItem as LoaiVanBan).Id);
            //reportFrm.ShowDialog();
        }
    }
}
