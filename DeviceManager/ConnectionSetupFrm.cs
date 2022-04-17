using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Libs;
using System.IO;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security;

namespace DeviceManager
{
    public partial class ConnectionSetupFrm : Form
    {
        public ConnectionSetupFrm()
        {
            InitializeComponent();
        }

        private void ConnectionSetupFrm_Load(object sender, EventArgs e)
        {

        }
        public void UpdateConnectionStringsConfig(string newName, string newConString)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration sysconfig = ConfigurationManager.OpenExeConfiguration(file);
            bool exist = false;
            if (sysconfig.ConnectionStrings.ConnectionStrings[newName] != null)
            {
                exist = true;
            }
            if (exist)
            {
                sysconfig.ConnectionStrings.ConnectionStrings.Remove(newName);
            }
            ConnectionStringSettings mySettings =
                new ConnectionStringSettings(newName, newConString);
            sysconfig.ConnectionStrings.ConnectionStrings.Add(mySettings);
            sysconfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("ConnectionStrings");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UpdateConnectionStringsConfig("connStr", txtConnectionStr.Text.Trim());
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtConnectionStr.Text = null;
        }
    }
}
