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
    public partial class BulkMaintenanceFrm : Form
    {
        MaintenanceBLL mBLL = new MaintenanceBLL();
        DeviceBLL dBLL = new DeviceBLL();
        LocationBLL locationBLL = new LocationBLL();
        ApBLL apBLL = new ApBLL();
        public BulkMaintenanceFrm()
        {
            InitializeComponent();
        }
         //foreach (var item in clbItems.CheckedItems)
         //   {
         //       MessageBox.Show(item.ToString()) ;
         //   }
    

        private void btnAddDeviceList_Click(object sender, EventArgs e)
        {
            List<DeviceModel> deviceList = new List<DeviceModel>();
            
            foreach (var item in clbItems.CheckedItems)
            {
               deviceList.AddRange( dBLL.GetDataByFilter(cmbLocation.Text.Trim().ToLower(), item.ToString().ToLower())); 
            }
            deviceModelBindingSource.DataSource = deviceList;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (DeviceModel item in deviceModelBindingSource)
            {
                MaintenanceModel maintenance = new MaintenanceModel();
                maintenance.PTW = txtPTW.Text;
                maintenance.Detail = txtDetail.Text;
                maintenance.StartDate = dtpStart.Text;
                maintenance.EndDate = dtpEnd.Text;
                maintenance.AP = cmbAP.Text;
                maintenance.DeviceId = item.Id;
                maintenance.DeviceKKS = item.DKKS;
                maintenance.DeviceLocation = item.Location;
                maintenance.DeviceModel = item.DModel;
                maintenance.DeviceName = item.DName;
                maintenance.DeviceNo = item.DNo;
                mBLL.Save(maintenance, EntityState.Added) ;
                
            }
            MessageBox.Show("Successful");
            ContinueAddSwitch();
        }
        private void ContinueAddSwitch()
        {
            if (chkContinue.Checked)
            {
                switch (cmbKeepItem.Text)
                {
                    case "Keep PTW":                        
                        cmbLocation.Text = null;
                        foreach (int item in clbItems.CheckedIndices)
                        {
                            clbItems.SetItemChecked(item, false);
                        }
                        deviceModelBindingSource.DataSource = null;
                        break;
                    case "Keep None":
                        txtPTW.Text = null;
                        txtDetail.Text = null;
                        dtpStart.CustomFormat = " ";
                        dtpStart.Checked = false;
                        dtpEnd.CustomFormat = " ";
                        dtpEnd.Checked = false;
                        cmbAP.Text = null;
                        cmbLocation.Text = null;
                        foreach (int item in clbItems.CheckedIndices)
                        {
                            clbItems.SetItemChecked(item, false);
                        }
                        deviceModelBindingSource.DataSource = null;
                        break;
                    default:
                        
                        break;
                }                
            }
            else
            {
                this.Close();
            }
            
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpStart.CustomFormat = "yyyy-MM-dd";
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.CustomFormat = "yyyy-MM-dd";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deviceModelBindingSource.RemoveCurrent();
        }

        private void cmbLocation_DropDown(object sender, EventArgs e)
        {
            cmbLocation.DataSource = locationBLL.GetAll();
            cmbLocation.DisplayMember = "LName";
        }

        private void cmbAP_DropDown(object sender, EventArgs e)
        {
            cmbAP.DataSource = apBLL.GetAll();
            cmbAP.DisplayMember = "Name";
        }
    }
}
