using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL;

namespace DeviceManager
{
    public partial class SparePartChangedFrm : Form
    {
        SparePartChangedBLL spChangedBLL = new SparePartChangedBLL();
        EntityState objState;
        SparePartChangedModel sparePartChanged = new SparePartChangedModel();
        public SparePartChangedFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            using (SparePartChangedDetailFrm frm = new SparePartChangedDetailFrm(objState))
            {
                frm.ShowDialog();
                SparePartChangedFrm_Load(null, null);
            }
            objState = EntityState.Unchanged;
        }

        private void SparePartChangedFrm_Load(object sender, EventArgs e)
        {
            sparePartChangedModelBindingSource.DataSource = spChangedBLL.GetAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            using (SparePartChangedDetailFrm frm = new SparePartChangedDetailFrm(sparePartChangedModelBindingSource.Current as SparePartChangedModel, objState))
            {
                frm.ShowDialog();
                SparePartChangedFrm_Load(null, null);
            }
            objState = EntityState.Unchanged;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                spChangedBLL.Delete((sparePartChangedModelBindingSource.Current as SparePartChangedModel).ID);
                sparePartChangedModelBindingSource.RemoveCurrent();
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sparePartChangedModelBindingSource.DataSource = spChangedBLL.GetDataByFilter(cmbSearch.Text.Trim().ToLower());
        }
    }
}
