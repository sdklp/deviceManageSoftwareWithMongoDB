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
    public partial class PhoneBookFrm : Form
    {
        EntityState objState;
        PhoneBookBLL phoneBookBLL = new PhoneBookBLL();
        public PhoneBookFrm()
        {
            InitializeComponent();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            using (PhoneBookDetailFrm frm = new PhoneBookDetailFrm(objState))
            {
                frm.ShowDialog();
                PhoneBookFrm_Load(null, null);
               
            }
            objState = EntityState.Unchanged;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objState = EntityState.Changed;
            using (PhoneBookDetailFrm frm = new PhoneBookDetailFrm(phoneBookModelBindingSource.Current as PhoneBookModel,objState))
            {
                frm.ShowDialog();
                PhoneBookFrm_Load(null, null);

            }
            objState = EntityState.Unchanged;
        }

        private void PhoneBookFrm_Load(object sender, EventArgs e)
        {
            phoneBookModelBindingSource.DataSource = phoneBookBLL.GetAll();
        }
    }
}
