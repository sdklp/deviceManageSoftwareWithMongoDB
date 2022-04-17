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
    public partial class ToolQtyChangeFrm : Form
    {
        ToolModel tool = new ToolModel();
        ToolQtyChangeModel qtyChangeModel = new ToolQtyChangeModel();
        EntityState objState;
        ToolQtyChangeBLL toolQtyChangeBLL = new ToolQtyChangeBLL();
        ToolBLL toolBLL = new ToolBLL();
        
        public ToolQtyChangeFrm()
        {
            InitializeComponent();
        }
        public ToolQtyChangeFrm(ToolModel toolModel)
        {
            InitializeComponent();
            tool = toolModel;
            qtyChangeModel.ToolId = tool.Id;
            qtyChangeModel.Name = tool.Name;
            qtyChangeModel.Model = tool.Model;
            qtyChangeModel.Units = tool.Units;
            toolQtyChangeModelBindingSource.DataSource = qtyChangeModel;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            toolQtyChangeBLL.Save(toolQtyChangeModelBindingSource.Current as ToolQtyChangeModel, EntityState.Added);
            tool = toolBLL.GetDataById(txtToolID.Text)[0];
            if (cmbAction.Text== "Scrap" | cmbAction.Text== "Lost")
            {
                tool.Qty = tool.Qty-Convert.ToInt32(txtQty.Text.Trim());
                tool.Balance=tool.Balance-Convert.ToInt32(txtQty.Text.Trim());
            }
            if (cmbAction.Text== "New In")
            {
                tool.Qty = Convert.ToInt32(txtQty.Text.Trim()) + tool.Qty;
                tool.Balance = tool.Balance + Convert.ToInt32(txtQty.Text.Trim());
            }
            
            toolBLL.Save(tool,EntityState.Changed);
            MessageBox.Show("Successful");
            this.Close();
        }

        private void cmbUnits_DropDown(object sender, EventArgs e)
        {
            UnitsBLL unitsBLL = new UnitsBLL();
            cmbUnits.DataSource = unitsBLL.GetAll();
            cmbUnits.DisplayMember = "Units";
        }
    }
}
