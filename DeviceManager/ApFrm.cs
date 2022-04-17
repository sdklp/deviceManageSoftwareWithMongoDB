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
    public partial class ApFrm : Form
    {
        ApBLL apBLL = new ApBLL();
        EntityState objState;
        
        public ApFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pnlContainer.Enabled = true;
            apModelBindingSource.AddNew();
            apModelBindingSource.MoveLast();
            txtName.Focus();
            dtpNex.CustomFormat = " ";
            dtpNex.Checked = false;
            dtpIdExpire.CustomFormat = " ";
            dtpIdExpire.Checked = false;
            dtpIqamaExport.CustomFormat = " ";
            dtpIqamaExport.Checked = false;
            dtpReturn.CustomFormat = " ";
            dtpReturn.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                apBLL.Delete((apModelBindingSource.Current as ApModel).Id);
                apModelBindingSource.RemoveCurrent();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            pnlContainer.Enabled = true;
            txtName.Focus();
        }

        private void dtpIdExpire_ValueChanged(object sender, EventArgs e)
        {
            dtpIdExpire.CustomFormat = "yyyy-MM-dd";
            dtpIdExpire.Checked = false;
        }

        private void dtpIdExpire_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Back|e.KeyCode==Keys.Delete)
            {
                dtpIdExpire.CustomFormat = " ";
                dtpIdExpire.Checked = false;
            }
        }

        private void dtpIqamaExport_ValueChanged(object sender, EventArgs e)
        {
            dtpIqamaExport.CustomFormat = "yyyy-MM-dd";
            dtpIqamaExport.Checked = false;
        }

        private void dtpIqamaExport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back | e.KeyCode == Keys.Delete)
            {
                dtpIqamaExport.CustomFormat = " ";
                dtpIqamaExport.Checked = false;
            }
        }

        private void dtpReturn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back | e.KeyCode == Keys.Delete)
            {
                dtpReturn.CustomFormat = " ";
                dtpReturn.Checked = false;
            }
        }

        private void dtpNex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back | e.KeyCode == Keys.Delete)
            {

            }
        }

        private void dtpReturn_ValueChanged(object sender, EventArgs e)
        {
            dtpReturn.CustomFormat = "yyyy-MM-dd";
            dtpReturn.Checked = false;
            if (!string.IsNullOrWhiteSpace(txtPeriod.Text.Trim()))
            {
                //dtpNex.Text =Convert.ToDateTime (dtpReturn.Text + Convert.ToInt32(txtPeriod.Text));
            }
        }

        private void dtpNex_ValueChanged(object sender, EventArgs e)
        {
            
            dtpNex.CustomFormat = "yyyy-MM-dd";
            dtpNex.Checked = false;
        }

        private void txtPeriod_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(dtpReturn.Text))
            {
                //dtpNex.Text = (dtpReturn.Text + Convert.ToInt32(txtPeriod.Text)).ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            apBLL.Save(apModelBindingSource.Current as ApModel, objState);
            MessageBox.Show("Successful");
            pnlContainer.Enabled = false;
            objState = EntityState.Unchanged;
        }

        private void ApFrm_Load(object sender, EventArgs e)
        {
            apModelBindingSource.DataSource = apBLL.GetAll();
            InitializeDateTimePicker();


        }
       private void InitializeDateTimePicker()
        {
            if ((apModelBindingSource.Current as ApModel).IdExpireDate == " " | string.IsNullOrEmpty((apModelBindingSource.Current as ApModel).IdExpireDate) == true)
            {
                dtpIdExpire.CustomFormat = " ";
                dtpIdExpire.Checked = false;
            }
            if ((apModelBindingSource.Current as ApModel).IqamaExpireDate == " " | string.IsNullOrEmpty((apModelBindingSource.Current as ApModel).IqamaExpireDate) == true)
            {
                dtpIqamaExport.CustomFormat = " ";
                dtpIqamaExport.Checked = false;
            }
            if ((apModelBindingSource.Current as ApModel).ReturnDate == " " | string.IsNullOrEmpty((apModelBindingSource.Current as ApModel).ReturnDate) == true)
            {
                dtpReturn.CustomFormat = " ";
                dtpReturn.Checked = false;
            }
            if ((apModelBindingSource.Current as ApModel).NexVacationDate == " " | string.IsNullOrEmpty((apModelBindingSource.Current as ApModel).NexVacationDate) == true)
            {
                dtpNex.CustomFormat = " ";
                dtpNex.Checked = false;
            }
        }
        private void dgvAp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            InitializeDateTimePicker();
        }
    }
}
