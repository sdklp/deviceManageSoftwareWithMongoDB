using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Models;
using BLL;
namespace DeviceManager
{
    class ShowLocationTreeView
    {
        LocationBLL locationBLL = new LocationBLL();
        //使用方法
        //1、需要加载的地方
        //private void LoadLocationTree()
        //{
        //    string sql = "select ID,AreaCode,pid from tblLocation1";
        //    DataTable dataTable = DBHelper.ExecuteDataTable(sql);
        //    treeView1.Nodes.Clear();
        //    showTreeView.dt = dataTable;
        //    showTreeView.make_rootView(treeView1.Nodes);

        //}

        //2、并生成TreeViewBeforeExpand事件
        //private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        //{

        //    showTreeView.make_NodeView(sender, e);
        //}

       

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
        //public void make_view(string node_id, TreeNode node)
        //{
        //    //node.Nodes.Clear();
        //    //foreach (DataRow row in dt.Select("pid='" + node_id + "'"))
        //    //{
        //    //    TreeNode tn = new TreeNode();
        //    //    string sk = row["id"].ToString();
        //    //    tn.Text = row["AreaCode"].ToString();
        //    //    node.Nodes.Add(tn);

        //    //    if ((dt.Select("pid='" + sk + "'")).Count() != 0)
        //    //    {
        //    //        TreeNode tn1 = new TreeNode();
        //    //        tn1.Text = "";
        //    //        tn.Nodes.Add(tn1);
        //    //    }
        //    }
        //}
        /// <summary>
        /// 查找父节点的ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void make_NodeView(object sender, TreeViewCancelEventArgs e)
        {
            //TreeNode tn = e.Node;
            //string node_id = "";
            //foreach (DataRow row in dt.Select("AreaCode='" + tn.Text + "'"))
            //{
            //    node_id = row["id"].ToString();
            //}
            //make_view(node_id, tn);
        }
        #endregion

        //private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        //{
        //    //make_NodeView(sender, e);

        //}
    }
}
