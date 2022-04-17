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
    public partial class DeviceSelectFrm : Form
    {
        public DeviceModel deviceInfor { get { return deviceModelBindingSource.Current as DeviceModel; } }
        public DeviceSelectFrm()
        {
            InitializeComponent();
        }

        private void DeviceSelectFrm_Load(object sender, EventArgs e)
        {
            DeviceBLL deviceBLL = new DeviceBLL();
            deviceModelBindingSource.DataSource = deviceBLL.GetAll();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
