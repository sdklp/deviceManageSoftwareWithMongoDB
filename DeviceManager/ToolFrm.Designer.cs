
namespace DeviceManager
{
    partial class ToolFrm
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
            this.splTool = new System.Windows.Forms.SplitContainer();
            this.dgvTools = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLendTool = new System.Windows.Forms.Button();
            this.btnQtyChange = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTool = new System.Windows.Forms.TabControl();
            this.tpQtyChanged = new System.Windows.Forms.TabPage();
            this.dgvQtyChange = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExportQtyChanged = new System.Windows.Forms.Button();
            this.tpInOut = new System.Windows.Forms.TabPage();
            this.dgvLend = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbSearchLend = new System.Windows.Forms.ComboBox();
            this.btnSearchLend = new System.Windows.Forms.Button();
            this.btnExportLend = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolQtyChangeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolLendModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diffQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splTool)).BeginInit();
            this.splTool.Panel1.SuspendLayout();
            this.splTool.Panel2.SuspendLayout();
            this.splTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabTool.SuspendLayout();
            this.tpQtyChanged.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQtyChange)).BeginInit();
            this.panel3.SuspendLayout();
            this.tpInOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLend)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolQtyChangeModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolLendModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splTool
            // 
            this.splTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splTool.Location = new System.Drawing.Point(0, 0);
            this.splTool.Name = "splTool";
            this.splTool.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splTool.Panel1
            // 
            this.splTool.Panel1.Controls.Add(this.dgvTools);
            this.splTool.Panel1.Controls.Add(this.panel2);
            this.splTool.Panel1.Controls.Add(this.panel1);
            // 
            // splTool.Panel2
            // 
            this.splTool.Panel2.Controls.Add(this.tabTool);
            this.splTool.Size = new System.Drawing.Size(1271, 704);
            this.splTool.SplitterDistance = 378;
            this.splTool.TabIndex = 0;
            // 
            // dgvTools
            // 
            this.dgvTools.AllowUserToAddRows = false;
            this.dgvTools.AutoGenerateColumns = false;
            this.dgvTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.toolTypeDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dgvTools.DataSource = this.toolModelBindingSource;
            this.dgvTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTools.Location = new System.Drawing.Point(0, 100);
            this.dgvTools.MultiSelect = false;
            this.dgvTools.Name = "dgvTools";
            this.dgvTools.RowHeadersVisible = false;
            this.dgvTools.RowHeadersWidth = 51;
            this.dgvTools.RowTemplate.Height = 27;
            this.dgvTools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTools.Size = new System.Drawing.Size(1269, 276);
            this.dgvTools.TabIndex = 5;
            this.dgvTools.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTools_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLendTool);
            this.panel2.Controls.Add(this.btnQtyChange);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 50);
            this.panel2.TabIndex = 3;
            // 
            // btnLendTool
            // 
            this.btnLendTool.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLendTool.Location = new System.Drawing.Point(362, 0);
            this.btnLendTool.Name = "btnLendTool";
            this.btnLendTool.Size = new System.Drawing.Size(75, 50);
            this.btnLendTool.TabIndex = 2;
            this.btnLendTool.Text = "Lend";
            this.btnLendTool.UseVisualStyleBackColor = true;
            this.btnLendTool.Click += new System.EventHandler(this.btnLendTool_Click);
            // 
            // btnQtyChange
            // 
            this.btnQtyChange.AutoSize = true;
            this.btnQtyChange.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQtyChange.Location = new System.Drawing.Point(1172, 0);
            this.btnQtyChange.Name = "btnQtyChange";
            this.btnQtyChange.Size = new System.Drawing.Size(97, 50);
            this.btnQtyChange.TabIndex = 1;
            this.btnQtyChange.Text = "Qty Change";
            this.btnQtyChange.UseVisualStyleBackColor = true;
            this.btnQtyChange.Click += new System.EventHandler(this.btnQtyChange_Click);
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExport.Location = new System.Drawing.Point(225, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(137, 50);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.Location = new System.Drawing.Point(150, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 50);
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
            this.btnDelete.Size = new System.Drawing.Size(75, 50);
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
            this.btnAdd.Size = new System.Drawing.Size(75, 50);
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
            this.panel1.Size = new System.Drawing.Size(1269, 50);
            this.panel1.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(1194, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 50);
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
            this.cmbSearch.Location = new System.Drawing.Point(950, 13);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(238, 23);
            this.cmbSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tools Management Form";
            // 
            // tabTool
            // 
            this.tabTool.Controls.Add(this.tpInOut);
            this.tabTool.Controls.Add(this.tpQtyChanged);
            this.tabTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTool.Location = new System.Drawing.Point(0, 0);
            this.tabTool.Name = "tabTool";
            this.tabTool.SelectedIndex = 0;
            this.tabTool.Size = new System.Drawing.Size(1269, 320);
            this.tabTool.TabIndex = 7;
            // 
            // tpQtyChanged
            // 
            this.tpQtyChanged.Controls.Add(this.dgvQtyChange);
            this.tpQtyChanged.Controls.Add(this.panel3);
            this.tpQtyChanged.Location = new System.Drawing.Point(4, 25);
            this.tpQtyChanged.Name = "tpQtyChanged";
            this.tpQtyChanged.Padding = new System.Windows.Forms.Padding(3);
            this.tpQtyChanged.Size = new System.Drawing.Size(1261, 291);
            this.tpQtyChanged.TabIndex = 0;
            this.tpQtyChanged.Text = "Qty Changed";
            this.tpQtyChanged.UseVisualStyleBackColor = true;
            // 
            // dgvQtyChange
            // 
            this.dgvQtyChange.AllowUserToAddRows = false;
            this.dgvQtyChange.AutoGenerateColumns = false;
            this.dgvQtyChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQtyChange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.toolIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.modelDataGridViewTextBoxColumn1,
            this.actionDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn1,
            this.qtyDataGridViewTextBoxColumn1,
            this.remarkDataGridViewTextBoxColumn1});
            this.dgvQtyChange.DataSource = this.toolQtyChangeModelBindingSource;
            this.dgvQtyChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQtyChange.Location = new System.Drawing.Point(3, 46);
            this.dgvQtyChange.MultiSelect = false;
            this.dgvQtyChange.Name = "dgvQtyChange";
            this.dgvQtyChange.RowHeadersVisible = false;
            this.dgvQtyChange.RowHeadersWidth = 51;
            this.dgvQtyChange.RowTemplate.Height = 27;
            this.dgvQtyChange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQtyChange.Size = new System.Drawing.Size(1255, 242);
            this.dgvQtyChange.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExportQtyChanged);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1255, 43);
            this.panel3.TabIndex = 0;
            // 
            // btnExportQtyChanged
            // 
            this.btnExportQtyChanged.AutoSize = true;
            this.btnExportQtyChanged.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportQtyChanged.Location = new System.Drawing.Point(0, 0);
            this.btnExportQtyChanged.Name = "btnExportQtyChanged";
            this.btnExportQtyChanged.Size = new System.Drawing.Size(137, 43);
            this.btnExportQtyChanged.TabIndex = 1;
            this.btnExportQtyChanged.Text = "Export To Excel";
            this.btnExportQtyChanged.UseVisualStyleBackColor = true;
            // 
            // tpInOut
            // 
            this.tpInOut.Controls.Add(this.dgvLend);
            this.tpInOut.Controls.Add(this.panel4);
            this.tpInOut.Location = new System.Drawing.Point(4, 25);
            this.tpInOut.Name = "tpInOut";
            this.tpInOut.Padding = new System.Windows.Forms.Padding(3);
            this.tpInOut.Size = new System.Drawing.Size(1261, 291);
            this.tpInOut.TabIndex = 1;
            this.tpInOut.Text = "Lend Record";
            this.tpInOut.UseVisualStyleBackColor = true;
            // 
            // dgvLend
            // 
            this.dgvLend.AllowUserToAddRows = false;
            this.dgvLend.AutoGenerateColumns = false;
            this.dgvLend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.toolIdDataGridViewTextBoxColumn1,
            this.toolNameDataGridViewTextBoxColumn,
            this.toolModelDataGridViewTextBoxColumn,
            this.lendPersonDataGridViewTextBoxColumn,
            this.lendDateDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn2,
            this.returnPersonDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.lendQtyDataGridViewTextBoxColumn,
            this.returnQtyDataGridViewTextBoxColumn,
            this.diffQtyDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn2});
            this.dgvLend.DataSource = this.toolLendModelBindingSource;
            this.dgvLend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLend.Location = new System.Drawing.Point(3, 46);
            this.dgvLend.MultiSelect = false;
            this.dgvLend.Name = "dgvLend";
            this.dgvLend.RowHeadersVisible = false;
            this.dgvLend.RowHeadersWidth = 51;
            this.dgvLend.RowTemplate.Height = 27;
            this.dgvLend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLend.Size = new System.Drawing.Size(1255, 242);
            this.dgvLend.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbSearchLend);
            this.panel4.Controls.Add(this.btnSearchLend);
            this.panel4.Controls.Add(this.btnExportLend);
            this.panel4.Controls.Add(this.btnReturn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1255, 43);
            this.panel4.TabIndex = 2;
            // 
            // cmbSearchLend
            // 
            this.cmbSearchLend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearchLend.FormattingEnabled = true;
            this.cmbSearchLend.Location = new System.Drawing.Point(855, 9);
            this.cmbSearchLend.Name = "cmbSearchLend";
            this.cmbSearchLend.Size = new System.Drawing.Size(304, 23);
            this.cmbSearchLend.TabIndex = 5;
            // 
            // btnSearchLend
            // 
            this.btnSearchLend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchLend.Location = new System.Drawing.Point(1180, 0);
            this.btnSearchLend.Name = "btnSearchLend";
            this.btnSearchLend.Size = new System.Drawing.Size(75, 43);
            this.btnSearchLend.TabIndex = 4;
            this.btnSearchLend.Text = "Search";
            this.btnSearchLend.UseVisualStyleBackColor = true;
            this.btnSearchLend.Click += new System.EventHandler(this.btnSearchLend_Click);
            // 
            // btnExportLend
            // 
            this.btnExportLend.AutoSize = true;
            this.btnExportLend.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportLend.Location = new System.Drawing.Point(85, 0);
            this.btnExportLend.Name = "btnExportLend";
            this.btnExportLend.Size = new System.Drawing.Size(137, 43);
            this.btnExportLend.TabIndex = 3;
            this.btnExportLend.Text = "Export To Excel";
            this.btnExportLend.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReturn.Location = new System.Drawing.Point(0, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(85, 43);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // toolTypeDataGridViewTextBoxColumn
            // 
            this.toolTypeDataGridViewTextBoxColumn.DataPropertyName = "ToolType";
            this.toolTypeDataGridViewTextBoxColumn.HeaderText = "ToolType";
            this.toolTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toolTypeDataGridViewTextBoxColumn.Name = "toolTypeDataGridViewTextBoxColumn";
            this.toolTypeDataGridViewTextBoxColumn.Width = 125;
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
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // toolModelBindingSource
            // 
            this.toolModelBindingSource.DataSource = typeof(Models.ToolModel);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // toolIdDataGridViewTextBoxColumn
            // 
            this.toolIdDataGridViewTextBoxColumn.DataPropertyName = "ToolId";
            this.toolIdDataGridViewTextBoxColumn.HeaderText = "ToolId";
            this.toolIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toolIdDataGridViewTextBoxColumn.Name = "toolIdDataGridViewTextBoxColumn";
            this.toolIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn1
            // 
            this.modelDataGridViewTextBoxColumn1.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn1.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn1.Name = "modelDataGridViewTextBoxColumn1";
            this.modelDataGridViewTextBoxColumn1.Width = 125;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitsDataGridViewTextBoxColumn1
            // 
            this.unitsDataGridViewTextBoxColumn1.DataPropertyName = "Units";
            this.unitsDataGridViewTextBoxColumn1.HeaderText = "Units";
            this.unitsDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.unitsDataGridViewTextBoxColumn1.Name = "unitsDataGridViewTextBoxColumn1";
            this.unitsDataGridViewTextBoxColumn1.Width = 125;
            // 
            // qtyDataGridViewTextBoxColumn1
            // 
            this.qtyDataGridViewTextBoxColumn1.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn1.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn1.Name = "qtyDataGridViewTextBoxColumn1";
            this.qtyDataGridViewTextBoxColumn1.Width = 125;
            // 
            // remarkDataGridViewTextBoxColumn1
            // 
            this.remarkDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarkDataGridViewTextBoxColumn1.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn1.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.remarkDataGridViewTextBoxColumn1.Name = "remarkDataGridViewTextBoxColumn1";
            // 
            // toolQtyChangeModelBindingSource
            // 
            this.toolQtyChangeModelBindingSource.DataSource = typeof(Models.ToolQtyChangeModel);
            // 
            // toolLendModelBindingSource
            // 
            this.toolLendModelBindingSource.DataSource = typeof(Models.ToolLendModel);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // toolIdDataGridViewTextBoxColumn1
            // 
            this.toolIdDataGridViewTextBoxColumn1.DataPropertyName = "ToolId";
            this.toolIdDataGridViewTextBoxColumn1.HeaderText = "ToolId";
            this.toolIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.toolIdDataGridViewTextBoxColumn1.Name = "toolIdDataGridViewTextBoxColumn1";
            this.toolIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // toolNameDataGridViewTextBoxColumn
            // 
            this.toolNameDataGridViewTextBoxColumn.DataPropertyName = "ToolName";
            this.toolNameDataGridViewTextBoxColumn.HeaderText = "ToolName";
            this.toolNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toolNameDataGridViewTextBoxColumn.Name = "toolNameDataGridViewTextBoxColumn";
            this.toolNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // toolModelDataGridViewTextBoxColumn
            // 
            this.toolModelDataGridViewTextBoxColumn.DataPropertyName = "ToolModel";
            this.toolModelDataGridViewTextBoxColumn.HeaderText = "ToolModel";
            this.toolModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toolModelDataGridViewTextBoxColumn.Name = "toolModelDataGridViewTextBoxColumn";
            this.toolModelDataGridViewTextBoxColumn.Width = 125;
            // 
            // lendPersonDataGridViewTextBoxColumn
            // 
            this.lendPersonDataGridViewTextBoxColumn.DataPropertyName = "LendPerson";
            this.lendPersonDataGridViewTextBoxColumn.HeaderText = "LendPerson";
            this.lendPersonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendPersonDataGridViewTextBoxColumn.Name = "lendPersonDataGridViewTextBoxColumn";
            this.lendPersonDataGridViewTextBoxColumn.Width = 125;
            // 
            // lendDateDataGridViewTextBoxColumn
            // 
            this.lendDateDataGridViewTextBoxColumn.DataPropertyName = "LendDate";
            this.lendDateDataGridViewTextBoxColumn.HeaderText = "LendDate";
            this.lendDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendDateDataGridViewTextBoxColumn.Name = "lendDateDataGridViewTextBoxColumn";
            this.lendDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitsDataGridViewTextBoxColumn2
            // 
            this.unitsDataGridViewTextBoxColumn2.DataPropertyName = "Units";
            this.unitsDataGridViewTextBoxColumn2.HeaderText = "Units";
            this.unitsDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.unitsDataGridViewTextBoxColumn2.Name = "unitsDataGridViewTextBoxColumn2";
            this.unitsDataGridViewTextBoxColumn2.Width = 125;
            // 
            // returnPersonDataGridViewTextBoxColumn
            // 
            this.returnPersonDataGridViewTextBoxColumn.DataPropertyName = "ReturnPerson";
            this.returnPersonDataGridViewTextBoxColumn.HeaderText = "ReturnPerson";
            this.returnPersonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnPersonDataGridViewTextBoxColumn.Name = "returnPersonDataGridViewTextBoxColumn";
            this.returnPersonDataGridViewTextBoxColumn.Width = 125;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // lendQtyDataGridViewTextBoxColumn
            // 
            this.lendQtyDataGridViewTextBoxColumn.DataPropertyName = "LendQty";
            this.lendQtyDataGridViewTextBoxColumn.HeaderText = "LendQty";
            this.lendQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lendQtyDataGridViewTextBoxColumn.Name = "lendQtyDataGridViewTextBoxColumn";
            this.lendQtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // returnQtyDataGridViewTextBoxColumn
            // 
            this.returnQtyDataGridViewTextBoxColumn.DataPropertyName = "ReturnQty";
            this.returnQtyDataGridViewTextBoxColumn.HeaderText = "ReturnQty";
            this.returnQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnQtyDataGridViewTextBoxColumn.Name = "returnQtyDataGridViewTextBoxColumn";
            this.returnQtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // diffQtyDataGridViewTextBoxColumn
            // 
            this.diffQtyDataGridViewTextBoxColumn.DataPropertyName = "DiffQty";
            this.diffQtyDataGridViewTextBoxColumn.HeaderText = "DiffQty";
            this.diffQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diffQtyDataGridViewTextBoxColumn.Name = "diffQtyDataGridViewTextBoxColumn";
            this.diffQtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // remarkDataGridViewTextBoxColumn2
            // 
            this.remarkDataGridViewTextBoxColumn2.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn2.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.remarkDataGridViewTextBoxColumn2.Name = "remarkDataGridViewTextBoxColumn2";
            this.remarkDataGridViewTextBoxColumn2.Width = 125;
            // 
            // ToolFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 704);
            this.Controls.Add(this.splTool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToolFrm";
            this.Text = "ToolFrm";
            this.Load += new System.EventHandler(this.ToolFrm_Load);
            this.splTool.Panel1.ResumeLayout(false);
            this.splTool.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splTool)).EndInit();
            this.splTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabTool.ResumeLayout(false);
            this.tpQtyChanged.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQtyChange)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpInOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLend)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolQtyChangeModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolLendModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource toolModelBindingSource;
        private System.Windows.Forms.SplitContainer splTool;
        private System.Windows.Forms.DataGridView dgvTools;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQtyChange;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabTool;
        private System.Windows.Forms.TabPage tpQtyChanged;
        private System.Windows.Forms.DataGridView dgvQtyChange;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExportQtyChanged;
        private System.Windows.Forms.TabPage tpInOut;
        private System.Windows.Forms.DataGridView dgvLend;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExportLend;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLendTool;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource toolQtyChangeModelBindingSource;
        private System.Windows.Forms.BindingSource toolLendModelBindingSource;
        private System.Windows.Forms.ComboBox cmbSearchLend;
        private System.Windows.Forms.Button btnSearchLend;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diffQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn2;
    }
}