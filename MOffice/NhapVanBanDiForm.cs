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
    public partial class NhapVanBanDiForm : Form
    {
        VanBanDi vbDi = new VanBanDi();

        private void FCbLoaiVanBanLoading()
        {
            loaiVanBanBindingSource.DataSource = AppContext.Instance.LoaiVanBans.ToList();
        }

        private void FCbbCoQuanLoading()
        {
            coQuanBindingSource.DataSource = AppContext.Instance.CoQuans.ToList();
        }

        private void FSetSoDi()
        {
            vbDi.LoaiVanBan = cbLoaiVanBan.SelectedItem as LoaiVanBan;
            if (vbDi.LoaiVanBan != null)
            {
                VanBanDi _vbdi = AppContext.Instance.VanBanDis.OrderByDescending(entity => entity.SoDi).FirstOrDefault(entity => entity.LoaiVanBan.Id == vbDi.LoaiVanBan.Id);
                if (_vbdi == null)
                {
                    txtSoDi.Text = "1";
                }
                else
                {
                    txtSoDi.Text = (_vbdi.SoDi + 1).ToString();
                }
            }
        }

        private void FSetSoKyHieu()
        {
            if (loaiVanBanBindingSource.Current != null)
            {
                txtSoKyHieu.Text = txtSoDi.Text + "/" + (cbLoaiVanBan.SelectedItem as LoaiVanBan).Ten;
            }
        }

        private void FInsert(LoaiVanBan _loaivb, string _sodi, string _sokyhieu, DateTime _ngaybanhanh, CoQuan _coquanbanhanh, string _trichyeu, string _nguoiky, string _ghichu)
        {
            var tran = AppContext.Instance.Database.BeginTransaction();
            try
            {
                string path = InitSetting.DirectoryVbDi + "\\" + _loaivb.Id + "\\" + _sodi + "\\";

                vbDi.User = LoginForm.LoginMember;
                vbDi.LoaiVanBanId = _loaivb.Id;
                vbDi.SoDi = int.Parse(_sodi);
                vbDi.SoKyHieu = _sokyhieu;
                vbDi.NgayBanHanh = _ngaybanhanh;
                vbDi.CoQuan = _coquanbanhanh;
                vbDi.TrichYeu = _trichyeu;
                vbDi.NguoiKy = _nguoiky;
                vbDi.GhiChu = _ghichu;
                vbDi.UpdateDate = DateTime.Now;
                vbDi.Path = path;
                AppContext.Instance.VanBanDis.Add(vbDi);

                // Copy and Mix File Name
                string mixNgayBanHanh = String.Format("{0} {1} {2}", _ngaybanhanh.Day.ToString(), _ngaybanhanh.Month.ToString(), _ngaybanhanh.Year.ToString());
                string mixTrichyeu = Funcs.RejectMarks(_trichyeu);
                string mixSoKyHieu = Funcs.RejectMarks(_sokyhieu);
                string mixFileName = String.Format("{0}-{1}-{2}-{3}", _sodi, mixSoKyHieu, mixNgayBanHanh, mixTrichyeu);
                string ext = "";
                string destFileName = "";

                List<VanBanDiFile> listVanBanDiFile = vanBanDiFileBindingSource.List.OfType<VanBanDiFile>().ToList();
                foreach (VanBanDiFile itemListVanBanDiFile in listVanBanDiFile)
                {
                    ext = Path.GetExtension(itemListVanBanDiFile.FileName);
                    destFileName = path + mixFileName + ext;
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    if (File.Exists(destFileName))
                    {
                        destFileName = path + mixFileName + "-" + itemListVanBanDiFile.ShortFileName;
                    }
                    File.Copy(itemListVanBanDiFile.FileName, destFileName, true);
                    AppContext.Instance.VanBanDiFiles.Add(itemListVanBanDiFile);
                }

                string log = LoginForm.LoginMember.UserName + " đã nhập " + vbDi.LoaiVanBan.Ten + " đi số " + vbDi.SoDi + " ký hiệu " + vbDi.SoKyHieu + " ngày " + mixNgayBanHanh + " trích yếu " + vbDi.TrichYeu;
                AppContext.Instance.UserLogs.Add(new UserLog() { LogContent = log, LogDate = DateTime.Now, User = vbDi.User });

                AppContext.Instance.SaveChanges();
                tran.Commit();
                Msg.Info("Lưu thành công.");
                this.Enabled = false;
            }
            catch (Exception)
            {
                Msg.Error("Lỗi hệ thống. Nhập văn bản đi không thành công.");
                tran.Rollback();
            }
        }

        private void FAttachFile()
        {

        }

        public NhapVanBanDiForm()
        {
            InitializeComponent();
        }

        private void NhapVanBanDiForm_Load(object sender, EventArgs e)
        {
            FCbLoaiVanBanLoading();
            FCbbCoQuanLoading();
            FSetSoDi();
            FSetSoKyHieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            FInsert(cbLoaiVanBan.SelectedItem as LoaiVanBan, txtSoDi.Text, txtSoKyHieu.Text, dtpNgayBanHanh.Value, cbbCoQuanBanHanh.SelectedItem as CoQuan, txtTrichYeu.Text, txtNguoiKy.Text, txtGhiChu.Text);
        }

        private void btnDinhKem_Click(object sender, EventArgs e)
        {
            bool _allowAdd = true;
            foreach (string _fileNameItem in AppTool.OpenFileDialogShow())
            {
                if (vanBanDiFileBindingSource.Count == 0)
                {
                    _allowAdd = true;
                }
                else
                {
                    VanBanDiFile _vbDiFile = vanBanDiFileBindingSource.List.OfType<VanBanDiFile>().ToList().Find(entity => entity.FileName == _fileNameItem);
                    if (_vbDiFile == null)
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
                    vanBanDiFileBindingSource.Add(new VanBanDiFile()
                    {
                        FileName = _fileNameItem,
                        ShortFileName = Path.GetFileName(_fileNameItem),
                        User = LoginForm.LoginMember,
                        VanBanDi = vbDi,
                        UpdateDate = DateTime.Now
                    });
                }
            }
        }

        private void cbLoaiVanBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            FSetSoDi();
            FSetSoKyHieu();
        }

        private void dgvDinhKemFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDinhKemFiles.Columns[e.ColumnIndex].Name == "Delete")
            {
                vanBanDiFileBindingSource.RemoveAt(e.RowIndex);
            }
        }
    }
}
