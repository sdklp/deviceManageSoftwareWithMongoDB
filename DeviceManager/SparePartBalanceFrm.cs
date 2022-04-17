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
    public partial class SparePartBalanceFrm : Form
    {
        SparePartModel sparePart = new SparePartModel();
        SparePartBalanceBLL sparePartBalanceBLL = new SparePartBalanceBLL();
        SparePartBLL sparePartBLL = new SparePartBLL();
        string inOut;
        EntityState objState;
        public SparePartBalanceFrm()
        {
            InitializeComponent();
        }
        public SparePartBalanceFrm(SparePartModel sparePartModel,string inOut,EntityState entityState)
        {
            InitializeComponent();
            this.sparePart = sparePartModel;
            this.inOut = inOut;
            this.objState = entityState;
            txtPid.Text = sparePartModel.Id;
            if (inOut=="In")
            {
                rdbPutIn.Checked = true;
                rdbPutOut.Visible = false;
            }
            if (inOut=="Out")
            {
                rdbPutOut.Checked = true;
                rdbPutIn.Visible = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SparePartBalanceModel obj = new SparePartBalanceModel();
            obj.Pid = txtPid.Text;
            obj.Person = cmbPerson.Text;
            obj.Qty = string.IsNullOrEmpty(txtQty.Text.Trim()) == true ? 0 : Convert.ToInt32(txtQty.Text.Trim());
            obj.Remark = txtRemark.Text;
            obj.Date = dtpDate.Text;
            obj.Units = cmbUnits.Text;
            obj.InOut = rdbPutIn.Checked == true ? "In" : "Out";
            sparePartBalanceBLL.Save(obj,objState);
            if (rdbPutIn.Checked)
            {
                sparePart.Balance = sparePart.Balance + obj.Qty;
            }
            if (rdbPutOut.Checked)
            {
                sparePart.Balance = sparePart.Balance - obj.Qty;
            }
            sparePartBLL.Save(sparePart,EntityState.Changed);
            MessageBox.Show("Successful");
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
            PhoneBookBLL phoneBookBLL = new PhoneBookBLL();
            cmbPerson.DataSource = phoneBookBLL.GetAll();
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
