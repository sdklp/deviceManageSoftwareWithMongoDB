
namespace DeviceManager
{
    partial class DevicePartRelatedFrm
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.sparePartModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvDevicePart = new System.Windows.Forms.DataGridView();
            this.locationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDeviceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicePartModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSparePartName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSparePartModel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevicePart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicePartModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(3, 23);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(47, 89);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = ">>";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // sparePartModelBindingSource
            // 
            this.sparePartModelBindingSource.DataSource = typeof(Models.SparePartModel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.lblSparePartModel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblSparePartName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 39);
            this.panel1.TabIndex = 5;
            // 
            // cmbSearch
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(81, 9);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(302, 23);
            this.cmbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 39);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AutoGenerateColumns = false;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.dNameDataGridViewTextBoxColumn,
            this.DNo});
            this.dgvDevice.DataSource = this.deviceModelBindingSource;
            this.dgvDevice.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDevice.Location = new System.Drawing.Point(0, 39);
            this.dgvDevice.MultiSelect = false;
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowHeadersWidth = 51;
            this.dgvDevice.RowTemplate.Height = 27;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(383, 632);
            this.dgvDevice.TabIndex = 0;
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
            // DNo
            // 
            this.DNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DNo.DataPropertyName = "DNo";
            this.DNo.HeaderText = "DNo";
            this.DNo.MinimumWidth = 6;
            this.DNo.Name = "DNo";
            // 
            // deviceModelBindingSource
            // 
            this.deviceModelBindingSource.DataSource = typeof(Models.DeviceModel);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(383, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 632);
            this.panel2.TabIndex = 7;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(3, 130);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(47, 89);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // dgvDevicePart
            // 
            this.dgvDevicePart.AllowUserToAddRows = false;
            this.dgvDevicePart.AutoGenerateColumns = false;
            this.dgvDevicePart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevicePart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn1,
            this.dNameDataGridViewTextBoxColumn1,
            this.subDeviceDataGridViewTextBoxColumn1,
            this.pNameDataGridViewTextBoxColumn,
            this.pModelDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn});
            this.dgvDevicePart.DataSource = this.devicePartModelBindingSource;
            this.dgvDevicePart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevicePart.Location = new System.Drawing.Point(436, 39);
            this.dgvDevicePart.MultiSelect = false;
            this.dgvDevicePart.Name = "dgvDevicePart";
            this.dgvDevicePart.RowHeadersVisible = false;
            this.dgvDevicePart.RowHeadersWidth = 51;
            this.dgvDevicePart.RowTemplate.Height = 27;
            this.dgvDevicePart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevicePart.Size = new System.Drawing.Size(898, 632);
            this.dgvDevicePart.TabIndex = 3;
            // 
            // locationDataGridViewTextBoxColumn1
            // 
            this.locationDataGridViewTextBoxColumn1.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn1.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn1.Name = "locationDataGridViewTextBoxColumn1";
            this.locationDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dNameDataGridViewTextBoxColumn1
            // 
            this.dNameDataGridViewTextBoxColumn1.DataPropertyName = "DName";
            this.dNameDataGridViewTextBoxColumn1.HeaderText = "DName";
            this.dNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dNameDataGridViewTextBoxColumn1.Name = "dNameDataGridViewTextBoxColumn1";
            this.dNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // subDeviceDataGridViewTextBoxColumn1
            // 
            this.subDeviceDataGridViewTextBoxColumn1.DataPropertyName = "SubDevice";
            this.subDeviceDataGridViewTextBoxColumn1.HeaderText = "SubDevice";
            this.subDeviceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.subDeviceDataGridViewTextBoxColumn1.Name = "subDeviceDataGridViewTextBoxColumn1";
            this.subDeviceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "PName";
            this.pNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // pModelDataGridViewTextBoxColumn
            // 
            this.pModelDataGridViewTextBoxColumn.DataPropertyName = "PModel";
            this.pModelDataGridViewTextBoxColumn.HeaderText = "PModel";
            this.pModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pModelDataGridViewTextBoxColumn.Name = "pModelDataGridViewTextBoxColumn";
            this.pModelDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitsDataGridViewTextBoxColumn
            // 
            this.unitsDataGridViewTextBoxColumn.DataPropertyName = "Units";
            this.unitsDataGridViewTextBoxColumn.HeaderText = "Units";
            this.unitsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitsDataGridViewTextBoxColumn.Name = "unitsDataGridViewTextBoxColumn";
            this.unitsDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // devicePartModelBindingSource
            // 
            this.devicePartModelBindingSource.DataSource = typeof(Models.DevicePartModel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(433, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "Id", true));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(472, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 15);
            this.lblId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(694, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Spare Part Name:";
            // 
            // lblSparePartName
            // 
            this.lblSparePartName.AutoSize = true;
            this.lblSparePartName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "PName", true));
            this.lblSparePartName.ForeColor = System.Drawing.Color.White;
            this.lblSparePartName.Location = new System.Drawing.Point(828, 12);
            this.lblSparePartName.Name = "lblSparePartName";
            this.lblSparePartName.Size = new System.Drawing.Size(0, 15);
            this.lblSparePartName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(989, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Spare Part Model:";
            // 
            // lblSparePartModel
            // 
            this.lblSparePartModel.AutoSize = true;
            this.lblSparePartModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "PModel", true));
            this.lblSparePartModel.ForeColor = System.Drawing.Color.White;
            this.lblSparePartModel.Location = new System.Drawing.Point(1135, 12);
            this.lblSparePartModel.Name = "lblSparePartModel";
            this.lblSparePartModel.Size = new System.Drawing.Size(0, 15);
            this.lblSparePartModel.TabIndex = 5;
            // 
            // DevicePartRelatedFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 671);
            this.Controls.Add(this.dgvDevicePart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvDevice);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DevicePartRelatedFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevicePartDetailFrm";
            this.Load += new System.EventHandler(this.DevicePartDetailFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sparePartModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevicePart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicePartModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.BindingSource devicePartModelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDevicePart;
        private System.Windows.Forms.BindingSource deviceModelBindingSource;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDeviceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNo;
        private System.Windows.Forms.BindingSource sparePartModelBindingSource;
        private System.Windows.Forms.Label lblSparePartModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSparePartName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
    }
}