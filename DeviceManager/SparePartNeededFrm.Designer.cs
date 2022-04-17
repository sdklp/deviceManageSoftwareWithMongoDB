
namespace DeviceManager
{
    partial class SparePartNeededFrm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSparePartNeeded = new System.Windows.Forms.DataGridView();
            this.sparePartNeededModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDeviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceKKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparePartNeeded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartNeededModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.cmbSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 44);
            this.panel1.TabIndex = 0;
            // 
            // cmbSearch
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(780, 9);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(204, 23);
            this.cmbSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(990, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 44);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spare Part Needed";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnCopy);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 44);
            this.panel2.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExport.Location = new System.Drawing.Point(300, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(137, 44);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCopy.Location = new System.Drawing.Point(225, 0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 44);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.Location = new System.Drawing.Point(150, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 44);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(75, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 44);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvSparePartNeeded
            // 
            this.dgvSparePartNeeded.AllowUserToAddRows = false;
            this.dgvSparePartNeeded.AutoGenerateColumns = false;
            this.dgvSparePartNeeded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSparePartNeeded.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.docIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.requireDateDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.subDeviceDataGridViewTextBoxColumn,
            this.deviceNameDataGridViewTextBoxColumn,
            this.deviceLocationDataGridViewTextBoxColumn,
            this.deviceNoDataGridViewTextBoxColumn,
            this.deviceModelDataGridViewTextBoxColumn,
            this.deviceKKSDataGridViewTextBoxColumn,
            this.sparePartNameDataGridViewTextBoxColumn,
            this.sparePartModelDataGridViewTextBoxColumn,
            this.sparePartNoDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dgvSparePartNeeded.DataSource = this.sparePartNeededModelBindingSource;
            this.dgvSparePartNeeded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSparePartNeeded.Location = new System.Drawing.Point(0, 88);
            this.dgvSparePartNeeded.MultiSelect = false;
            this.dgvSparePartNeeded.Name = "dgvSparePartNeeded";
            this.dgvSparePartNeeded.RowHeadersVisible = false;
            this.dgvSparePartNeeded.RowHeadersWidth = 51;
            this.dgvSparePartNeeded.RowTemplate.Height = 27;
            this.dgvSparePartNeeded.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSparePartNeeded.Size = new System.Drawing.Size(1065, 581);
            this.dgvSparePartNeeded.TabIndex = 1;
            // 
            // sparePartNeededModelBindingSource
            // 
            this.sparePartNeededModelBindingSource.DataSource = typeof(Models.SparePartNeededModel);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // docIDDataGridViewTextBoxColumn
            // 
            this.docIDDataGridViewTextBoxColumn.DataPropertyName = "DocID";
            this.docIDDataGridViewTextBoxColumn.HeaderText = "DocID";
            this.docIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.docIDDataGridViewTextBoxColumn.Name = "docIDDataGridViewTextBoxColumn";
            this.docIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 70;
            // 
            // requireDateDataGridViewTextBoxColumn
            // 
            this.requireDateDataGridViewTextBoxColumn.DataPropertyName = "RequireDate";
            this.requireDateDataGridViewTextBoxColumn.HeaderText = "RequireDate";
            this.requireDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requireDateDataGridViewTextBoxColumn.Name = "requireDateDataGridViewTextBoxColumn";
            this.requireDateDataGridViewTextBoxColumn.Width = 70;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.Width = 70;
            // 
            // subDeviceDataGridViewTextBoxColumn
            // 
            this.subDeviceDataGridViewTextBoxColumn.DataPropertyName = "SubDevice";
            this.subDeviceDataGridViewTextBoxColumn.HeaderText = "SubDevice";
            this.subDeviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subDeviceDataGridViewTextBoxColumn.Name = "subDeviceDataGridViewTextBoxColumn";
            this.subDeviceDataGridViewTextBoxColumn.Width = 70;
            // 
            // deviceNameDataGridViewTextBoxColumn
            // 
            this.deviceNameDataGridViewTextBoxColumn.DataPropertyName = "DeviceName";
            this.deviceNameDataGridViewTextBoxColumn.HeaderText = "DeviceName";
            this.deviceNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deviceNameDataGridViewTextBoxColumn.Name = "deviceNameDataGridViewTextBoxColumn";
            this.deviceNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // deviceLocationDataGridViewTextBoxColumn
            // 
            this.deviceLocationDataGridViewTextBoxColumn.DataPropertyName = "DeviceLocation";
            this.deviceLocationDataGridViewTextBoxColumn.HeaderText = "DeviceLocation";
            this.deviceLocationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deviceLocationDataGridViewTextBoxColumn.Name = "deviceLocationDataGridViewTextBoxColumn";
            this.deviceLocationDataGridViewTextBoxColumn.Width = 70;
            // 
            // deviceNoDataGridViewTextBoxColumn
            // 
            this.deviceNoDataGridViewTextBoxColumn.DataPropertyName = "DeviceNo";
            this.deviceNoDataGridViewTextBoxColumn.HeaderText = "DeviceNo";
            this.deviceNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deviceNoDataGridViewTextBoxColumn.Name = "deviceNoDataGridViewTextBoxColumn";
            this.deviceNoDataGridViewTextBoxColumn.Width = 70;
            // 
            // deviceModelDataGridViewTextBoxColumn
            // 
            this.deviceModelDataGridViewTextBoxColumn.DataPropertyName = "DeviceModel";
            this.deviceModelDataGridViewTextBoxColumn.HeaderText = "DeviceModel";
            this.deviceModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deviceModelDataGridViewTextBoxColumn.Name = "deviceModelDataGridViewTextBoxColumn";
            this.deviceModelDataGridViewTextBoxColumn.Width = 125;
            // 
            // deviceKKSDataGridViewTextBoxColumn
            // 
            this.deviceKKSDataGridViewTextBoxColumn.DataPropertyName = "DeviceKKS";
            this.deviceKKSDataGridViewTextBoxColumn.HeaderText = "DeviceKKS";
            this.deviceKKSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deviceKKSDataGridViewTextBoxColumn.Name = "deviceKKSDataGridViewTextBoxColumn";
            this.deviceKKSDataGridViewTextBoxColumn.Width = 70;
            // 
            // sparePartNameDataGridViewTextBoxColumn
            // 
            this.sparePartNameDataGridViewTextBoxColumn.DataPropertyName = "SparePartName";
            this.sparePartNameDataGridViewTextBoxColumn.HeaderText = "SparePartName";
            this.sparePartNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sparePartNameDataGridViewTextBoxColumn.Name = "sparePartNameDataGridViewTextBoxColumn";
            this.sparePartNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // sparePartModelDataGridViewTextBoxColumn
            // 
            this.sparePartModelDataGridViewTextBoxColumn.DataPropertyName = "SparePartModel";
            this.sparePartModelDataGridViewTextBoxColumn.HeaderText = "SparePartModel";
            this.sparePartModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sparePartModelDataGridViewTextBoxColumn.Name = "sparePartModelDataGridViewTextBoxColumn";
            this.sparePartModelDataGridViewTextBoxColumn.Width = 125;
            // 
            // sparePartNoDataGridViewTextBoxColumn
            // 
            this.sparePartNoDataGridViewTextBoxColumn.DataPropertyName = "SparePartNo";
            this.sparePartNoDataGridViewTextBoxColumn.HeaderText = "SparePartNo";
            this.sparePartNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sparePartNoDataGridViewTextBoxColumn.Name = "sparePartNoDataGridViewTextBoxColumn";
            this.sparePartNoDataGridViewTextBoxColumn.Width = 125;
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
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.Width = 125;
            // 
            // SparePartNeededFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 669);
            this.Controls.Add(this.dgvSparePartNeeded);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SparePartNeededFrm";
            this.Text = "SparePartNeededFrm";
            this.Load += new System.EventHandler(this.SparePartNeededFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparePartNeeded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartNeededModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvSparePartNeeded;
        private System.Windows.Forms.BindingSource sparePartNeededModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDeviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceKKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}