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
    public partial class SubDeviceFrm : Form
    {
        SubDeviceBLL subDeviceBLL = new SubDeviceBLL();
        EntityState objState = EntityState.Unchanged;
        string selectID, parentID;
        string nodeType;
        SubDeviceModel subDeviceModel = new SubDeviceModel();

        public SubDeviceFrm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                subDeviceModel.Id = txtID.Text;
            }
            
            subDeviceModel.Pid =txtPid.Text; 
            subDeviceModel.SubDevice = txtSubDevice.Text.Trim();
            subDeviceBLL.Save(subDeviceModel,objState);           
            pnlContainer.Enabled = false;
            subDeviceModel.Id = null;
            tvwSubDevice.Nodes.Clear();
            make_rootView(tvwSubDevice.Nodes);

        }
      
        private void btnAddChild_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;           
            pnlContainer.Enabled = true;
            nodeType = "child";
            txtID.Text = null;
            txtSubDevice.Text = null;
            txtPid.Text = selectID;
            txtSubDevice.Focus();
        }

        private void btnAddSibling_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;           
            pnlContainer.Enabled = true;
            nodeType = "sibling";
            txtID.Text = null;
            txtSubDevice.Text = null;
            txtPid.Text = parentID;
            txtSubDevice.Focus();
        }

        private void SubDeviceFrm_Load(object sender, EventArgs e)
        {
            
            make_rootView(tvwSubDevice.Nodes);
        }

        private void tvwSubDevice_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            make_NodeView(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure want to delete this record?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                
                if (subDeviceBLL.GetDataBySubDeviceName(tvwSubDevice.SelectedNode.Text).Count!=0)
                {
                    subDeviceBLL.Delete(subDeviceBLL.GetDataBySubDeviceName(tvwSubDevice.SelectedNode.Text)[0].Id);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlContainer.Enabled = true;
            objState = EntityState.Changed;
            subDeviceModelBindingSource.DataSource = subDeviceBLL.GetDataById(selectID);
        }

        private void tvwSubDevice_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvwSubDevice.SelectedNode.Level == 0)
            {
                parentID = "abcdefghabcdefghabcdefgh";
                //parentText = "All";
            }
            else
            {
                parentID = tvwSubDevice.SelectedNode.Parent.Tag.ToString();
                //parentText = tvwSubDevice.SelectedNode.Parent.Text;
            }

            selectID = tvwSubDevice.SelectedNode.Tag.ToString();
            //thisText = tvwLocation.SelectedNode.Text;



        }
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tvwSubDevice.Nodes.Clear();
            SubDeviceFrm_Load(null, null);
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
    }
}
