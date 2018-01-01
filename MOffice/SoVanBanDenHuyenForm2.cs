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
    public partial class SoVanBanDenHuyenForm2 : Form
    {
        VanBanDen _vbden = new VanBanDen();

        private void FCbLoaiVanBanLoading()
        {
            loaiVanBanBindingSource.DataSource = AppContext.Instance.LoaiVanBans.ToList();
        }

        private void FCbbCoQuanLoading()
        {
            List<CoQuan> coQuanList = (from coquans in AppContext.Instance.CoQuans
                                       where (coquans.Huyen == 1)
                                       select coquans).ToList();
            coQuanBindingSource.DataSource = coQuanList;
        }

        private void FDgvDinhKemFilesLoading()
        {
            vanBanDenFileBindingSource.DataSource = _vbden.VanBanDenFiles.ToList();
        }

        private void FDgvVanBanDenLoading()
        {
            CoQuan cq = cbbCoQuanBanHanh.SelectedItem as CoQuan;
            int year = dtpNgayDen.Value.Year;

            if (cq != null)
            {
                vanBanDenBindingSource.DataSource = (from _eVanBanDen in AppContext.Instance.VanBanDens.Include("CoQuans").Include("LoaiVanBans").Where(e => e.CoQuanId == cq.Id && e.NgayDen.Value.Year == year)
                                                     orderby _eVanBanDen.SoDen descending
                                                     select _eVanBanDen).ToList();
            }
        }

        private void FSetSoden()
        {
            CoQuan cq = cbbCoQuanBanHanh.SelectedItem as CoQuan;
            int year = dtpNgayDen.Value.Year;
            if (cq != null)
            {
                VanBanDen eVanBanDen = (from _eVanBanDen in AppContext.Instance.VanBanDens.Where(e => e.CoQuanId == cq.Id && e.NgayDen.Value.Year == year)
                                        orderby _eVanBanDen.SoDen descending
                                        select _eVanBanDen).FirstOrDefault();
                if (eVanBanDen != null)
                {
                    txtSoDen.Text = (eVanBanDen.SoDen + 1).ToString();
                }
                else
                {
                    txtSoDen.Text = "1";
                }
            }
        }

        private void FInsert(DateTime ngayden, string soden, string sokyhieu, DateTime ngaybanhanh, string trichyeu, string nguoinhan, string ghichu)
        {
            var tran = AppContext.Instance.Database.BeginTransaction();
            try
            {
                int mixSoDen = Int32.Parse(soden);
                string path = InitSetting.DirectoryVbDen + "\\Huyen " + (cbbCoQuanBanHanh.SelectedItem as CoQuan).Id + "\\" + mixSoDen + "\\";

                // insert record
                _vbden.LoaiVanBan = cbLoaiVanBan.SelectedItem as LoaiVanBan;
                _vbden.CoQuan = cbbCoQuanBanHanh.SelectedItem as CoQuan;
                _vbden.User = LoginForm.LoginMember;
                _vbden.NgayDen = ngayden;
                _vbden.SoDen = mixSoDen;
                _vbden.SoKyHieu = sokyhieu;
                _vbden.NgayBanHanh = ngaybanhanh;
                _vbden.TrichYeu = trichyeu;
                _vbden.NguoiNhan = nguoinhan;
                _vbden.GhiChu = ghichu;
                _vbden.UpdateDate = DateTime.Now;
                _vbden.Path = path;
                // insert record

                string mixNgayden = String.Format("{0} {1} {2}", dtpNgayDen.Value.Day.ToString(), dtpNgayDen.Value.Month.ToString(), dtpNgayDen.Value.Year.ToString());
                string mixTrichyeu = Funcs.RejectMarks(trichyeu);
                string mixSoKyHieu = Funcs.RejectMarks(sokyhieu);
                string mixFileName = String.Format("{0}-{1}-{2}-{3}", mixSoDen, mixNgayden, mixSoKyHieu, mixTrichyeu);
                string ext = "";
                string destFileName = "";


                List<VanBanDenFile> listVanBanDenFile = _vbden.VanBanDenFiles.ToList();
                foreach (VanBanDenFile itemListVanBanDenFile in listVanBanDenFile)
                {
                    ext = Path.GetExtension(itemListVanBanDenFile.FileName);
                    destFileName = path + mixFileName + ext;
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    if (File.Exists(destFileName))
                    {
                        destFileName = path + mixFileName + "-" + itemListVanBanDenFile.ShortFileName;
                    }

                    File.Copy(itemListVanBanDenFile.FileName, destFileName, true);
                    itemListVanBanDenFile.FileName = destFileName;
                    itemListVanBanDenFile.ShortFileName = mixFileName + ext;
                }

                AppContext.Instance.VanBanDens.Add(_vbden);

                // write log
                string log = LoginForm.LoginMember.UserName + " đã nhập " + _vbden.LoaiVanBan.Ten + " đến số " + _vbden.SoDen + " ký hiệu " + _vbden.SoKyHieu + " ngày " + mixNgayden + " trích yếu " + _vbden.TrichYeu;
                AppContext.Instance.UserLogs.Add(new UserLog() { LogContent = log, LogDate = DateTime.Now, User = _vbden.User });
                // write log


                // commit savechange
                AppContext.Instance.SaveChanges();
                tran.Commit();
                Msg.Info("Lưu thành công.");
                this.Enabled = false;
                // commit savechange
            }
            catch (PathTooLongException)
            {
                tran.Rollback();
                Msg.Error("Trích yếu quá dài.");
            }
            catch (Exception)
            {
                tran.Rollback();
                Msg.Error("Lỗi hệ thống. Nhập văn bản đến không thành công.");
            }
        }

        private void FDelete(VanBanDen vanbanden)
        {
            AppContext.Instance.VanBanDenFiles.RemoveRange(vanbanden.VanBanDenFiles);
            AppContext.Instance.VanBanDens.Remove(vanbanden);
            AppContext.Instance.SaveChanges();
        }

        public SoVanBanDenHuyenForm2()
        {
            InitializeComponent();
            FCbLoaiVanBanLoading();
            FCbbCoQuanLoading();
            FDgvDinhKemFilesLoading();
            FSetSoden();
            FDgvVanBanDenLoading();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            FInsert(dtpNgayDen.Value, txtSoDen.Text, txtSoKyHieu.Text, dtpNgayBanHanh.Value, txtTrichYeu.Text, txtNguoiNhan.Text, txtGhiChu.Text);
            FSetSoden();
            FDgvVanBanDenLoading();
        }

        private void btnDinhKem_Click(object sender, EventArgs e)
        {
            bool _allowAdd = true;
            foreach (string _fileNameItem in AppTool.OpenFileDialogShow())
            {
                if (_vbden.VanBanDenFiles.Count == 0)
                {
                    _allowAdd = true;
                }
                else
                {
                    VanBanDenFile _vbDenFile = _vbden.VanBanDenFiles.ToList().Find(entity => entity.FileName == _fileNameItem);
                    if (_vbDenFile == null)
                    {
                        _allowAdd = true;
                    }
                    else
                    {
                        _allowAdd = false;
                    }
                }

                if (_allowAdd)
                {
                    _vbden.VanBanDenFiles.Add(new VanBanDenFile()
                    {
                        FileName = _fileNameItem,
                        ShortFileName = Path.GetFileName(_fileNameItem),
                        User = LoginForm.LoginMember,
                        VanBanDen = _vbden,
                        UpdateDate = DateTime.Now
                    });
                }
            }
            FDgvDinhKemFilesLoading();
        }

        private void dgvDinhKemFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDinhKemFiles.Columns[e.ColumnIndex].Name == "Delete")
            {
                _vbden.VanBanDenFiles.Remove(vanBanDenFileBindingSource.Current as VanBanDenFile);
                FDgvDinhKemFilesLoading();
            }
        }

        private void dtpNgayDen_ValueChanged(object sender, EventArgs e)
        {
            FSetSoden();
            FDgvVanBanDenLoading();
        }

        private void cbbCoQuanBanHanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            FSetSoden();
            FDgvVanBanDenLoading();
        }

        private void dgvVanBanDen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVanBanDen.Columns[e.ColumnIndex].Name == "DeleteVanBanDen")
            {
                FDelete(vanBanDenBindingSource.Current as VanBanDen);
                FDgvVanBanDenLoading();
            }

            if (dgvVanBanDen.Columns[e.ColumnIndex].Name == "FolderVanBanDen")
            {
                Process.Start(Path.GetDirectoryName((vanBanDenBindingSource.Current as VanBanDen).Path));
            }
        }

        private async void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                await AppContext.Instance.SaveChangesAsync();
            }
            catch (Exception)
            {
                Msg.Error("Lỗi hệ thống. Quá trình cập nhật thất bại.");
            }
        }

        private void SoVanBanDenHuyenForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
