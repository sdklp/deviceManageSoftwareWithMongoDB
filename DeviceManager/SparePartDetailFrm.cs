using BLL;
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



namespace DeviceManager
{
    public partial class SparePartDetailFrm : Form
    {
        private EntityState objState;
        SparePartBLL sBLL = new SparePartBLL();

        public SparePartDetailFrm()
        {
            InitializeComponent();
        }

        public SparePartDetailFrm(EntityState entityState)
        {
            InitializeComponent();            
            this.objState = entityState;
           
            if (this.objState==EntityState.Added)
            {               
                sparePartModelBindingSource.AddNew();
                sparePartModelBindingSource.MoveLast();
            }
            

        }
        public SparePartDetailFrm(SparePartModel sparePart,EntityState entityState)
        {
            InitializeComponent();
            this.objState = entityState;
            if (entityState==EntityState.Changed)
            {
                sparePartModelBindingSource.DataSource = sparePart;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            sBLL.Save(sparePartModelBindingSource.Current as SparePartModel, objState);
            ContinueAddSwitch();
        }
        private void ContinueAddSwitch()
        {
            txtID.Text = null;
            if (chkContinue.Checked)
            {
                sparePartModelBindingSource.AddNew();
                sparePartModelBindingSource.MoveLast();
                return;
            }
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbUnits_DropDown(object sender, EventArgs e)
        {
            UnitsBLL unitsBLL = new UnitsBLL();
            cmbUnits.DataSource = unitsBLL.GetAll();
            cmbUnits.DisplayMember = "Units";
        }

        private void cmbManufacturer_DropDown(object sender, EventArgs e)
        {
            CompanyBLL companyBLL = new CompanyBLL();
            cmbManufacturer.DataSource = companyBLL.GetAllCompany();
            cmbManufacturer.DisplayMember = "CompanyName";
        }

        private void cmbAgency_DropDown(object sender, EventArgs e)
        {
            CompanyBLL companyBLL = new CompanyBLL();
            cmbAgency.DataSource = companyBLL.GetAllAgency();
            cmbAgency.DisplayMember= "CompanyName";
        }
    }
}
