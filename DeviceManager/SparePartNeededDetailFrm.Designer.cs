
namespace DeviceManager
{
    partial class SparePartNeededDetailFrm
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
            this.chkContinue = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.sparePartNeededModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sparePartNeededBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSparePartUnits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSubDevice = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeviceModel = new System.Windows.Forms.TextBox();
            this.txtKKS = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtDeviceNo = new System.Windows.Forms.TextBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelectDevice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectSparePart = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSparePartModel = new System.Windows.Forms.TextBox();
            this.txtSparePartID = new System.Windows.Forms.TextBox();
            this.txtSparePartQty = new System.Windows.Forms.TextBox();
            this.txtSparePartNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSparePartName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbKeepItems = new System.Windows.Forms.ComboBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpRelease = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpRequire = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.bindingSourceDevice = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSparePart = new System.Windows.Forms.BindingSource(this.components);
            this.tvwSubDevice = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartNeededModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartNeededBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSparePart)).BeginInit();
            this.SuspendLayout();
            // 
            // chkContinue
            // 
            this.chkContinue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(22, 14);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(125, 19);
            this.chkContinue.TabIndex = 0;
            this.chkContinue.Text = "Continue Add";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(288, 1);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 42);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "DeviceID", true));
            this.txtDeviceID.Enabled = false;
            this.txtDeviceID.Location = new System.Drawing.Point(104, 47);
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(199, 25);
            this.txtDeviceID.TabIndex = 3;
            // 
            // sparePartNeededModelBindingSource
            // 
            this.sparePartNeededModelBindingSource.DataSource = typeof(Models.SparePartNeededModel);
            // 
            // cmbSparePartUnits
            // 
            this.cmbSparePartUnits.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "Units", true));
            this.cmbSparePartUnits.FormattingEnabled = true;
            this.cmbSparePartUnits.Location = new System.Drawing.Point(104, 141);
            this.cmbSparePartUnits.Name = "cmbSparePartUnits";
            this.cmbSparePartUnits.Size = new System.Drawing.Size(199, 23);
            this.cmbSparePartUnits.TabIndex = 1;
            this.cmbSparePartUnits.DropDown += new System.EventHandler(this.cmbSparePartUnits_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbSubDevice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDeviceModel);
            this.groupBox1.Controls.Add(this.txtKKS);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.txtDeviceNo);
            this.groupBox1.Controls.Add(this.txtDeviceName);
            this.groupBox1.Controls.Add(this.txtDeviceID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnSelectDevice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Location:";
            // 
            // cmbSubDevice
            // 
            this.cmbSubDevice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "SubDevice", true));
            this.cmbSubDevice.DropDownHeight = 1;
            this.cmbSubDevice.FormattingEnabled = true;
            this.cmbSubDevice.IntegralHeight = false;
            this.cmbSubDevice.ItemHeight = 15;
            this.cmbSubDevice.Location = new System.Drawing.Point(521, 147);
            this.cmbSubDevice.Name = "cmbSubDevice";
            this.cmbSubDevice.Size = new System.Drawing.Size(156, 23);
            this.cmbSubDevice.TabIndex = 1;
            this.cmbSubDevice.DropDown += new System.EventHandler(this.cmbSubDevice_DropDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "SubDevice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            // 
            // txtDeviceModel
            // 
            this.txtDeviceModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "DeviceModel", true));
            this.txtDeviceModel.Enabled = false;
            this.txtDeviceModel.Location = new System.Drawing.Point(374, 101);
            this.txtDeviceModel.Name = "txtDeviceModel";
            this.txtDeviceModel.Size = new System.Drawing.Size(304, 25);
            this.txtDeviceModel.TabIndex = 9;
            // 
            // txtKKS
            // 
            this.txtKKS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "DeviceKKS", true));
            this.txtKKS.Enabled = false;
            this.txtKKS.Location = new System.Drawing.Point(104, 96);
            this.txtKKS.Name = "txtKKS";
            this.txtKKS.Size = new System.Drawing.Size(203, 25);
            this.txtKKS.TabIndex = 7;
            // 
            // txtLocation
            // 
            this.txtLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "DeviceLocation", true));
            this.txtLocation.Enabled = false;
            this.txtLocation.Location = new System.Drawing.Point(104, 146);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(126, 25);
            this.txtLocation.TabIndex = 11;
            // 
            // txtDeviceNo
            // 
            this.txtDeviceNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "DeviceNo", true));
            this.txtDeviceNo.Enabled = false;
            this.txtDeviceNo.Location = new System.Drawing.Point(276, 146);
            this.txtDeviceNo.Name = "txtDeviceNo";
            this.txtDeviceNo.Size = new System.Drawing.Size(129, 25);
            this.txtDeviceNo.TabIndex = 13;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "DeviceName", true));
            this.txtDeviceName.Enabled = false;
            this.txtDeviceName.Location = new System.Drawing.Point(373, 47);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(305, 25);
            this.txtDeviceName.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "KKS:";
            // 
            // btnSelectDevice
            // 
            this.btnSelectDevice.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectDevice.Location = new System.Drawing.Point(697, 21);
            this.btnSelectDevice.Name = "btnSelectDevice";
            this.btnSelectDevice.Size = new System.Drawing.Size(75, 173);
            this.btnSelectDevice.TabIndex = 0;
            this.btnSelectDevice.Text = "Select";
            this.btnSelectDevice.UseVisualStyleBackColor = true;
            this.btnSelectDevice.Click += new System.EventHandler(this.btnSelectDevice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectSparePart);
            this.groupBox2.Controls.Add(this.cmbSparePartUnits);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSparePartModel);
            this.groupBox2.Controls.Add(this.txtSparePartID);
            this.groupBox2.Controls.Add(this.txtSparePartQty);
            this.groupBox2.Controls.Add(this.txtSparePartNo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSparePartName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 187);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spare Part Information";
            // 
            // btnSelectSparePart
            // 
            this.btnSelectSparePart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectSparePart.Location = new System.Drawing.Point(697, 21);
            this.btnSelectSparePart.Name = "btnSelectSparePart";
            this.btnSelectSparePart.Size = new System.Drawing.Size(75, 163);
            this.btnSelectSparePart.TabIndex = 0;
            this.btnSelectSparePart.Text = "Select";
            this.btnSelectSparePart.UseVisualStyleBackColor = true;
            this.btnSelectSparePart.Click += new System.EventHandler(this.btnSelectSparePart_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(311, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Model:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "Units:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "ID:";
            // 
            // txtSparePartModel
            // 
            this.txtSparePartModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "SparePartModel", true));
            this.txtSparePartModel.Enabled = false;
            this.txtSparePartModel.Location = new System.Drawing.Point(372, 98);
            this.txtSparePartModel.Name = "txtSparePartModel";
            this.txtSparePartModel.Size = new System.Drawing.Size(306, 25);
            this.txtSparePartModel.TabIndex = 10;
            // 
            // txtSparePartID
            // 
            this.txtSparePartID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "SparePartID", true));
            this.txtSparePartID.Enabled = false;
            this.txtSparePartID.Location = new System.Drawing.Point(104, 44);
            this.txtSparePartID.Name = "txtSparePartID";
            this.txtSparePartID.Size = new System.Drawing.Size(199, 25);
            this.txtSparePartID.TabIndex = 4;
            // 
            // txtSparePartQty
            // 
            this.txtSparePartQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "Qty", true));
            this.txtSparePartQty.Location = new System.Drawing.Point(372, 139);
            this.txtSparePartQty.Name = "txtSparePartQty";
            this.txtSparePartQty.Size = new System.Drawing.Size(128, 25);
            this.txtSparePartQty.TabIndex = 2;
            // 
            // txtSparePartNo
            // 
            this.txtSparePartNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "SparePartNo", true));
            this.txtSparePartNo.Enabled = false;
            this.txtSparePartNo.Location = new System.Drawing.Point(104, 93);
            this.txtSparePartNo.Name = "txtSparePartNo";
            this.txtSparePartNo.Size = new System.Drawing.Size(199, 25);
            this.txtSparePartNo.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(327, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Qty:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(319, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Name:";
            // 
            // txtSparePartName
            // 
            this.txtSparePartName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "SparePartName", true));
            this.txtSparePartName.Enabled = false;
            this.txtSparePartName.Location = new System.Drawing.Point(372, 44);
            this.txtSparePartName.Name = "txtSparePartName";
            this.txtSparePartName.Size = new System.Drawing.Size(306, 25);
            this.txtSparePartName.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "No:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbKeepItems);
            this.panel1.Controls.Add(this.chkContinue);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 703);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 45);
            this.panel1.TabIndex = 3;
            // 
            // cmbKeepItems
            // 
            this.cmbKeepItems.FormattingEnabled = true;
            this.cmbKeepItems.Items.AddRange(new object[] {
            "Keep None",
            "Keep Document Infor"});
            this.cmbKeepItems.Location = new System.Drawing.Point(620, 14);
            this.cmbKeepItems.Name = "cmbKeepItems";
            this.cmbKeepItems.Size = new System.Drawing.Size(192, 23);
            this.cmbKeepItems.TabIndex = 3;
            this.cmbKeepItems.Text = "Keep None";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(437, 1);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(102, 42);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpRelease);
            this.groupBox3.Controls.Add(this.cmbStatus);
            this.groupBox3.Controls.Add(this.dtpRequire);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtRemark);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtDocID);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Location = new System.Drawing.Point(22, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 215);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Document Information";
            // 
            // dtpRelease
            // 
            this.dtpRelease.CustomFormat = " ";
            this.dtpRelease.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "ReleaseDate", true));
            this.dtpRelease.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRelease.Location = new System.Drawing.Point(584, 90);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(162, 25);
            this.dtpRelease.TabIndex = 3;
            this.dtpRelease.ValueChanged += new System.EventHandler(this.dtpRelease_ValueChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "Status", true));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(441, 48);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(305, 23);
            this.cmbStatus.TabIndex = 0;
            this.cmbStatus.DropDown += new System.EventHandler(this.cmbStatus_DropDown);
            // 
            // dtpRequire
            // 
            this.dtpRequire.CustomFormat = " ";
            this.dtpRequire.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "RequireDate", true));
            this.dtpRequire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRequire.Location = new System.Drawing.Point(312, 90);
            this.dtpRequire.Name = "dtpRequire";
            this.dtpRequire.Size = new System.Drawing.Size(149, 25);
            this.dtpRequire.TabIndex = 2;
            this.dtpRequire.ValueChanged += new System.EventHandler(this.dtpRequire_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "Remark:";
            // 
            // txtRemark
            // 
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "Remark", true));
            this.txtRemark.Location = new System.Drawing.Point(83, 135);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(663, 57);
            this.txtRemark.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(372, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 15);
            this.label19.TabIndex = 7;
            this.label19.Text = "Status:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(497, 95);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 15);
            this.label18.TabIndex = 9;
            this.label18.Text = "Released:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(227, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 15);
            this.label17.TabIndex = 9;
            this.label17.Text = "Required:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 15);
            this.label16.TabIndex = 8;
            this.label16.Text = "Doc ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // txtDocID
            // 
            this.txtDocID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "DocID", true));
            this.txtDocID.Location = new System.Drawing.Point(83, 90);
            this.txtDocID.Name = "txtDocID";
            this.txtDocID.Size = new System.Drawing.Size(129, 25);
            this.txtDocID.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartNeededModelBindingSource, "ID", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(83, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(272, 25);
            this.txtID.TabIndex = 6;
            // 
            // bindingSourceDevice
            // 
            this.bindingSourceDevice.DataSource = typeof(Models.DeviceModel);
            // 
            // bindingSourceSparePart
            // 
            this.bindingSourceSparePart.DataSource = typeof(Models.SparePartModel);
            // 
            // tvwSubDevice
            // 
            this.tvwSubDevice.Location = new System.Drawing.Point(533, 437);
            this.tvwSubDevice.Name = "tvwSubDevice";
            this.tvwSubDevice.Size = new System.Drawing.Size(157, 240);
            this.tvwSubDevice.TabIndex = 4;
            this.tvwSubDevice.Visible = false;
            this.tvwSubDevice.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwSubDevice_BeforeExpand);
            this.tvwSubDevice.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // SparePartNeededDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 748);
            this.Controls.Add(this.tvwSubDevice);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SparePartNeededDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SparePartNeededDetailFrm";
            ((System.ComponentModel.ISupportInitialize)(this.sparePartNeededModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartNeededBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSparePart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkContinue;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDeviceID;
        private System.Windows.Forms.ComboBox cmbSparePartUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSubDevice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeviceModel;
        private System.Windows.Forms.TextBox txtKKS;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtDeviceNo;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelectDevice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectSparePart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSparePartModel;
        private System.Windows.Forms.TextBox txtSparePartID;
        private System.Windows.Forms.TextBox txtSparePartQty;
        private System.Windows.Forms.TextBox txtSparePartNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSparePartName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpRelease;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpRequire;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.BindingSource sparePartNeededBindingSource;
        private System.Windows.Forms.BindingSource bindingSourceDevice;
        private System.Windows.Forms.BindingSource bindingSourceSparePart;
        private System.Windows.Forms.BindingSource sparePartNeededModelBindingSource;
        private System.Windows.Forms.ComboBox cmbKeepItems;
        private System.Windows.Forms.TreeView tvwSubDevice;
    }
}