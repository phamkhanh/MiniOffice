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

namespace MOffice.eVanBanDi
{
    public partial class VanBanDiEdit : Form
    {
        private void FCbbLoaiVanBanLoading()
        {
            loaiVanBanBindingSource.DataSource = AppContext.Instance.LoaiVanBans.ToList();
        }

        private void FCbbCoQuanLoading()
        {
            coQuanBindingSource.DataSource = (from coquans in AppContext.Instance.CoQuans
                                              where (coquans.Xa == 1)
                                              select coquans).ToList();
        }

        private void FDgvVanBanDiLoading(LoaiVanBan loaiVanBan, string strTag, DateTime ngayBanHanh)
        {
            int sodi = 0;
            try
            {
                sodi = Int32.Parse(strTag);
            }
            catch (Exception)
            {
                sodi = 0;
            }
            if (loaiVanBan != null)
            {
                vanBanDiBindingSource.DataSource = (from listvanbandi in AppContext.Instance.VanBanDis
                                                    where (listvanbandi.NgayBanHanh.Value.Year == ngayBanHanh.Year && (listvanbandi.SoDi == sodi || listvanbandi.SoKyHieu.Contains(strTag) || listvanbandi.TrichYeu.Contains(strTag) || listvanbandi.GhiChu.Contains(strTag)))
                                                    orderby listvanbandi.UpdateDate descending
                                                    select listvanbandi).Take(10).ToList();
            }
        }

        private void FMixFileName()
        {
            string mixSoKyHieu = Funcs.RejectMarks(txtSoKyHieu.Text);
            string mixNgayBanHanh = String.Format("{0} {1} {2}", dtpNgayBanHanh.Value.Day, dtpNgayBanHanh.Value.Month, dtpNgayBanHanh.Value.Year);
            string mixTrichYeu = Funcs.RejectMarks(txtTrichYeu.Text);
            string mixCompleted = String.Format("{0}-{1}-{2}-{3}", txtSoDi.Text, mixSoKyHieu, mixNgayBanHanh, mixTrichYeu);
            txtTenFile.Text = mixCompleted;
        }

        private string FGetSoKyHieu(string sodi, LoaiVanBan loaiVanBan, string chenKyTu)
        {
            string mixSoKyHieu = "";
            if (loaiVanBan != null)
            {
                mixSoKyHieu = sodi + chenKyTu + loaiVanBan.KyHieu;
            }
            return mixSoKyHieu;
        }

        public VanBanDiEdit()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FDgvVanBanDiLoading(cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtTimKiem.Text, dtpNgayBanHanh.Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            vanBanDiBindingSource.ResetBindings(false);
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
            FDgvVanBanDiLoading(cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtTimKiem.Text, dtpNgayBanHanh.Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //var a = AppContext.Instance.ChangeTracker;
                //Funcs.DisplayTrackedEntities(AppContext.Instance.ChangeTracker);

                //var entries = a.Entries();
                //foreach (var entry in entries)
                //{
                //    if(entry.State == EntityState.Modified)
                //    {
                //        VanBanDi vbdi = entry.Entity as VanBanDi;
                //        Console.WriteLine(vbdi.Id);
                //    }
                //}

                VanBanDi vanBanDi = vanBanDiBindingSource.Current as VanBanDi;
                vanBanDi.UpdateDate = DateTime.Now;
                vanBanDi.LoaiVanBan = cbbLoaiVanBan.SelectedItem as LoaiVanBan;
                vanBanDi.Path = InitSetting.DirectoryVbDi + (cbbCoQuan.SelectedItem as CoQuan).Id + "\\" + txtSoDi.Text + "\\";
                AppContext.Instance.SaveChanges();
                //Msg.Info("Dữ liệu đã được lưu");
                FDgvVanBanDiLoading(cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtTimKiem.Text, dtpNgayBanHanh.Value);
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message);
            }
        }

        private void VanBanDiEdit_Load(object sender, EventArgs e)
        {
            FCbbLoaiVanBanLoading();
            FCbbCoQuanLoading();
            FDgvVanBanDiLoading(cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtTimKiem.Text, dtpNgayBanHanh.Value);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            FMixFileName();
            Clipboard.SetText(txtTenFile.Text);
        }

        private void cbbLoaiVanBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoKyHieu.Text = FGetSoKyHieu(txtSoDi.Text, cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtMix.Text);
        }
    }
}
