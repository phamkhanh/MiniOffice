using MOffice.Context;
using MOffice.eTemplate;
using MOffice.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOffice
{
    public partial class TienIchThoMoiForm : Form
    {
        private void FClbThanhPhanLoading()
        {
            this.canboBindingSource.DataSource = AppContext.Instance.CanBoes.ToList();
            ((ListBox)this.clbThanhPhan).DataSource = this.canboBindingSource;
            this.clbThanhPhan.DisplayMember = "HoTen";
            this.clbThanhPhan.ValueMember = "Id";
        }

        public TienIchThoMoiForm()
        {
            InitializeComponent();
        }

        private void TienIchThoMoiForm_Load(object sender, EventArgs e)
        {
            this.FClbThanhPhanLoading();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            List<CanBo> listCanBo = new List<CanBo>();
            string path = Application.StartupPath + "\\THUMOI\\" + "TM-"+Funcs.RejectUnicode( txtNoiDung.Text ) + DateTime.Now.ToString("ddMMyyyy") + ".html";

            ThuMoiTmp tickTmp = new ThuMoiTmp();

            // Theo văn hóa Việt Nam.
            CultureInfo viVn = new CultureInfo("vi-VN");
            string sangChieu = "( Sáng";
            switch (dtpThoiGian.Value.ToString("tt", viVn))
            {
                case "CH":
                    sangChieu = "( Chiều";
                    break;
                default:
                    break;
            }
            string sangChieuThu = sangChieu + " " + dtpThoiGian.Value.ToString("dddd", viVn) + " )";
            ThuMoiTemplate tm = new ThuMoiTemplate() { ThoiGian = dtpThoiGian.Value.ToString("HH 'giờ' mm 'ngày' dd 'tháng' MM 'năm' yyyy ") + sangChieuThu, DiaDiem = txtDiaDiem.Text, NoiDung = txtNoiDung.Text };

            if (ckbXungDanh.CheckState == CheckState.Checked)
            {
                foreach (CanBo item in this.clbThanhPhan.CheckedItems)
                {
                    item.HoTen = txtXungDanh.Text + " " + item.HoTen;
                    listCanBo.Add(item);
                }
            }
            else
            {
                listCanBo = this.clbThanhPhan.CheckedItems.OfType<CanBo>().ToList();
            }

            //tm.ThanhPhanCanBo = this.clbThanhPhan.CheckedItems.OfType<CanBo>().ToList();
            tm.ThanhPhanCanBo = listCanBo;
            tickTmp.Session = new Dictionary<string, object>();
            tickTmp.Session.Add("ThuMoiTemplate", tm);
            tickTmp.Initialize();
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            using (FileStream fs = File.Create(path))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(tickTmp.TransformText());
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
            Process.Start(path);
        }

        private void clbThanhPhan_Click(object sender, EventArgs e)
        {
            if (clbThanhPhan.SelectedItems.Count != clbThanhPhan.Items.Count)
            {
                ckbTatCaThanhPhan.CheckState = CheckState.Unchecked;
            }
        }

        private void ckbTatCaThanhPhan_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbTatCaThanhPhan.CheckState == CheckState.Checked)
            {
                for (int i = 0; i < clbThanhPhan.Items.Count; i++)
                {
                    clbThanhPhan.SetItemChecked(i, true);
                }
            }
        }
    }

    public class ThuMoiTemplate
    {
        public ThuMoiTemplate()
        {
            NgayMoi = DateTime.Now;
        }

        public string ThoiGian;
        public string DiaDiem;
        public string NoiDung;
        public List<CanBo> ThanhPhanCanBo;
        public DateTime NgayMoi;
    }
}
