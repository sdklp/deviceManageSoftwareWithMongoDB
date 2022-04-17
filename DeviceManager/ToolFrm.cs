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
    public partial class ToolFrm : Form
    {
        EntityState objState;
        ToolBLL toolBLL = new ToolBLL();
        public ToolFrm()
        {
            InitializeComponent();
        }

        private void ToolFrm_Load(object sender, EventArgs e)
        {
            toolModelBindingSource.DataSource = toolBLL.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            using (ToolDetailFrm frm = new ToolDetailFrm(objState))
            {
                frm.ShowDialog();
                ToolFrm_Load(null,null);
            }
            objState = EntityState.Unchanged;
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            using (ToolDetailFrm frm = new ToolDetailFrm(toolModelBindingSource.Current as ToolModel, objState))
            {
                frm.ShowDialog();
                ToolFrm_Load(null, null);
            }
            objState = EntityState.Unchanged;
        }

       

        private void btnQtyChange_Click(object sender, EventArgs e)
        {
            ToolModel toolModel = toolModelBindingSource.Current as ToolModel;
            toolModel = toolModelBindingSource.Current as ToolModel;
            using (ToolQtyChangeFrm frm = new ToolQtyChangeFrm(toolModel))
            {
                frm.ShowDialog();
                ToolFrm_Load(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                toolBLL.Delete((toolModelBindingSource.Current as ToolModel).Id);
                toolModelBindingSource.RemoveCurrent();
            }
            
        }

        private void btnDeleteQtyChanged_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLendTool_Click(object sender, EventArgs e)
        {
            using (ToolLendDetailFrm frm = new ToolLendDetailFrm(toolModelBindingSource.Current as ToolModel, "Lend"))
            {
                frm.ShowDialog();
                ToolModel toolModel = new ToolModel();
                toolModel = toolModelBindingSource.Current as ToolModel;
                toolModel.Balance = toolModel.Balance - frm.qty;
                toolBLL.Save(toolModel, EntityState.Changed);
                
                ToolFrm_Load(null,null);
            }
            
        }

        

        private void dgvTools_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            LoadDownSide();
        }
        private void LoadDownSide()
        {
            ToolQtyChangeBLL toolQtyChangeBLL = new ToolQtyChangeBLL();
            ToolLendBLL toolLendBLL = new ToolLendBLL();
            switch (tabTool.SelectedTab.Text)
            {
                case "Qty Changed":
                    toolQtyChangeModelBindingSource.DataSource = null;
                    toolQtyChangeModelBindingSource.DataSource = toolQtyChangeBLL.GetDataByToolId((toolModelBindingSource.Current as ToolModel).Id);
                    break;
                case "Lend Record":
                    toolLendModelBindingSource.DataSource = null;
                    toolLendModelBindingSource.DataSource = toolLendBLL.GetDataByToolIdNotFinish((toolModelBindingSource.Current as ToolModel).Id);
                    break;
                default:
                    break;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ToolLendModel obj = new ToolLendModel();
            obj = toolLendModelBindingSource.Current as ToolLendModel;
            
                using (ToolLendDetailFrm frm = new ToolLendDetailFrm(obj, "Return"))
                {
                    frm.ShowDialog();
                    ToolModel toolModel = new ToolModel();
                    toolModel = toolModelBindingSource.Current as ToolModel;
                    toolModel.Balance = toolModel.Balance + frm.qty;
                    toolBLL.Save(toolModel, EntityState.Changed);
                    ToolFrm_Load(null, null);
                }
            
           
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
           toolModelBindingSource.DataSource= toolBLL.GetDataByFilter(cmbSearch.Text.Trim().ToLower()) ;
        }

        private void btnSearchLend_Click(object sender, EventArgs e)
        {
            ToolLendBLL toolLendBLL = new ToolLendBLL();
            toolLendModelBindingSource.DataSource = toolLendBLL.GetDataByFilterNotFinish(cmbSearchLend.Text.Trim().ToLower()) ;
        }
    }
}
