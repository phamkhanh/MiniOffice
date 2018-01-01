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
using System.Xml;

namespace MOffice
{
    public partial class LoginForm : Form
    {
        public static User LoginMember = null;

        private void SampleData()
        {
            AppContext.Instance.CoQuans.Add(new CoQuan() { Ten = "UBND thị trấn Gò Dầu", Xa = 1, Huyen = 0, Tinh = 0, Khac = 0 });
            AppContext.Instance.CoQuans.Add(new CoQuan() { Ten = "UBND huyện Gò Dầu", Xa = 0, Huyen = 1, Tinh = 0, Khac = 0 });
            AppContext.Instance.CoQuans.Add(new CoQuan() { Ten = "UBND tỉnh Tây Ninh", Xa = 0, Huyen = 0, Tinh = 1, Khac = 0 });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Công văn" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Kế hoạch" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Báo cáo" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Quyết định" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Tờ trình" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Biên bản" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Thông báo" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Thư mời" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Chương trình" });
            AppContext.Instance.Users.Add(new User() { UserName = "khanhpd", Password = "123", UserType = "1" });
            AppContext.Instance.Users.Add(new User() { UserName = "khuongnth", Password = "1", UserType = "2" });
            AppContext.Instance.Users.Add(new User() { UserName = "huongla", Password = "1", UserType = "2" });
            AppContext.Instance.SaveChanges();
        }

        private void SampleData2()
        {
            AppContext.Instance.Users.Add(new User() { UserName = "khanhpd", Password = "123", UserType = "1" });
            AppContext.Instance.Users.Add(new User() { UserName = "khuongnth", Password = "1", UserType = "2" });
            AppContext.Instance.Users.Add(new User() { UserName = "huongla", Password = "1", UserType = "2" });
            AppContext.Instance.CoQuans.Add(new CoQuan() { Ten = "UBND thị trấn Gò Dầu", Xa = 1, Huyen = 0, Tinh = 0, Khac = 0 });
            AppContext.Instance.CoQuans.Add(new CoQuan() { Ten = "UBND huyện Gò Dầu", Xa = 0, Huyen = 1, Tinh = 0, Khac = 0 });
            AppContext.Instance.CoQuans.Add(new CoQuan() { Ten = "UBND tỉnh Tây Ninh", Xa = 0, Huyen = 0, Tinh = 1, Khac = 0 });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Công văn", KyHieu = "/UBND"});
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Kế hoạch", KyHieu = "/KH-UBND" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Báo cáo", KyHieu = "/BC-UBND" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Quyết định", KyHieu = "/QĐ-UBND" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Tờ Trình", KyHieu = "/TTr-UBND" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Biên Bản", KyHieu = "/BB-UBND" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Thông Báo", KyHieu = "/TB-UBND" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Thư Mời", KyHieu = "/TM-UBND" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Chương Trình", KyHieu = "/CTr-UBND" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Đề Nghị", KyHieu = "/BĐN-UBND" });
            AppContext.Instance.LoaiVanBans.Add(new LoaiVanBan() { Ten = "Chỉ Thị", KyHieu = "/CT-UBND" });
            AppContext.Instance.SaveChanges();
        }

        public LoginForm()
        {
            InitializeComponent();
            //SampleData2();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (chkNhoTaiKhoan.CheckState == CheckState.Checked)
            {
                string root = "<accounts></accounts>";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(root);
                doc.Save("accounts.xml");

                XmlElement newElem = doc.CreateElement("UserName");
                newElem.InnerText = Funcs.Encrypt(txtDangNhap.Text);
                doc.DocumentElement.AppendChild(newElem);

                newElem = doc.CreateElement("Password");
                newElem.InnerText = Funcs.Encrypt(txtMatKhau.Text);
                doc.DocumentElement.AppendChild(newElem);

                doc.PreserveWhitespace = true;
                doc.Save("accounts.xml");
            }
            else
            {
                File.Delete("accounts.xml");
            }

            LoginMember = (from _member in AppContext.Instance.Users
                             where (_member.UserName == txtDangNhap.Text && _member.Password == txtMatKhau.Text)
                             select _member).FirstOrDefault();
            if (LoginMember != null)
            {
                MainForm frm = new MainForm();
                this.Hide();
                frm.ShowDialog();
                if (!this.IsDisposed)
                {
                    this.Show();
                }
            }
            else
            {
                Msg.Error(Messages.DangNhapThatBai);
            }
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            CauHinhForm frm = new CauHinhForm();
            frm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("accounts.xml"))
            {
                chkNhoTaiKhoan.CheckState = CheckState.Checked;
                XmlDocument doc = new XmlDocument();
                doc.Load("accounts.xml");
                XmlNode node = doc.SelectSingleNode("/accounts/UserName");
                txtDangNhap.Text = Funcs.Decrypt(node.InnerText);

                node = doc.SelectSingleNode("/accounts/Password");
                txtMatKhau.Text = Funcs.Decrypt(node.InnerText);
            }
        }
    }
}