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
    public partial class NhapVanBanDenForm2 : Form
    {
        public NhapVanBanDenForm2()
        {
            InitializeComponent();
        }

        private void btnDinhKem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFiles = new OpenFileDialog();
            openFiles.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFiles.FilterIndex = 2;
            openFiles.Title = "Chọn các file văn bản đến";
            openFiles.Multiselect = true;
            openFiles.ShowDialog();
            string[] fileNames = openFiles.FileNames;
            foreach (string item in fileNames)
            {
                bool _isExisted = false;
                string _fileName = Path.GetFileName(item);

                if (dgvDinhKemFiles.Rows.Count == 0)
                {
                    _isExisted = false;
                }
                else
                {
                    foreach (DataGridViewRow _row in dgvDinhKemFiles.Rows)
                    {
                        if (String.Compare(_row.Cells[1].Value.ToString(), _fileName) == 0)
                        {
                            _isExisted = true;
                            break;
                        }
                    }
                }

                if (!_isExisted)
                {
                    dgvDinhKemFiles.Rows.Add(new object[] { "", Path.GetFileName(item), item });
                }
            }
        }

        private void dgvDinhKemFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDinhKemFiles.Columns[e.ColumnIndex].Name == "Delete")
            {
                dgvDinhKemFiles.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void NhapVanBanDenForm_Load(object sender, EventArgs e)
        {
            FCbLoaiVanBanLoading();
            FCbCoQuanLoading();
            FSetSoden();
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

        private void FCbLoaiVanBanLoading()
        {
            loaiVanBanBindingSource.DataSource = AppContext.Instance.LoaiVanBans.ToList();
        }

        private void FCbCoQuanLoading()
        {
            coQuanBindingSource.DataSource = AppContext.Instance.CoQuans.ToList();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            FLuuVbDen(dtpNgayDen.Value, txtSoDen.Text, txtKyHieu.Text, dtpNgayBanHanh.Value, rxtTrichYeu.Text, txtNguoiNhan.Text, rxtGhiChu.Text, dgvDinhKemFiles.Rows);
        }

        private void FLuuVbDen(DateTime ngayden, string soden, string sokyhieu, DateTime ngaybanhanh, string trichyeu,string nguoinhan, string ghichu, DataGridViewRowCollection files)
        {
            var dbTransaction = AppContext.Instance.Database.BeginTransaction();
            try
            {
                int mixSoDen = int.Parse(soden);
                if (ngayden == null)
                {
                    Msg.Error("Nhập ngày văn bản đến.");
                }
                else if (String.IsNullOrWhiteSpace(sokyhieu))
                {
                    Msg.Error("Nhập số ký hiệu văn bản.");
                }
                else if (ngaybanhanh == null)
                {
                    Msg.Error("Nhập ngày ban hành văn bản.");
                }
                else if (String.IsNullOrWhiteSpace(trichyeu))
                {
                    Msg.Error("Nhập trích yếu của văn bản.");
                }
                else if (String.IsNullOrWhiteSpace(trichyeu))
                {
                    Msg.Error("Nhập người nhận văn bản.");
                }
                else if (AppContext.Instance.VanBanDens.FirstOrDefault(e => e.SoDen == mixSoDen) != null)
                {
                    Msg.Error("Số đến đã tồn tại. Nhập số khác.");
                }
                else if (files.Count == 0)
                {
                    Msg.Error("Phải đính kèm văn bản.");
                }
                else
                {
                    string _mixNgayden = String.Format("{0} {1} {2}", dtpNgayDen.Value.Day.ToString(), dtpNgayDen.Value.Month.ToString(), dtpNgayDen.Value.Year.ToString());
                    string _mixTrichyeu = Funcs.RejectMarks(trichyeu);
                    string _mixSoKyHieu = Funcs.RejectMarks(sokyhieu);
                    string _mixFileName = String.Format("{0}-{1}-{2}-{3}",mixSoDen,_mixNgayden, _mixSoKyHieu, _mixTrichyeu);
                    string _ext = "";
                    string _destFileName = "";

                    List<VanBanDenFile> vbdenListFile = new List<VanBanDenFile>();
                    VanBanDen _vbden = new VanBanDen();
                    _vbden.LoaiVanBanId = (loaiVanBanBindingSource.Current as LoaiVanBan).Id;
                    _vbden.CoQuanId = (coQuanBindingSource.Current as CoQuan).Id;
                    _vbden.NgayDen = ngayden;
                    _vbden.SoDen = mixSoDen;
                    _vbden.SoKyHieu = sokyhieu;
                    _vbden.NgayBanHanh = ngaybanhanh;
                    _vbden.TrichYeu = trichyeu;
                    _vbden.NguoiNhan = nguoinhan;
                    _vbden.GhiChu = ghichu;
                    _vbden.UserId = LoginForm.LoginMember.Id;
                    _vbden.UpdateDate = DateTime.Now;
                    AppContext.Instance.VanBanDens.Add(_vbden);

                    string _path = InitSetting.DirectoryVbDen + "\\" + mixSoDen + "\\";
                    foreach (DataGridViewRow row in files)
                    {
                        _ext = Path.GetExtension(row.Cells["FileName"].Value.ToString());
                        _destFileName = _path + _mixFileName + _ext;
                        if (!Directory.Exists(_path))
                        {
                            Directory.CreateDirectory(_path);
                        }

                        if (File.Exists(_destFileName))
                        {
                            _destFileName = _path + _mixFileName + "-" +row.Cells["FileName"].Value.ToString();
                        }
                        File.Copy(row.Cells["FullFileName"].Value.ToString(), _destFileName, true);
                        AppContext.Instance.VanBanDenFiles.Add(
                            new VanBanDenFile() {
                                VanBanDenId = _vbden.Id, 
                                UserId = LoginForm.LoginMember.Id, 
                                FileName = _destFileName,
                                UpdateDate = DateTime.Now
                            });
                    }

                    string _logContent = String.Format(
                        "{0} {1} {2} {3} {4} {5} {6} {7}",
                        "Tài khoản",
                        LoginForm.LoginMember.UserName,
                        "đã",
                        "nhập văn bản đến số",
                        mixSoDen,
                        "ký hiệu " + sokyhieu,
                        "ngày ban hành " + ngaybanhanh,
                        "trích yếu " + trichyeu
                        );
                    UserLog _entityUserLog = new UserLog() {
                        UserRef = LoginForm.LoginMember.Id,
                        LogDate = DateTime.Now,
                        LogContent = _logContent
                    };
                    AppContext.Instance.UserLogs.Add(_entityUserLog);
                    AppContext.Instance.SaveChanges();
                    dbTransaction.Commit();
                    btnNhap.Enabled = false;
                    btnDinhKem.Enabled = false;
                }
            }
            catch (FormatException)
            {
                Msg.Error("Nhap so den");
            }  
            catch (Exception)
            {
                Msg.Error("Lỗi hệ thống. Quá trình nhập văn bản không thành công.");
                dbTransaction.Rollback();
            }
        }

        private void NhapVanBanDenForm_Deactivate(object sender, EventArgs e)
        {
            
        }
    }
}
