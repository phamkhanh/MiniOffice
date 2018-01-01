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
    public partial class QuanLyNguoiDungForm : Form
    {
        MOfficeEntities db;

        public QuanLyNguoiDungForm()
        {
            InitializeComponent();
        }

        private void QuanLyNguoiDungForm_Load(object sender, EventArgs e)
        {
            DgvUserLoading();
            DgvUserLogLoading();
        }

        private void DgvUserLoading()
        {
            db = new MOfficeEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;
            userBindingSource.DataSource = db.Users.Include("UserLogs").ToList();
        }

        private void DgvUserLogLoading()
        {
            User _user = userBindingSource.Current as User;
            if (_user != null)
            {
                if (_user.UserLogs != null)
                {
                    userLogBindingSource.DataSource = _user.UserLogs.OrderByDescending(_log => _log.LogDate).ToList();
                }
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DgvUserLogLoading();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            User _user = db.Users.FirstOrDefault(u => u.UserName == txtTenDangNhap.Text);
            if (_user == null)
            {
                _user = new User();
                _user.UserName = txtTenDangNhap.Text;
                _user.Password = txtMatKhau.Text;
                _user.UserType = txtUserType.Text;
                db.Users.Add(_user);
                db.SaveChanges();
                DgvUserLoading();
                DgvUserLogLoading();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            User _user = db.Users.FirstOrDefault(u => u.UserName == txtTenDangNhap.Text);
            if (_user != null)
            {
                _user.Password = txtMatKhau.Text;
                _user.UserType = txtUserType.Text;
                db.SaveChanges();
                DgvUserLoading();
                DgvUserLogLoading();
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUser.Columns[e.ColumnIndex].Name == "Delete")
            {
                db.Users.Remove(userBindingSource.Current as User);
                db.SaveChanges();
                DgvUserLoading();
                DgvUserLogLoading();
            }
        }
    }
}
