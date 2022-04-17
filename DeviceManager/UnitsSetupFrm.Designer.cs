
namespace DeviceManager
{
    partial class UnitsSetupFrm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveUnits = new System.Windows.Forms.Button();
            this.btnCancleUnits = new System.Windows.Forms.Button();
            this.chkContinue = new System.Windows.Forms.CheckBox();
            this.btnEditUnits = new System.Windows.Forms.Button();
            this.btnDeleteUnits = new System.Windows.Forms.Button();
            this.btnAddUnits = new System.Windows.Forms.Button();
            this.dgvUnits = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceUnits = new System.Windows.Forms.BindingSource(this.components);
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtID);
            this.panel4.Controls.Add(this.txtUnits);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(462, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(672, 599);
            this.panel4.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsModelBindingSource, "Id", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(269, 204);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 25);
            this.txtID.TabIndex = 1;
            // 
            // txtUnits
            // 
            this.txtUnits.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsModelBindingSource, "Units", true));
            this.txtUnits.Enabled = false;
            this.txtUnits.Location = new System.Drawing.Point(269, 268);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(227, 25);
            this.txtUnits.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Units Name:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.btnSaveUnits);
            this.panel3.Controls.Add(this.btnCancleUnits);
            this.panel3.Controls.Add(this.chkContinue);
            this.panel3.Controls.Add(this.btnEditUnits);
            this.panel3.Controls.Add(this.btnDeleteUnits);
            this.panel3.Controls.Add(this.btnAddUnits);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(462, 599);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 53);
            this.panel3.TabIndex = 5;
            // 
            // btnSaveUnits
            // 
            this.btnSaveUnits.Location = new System.Drawing.Point(584, 9);
            this.btnSaveUnits.Name = "btnSaveUnits";
            this.btnSaveUnits.Size = new System.Drawing.Size(75, 34);
            this.btnSaveUnits.TabIndex = 0;
            this.btnSaveUnits.Text = "Save";
            this.btnSaveUnits.UseVisualStyleBackColor = true;
            this.btnSaveUnits.Click += new System.EventHandler(this.btnSaveUnits_Click);
            // 
            // btnCancleUnits
            // 
            this.btnCancleUnits.Location = new System.Drawing.Point(493, 9);
            this.btnCancleUnits.Name = "btnCancleUnits";
            this.btnCancleUnits.Size = new System.Drawing.Size(75, 34);
            this.btnCancleUnits.TabIndex = 0;
            this.btnCancleUnits.Text = "Cancle";
            this.btnCancleUnits.UseVisualStyleBackColor = true;
            this.btnCancleUnits.Click += new System.EventHandler(this.btnCancleUnits_Click);
            // 
            // chkContinue
            // 
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(6, 18);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(125, 19);
            this.chkContinue.TabIndex = 0;
            this.chkContinue.Text = "Continue Add";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // btnEditUnits
            // 
            this.btnEditUnits.Location = new System.Drawing.Point(402, 9);
            this.btnEditUnits.Name = "btnEditUnits";
            this.btnEditUnits.Size = new System.Drawing.Size(75, 34);
            this.btnEditUnits.TabIndex = 0;
            this.btnEditUnits.Text = "Edit";
            this.btnEditUnits.UseVisualStyleBackColor = true;
            this.btnEditUnits.Click += new System.EventHandler(this.btnEditUnits_Click);
            // 
            // btnDeleteUnits
            // 
            this.btnDeleteUnits.Location = new System.Drawing.Point(311, 9);
            this.btnDeleteUnits.Name = "btnDeleteUnits";
            this.btnDeleteUnits.Size = new System.Drawing.Size(75, 34);
            this.btnDeleteUnits.TabIndex = 0;
            this.btnDeleteUnits.Text = "Delete";
            this.btnDeleteUnits.UseVisualStyleBackColor = true;
            this.btnDeleteUnits.Click += new System.EventHandler(this.btnDeleteUnits_Click);
            // 
            // btnAddUnits
            // 
            this.btnAddUnits.Location = new System.Drawing.Point(220, 9);
            this.btnAddUnits.Name = "btnAddUnits";
            this.btnAddUnits.Size = new System.Drawing.Size(75, 34);
            this.btnAddUnits.TabIndex = 0;
            this.btnAddUnits.Text = "Add";
            this.btnAddUnits.UseVisualStyleBackColor = true;
            this.btnAddUnits.Click += new System.EventHandler(this.btnAddUnits_Click);
            // 
            // dgvUnits
            // 
            this.dgvUnits.AllowUserToAddRows = false;
            this.dgvUnits.AutoGenerateColumns = false;
            this.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn});
            this.dgvUnits.DataSource = this.unitsModelBindingSource;
            this.dgvUnits.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvUnits.Location = new System.Drawing.Point(0, 0);
            this.dgvUnits.MultiSelect = false;
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.RowHeadersVisible = false;
            this.dgvUnits.RowHeadersWidth = 51;
            this.dgvUnits.RowTemplate.Height = 27;
            this.dgvUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnits.Size = new System.Drawing.Size(462, 652);
            this.dgvUnits.TabIndex = 2;
            this.dgvUnits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnits_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitsDataGridViewTextBoxColumn
            // 
            this.unitsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitsDataGridViewTextBoxColumn.DataPropertyName = "Units";
            this.unitsDataGridViewTextBoxColumn.HeaderText = "Units";
            this.unitsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitsDataGridViewTextBoxColumn.Name = "unitsDataGridViewTextBoxColumn";
            // 
            // unitsModelBindingSource
            // 
            this.unitsModelBindingSource.DataSource = typeof(Models.UnitsModel);
            // 
            // bindingSourceUnits
            // 
            this.bindingSourceUnits.DataSource = typeof(Models.UnitsModel);
            // 
            // UnitsSetupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 652);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvUnits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitsSetupFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnitsSetupFrm";
            this.Load += new System.EventHandler(this.UnitsSetupFrm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSaveUnits;
        private System.Windows.Forms.Button btnCancleUnits;
        private System.Windows.Forms.CheckBox chkContinue;
        private System.Windows.Forms.Button btnEditUnits;
        private System.Windows.Forms.Button btnDeleteUnits;
        private System.Windows.Forms.Button btnAddUnits;
        private System.Windows.Forms.DataGridView dgvUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource unitsModelBindingSource;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceUnits;
    }
}