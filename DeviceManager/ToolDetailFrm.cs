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
    public partial class ToolDetailFrm : Form
    {
        EntityState objState;
        ToolBLL toolBLL = new ToolBLL();
        public ToolDetailFrm()
        {
            InitializeComponent();
        }
        public ToolDetailFrm(EntityState entityState)
        {
            InitializeComponent();
            objState = entityState;
            toolModelBindingSource.AddNew();
            toolModelBindingSource.MoveLast();
        }
        public ToolDetailFrm(ToolModel toolModel,EntityState entityState)
        {
            InitializeComponent();
            objState = entityState;
            toolModelBindingSource.DataSource = toolModel;
        }
        private void ToolDetailFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            toolBLL.Save(toolModelBindingSource.Current as ToolModel,objState);
            MessageBox.Show("Successful");
            ContinueAddSwitch();
        }
        private void ContinueAddSwitch()
        {
            if (chkContinue.Checked)
            {
                toolModelBindingSource.AddNew();
                toolModelBindingSource.MoveLast();
                txtName.Focus();
            }
            else
            {
                this.Close();
            }
        }

        private void cmbUnits_DropDown(object sender, EventArgs e)
        {
            UnitsBLL unitsBLL = new UnitsBLL();
            cmbUnits.DataSource = unitsBLL.GetAll();
            cmbUnits.DisplayMember = "Units";
        }

        private void cmbType_DropDown(object sender, EventArgs e)
        {
            ToolTypeBLL toolTypeBLL = new ToolTypeBLL();
            cmbType.DataSource = toolTypeBLL.GetAll();
            cmbType.DisplayMember = "ToolType";
        }
    }
}
