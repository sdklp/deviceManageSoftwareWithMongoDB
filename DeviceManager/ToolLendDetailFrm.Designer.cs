
namespace DeviceManager
{
    partial class ToolLendDetailFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtToolId = new System.Windows.Forms.TextBox();
            this.txtToolName = new System.Windows.Forms.TextBox();
            this.txtToolModel = new System.Windows.Forms.TextBox();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbLend = new System.Windows.Forms.RadioButton();
            this.rdbReturn = new System.Windows.Forms.RadioButton();
            this.toolLendModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolLendModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(310, 9);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 35);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkContinue
            // 
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(20, 19);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(125, 19);
            this.chkContinue.TabIndex = 1;
            this.chkContinue.Text = "Continue Add";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.chkContinue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 593);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(433, 9);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 35);
            this.btnCancle.TabIndex = 0;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(127, 409);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 25);
            this.txtQty.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Person:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Units:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Qty:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Remark:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tool Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tool Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tool Model:";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolLendModelBindingSource, "Id", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(138, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(313, 25);
            this.txtID.TabIndex = 4;
            // 
            // txtToolId
            // 
            this.txtToolId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolLendModelBindingSource, "ToolId", true));
            this.txtToolId.Location = new System.Drawing.Point(127, 163);
            this.txtToolId.Name = "txtToolId";
            this.txtToolId.Size = new System.Drawing.Size(313, 25);
            this.txtToolId.TabIndex = 4;
            // 
            // txtToolName
            // 
            this.txtToolName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolLendModelBindingSource, "ToolName", true));
            this.txtToolName.Location = new System.Drawing.Point(127, 213);
            this.txtToolName.Name = "txtToolName";
            this.txtToolName.Size = new System.Drawing.Size(536, 25);
            this.txtToolName.TabIndex = 4;
            // 
            // txtToolModel
            // 
            this.txtToolModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolLendModelBindingSource, "ToolModel", true));
            this.txtToolModel.Location = new System.Drawing.Point(127, 263);
            this.txtToolModel.Name = "txtToolModel";
            this.txtToolModel.Size = new System.Drawing.Size(536, 25);
            this.txtToolModel.TabIndex = 4;
            // 
            // cmbPerson
            // 
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(127, 313);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(205, 23);
            this.cmbPerson.TabIndex = 6;
            this.cmbPerson.DropDown += new System.EventHandler(this.cmbPerson_DropDown);
            // 
            // cmbUnits
            // 
            this.cmbUnits.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolLendModelBindingSource, "Units", true));
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(127, 361);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(205, 23);
            this.cmbUnits.TabIndex = 6;
            this.cmbUnits.DropDown += new System.EventHandler(this.cmbUnits_DropDown);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = " ";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(138, 69);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 25);
            this.dtpDate.TabIndex = 7;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            this.dtpDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDate_KeyDown);
            // 
            // txtRemark
            // 
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolLendModelBindingSource, "Remark", true));
            this.txtRemark.Location = new System.Drawing.Point(127, 459);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(536, 99);
            this.txtRemark.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Method:";
            // 
            // rdbLend
            // 
            this.rdbLend.AutoSize = true;
            this.rdbLend.Location = new System.Drawing.Point(138, 119);
            this.rdbLend.Name = "rdbLend";
            this.rdbLend.Size = new System.Drawing.Size(60, 19);
            this.rdbLend.TabIndex = 5;
            this.rdbLend.TabStop = true;
            this.rdbLend.Text = "Lend";
            this.rdbLend.UseVisualStyleBackColor = true;
            // 
            // rdbReturn
            // 
            this.rdbReturn.AutoSize = true;
            this.rdbReturn.Location = new System.Drawing.Point(138, 119);
            this.rdbReturn.Name = "rdbReturn";
            this.rdbReturn.Size = new System.Drawing.Size(76, 19);
            this.rdbReturn.TabIndex = 5;
            this.rdbReturn.TabStop = true;
            this.rdbReturn.Text = "Return";
            this.rdbReturn.UseVisualStyleBackColor = true;
            // 
            // toolLendModelBindingSource
            // 
            this.toolLendModelBindingSource.DataSource = typeof(Models.ToolLendModel);
            // 
            // ToolLendDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbUnits);
            this.Controls.Add(this.cmbPerson);
            this.Controls.Add(this.rdbReturn);
            this.Controls.Add(this.rdbLend);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtToolModel);
            this.Controls.Add(this.txtToolName);
            this.Controls.Add(this.txtToolId);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toolLendModelBindingSource, "Id", true));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolLendDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolLendDetailFrm";
            this.Load += new System.EventHandler(this.ToolLendDetailFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolLendModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkContinue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtToolId;
        private System.Windows.Forms.TextBox txtToolName;
        private System.Windows.Forms.TextBox txtToolModel;
        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.BindingSource toolLendModelBindingSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbLend;
        private System.Windows.Forms.RadioButton rdbReturn;
    }
}