
namespace DeviceManager
{
    partial class ApFrm
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
            this.dgvAp = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iQAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idExpireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iqamaExpireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nexVacationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtIqama = new System.Windows.Forms.TextBox();
            this.txtWorkId = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNex = new System.Windows.Forms.DateTimePicker();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpIqamaExport = new System.Windows.Forms.DateTimePicker();
            this.dtpIdExpire = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAp
            // 
            this.dgvAp.AllowUserToAddRows = false;
            this.dgvAp.AutoGenerateColumns = false;
            this.dgvAp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.workIdDataGridViewTextBoxColumn,
            this.iQAMADataGridViewTextBoxColumn,
            this.idExpireDateDataGridViewTextBoxColumn,
            this.iqamaExpireDateDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.nexVacationDateDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dgvAp.DataSource = this.apModelBindingSource;
            this.dgvAp.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvAp.Location = new System.Drawing.Point(0, 0);
            this.dgvAp.MultiSelect = false;
            this.dgvAp.Name = "dgvAp";
            this.dgvAp.RowHeadersVisible = false;
            this.dgvAp.RowHeadersWidth = 51;
            this.dgvAp.RowTemplate.Height = 27;
            this.dgvAp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAp.Size = new System.Drawing.Size(904, 756);
            this.dgvAp.TabIndex = 0;
            this.dgvAp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAp_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // workIdDataGridViewTextBoxColumn
            // 
            this.workIdDataGridViewTextBoxColumn.DataPropertyName = "WorkId";
            this.workIdDataGridViewTextBoxColumn.HeaderText = "WorkId";
            this.workIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workIdDataGridViewTextBoxColumn.Name = "workIdDataGridViewTextBoxColumn";
            this.workIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // iQAMADataGridViewTextBoxColumn
            // 
            this.iQAMADataGridViewTextBoxColumn.DataPropertyName = "IQAMA";
            this.iQAMADataGridViewTextBoxColumn.HeaderText = "IQAMA";
            this.iQAMADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iQAMADataGridViewTextBoxColumn.Name = "iQAMADataGridViewTextBoxColumn";
            this.iQAMADataGridViewTextBoxColumn.Width = 125;
            // 
            // idExpireDateDataGridViewTextBoxColumn
            // 
            this.idExpireDateDataGridViewTextBoxColumn.DataPropertyName = "IdExpireDate";
            this.idExpireDateDataGridViewTextBoxColumn.HeaderText = "IdExpireDate";
            this.idExpireDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idExpireDateDataGridViewTextBoxColumn.Name = "idExpireDateDataGridViewTextBoxColumn";
            this.idExpireDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // iqamaExpireDateDataGridViewTextBoxColumn
            // 
            this.iqamaExpireDateDataGridViewTextBoxColumn.DataPropertyName = "IqamaExpireDate";
            this.iqamaExpireDateDataGridViewTextBoxColumn.HeaderText = "IqamaExpireDate";
            this.iqamaExpireDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iqamaExpireDateDataGridViewTextBoxColumn.Name = "iqamaExpireDateDataGridViewTextBoxColumn";
            this.iqamaExpireDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            this.periodDataGridViewTextBoxColumn.Width = 125;
            // 
            // nexVacationDateDataGridViewTextBoxColumn
            // 
            this.nexVacationDateDataGridViewTextBoxColumn.DataPropertyName = "NexVacationDate";
            this.nexVacationDateDataGridViewTextBoxColumn.HeaderText = "NexVacationDate";
            this.nexVacationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nexVacationDateDataGridViewTextBoxColumn.Name = "nexVacationDateDataGridViewTextBoxColumn";
            this.nexVacationDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.Width = 125;
            // 
            // apModelBindingSource
            // 
            this.apModelBindingSource.DataSource = typeof(Models.ApModel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(904, 692);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 64);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(224, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 40);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.txtRemark);
            this.pnlContainer.Controls.Add(this.txtEmail);
            this.pnlContainer.Controls.Add(this.txtPhone);
            this.pnlContainer.Controls.Add(this.txtIqama);
            this.pnlContainer.Controls.Add(this.txtWorkId);
            this.pnlContainer.Controls.Add(this.txtPeriod);
            this.pnlContainer.Controls.Add(this.txtName);
            this.pnlContainer.Controls.Add(this.txtId);
            this.pnlContainer.Controls.Add(this.label11);
            this.pnlContainer.Controls.Add(this.label10);
            this.pnlContainer.Controls.Add(this.label9);
            this.pnlContainer.Controls.Add(this.label8);
            this.pnlContainer.Controls.Add(this.label7);
            this.pnlContainer.Controls.Add(this.label6);
            this.pnlContainer.Controls.Add(this.label5);
            this.pnlContainer.Controls.Add(this.label4);
            this.pnlContainer.Controls.Add(this.label3);
            this.pnlContainer.Controls.Add(this.label12);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.dtpNex);
            this.pnlContainer.Controls.Add(this.dtpReturn);
            this.pnlContainer.Controls.Add(this.dtpIqamaExport);
            this.pnlContainer.Controls.Add(this.dtpIdExpire);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Enabled = false;
            this.pnlContainer.Location = new System.Drawing.Point(904, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(423, 692);
            this.pnlContainer.TabIndex = 1;
            // 
            // txtRemark
            // 
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apModelBindingSource, "Remark", true));
            this.txtRemark.Location = new System.Drawing.Point(79, 559);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(325, 108);
            this.txtRemark.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apModelBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(161, 508);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 25);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apModelBindingSource, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(161, 459);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(243, 25);
            this.txtPhone.TabIndex = 2;
            // 
            // txtIqama
            // 
            this.txtIqama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apModelBindingSource, "IQAMA", true));
            this.txtIqama.Location = new System.Drawing.Point(161, 175);
            this.txtIqama.Name = "txtIqama";
            this.txtIqama.Size = new System.Drawing.Size(243, 25);
            this.txtIqama.TabIndex = 2;
            // 
            // txtWorkId
            // 
            this.txtWorkId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apModelBindingSource, "WorkId", true));
            this.txtWorkId.Location = new System.Drawing.Point(161, 126);
            this.txtWorkId.Name = "txtWorkId";
            this.txtWorkId.Size = new System.Drawing.Size(243, 25);
            this.txtWorkId.TabIndex = 2;
            // 
            // txtPeriod
            // 
            this.txtPeriod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apModelBindingSource, "Period", true));
            this.txtPeriod.Location = new System.Drawing.Point(161, 367);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(243, 25);
            this.txtPeriod.TabIndex = 2;
            this.txtPeriod.TextChanged += new System.EventHandler(this.txtPeriod_TextChanged);
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apModelBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(161, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 25);
            this.txtName.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apModelBindingSource, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(161, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(243, 25);
            this.txtId.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 562);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Remark:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "NexVacationDate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "ReturnDate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "IqamaExpireDate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "IdExpireDate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "IQAMA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "WorkId:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Period:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // dtpNex
            // 
            this.dtpNex.CustomFormat = " ";
            this.dtpNex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apModelBindingSource, "NexVacationDate", true));
            this.dtpNex.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNex.Location = new System.Drawing.Point(161, 410);
            this.dtpNex.Name = "dtpNex";
            this.dtpNex.Size = new System.Drawing.Size(243, 25);
            this.dtpNex.TabIndex = 0;
            this.dtpNex.ValueChanged += new System.EventHandler(this.dtpNex_ValueChanged);
            this.dtpNex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpNex_KeyDown);
            // 
            // dtpReturn
            // 
            this.dtpReturn.CustomFormat = " ";
            this.dtpReturn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apModelBindingSource, "ReturnDate", true));
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturn.Location = new System.Drawing.Point(161, 322);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(243, 25);
            this.dtpReturn.TabIndex = 0;
            this.dtpReturn.ValueChanged += new System.EventHandler(this.dtpReturn_ValueChanged);
            this.dtpReturn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpReturn_KeyDown);
            // 
            // dtpIqamaExport
            // 
            this.dtpIqamaExport.CustomFormat = " ";
            this.dtpIqamaExport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apModelBindingSource, "IqamaExpireDate", true));
            this.dtpIqamaExport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIqamaExport.Location = new System.Drawing.Point(161, 273);
            this.dtpIqamaExport.Name = "dtpIqamaExport";
            this.dtpIqamaExport.Size = new System.Drawing.Size(243, 25);
            this.dtpIqamaExport.TabIndex = 0;
            this.dtpIqamaExport.ValueChanged += new System.EventHandler(this.dtpIqamaExport_ValueChanged);
            this.dtpIqamaExport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpIqamaExport_KeyDown);
            // 
            // dtpIdExpire
            // 
            this.dtpIdExpire.CustomFormat = " ";
            this.dtpIdExpire.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apModelBindingSource, "IdExpireDate", true));
            this.dtpIdExpire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIdExpire.Location = new System.Drawing.Point(161, 224);
            this.dtpIdExpire.Name = "dtpIdExpire";
            this.dtpIdExpire.Size = new System.Drawing.Size(243, 25);
            this.dtpIdExpire.TabIndex = 0;
            this.dtpIdExpire.ValueChanged += new System.EventHandler(this.dtpIdExpire_ValueChanged);
            this.dtpIdExpire.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpIdExpire_KeyDown);
            // 
            // ApFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 756);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAp);
            this.Name = "ApFrm";
            this.Text = "ApFrm";
            this.Load += new System.EventHandler(this.ApFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpIdExpire;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtIqama;
        private System.Windows.Forms.TextBox txtWorkId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpNex;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.DateTimePicker dtpIqamaExport;
        private System.Windows.Forms.BindingSource apModelBindingSource;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iQAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExpireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iqamaExpireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nexVacationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}