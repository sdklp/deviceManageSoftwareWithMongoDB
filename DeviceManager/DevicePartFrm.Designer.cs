
namespace DeviceManager
{
    partial class DevicePartFrm
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
            this.brnSearh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDevicePart = new System.Windows.Forms.DataGridView();
            this.devicePartModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dKKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDeviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevicePart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicePartModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.cmbSearch);
            this.panel1.Controls.Add(this.brnSearh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 49);
            this.panel1.TabIndex = 0;
            // 
            // cmbSearch
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(839, 14);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(267, 23);
            this.cmbSearch.TabIndex = 2;
            // 
            // brnSearh
            // 
            this.brnSearh.Dock = System.Windows.Forms.DockStyle.Right;
            this.brnSearh.Location = new System.Drawing.Point(1112, 0);
            this.brnSearh.Name = "brnSearh";
            this.brnSearh.Size = new System.Drawing.Size(75, 49);
            this.brnSearh.TabIndex = 1;
            this.brnSearh.Text = "Search";
            this.brnSearh.UseVisualStyleBackColor = true;
            this.brnSearh.Click += new System.EventHandler(this.brnSearh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spare Part Related Device";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnCopy);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1187, 56);
            this.panel2.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExport.Location = new System.Drawing.Point(300, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(137, 56);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCopy.Location = new System.Drawing.Point(225, 0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 56);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.Location = new System.Drawing.Point(150, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 56);
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
            this.btnDelete.Size = new System.Drawing.Size(75, 56);
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
            this.btnAdd.Size = new System.Drawing.Size(75, 56);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDevicePart
            // 
            this.dgvDevicePart.AllowUserToAddRows = false;
            this.dgvDevicePart.AutoGenerateColumns = false;
            this.dgvDevicePart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevicePart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNameDataGridViewTextBoxColumn,
            this.Location,
            this.dNoDataGridViewTextBoxColumn,
            this.dModelDataGridViewTextBoxColumn,
            this.dKKSDataGridViewTextBoxColumn,
            this.subDeviceDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pModelDataGridViewTextBoxColumn,
            this.pNoDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dgvDevicePart.DataSource = this.devicePartModelBindingSource;
            this.dgvDevicePart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevicePart.Location = new System.Drawing.Point(0, 105);
            this.dgvDevicePart.Name = "dgvDevicePart";
            this.dgvDevicePart.RowHeadersVisible = false;
            this.dgvDevicePart.RowHeadersWidth = 51;
            this.dgvDevicePart.RowTemplate.Height = 27;
            this.dgvDevicePart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevicePart.Size = new System.Drawing.Size(1187, 571);
            this.dgvDevicePart.TabIndex = 1;
            // 
            // devicePartModelBindingSource
            // 
            this.devicePartModelBindingSource.DataSource = typeof(Models.DevicePartModel);
            // 
            // dNameDataGridViewTextBoxColumn
            // 
            this.dNameDataGridViewTextBoxColumn.DataPropertyName = "DName";
            this.dNameDataGridViewTextBoxColumn.HeaderText = "DName";
            this.dNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNameDataGridViewTextBoxColumn.Name = "dNameDataGridViewTextBoxColumn";
            this.dNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.Width = 125;
            // 
            // dNoDataGridViewTextBoxColumn
            // 
            this.dNoDataGridViewTextBoxColumn.DataPropertyName = "DNo";
            this.dNoDataGridViewTextBoxColumn.HeaderText = "DNo";
            this.dNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNoDataGridViewTextBoxColumn.Name = "dNoDataGridViewTextBoxColumn";
            this.dNoDataGridViewTextBoxColumn.Width = 125;
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
            // subDeviceDataGridViewTextBoxColumn
            // 
            this.subDeviceDataGridViewTextBoxColumn.DataPropertyName = "SubDevice";
            this.subDeviceDataGridViewTextBoxColumn.HeaderText = "SubDevice";
            this.subDeviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subDeviceDataGridViewTextBoxColumn.Name = "subDeviceDataGridViewTextBoxColumn";
            this.subDeviceDataGridViewTextBoxColumn.Width = 125;
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
            // pNoDataGridViewTextBoxColumn
            // 
            this.pNoDataGridViewTextBoxColumn.DataPropertyName = "PNo";
            this.pNoDataGridViewTextBoxColumn.HeaderText = "PNo";
            this.pNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pNoDataGridViewTextBoxColumn.Name = "pNoDataGridViewTextBoxColumn";
            this.pNoDataGridViewTextBoxColumn.Width = 125;
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
            // DevicePartFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 676);
            this.Controls.Add(this.dgvDevicePart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevicePartFrm";
            this.Text = "DevicePartFrm";
            this.Load += new System.EventHandler(this.DevicePartFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevicePart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicePartModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button brnSearh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvDevicePart;
        private System.Windows.Forms.BindingSource devicePartModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dKKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDeviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}