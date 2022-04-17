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
    public partial class AddressFrm : Form
    {
        public AddressFrm()
        {
            InitializeComponent();
        }
        AddressBLL addressBLL = new AddressBLL();
        EntityState objState;
        string parentId, parentText, thisId, thisText,addType;
        AddressModel addressModel = new AddressModel();
        #region 树的异步加载
        /// <summary>
        /// 载入根节点
        /// </summary>
        public void make_rootView(TreeNodeCollection tnc)
        {

            foreach (var item in addressBLL.GetDataByPid("abcdefghabcdefghabcdefgh"))
            {
                TreeNode tn = new TreeNode();
                string sk = item.Id;
                tn.Text = item.Name;
                tn.Tag = item.Id;
                tnc.Add(tn);
                if (addressBLL.GetDataByPid(sk).Count != 0)
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
            foreach (var item in addressBLL.GetDataByPid(node_id))
            {
                TreeNode tn = new TreeNode();
                string sk = item.Id;
                tn.Text = item.Name;
                tn.Tag = item.Id;
                node.Nodes.Add(tn);

                if (addressBLL.GetDataByPid(sk).Count != 0)
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
            foreach (var item in addressBLL.GetDataByName(tn.Text))
            {
                node_id = item.Id;
            }
            make_view(node_id, tn);
        }
        private void AddressFrm_Load(object sender, EventArgs e)
        {
            tvwAddress.Nodes.Clear();
            make_rootView(tvwAddress.Nodes);
        }
        #endregion

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pnlContainer.Enabled = true;
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                if (addressBLL.GetDataById(tvwAddress.SelectedNode.Tag.ToString()).Count>0)
                {
                    MessageBox.Show("Please delete child nodes first!");
                    return;
                }
                addressBLL.Delete(tvwAddress.SelectedNode.Tag.ToString()) ;
                tvwAddress.Nodes.Remove(tvwAddress.SelectedNode);
            }
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            addType = "addChild";
            pnlContainer.Enabled = true;
            addressModelBindingSource.AddNew();
            addressModelBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnAddSibling_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            addType = "addSibling";
            pnlContainer.Enabled = true;
            addressModelBindingSource.AddNew();
            addressModelBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addressModel = addressModelBindingSource.Current as AddressModel;
            if (addType== "addChild")
            {
                if (string.IsNullOrEmpty(thisId))
                {
                    addressModel.Pid = "abcdefghabcdefghabcdefgh";
                }
                addressModel.Pid = thisId;
            }
            if (addType== "addSibling")
            {
                if (string.IsNullOrEmpty(parentId))
                {
                    addressModel.Pid = "abcdefghabcdefghabcdefgh";
                }
                addressModel.Pid = parentId;
            }
            
            addressBLL.Save(addressModel, objState);
            pnlContainer.Enabled = false;
            objState = EntityState.Unchanged;
            AddressFrm_Load(null, null);
        }

        private void tvwAddress_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            make_NodeView(sender, e);
        }

        private void tvwAddress_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            if (tvwAddress.SelectedNode.Level == 0)
            {
                parentId = "abcdefghabcdefghabcdefgh";
                parentText = "All";
            }
            else
            {
                parentId = tvwAddress.SelectedNode.Parent.Tag.ToString();
                parentText = tvwAddress.SelectedNode.Parent.Text;
            }

            thisId = tvwAddress.SelectedNode.Tag.ToString();
            thisText = tvwAddress.SelectedNode.Text;
            addressModelBindingSource.DataSource = addressBLL.GetDataById(tvwAddress.SelectedNode.Tag.ToString()) ;
        }
        
    }
}
