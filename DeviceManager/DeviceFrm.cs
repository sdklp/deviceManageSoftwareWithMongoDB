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
    public partial class DeviceFrm : Form
    {
        DeviceBLL deviceBLL = new DeviceBLL();
        EntityState objState;
        public DeviceFrm()
        {
            InitializeComponent();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState= EntityState.Added;
            using (DeviceDetailFrm dFrm = new DeviceDetailFrm(objState))
            {
                dFrm.ShowDialog();
                DeviceFrm_Load(null,null);
            }
            objState = EntityState.Unchanged;
        }

        private void DeviceFrm_Load(object sender, EventArgs e)
        {
            deviceModelBindingSource.DataSource = deviceBLL.GetAll();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objState= EntityState.Deleted;
            if (MessageBox.Show("Are you sure want to delete this record", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                deviceBLL.Delete((deviceModelBindingSource.Current as DeviceModel).Id, EntityState.Deleted);
                deviceModelBindingSource.RemoveCurrent();
            }
            objState = EntityState.Unchanged;
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            using (DeviceDetailFrm dFrm = new DeviceDetailFrm(deviceModelBindingSource.Current as DeviceModel,objState))
            {                
                dFrm.ShowDialog();
            }
            objState = EntityState.Unchanged;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            deviceModelBindingSource.DataSource = deviceBLL.GetDataByFilter(cmbSearch.Text.Trim().ToLower());
        }

        private void cmbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                btnSearch_Click(null, null);
            }
        }
    }
}
