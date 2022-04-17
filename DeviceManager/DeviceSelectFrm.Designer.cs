
namespace DeviceManager
{
    partial class DeviceSelectFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dKKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRemarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDeviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbSearch);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 0;
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(95, 12);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(216, 23);
            this.cmbSearch.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Location = new System.Drawing.Point(705, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 47);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 47);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AutoGenerateColumns = false;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.dNameDataGridViewTextBoxColumn,
            this.dModelDataGridViewTextBoxColumn,
            this.dKKSDataGridViewTextBoxColumn,
            this.dNoDataGridViewTextBoxColumn,
            this.dStatusDataGridViewTextBoxColumn,
            this.pidDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.agencyDataGridViewTextBoxColumn,
            this.dRemarkDataGridViewTextBoxColumn,
            this.subDeviceDataGridViewTextBoxColumn});
            this.dgvDevice.DataSource = this.deviceModelBindingSource;
            this.dgvDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevice.Location = new System.Drawing.Point(0, 47);
            this.dgvDevice.MultiSelect = false;
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowHeadersWidth = 51;
            this.dgvDevice.RowTemplate.Height = 27;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(800, 403);
            this.dgvDevice.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // dNameDataGridViewTextBoxColumn
            // 
            this.dNameDataGridViewTextBoxColumn.DataPropertyName = "DName";
            this.dNameDataGridViewTextBoxColumn.HeaderText = "DName";
            this.dNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNameDataGridViewTextBoxColumn.Name = "dNameDataGridViewTextBoxColumn";
            this.dNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dModelDataGridViewTextBoxColumn
            // 
            this.dModelDataGridViewTextBoxColumn.DataPropertyName = "DModel";
            this.dModelDataGridViewTextBoxColumn.HeaderText = "DModel";
            this.dModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dModelDataGridViewTextBoxColumn.Name = "dModelDataGridViewTextBoxColumn";
            this.dModelDataGridViewTextBoxColumn.Width = 125;
            // 
            // dKKSDataGridViewTextBoxColumn
            // 
            this.dKKSDataGridViewTextBoxColumn.DataPropertyName = "DKKS";
            this.dKKSDataGridViewTextBoxColumn.HeaderText = "DKKS";
            this.dKKSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dKKSDataGridViewTextBoxColumn.Name = "dKKSDataGridViewTextBoxColumn";
            this.dKKSDataGridViewTextBoxColumn.Width = 125;
            // 
            // dNoDataGridViewTextBoxColumn
            // 
            this.dNoDataGridViewTextBoxColumn.DataPropertyName = "DNo";
            this.dNoDataGridViewTextBoxColumn.HeaderText = "DNo";
            this.dNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNoDataGridViewTextBoxColumn.Name = "dNoDataGridViewTextBoxColumn";
            this.dNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dStatusDataGridViewTextBoxColumn
            // 
            this.dStatusDataGridViewTextBoxColumn.DataPropertyName = "DStatus";
            this.dStatusDataGridViewTextBoxColumn.HeaderText = "DStatus";
            this.dStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dStatusDataGridViewTextBoxColumn.Name = "dStatusDataGridViewTextBoxColumn";
            this.dStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "Pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "Pid";
            this.pidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.Width = 125;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.Width = 125;
            // 
            // agencyDataGridViewTextBoxColumn
            // 
            this.agencyDataGridViewTextBoxColumn.DataPropertyName = "Agency";
            this.agencyDataGridViewTextBoxColumn.HeaderText = "Agency";
            this.agencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agencyDataGridViewTextBoxColumn.Name = "agencyDataGridViewTextBoxColumn";
            this.agencyDataGridViewTextBoxColumn.Width = 125;
            // 
            // dRemarkDataGridViewTextBoxColumn
            // 
            this.dRemarkDataGridViewTextBoxColumn.DataPropertyName = "DRemark";
            this.dRemarkDataGridViewTextBoxColumn.HeaderText = "DRemark";
            this.dRemarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dRemarkDataGridViewTextBoxColumn.Name = "dRemarkDataGridViewTextBoxColumn";
            this.dRemarkDataGridViewTextBoxColumn.Width = 125;
            // 
            // subDeviceDataGridViewTextBoxColumn
            // 
            this.subDeviceDataGridViewTextBoxColumn.DataPropertyName = "SubDevice";
            this.subDeviceDataGridViewTextBoxColumn.HeaderText = "SubDevice";
            this.subDeviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subDeviceDataGridViewTextBoxColumn.Name = "subDeviceDataGridViewTextBoxColumn";
            this.subDeviceDataGridViewTextBoxColumn.Width = 125;
            // 
            // deviceModelBindingSource
            // 
            this.deviceModelBindingSource.DataSource = typeof(Models.DeviceModel);
            // 
            // DeviceSelectFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDevice);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceSelectFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceSelectFrm";
            this.Load += new System.EventHandler(this.DeviceSelectFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dKKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRemarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDeviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deviceModelBindingSource;
    }
}