
namespace DeviceManager
{
    partial class SparePartDetailFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.sparePartModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtMinQty = new System.Windows.Forms.TextBox();
            this.txtMaxQty = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.cmbAgency = new System.Windows.Forms.ComboBox();
            this.btnCancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(389, 518);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 36);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkContinue
            // 
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(48, 527);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(125, 19);
            this.chkContinue.TabIndex = 2;
            this.chkContinue.Text = "Continue Add";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Units:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Balance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "MinQty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "MaxQty:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Detail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Manufacturer:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Agency:";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "Id", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(164, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(242, 25);
            this.txtID.TabIndex = 4;
            // 
            // sparePartModelBindingSource
            // 
            this.sparePartModelBindingSource.DataSource = typeof(Models.SparePartModel);
            // 
            // txtModel
            // 
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "PModel", true));
            this.txtModel.Location = new System.Drawing.Point(164, 129);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(597, 25);
            this.txtModel.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "PName", true));
            this.txtName.Location = new System.Drawing.Point(164, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(597, 25);
            this.txtName.TabIndex = 4;
            // 
            // txtNo
            // 
            this.txtNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "PNo", true));
            this.txtNo.Location = new System.Drawing.Point(519, 36);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(242, 25);
            this.txtNo.TabIndex = 4;
            // 
            // cmbUnits
            // 
            this.cmbUnits.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "Units", true));
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(164, 177);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(242, 23);
            this.cmbUnits.TabIndex = 1;
            this.cmbUnits.DropDown += new System.EventHandler(this.cmbUnits_DropDown);
            // 
            // txtBalance
            // 
            this.txtBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "Balance", true));
            this.txtBalance.Location = new System.Drawing.Point(519, 176);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(242, 25);
            this.txtBalance.TabIndex = 4;
            // 
            // txtMinQty
            // 
            this.txtMinQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "MinQty", true));
            this.txtMinQty.Location = new System.Drawing.Point(164, 221);
            this.txtMinQty.Name = "txtMinQty";
            this.txtMinQty.Size = new System.Drawing.Size(242, 25);
            this.txtMinQty.TabIndex = 4;
            // 
            // txtMaxQty
            // 
            this.txtMaxQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "MaxQty", true));
            this.txtMaxQty.Location = new System.Drawing.Point(519, 221);
            this.txtMaxQty.Name = "txtMaxQty";
            this.txtMaxQty.Size = new System.Drawing.Size(242, 25);
            this.txtMaxQty.TabIndex = 4;
            // 
            // txtRemark
            // 
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "Detail", true));
            this.txtRemark.Location = new System.Drawing.Point(164, 375);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(597, 126);
            this.txtRemark.TabIndex = 4;
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "Manufacturer", true));
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(164, 265);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(597, 23);
            this.cmbManufacturer.TabIndex = 1;
            this.cmbManufacturer.DropDown += new System.EventHandler(this.cmbManufacturer_DropDown);
            // 
            // cmbAgency
            // 
            this.cmbAgency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartModelBindingSource, "Agency", true));
            this.cmbAgency.FormattingEnabled = true;
            this.cmbAgency.Location = new System.Drawing.Point(164, 313);
            this.cmbAgency.Name = "cmbAgency";
            this.cmbAgency.Size = new System.Drawing.Size(597, 23);
            this.cmbAgency.TabIndex = 1;
            this.cmbAgency.DropDown += new System.EventHandler(this.cmbAgency_DropDown);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(500, 518);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(84, 36);
            this.btnCancle.TabIndex = 0;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // SparePartDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 573);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtMaxQty);
            this.Controls.Add(this.txtMinQty);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkContinue);
            this.Controls.Add(this.cmbUnits);
            this.Controls.Add(this.cmbAgency);
            this.Controls.Add(this.cmbManufacturer);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SparePartDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SparePartDetailFrm";
            ((System.ComponentModel.ISupportInitialize)(this.sparePartModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtMinQty;
        private System.Windows.Forms.TextBox txtMaxQty;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.ComboBox cmbAgency;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.BindingSource sparePartModelBindingSource;
    }
}