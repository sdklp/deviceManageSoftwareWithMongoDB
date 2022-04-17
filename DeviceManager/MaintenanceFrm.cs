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
    public partial class MaintenanceFrm : Form
    {
        EntityState objState;
        MaintenanceBLL mBLL = new MaintenanceBLL();
        public MaintenanceFrm()
        {
            InitializeComponent();
        }

        private void MaintenanceFrm_Load(object sender, EventArgs e)
        {
            maintenanceModelBindingSource.DataSource = mBLL.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            using (MaintenanceDetailFrm frm = new MaintenanceDetailFrm(objState))
            {
                frm.ShowDialog();
                MaintenanceFrm_Load(null,null);
            }
            objState = EntityState.Unchanged;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            using (MaintenanceDetailFrm frm = new MaintenanceDetailFrm(maintenanceModelBindingSource.Current as MaintenanceModel, objState))
            {
                frm.ShowDialog();
                MaintenanceFrm_Load(null, null);
            }
            objState = EntityState.Unchanged;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            maintenanceModelBindingSource.DataSource = mBLL.GetDataByFilter(cmbSearch.Text.Trim().ToLower()) ;
        }

        private void cmbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                mBLL.Delete((maintenanceModelBindingSource.Current as MaintenanceModel).Id);
                maintenanceModelBindingSource.RemoveCurrent();
            }
        }
    }
}
