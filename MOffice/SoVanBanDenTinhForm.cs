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
    public partial class SoVanBanDenTinhForm : Form
    {
        VanBanDenTinh _VanBanDenTinh;

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

        private string FGetSoden(DateTime ngayden)
        {
            string soden = "1";
            //int year = ngayden.Year;
            VanBanDenTinh eVanBanDenTinh = (from queryVanBanDenTinh in AppContext.Instance.VanBanDenTinhs
                                            where (queryVanBanDenTinh.NgayDen.Value.Year == ngayden.Year)
                                            orderby queryVanBanDenTinh.SoDen descending
                                            select queryVanBanDenTinh).FirstOrDefault();
            if (eVanBanDenTinh != null)
            {
                soden = (eVanBanDenTinh.SoDen + 1).ToString();
            }
            return soden;
        }

        private void FAddVanBanDenTinh(CoQuan coquan, LoaiVanBan loaivanban, User user, string soden, DateTime ngayden, DateTime ngaybanhanh, string sokyhieu, string trichyeu, string ghichu, string nguoinhan)
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

            _VanBanDenTinh = new VanBanDenTinh();
            _VanBanDenTinh.CoQuan = coquan;
            _VanBanDenTinh.LoaiVanBan = loaivanban;
            _VanBanDenTinh.User = user;
            _VanBanDenTinh.SoDen = mixSoDen;
            _VanBanDenTinh.NgayDen = ngayden;
            _VanBanDenTinh.NgayBanHanh = ngaybanhanh;
            _VanBanDenTinh.SoKyHieu = sokyhieu;
            _VanBanDenTinh.TrichYeu = Funcs.FirstCharToUpper( trichyeu);
            _VanBanDenTinh.GhiChu = Funcs.FirstCharToUpper( ghichu);
            _VanBanDenTinh.NguoiNhan = Funcs.FirstCharToUpper( nguoinhan);
            _VanBanDenTinh.UpdateDate = DateTime.Now;
            AppContext.Instance.VanBanDenTinhs.Add(_VanBanDenTinh);

            string logcontent = LoginForm.LoginMember.UserName + " đã nhập " + _VanBanDenTinh.LoaiVanBan.Ten + " đến [ TỈNH ] số " + _VanBanDenTinh.SoDen + " ký hiệu " + _VanBanDenTinh.SoKyHieu + " ngày " + String.Format("{0} {1} {2}", dtpNgayDen.Value.Day, dtpNgayDen.Value.Month, dtpNgayDen.Value.Year) + " trích yếu " + _VanBanDenTinh.TrichYeu;
            FWriteLog(logcontent);

            AppContext.Instance.SaveChanges();
        }

        private void FWriteLog(string logcontent)
        {
            AppContext.Instance.UserLogs.Add(new UserLog() {
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

        public SoVanBanDenTinhForm()
        {
            InitializeComponent();
        }

        private void SoVanBanDenTinhForm_Load(object sender, EventArgs e)
        {
            FCbbLoaiVanBanLoading();
            FCbbCoQuanLoading();
            FDgvVanBanDenTinhLoading(txtTimKiem.Text);
            txtSoDen.Text = FGetSoden(dtpNgayDen.Value);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FDgvVanBanDenTinhLoading(txtTimKiem.Text);
            txtTimKiem.Focus();
            txtTimKiem.SelectAll();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SoVanBanDenTinhReport frm = new SoVanBanDenTinhReport(dtpNgayDen.Value.Year);
            frm.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FAddVanBanDenTinh(cbbCoQuan.SelectedItem as CoQuan, cbbLoaiVanBan.SelectedItem as LoaiVanBan, LoginForm.LoginMember, txtSoDen.Text, dtpNgayDen.Value, dtpNgayBanHanh.Value, txtSoKyHieu.Text, txtTrichYeu.Text, txtGhiChu.Text, txtNguoiNhan.Text);
            FDgvVanBanDenTinhLoading(txtTimKiem.Text);
            txtSoDen.Text = FGetSoden(dtpNgayDen.Value);
        }

        private void dtpNgayDen_ValueChanged(object sender, EventArgs e)
        {
            txtSoDen.Text = FGetSoden(dtpNgayDen.Value);
        }

        private void dgvVanBanDenTinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVanBanDenTinh.Columns[e.ColumnIndex].Name == "OpenFolder")
            {
                VanBanDenTinh vbdentinh = (vanBanDenTinhBindingSource.Current as VanBanDenTinh);
                string path = "CoQuan " + (cbbCoQuan.SelectedItem as CoQuan).Id + "\\LoaiVanBan " + (cbbLoaiVanBan.SelectedItem as LoaiVanBan).Id + "\\" + vbdentinh.Id;
                vbdentinh.Path = path;
                AppContext.Instance.SaveChanges();
                if (!Directory.Exists(InitSetting.DirectoryVbDen + path))
                {
                    Directory.CreateDirectory(InitSetting.DirectoryVbDen + path);
                }
                Process.Start(InitSetting.DirectoryVbDen + path);
            }

            if (dgvVanBanDenTinh.Columns[e.ColumnIndex].Name == "Xoa")
            {
                AppContext.Instance.VanBanDenTinhs.Remove(vanBanDenTinhBindingSource.Current as VanBanDenTinh);
                AppContext.Instance.SaveChanges();
                FDgvVanBanDenTinhLoading(txtTimKiem.Text);
            }
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SoVanBanDenTinhEditForm frm = new SoVanBanDenTinhEditForm();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
