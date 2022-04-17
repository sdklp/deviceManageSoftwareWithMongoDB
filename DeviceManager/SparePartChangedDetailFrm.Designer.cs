
namespace DeviceManager
{
    partial class SparePartChangedDetailFrm
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
            this.btnSelectSparePart = new System.Windows.Forms.Button();
            this.chkContinue = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.sparePartChangedModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDeviceLocation = new System.Windows.Forms.TextBox();
            this.txtDeviceNo = new System.Windows.Forms.TextBox();
            this.txtDeviceKKS = new System.Windows.Forms.TextBox();
            this.txtDeviceModel = new System.Windows.Forms.TextBox();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.cmbSubDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSelectDevice = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSparePartID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtSparePartModel = new System.Windows.Forms.TextBox();
            this.txtSparePartName = new System.Windows.Forms.TextBox();
            this.txtSparePartNo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbKeepItem = new System.Windows.Forms.ComboBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.bindingSourceDevice = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSparePart = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartChangedModelBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSparePart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectSparePart
            // 
            this.btnSelectSparePart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectSparePart.Location = new System.Drawing.Point(851, 21);
            this.btnSelectSparePart.Name = "btnSelectSparePart";
            this.btnSelectSparePart.Size = new System.Drawing.Size(65, 107);
            this.btnSelectSparePart.TabIndex = 0;
            this.btnSelectSparePart.Text = "Select";
            this.btnSelectSparePart.UseVisualStyleBackColor = true;
            this.btnSelectSparePart.Click += new System.EventHandler(this.btnSelectSparePart_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDeviceName);
            this.groupBox1.Controls.Add(this.txtDeviceLocation);
            this.groupBox1.Controls.Add(this.txtDeviceNo);
            this.groupBox1.Controls.Add(this.txtDeviceKKS);
            this.groupBox1.Controls.Add(this.txtDeviceModel);
            this.groupBox1.Controls.Add(this.txtDeviceID);
            this.groupBox1.Controls.Add(this.cmbSubDevice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnSelectDevice);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "KKS:";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "DeviceNo", true));
            this.txtDeviceName.Enabled = false;
            this.txtDeviceName.Location = new System.Drawing.Point(346, 89);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(187, 25);
            this.txtDeviceName.TabIndex = 4;
            // 
            // sparePartChangedModelBindingSource
            // 
            this.sparePartChangedModelBindingSource.DataSource = typeof(Models.SparePartChangedModel);
            // 
            // txtDeviceLocation
            // 
            this.txtDeviceLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "DeviceLocation", true));
            this.txtDeviceLocation.Enabled = false;
            this.txtDeviceLocation.Location = new System.Drawing.Point(91, 89);
            this.txtDeviceLocation.Name = "txtDeviceLocation";
            this.txtDeviceLocation.Size = new System.Drawing.Size(179, 25);
            this.txtDeviceLocation.TabIndex = 4;
            // 
            // txtDeviceNo
            // 
            this.txtDeviceNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "DeviceKKS", true));
            this.txtDeviceNo.Enabled = false;
            this.txtDeviceNo.Location = new System.Drawing.Point(689, 33);
            this.txtDeviceNo.Name = "txtDeviceNo";
            this.txtDeviceNo.Size = new System.Drawing.Size(146, 25);
            this.txtDeviceNo.TabIndex = 4;
            // 
            // txtDeviceKKS
            // 
            this.txtDeviceKKS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "DeviceModel", true));
            this.txtDeviceKKS.Enabled = false;
            this.txtDeviceKKS.Location = new System.Drawing.Point(468, 33);
            this.txtDeviceKKS.Name = "txtDeviceKKS";
            this.txtDeviceKKS.Size = new System.Drawing.Size(158, 25);
            this.txtDeviceKKS.TabIndex = 4;
            // 
            // txtDeviceModel
            // 
            this.txtDeviceModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "DeviceName", true));
            this.txtDeviceModel.Enabled = false;
            this.txtDeviceModel.Location = new System.Drawing.Point(226, 33);
            this.txtDeviceModel.Name = "txtDeviceModel";
            this.txtDeviceModel.Size = new System.Drawing.Size(178, 25);
            this.txtDeviceModel.TabIndex = 4;
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "Did", true));
            this.txtDeviceID.Enabled = false;
            this.txtDeviceID.Location = new System.Drawing.Point(54, 33);
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(100, 25);
            this.txtDeviceID.TabIndex = 4;
            // 
            // cmbSubDevice
            // 
            this.cmbSubDevice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "SubDevice", true));
            this.cmbSubDevice.FormattingEnabled = true;
            this.cmbSubDevice.Location = new System.Drawing.Point(671, 90);
            this.cmbSubDevice.Name = "cmbSubDevice";
            this.cmbSubDevice.Size = new System.Drawing.Size(164, 23);
            this.cmbSubDevice.TabIndex = 2;
            this.cmbSubDevice.DropDown += new System.EventHandler(this.cmbSubDevice_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Model:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Location:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "No:";
            // 
            // btnSelectDevice
            // 
            this.btnSelectDevice.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectDevice.Location = new System.Drawing.Point(851, 21);
            this.btnSelectDevice.Name = "btnSelectDevice";
            this.btnSelectDevice.Size = new System.Drawing.Size(65, 119);
            this.btnSelectDevice.TabIndex = 0;
            this.btnSelectDevice.Text = "Select";
            this.btnSelectDevice.UseVisualStyleBackColor = true;
            this.btnSelectDevice.Click += new System.EventHandler(this.btnSelectDevice_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(570, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "SubDevice:";
            // 
            // txtSparePartID
            // 
            this.txtSparePartID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "Pid", true));
            this.txtSparePartID.Enabled = false;
            this.txtSparePartID.Location = new System.Drawing.Point(67, 38);
            this.txtSparePartID.Name = "txtSparePartID";
            this.txtSparePartID.Size = new System.Drawing.Size(161, 25);
            this.txtSparePartID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Remark:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(652, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "Qty:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(424, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "Units:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.txtSparePartModel);
            this.groupBox2.Controls.Add(this.txtSparePartName);
            this.groupBox2.Controls.Add(this.txtSparePartNo);
            this.groupBox2.Controls.Add(this.txtSparePartID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cmbUnits);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnSelectSparePart);
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(919, 131);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spare Part";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "No:";
            // 
            // txtQty
            // 
            this.txtQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "Qty", true));
            this.txtQty.Location = new System.Drawing.Point(707, 84);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(128, 25);
            this.txtQty.TabIndex = 4;
            // 
            // txtSparePartModel
            // 
            this.txtSparePartModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "SparePartModel", true));
            this.txtSparePartModel.Enabled = false;
            this.txtSparePartModel.Location = new System.Drawing.Point(67, 84);
            this.txtSparePartModel.Name = "txtSparePartModel";
            this.txtSparePartModel.Size = new System.Drawing.Size(350, 25);
            this.txtSparePartModel.TabIndex = 4;
            // 
            // txtSparePartName
            // 
            this.txtSparePartName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "SparePartName", true));
            this.txtSparePartName.Enabled = false;
            this.txtSparePartName.Location = new System.Drawing.Point(304, 38);
            this.txtSparePartName.Name = "txtSparePartName";
            this.txtSparePartName.Size = new System.Drawing.Size(320, 25);
            this.txtSparePartName.TabIndex = 4;
            // 
            // txtSparePartNo
            // 
            this.txtSparePartNo.Enabled = false;
            this.txtSparePartNo.Location = new System.Drawing.Point(671, 38);
            this.txtSparePartNo.Name = "txtSparePartNo";
            this.txtSparePartNo.Size = new System.Drawing.Size(161, 25);
            this.txtSparePartNo.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "Model:";
            // 
            // cmbUnits
            // 
            this.cmbUnits.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "Units", true));
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(484, 85);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(164, 23);
            this.cmbUnits.TabIndex = 2;
            this.cmbUnits.DropDown += new System.EventHandler(this.cmbUnits_DropDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkContinue);
            this.panel1.Controls.Add(this.cmbKeepItem);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 56);
            this.panel1.TabIndex = 7;
            // 
            // cmbKeepItem
            // 
            this.cmbKeepItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbKeepItem.FormattingEnabled = true;
            this.cmbKeepItem.Items.AddRange(new object[] {
            "Keep None",
            "Keep Device",
            "Keep Spare Part"});
            this.cmbKeepItem.Location = new System.Drawing.Point(143, 14);
            this.cmbKeepItem.Name = "cmbKeepItem";
            this.cmbKeepItem.Size = new System.Drawing.Size(221, 23);
            this.cmbKeepItem.TabIndex = 2;
            this.cmbKeepItem.Text = "Keep None";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(618, 9);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(94, 38);
            this.btnCancle.TabIndex = 0;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(489, 9);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 38);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "ID", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(84, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(156, 25);
            this.txtID.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = " ";
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "ChangedDate", true));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(319, 22);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(148, 25);
            this.dtpDate.TabIndex = 8;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtRemark
            // 
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartChangedModelBindingSource, "Remark", true));
            this.txtRemark.Location = new System.Drawing.Point(84, 73);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(844, 46);
            this.txtRemark.TabIndex = 4;
            // 
            // bindingSourceDevice
            // 
            this.bindingSourceDevice.DataSource = typeof(Models.DeviceModel);
            // 
            // bindingSourceSparePart
            // 
            this.bindingSourceSparePart.DataSource = typeof(Models.SparePartModel);
            // 
            // SparePartChangedDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 508);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SparePartChangedDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SparePartChangedDetailFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartChangedModelBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSparePart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectSparePart;
        private System.Windows.Forms.CheckBox chkContinue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtDeviceLocation;
        private System.Windows.Forms.TextBox txtDeviceNo;
        private System.Windows.Forms.TextBox txtDeviceKKS;
        private System.Windows.Forms.TextBox txtDeviceModel;
        private System.Windows.Forms.TextBox txtDeviceID;
        private System.Windows.Forms.ComboBox cmbSubDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSelectDevice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSparePartID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtSparePartModel;
        private System.Windows.Forms.TextBox txtSparePartName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbKeepItem;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.BindingSource sparePartChangedModelBindingSource;
        private System.Windows.Forms.BindingSource bindingSourceDevice;
        private System.Windows.Forms.BindingSource bindingSourceSparePart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSparePartNo;
    }
}