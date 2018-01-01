using MOffice.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOffice
{
    public partial class DoiMatKhauForm : Form
    {
        public DoiMatKhauForm()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (String.Compare(LoginForm.LoginMember.Password, txtMatKhauCu.Text, false) == 0)
            {
                if (String.Compare(txtMatKhauMoi.Text, txtMatKhauMoiLan2.Text, false) == 0)
                {
                    if (String.IsNullOrEmpty(txtMatKhauMoi.Text))
                    {
                        Msg.Info(Messages.MatKhauVuiLongNhapMatKhauMoi);
                        txtMatKhauMoi.Focus();
                    }
                    else
                    {
                        using (MOfficeEntities db = new MOfficeEntities())
                        {
                            User _user = db.Users.First(u => u.UserName == LoginForm.LoginMember.UserName);
                            _user.Password = txtMatKhauMoi.Text;
                            db.SaveChanges();
                        }
                        Msg.Info(Messages.DoiMatKhauThanhCong);
                        Application.Restart();
                    }
                }
                else
                {
                    Msg.Error(Messages.MatKhauMoiKhongKhop);
                    txtMatKhauMoi.Focus();
                    txtMatKhauMoi.SelectAll();
                }
            }
            else
            {
                Msg.Error(Messages.MatKhauCuKhongDung);
                txtMatKhauCu.Focus();
                txtMatKhauCu.SelectAll();
            }
        }

        private void DoiMatKhauForm_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = LoginForm.LoginMember.UserName;
        }
    }
}
