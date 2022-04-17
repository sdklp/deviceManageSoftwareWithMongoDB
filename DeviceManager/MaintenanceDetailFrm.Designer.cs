
namespace DeviceManager
{
    partial class MaintenanceDetailFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.maintenanceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.txtPTW = new System.Windows.Forms.TextBox();
            this.cmbAP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectDevice = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSubDevice = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtDeviceNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDeviceModel = new System.Windows.Forms.TextBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.txtDeviceKKS = new System.Windows.Forms.TextBox();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSelectFaultLib = new System.Windows.Forms.Button();
            this.btnAddFaultLib = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDealWithSummary = new System.Windows.Forms.TextBox();
            this.txtDealWithDetail = new System.Windows.Forms.TextBox();
            this.txtFaultSummary = new System.Windows.Forms.TextBox();
            this.txtFaultDetail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkContinue = new System.Windows.Forms.CheckBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbKeepItem = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRemrk = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.bindingSourceDevice = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceModelBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDetail);
            this.groupBox1.Controls.Add(this.txtPTW);
            this.groupBox1.Controls.Add(this.cmbAP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PTW";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = " ";
            this.dtpEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "EndDate", true));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(511, 16);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(135, 25);
            this.dtpEnd.TabIndex = 2;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // maintenanceModelBindingSource
            // 
            this.maintenanceModelBindingSource.DataSource = typeof(Models.MaintenanceModel);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = " ";
            this.dtpStart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "StartDate", true));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(296, 16);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(135, 25);
            this.dtpStart.TabIndex = 1;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Detail:";
            // 
            // txtDetail
            // 
            this.txtDetail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "Detail", true));
            this.txtDetail.Location = new System.Drawing.Point(80, 58);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(1011, 56);
            this.txtDetail.TabIndex = 4;
            // 
            // txtPTW
            // 
            this.txtPTW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "PTW", true));
            this.txtPTW.Location = new System.Drawing.Point(84, 16);
            this.txtPTW.Name = "txtPTW";
            this.txtPTW.Size = new System.Drawing.Size(145, 25);
            this.txtPTW.TabIndex = 0;
            // 
            // cmbAP
            // 
            this.cmbAP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "AP", true));
            this.cmbAP.FormattingEnabled = true;
            this.cmbAP.Location = new System.Drawing.Point(701, 17);
            this.cmbAP.Name = "cmbAP";
            this.cmbAP.Size = new System.Drawing.Size(184, 23);
            this.cmbAP.TabIndex = 3;
            this.cmbAP.DropDown += new System.EventHandler(this.cmbAP_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "AP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "End:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "No:";
            // 
            // btnSelectDevice
            // 
            this.btnSelectDevice.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectDevice.Location = new System.Drawing.Point(1052, 21);
            this.btnSelectDevice.Name = "btnSelectDevice";
            this.btnSelectDevice.Size = new System.Drawing.Size(65, 76);
            this.btnSelectDevice.TabIndex = 0;
            this.btnSelectDevice.Text = "Select";
            this.btnSelectDevice.UseVisualStyleBackColor = true;
            this.btnSelectDevice.Click += new System.EventHandler(this.btnSelectDevice_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectDevice);
            this.groupBox2.Controls.Add(this.cmbSubDevice);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtLocation);
            this.groupBox2.Controls.Add(this.txtDeviceNo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDeviceModel);
            this.groupBox2.Controls.Add(this.txtDeviceName);
            this.groupBox2.Controls.Add(this.txtDeviceKKS);
            this.groupBox2.Controls.Add(this.txtDeviceID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1120, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device";
            // 
            // cmbSubDevice
            // 
            this.cmbSubDevice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "SubDevice", true));
            this.cmbSubDevice.FormattingEnabled = true;
            this.cmbSubDevice.Location = new System.Drawing.Point(844, 63);
            this.cmbSubDevice.Name = "cmbSubDevice";
            this.cmbSubDevice.Size = new System.Drawing.Size(195, 23);
            this.cmbSubDevice.TabIndex = 1;
            this.cmbSubDevice.DropDown += new System.EventHandler(this.cmbSubDevice_DropDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(751, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "SubDevice:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Location:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "KKS:";
            // 
            // txtLocation
            // 
            this.txtLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "DeviceLocation", true));
            this.txtLocation.Enabled = false;
            this.txtLocation.Location = new System.Drawing.Point(95, 62);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(182, 25);
            this.txtLocation.TabIndex = 3;
            // 
            // txtDeviceNo
            // 
            this.txtDeviceNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "DeviceNo", true));
            this.txtDeviceNo.Enabled = false;
            this.txtDeviceNo.Location = new System.Drawing.Point(336, 62);
            this.txtDeviceNo.Name = "txtDeviceNo";
            this.txtDeviceNo.Size = new System.Drawing.Size(164, 25);
            this.txtDeviceNo.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Model:";
            // 
            // txtDeviceModel
            // 
            this.txtDeviceModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "DeviceModel", true));
            this.txtDeviceModel.Enabled = false;
            this.txtDeviceModel.Location = new System.Drawing.Point(754, 22);
            this.txtDeviceModel.Name = "txtDeviceModel";
            this.txtDeviceModel.Size = new System.Drawing.Size(285, 25);
            this.txtDeviceModel.TabIndex = 3;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "DeviceName", true));
            this.txtDeviceName.Enabled = false;
            this.txtDeviceName.Location = new System.Drawing.Point(402, 22);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(278, 25);
            this.txtDeviceName.TabIndex = 3;
            // 
            // txtDeviceKKS
            // 
            this.txtDeviceKKS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "DeviceKKS", true));
            this.txtDeviceKKS.Enabled = false;
            this.txtDeviceKKS.Location = new System.Drawing.Point(562, 62);
            this.txtDeviceKKS.Name = "txtDeviceKKS";
            this.txtDeviceKKS.Size = new System.Drawing.Size(160, 25);
            this.txtDeviceKKS.TabIndex = 3;
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "DeviceId", true));
            this.txtDeviceID.Enabled = false;
            this.txtDeviceID.Location = new System.Drawing.Point(95, 22);
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(248, 25);
            this.txtDeviceID.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(349, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSelectFaultLib);
            this.groupBox3.Controls.Add(this.btnAddFaultLib);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtDealWithSummary);
            this.groupBox3.Controls.Add(this.txtDealWithDetail);
            this.groupBox3.Controls.Add(this.txtFaultSummary);
            this.groupBox3.Controls.Add(this.txtFaultDetail);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(12, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1111, 241);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detail";
            // 
            // btnSelectFaultLib
            // 
            this.btnSelectFaultLib.Location = new System.Drawing.Point(1052, 147);
            this.btnSelectFaultLib.Name = "btnSelectFaultLib";
            this.btnSelectFaultLib.Size = new System.Drawing.Size(39, 38);
            this.btnSelectFaultLib.TabIndex = 4;
            this.btnSelectFaultLib.Text = "...";
            this.btnSelectFaultLib.UseVisualStyleBackColor = true;
            // 
            // btnAddFaultLib
            // 
            this.btnAddFaultLib.Location = new System.Drawing.Point(1052, 84);
            this.btnAddFaultLib.Name = "btnAddFaultLib";
            this.btnAddFaultLib.Size = new System.Drawing.Size(39, 38);
            this.btnAddFaultLib.TabIndex = 4;
            this.btnAddFaultLib.Text = "+";
            this.btnAddFaultLib.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 165);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 15);
            this.label19.TabIndex = 2;
            this.label19.Text = "DealWith Detail:";
            // 
            // txtDealWithSummary
            // 
            this.txtDealWithSummary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "DealWithSummary", true));
            this.txtDealWithSummary.Location = new System.Drawing.Point(161, 128);
            this.txtDealWithSummary.Name = "txtDealWithSummary";
            this.txtDealWithSummary.Size = new System.Drawing.Size(561, 25);
            this.txtDealWithSummary.TabIndex = 2;
            // 
            // txtDealWithDetail
            // 
            this.txtDealWithDetail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "DealWithDetail", true));
            this.txtDealWithDetail.Location = new System.Drawing.Point(161, 166);
            this.txtDealWithDetail.Multiline = true;
            this.txtDealWithDetail.Name = "txtDealWithDetail";
            this.txtDealWithDetail.Size = new System.Drawing.Size(878, 56);
            this.txtDealWithDetail.TabIndex = 3;
            // 
            // txtFaultSummary
            // 
            this.txtFaultSummary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "FaultSummary", true));
            this.txtFaultSummary.Location = new System.Drawing.Point(161, 24);
            this.txtFaultSummary.Name = "txtFaultSummary";
            this.txtFaultSummary.Size = new System.Drawing.Size(561, 25);
            this.txtFaultSummary.TabIndex = 0;
            // 
            // txtFaultDetail
            // 
            this.txtFaultDetail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "FaultDetail", true));
            this.txtFaultDetail.Location = new System.Drawing.Point(161, 60);
            this.txtFaultDetail.Multiline = true;
            this.txtFaultDetail.Name = "txtFaultDetail";
            this.txtFaultDetail.Size = new System.Drawing.Size(878, 56);
            this.txtFaultDetail.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Fault Detail:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "DealWith Summary:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "Fault Summary:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 15);
            this.label20.TabIndex = 2;
            this.label20.Text = "ID:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "Remark:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkContinue);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.cmbKeepItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 734);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 48);
            this.panel1.TabIndex = 1;
            // 
            // chkContinue
            // 
            this.chkContinue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(12, 16);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(125, 19);
            this.chkContinue.TabIndex = 1;
            this.chkContinue.Text = "Continue Add";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(651, 3);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 42);
            this.btnCancle.TabIndex = 0;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(528, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 42);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbKeepItem
            // 
            this.cmbKeepItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbKeepItem.FormattingEnabled = true;
            this.cmbKeepItem.Items.AddRange(new object[] {
            "Keep None",
            "Keep PTW"});
            this.cmbKeepItem.Location = new System.Drawing.Point(147, 14);
            this.cmbKeepItem.Name = "cmbKeepItem";
            this.cmbKeepItem.Size = new System.Drawing.Size(246, 23);
            this.cmbKeepItem.TabIndex = 0;
            this.cmbKeepItem.Text = "Keep None";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtRemrk);
            this.groupBox4.Controls.Add(this.txtID);
            this.groupBox4.Location = new System.Drawing.Point(12, 547);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1111, 155);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Maintenance";
            // 
            // txtRemrk
            // 
            this.txtRemrk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "Remark", true));
            this.txtRemrk.Location = new System.Drawing.Point(99, 76);
            this.txtRemrk.Multiline = true;
            this.txtRemrk.Name = "txtRemrk";
            this.txtRemrk.Size = new System.Drawing.Size(992, 58);
            this.txtRemrk.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maintenanceModelBindingSource, "Id", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(102, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(241, 25);
            this.txtID.TabIndex = 3;
            // 
            // bindingSourceDevice
            // 
            this.bindingSourceDevice.DataSource = typeof(Models.DeviceModel);
            // 
            // MaintenanceDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 782);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaintenanceDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MintenanceDetailFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceModelBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDevice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectDevice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkContinue;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbKeepItem;
        private System.Windows.Forms.TextBox txtFaultSummary;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.TextBox txtPTW;
        private System.Windows.Forms.ComboBox cmbAP;
        private System.Windows.Forms.TextBox txtDeviceNo;
        private System.Windows.Forms.TextBox txtDeviceKKS;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtDeviceModel;
        private System.Windows.Forms.TextBox txtDeviceID;
        private System.Windows.Forms.ComboBox cmbSubDevice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtDealWithSummary;
        private System.Windows.Forms.TextBox txtDealWithDetail;
        private System.Windows.Forms.TextBox txtFaultDetail;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtRemrk;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSelectFaultLib;
        private System.Windows.Forms.Button btnAddFaultLib;
        private System.Windows.Forms.BindingSource maintenanceModelBindingSource;
        private System.Windows.Forms.BindingSource bindingSourceDevice;
    }
}