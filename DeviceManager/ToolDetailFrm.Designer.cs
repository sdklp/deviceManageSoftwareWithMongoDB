
namespace DeviceManager
{
    partial class ToolDetailFrm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chkContinue = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.toolModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(286, 9);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 37);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkContinue
            // 
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(20, 17);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(125, 19);
            this.chkContinue.TabIndex = 1;
            this.chkContinue.Text = "Continue Add";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.chkContinue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 589);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 52);
            this.panel1.TabIndex = 4;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(407, 9);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 37);
            this.btnCancle.TabIndex = 0;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolModelBindingSource, "Id", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(137, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(276, 25);
            this.txtID.TabIndex = 5;
            // 
            // toolModelBindingSource
            // 
            this.toolModelBindingSource.DataSource = typeof(Models.ToolModel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tool Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Units:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Qty:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Balance:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Remark:";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolModelBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(137, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(505, 25);
            this.txtName.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolModelBindingSource, "Model", true));
            this.txtModel.Location = new System.Drawing.Point(137, 133);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(505, 25);
            this.txtModel.TabIndex = 5;
            // 
            // txtQty
            // 
            this.txtQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolModelBindingSource, "Qty", true));
            this.txtQty.Location = new System.Drawing.Point(137, 291);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(136, 25);
            this.txtQty.TabIndex = 5;
            // 
            // txtBalance
            // 
            this.txtBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolModelBindingSource, "Balance", true));
            this.txtBalance.Location = new System.Drawing.Point(137, 353);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(136, 25);
            this.txtBalance.TabIndex = 5;
            // 
            // txtRemark
            // 
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolModelBindingSource, "Remark", true));
            this.txtRemark.Location = new System.Drawing.Point(137, 415);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(505, 137);
            this.txtRemark.TabIndex = 5;
            // 
            // cmbType
            // 
            this.cmbType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolModelBindingSource, "ToolType", true));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(137, 183);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(276, 23);
            this.cmbType.TabIndex = 2;
            this.cmbType.DropDown += new System.EventHandler(this.cmbType_DropDown);
            // 
            // cmbUnits
            // 
            this.cmbUnits.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolModelBindingSource, "Units", true));
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(137, 239);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(276, 23);
            this.cmbUnits.TabIndex = 2;
            this.cmbUnits.DropDown += new System.EventHandler(this.cmbUnits_DropDown);
            // 
            // ToolDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 641);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUnits);
            this.Controls.Add(this.cmbType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolDetailFrm";
            this.Load += new System.EventHandler(this.ToolDetailFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.BindingSource toolModelBindingSource;
    }
}