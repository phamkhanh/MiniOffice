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
    public partial class DanhMucCanBoForm : Form
    {
        private void FDgvCanBoLoading()
        {
            canBoBindingSource.DataSource = AppContext.Instance.CanBoes.ToList();
        }

        private void FAdd(string hoten, string donvi)
        {
            CanBo entity = new CanBo();
            entity.HoTen = hoten;
            entity.DonVi = donvi;
            AppContext.Instance.CanBoes.Add(entity);
            AppContext.Instance.SaveChanges();
        }

        private void FUpdate(string hoten, string donvi)
        {
            CanBo entity = canBoBindingSource.Current as CanBo;
            entity.HoTen = hoten;
            entity.DonVi = donvi;
            AppContext.Instance.SaveChanges();
        }

        private void FDelete()
        {
            CanBo entity = canBoBindingSource.Current as CanBo;
            AppContext.Instance.CanBoes.Remove(entity);
            AppContext.Instance.SaveChanges();
        }

        public DanhMucCanBoForm()
        {
            InitializeComponent();
        }

        private void DanhMucCanBoForm_Load(object sender, EventArgs e)
        {
            this.FDgvCanBoLoading();
        }

        private void dgvCanBo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCanBo.Columns[e.ColumnIndex].Name == "Delete")
            {
                this.FDelete();
                this.FDgvCanBoLoading();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.FAdd(txtHoTen.Text, txtDonVi.Text);
            FDgvCanBoLoading();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.FUpdate(txtHoTen.Text, txtDonVi.Text);
            FDgvCanBoLoading();
        }
    }
}
