
namespace DeviceManager
{
    partial class SparePartFrm
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvSparePart = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPutOut = new System.Windows.Forms.Button();
            this.btnPutIn = new System.Windows.Forms.Button();
            this.btnDevicePart = new System.Windows.Forms.Button();
            this.cmbSaveForm = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBalance = new System.Windows.Forms.TabPage();
            this.dgvBalance = new System.Windows.Forms.DataGridView();
            this.sparePartBalanceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExportBalance = new System.Windows.Forms.Button();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparePart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartModelBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartBalanceModelBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvSparePart);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1123, 558);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvSparePart
            // 
            this.dgvSparePart.AllowUserToAddRows = false;
            this.dgvSparePart.AutoGenerateColumns = false;
            this.dgvSparePart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSparePart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pModelDataGridViewTextBoxColumn,
            this.pNoDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.minQtyDataGridViewTextBoxColumn,
            this.maxQtyDataGridViewTextBoxColumn,
            this.Manufacturer,
            this.Agency,
            this.detailDataGridViewTextBoxColumn});
            this.dgvSparePart.DataSource = this.sparePartModelBindingSource;
            this.dgvSparePart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSparePart.Location = new System.Drawing.Point(0, 88);
            this.dgvSparePart.Name = "dgvSparePart";
            this.dgvSparePart.RowHeadersVisible = false;
            this.dgvSparePart.RowHeadersWidth = 51;
            this.dgvSparePart.RowTemplate.Height = 27;
            this.dgvSparePart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSparePart.Size = new System.Drawing.Size(1123, 286);
            this.dgvSparePart.TabIndex = 7;
            this.dgvSparePart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSparePart_CellClick);
            this.dgvSparePart.DoubleClick += new System.EventHandler(this.btnEdit_Click);
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
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // minQtyDataGridViewTextBoxColumn
            // 
            this.minQtyDataGridViewTextBoxColumn.DataPropertyName = "MinQty";
            this.minQtyDataGridViewTextBoxColumn.HeaderText = "MinQty";
            this.minQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minQtyDataGridViewTextBoxColumn.Name = "minQtyDataGridViewTextBoxColumn";
            this.minQtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxQtyDataGridViewTextBoxColumn
            // 
            this.maxQtyDataGridViewTextBoxColumn.DataPropertyName = "MaxQty";
            this.maxQtyDataGridViewTextBoxColumn.HeaderText = "MaxQty";
            this.maxQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxQtyDataGridViewTextBoxColumn.Name = "maxQtyDataGridViewTextBoxColumn";
            this.maxQtyDataGridViewTextBoxColumn.Width = 125;
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
            // detailDataGridViewTextBoxColumn
            // 
            this.detailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detailDataGridViewTextBoxColumn.DataPropertyName = "Detail";
            this.detailDataGridViewTextBoxColumn.HeaderText = "Detail";
            this.detailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailDataGridViewTextBoxColumn.Name = "detailDataGridViewTextBoxColumn";
            // 
            // sparePartModelBindingSource
            // 
            this.sparePartModelBindingSource.DataSource = typeof(Models.SparePartModel);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPutOut);
            this.panel2.Controls.Add(this.btnPutIn);
            this.panel2.Controls.Add(this.btnDevicePart);
            this.panel2.Controls.Add(this.cmbSaveForm);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 44);
            this.panel2.TabIndex = 5;
            // 
            // btnPutOut
            // 
            this.btnPutOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPutOut.Location = new System.Drawing.Point(448, 0);
            this.btnPutOut.Name = "btnPutOut";
            this.btnPutOut.Size = new System.Drawing.Size(75, 44);
            this.btnPutOut.TabIndex = 0;
            this.btnPutOut.Text = "Put Out";
            this.btnPutOut.UseVisualStyleBackColor = true;
            this.btnPutOut.Click += new System.EventHandler(this.btnPutOut_Click);
            // 
            // btnPutIn
            // 
            this.btnPutIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPutIn.Location = new System.Drawing.Point(373, 0);
            this.btnPutIn.Name = "btnPutIn";
            this.btnPutIn.Size = new System.Drawing.Size(75, 44);
            this.btnPutIn.TabIndex = 0;
            this.btnPutIn.Text = "Put In";
            this.btnPutIn.UseVisualStyleBackColor = true;
            this.btnPutIn.Click += new System.EventHandler(this.btnPutIn_Click);
            // 
            // btnDevicePart
            // 
            this.btnDevicePart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDevicePart.Location = new System.Drawing.Point(225, 0);
            this.btnDevicePart.Name = "btnDevicePart";
            this.btnDevicePart.Size = new System.Drawing.Size(148, 44);
            this.btnDevicePart.TabIndex = 2;
            this.btnDevicePart.Text = "SparePartRelate";
            this.btnDevicePart.UseVisualStyleBackColor = true;
            this.btnDevicePart.Click += new System.EventHandler(this.btnDevicePart_Click);
            // 
            // cmbSaveForm
            // 
            this.cmbSaveForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSaveForm.FormattingEnabled = true;
            this.cmbSaveForm.Items.AddRange(new object[] {
            "Save Form"});
            this.cmbSaveForm.Location = new System.Drawing.Point(786, 12);
            this.cmbSaveForm.Name = "cmbSaveForm";
            this.cmbSaveForm.Size = new System.Drawing.Size(194, 23);
            this.cmbSaveForm.TabIndex = 1;
            this.cmbSaveForm.Text = "Save Form";
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExport.Location = new System.Drawing.Point(986, 0);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cmbSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 44);
            this.panel1.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(1048, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spare Part Management Form";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpBalance);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 180);
            this.tabControl1.TabIndex = 0;
            // 
            // tpBalance
            // 
            this.tpBalance.Controls.Add(this.dgvBalance);
            this.tpBalance.Controls.Add(this.panel3);
            this.tpBalance.Location = new System.Drawing.Point(4, 25);
            this.tpBalance.Name = "tpBalance";
            this.tpBalance.Padding = new System.Windows.Forms.Padding(3);
            this.tpBalance.Size = new System.Drawing.Size(1115, 151);
            this.tpBalance.TabIndex = 0;
            this.tpBalance.Text = "Balance";
            this.tpBalance.UseVisualStyleBackColor = true;
            // 
            // dgvBalance
            // 
            this.dgvBalance.AllowUserToAddRows = false;
            this.dgvBalance.AutoGenerateColumns = false;
            this.dgvBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitsDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.inOutDataGridViewTextBoxColumn,
            this.personDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dgvBalance.DataSource = this.sparePartBalanceModelBindingSource;
            this.dgvBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBalance.Location = new System.Drawing.Point(3, 44);
            this.dgvBalance.MultiSelect = false;
            this.dgvBalance.Name = "dgvBalance";
            this.dgvBalance.RowHeadersVisible = false;
            this.dgvBalance.RowHeadersWidth = 51;
            this.dgvBalance.RowTemplate.Height = 27;
            this.dgvBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBalance.Size = new System.Drawing.Size(1109, 104);
            this.dgvBalance.TabIndex = 1;
            // 
            // sparePartBalanceModelBindingSource
            // 
            this.sparePartBalanceModelBindingSource.DataSource = typeof(Models.SparePartBalanceModel);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.btnExportBalance);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1109, 41);
            this.panel3.TabIndex = 0;
            // 
            // btnExportBalance
            // 
            this.btnExportBalance.AutoSize = true;
            this.btnExportBalance.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportBalance.Location = new System.Drawing.Point(0, 0);
            this.btnExportBalance.Name = "btnExportBalance";
            this.btnExportBalance.Size = new System.Drawing.Size(137, 41);
            this.btnExportBalance.TabIndex = 0;
            this.btnExportBalance.Text = "Export To Excel";
            this.btnExportBalance.UseVisualStyleBackColor = true;
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
            // inOutDataGridViewTextBoxColumn
            // 
            this.inOutDataGridViewTextBoxColumn.DataPropertyName = "InOut";
            this.inOutDataGridViewTextBoxColumn.HeaderText = "InOut";
            this.inOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inOutDataGridViewTextBoxColumn.Name = "inOutDataGridViewTextBoxColumn";
            this.inOutDataGridViewTextBoxColumn.Width = 125;
            // 
            // personDataGridViewTextBoxColumn
            // 
            this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            this.personDataGridViewTextBoxColumn.HeaderText = "Person";
            this.personDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            this.personDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // SparePartFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 558);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SparePartFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SparePartFrm";
            this.Load += new System.EventHandler(this.SparePartFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparePart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartModelBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpBalance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartBalanceModelBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sparePartModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvSparePart;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agency;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPutOut;
        private System.Windows.Forms.Button btnPutIn;
        private System.Windows.Forms.Button btnDevicePart;
        private System.Windows.Forms.ComboBox cmbSaveForm;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBalance;
        private System.Windows.Forms.DataGridView dgvBalance;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExportBalance;
        private System.Windows.Forms.BindingSource sparePartBalanceModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}