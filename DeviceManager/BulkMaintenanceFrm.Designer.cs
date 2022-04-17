
namespace DeviceManager
{
    partial class BulkMaintenanceFrm
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
            this.clbItems = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkContinue = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbKeepItem = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.dNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPTW = new System.Windows.Forms.TextBox();
            this.cmbAP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.btnAddDeviceList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clbItems
            // 
            this.clbItems.CheckOnClick = true;
            this.clbItems.FormattingEnabled = true;
            this.clbItems.Items.AddRange(new object[] {
            "AHU",
            "EF"});
            this.clbItems.Location = new System.Drawing.Point(541, 381);
            this.clbItems.MultiColumn = true;
            this.clbItems.Name = "clbItems";
            this.clbItems.Size = new System.Drawing.Size(584, 244);
            this.clbItems.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.chkContinue);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.cmbKeepItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 631);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 58);
            this.panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(265, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(265, 58);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkContinue
            // 
            this.chkContinue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(1005, 15);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(125, 19);
            this.chkContinue.TabIndex = 5;
            this.chkContinue.Text = "Continue Add";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSubmit.Location = new System.Drawing.Point(0, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(265, 58);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbKeepItem
            // 
            this.cmbKeepItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbKeepItem.FormattingEnabled = true;
            this.cmbKeepItem.Items.AddRange(new object[] {
            "Keep None",
            "Keep PTW"});
            this.cmbKeepItem.Location = new System.Drawing.Point(741, 13);
            this.cmbKeepItem.Name = "cmbKeepItem";
            this.cmbKeepItem.Size = new System.Drawing.Size(248, 23);
            this.cmbKeepItem.TabIndex = 6;
            this.cmbKeepItem.Text = "Keep None";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDevice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 631);
            this.panel2.TabIndex = 2;
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AutoGenerateColumns = false;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.dNoDataGridViewTextBoxColumn});
            this.dgvDevice.DataSource = this.deviceModelBindingSource;
            this.dgvDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevice.Location = new System.Drawing.Point(0, 0);
            this.dgvDevice.MultiSelect = false;
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowHeadersWidth = 51;
            this.dgvDevice.RowTemplate.Height = 27;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(530, 631);
            this.dgvDevice.TabIndex = 1;
            // 
            // dNameDataGridViewTextBoxColumn
            // 
            this.dNameDataGridViewTextBoxColumn.DataPropertyName = "DName";
            this.dNameDataGridViewTextBoxColumn.HeaderText = "DName";
            this.dNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNameDataGridViewTextBoxColumn.Name = "dNameDataGridViewTextBoxColumn";
            this.dNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // dNoDataGridViewTextBoxColumn
            // 
            this.dNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dNoDataGridViewTextBoxColumn.DataPropertyName = "DNo";
            this.dNoDataGridViewTextBoxColumn.HeaderText = "DNo";
            this.dNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNoDataGridViewTextBoxColumn.Name = "dNoDataGridViewTextBoxColumn";
            // 
            // deviceModelBindingSource
            // 
            this.deviceModelBindingSource.DataSource = typeof(Models.DeviceModel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "PTW:";
            // 
            // txtPTW
            // 
            this.txtPTW.Location = new System.Drawing.Point(627, 16);
            this.txtPTW.Name = "txtPTW";
            this.txtPTW.Size = new System.Drawing.Size(193, 25);
            this.txtPTW.TabIndex = 4;
            // 
            // cmbAP
            // 
            this.cmbAP.FormattingEnabled = true;
            this.cmbAP.Location = new System.Drawing.Point(627, 153);
            this.cmbAP.Name = "cmbAP";
            this.cmbAP.Size = new System.Drawing.Size(193, 23);
            this.cmbAP.TabIndex = 6;
            this.cmbAP.DropDown += new System.EventHandler(this.cmbAP_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "End:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "AP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Detail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Location:";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = " ";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(627, 62);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(193, 25);
            this.dtpStart.TabIndex = 7;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = " ";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(627, 109);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(193, 25);
            this.dtpEnd.TabIndex = 7;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(627, 199);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(498, 118);
            this.txtDetail.TabIndex = 8;
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(627, 333);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(193, 23);
            this.cmbLocation.TabIndex = 6;
            this.cmbLocation.DropDown += new System.EventHandler(this.cmbLocation_DropDown);
            // 
            // btnAddDeviceList
            // 
            this.btnAddDeviceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddDeviceList.Location = new System.Drawing.Point(852, 327);
            this.btnAddDeviceList.Name = "btnAddDeviceList";
            this.btnAddDeviceList.Size = new System.Drawing.Size(112, 33);
            this.btnAddDeviceList.TabIndex = 0;
            this.btnAddDeviceList.Text = "Add To List";
            this.btnAddDeviceList.UseVisualStyleBackColor = true;
            this.btnAddDeviceList.Click += new System.EventHandler(this.btnAddDeviceList_Click);
            // 
            // BulkMaintenanceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 689);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.btnAddDeviceList);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.cmbAP);
            this.Controls.Add(this.txtPTW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clbItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BulkMaintenanceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BulkMaintenanceFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkContinue;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbKeepItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deviceModelBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPTW;
        private System.Windows.Forms.ComboBox cmbAP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Button btnAddDeviceList;
    }
}