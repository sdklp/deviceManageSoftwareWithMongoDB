
namespace DeviceManager
{
    partial class SparePartSelectFrm
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
            this.dgvSparePart = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparePart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.unitsDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.minQtyDataGridViewTextBoxColumn,
            this.maxQtyDataGridViewTextBoxColumn,
            this.detailDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.agencyDataGridViewTextBoxColumn});
            this.dgvSparePart.DataSource = this.sparePartModelBindingSource;
            this.dgvSparePart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSparePart.Location = new System.Drawing.Point(0, 47);
            this.dgvSparePart.MultiSelect = false;
            this.dgvSparePart.Name = "dgvSparePart";
            this.dgvSparePart.RowHeadersVisible = false;
            this.dgvSparePart.RowHeadersWidth = 51;
            this.dgvSparePart.RowTemplate.Height = 27;
            this.dgvSparePart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSparePart.Size = new System.Drawing.Size(800, 403);
            this.dgvSparePart.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // unitsDataGridViewTextBoxColumn
            // 
            this.unitsDataGridViewTextBoxColumn.DataPropertyName = "Units";
            this.unitsDataGridViewTextBoxColumn.HeaderText = "Units";
            this.unitsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitsDataGridViewTextBoxColumn.Name = "unitsDataGridViewTextBoxColumn";
            this.unitsDataGridViewTextBoxColumn.Width = 125;
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
            // detailDataGridViewTextBoxColumn
            // 
            this.detailDataGridViewTextBoxColumn.DataPropertyName = "Detail";
            this.detailDataGridViewTextBoxColumn.HeaderText = "Detail";
            this.detailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailDataGridViewTextBoxColumn.Name = "detailDataGridViewTextBoxColumn";
            this.detailDataGridViewTextBoxColumn.Width = 125;
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
            // sparePartModelBindingSource
            // 
            this.sparePartModelBindingSource.DataSource = typeof(Models.SparePartModel);
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
            this.panel1.TabIndex = 2;
            // 
            // cmbSearch
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(81, 12);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(237, 23);
            this.cmbSearch.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Location = new System.Drawing.Point(725, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 47);
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
            this.btnSearch.Size = new System.Drawing.Size(75, 47);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // SparePartSelectFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSparePart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SparePartSelectFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SparePartSelectFrm";
            this.Load += new System.EventHandler(this.SparePartSelectFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparePart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSparePart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sparePartModelBindingSource;
    }
}