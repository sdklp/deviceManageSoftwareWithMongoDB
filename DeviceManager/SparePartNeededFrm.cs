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
    public partial class SparePartNeededFrm : Form
    {
        
        public SparePartNeededFrm()
        {
            InitializeComponent();
        }
        SparePartNeededBLL spBLL = new SparePartNeededBLL();
        EntityState objState;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            using (SparePartNeededDetailFrm frm = new SparePartNeededDetailFrm(objState))
            {
                frm.ShowDialog();
            }
            objState = EntityState.Unchanged;
        }

        private void SparePartNeededFrm_Load(object sender, EventArgs e)
        {
            dgvSparePartNeeded.AllowUserToAddRows = false;
            sparePartNeededModelBindingSource.DataSource = spBLL.GetAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            using (SparePartNeededDetailFrm frm = new SparePartNeededDetailFrm(sparePartNeededModelBindingSource.Current as SparePartNeededModel, objState))
            {
                frm.ShowDialog();
            }
            objState = EntityState.Unchanged;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sparePartNeededModelBindingSource.DataSource = spBLL.GetDataByFilter(cmbSearch.Text.Trim().ToLower());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this record", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                spBLL.Delete((sparePartNeededModelBindingSource.Current as SparePartNeededModel).ID);
                sparePartNeededModelBindingSource.RemoveCurrent();
            }
        }
    }
}
