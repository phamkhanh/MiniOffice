using MOffice.Context;
using MOffice.eVanBanDenHuyen;
using MOffice.eVanBanDi;
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
using System.Xml;

namespace MOffice
{
    public partial class MainForm : Form
    {
        private void FCheckFolder()
        {
            if (!Directory.Exists(InitSetting.DirectoryVbDen))
            {
                Directory.CreateDirectory(InitSetting.DirectoryVbDen);
            }

            if (!Directory.Exists(InitSetting.DirectoryVbDi))
            {
                Directory.CreateDirectory(InitSetting.DirectoryVbDi);
            }
        }

        private string GetPathQuanLyVanBan()
        {
            string path = Application.StartupPath;
            XmlDocument doc = new XmlDocument();
            if (File.Exists(InitSetting.AppSettingsFile))
            {
                doc.Load(InitSetting.AppSettingsFile);
                XmlNode node = doc.SelectSingleNode("settings/QuanLyVanBan/Path");
                path = node.InnerText.Trim();
            }
            else
            {
                string root = String.Format("<settings><QuanLyVanBan><Path>{0}</Path></QuanLyVanBan></settings>", path);
                doc.LoadXml(root);
                doc.Save(InitSetting.AppSettingsFile);
            }
            return path;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitSetting.DirectoryVbDen = GetPathQuanLyVanBan() + InitSetting.DirectoryVbDen;
            InitSetting.DirectoryVbDi = GetPathQuanLyVanBan() + InitSetting.DirectoryVbDi;
            this.Text = InitSetting.AppName + " - " + LoginForm.LoginMember.UserName;
            //FCheckFolder();
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.Parse( LoginForm.LoginMember.UserType) != 1)
            {
                Msg.Stop(Messages.BanKhongDuocVaoKhuVucNay);
            }
            else
            {
                QuanLyNguoiDungForm frm = new QuanLyNguoiDungForm();
                Funcs.AddFormToMdiParent(frm, this);
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhauForm frm = new DoiMatKhauForm();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cơQuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucCoQuanForm frm = new DanhMucCoQuanForm();
            Funcs.AddFormToMdiParent(frm, this);
        }

        private void loạiVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucLoaiVanBanForm frm = new DanhMucLoaiVanBanForm();
            Funcs.AddFormToMdiParent(frm, this);
        }

        private void btnNhapVbDen_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNhapVbDi_Click(object sender, EventArgs e)
        {

        }

        private void sổVănBảnĐếnHuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoVanBanDenHuyenForm frm = new SoVanBanDenHuyenForm();
            Funcs.AddFormToMdiParent(frm, this);
        }

        private void sổVănBảnĐếnTỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoVanBanDenTinhForm frm = new SoVanBanDenTinhForm();
            Funcs.AddFormToMdiParent(frm, this);
        }

        private void sổVănBảnĐiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VanBanDiForm frm = new VanBanDiForm();
            Funcs.AddFormToMdiParent(frm, this);
        }

        private void tùyChỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(LoginForm.LoginMember.UserType) != 1)
            {
                Msg.Stop(Messages.BanKhongDuocVaoKhuVucNay);
            }
            else
            {
                TuyChinhForm frm = new TuyChinhForm();
                Funcs.AddFormToMdiParent(frm, this);
            }
        }

        private void nghiệpVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loạiTríchYếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucLoaiTrichYeuForm frm = new DanhMucLoaiTrichYeuForm();
            Funcs.AddFormToMdiParent(frm, this);
        }

        private void thơMơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TienIchThoMoiForm frm = new TienIchThoMoiForm();
            Funcs.AddFormToMdiParent(frm, this);
        }

        private void cánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucCanBoForm frm = new DanhMucCanBoForm();
            Funcs.AddFormToMdiParent(frm, this);
        }
    }
}