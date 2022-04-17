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
    public partial class DeviceStatusFrm : Form
    {
        DeviceStatusBLL deviceStatusBLL = new DeviceStatusBLL();
        EntityState objState = EntityState.Unchanged;
        public DeviceStatusFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
           
            deviceStatusModelBindingSource.AddNew();
            deviceStatusModelBindingSource.MoveLast();
            pnlContainer.Enabled = true;
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
                deviceStatusBLL.Delete((deviceStatusModelBindingSource.Current as DeviceStatusModel).Id);
                deviceStatusModelBindingSource.RemoveCurrent();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DeviceStatusModel deviceStatusModel = new DeviceStatusModel();
            if (objState==EntityState.Changed)
            {
                deviceStatusModel.Id = txtID.Text;
            }
            deviceStatusModel.DeviceStatus = txtStatus.Text;
            deviceStatusBLL.Save(deviceStatusModel,objState);
            objState = EntityState.Unchanged;
            pnlContainer.Enabled = false;
            DeviceStatusFrm_Load(null, null);
        }

        private void DeviceStatusFrm_Load(object sender, EventArgs e)
        {
            deviceStatusModelBindingSource.DataSource = deviceStatusBLL.GetAll();
        }
    }
}
