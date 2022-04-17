
namespace DeviceManager
{
    partial class ToolLendRecordFrm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvToolLend = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diffQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolLendModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToolLend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolLendModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 43);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 43);
            this.panel2.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(812, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 25);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(1053, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 43);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvToolLend
            // 
            this.dgvToolLend.AllowUserToAddRows = false;
            this.dgvToolLend.AutoGenerateColumns = false;
            this.dgvToolLend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToolLend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.toolIdDataGridViewTextBoxColumn,
            this.toolNameDataGridViewTextBoxColumn,
            this.toolModelDataGridViewTextBoxColumn,
            this.lendPersonDataGridViewTextBoxColumn,
            this.lendDateDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn,
            this.returnPersonDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.lendQtyDataGridViewTextBoxColumn,
            this.returnQtyDataGridViewTextBoxColumn,
            this.diffQtyDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dgvToolLend.DataSource = this.toolLendModelBindingSource;
            this.dgvToolLend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvToolLend.Location = new System.Drawing.Point(0, 86);
            this.dgvToolLend.Name = "dgvToolLend";
            this.dgvToolLend.RowHeadersWidth = 51;
            this.dgvToolLend.RowTemplate.Height = 27;
            this.dgvToolLend.Size = new System.Drawing.Size(1128, 508);
            this.dgvToolLend.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // toolIdDataGridViewTextBoxColumn
            // 
            this.toolIdDataGridViewTextBoxColumn.DataPropertyName = "ToolId";
            this.toolIdDataGridViewTextBoxColumn.HeaderText = "ToolId";
            this.toolIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toolIdDataGridViewTextBoxColumn.Name = "toolIdDataGridViewTextBoxColumn";
            this.toolIdDataGridViewTextBoxColumn.Width = 125;
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
            // unitsDataGridViewTextBoxColumn
            // 
            this.unitsDataGridViewTextBoxColumn.DataPropertyName = "Units";
            this.unitsDataGridViewTextBoxColumn.HeaderText = "Units";
            this.unitsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitsDataGridViewTextBoxColumn.Name = "unitsDataGridViewTextBoxColumn";
            this.unitsDataGridViewTextBoxColumn.Width = 125;
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
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.Width = 125;
            // 
            // toolLendModelBindingSource
            // 
            this.toolLendModelBindingSource.DataSource = typeof(Models.ToolLendModel);
            // 
            // ToolLendRecordFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 594);
            this.Controls.Add(this.dgvToolLend);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToolLendRecordFrm";
            this.Text = "ToolLendRecordFrm";
            this.Load += new System.EventHandler(this.ToolLendRecordFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToolLend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolLendModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvToolLend;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diffQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource toolLendModelBindingSource;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}