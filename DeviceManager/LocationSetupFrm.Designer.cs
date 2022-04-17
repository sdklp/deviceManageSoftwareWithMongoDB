
namespace DeviceManager
{
    partial class LocationSetupFrm
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
            this.chkContinue = new System.Windows.Forms.CheckBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.locationModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddSibling = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.tvwLocation = new System.Windows.Forms.TreeView();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationModelBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkContinue
            // 
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(588, 19);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(125, 19);
            this.chkContinue.TabIndex = 0;
            this.chkContinue.Text = "Continue Add";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.txtRemark);
            this.pnlContainer.Controls.Add(this.txtNodeName);
            this.pnlContainer.Controls.Add(this.txtPid);
            this.pnlContainer.Controls.Add(this.txtLocation);
            this.pnlContainer.Controls.Add(this.label4);
            this.pnlContainer.Controls.Add(this.label5);
            this.pnlContainer.Controls.Add(this.txtID);
            this.pnlContainer.Controls.Add(this.label6);
            this.pnlContainer.Controls.Add(this.label3);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(371, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(725, 467);
            this.pnlContainer.TabIndex = 4;
            // 
            // txtRemark
            // 
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationModelBindingSource, "Remark", true));
            this.txtRemark.Location = new System.Drawing.Point(236, 309);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(254, 114);
            this.txtRemark.TabIndex = 1;
            // 
            // locationModelBindingSource
            // 
            this.locationModelBindingSource.DataSource = typeof(Models.LocationModel);
            // 
            // txtNodeName
            // 
            this.txtNodeName.Enabled = false;
            this.txtNodeName.Location = new System.Drawing.Point(236, 251);
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(254, 25);
            this.txtNodeName.TabIndex = 1;
            // 
            // txtPid
            // 
            this.txtPid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationModelBindingSource, "Pid", true));
            this.txtPid.Enabled = false;
            this.txtPid.Location = new System.Drawing.Point(233, 159);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(254, 25);
            this.txtPid.TabIndex = 1;
            // 
            // txtLocation
            // 
            this.txtLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationModelBindingSource, "LName", true));
            this.txtLocation.Location = new System.Drawing.Point(233, 104);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(254, 25);
            this.txtLocation.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Remark:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationModelBindingSource, "Id", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(233, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(254, 25);
            this.txtID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Selected Node Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.chkContinue);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancle);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAddSibling);
            this.panel2.Controls.Add(this.btnAddChild);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(371, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 51);
            this.panel2.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(479, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(307, 6);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 42);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(393, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 42);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(221, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 42);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddSibling
            // 
            this.btnAddSibling.AutoSize = true;
            this.btnAddSibling.Location = new System.Drawing.Point(105, 6);
            this.btnAddSibling.Name = "btnAddSibling";
            this.btnAddSibling.Size = new System.Drawing.Size(105, 42);
            this.btnAddSibling.TabIndex = 1;
            this.btnAddSibling.Text = "Add Sibling";
            this.btnAddSibling.UseVisualStyleBackColor = true;
            this.btnAddSibling.Click += new System.EventHandler(this.btnAddSibling_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.AutoSize = true;
            this.btnAddChild.Location = new System.Drawing.Point(5, 6);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(89, 42);
            this.btnAddChild.TabIndex = 1;
            this.btnAddChild.Text = "Add Child";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // tvwLocation
            // 
            this.tvwLocation.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvwLocation.Location = new System.Drawing.Point(0, 0);
            this.tvwLocation.Name = "tvwLocation";
            this.tvwLocation.Size = new System.Drawing.Size(371, 518);
            this.tvwLocation.TabIndex = 3;
            this.tvwLocation.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwLocation_BeforeExpand);
            this.tvwLocation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwLocation_AfterSelect);
            // 
            // LocationSetupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 518);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tvwLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LocationSetupFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocationSetupFrm";
            this.Load += new System.EventHandler(this.LocationSetupFrm_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationModelBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkContinue;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtNodeName;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddSibling;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.TreeView tvwLocation;
        private System.Windows.Forms.BindingSource locationModelBindingSource;
    }
}