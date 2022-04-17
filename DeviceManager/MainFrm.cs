using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libs;


namespace DeviceManager
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void deviceFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<DeviceFrm>(splMain.Panel2, this);
        }

        private void sparePartFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<SparePartFrm>(splMain.Panel2, this);
        }

        private void devicePartRelateFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<DevicePartFrm>(splMain.Panel2, this);
        }

        private void maintenanceFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<MaintenanceFrm>(splMain.Panel2, this);
        }

        private void bulkMaintenanceFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (BulkMaintenanceFrm frm = new BulkMaintenanceFrm())
            {
                frm.ShowDialog();
            }
        }

        private void sparePartNeededFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<SparePartNeededFrm>(splMain.Panel2, this);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            MainFrm_Resize(null, null);//DBHelper.GetConnectionState();
        }

        private void connectionSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ConnectionSetupFrm sFrm = new ConnectionSetupFrm())
            {
                sFrm.ShowDialog();
            }
        }

        private void sparePartChangedFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<SparePartChangedFrm>(splMain.Panel2, this);
        }

        

        private void localSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (LocationSetupFrm frm = new LocationSetupFrm())
            {
                frm.ShowDialog();
            }
        }

        private void unitsSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (UnitsSetupFrm frm = new UnitsSetupFrm())
            {
                frm.ShowDialog();
            }
        }

        private void addressSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddressFrm frm = new AddressFrm())
            {
                frm.ShowDialog();
            }
        }

        private void companyFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<CompanyFrm>(splMain.Panel2, this);
        }

        private void phoneBookFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<PhoneBookFrm>(splMain.Panel2, this);
        }
        
        private void MainFrm_Resize(object sender, EventArgs e)
        {
           pnlHome.Left=( splMain.Panel2.Width - pnlHome.Width)/2;
            pnlHome.Top = (splMain.Panel2.Height - pnlHome.Height) / 2;
        }

        private void toolFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<ToolFrm>(splMain.Panel2, this);
        }

        private void apSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ApFrm frm=new ApFrm())
            {
                frm.ShowDialog();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlHome.BringToFront();
        }

        private void toolLendRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewForm newForm = new ShowNewForm();
            newForm.ShowForm<ToolLendRecordFrm>(splMain.Panel2, this);
        }

        private void databaseBackupRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (BackupRestoreFrm brFrm = new BackupRestoreFrm())
            {
                brFrm.ShowDialog();
            }
        }

        private void toolTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ToolTypeFrm frm = new ToolTypeFrm())
            {
                frm.ShowDialog();
            }
        }

        private void deviceStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DeviceStatusFrm frm = new DeviceStatusFrm())
            {
                frm.ShowDialog();
            }
        }

        private void sparePartNeededStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SparePartNeededStatusFrm frm = new SparePartNeededStatusFrm())
            {
                frm.ShowDialog();
            }
            
        }

        private void subDeviceSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SubDeviceFrm frm = new SubDeviceFrm())
            {
                frm.ShowDialog();
            }
        }
    }
}
