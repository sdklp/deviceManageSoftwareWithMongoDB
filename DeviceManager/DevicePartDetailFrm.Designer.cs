
namespace DeviceManager
{
    partial class DevicePartDetailFrm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSubDevice = new System.Windows.Forms.ComboBox();
            this.devicePartModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDeviceModel = new System.Windows.Forms.TextBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.txtDeviceKKS = new System.Windows.Forms.TextBox();
            this.txtDeviceLocation = new System.Windows.Forms.TextBox();
            this.txtDeviceNo = new System.Windows.Forms.TextBox();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.btnSelectDevice = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSelectSparePart = new System.Windows.Forms.Button();
            this.cmbSparePartUnits = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSparePartNo = new System.Windows.Forms.TextBox();
            this.txtSparePartModel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSparePartQty = new System.Windows.Forms.TextBox();
            this.txtSparePartName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSparePartID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.chkContinue = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.txtDevicePartID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingSourceDevice = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSparePart = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicePartModelBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSparePart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSubDevice);
            this.groupBox2.Controls.Add(this.txtDeviceModel);
            this.groupBox2.Controls.Add(this.txtDeviceName);
            this.groupBox2.Controls.Add(this.txtDeviceKKS);
            this.groupBox2.Controls.Add(this.txtDeviceLocation);
            this.groupBox2.Controls.Add(this.txtDeviceNo);
            this.groupBox2.Controls.Add(this.txtDeviceID);
            this.groupBox2.Controls.Add(this.btnSelectDevice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 162);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device Information";
            // 
            // cmbSubDevice
            // 
            this.cmbSubDevice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "SubDevice", true));
            this.cmbSubDevice.FormattingEnabled = true;
            this.cmbSubDevice.Location = new System.Drawing.Point(534, 69);
            this.cmbSubDevice.Name = "cmbSubDevice";
            this.cmbSubDevice.Size = new System.Drawing.Size(198, 23);
            this.cmbSubDevice.TabIndex = 4;
            this.cmbSubDevice.DropDown += new System.EventHandler(this.cmbSubDevice_DropDown);
            // 
            // devicePartModelBindingSource
            // 
            this.devicePartModelBindingSource.DataSource = typeof(Models.DevicePartModel);
            // 
            // txtDeviceModel
            // 
            this.txtDeviceModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "DModel", true));
            this.txtDeviceModel.Enabled = false;
            this.txtDeviceModel.Location = new System.Drawing.Point(74, 104);
            this.txtDeviceModel.Name = "txtDeviceModel";
            this.txtDeviceModel.Size = new System.Drawing.Size(658, 25);
            this.txtDeviceModel.TabIndex = 3;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "DName", true));
            this.txtDeviceName.Enabled = false;
            this.txtDeviceName.Location = new System.Drawing.Point(74, 68);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(167, 25);
            this.txtDeviceName.TabIndex = 3;
            // 
            // txtDeviceKKS
            // 
            this.txtDeviceKKS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "DKKS", true));
            this.txtDeviceKKS.Enabled = false;
            this.txtDeviceKKS.Location = new System.Drawing.Point(295, 68);
            this.txtDeviceKKS.Name = "txtDeviceKKS";
            this.txtDeviceKKS.Size = new System.Drawing.Size(143, 25);
            this.txtDeviceKKS.TabIndex = 3;
            // 
            // txtDeviceLocation
            // 
            this.txtDeviceLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "Location", true));
            this.txtDeviceLocation.Enabled = false;
            this.txtDeviceLocation.Location = new System.Drawing.Point(391, 33);
            this.txtDeviceLocation.Name = "txtDeviceLocation";
            this.txtDeviceLocation.Size = new System.Drawing.Size(170, 25);
            this.txtDeviceLocation.TabIndex = 3;
            // 
            // txtDeviceNo
            // 
            this.txtDeviceNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "DNo", true));
            this.txtDeviceNo.Enabled = false;
            this.txtDeviceNo.Location = new System.Drawing.Point(605, 31);
            this.txtDeviceNo.Name = "txtDeviceNo";
            this.txtDeviceNo.Size = new System.Drawing.Size(127, 25);
            this.txtDeviceNo.TabIndex = 3;
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "Did", true));
            this.txtDeviceID.Enabled = false;
            this.txtDeviceID.Location = new System.Drawing.Point(74, 31);
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(220, 25);
            this.txtDeviceID.TabIndex = 3;
            // 
            // btnSelectDevice
            // 
            this.btnSelectDevice.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectDevice.Location = new System.Drawing.Point(750, 21);
            this.btnSelectDevice.Name = "btnSelectDevice";
            this.btnSelectDevice.Size = new System.Drawing.Size(65, 138);
            this.btnSelectDevice.TabIndex = 1;
            this.btnSelectDevice.Text = "Select";
            this.btnSelectDevice.UseVisualStyleBackColor = true;
            this.btnSelectDevice.Click += new System.EventHandler(this.btnSelectDevice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "SubDevice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "KKS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSelectSparePart);
            this.groupBox3.Controls.Add(this.cmbSparePartUnits);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtSparePartNo);
            this.groupBox3.Controls.Add(this.txtSparePartModel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSparePartQty);
            this.groupBox3.Controls.Add(this.txtSparePartName);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtSparePartID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(815, 162);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spare Part Information";
            // 
            // btnSelectSparePart
            // 
            this.btnSelectSparePart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectSparePart.Location = new System.Drawing.Point(747, 21);
            this.btnSelectSparePart.Name = "btnSelectSparePart";
            this.btnSelectSparePart.Size = new System.Drawing.Size(65, 138);
            this.btnSelectSparePart.TabIndex = 1;
            this.btnSelectSparePart.Text = "Select";
            this.btnSelectSparePart.UseVisualStyleBackColor = true;
            this.btnSelectSparePart.Click += new System.EventHandler(this.btnSelectSparePart_Click);
            // 
            // cmbSparePartUnits
            // 
            this.cmbSparePartUnits.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "Units", true));
            this.cmbSparePartUnits.FormattingEnabled = true;
            this.cmbSparePartUnits.Location = new System.Drawing.Point(611, 76);
            this.cmbSparePartUnits.Name = "cmbSparePartUnits";
            this.cmbSparePartUnits.Size = new System.Drawing.Size(121, 23);
            this.cmbSparePartUnits.TabIndex = 4;
            this.cmbSparePartUnits.DropDown += new System.EventHandler(this.cmbSparePartUnits_DropDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(550, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Units:";
            // 
            // txtSparePartNo
            // 
            this.txtSparePartNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "PNo", true));
            this.txtSparePartNo.Enabled = false;
            this.txtSparePartNo.Location = new System.Drawing.Point(407, 37);
            this.txtSparePartNo.Name = "txtSparePartNo";
            this.txtSparePartNo.Size = new System.Drawing.Size(122, 25);
            this.txtSparePartNo.TabIndex = 3;
            // 
            // txtSparePartModel
            // 
            this.txtSparePartModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "PModel", true));
            this.txtSparePartModel.Enabled = false;
            this.txtSparePartModel.Location = new System.Drawing.Point(74, 115);
            this.txtSparePartModel.Name = "txtSparePartModel";
            this.txtSparePartModel.Size = new System.Drawing.Size(455, 25);
            this.txtSparePartModel.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID:";
            // 
            // txtSparePartQty
            // 
            this.txtSparePartQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "Qty", true));
            this.txtSparePartQty.Location = new System.Drawing.Point(611, 115);
            this.txtSparePartQty.Name = "txtSparePartQty";
            this.txtSparePartQty.Size = new System.Drawing.Size(122, 25);
            this.txtSparePartQty.TabIndex = 3;
            // 
            // txtSparePartName
            // 
            this.txtSparePartName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "PName", true));
            this.txtSparePartName.Enabled = false;
            this.txtSparePartName.Location = new System.Drawing.Point(74, 75);
            this.txtSparePartName.Name = "txtSparePartName";
            this.txtSparePartName.Size = new System.Drawing.Size(455, 25);
            this.txtSparePartName.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(370, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(565, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Qty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name:";
            // 
            // txtSparePartID
            // 
            this.txtSparePartID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "Pid", true));
            this.txtSparePartID.Enabled = false;
            this.txtSparePartID.Location = new System.Drawing.Point(74, 37);
            this.txtSparePartID.Name = "txtSparePartID";
            this.txtSparePartID.Size = new System.Drawing.Size(278, 25);
            this.txtSparePartID.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Model:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Device Part ID:";
            // 
            // chkContinue
            // 
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(20, 12);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(125, 19);
            this.chkContinue.TabIndex = 1;
            this.chkContinue.Text = "Continue Add";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(353, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 35);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(498, 4);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 35);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // txtDevicePartID
            // 
            this.txtDevicePartID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "Id", true));
            this.txtDevicePartID.Enabled = false;
            this.txtDevicePartID.Location = new System.Drawing.Point(151, 30);
            this.txtDevicePartID.Name = "txtDevicePartID";
            this.txtDevicePartID.Size = new System.Drawing.Size(280, 25);
            this.txtDevicePartID.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 454);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Remark:";
            // 
            // txtRemark
            // 
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devicePartModelBindingSource, "Remark", true));
            this.txtRemark.Location = new System.Drawing.Point(86, 454);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(738, 78);
            this.txtRemark.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkContinue);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 557);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 43);
            this.panel1.TabIndex = 4;
            // 
            // bindingSourceDevice
            // 
            this.bindingSourceDevice.DataSource = typeof(Models.DeviceModel);
            // 
            // bindingSourceSparePart
            // 
            this.bindingSourceSparePart.DataSource = typeof(Models.SparePartModel);
            // 
            // DevicePartDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDevicePartID);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DevicePartDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevicePartDetailFrm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicePartModelBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSparePart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSubDevice;
        private System.Windows.Forms.TextBox txtDeviceModel;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtDeviceKKS;
        private System.Windows.Forms.TextBox txtDeviceNo;
        private System.Windows.Forms.TextBox txtDeviceID;
        private System.Windows.Forms.Button btnSelectDevice;
        private System.Windows.Forms.Button btnSelectSparePart;
        private System.Windows.Forms.ComboBox cmbSparePartUnits;
        private System.Windows.Forms.TextBox txtSparePartNo;
        private System.Windows.Forms.TextBox txtSparePartModel;
        private System.Windows.Forms.TextBox txtSparePartQty;
        private System.Windows.Forms.TextBox txtSparePartName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSparePartID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkContinue;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox txtDevicePartID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDeviceLocation;
        private System.Windows.Forms.BindingSource devicePartModelBindingSource;
        private System.Windows.Forms.BindingSource bindingSourceDevice;
        private System.Windows.Forms.BindingSource bindingSourceSparePart;
    }
}