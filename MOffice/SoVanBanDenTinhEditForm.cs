using MOffice.Context;
using MOffice.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOffice
{
    public partial class SoVanBanDenTinhEditForm : Form
    {
        private void FCbbLoaiVanBanLoading()
        {
            loaiVanBanBindingSource.DataSource = AppContext.Instance.LoaiVanBans.ToList();
        }

        private void FCbbCoQuanLoading()
        {
            coQuanBindingSource.DataSource = (from coquans in AppContext.Instance.CoQuans
                                              where (coquans.Tinh == 1)
                                              select coquans).ToList();
        }

        private void FDgvVanBanDenTinhLoading(string strTag)
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
            vanBanDenTinhBindingSource.DataSource = (from listvanbandentinh in AppContext.Instance.VanBanDenTinhs
                                                     where (listvanbandentinh.SoDen == soden || listvanbandentinh.SoKyHieu.Contains(sokyhieu) || listvanbandentinh.TrichYeu.Contains(trichyeu) || listvanbandentinh.GhiChu.Contains(ghichu))
                                                     orderby listvanbandentinh.SoDen descending
                                                     select listvanbandentinh).ToList();
        }

        private void FMixFileName()
        {
            string mixSoKyHieu = Funcs.RejectMarks(txtSoKyHieu.Text);
            string mixNgayBanHanh = String.Format("{0} {1} {2}", dtpNgayBanHanh.Value.Day, dtpNgayBanHanh.Value.Month, dtpNgayBanHanh.Value.Year);
            string mixTrichYeu = Funcs.RejectMarks(txtTrichYeu.Text);
            string mixCompleted = String.Format("{0}-{1}-{2}-{3}", txtSoDen.Text, mixSoKyHieu, mixNgayBanHanh, mixTrichYeu);
            txtTenFile.Text = mixCompleted;
        }

        public SoVanBanDenTinhEditForm()
        {
            InitializeComponent();
        }

        private void SoVanBanDenTinhEditForm_Load(object sender, EventArgs e)
        {
            FCbbLoaiVanBanLoading();
            FCbbCoQuanLoading();
            FDgvVanBanDenTinhLoading(txtTimKiem.Text);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FDgvVanBanDenTinhLoading(txtTimKiem.Text);
            txtTimKiem.Focus();
            txtTimKiem.SelectAll();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            FMixFileName();
            Clipboard.SetText(txtTenFile.Text);
        }

        private void txtSoKyHieu_TextChanged(object sender, EventArgs e)
        {
            FMixFileName();
        }

        private void dtpNgayBanHanh_ValueChanged(object sender, EventArgs e)
        {
            FMixFileName();
        }

        private void txtTrichYeu_TextChanged(object sender, EventArgs e)
        {
            FMixFileName();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                VanBanDenTinh vanBanDenTinh = vanBanDenTinhBindingSource.Current as VanBanDenTinh;
                vanBanDenTinh.UpdateDate = DateTime.Now;
                vanBanDenTinh.Path = InitSetting.DirectoryVbDen + "\\Huyen " + (cbbCoQuan.SelectedItem as CoQuan).Id + "\\" + txtSoDen.Text + "\\";
                AppContext.Instance.SaveChanges();
                Msg.Info("Dữ liệu đã được lưu");
                FDgvVanBanDenTinhLoading(txtTimKiem.Text);
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            vanBanDenTinhBindingSource.ResetBindings(false);
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
            FDgvVanBanDenTinhLoading(txtTimKiem.Text);
        }
    }
}
