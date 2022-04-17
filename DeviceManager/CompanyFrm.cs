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
    public partial class CompanyFrm : Form
    {
        EntityState objState;
        CompanyBLL companyBLL = new CompanyBLL();
        public CompanyFrm()
        {
            InitializeComponent();
        }

        private void CompanyFrm_Load(object sender, EventArgs e)
        {
            companyModelBindingSource.DataSource = companyBLL.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            using (CompanyDetailFrm frm = new CompanyDetailFrm(objState))
            {
                frm.ShowDialog();
                CompanyFrm_Load(null,null);
            }
            objState = EntityState.Unchanged;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                companyBLL.Delete((companyModelBindingSource.Current as CompanyModel).Id);
                companyModelBindingSource.RemoveCurrent();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            using (CompanyDetailFrm frm = new CompanyDetailFrm(companyModelBindingSource.Current as CompanyModel, objState))
            {
                frm.ShowDialog();
                CompanyFrm_Load(null, null);
            }
            objState = EntityState.Unchanged;
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            companyModelBindingSource.DataSource = companyBLL.GetDataByFilter(cmbSearch.Text.Trim().ToLower()) ;
        }
    }
}
