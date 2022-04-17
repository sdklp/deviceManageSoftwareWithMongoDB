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
    public partial class ToolLendDetailFrm : Form
    {
        ToolModel toolModel = new ToolModel();
        string method;
        EntityState objState;
        ToolLendModel initialToolLendModel;
        public int qty { get { return string.IsNullOrEmpty(txtQty.Text)==true?0: Convert.ToInt32(txtQty.Text); } }
        public ToolLendDetailFrm()
        {
            InitializeComponent();
        }
        public ToolLendDetailFrm(ToolModel tool, string method)
        {
            InitializeComponent();
            toolModel = tool;
            txtToolId.Text = toolModel.Id;
            txtToolName.Text = toolModel.Name;
            txtToolModel.Text = toolModel.Model;
            this.method = method;
            rdbReturn.Visible = false;
            rdbLend.Checked = true;
            objState = EntityState.Added;

        }
        public ToolLendDetailFrm(ToolLendModel toolLend, string method)
        {
            InitializeComponent();
            initialToolLendModel = toolLend;
            this.method = method;
            rdbLend.Visible = false;
            rdbReturn.Checked = true;
            toolLendModelBindingSource.DataSource = toolLend;
            objState = EntityState.Changed;

        }
        private void InitializeDataBings()
        {
            if (method=="Lend")
            {
               
            }
        }
        private void ToolLendDetailFrm_Load(object sender, EventArgs e)
        {


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ToolLendModel toolLendModel = new ToolLendModel();
            if (method=="Lend")
            {
                toolLendModel.LendDate = dtpDate.Text;
                toolLendModel.LendPerson = cmbPerson.Text;
                toolLendModel.LendQty =string.IsNullOrEmpty(txtQty.Text)==true?0: Convert.ToInt32(txtQty.Text);
                toolLendModel.DiffQty = toolLendModel.LendQty;
            }
            if (method=="Return")
            {
                toolLendModel.Id = txtID.Text;

                toolLendModel.LendDate = initialToolLendModel.LendDate;
                toolLendModel.LendPerson = initialToolLendModel.LendPerson;
                toolLendModel.LendQty = initialToolLendModel.LendQty;

                toolLendModel.ReturnDate = dtpDate.Text;
                toolLendModel.ReturnPerson = cmbPerson.Text;
                toolLendModel.ReturnQty = string.IsNullOrEmpty(txtQty.Text) == true ? 0 : Convert.ToInt32(txtQty.Text);
                toolLendModel.DiffQty =initialToolLendModel.DiffQty- toolLendModel.ReturnQty;
            }

            toolLendModel.ToolId = txtToolId.Text;
            toolLendModel.ToolModel = txtToolModel.Text;
            toolLendModel.ToolName = txtToolName.Text;
            toolLendModel.Units = cmbUnits.Text;
            toolLendModel.Remark = txtRemark.Text;
            
            ToolLendBLL toolLendBLL = new ToolLendBLL();            
            toolLendBLL.Save(toolLendModel, objState);

            ToolLendModel lendModel = new ToolLendModel();
            if (method=="Return")
            {
                lendModel.ReturnDate = dtpDate.Text;
                lendModel.ReturnPerson = cmbPerson.Text;
                lendModel.ReturnQty = string.IsNullOrEmpty(txtQty.Text) == true ? 0 : Convert.ToInt32(txtQty.Text);

                lendModel.ToolId = txtToolId.Text;
                lendModel.ToolModel = txtToolModel.Text;
                lendModel.ToolName = txtToolName.Text;
                lendModel.Units = cmbUnits.Text;
                lendModel.Remark = txtRemark.Text;
                MessageBox.Show("Test");
                toolLendBLL.Save(lendModel, EntityState.Added);
            }            
            MessageBox.Show("Successful");
            this.Close();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDate.CustomFormat = "yyyy-MM-dd";
            dtpDate.Checked = false;
        }

        private void dtpDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete|e.KeyCode==Keys.Back)
            {
                dtpDate.CustomFormat = " ";
                dtpDate.Checked = false;
            }
        }

        private void cmbPerson_DropDown(object sender, EventArgs e)
        {
            ApBLL ap = new ApBLL();
            cmbPerson.DataSource = ap.GetAll();
            cmbPerson.DisplayMember = "Name";
        }

        private void cmbUnits_DropDown(object sender, EventArgs e)
        {
            UnitsBLL unitsBLL = new UnitsBLL();
            cmbUnits.DataSource = unitsBLL.GetAll();
            cmbUnits.DisplayMember = "Units";
        }
    }
}
