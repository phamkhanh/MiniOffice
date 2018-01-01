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

namespace MOffice.eVanBanDenHuyen
{
    public partial class SoVanBanDenHuyenForm : Form
    {
        VanBanDenHuyen _VanBanDenHuyen;

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

        private string FGetSoden(DateTime ngayden)
        {
            string soden = "1";
            VanBanDenHuyen eVanBanDenHuyen = (from queryVanBanDenHuyen in AppContext.Instance.VanBanDenHuyens
                                            where (queryVanBanDenHuyen.NgayDen.Value.Year == ngayden.Year)
                                            orderby queryVanBanDenHuyen.SoDen descending
                                            select queryVanBanDenHuyen).FirstOrDefault();
            if (eVanBanDenHuyen != null)
            {
                soden = (eVanBanDenHuyen.SoDen + 1).ToString();
            }
            return soden;
        }

        private void FAddVanBanDenHuyen(CoQuan coquan, LoaiVanBan loaivanban, User user, string soden, DateTime ngayden, DateTime ngaybanhanh, string sokyhieu, string trichyeu, string ghichu, string nguoinhan)
        {
            int mixSoDen = 0;
            try
            {
                mixSoDen = Int32.Parse(soden);
            }
            catch (Exception)
            {
                mixSoDen = 0;
            }

            _VanBanDenHuyen = new VanBanDenHuyen();
            _VanBanDenHuyen.CoQuan = coquan;
            _VanBanDenHuyen.LoaiVanBan = loaivanban;
            _VanBanDenHuyen.User = user;
            _VanBanDenHuyen.SoDen = mixSoDen;
            _VanBanDenHuyen.NgayDen = ngayden;
            _VanBanDenHuyen.NgayBanHanh = ngaybanhanh;
            _VanBanDenHuyen.SoKyHieu = sokyhieu;
            _VanBanDenHuyen.TrichYeu = Funcs.FirstCharToUpper( trichyeu);
            _VanBanDenHuyen.GhiChu = Funcs.FirstCharToUpper( ghichu);
            _VanBanDenHuyen.NguoiNhan = Funcs.FirstCharToUpper( nguoinhan);
            _VanBanDenHuyen.UpdateDate = DateTime.Now;
            AppContext.Instance.VanBanDenHuyens.Add(_VanBanDenHuyen);

            string logcontent = LoginForm.LoginMember.UserName + " đã nhập " + _VanBanDenHuyen.LoaiVanBan.Ten + " đến [ HUYỆN ] số " + _VanBanDenHuyen.SoDen + " ký hiệu " + _VanBanDenHuyen.SoKyHieu + " ngày " + String.Format("{0} {1} {2}", dtpNgayDen.Value.Day, dtpNgayDen.Value.Month, dtpNgayDen.Value.Year) + " trích yếu " + _VanBanDenHuyen.TrichYeu;
            FWriteLog(logcontent);

            AppContext.Instance.SaveChanges();
        }

        private void FWriteLog(string logcontent)
        {
            AppContext.Instance.UserLogs.Add(new UserLog()
            {
                LogContent = logcontent,
                LogDate = DateTime.Now,
                User = LoginForm.LoginMember
            });
        }

        private void FMixFileName()
        {
            string mixSoKyHieu = Funcs.RejectMarks(txtSoKyHieu.Text);
            string mixNgayBanHanh = String.Format("{0} {1} {2}", dtpNgayBanHanh.Value.Day, dtpNgayBanHanh.Value.Month, dtpNgayBanHanh.Value.Year);
            string mixTrichYeu = Funcs.RejectMarks(txtTrichYeu.Text);
            string mixCompleted = String.Format("{0}-{1}-{2}-{3}", txtSoDen.Text, mixSoKyHieu, mixNgayBanHanh, mixTrichYeu);
            txtTenFile.Text = mixCompleted;
        }

        public SoVanBanDenHuyenForm()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FDgvVanBanDenHuyenLoading(txtTimKiem.Text);
            txtTimKiem.Focus();
            txtTimKiem.SelectAll();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SoVanBanDenHuyenReport frm = new SoVanBanDenHuyenReport(dtpNgayDen.Value.Year);
            frm.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SoVanBanDenHuyenEdit frm = new SoVanBanDenHuyenEdit();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FAddVanBanDenHuyen(cbbCoQuan.SelectedItem as CoQuan, cbbLoaiVanBan.SelectedItem as LoaiVanBan, LoginForm.LoginMember, txtSoDen.Text, dtpNgayDen.Value, dtpNgayBanHanh.Value, txtSoKyHieu.Text, txtTrichYeu.Text, txtGhiChu.Text, txtNguoiNhan.Text);
            FDgvVanBanDenHuyenLoading(txtTimKiem.Text);
            txtSoDen.Text = FGetSoden(dtpNgayDen.Value);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            FMixFileName();
            Clipboard.SetText(txtTenFile.Text);
        }

        private void SoVanBanDenHuyenForm_Load(object sender, EventArgs e)
        {
            FCbbLoaiVanBanLoading();
            FCbbCoQuanLoading();
            FDgvVanBanDenHuyenLoading(txtTimKiem.Text);
            txtSoDen.Text = FGetSoden(dtpNgayDen.Value);
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

        private void dtpNgayDen_ValueChanged(object sender, EventArgs e)
        {
            txtSoDen.Text = FGetSoden(dtpNgayDen.Value);
        }

        private void dgvVanBanDenHuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVanBanDenHuyen.Columns[e.ColumnIndex].Name == "OpenFolder")
            {
                VanBanDenHuyen vbdenhuyen = (vanBanDenHuyenBindingSource.Current as VanBanDenHuyen);
                string path = "CoQuan " + (cbbCoQuan.SelectedItem as CoQuan).Id + "\\LoaiVanBan " + (cbbLoaiVanBan.SelectedItem as LoaiVanBan).Id + "\\" +vbdenhuyen.Id;
                vbdenhuyen.Path = path;
                AppContext.Instance.SaveChanges();
                if (!Directory.Exists(InitSetting.DirectoryVbDen + path))
                {
                    Directory.CreateDirectory(InitSetting.DirectoryVbDen + path);
                }
                Process.Start(InitSetting.DirectoryVbDen + path);
            }

            if (dgvVanBanDenHuyen.Columns[e.ColumnIndex].Name == "Xoa")
            {
                AppContext.Instance.VanBanDenHuyens.Remove(vanBanDenHuyenBindingSource.Current as VanBanDenHuyen);
                AppContext.Instance.SaveChanges();
                FDgvVanBanDenHuyenLoading(txtTimKiem.Text);
            }
        }
    }
}
