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
    public partial class SparePartFrm : Form
    {
        EntityState objState;
        SparePartBLL sBLL = new SparePartBLL();
        SparePartBalanceBLL spbBLL = new SparePartBalanceBLL();
        public SparePartFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            using (SparePartDetailFrm sFrm = new SparePartDetailFrm(objState))
            {
                sFrm.ShowDialog();
                SparePartFrm_Load(null,null);


            }
            objState = EntityState.Unchanged;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            using (SparePartDetailFrm sFrm = new SparePartDetailFrm(sparePartModelBindingSource.Current as SparePartModel,objState))
            {
                sFrm.ShowDialog();
            }
            objState = EntityState.Unchanged;
        }

        private void SparePartFrm_Load(object sender, EventArgs e)
        {
            sparePartModelBindingSource.DataSource = sBLL.GetAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          sparePartModelBindingSource.DataSource=sBLL.GetDataByFilter(cmbSearch.Text.ToLower());
        }

        private void cmbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                btnSearch_Click(null,null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure delete this record", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                objState =EntityState.Deleted;
                sBLL.Delete((sparePartModelBindingSource.Current as SparePartModel).Id,objState);
                sparePartModelBindingSource.RemoveCurrent();
                objState = EntityState.Unchanged;
            }
        }

        private void btnDevicePart_Click(object sender, EventArgs e)
        {
            using (DevicePartRelatedFrm frm = new DevicePartRelatedFrm(sparePartModelBindingSource.Current as SparePartModel))
            {
                frm.ShowDialog();
            }
        }

        private void btnPutIn_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            using (SparePartBalanceFrm frm = new SparePartBalanceFrm(sparePartModelBindingSource.Current as SparePartModel, "In", objState))
            {
                frm.ShowDialog();
                SparePartFrm_Load(null, null);
            }
            objState = EntityState.Unchanged;
        }

        private void btnPutOut_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            using (SparePartBalanceFrm frm = new SparePartBalanceFrm(sparePartModelBindingSource.Current as SparePartModel, "Out", objState))
            {
                frm.ShowDialog();
                SparePartFrm_Load(null, null);
            }
            objState = EntityState.Unchanged;
        }

        private void dgvSparePart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDownSide();
        }

        private void LoadDownSide()
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Balance":
                    dgvBalance.DataSource = spbBLL.GetDataByPid((sparePartModelBindingSource.Current as SparePartModel).Id);
                    break;
                default:
                    break;
            }
        }
    }
}
