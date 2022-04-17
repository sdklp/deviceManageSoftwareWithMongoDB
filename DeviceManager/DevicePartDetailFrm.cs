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
    public partial class DevicePartDetailFrm : Form
    {
        EntityState objState;
        DeviceModel device = new DeviceModel();
        SparePartModel sparePart = new SparePartModel();
        DevicePartModel devicePart;
        SubDeviceBLL subDeviceBLL = new SubDeviceBLL();
        UnitsBLL unitsBLL = new UnitsBLL();
       
        public DevicePartDetailFrm()
        {
            InitializeComponent();            
           
        }
        public DevicePartDetailFrm(DeviceModel device,SparePartModel sparePart,EntityState entityState)
        {
            InitializeComponent();
            this.objState = entityState;
            this.device = device;
            this.sparePart = sparePart;            
            DataBindingToDevice();
            DataBindingToSparePart();
            bindingSourceDevice.DataSource = device;
            bindingSourceSparePart.DataSource = sparePart;
        }
        public DevicePartDetailFrm(DevicePartModel devicePart,EntityState entityState)
        {
            InitializeComponent();
            this.objState = entityState;
            this.devicePart = devicePart;
            this.device = devicePart.Device;
            this.sparePart = devicePart.SparePart;
            
            devicePartModelBindingSource.DataSource = devicePart;

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (objState==EntityState.Added)
            {
                devicePart = new DevicePartModel(this.device, this.sparePart);
            }
           
            devicePart.SubDevice = cmbSubDevice.Text;
            devicePart.Units = cmbSparePartUnits.Text;
            devicePart.Qty = string.IsNullOrEmpty(txtSparePartQty.Text.Trim()) == true ? 0 : Convert.ToInt32(txtSparePartQty.Text.Trim());
            devicePart.Device = device;
            devicePart.SparePart = sparePart;
            devicePart.Remark = txtRemark.Text;
            devicePart.Did = txtDeviceID.Text;
            devicePart.DKKS = txtDeviceKKS.Text;
            devicePart.DModel = txtDeviceModel.Text;
            devicePart.DName = txtDeviceName.Text;
            devicePart.DNo = txtDeviceNo.Text;
            devicePart.Location = txtDeviceLocation.Text;
            devicePart.Pid = txtDevicePartID.Text;
            devicePart.PModel = txtSparePartModel.Text;
            devicePart.PName = txtSparePartName.Text;
            devicePart.PNo = txtSparePartNo.Text;
            
            DevicePartBLL dpBLL = new DevicePartBLL();
            dpBLL.Save(devicePart, objState) ;
            this.Close();
        }
        private void DataBindingToDevice()
        {
            txtDeviceID.DataBindings.Clear();
            txtDeviceLocation.DataBindings.Clear();
            txtDeviceKKS.DataBindings.Clear();
            txtDeviceName.DataBindings.Clear();
            txtDeviceModel.DataBindings.Clear();
            txtDeviceNo.DataBindings.Clear();


            txtDeviceID.DataBindings.Add("Text", bindingSourceDevice, "Id");
            txtDeviceLocation.DataBindings.Add("Text", bindingSourceDevice, "Location");
            txtDeviceKKS.DataBindings.Add("Text", bindingSourceDevice, "DKKS");
            txtDeviceName.DataBindings.Add("Text", bindingSourceDevice, "DName");
            txtDeviceModel.DataBindings.Add("Text", bindingSourceDevice, "DModel");
            txtDeviceNo.DataBindings.Add("Text", bindingSourceDevice, "DNo");
        }
        private void DataBindingToSparePart()
        {
            txtSparePartID.DataBindings.Clear();
            txtSparePartName.DataBindings.Clear();
            txtSparePartModel.DataBindings.Clear();
            txtSparePartNo.DataBindings.Clear();

            txtSparePartID.DataBindings.Add("Text", bindingSourceSparePart, "Id");
            txtSparePartName.DataBindings.Add("Text", bindingSourceSparePart, "PName");
            txtSparePartModel.DataBindings.Add("Text", bindingSourceSparePart, "PModel");
            txtSparePartNo.DataBindings.Add("Text", bindingSourceSparePart, "PNo");
        }
        private void btnSelectDevice_Click(object sender, EventArgs e)
        {
            using (DeviceSelectFrm deviceSelectFrm = new DeviceSelectFrm())
            {
                deviceSelectFrm.ShowDialog();
                this.device = deviceSelectFrm.deviceInfor;
                this.devicePart.Device = device;
                bindingSourceDevice.DataSource = device;
                DataBindingToDevice();
            }
        }

        private void btnSelectSparePart_Click(object sender, EventArgs e)
        {
            using (SparePartSelectFrm spsFrm = new SparePartSelectFrm())
            {
                spsFrm.ShowDialog();
                sparePart = spsFrm.sparePartInfor;
                //this.devicePart.SparePart = sparePart;
                bindingSourceSparePart.DataSource = sparePart;
                DataBindingToSparePart();
            }
        }

        private void cmbSubDevice_DropDown(object sender, EventArgs e)
        {
            cmbSubDevice.DataSource = subDeviceBLL.GetAll();
            cmbSubDevice.DisplayMember = "SubDevice";
        }

        private void cmbSparePartUnits_DropDown(object sender, EventArgs e)
        {
            cmbSparePartUnits.DataSource = unitsBLL.GetAll();
            cmbSparePartUnits.DisplayMember = "Units";
        }
    }
}
