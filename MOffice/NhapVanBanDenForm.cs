using MOffice.Context;
using MOffice.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOffice
{
    public partial class NhapVanBanDenForm : Form
    {
        VanBanDen _vbden = new VanBanDen();

        private void FCbLoaiVanBanLoading()
        {
            loaiVanBanBindingSource.DataSource = AppContext.Instance.LoaiVanBans.ToList();
        }

        private void FCbbCoQuanLoading()
        {
            coQuanBindingSource.DataSource = AppContext.Instance.CoQuans.ToList();
        }

        private void FInsert(DateTime ngayden, string soden, string sokyhieu, DateTime ngaybanhanh, string trichyeu, string nguoinhan, string ghichu)
        {
            var tran = AppContext.Instance.Database.BeginTransaction();
            try
            {
                int mixSoDen = Int32.Parse(soden);
                string path = InitSetting.DirectoryVbDen + "\\" + (cbLoaiVanBan.SelectedItem as LoaiVanBan).Id + "\\" + mixSoDen + "\\";

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
                AppContext.Instance.VanBanDens.Add(_vbden);
                // insert record

                string mixNgayden = String.Format("{0} {1} {2}", dtpNgayDen.Value.Day.ToString(), dtpNgayDen.Value.Month.ToString(), dtpNgayDen.Value.Year.ToString());
                string mixTrichyeu = Funcs.RejectMarks(trichyeu);
                string mixSoKyHieu = Funcs.RejectMarks(sokyhieu);
                string mixFileName = String.Format("{0}-{1}-{2}-{3}", mixSoDen, mixNgayden, mixSoKyHieu, mixTrichyeu);
                string ext = "";
                string destFileName = "";
                

                List<VanBanDenFile> listVanBanDenFile = vanBanDenFileBindingSource.List.OfType<VanBanDenFile>().ToList();
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
                    AppContext.Instance.VanBanDenFiles.Add(itemListVanBanDenFile);
                }

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
            catch (Exception)
            {
                tran.Rollback();
                Msg.Error("Lỗi hệ thống. Nhập văn bản dến không thành công.");
            }
        }

        private void FSetSoden()
        {
            int _countVanBanDen = AppContext.Instance.VanBanDens.Count();
            int _soden = 0;
            if (_countVanBanDen == 0)
            {
                _soden = InitSetting.SoVanBanDen;
            }
            else
            {
                _soden = _countVanBanDen + 1;
            }
            txtSoDen.Text = _soden.ToString();
        }

        public NhapVanBanDenForm()
        {
            InitializeComponent();
        }

        private void NhapVanBanDenForm_Load(object sender, EventArgs e)
        {
            FCbLoaiVanBanLoading();
            FCbbCoQuanLoading();
            FSetSoden();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            FInsert(dtpNgayDen.Value, txtSoDen.Text, txtSoKyHieu.Text, dtpNgayBanHanh.Value, txtTrichYeu.Text, txtNguoiNhan.Text, txtGhiChu.Text);
        }

        private void btnDinhKem_Click(object sender, EventArgs e)
        {
            bool _allowAdd = true;
            foreach (string _fileNameItem in AppTool.OpenFileDialogShow())
            {
                if (vanBanDenFileBindingSource.Count == 0)
                {
                    _allowAdd = true;
                }
                else
                {
                    VanBanDenFile _vbDenFile = vanBanDenFileBindingSource.List.OfType<VanBanDenFile>().ToList().Find(entity => entity.FileName == _fileNameItem);
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
                    vanBanDenFileBindingSource.Add(new VanBanDenFile()
                    {
                        FileName = _fileNameItem,
                        ShortFileName = Path.GetFileName(_fileNameItem),
                        User = LoginForm.LoginMember,
                        VanBanDen = _vbden,
                        UpdateDate = DateTime.Now
                    });
                }
            }
        }

        private void dgvDinhKemFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDinhKemFiles.Columns[e.ColumnIndex].Name == "Delete")
            {
                vanBanDenFileBindingSource.RemoveAt(e.RowIndex);
            }
        }
    }
}
