
namespace DeviceManager
{
    partial class SparePartBalanceFrm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbPutIn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.rdbPutOut = new System.Windows.Forms.RadioButton();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(229, 540);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 42);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = " ";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(144, 150);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(202, 25);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            this.dtpDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDate_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // rdbPutIn
            // 
            this.rdbPutIn.AutoSize = true;
            this.rdbPutIn.Location = new System.Drawing.Point(144, 267);
            this.rdbPutIn.Name = "rdbPutIn";
            this.rdbPutIn.Size = new System.Drawing.Size(76, 19);
            this.rdbPutIn.TabIndex = 3;
            this.rdbPutIn.TabStop = true;
            this.rdbPutIn.Text = "Put In";
            this.rdbPutIn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Person:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Units:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Qty:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Remark:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(144, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(206, 25);
            this.txtId.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Pid:";
            // 
            // txtPid
            // 
            this.txtPid.Enabled = false;
            this.txtPid.Location = new System.Drawing.Point(144, 81);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(206, 25);
            this.txtPid.TabIndex = 4;
            // 
            // cmbPerson
            // 
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(144, 203);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(206, 23);
            this.cmbPerson.TabIndex = 5;
            this.cmbPerson.DropDown += new System.EventHandler(this.cmbPerson_DropDown);
            // 
            // cmbUnits
            // 
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(144, 316);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(206, 23);
            this.cmbUnits.TabIndex = 5;
            this.cmbUnits.DropDown += new System.EventHandler(this.cmbUnits_DropDown);
            // 
            // rdbPutOut
            // 
            this.rdbPutOut.AutoSize = true;
            this.rdbPutOut.Location = new System.Drawing.Point(144, 267);
            this.rdbPutOut.Name = "rdbPutOut";
            this.rdbPutOut.Size = new System.Drawing.Size(84, 19);
            this.rdbPutOut.TabIndex = 3;
            this.rdbPutOut.TabStop = true;
            this.rdbPutOut.Text = "Put Out";
            this.rdbPutOut.UseVisualStyleBackColor = true;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(144, 382);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(206, 25);
            this.txtQty.TabIndex = 4;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(144, 448);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(484, 68);
            this.txtRemark.TabIndex = 4;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(346, 540);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 42);
            this.btnCancle.TabIndex = 0;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // SparePartBalanceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 607);
            this.Controls.Add(this.cmbUnits);
            this.Controls.Add(this.cmbPerson);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPid);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.rdbPutOut);
            this.Controls.Add(this.rdbPutIn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SparePartBalanceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SparePartBalanceFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbPutIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.RadioButton rdbPutOut;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnCancle;
    }
}