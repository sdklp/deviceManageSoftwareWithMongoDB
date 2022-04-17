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
    public partial class DeviceDetailFrm : Form
    {
        DeviceBLL dBLL = new DeviceBLL();
        EntityState objState;
        LocationBLL locationBLL = new LocationBLL();
        DeviceStatusBLL deviceStatusBLL = new DeviceStatusBLL();
        CompanyBLL companyBLL = new CompanyBLL();
        public DeviceDetailFrm()
        {
            InitializeComponent();
        }
        public DeviceDetailFrm(EntityState entityState)
        {
            InitializeComponent();
            this.objState = entityState;
            if (objState == EntityState.Added)
            {
                //MessageBox.Show("Test");
                deviceModelBindingSource.AddNew();
                deviceModelBindingSource.MoveLast();
            }
            
        }
        public DeviceDetailFrm(DeviceModel device,EntityState entityState)
        {
            InitializeComponent();
            this.objState = entityState;            
            deviceModelBindingSource.DataSource = device;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            dBLL.Save(deviceModelBindingSource.Current as DeviceModel, objState);
            ContinueAddSwitch();
        }
        private void ContinueAddSwitch()
        {
            if (chkContinue.Checked)
            {
                deviceModelBindingSource.AddNew();
                deviceModelBindingSource.MoveLast();                
                return;
            }
            this.Close();
        }
        private void DeviceDetailFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbLocation_DropDown(object sender, EventArgs e)
        {
            cmbLocation.DataSource = locationBLL.GetAll();
            cmbLocation.DisplayMember = "LName";
        }

        private void cmbStatus_DropDown(object sender, EventArgs e)
        {
            cmbStatus.DataSource = deviceStatusBLL.GetAll();
            cmbStatus.DisplayMember = "DeviceStatus";
        }

        private void cmbManufacturer_DropDown(object sender, EventArgs e)
        {
            cmbManufacturer.DataSource = companyBLL.GetAllCompany();
            cmbManufacturer.DisplayMember = "CompanyName";
        }

        private void cmbAgency_DropDown(object sender, EventArgs e)
        {
            cmbAgency.DataSource = companyBLL.GetAllAgency();
            cmbAgency.DisplayMember = "CompanyName";
        }
    }
}
