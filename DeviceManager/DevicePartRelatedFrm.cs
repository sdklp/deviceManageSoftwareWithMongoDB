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
    public partial class DevicePartRelatedFrm : Form
    {
        DeviceBLL deviceBLL = new DeviceBLL();
        SparePartModel sparePart = new SparePartModel();
        EntityState objState = EntityState.Unchanged;
        public DevicePartRelatedFrm()
        {
            InitializeComponent();
           
        }
        public DevicePartRelatedFrm(SparePartModel sparePart)
        {
            InitializeComponent();
            this.sparePart = sparePart;
            sparePartModelBindingSource.DataSource = sparePart;
        }
        private void DevicePartDetailFrm_Load(object sender, EventArgs e)
        {
            deviceModelBindingSource.DataSource = deviceBLL.GetAll();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            using (DevicePartDetailFrm detailFrm = new DevicePartDetailFrm(deviceModelBindingSource.Current as DeviceModel,sparePart,objState))
            {
                detailFrm.ShowDialog();
            }
            objState = EntityState.Unchanged;
        }
    }
}
