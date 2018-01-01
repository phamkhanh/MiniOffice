using MOffice.Context;
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
    public partial class DanhMucLoaiVanBanForm : Form
    {
        public DanhMucLoaiVanBanForm()
        {
            InitializeComponent();
        }

        private void DanhMucLoaiVanBanForm_Load(object sender, EventArgs e)
        {
            DgvLoaiVbLoading();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Insert(txtTenLoai.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Update(txtLoaiVbId.Text, txtTenLoai.Text);
        }

        private void dgvLoaiVb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLoaiVb.Columns[e.ColumnIndex].Name == "Delete")
            {
                AppContext.Instance.LoaiVanBans.Remove(loaiVanBanBindingSource.Current as LoaiVanBan);
                AppContext.Instance.SaveChanges();
                DgvLoaiVbLoading();
            }
        }

        private void DgvLoaiVbLoading()
        {
            loaiVanBanBindingSource.DataSource = AppContext.Instance.LoaiVanBans.ToList();
        }

        private void Insert(string tenLoaiVb)
        {
            if (!String.IsNullOrWhiteSpace(tenLoaiVb) &&
                AppContext.Instance.LoaiVanBans.FirstOrDefault(_entity => _entity.Ten == tenLoaiVb) == null)
            {
                LoaiVanBan loaiVb = new LoaiVanBan();
                loaiVb.Ten = tenLoaiVb;
                AppContext.Instance.LoaiVanBans.Add(loaiVb);
                AppContext.Instance.SaveChanges();
                DgvLoaiVbLoading();
            }
        }

        private void Update(string id, string tenLoaiVb)
        {
            int loaiVbId = Int32.Parse(id);
            if (!String.IsNullOrWhiteSpace(tenLoaiVb))
            {
                LoaiVanBan loaivb = AppContext.Instance.LoaiVanBans.FirstOrDefault(_entity => _entity.Id == loaiVbId);
                if (loaivb != null)
                {
                    loaivb.Ten = tenLoaiVb;
                    AppContext.Instance.SaveChanges();
                    DgvLoaiVbLoading();
                }
            }
        }
    }
}
