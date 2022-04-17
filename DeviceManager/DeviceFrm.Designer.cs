
namespace DeviceManager
{
    partial class DeviceFrm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSaveForm = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deviceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dKKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRemarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cmbSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(1043, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(800, 9);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(237, 23);
            this.cmbSearch.TabIndex = 1;
            this.cmbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Management Form";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbSaveForm);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 44);
            this.panel2.TabIndex = 0;
            // 
            // cmbSaveForm
            // 
            this.cmbSaveForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSaveForm.FormattingEnabled = true;
            this.cmbSaveForm.Items.AddRange(new object[] {
            "Save Form"});
            this.cmbSaveForm.Location = new System.Drawing.Point(921, 12);
            this.cmbSaveForm.Name = "cmbSaveForm";
            this.cmbSaveForm.Size = new System.Drawing.Size(194, 23);
            this.cmbSaveForm.TabIndex = 1;
            this.cmbSaveForm.Text = "Save Form";
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExport.Location = new System.Drawing.Point(225, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(137, 44);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.dNameDataGridViewTextBoxColumn,
            this.dKKSDataGridViewTextBoxColumn,
            this.DStatus,
            this.dModelDataGridViewTextBoxColumn,
            this.dNoDataGridViewTextBoxColumn,
            this.pidDataGridViewTextBoxColumn,
            this.Manufacturer,
            this.Agency,
            this.dRemarkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deviceModelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 561);
            this.dataGridView1.TabIndex = 1;
            // 
            // deviceModelBindingSource
            // 
            this.deviceModelBindingSource.DataSource = typeof(Models.DeviceModel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dKKSDataGridViewTextBoxColumn
            // 
            this.dKKSDataGridViewTextBoxColumn.DataPropertyName = "DKKS";
            this.dKKSDataGridViewTextBoxColumn.HeaderText = "DKKS";
            this.dKKSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dKKSDataGridViewTextBoxColumn.Name = "dKKSDataGridViewTextBoxColumn";
            this.dKKSDataGridViewTextBoxColumn.Width = 125;
            // 
            // DStatus
            // 
            this.DStatus.DataPropertyName = "DStatus";
            this.DStatus.HeaderText = "DStatus";
            this.DStatus.MinimumWidth = 6;
            this.DStatus.Name = "DStatus";
            this.DStatus.Width = 125;
            // 
            // dModelDataGridViewTextBoxColumn
            // 
            this.dModelDataGridViewTextBoxColumn.DataPropertyName = "DModel";
            this.dModelDataGridViewTextBoxColumn.HeaderText = "DModel";
            this.dModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dModelDataGridViewTextBoxColumn.Name = "dModelDataGridViewTextBoxColumn";
            this.dModelDataGridViewTextBoxColumn.Width = 125;
            // 
            // dNoDataGridViewTextBoxColumn
            // 
            this.dNoDataGridViewTextBoxColumn.DataPropertyName = "DNo";
            this.dNoDataGridViewTextBoxColumn.HeaderText = "DNo";
            this.dNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNoDataGridViewTextBoxColumn.Name = "dNoDataGridViewTextBoxColumn";
            this.dNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "Pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "Pid";
            this.pidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.Width = 125;
            // 
            // Manufacturer
            // 
            this.Manufacturer.DataPropertyName = "Manufacturer";
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.MinimumWidth = 6;
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Width = 125;
            // 
            // Agency
            // 
            this.Agency.DataPropertyName = "Agency";
            this.Agency.HeaderText = "Agency";
            this.Agency.MinimumWidth = 6;
            this.Agency.Name = "Agency";
            this.Agency.Width = 125;
            // 
            // dRemarkDataGridViewTextBoxColumn
            // 
            this.dRemarkDataGridViewTextBoxColumn.DataPropertyName = "DRemark";
            this.dRemarkDataGridViewTextBoxColumn.HeaderText = "DRemark";
            this.dRemarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dRemarkDataGridViewTextBoxColumn.Name = "dRemarkDataGridViewTextBoxColumn";
            this.dRemarkDataGridViewTextBoxColumn.Width = 125;
            // 
            // DeviceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 649);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeviceFrm";
            this.Text = "DeviceFrm";
            this.Load += new System.EventHandler(this.DeviceFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSaveForm;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deviceModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dKKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRemarkDataGridViewTextBoxColumn;
    }
}