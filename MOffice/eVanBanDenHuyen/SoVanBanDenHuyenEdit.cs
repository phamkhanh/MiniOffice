using MOffice.Context;
using MOffice.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOffice.eVanBanDenHuyen
{
    public partial class SoVanBanDenHuyenEdit : Form
    {
        private void FCbbLoaiVanBanLoading()
        {
            loaiVanBanBindingSource.DataSource = AppContext.Instance.LoaiVanBans.ToList();
        }

        private void FCbbCoQuanLoading()
        {
            coQuanBindingSource.DataSource = (from coquans in AppContext.Instance.CoQuans
                                              where (coquans.Huyen == 1)
                                              select coquans).ToList();
        }

        private void FDgvVanBanDenHuyenLoading(string strTag)
        {
            int soden = 0;
            try
            {
                soden = Int32.Parse(strTag);
            }
            catch (Exception)
            {
                soden = 0;
            }
            string sokyhieu = strTag;
            string trichyeu = strTag;
            string ghichu = strTag;
            vanBanDenHuyenBindingSource.DataSource = (from listvanbandenhuyen in AppContext.Instance.VanBanDenHuyens
                                                      where (listvanbandenhuyen.SoDen == soden || listvanbandenhuyen.SoKyHieu.Contains(sokyhieu) || listvanbandenhuyen.TrichYeu.Contains(trichyeu) || listvanbandenhuyen.GhiChu.Contains(ghichu))
                                                      orderby listvanbandenhuyen.SoDen descending
                                                      select listvanbandenhuyen).ToList();
        }

        private void FMixFileName()
        {
            string mixSoKyHieu = Funcs.RejectMarks(txtSoKyHieu.Text);
            string mixNgayBanHanh = String.Format("{0} {1} {2}", dtpNgayBanHanh.Value.Day, dtpNgayBanHanh.Value.Month, dtpNgayBanHanh.Value.Year);
            string mixTrichYeu = Funcs.RejectMarks(txtTrichYeu.Text);
            string mixCompleted = String.Format("{0}-{1}-{2}-{3}", txtSoDen.Text, mixSoKyHieu, mixNgayBanHanh, mixTrichYeu);
            txtTenFile.Text = mixCompleted;
        }

        public SoVanBanDenHuyenEdit()
        {
            InitializeComponent();
        }

        private void txtSoKyHieu_TextChanged(object sender, EventArgs e)
        {
            FMixFileName();
        }

        private void txtTrichYeu_TextChanged(object sender, EventArgs e)
        {
            FMixFileName();
        }

        private void dtpNgayBanHanh_ValueChanged(object sender, EventArgs e)
        {
            FMixFileName();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FDgvVanBanDenHuyenLoading(txtTimKiem.Text);
            txtTimKiem.Focus();
            txtTimKiem.SelectAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            vanBanDenHuyenBindingSource.ResetBindings(false);
            foreach (DbEntityEntry entry in AppContext.Instance.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Detached;
                        entry.Reload();
                        break;
                    default:
                        break;
                }
            }
            FDgvVanBanDenHuyenLoading(txtTimKiem.Text);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                VanBanDenHuyen vanBanDenHuyen = vanBanDenHuyenBindingSource.Current as VanBanDenHuyen;
                vanBanDenHuyen.UpdateDate = DateTime.Now;
                vanBanDenHuyen.Path = InitSetting.DirectoryVbDen + "\\Huyen " + (cbbCoQuan.SelectedItem as CoQuan).Id + "\\" + txtSoDen.Text + "\\";
                AppContext.Instance.SaveChanges();
                Msg.Info("Dữ liệu đã được lưu");
                FDgvVanBanDenHuyenLoading(txtTimKiem.Text);
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            FMixFileName();
            Clipboard.SetText(txtTenFile.Text);
        }

        private void SoVanBanDenHuyenEdit_Load(object sender, EventArgs e)
        {
            FCbbLoaiVanBanLoading();
            FCbbCoQuanLoading();
            FDgvVanBanDenHuyenLoading(txtTimKiem.Text);
        }

        private void dgvVanBanDenHuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVanBanDenHuyen.Columns[e.ColumnIndex].Name == "Xoa")
            {
                AppContext.Instance.VanBanDenHuyens.Remove(vanBanDenHuyenBindingSource.Current as VanBanDenHuyen);
                AppContext.Instance.SaveChanges();
                FDgvVanBanDenHuyenLoading(txtTimKiem.Text);
            }
        }
    }
}
