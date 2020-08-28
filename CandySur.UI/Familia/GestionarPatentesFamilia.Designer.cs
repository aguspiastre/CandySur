namespace CandySur.UI.Familia
{
    partial class GestionarPatentesFamilia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listPatentesAsignar = new System.Windows.Forms.ListView();
            this.listPatentesDesasignar = new System.Windows.Forms.ListView();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 493);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ASIGNAR PATENTES A FAMILIA";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Green;
            this.btnAceptar.Location = new System.Drawing.Point(517, 454);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.listPatentesAsignar);
            this.groupBox3.Controls.Add(this.listPatentesDesasignar);
            this.groupBox3.Controls.Add(this.btnDesasignar);
            this.groupBox3.Controls.Add(this.btnAsignar);
            this.groupBox3.Location = new System.Drawing.Point(10, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 255);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PATENTES DISPONIBLES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Patentes a Desasignar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Patentes a Asignar";
            // 
            // listPatentesAsignar
            // 
            this.listPatentesAsignar.Location = new System.Drawing.Point(6, 45);
            this.listPatentesAsignar.Name = "listPatentesAsignar";
            this.listPatentesAsignar.Size = new System.Drawing.Size(222, 191);
            this.listPatentesAsignar.TabIndex = 22;
            this.listPatentesAsignar.UseCompatibleStateImageBehavior = false;
            this.listPatentesAsignar.View = System.Windows.Forms.View.List;
            // 
            // listPatentesDesasignar
            // 
            this.listPatentesDesasignar.Location = new System.Drawing.Point(351, 45);
            this.listPatentesDesasignar.Name = "listPatentesDesasignar";
            this.listPatentesDesasignar.Size = new System.Drawing.Size(222, 191);
            this.listPatentesDesasignar.TabIndex = 21;
            this.listPatentesDesasignar.UseCompatibleStateImageBehavior = false;
            this.listPatentesDesasignar.View = System.Windows.Forms.View.List;
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesasignar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDesasignar.Location = new System.Drawing.Point(234, 139);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(111, 31);
            this.btnDesasignar.TabIndex = 17;
            this.btnDesasignar.Text = "<- Desasignar ";
            this.btnDesasignar.UseVisualStyleBackColor = false;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.Blue;
            this.btnAsignar.Location = new System.Drawing.Point(234, 102);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(111, 31);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar ->";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbFamilia);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(10, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 88);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTROS DE BUSQUEDA";
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(10, 44);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(218, 26);
            this.cmbFamilia.TabIndex = 19;
            this.cmbFamilia.SelectedIndexChanged += new System.EventHandler(this.cmbFamilia_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Familia:";
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
            // GestionarPatentesFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(613, 504);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionarPatentesFamilia";
            this.Text = "Gestion de Patentes/Familia";
            this.Load += new System.EventHandler(this.AsignarPatentesFamilia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listPatentesAsignar;
        private System.Windows.Forms.ListView listPatentesDesasignar;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbFamilia;
    }
}