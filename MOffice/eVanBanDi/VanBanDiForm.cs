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

namespace MOffice.eVanBanDi
{
    public partial class VanBanDiForm : Form
    {
        VanBanDi _VanBanDi;

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

        private void FCbbLoaiTrichYeuLoading()
        {
            loaiTrichYeuBindingSource.DataSource = AppContext.Instance.LoaiTrichYeus.ToList();
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
                vanBanDiFormBindingSource.DataSource = (from listvanbandi in AppContext.Instance.VanBanDis
                                                    where (listvanbandi.NgayBanHanh.Value.Year == ngayBanHanh.Year && listvanbandi.LoaiVanBanId == loaiVanBan.Id && (listvanbandi.SoDi == sodi || listvanbandi.SoKyHieu.Contains(strTag) || listvanbandi.TrichYeu.Contains(strTag) || listvanbandi.GhiChu.Contains(strTag)))
                                                    orderby listvanbandi.SoDi descending
                                                    select listvanbandi).ToList();
            }
        }

        private string FGetSodi(LoaiVanBan loaiVanBan, DateTime ngayBanhanh)
        {
            string sodi = "1";
            VanBanDi eVanBanDi = null;
            if (loaiVanBan != null)
            {
                eVanBanDi = (from queryVanBanDi in AppContext.Instance.VanBanDis
                                      where (queryVanBanDi.LoaiVanBanId == loaiVanBan.Id && queryVanBanDi.NgayBanHanh.Value.Year == ngayBanhanh.Year)
                                      orderby queryVanBanDi.SoDi descending
                                      select queryVanBanDi).FirstOrDefault();
            }

            if (eVanBanDi != null)
            {
                sodi = (eVanBanDi.SoDi + 1).ToString();
            }
            return sodi;
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

        private void FAddVanBanDi(CoQuan coquan, LoaiVanBan loaivanban, User user, string sodi, DateTime ngaybanhanh, string sokyhieu, string trichyeu, string ghichu, string nguoiky)
        {
            int mixSoDi = 0;
            try
            {
                mixSoDi = Int32.Parse(Funcs.RejectMarksOnlyNumber(sodi));
            }
            catch (Exception)
            {
                mixSoDi = 0;
            }

            string mixAlpha = Funcs.RejectMarksOnlyAlpha(sodi);
            
            _VanBanDi = new VanBanDi();
            _VanBanDi.CoQuan = coquan;
            _VanBanDi.LoaiVanBan = loaivanban;
            _VanBanDi.User = user;
            _VanBanDi.SoDi = mixSoDi;
            _VanBanDi.NgayBanHanh = ngaybanhanh;
            _VanBanDi.SoKyHieu = sokyhieu;
            _VanBanDi.TrichYeu = Funcs.FirstCharToUpper(trichyeu);
            _VanBanDi.GhiChu = Funcs.FirstCharToUpper(ghichu);
            _VanBanDi.NguoiKy = Funcs.FirstCharToUpper(nguoiky);
            _VanBanDi.Mix = mixAlpha;
            _VanBanDi.UpdateDate = DateTime.Now;
            AppContext.Instance.VanBanDis.Add(_VanBanDi);

            string logcontent = LoginForm.LoginMember.UserName + " đã nhập " + _VanBanDi.LoaiVanBan.Ten + " đi số " + _VanBanDi.SoDi + " ký hiệu " + _VanBanDi.SoKyHieu + " ngày " + String.Format("{0} {1} {2}", dtpNgayBanHanh.Value.Day, dtpNgayBanHanh.Value.Month, dtpNgayBanHanh.Value.Year) + " trích yếu " + _VanBanDi.TrichYeu;
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
            string mixCompleted = String.Format("{0}-{1}-{2}-{3}", txtSoDi.Text, mixSoKyHieu, mixNgayBanHanh, mixTrichYeu);
            txtTenFile.Text = mixCompleted;
        }

        public VanBanDiForm()
        {
            InitializeComponent();
        }

        private void VanBanDiForm_Load(object sender, EventArgs e)
        {
            FCbbLoaiVanBanLoading();
            FCbbCoQuanLoading();
            FCbbLoaiTrichYeuLoading();
            FDgvVanBanDiLoading(cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtTimKiem.Text, dtpNgayBanHanh.Value);
            txtSoDi.Text = FGetSodi(cbbLoaiVanBan.SelectedItem as LoaiVanBan, dtpNgayBanHanh.Value);
            txtSoKyHieu.Text = FGetSoKyHieu(txtSoDi.Text, cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtMix.Text);
        }

        private void txtSoKyHieu_TextChanged(object sender, EventArgs e)
        {
            FMixFileName();
        }

        private void cbbLoaiVanBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            FDgvVanBanDiLoading(cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtTimKiem.Text, dtpNgayBanHanh.Value);
            txtSoDi.Text = FGetSodi(cbbLoaiVanBan.SelectedItem as LoaiVanBan, dtpNgayBanHanh.Value);
            txtSoKyHieu.Text = FGetSoKyHieu(txtSoDi.Text, cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtMix.Text);
        }

        private void dtpNgayBanHanh_ValueChanged(object sender, EventArgs e)
        {
            FDgvVanBanDiLoading(cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtTimKiem.Text, dtpNgayBanHanh.Value);
            txtSoDi.Text = FGetSodi(cbbLoaiVanBan.SelectedItem as LoaiVanBan, dtpNgayBanHanh.Value);
            txtSoKyHieu.Text = FGetSoKyHieu(txtSoDi.Text, cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtMix.Text);
            FMixFileName();
        }

        private void txtTrichYeu_TextChanged(object sender, EventArgs e)
        {
            FMixFileName();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FDgvVanBanDiLoading(cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtTimKiem.Text, dtpNgayBanHanh.Value);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            VanBanDiReport frm = new VanBanDiReport((cbbLoaiVanBan.SelectedItem as LoaiVanBan).Id, dtpNgayBanHanh.Value.Year);
            frm.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            VanBanDiEdit frm = new VanBanDiEdit();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FAddVanBanDi(cbbCoQuan.SelectedItem as CoQuan, cbbLoaiVanBan.SelectedItem as LoaiVanBan, LoginForm.LoginMember, txtSoDi.Text, dtpNgayBanHanh.Value, txtSoKyHieu.Text, txtTrichYeu.Text, txtGhiChu.Text, txtNguoiKy.Text);
            FDgvVanBanDiLoading(cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtTimKiem.Text, dtpNgayBanHanh.Value);
            txtSoDi.Text = FGetSodi(cbbLoaiVanBan.SelectedItem as LoaiVanBan, dtpNgayBanHanh.Value);
            txtSoKyHieu.Text = txtSoKyHieu.Text = FGetSoKyHieu(txtSoDi.Text, cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtMix.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            FMixFileName();
            Clipboard.SetText(txtTenFile.Text);
        }

        private void txtSoDi_TextChanged(object sender, EventArgs e)
        {
            txtSoKyHieu.Text = FGetSoKyHieu(txtSoDi.Text, cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtMix.Text);
            FMixFileName();
        }

        private void txtMix_TextChanged(object sender, EventArgs e)
        {
            txtSoKyHieu.Text = FGetSoKyHieu(txtSoDi.Text, cbbLoaiVanBan.SelectedItem as LoaiVanBan, txtMix.Text);
            FMixFileName();
        }

        private void dgvVanBanDi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVanBanDi.Columns[e.ColumnIndex].Name == "Xoa")
            {
                AppContext.Instance.VanBanDis.Remove(vanBanDiFormBindingSource.Current as VanBanDi);
                AppContext.Instance.SaveChanges();
                vanBanDiFormBindingSource.RemoveAt(e.RowIndex);
            }

            if (dgvVanBanDi.Columns[e.ColumnIndex].Name == "OpenFolder")
            {
                VanBanDi vbdi = (vanBanDiFormBindingSource.Current as VanBanDi);
                //string path = InitSetting.DirectoryVbDi + "\\ VanBan " + (cbbLoaiVanBan.SelectedItem as LoaiVanBan).Id + "\\CoQuan " + (cbbCoQuan.SelectedItem as CoQuan).Id + "\\" + vbdi.Id + "\\";
                string path ="LoaiVanBan " + (cbbLoaiVanBan.SelectedItem as LoaiVanBan).Id + "\\CoQuan " + (cbbCoQuan.SelectedItem as CoQuan).Id + "\\" + vbdi.Id + "\\";
                vbdi.Path = path;
                AppContext.Instance.SaveChanges();
                if (!Directory.Exists(InitSetting.DirectoryVbDi + path))
                {
                    Directory.CreateDirectory(InitSetting.DirectoryVbDi + path);
                }
                Process.Start(InitSetting.DirectoryVbDi + path);
            }
        }

        private void cbxTrichYeu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTrichYeu.SelectedItem != null)
            {
                LoaiTrichYeu entitySelected = cbxTrichYeu.SelectedItem as LoaiTrichYeu;
                txtTrichYeu.Text = entitySelected.TrichYeu;
            }
        }
    }
}
