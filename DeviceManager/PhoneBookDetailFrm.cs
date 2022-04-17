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
    public partial class PhoneBookDetailFrm : Form
    {
        EntityState objState;
        PhoneBookModel phoneBook = new PhoneBookModel();
        PhoneBookBLL phoneBookBLL = new PhoneBookBLL();
        CompanyBLL companyBLL = new CompanyBLL();
        public PhoneBookDetailFrm()
        {
            InitializeComponent();
        }
        public PhoneBookDetailFrm(EntityState entityState)
        {
            InitializeComponent();
            objState = entityState;
            phoneBookModelBindingSource.AddNew();
            phoneBookModelBindingSource.MoveLast();
        }
        public PhoneBookDetailFrm(PhoneBookModel phoneBookModel,EntityState entityState)
        {
            InitializeComponent();
            objState = entityState;
            phoneBook = phoneBookModel;
            phoneBookModelBindingSource.DataSource = phoneBookModel;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                phoneBookBLL.Save(phoneBookModelBindingSource.Current as PhoneBookModel, objState);
                MessageBox.Show("Successful");
                ContinueAddSwitch();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        private void ContinueAddSwitch()
        {
            if (chkContinue.Checked)
            {
                phoneBookModelBindingSource.AddNew();
                phoneBookModelBindingSource.MoveLast();
               
            }
            else
            {
                this.Close();
            }
        }
        private void cmbCompany_DropDown(object sender, EventArgs e)
        {
            cmbCompany.DataSource = companyBLL.GetAll();
            cmbCompany.DisplayMember = "CompanyName";
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            using (CompanyDetailFrm frm = new CompanyDetailFrm())
            {
                frm.ShowDialog();
            }
        }
    }
}
