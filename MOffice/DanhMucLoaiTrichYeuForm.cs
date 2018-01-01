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
    public partial class DanhMucLoaiTrichYeuForm : Form
    {
        private void FDgvLoaiTrichYeuLoading()
        {
            loaiTrichYeuBindingSource.DataSource = AppContext.Instance.LoaiTrichYeus.ToList();
        }

        private void FAdd(string trichyeu)
        {
            LoaiTrichYeu entity = new LoaiTrichYeu();
            entity.TrichYeu = trichyeu;
            AppContext.Instance.LoaiTrichYeus.Add(entity);
            AppContext.Instance.SaveChanges();
        }

        private void FUpdate(string trichyeu)
        {
            LoaiTrichYeu entity = loaiTrichYeuBindingSource.Current as LoaiTrichYeu;
            entity.TrichYeu = trichyeu;
            AppContext.Instance.SaveChanges();
        }

        private void FDelete()
        {
            LoaiTrichYeu entity = loaiTrichYeuBindingSource.Current as LoaiTrichYeu;
            AppContext.Instance.LoaiTrichYeus.Remove(entity);
            AppContext.Instance.SaveChanges();
        }

        public DanhMucLoaiTrichYeuForm()
        {
            InitializeComponent();
        }

        private void DanhMucLoaiTrichYeuForm_Load(object sender, EventArgs e)
        {
            FDgvLoaiTrichYeuLoading();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.FAdd(txtTrichYeu.Text);
            this.FDgvLoaiTrichYeuLoading();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.FUpdate(txtTrichYeu.Text);
            this.FDgvLoaiTrichYeuLoading();
        }

        private void dgvLoaiTrichYeu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLoaiTrichYeu.Columns[e.ColumnIndex].Name == "Delete")
            {
                this.FDelete();
                this.FDgvLoaiTrichYeuLoading();
            }
        }
    }
}
