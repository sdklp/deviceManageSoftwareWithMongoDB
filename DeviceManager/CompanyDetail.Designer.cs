
namespace DeviceManager
{
    partial class CompanyDetailFrm
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCompanyType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.companyModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(398, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 45);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkContinue
            // 
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(12, 19);
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
            this.panel1.Location = new System.Drawing.Point(0, 587);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 51);
            this.panel1.TabIndex = 2;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(535, 3);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 45);
            this.btnCancle.TabIndex = 0;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "Id", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(143, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(301, 25);
            this.txtID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Province:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "County:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Address:";
            // 
            // cmbCompanyType
            // 
            this.cmbCompanyType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "CompanyType", true));
            this.cmbCompanyType.FormattingEnabled = true;
            this.cmbCompanyType.Items.AddRange(new object[] {
            "Company",
            "Agency",
            "Both"});
            this.cmbCompanyType.Location = new System.Drawing.Point(143, 445);
            this.cmbCompanyType.Name = "cmbCompanyType";
            this.cmbCompanyType.Size = new System.Drawing.Size(356, 23);
            this.cmbCompanyType.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Person:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mobile:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Fax:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(559, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tel:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Company Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 491);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Remark:";
            // 
            // cmbProvince
            // 
            this.cmbProvince.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "Province", true));
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(143, 207);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(191, 23);
            this.cmbProvince.TabIndex = 5;
            this.cmbProvince.DropDown += new System.EventHandler(this.cmbProvince_DropDown);
            // 
            // cmbCity
            // 
            this.cmbCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "City", true));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(398, 207);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(191, 23);
            this.cmbCity.TabIndex = 5;
            this.cmbCity.DropDown += new System.EventHandler(this.cmbCity_DropDown);
            // 
            // cmbCounty
            // 
            this.cmbCounty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "County", true));
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Location = new System.Drawing.Point(658, 207);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(191, 23);
            this.cmbCounty.TabIndex = 5;
            this.cmbCounty.DropDown += new System.EventHandler(this.cmbCounty_DropDown);
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(143, 260);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(710, 60);
            this.txtAddress.TabIndex = 4;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "CompanyName", true));
            this.txtCompanyName.Location = new System.Drawing.Point(143, 83);
            this.txtCompanyName.Multiline = true;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(706, 56);
            this.txtCompanyName.TabIndex = 4;
            // 
            // txtPerson
            // 
            this.txtPerson.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "Person", true));
            this.txtPerson.Location = new System.Drawing.Point(143, 348);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(356, 25);
            this.txtPerson.TabIndex = 4;
            // 
            // txtMobile
            // 
            this.txtMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "Mobile", true));
            this.txtMobile.Location = new System.Drawing.Point(604, 348);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(249, 25);
            this.txtMobile.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "Tel", true));
            this.txtTel.Location = new System.Drawing.Point(604, 395);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(245, 25);
            this.txtTel.TabIndex = 4;
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "Fax", true));
            this.txtFax.Location = new System.Drawing.Point(604, 444);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(245, 25);
            this.txtFax.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(139, 395);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 25);
            this.txtEmail.TabIndex = 4;
            // 
            // txtRemark
            // 
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "Remark", true));
            this.txtRemark.Location = new System.Drawing.Point(143, 493);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(706, 60);
            this.txtRemark.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Country:";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyModelBindingSource, "Country", true));
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(143, 164);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(301, 23);
            this.cmbCountry.TabIndex = 5;
            this.cmbCountry.DropDown += new System.EventHandler(this.cmbCountry_DropDown);
           
            // 
            // companyModelBindingSource
            // 
            this.companyModelBindingSource.DataSource = typeof(Models.CompanyModel);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(464, 159);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(113, 32);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // CompanyDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 638);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cmbCounty);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.cmbProvince);
            this.Controls.Add(this.cmbCompanyType);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "CompanyDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkContinue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCompanyType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.BindingSource companyModelBindingSource;
        private System.Windows.Forms.Button btnAddNew;
    }
}