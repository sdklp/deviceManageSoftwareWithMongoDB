using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace DeviceManager
{
    public partial class DevicePartFrm : Form
    {
        DevicePartBLL dpBLL = new DevicePartBLL();
        EntityState objState = EntityState.Unchanged;
        public DevicePartFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            using (DevicePartDetailFrm dpFrm = new DevicePartDetailFrm())
            {
                dpFrm.ShowDialog();
            }
            DevicePartFrm_Load(null, null); 
            objState = EntityState.Unchanged;
        }

        private void DevicePartFrm_Load(object sender, EventArgs e)
        {
            dgvDevicePart.AutoGenerateColumns = false;
            devicePartModelBindingSource.DataSource = dpBLL.GetAll();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show((devicePartModelBindingSource.Current as DevicePartModel).Id);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            using (DevicePartDetailFrm dpFrm = new DevicePartDetailFrm(devicePartModelBindingSource.Current as DevicePartModel,objState))
            {
                dpFrm.ShowDialog();
            }
            DevicePartFrm_Load(null, null);
            objState = EntityState.Unchanged;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                dpBLL.Delete((devicePartModelBindingSource.Current as DevicePartModel).Id,EntityState.Deleted);
                devicePartModelBindingSource.RemoveCurrent();
            }
        }

        private void brnSearh_Click(object sender, EventArgs e)
        {
            
            devicePartModelBindingSource.DataSource= dpBLL.GetDataByFilter(cmbSearch.Text.Trim().ToLower());
        }
    }
}
