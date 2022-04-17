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
    public partial class ToolLendRecordFrm : Form
    {
        ToolLendBLL toolLendBLL = new ToolLendBLL();
        
        public ToolLendRecordFrm()
        {
            InitializeComponent();
        }

        private void ToolLendRecordFrm_Load(object sender, EventArgs e)
        {
            toolLendModelBindingSource.DataSource = toolLendBLL.GetAll();
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            toolLendModelBindingSource.DataSource = toolLendBLL.GetDataByFilter(txtSearch.Text.Trim().ToLower()) ;
        }
    }
}
