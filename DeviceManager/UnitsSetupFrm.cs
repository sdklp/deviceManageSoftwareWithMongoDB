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
    public partial class UnitsSetupFrm : Form
    {
        EntityState objState;
        UnitsBLL unitsBLL = new UnitsBLL();
        UnitsModel obj = new UnitsModel();
        public UnitsSetupFrm()
        {
            InitializeComponent();
        }

        private void UnitsSetupFrm_Load(object sender, EventArgs e)
        {
            unitsModelBindingSource.DataSource = unitsBLL.GetAll();
        }

        private void btnAddUnits_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            txtUnits.Enabled = true;
            unitsModelBindingSource.AddNew();
            unitsModelBindingSource.MoveLast();
           
            txtUnits.Focus();
        }

        private void btnSaveUnits_Click(object sender, EventArgs e)
        {
            obj.Id = txtID.Text;
            obj.Units = txtUnits.Text;
            unitsBLL.Save(obj, objState);
            objState = EntityState.Unchanged;
            txtUnits.Enabled = false;
            UnitsSetupFrm_Load(null, null);
        }

        private void btnEditUnits_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            txtUnits.Enabled = true;
            txtUnits.Focus();
        }

        private void dgvUnits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingSourceUnits.DataSource = unitsModelBindingSource.Current as UnitsModel;
        }

        private void btnDeleteUnits_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                unitsBLL.Delete((unitsModelBindingSource.Current as UnitsModel).Id);
                unitsModelBindingSource.RemoveCurrent();
            }
        }

        private void btnCancleUnits_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtUnits.Text = null;
        }
    }
}
