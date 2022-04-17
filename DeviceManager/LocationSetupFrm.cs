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
    public partial class LocationSetupFrm : Form
    {
        public LocationSetupFrm()
        {
            InitializeComponent();
        }
        LocationModel location = new LocationModel();
        LocationBLL locationBLL = new LocationBLL();
        EntityState objState;
        string nodeLevel;
        string thisId, parentId, thisText, parentText;
     

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if (thisId == null)
            {
                MessageBox.Show("Please select node first");
                return;
            }
            objState = EntityState.Added;
            pnlContainer.Enabled = true;
            nodeLevel = "child";

            txtID.Text = null;
            txtLocation.Text = null;
            txtPid.Text = thisId;
            txtNodeName.Text = thisText;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            location.Id = txtID.Text;
            location.LName = txtLocation.Text;
            location.Pid = string.IsNullOrEmpty(txtPid.Text.Trim()) == true ? "abcdefghabcdefghabcdefgh" : txtPid.Text.Trim();
            location.Remark = txtRemark.Text;
            locationBLL.Save(location, objState);
            objState = EntityState.Unchanged;
            pnlContainer.Enabled = false;

            tvwLocation.Nodes.Clear();
            LocationSetupFrm_Load(null, null);
        }

        private void tvwLocation_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            make_NodeView(sender, e);
        }








        #region 树的异步加载
        /// <summary>
        /// 载入根节点
        /// </summary>
        public void make_rootView(TreeNodeCollection tnc)
        {

            foreach (var item in locationBLL.GetDataByPid("abcdefghabcdefghabcdefgh"))
            {
                TreeNode tn = new TreeNode();
                string sk = item.Id;
                tn.Text = item.LName;
                tn.Tag = item.Id;
                tnc.Add(tn);
                if (locationBLL.GetDataByPid(sk).Count != 0)
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
            foreach (var item in locationBLL.GetDataByPid(node_id))
            {
                TreeNode tn = new TreeNode();
                string sk = item.Id;
                tn.Text = item.LName;
                tn.Tag = item.Id;
                node.Nodes.Add(tn);

                if (locationBLL.GetDataByPid(sk).Count != 0)
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
            foreach (var item in locationBLL.GetDataByLocationName(tn.Text))
            {
                node_id = item.Id;
            }
            make_view(node_id, tn);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtLocation.Text = null;
            txtNodeName.Text = null;
            txtPid.Text = null;
            txtRemark.Text = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (var item in locationBLL.GetDataByPid(thisId))
                {
                    locationBLL.Delete(item.Id);
                }
                locationBLL.Delete(thisId);
                tvwLocation.Nodes.Clear();
                LocationSetupFrm_Load(null, null);
            }
        }
        


        

        private void LocationSetupFrm_Load(object sender, EventArgs e)
        {
            pnlContainer.Enabled = false;

            make_rootView(tvwLocation.Nodes);
        }

        private void tvwLocation_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (tvwLocation.SelectedNode.Level == 0)
            {
                parentId = "abcdefghabcdefghabcdefgh";
                parentText = "All";
            }
            else
            {
                parentId = tvwLocation.SelectedNode.Parent.Tag.ToString();
                parentText = tvwLocation.SelectedNode.Parent.Text;
            }

            thisId = tvwLocation.SelectedNode.Tag.ToString();
            thisText = tvwLocation.SelectedNode.Text;


        }

        private void btnAddSibling_Click(object sender, EventArgs e)
        {
            if (parentId == null)
            {
                MessageBox.Show("Please select node first");
                return;
            }
            pnlContainer.Enabled = true;

            objState = EntityState.Added;
            nodeLevel = "sibling";
            txtLocation.Text = null;
            txtPid.Text = parentId;
            txtNodeName.Text = parentText;
        }


        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {

            locationModelBindingSource.DataSource = locationBLL.GetDataById(thisId);
            pnlContainer.Enabled = true;
            objState = EntityState.Changed;
            txtNodeName.Text = null;
            txtLocation.Focus();

        }
    }
}
