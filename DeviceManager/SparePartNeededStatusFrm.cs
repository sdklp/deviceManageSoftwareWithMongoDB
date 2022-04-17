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
    public partial class SparePartNeededStatusFrm : Form
    {
        EntityState objState;
        SparePartNeededStatusBLL sparePartNeededStatusBLL = new SparePartNeededStatusBLL();
        public SparePartNeededStatusFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pnlContainer.Enabled = true;
            sparePartNeededStatusModelBindingSource.AddNew();
            sparePartNeededStatusModelBindingSource.MoveLast();
            txtStatus.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pnlContainer.Enabled = true;
            txtStatus.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure want to delete this record?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                sparePartNeededStatusBLL.Delete((sparePartNeededStatusModelBindingSource.Current as SparePartNeededStatusModel).Id);
                sparePartNeededStatusModelBindingSource.RemoveCurrent();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SparePartNeededStatusModel sparePartNeededStatusModel = new SparePartNeededStatusModel();
            if (objState==EntityState.Changed)
            {
                sparePartNeededStatusModel.Id = txtID.Text;
            }
            sparePartNeededStatusModel.Name = txtStatus.Text.Trim();
            sparePartNeededStatusBLL.Save(sparePartNeededStatusModel,objState);
            pnlContainer.Enabled = false;
            objState = EntityState.Unchanged;
            SparePartNeededStatusFrm_Load(null, null);
        }

        private void SparePartNeededStatusFrm_Load(object sender, EventArgs e)
        {
            sparePartNeededStatusModelBindingSource.DataSource = sparePartNeededStatusBLL.GetAll();
        }
    }
}
