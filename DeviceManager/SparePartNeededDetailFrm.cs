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
    public partial class SparePartNeededDetailFrm : Form
    {
        public SparePartNeededDetailFrm()
        {
            InitializeComponent();
        }

        EntityState objState;
        DeviceModel device;
        SparePartModel sparePart;
        SparePartNeededModel sp;
        public SparePartNeededDetailFrm(EntityState entityState)
        {
            InitializeComponent();
            this.objState = entityState;
        }
        public SparePartNeededDetailFrm(SparePartNeededModel sparePartNeeded,EntityState entityState)
        {
            InitializeComponent();
            this.objState = entityState;
            sparePartNeededModelBindingSource.DataSource = sparePartNeeded;
            sp = sparePartNeeded;
            device = sparePartNeeded.Device;
            sparePart = sparePartNeeded.SparePart;

        }
        private void dtpRequire_ValueChanged(object sender, EventArgs e)
        {
            dtpRequire.CustomFormat = "yyyy-MM-dd";
        }

        private void dtpRelease_ValueChanged(object sender, EventArgs e)
        {
            dtpRelease.CustomFormat= "yyyy-MM-dd";
        }

        private void btnSelectDevice_Click(object sender, EventArgs e)
        {
            DeviceBLL dBLL = new DeviceBLL();
            using (DeviceSelectFrm dFrm = new DeviceSelectFrm())
            {
                dFrm.ShowDialog();

                txtDeviceID.DataBindings.Clear();
                txtDeviceName.DataBindings.Clear();
                txtKKS.DataBindings.Clear();
                txtDeviceModel.DataBindings.Clear();
                txtLocation.DataBindings.Clear();
                txtDeviceNo.DataBindings.Clear();
                txtDeviceID.DataBindings.Add("Text",bindingSourceDevice, "Id");
                txtDeviceName.DataBindings.Add("Text", bindingSourceDevice, "DName");
                txtKKS.DataBindings.Add("Text", bindingSourceDevice, "DKKS");
                txtDeviceModel.DataBindings.Add("Text", bindingSourceDevice, "DModel");
                txtLocation.DataBindings.Add("Text", bindingSourceDevice, "Location");
                txtDeviceNo.DataBindings.Add("Text", bindingSourceDevice, "DNo");
                this.device = dFrm.deviceInfor;
                bindingSourceDevice.DataSource = dFrm.deviceInfor;
                
            }
        }

        private void btnSelectSparePart_Click(object sender, EventArgs e)
        {
            SparePartBLL sBLL = new SparePartBLL();
            using (SparePartSelectFrm sFrm = new SparePartSelectFrm())
            {
                sFrm.ShowDialog();

                txtSparePartID.DataBindings.Clear();
                txtSparePartName.DataBindings.Clear();
                txtSparePartNo.DataBindings.Clear();
                txtSparePartModel.DataBindings.Clear();
                txtSparePartID.DataBindings.Add("Text",bindingSourceSparePart, "Id");
                txtSparePartName.DataBindings.Add("Text", bindingSourceSparePart, "PName");
                txtSparePartNo.DataBindings.Add("Text", bindingSourceSparePart, "PNo");
                txtSparePartModel.DataBindings.Add("Text", bindingSourceSparePart, "PModel");
                this.sparePart = sFrm.sparePartInfor;
                bindingSourceSparePart.DataSource = sFrm.sparePartInfor;
               
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (objState==EntityState.Added)
            {
                sp = new SparePartNeededModel(this.device, this.sparePart);
                
            }

            sp.Device = this.device;
            sp.SparePart = this.sparePart;
            sp.Status = cmbStatus.Text.Trim();
            sp.DocID = txtDocID.Text;
            sp.RequireDate = dtpRequire.Text;
            sp.ReleaseDate = dtpRelease.Text;
            sp.Remark = txtRemark.Text;
            sp.SubDevice = cmbSubDevice.Text;
            sp.Units = cmbSparePartUnits.Text;
            sp.Qty = string.IsNullOrEmpty(txtSparePartQty.Text.Trim()) == true ? 0 : Convert.ToInt32(txtSparePartQty.Text.Trim());
            sp.DeviceID = txtDeviceID.Text;
            sp.DeviceKKS = txtKKS.Text;
            sp.DeviceLocation = txtLocation.Text;
            sp.DeviceModel = txtDeviceModel.Text;
            sp.DeviceName = txtDeviceName.Text;
            sp.DeviceNo = txtDeviceNo.Text;
            sp.SparePartID = txtSparePartID.Text;
            sp.SparePartModel = txtSparePartModel.Text;
            sp.SparePartName = txtSparePartName.Text;
            sp.SparePartNo = txtSparePartNo.Text;
            SparePartNeededBLL spBLL = new SparePartNeededBLL();
            spBLL.Save(sp,objState);
            ContinueAddSwitch();
        }
        private void ContinueAddSwitch()
        {
            txtID.Text = null;
            if (chkContinue.Checked)
            {
                switch (cmbKeepItems.Text)
                {
                    case "Keep None":
                        cmbStatus.Text = null;
                        txtDocID.Text = null;
                        dtpRequire.CustomFormat = " ";
                        dtpRequire.Checked = false;
                        dtpRelease.CustomFormat = " ";
                        dtpRelease.Checked = false;
                        txtRemark.Text = null;
                        txtDeviceID.Text = null;
                        txtDeviceName.Text = null;
                        txtKKS.Text = null;
                        txtDeviceModel.Text = null;
                        txtLocation.Text = null;
                        txtDeviceNo.Text = null;
                        cmbSubDevice.Text = null;
                        this.device = null;
                        txtSparePartID.Text = null;
                        txtSparePartName.Text = null;
                        txtSparePartNo.Text = null;
                        txtSparePartModel.Text = null;
                        cmbSparePartUnits.Text = null;
                        txtSparePartQty.Text = null;
                        sparePart = null;
                        break;
                    default:
                       
                        txtDeviceID.Text = null;
                        txtDeviceName.Text = null;
                        txtKKS.Text = null;
                        txtDeviceModel.Text = null;
                        txtLocation.Text = null;
                        txtDeviceNo.Text = null;
                        cmbSubDevice.Text = null;
                        this.device = null;
                        txtSparePartID.Text = null;
                        txtSparePartName.Text = null;
                        txtSparePartNo.Text = null;
                        txtSparePartModel.Text = null;
                        cmbSparePartUnits.Text = null;
                        txtSparePartQty.Text = null;
                        sparePart = null;
                        break;
                }
                
            }
            else
            {
                this.Close();
            }
        }

        private void cmbStatus_DropDown(object sender, EventArgs e)
        {
            SparePartNeededStatusBLL sparePartNeededStatusBLL = new SparePartNeededStatusBLL();
            cmbStatus.DataSource = sparePartNeededStatusBLL.GetAll();
            cmbStatus.DisplayMember = "Name";
        }

        private void cmbSubDevice_DropDown(object sender, EventArgs e)
        {
            //SubDeviceBLL subDeviceBLL = new SubDeviceBLL();
            //cmbSubDevice.DataSource = subDeviceBLL.GetAll();
            //cmbSubDevice.DisplayMember = "SubDevice";
            tvwSubDevice.Focus();
            tvwSubDevice.Visible = true;
            if (tvwSubDevice.Nodes.Count == 0)
            {
                make_rootView(tvwSubDevice.Nodes);
            }
           
            
        }

        private void cmbSparePartUnits_DropDown(object sender, EventArgs e)
        {
            UnitsBLL unitsBLL = new UnitsBLL();
            cmbSparePartUnits.DataSource = unitsBLL.GetAll();
            cmbSparePartUnits.DisplayMember = "Units";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tvwSubDevice.Visible = false;
            cmbSubDevice.Text = tvwSubDevice.SelectedNode.FullPath;

        }
        SubDeviceBLL subDeviceBLL = new SubDeviceBLL();
        #region 树的异步加载
        /// <summary>
        /// 载入根节点
        /// </summary>
        public void make_rootView(TreeNodeCollection tnc)
        {

            foreach (var item in subDeviceBLL.GetDataByPid("abcdefghabcdefghabcdefgh"))
            {
                TreeNode tn = new TreeNode();
                string sk = item.Id;
                tn.Text = item.SubDevice;
                tn.Tag = item.Id;
                tnc.Add(tn);
                if (subDeviceBLL.GetDataByPid(sk).Count != 0)
                {
                    TreeNode tn1 = new TreeNode();
                    tn1.Text = "";
                    tn.Nodes.Add(tn1);
                }
            }
        }

        /// <summary>
        /// 载入子节点
        /// </summary>
        /// <param name="node_id"></param>
        /// <param name="node"></param>
        public void make_view(string node_id, TreeNode node)
        {
            node.Nodes.Clear();
            foreach (var item in subDeviceBLL.GetDataByPid(node_id))
            {

                TreeNode tn = new TreeNode();
                string sk = item.Id;
                tn.Text = item.SubDevice;
                tn.Tag = item.Id;
                node.Nodes.Add(tn);

                if (subDeviceBLL.GetDataByPid(sk).Count != 0)
                {
                    TreeNode tn1 = new TreeNode();
                    tn1.Text = "";

                    tn.Nodes.Add(tn1);
                }
            }
        }

       

        /// <summary>
        /// 查找父节点的ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void make_NodeView(object sender, TreeViewCancelEventArgs e)
        {

            TreeNode tn = e.Node;
            string node_id = "";
            foreach (var item in subDeviceBLL.GetDataById(tn.Tag.ToString()))
            {
                node_id = item.Id;
            }
            make_view(node_id, tn);
        }


        #endregion

        private void tvwSubDevice_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            make_NodeView(sender, e);
        }
    }
}
