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
    public partial class ToolTypeFrm : Form
    {
        ToolTypeBLL toolTypeBLL = new ToolTypeBLL();
        EntityState objState = EntityState.Unchanged;
        public ToolTypeFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pnlContainer.Enabled = true;
            toolTypeModelBindingSource.AddNew();
            toolTypeModelBindingSource.MoveLast();
            txtToolType.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pnlContainer.Enabled = true;
            txtToolType.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                toolTypeBLL.Delete((toolTypeModelBindingSource.Current as ToolTypeModel).Id);
                toolTypeModelBindingSource.RemoveCurrent();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ToolTypeModel toolTypeModel = new ToolTypeModel();
            if (objState==EntityState.Changed)
            {
                toolTypeModel.Id = txtID.Text;
            }
            toolTypeModel.ToolType = txtToolType.Text;
            toolTypeBLL.Save(toolTypeModel,objState);
            pnlContainer.Enabled = false;
            objState = EntityState.Unchanged;
            ToolTypeFrm_Load(null, null);
        }

        private void ToolTypeFrm_Load(object sender, EventArgs e)
        {
            toolTypeModelBindingSource.DataSource = toolTypeBLL.GetAll();
        }
    }
}
