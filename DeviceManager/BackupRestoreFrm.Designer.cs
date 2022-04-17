
namespace DeviceManager
{
    partial class BackupRestoreFrm
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.rdbBackup = new System.Windows.Forms.RadioButton();
            this.rdbRestore = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(576, 153);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(81, 64);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "File:";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(112, 116);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(442, 140);
            this.txtFile.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(214, 293);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 43);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(378, 293);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(99, 43);
            this.btnCancle.TabIndex = 0;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // rdbBackup
            // 
            this.rdbBackup.AutoSize = true;
            this.rdbBackup.Checked = true;
            this.rdbBackup.Location = new System.Drawing.Point(189, 70);
            this.rdbBackup.Name = "rdbBackup";
            this.rdbBackup.Size = new System.Drawing.Size(76, 19);
            this.rdbBackup.TabIndex = 3;
            this.rdbBackup.TabStop = true;
            this.rdbBackup.Text = "Backup";
            this.rdbBackup.UseVisualStyleBackColor = true;
            // 
            // rdbRestore
            // 
            this.rdbRestore.AutoSize = true;
            this.rdbRestore.Location = new System.Drawing.Point(353, 70);
            this.rdbRestore.Name = "rdbRestore";
            this.rdbRestore.Size = new System.Drawing.Size(84, 19);
            this.rdbRestore.TabIndex = 3;
            this.rdbRestore.Text = "Restore";
            this.rdbRestore.UseVisualStyleBackColor = true;
            // 
            // BackupRestoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 373);
            this.Controls.Add(this.rdbRestore);
            this.Controls.Add(this.rdbBackup);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupRestoreFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackupRestoreFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.RadioButton rdbBackup;
        private System.Windows.Forms.RadioButton rdbRestore;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}