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
    public partial class SparePartSelectFrm : Form
    {
        public SparePartModel sparePartInfor { get {return sparePartModelBindingSource.Current as SparePartModel; }}
        public SparePartSelectFrm()
        {
            InitializeComponent();
        }

        private void SparePartSelectFrm_Load(object sender, EventArgs e)
        {
            SparePartBLL sparePartBLL = new SparePartBLL();
            sparePartModelBindingSource.DataSource = sparePartBLL.GetAll();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
