
namespace DeviceManager
{
    partial class DeviceDetailFrm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.deviceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtKKS = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbPid = new System.Windows.Forms.ComboBox();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.cmbAgency = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.chkContinue = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(319, 613);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceModelBindingSource, "Id", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(142, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(264, 25);
            this.txtID.TabIndex = 14;
            // 
            // deviceModelBindingSource
            // 
            this.deviceModelBindingSource.DataSource = typeof(Models.DeviceModel);
            // 
            // cmbLocation
            // 
            this.cmbLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceModelBindingSource, "Location", true));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(142, 172);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(264, 23);
            this.cmbLocation.TabIndex = 2;
            this.cmbLocation.DropDown += new System.EventHandler(this.cmbLocation_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "KKS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Manufacturer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Agency:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 502);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Remark:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "ParentId:";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceModelBindingSource, "DName", true));
            this.txtName.Location = new System.Drawing.Point(142, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(576, 25);
            this.txtName.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceModelBindingSource, "DModel", true));
            this.txtModel.Location = new System.Drawing.Point(142, 124);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(576, 25);
            this.txtModel.TabIndex = 1;
            // 
            // txtNo
            // 
            this.txtNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceModelBindingSource, "DNo", true));
            this.txtNo.Location = new System.Drawing.Point(142, 216);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(264, 25);
            this.txtNo.TabIndex = 3;
            // 
            // txtKKS
            // 
            this.txtKKS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceModelBindingSource, "DKKS", true));
            this.txtKKS.Location = new System.Drawing.Point(142, 264);
            this.txtKKS.Name = "txtKKS";
            this.txtKKS.Size = new System.Drawing.Size(264, 25);
            this.txtKKS.TabIndex = 4;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceModelBindingSource, "DStatus", true));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(142, 312);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(264, 23);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.DropDown += new System.EventHandler(this.cmbStatus_DropDown);
            // 
            // cmbPid
            // 
            this.cmbPid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceModelBindingSource, "Pid", true));
            this.cmbPid.FormattingEnabled = true;
            this.cmbPid.Location = new System.Drawing.Point(142, 358);
            this.cmbPid.Name = "cmbPid";
            this.cmbPid.Size = new System.Drawing.Size(264, 23);
            this.cmbPid.TabIndex = 6;
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceModelBindingSource, "Manufacturer", true));
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(142, 404);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(576, 23);
            this.cmbManufacturer.TabIndex = 7;
            this.cmbManufacturer.DropDown += new System.EventHandler(this.cmbManufacturer_DropDown);
            // 
            // cmbAgency
            // 
            this.cmbAgency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceModelBindingSource, "Agency", true));
            this.cmbAgency.FormattingEnabled = true;
            this.cmbAgency.Location = new System.Drawing.Point(142, 450);
            this.cmbAgency.Name = "cmbAgency";
            this.cmbAgency.Size = new System.Drawing.Size(576, 23);
            this.cmbAgency.TabIndex = 8;
            this.cmbAgency.DropDown += new System.EventHandler(this.cmbAgency_DropDown);
            // 
            // txtRemark
            // 
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceModelBindingSource, "DRemark", true));
            this.txtRemark.Location = new System.Drawing.Point(142, 504);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(576, 87);
            this.txtRemark.TabIndex = 9;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(437, 613);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 33);
            this.btnCancle.TabIndex = 11;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(437, 172);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(281, 209);
            this.treeView1.TabIndex = 12;
            this.treeView1.Visible = false;
            // 
            // chkContinue
            // 
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(27, 621);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(125, 19);
            this.chkContinue.TabIndex = 25;
            this.chkContinue.Text = "Continue Add";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // DeviceDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 670);
            this.Controls.Add(this.chkContinue);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.cmbAgency);
            this.Controls.Add(this.cmbManufacturer);
            this.Controls.Add(this.cmbPid);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtKKS);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceDetailFrm";
            this.Load += new System.EventHandler(this.DeviceDetailFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtKKS;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbPid;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.ComboBox cmbAgency;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.BindingSource deviceModelBindingSource;
        private System.Windows.Forms.CheckBox chkContinue;
    }
}