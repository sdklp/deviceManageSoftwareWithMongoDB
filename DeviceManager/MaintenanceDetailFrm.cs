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
    public partial class MaintenanceDetailFrm : Form
    {
        EntityState objState;
        DeviceModel device = new DeviceModel();
        MaintenanceBLL mBLL = new MaintenanceBLL();

        public MaintenanceDetailFrm()
        {
            InitializeComponent();
        }
        public MaintenanceDetailFrm(EntityState entityState)
        {
            InitializeComponent();
            this.objState = entityState;
            dtpStart.CustomFormat = " ";
            dtpStart.Checked = false;
            dtpEnd.CustomFormat = " ";
            dtpEnd.Checked = false;
           
        }
        public MaintenanceDetailFrm(MaintenanceModel maintenance,EntityState entityState)
        {
            InitializeComponent();
            this.objState = entityState;
            maintenanceModelBindingSource.DataSource = maintenance;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpStart.CustomFormat = "yyyy-MM-dd";
            dtpStart.Checked = false;

        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.CustomFormat = "yyyy-MM-dd";
            dtpEnd.Checked = false;
        }

        private void btnSelectDevice_Click(object sender, EventArgs e)
        {
            using (DeviceSelectFrm frm = new DeviceSelectFrm())
            {
                frm.ShowDialog();
                txtDeviceID.DataBindings.Clear() ;
                txtDeviceKKS.DataBindings.Clear();
                txtDeviceModel.DataBindings.Clear();
                txtDeviceName.DataBindings.Clear();
                txtDeviceNo.DataBindings.Clear();
                txtLocation.DataBindings.Clear();

                txtDeviceID.DataBindings.Add("Text",bindingSourceDevice, "Id");
                txtDeviceKKS.DataBindings.Add("Text", bindingSourceDevice, "DKKS");
                txtDeviceModel.DataBindings.Add("Text", bindingSourceDevice, "DModel");
                txtDeviceName.DataBindings.Add("Text", bindingSourceDevice, "DName");
                txtDeviceNo.DataBindings.Add("Text", bindingSourceDevice, "DNo");
                txtLocation.DataBindings.Add("Text", bindingSourceDevice, "Location");
                device = frm.deviceInfor;
                bindingSourceDevice.DataSource = frm.deviceInfor;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MaintenanceModel maintenanceModel = new MaintenanceModel();
            maintenanceModel.Id = txtID.Text;
            maintenanceModel.Remark = txtRemrk.Text;
            maintenanceModel.PTW = txtPTW.Text;
            maintenanceModel.StartDate = dtpStart.Text;
            maintenanceModel.EndDate = dtpEnd.Text;
            maintenanceModel.AP = cmbAP.Text;
            maintenanceModel.Detail = txtDetail.Text;
            maintenanceModel.DeviceId = txtDeviceID.Text;
            maintenanceModel.DeviceKKS = txtDeviceKKS.Text;
            maintenanceModel.DeviceLocation = txtLocation.Text;
            maintenanceModel.DeviceModel = txtDeviceModel.Text;
            maintenanceModel.DeviceName = txtDeviceName.Text;
            maintenanceModel.DeviceNo = txtDeviceNo.Text;
            maintenanceModel.FaultDetail = txtFaultDetail.Text;
            maintenanceModel.FaultSummary = txtFaultSummary.Text;
            maintenanceModel.DealWithDetail = txtDealWithDetail.Text;
            maintenanceModel.DealWithSummary = txtDealWithSummary.Text;
            mBLL.Save(maintenanceModel,objState);
            MessageBox.Show("Successful");
            ContinueAddSwitch();
        }
        private void ContinueAddSwitch()
        {
            txtID.Text = null;
            if (chkContinue.Checked)
            {
                switch (cmbKeepItem.Text)
                {
                    case "Keep PTW":
                        txtRemrk.Text = null;                       
                        txtDeviceID.Text = null;
                        txtDeviceKKS.Text = null;
                        txtLocation.Text = null;
                        txtDeviceModel.Text = null;
                        txtDeviceName.Text = null;
                        txtDeviceNo.Text = null;
                        txtFaultDetail.Text = null;
                        txtFaultSummary.Text = null;
                        txtDealWithDetail.Text = null;
                        txtDealWithSummary.Text = null;
                        break;
                    default:
                        txtRemrk.Text = null;
                        txtPTW.Text = null;
                        dtpStart.CustomFormat = " ";
                        dtpStart.Checked = false;
                        dtpEnd.CustomFormat = " ";
                        dtpEnd.Checked = false;
                        cmbAP.Text = null;
                        txtDetail.Text = null;
                        txtDeviceID.Text = null;
                        txtDeviceKKS.Text = null;
                        txtLocation.Text = null;
                        txtDeviceModel.Text = null;
                        txtDeviceName.Text = null;
                        txtDeviceNo.Text = null;
                        txtFaultDetail.Text = null;
                        txtFaultSummary.Text = null;
                        txtDealWithDetail.Text = null;
                        txtDealWithSummary.Text = null;
                        break;
                }
                
            }
            this.Close();
        }

        private void cmbAP_DropDown(object sender, EventArgs e)
        {
            ApBLL apBLL = new ApBLL();
            cmbAP.DataSource = apBLL.GetAll();
            cmbAP.DisplayMember = "Name";
        }

        private void cmbSubDevice_DropDown(object sender, EventArgs e)
        {
            SubDeviceBLL subDeviceBLL = new SubDeviceBLL();
            cmbSubDevice.DataSource = subDeviceBLL.GetAll();
            cmbSubDevice.DisplayMember = "SubDevice";
        }
    }
}
