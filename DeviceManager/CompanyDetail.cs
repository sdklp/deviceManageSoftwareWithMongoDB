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
    public partial class CompanyDetailFrm : Form
    {
        EntityState objState;
        CompanyBLL companyBLL = new CompanyBLL();
        CompanyModel company;
        AddressBLL addressBLL = new AddressBLL();
        
        public CompanyDetailFrm()
        {
            InitializeComponent();
        }
        public CompanyDetailFrm(EntityState entityState)
        {
            InitializeComponent();
            objState = entityState;
            companyModelBindingSource.AddNew();
            companyModelBindingSource.MoveLast();
        }
        public CompanyDetailFrm(CompanyModel companyModel,EntityState entityState)
        {
            InitializeComponent();
            objState = entityState;
            this.company = companyModel;
            companyModelBindingSource.DataSource = companyModel;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                companyBLL.Save(companyModelBindingSource.Current as CompanyModel, objState);
                MessageBox.Show("Successful");
                ContinueAddSwitch();
            }
            catch (Exception)
            {

                //throw;
            }
            
        }
        private void ContinueAddSwitch()
        {
            if (chkContinue.Checked)
            {
                companyModelBindingSource.AddNew();
                companyModelBindingSource.MoveLast();
            }
            else
            {
                this.Close();
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (AddressFrm frm = new AddressFrm())
            {
                frm.ShowDialog();
            }
        }

        private void cmbCountry_DropDown(object sender, EventArgs e)
        {
            cmbCountry.DataSource = addressBLL.GetDataByPid("abcdefghabcdefghabcdefgh");
            cmbCountry.DisplayMember = "Name";
            
        }

        private void cmbProvince_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (addressBLL.GetDataByName(cmbCountry.Text).Count>0)
                {
                    cmbProvince.DataSource = addressBLL.GetDataByPid(addressBLL.GetDataByName(cmbCountry.Text)[0].Id);
                    cmbProvince.DisplayMember = "Name";
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

       

        private void cmbCity_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (addressBLL.GetDataByName(cmbProvince.Text).Count > 0)
                {
                    cmbCity.DataSource = addressBLL.GetDataByPid(addressBLL.GetDataByName(cmbProvince.Text)[0].Id);
                    cmbCity.DisplayMember = "Name";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbCounty_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (addressBLL.GetDataByName(cmbCity.Text).Count > 0)
                {
                    cmbCounty.DataSource = addressBLL.GetDataByPid(addressBLL.GetDataByName(cmbCity.Text)[0].Id);
                    cmbCounty.DisplayMember = "Name";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
