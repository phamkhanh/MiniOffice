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

namespace MOffice
{
    public partial class SoVanBanDenHuyenForm3 : Form
    {
        private string _pathVanBanDenHuyen;

        public string PathVanBanDenHuyen
        {
            get { return 
                _pathVanBanDenHuyen = InitSetting.DirectoryVbDen + "\\Huyen " + (cbbCoQuanBanHanh.SelectedItem as CoQuan).Id + "\\" + txtSoDen.Text + "\\";
            }
        }

        private VanBanDenHuyen _objVanBanDenHuyen;

        public VanBanDenHuyen ObjVanBanDenHuyen
        {
            get {
                _objVanBanDenHuyen = vanBanDenHuyenBindingSource.Current as VanBanDenHuyen;
                return _objVanBanDenHuyen; 
            }
            set { _objVanBanDenHuyen = value; }
        }


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

        private void FSetSoden()
        {
            CoQuan cq = cbbCoQuanBanHanh.SelectedItem as CoQuan;
            int year = dtpNgayDen.Value.Year;
            if (cq != null)
            {
                VanBanDenHuyen eVanBanDenHuyen = (from _eVanBanDen in AppContext.Instance.VanBanDenHuyens.Where(e => e.CoQuanId == cq.Id && e.NgayDen.Value.Year == year)
                                        orderby _eVanBanDen.SoDen descending
                                        select _eVanBanDen).FirstOrDefault();
                if (eVanBanDenHuyen != null)
                {
                    ObjVanBanDenHuyen.SoDen = (eVanBanDenHuyen.SoDen + 1);
                }
                else
                {
                    txtSoDen.Text = "1";
                }
            }
        }

        private void FDgvVanBanDenHuyenLoading(int filterYear)
        {
            var query = AppContext.Instance.VanBanDenHuyens.Where(e => e.NgayDen.Value.Year == filterYear).OrderByDescending(e => e.SoDen).ToList();
            vanBanDenHuyenBindingSource.DataSource = query;
        }

        private void FInsertVanBanDenHuyen(DateTime pngayden, string psoden, CoQuan pcoquan, string psokyhieu, DateTime pngaybanhanh, LoaiVanBan ploaivanban, string ptrichyeu, string pnguoinhan, string pghichu, User puser, string ppath)
        {
            int mixSoden;
            try
            {
                mixSoden = Int32.Parse(psoden);
            }
            catch (Exception)
            {
                mixSoden = 0;
            }
            ObjVanBanDenHuyen.CoQuan = pcoquan;
            ObjVanBanDenHuyen.LoaiVanBan = ploaivanban;
            ObjVanBanDenHuyen.User = puser;
            ObjVanBanDenHuyen.NgayDen = pngayden;
            ObjVanBanDenHuyen.SoDen = mixSoden;
            ObjVanBanDenHuyen.SoKyHieu = psokyhieu;
            ObjVanBanDenHuyen.NgayBanHanh = pngaybanhanh;
            ObjVanBanDenHuyen.TrichYeu = ptrichyeu;
            ObjVanBanDenHuyen.NguoiNhan = pnguoinhan;
            ObjVanBanDenHuyen.GhiChu = pghichu;
            ObjVanBanDenHuyen.Path = ppath;
            AppContext.Instance.VanBanDenHuyens.Add(ObjVanBanDenHuyen);
        }

        public SoVanBanDenHuyenForm3()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ObjVanBanDenHuyen.UpdateDate = DateTime.Now;
                ObjVanBanDenHuyen.Path = PathVanBanDenHuyen;
                if (!btnTaoMoi.Enabled)
                {
                    string log = LoginForm.LoginMember.UserName + " đã nhập " + ObjVanBanDenHuyen.LoaiVanBan.Ten + " đến số " + ObjVanBanDenHuyen.SoDen + " ký hiệu " + ObjVanBanDenHuyen.SoKyHieu + " ngày " + String.Format("{0} {1} {2}", dtpNgayDen.Value.Day, dtpNgayDen.Value.Month, dtpNgayDen.Value.Year) + " trích yếu " + ObjVanBanDenHuyen.TrichYeu;
                    AppContext.Instance.UserLogs.Add(new UserLog() { LogContent = log, LogDate = DateTime.Now, User = ObjVanBanDenHuyen.User });
                }

                AppContext.Instance.SaveChanges();
                btnTaoMoi.Enabled = true;
                Msg.Info("Dữ liệu đã được lưu");
                FDgvVanBanDenHuyenLoading(dtpNgayDen.Value.Year);
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message);
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            btnTaoMoi.Enabled = false;
            dtpNgayDen.Focus();
            ObjVanBanDenHuyen = new VanBanDenHuyen();
            vanBanDenHuyenBindingSource.Add(ObjVanBanDenHuyen);
            FInsertVanBanDenHuyen(dtpNgayDen.Value, txtSoDen.Text, cbbCoQuanBanHanh.SelectedItem as CoQuan, txtSoKyHieu.Text, dtpNgayBanHanh.Value, cbLoaiVanBan.SelectedItem as LoaiVanBan, txtTrichYeu.Text, txtNguoiNhan.Text, txtGhiChu.Text, LoginForm.LoginMember, PathVanBanDenHuyen);
            FSetSoden();
            vanBanDenHuyenBindingSource.MoveLast();
        }

        private void SoVanBanDenHuyenForm_Load(object sender, EventArgs e)
        {
            FCbbCoQuanLoading();
            FCbbLoaiVanBanLoading();
            FDgvVanBanDenHuyenLoading(dtpNgayDen.Value.Year);
        }

        private void dtpNgayDen_ValueChanged(object sender, EventArgs e)
        {
            if (!btnTaoMoi.Enabled)
            {
                FSetSoden();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnTaoMoi.Enabled = true;
            btnLuu.Enabled = true;
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
            FDgvVanBanDenHuyenLoading(dtpNgayDen.Value.Year);
        }

        private void dgvVanBanDenHuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVanBanDenHuyen.Columns[e.ColumnIndex].Name == "Xoa")
            {
                AppContext.Instance.VanBanDenHuyens.Remove(vanBanDenHuyenBindingSource.Current as VanBanDenHuyen);
                vanBanDenHuyenBindingSource.RemoveCurrent();
            }
            else if (dgvVanBanDenHuyen.Columns[e.ColumnIndex].Name == "OpenFolder")
            {
                if (!Directory.Exists(ObjVanBanDenHuyen.Path))
                {
                    Directory.CreateDirectory(ObjVanBanDenHuyen.Path);
                }
                Process.Start(ObjVanBanDenHuyen.Path);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int soden = 0;
            try
            {
                soden = Int32.Parse(txtTimKiem.Text);
            }
            catch (Exception)
            {
                soden = 0;
            }
            string sokyhieu = txtTimKiem.Text;
            string trichyeu = txtTimKiem.Text;
            string ghichu = txtTimKiem.Text;
            var query = (from listvbdenhuyen in AppContext.Instance.VanBanDenHuyens
                         where (listvbdenhuyen.SoDen == soden || listvbdenhuyen.SoKyHieu.Contains(sokyhieu) || listvbdenhuyen.TrichYeu.Contains(trichyeu) || listvbdenhuyen.GhiChu.Contains(ghichu))
                         select listvbdenhuyen).ToList();
            vanBanDenHuyenBindingSource.DataSource = query;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SoVanBanHuyenDenReport frm = new SoVanBanHuyenDenReport(dtpNgayDen.Value.Year);
            frm.ShowDialog();
        }
    }
}
