
namespace DeviceManager
{
    partial class SubDeviceFrm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddSibling = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtSubDevice = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tvwSubDevice = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.subDeviceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subDeviceModelBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAddSibling);
            this.panel1.Controls.Add(this.btnAddChild);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(339, 565);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 55);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(373, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(293, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 37);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(213, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 37);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddSibling
            // 
            this.btnAddSibling.AutoSize = true;
            this.btnAddSibling.Location = new System.Drawing.Point(103, 9);
            this.btnAddSibling.Name = "btnAddSibling";
            this.btnAddSibling.Size = new System.Drawing.Size(105, 37);
            this.btnAddSibling.TabIndex = 0;
            this.btnAddSibling.Text = "Add Sibling";
            this.btnAddSibling.UseVisualStyleBackColor = true;
            this.btnAddSibling.Click += new System.EventHandler(this.btnAddSibling_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.AutoSize = true;
            this.btnAddChild.Location = new System.Drawing.Point(9, 9);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(89, 37);
            this.btnAddChild.TabIndex = 0;
            this.btnAddChild.Text = "Add Child";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.txtPid);
            this.pnlContainer.Controls.Add(this.txtSubDevice);
            this.pnlContainer.Controls.Add(this.label3);
            this.pnlContainer.Controls.Add(this.txtID);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Enabled = false;
            this.pnlContainer.Location = new System.Drawing.Point(339, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(461, 565);
            this.pnlContainer.TabIndex = 1;
            // 
            // txtSubDevice
            // 
            this.txtSubDevice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subDeviceModelBindingSource, "SubDevice", true));
            this.txtSubDevice.Location = new System.Drawing.Point(129, 258);
            this.txtSubDevice.Name = "txtSubDevice";
            this.txtSubDevice.Size = new System.Drawing.Size(292, 25);
            this.txtSubDevice.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subDeviceModelBindingSource, "Id", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(129, 188);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(292, 25);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "SubDevice:";
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
            // tvwSubDevice
            // 
            this.tvwSubDevice.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvwSubDevice.Location = new System.Drawing.Point(0, 0);
            this.tvwSubDevice.Name = "tvwSubDevice";
            this.tvwSubDevice.Size = new System.Drawing.Size(339, 620);
            this.tvwSubDevice.TabIndex = 2;
            this.tvwSubDevice.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwSubDevice_BeforeExpand);
            this.tvwSubDevice.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwSubDevice_AfterSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "PID:";
            // 
            // txtPid
            // 
            this.txtPid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subDeviceModelBindingSource, "Pid", true));
            this.txtPid.Enabled = false;
            this.txtPid.Location = new System.Drawing.Point(129, 321);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(292, 25);
            this.txtPid.TabIndex = 1;
            // 
            // subDeviceModelBindingSource
            // 
            this.subDeviceModelBindingSource.DataSource = typeof(Models.SubDeviceModel);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(339, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 28);
            this.panel2.TabIndex = 3;
            // 
            // SubDeviceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tvwSubDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubDeviceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubDeviceFrm";
            this.Load += new System.EventHandler(this.SubDeviceFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subDeviceModelBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TextBox txtSubDevice;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvwSubDevice;
        private System.Windows.Forms.Button btnAddSibling;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource subDeviceModelBindingSource;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
    }
}