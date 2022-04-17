
namespace DeviceManager
{
    partial class MaintenanceFrm
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
            this.btnPartsChanged = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceKKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDeviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faultSummaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealWithSummaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faultDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealWithDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceModelBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1118, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(1043, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 48);
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
            this.cmbSearch.Location = new System.Drawing.Point(761, 14);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(276, 23);
            this.cmbSearch.TabIndex = 1;
            this.cmbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maintenance Form";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPartsChanged);
            this.panel2.Controls.Add(this.btnPic);
            this.panel2.Controls.Add(this.btnDoc);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnCopy);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 48);
            this.panel2.TabIndex = 0;
            // 
            // btnPartsChanged
            // 
            this.btnPartsChanged.AutoSize = true;
            this.btnPartsChanged.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPartsChanged.Location = new System.Drawing.Point(841, 0);
            this.btnPartsChanged.Name = "btnPartsChanged";
            this.btnPartsChanged.Size = new System.Drawing.Size(121, 48);
            this.btnPartsChanged.TabIndex = 1;
            this.btnPartsChanged.Text = "Parts Changed";
            this.btnPartsChanged.UseVisualStyleBackColor = true;
            // 
            // btnPic
            // 
            this.btnPic.AutoSize = true;
            this.btnPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPic.Location = new System.Drawing.Point(962, 0);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(75, 48);
            this.btnPic.TabIndex = 1;
            this.btnPic.Text = "Picture";
            this.btnPic.UseVisualStyleBackColor = true;
            // 
            // btnDoc
            // 
            this.btnDoc.AutoSize = true;
            this.btnDoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDoc.Location = new System.Drawing.Point(1037, 0);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(81, 48);
            this.btnDoc.TabIndex = 1;
            this.btnDoc.Text = "Document";
            this.btnDoc.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExport.Location = new System.Drawing.Point(300, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(137, 48);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCopy.Location = new System.Drawing.Point(225, 0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 48);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.Location = new System.Drawing.Point(150, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 48);
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
            this.btnDelete.Size = new System.Drawing.Size(75, 48);
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
            this.btnAdd.Size = new System.Drawing.Size(75, 48);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvMaintenance
            // 
            this.dgvMaintenance.AllowUserToAddRows = false;
            this.dgvMaintenance.AutoGenerateColumns = false;
            this.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.DeviceName,
            this.DeviceLocation,
            this.DeviceNo,
            this.DeviceModel,
            this.DeviceKKS,
            this.pTWDataGridViewTextBoxColumn,
            this.aPDataGridViewTextBoxColumn,
            this.detailDataGridViewTextBoxColumn,
            this.subDeviceDataGridViewTextBoxColumn,
            this.faultSummaryDataGridViewTextBoxColumn,
            this.dealWithSummaryDataGridViewTextBoxColumn,
            this.faultDetailDataGridViewTextBoxColumn,
            this.dealWithDetailDataGridViewTextBoxColumn});
            this.dgvMaintenance.DataSource = this.maintenanceModelBindingSource;
            this.dgvMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaintenance.Location = new System.Drawing.Point(0, 96);
            this.dgvMaintenance.MultiSelect = false;
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.RowHeadersVisible = false;
            this.dgvMaintenance.RowHeadersWidth = 51;
            this.dgvMaintenance.RowTemplate.Height = 27;
            this.dgvMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaintenance.Size = new System.Drawing.Size(1118, 569);
            this.dgvMaintenance.TabIndex = 1;
            this.dgvMaintenance.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "DeviceName";
            this.DeviceName.HeaderText = "DeviceName";
            this.DeviceName.MinimumWidth = 6;
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Width = 125;
            // 
            // DeviceLocation
            // 
            this.DeviceLocation.DataPropertyName = "DeviceLocation";
            this.DeviceLocation.HeaderText = "DeviceLocation";
            this.DeviceLocation.MinimumWidth = 6;
            this.DeviceLocation.Name = "DeviceLocation";
            this.DeviceLocation.Width = 125;
            // 
            // DeviceNo
            // 
            this.DeviceNo.DataPropertyName = "DeviceNo";
            this.DeviceNo.HeaderText = "DeviceNo";
            this.DeviceNo.MinimumWidth = 6;
            this.DeviceNo.Name = "DeviceNo";
            this.DeviceNo.Width = 125;
            // 
            // DeviceModel
            // 
            this.DeviceModel.DataPropertyName = "DeviceModel";
            this.DeviceModel.HeaderText = "DeviceModel";
            this.DeviceModel.MinimumWidth = 6;
            this.DeviceModel.Name = "DeviceModel";
            this.DeviceModel.Width = 125;
            // 
            // DeviceKKS
            // 
            this.DeviceKKS.DataPropertyName = "DeviceKKS";
            this.DeviceKKS.HeaderText = "DeviceKKS";
            this.DeviceKKS.MinimumWidth = 6;
            this.DeviceKKS.Name = "DeviceKKS";
            this.DeviceKKS.Width = 125;
            // 
            // pTWDataGridViewTextBoxColumn
            // 
            this.pTWDataGridViewTextBoxColumn.DataPropertyName = "PTW";
            this.pTWDataGridViewTextBoxColumn.HeaderText = "PTW";
            this.pTWDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pTWDataGridViewTextBoxColumn.Name = "pTWDataGridViewTextBoxColumn";
            this.pTWDataGridViewTextBoxColumn.Width = 125;
            // 
            // aPDataGridViewTextBoxColumn
            // 
            this.aPDataGridViewTextBoxColumn.DataPropertyName = "AP";
            this.aPDataGridViewTextBoxColumn.HeaderText = "AP";
            this.aPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aPDataGridViewTextBoxColumn.Name = "aPDataGridViewTextBoxColumn";
            this.aPDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailDataGridViewTextBoxColumn
            // 
            this.detailDataGridViewTextBoxColumn.DataPropertyName = "Detail";
            this.detailDataGridViewTextBoxColumn.HeaderText = "Detail";
            this.detailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailDataGridViewTextBoxColumn.Name = "detailDataGridViewTextBoxColumn";
            this.detailDataGridViewTextBoxColumn.Width = 125;
            // 
            // subDeviceDataGridViewTextBoxColumn
            // 
            this.subDeviceDataGridViewTextBoxColumn.DataPropertyName = "SubDevice";
            this.subDeviceDataGridViewTextBoxColumn.HeaderText = "SubDevice";
            this.subDeviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subDeviceDataGridViewTextBoxColumn.Name = "subDeviceDataGridViewTextBoxColumn";
            this.subDeviceDataGridViewTextBoxColumn.Width = 125;
            // 
            // faultSummaryDataGridViewTextBoxColumn
            // 
            this.faultSummaryDataGridViewTextBoxColumn.DataPropertyName = "FaultSummary";
            this.faultSummaryDataGridViewTextBoxColumn.HeaderText = "FaultSummary";
            this.faultSummaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faultSummaryDataGridViewTextBoxColumn.Name = "faultSummaryDataGridViewTextBoxColumn";
            this.faultSummaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // dealWithSummaryDataGridViewTextBoxColumn
            // 
            this.dealWithSummaryDataGridViewTextBoxColumn.DataPropertyName = "DealWithSummary";
            this.dealWithSummaryDataGridViewTextBoxColumn.HeaderText = "DealWithSummary";
            this.dealWithSummaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dealWithSummaryDataGridViewTextBoxColumn.Name = "dealWithSummaryDataGridViewTextBoxColumn";
            this.dealWithSummaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // faultDetailDataGridViewTextBoxColumn
            // 
            this.faultDetailDataGridViewTextBoxColumn.DataPropertyName = "FaultDetail";
            this.faultDetailDataGridViewTextBoxColumn.HeaderText = "FaultDetail";
            this.faultDetailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faultDetailDataGridViewTextBoxColumn.Name = "faultDetailDataGridViewTextBoxColumn";
            this.faultDetailDataGridViewTextBoxColumn.Width = 125;
            // 
            // dealWithDetailDataGridViewTextBoxColumn
            // 
            this.dealWithDetailDataGridViewTextBoxColumn.DataPropertyName = "DealWithDetail";
            this.dealWithDetailDataGridViewTextBoxColumn.HeaderText = "DealWithDetail";
            this.dealWithDetailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dealWithDetailDataGridViewTextBoxColumn.Name = "dealWithDetailDataGridViewTextBoxColumn";
            this.dealWithDetailDataGridViewTextBoxColumn.Width = 125;
            // 
            // maintenanceModelBindingSource
            // 
            this.maintenanceModelBindingSource.DataSource = typeof(Models.MaintenanceModel);
            // 
            // MaintenanceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 665);
            this.Controls.Add(this.dgvMaintenance);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaintenanceFrm";
            this.Text = "MaintenanceFrm";
            this.Load += new System.EventHandler(this.MaintenanceFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPartsChanged;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvMaintenance;
        private System.Windows.Forms.BindingSource maintenanceModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceKKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDeviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faultSummaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealWithSummaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faultDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealWithDetailDataGridViewTextBoxColumn;
    }
}