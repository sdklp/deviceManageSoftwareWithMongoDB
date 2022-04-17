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
    public partial class SparePartChangedDetailFrm : Form
    {
        SparePartChangedModel spChanged = new SparePartChangedModel();
        SparePartChangedBLL spChangedBLL = new SparePartChangedBLL();
        EntityState objState;

        public SparePartChangedDetailFrm()
        {
            InitializeComponent();
        }
        public SparePartChangedDetailFrm(EntityState entityState)
        {
            InitializeComponent();
            this.objState = entityState;
            dtpDate.CustomFormat = " ";
            dtpDate.Checked = false;
        }
        public SparePartChangedDetailFrm(SparePartChangedModel sparePartChanged,EntityState entityState)
        {
            InitializeComponent();
            this.objState = entityState;
            sparePartChangedModelBindingSource.DataSource = sparePartChanged;
        }
        private void btnSelectDevice_Click(object sender, EventArgs e)
        {
            using (DeviceSelectFrm dFrm = new DeviceSelectFrm())
            {
                dFrm.ShowDialog();
                txtDeviceID.DataBindings.Clear();
                txtDeviceKKS.DataBindings.Clear();
                txtDeviceLocation.DataBindings.Clear();
                txtDeviceModel.DataBindings.Clear();
                txtDeviceName.DataBindings.Clear();
                txtDeviceNo.DataBindings.Clear();

                txtDeviceID.DataBindings.Add("Text",bindingSourceDevice, "Id");
                txtDeviceKKS.DataBindings.Add("Text", bindingSourceDevice, "DKKS");
                txtDeviceLocation.DataBindings.Add("Text", bindingSourceDevice, "Location");
                txtDeviceModel.DataBindings.Add("Text", bindingSourceDevice, "DModel");
                txtDeviceName.DataBindings.Add("Text", bindingSourceDevice, "DName");
                txtDeviceNo.DataBindings.Add("Text", bindingSourceDevice, "DNo");
                bindingSourceDevice.DataSource = dFrm.deviceInfor;
            }
        }

        private void btnSelectSparePart_Click(object sender, EventArgs e)
        {
            using (SparePartSelectFrm pFrm = new SparePartSelectFrm())
            {
                pFrm.ShowDialog();
                txtSparePartID.DataBindings.Clear();
                txtSparePartName.DataBindings.Clear();
                txtSparePartModel.DataBindings.Clear();
                txtSparePartNo.DataBindings.Clear();

                txtSparePartID.DataBindings.Add("Text",bindingSourceSparePart, "Id");
                txtSparePartName.DataBindings.Add("Text", bindingSourceSparePart, "PName");
                txtSparePartModel.DataBindings.Add("Text", bindingSourceSparePart, "PModel");
                txtSparePartNo.DataBindings.Add("Text", bindingSourceSparePart, "PNo");
                bindingSourceSparePart.DataSource = pFrm.sparePartInfor;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            spChanged.ID = txtID.Text;
            spChanged.ChangedDate = dtpDate.Text;
            spChanged.Remark = txtRemark.Text;
            spChanged.Did = txtDeviceID.Text;
            spChanged.DeviceModel = txtDeviceModel.Text;
            spChanged.DeviceName = txtDeviceName.Text;
            spChanged.DeviceLocation = txtDeviceLocation.Text;
            spChanged.DeviceKKS = txtDeviceKKS.Text;
            spChanged.DeviceNo = txtDeviceNo.Text;
            spChanged.SubDevice = cmbSubDevice.Text;
            spChanged.Pid = txtSparePartID.Text;
            spChanged.SparePartModel = txtSparePartModel.Text;
            spChanged.SparePartName = txtSparePartName.Text;
            spChanged.SparePartNo = txtSparePartNo.Text;
            spChanged.Units = cmbUnits.Text;
            spChanged.Qty = string.IsNullOrEmpty(txtQty.Text.Trim()) == true ? 0 : Convert.ToInt32(txtQty.Text);
            spChangedBLL.Save(spChanged, objState);
            MessageBox.Show("Successful");
            ContinueAddSwitch();
        }
        private void ContinueAddSwitch()
        {
            if (chkContinue.Checked)
            {
                txtID.Text = null;
                switch (cmbKeepItem.Text)
                {
                    case "Keep Device":
                        txtSparePartID.Text = null;
                        txtSparePartModel.Text = null;
                        txtSparePartName.Text = null;
                        txtSparePartNo.Text = null;
                        cmbUnits.Text = null;
                        txtQty.Text = null;
                        break;
                    case "Keep Spare Part":
                        txtDeviceID.Text = null;
                        txtDeviceKKS.Text = null;
                        txtDeviceLocation.Text = null;
                        txtDeviceModel.Text = null;
                        txtDeviceName.Text = null;
                        txtDeviceNo.Text = null;
                        cmbSubDevice.Text = null;
                        break;
                    default:
                        txtSparePartID.Text = null;
                        txtSparePartModel.Text = null;
                        txtSparePartName.Text = null;
                        txtSparePartNo.Text = null;
                        cmbUnits.Text = null;
                        txtQty.Text = null;
                        txtDeviceID.Text = null;
                        txtDeviceKKS.Text = null;
                        txtDeviceLocation.Text = null;
                        txtDeviceModel.Text = null;
                        txtDeviceName.Text = null;
                        txtDeviceNo.Text = null;
                        cmbSubDevice.Text = null;
                        break;
                }
            }
            else
            {
                this.Close();
            }
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDate.CustomFormat = "yyyy-MM-dd";
        }

        private void cmbUnits_DropDown(object sender, EventArgs e)
        {
            UnitsBLL unitsBLL = new UnitsBLL();
            cmbUnits.DataSource = unitsBLL.GetAll();
            cmbUnits.DisplayMember = "Units";
        }

        private void cmbSubDevice_DropDown(object sender, EventArgs e)
        {
            SubDeviceBLL subDeviceBLL = new SubDeviceBLL();
            cmbSubDevice.DataSource = subDeviceBLL.GetAll();
            cmbSubDevice.DisplayMember = "SubDevice";
        }
    }
}
