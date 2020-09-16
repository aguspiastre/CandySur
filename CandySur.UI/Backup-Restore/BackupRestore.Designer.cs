namespace CandySur.UI.Backup_Restore
{
    partial class BackupRestore
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
            this.gbBackupRestore = new System.Windows.Forms.GroupBox();
            this.btnNuevoBackup = new System.Windows.Forms.Button();
            this.gbBackupDisponibles = new System.Windows.Forms.GroupBox();
            this.lblBackup = new System.Windows.Forms.Label();
            this.cmbBackup = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.gbBackupRestore.SuspendLayout();
            this.gbBackupDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBackupRestore
            // 
            this.gbBackupRestore.Controls.Add(this.btnNuevoBackup);
            this.gbBackupRestore.Controls.Add(this.gbBackupDisponibles);
            this.gbBackupRestore.Controls.Add(this.pictureBox1);
            this.gbBackupRestore.Controls.Add(this.btnRestore);
            this.gbBackupRestore.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBackupRestore.Location = new System.Drawing.Point(3, 7);
            this.gbBackupRestore.Name = "gbBackupRestore";
            this.gbBackupRestore.Size = new System.Drawing.Size(602, 239);
            this.gbBackupRestore.TabIndex = 5;
            this.gbBackupRestore.TabStop = false;
            this.gbBackupRestore.Text = "BACK-UP Y RESTORE";
            // 
            // btnNuevoBackup
            // 
            this.btnNuevoBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoBackup.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoBackup.ForeColor = System.Drawing.Color.Blue;
            this.btnNuevoBackup.Location = new System.Drawing.Point(350, 199);
            this.btnNuevoBackup.Name = "btnNuevoBackup";
            this.btnNuevoBackup.Size = new System.Drawing.Size(118, 31);
            this.btnNuevoBackup.TabIndex = 18;
            this.btnNuevoBackup.Text = "Nuevo Back-up";
            this.btnNuevoBackup.UseVisualStyleBackColor = false;
            this.btnNuevoBackup.Click += new System.EventHandler(this.btnNuevoBackup_Click);
            // 
            // gbBackupDisponibles
            // 
            this.gbBackupDisponibles.Controls.Add(this.lblBackup);
            this.gbBackupDisponibles.Controls.Add(this.cmbBackup);
            this.gbBackupDisponibles.Location = new System.Drawing.Point(9, 98);
            this.gbBackupDisponibles.Name = "gbBackupDisponibles";
            this.gbBackupDisponibles.Size = new System.Drawing.Size(583, 95);
            this.gbBackupDisponibles.TabIndex = 5;
            this.gbBackupDisponibles.TabStop = false;
            this.gbBackupDisponibles.Text = "BACK-UP DISPONIBLES";
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackup.Location = new System.Drawing.Point(6, 22);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(64, 19);
            this.lblBackup.TabIndex = 18;
            this.lblBackup.Text = "Back-up:";
            // 
            // cmbBackup
            // 
            this.cmbBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackup.FormattingEnabled = true;
            this.cmbBackup.Location = new System.Drawing.Point(10, 44);
            this.cmbBackup.Name = "cmbBackup";
            this.cmbBackup.Size = new System.Drawing.Size(263, 26);
            this.cmbBackup.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CandySur.UI.Properties.Resources.FINAL;
            this.pictureBox1.Location = new System.Drawing.Point(10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 72);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.Green;
            this.btnRestore.Location = new System.Drawing.Point(474, 199);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(118, 31);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Realizar Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(611, 251);
            this.Controls.Add(this.gbBackupRestore);
            this.Name = "BackupRestore";
            this.Text = "Backup y Restore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackupRestore_FormClosing);
            this.Load += new System.EventHandler(this.BackupRestore_Load);
            this.gbBackupRestore.ResumeLayout(false);
            this.gbBackupDisponibles.ResumeLayout(false);
            this.gbBackupDisponibles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBackupRestore;
        private System.Windows.Forms.GroupBox gbBackupDisponibles;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.ComboBox cmbBackup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnNuevoBackup;
    }
}