
namespace DeviceManager
{
    partial class DeviceStatusFrm
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDevieStatus = new System.Windows.Forms.DataGridView();
            this.deviceStatusModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevieStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceStatusModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.txtStatus);
            this.pnlContainer.Controls.Add(this.txtID);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Enabled = false;
            this.pnlContainer.Location = new System.Drawing.Point(350, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(450, 620);
            this.pnlContainer.TabIndex = 4;
            // 
            // txtStatus
            // 
            this.txtStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceStatusModelBindingSource, "DeviceStatus", true));
            this.txtStatus.Location = new System.Drawing.Point(129, 258);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(292, 25);
            this.txtStatus.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceStatusModelBindingSource, "Id", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(129, 188);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(292, 25);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(350, 620);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 55);
            this.panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(293, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(212, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 37);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(131, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 37);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDevieStatus
            // 
            this.dgvDevieStatus.AllowUserToAddRows = false;
            this.dgvDevieStatus.AutoGenerateColumns = false;
            this.dgvDevieStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevieStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.deviceStatusDataGridViewTextBoxColumn});
            this.dgvDevieStatus.DataSource = this.deviceStatusModelBindingSource;
            this.dgvDevieStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDevieStatus.Location = new System.Drawing.Point(0, 0);
            this.dgvDevieStatus.MultiSelect = false;
            this.dgvDevieStatus.Name = "dgvDevieStatus";
            this.dgvDevieStatus.RowHeadersVisible = false;
            this.dgvDevieStatus.RowHeadersWidth = 51;
            this.dgvDevieStatus.RowTemplate.Height = 27;
            this.dgvDevieStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevieStatus.Size = new System.Drawing.Size(350, 675);
            this.dgvDevieStatus.TabIndex = 2;
            // 
            // deviceStatusModelBindingSource
            // 
            this.deviceStatusModelBindingSource.DataSource = typeof(Models.DeviceStatusModel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // deviceStatusDataGridViewTextBoxColumn
            // 
            this.deviceStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deviceStatusDataGridViewTextBoxColumn.DataPropertyName = "DeviceStatus";
            this.deviceStatusDataGridViewTextBoxColumn.HeaderText = "DeviceStatus";
            this.deviceStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deviceStatusDataGridViewTextBoxColumn.Name = "deviceStatusDataGridViewTextBoxColumn";
            // 
            // DeviceStatusFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDevieStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceStatusFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceStatusFrm";
            this.Load += new System.EventHandler(this.DeviceStatusFrm_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevieStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceStatusModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvDevieStatus;
        private System.Windows.Forms.BindingSource deviceStatusModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceStatusDataGridViewTextBoxColumn;
    }
}