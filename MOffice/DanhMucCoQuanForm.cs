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
    public partial class DanhMucCoQuanForm : Form
    {
        public DanhMucCoQuanForm()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTenCoQuan.Text) && (AppContext.Instance.CoQuans.FirstOrDefault(_entity => _entity.Ten == txtTenCoQuan.Text) == null))
            {
                CoQuan entity = new CoQuan();
                entity.Ten = txtTenCoQuan.Text;
                if (rdbXa.Checked == true)
                {
                    entity.Xa = 1;
                    entity.Huyen = 0;
                    entity.Tinh = 0;
                    entity.Khac = 0;
                }
                else if (rdbHuyen.Checked == true)
                {
                    entity.Xa = 0;
                    entity.Huyen = 1;
                    entity.Tinh = 0;
                    entity.Khac = 0;
                }
                else if (rdbTinh.Checked == true)
                {
                    entity.Xa = 0;
                    entity.Huyen = 0;
                    entity.Tinh = 1;
                    entity.Khac = 0;
                }
                else
                {
                    entity.Xa = 0;
                    entity.Huyen = 0;
                    entity.Tinh = 0;
                    entity.Khac = 1;
                }
                AppContext.Instance.CoQuans.Add(entity);
                AppContext.Instance.SaveChanges();
                DgvCoQuanLoading();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int CoQuanId = Int32.Parse(txtCoQuanId.Text);
            CoQuan entity = AppContext.Instance.CoQuans.FirstOrDefault(_entity => _entity.Id == CoQuanId);

            if (!String.IsNullOrWhiteSpace(txtTenCoQuan.Text) && AppContext.Instance.CoQuans.FirstOrDefault(_entity => _entity.Ten == txtTenCoQuan.Text && entity.Id != _entity.Id) == null)
            {
                entity.Ten = txtTenCoQuan.Text;
                if (rdbXa.Checked == true)
                {
                    entity.Xa = 1;
                    entity.Huyen = 0;
                    entity.Tinh = 0;
                    entity.Khac = 0;
                }
                else if (rdbHuyen.Checked == true)
                {
                    entity.Xa = 0;
                    entity.Huyen = 1;
                    entity.Tinh = 0;
                    entity.Khac = 0;
                }
                else if (rdbTinh.Checked == true)
                {
                    entity.Xa = 0;
                    entity.Huyen = 0;
                    entity.Tinh = 1;
                    entity.Khac = 0;
                }
                else
                {
                    entity.Xa = 0;
                    entity.Huyen = 0;
                    entity.Tinh = 0;
                    entity.Khac = 1;
                }
                AppContext.Instance.SaveChanges();
                DgvCoQuanLoading();
            }
        }

        private void DanhMucCoQuanForm_Load(object sender, EventArgs e)
        {
            DgvCoQuanLoading();
        }

        private void DgvCoQuanLoading()
        {
            coQuanBindingSource.DataSource = AppContext.Instance.CoQuans.ToList();
        }

        private void dgvCoQuan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCoQuan.Columns[e.ColumnIndex].Name == "Delete")
            {
                AppContext.Instance.CoQuans.Remove(coQuanBindingSource.Current as CoQuan);
                AppContext.Instance.SaveChanges();
                DgvCoQuanLoading();
            }
        }
    }
}
