namespace CandySur.UI.Familia
{
    partial class AltaFamilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaFamilia));
            this.gbAltaFamilia = new System.Windows.Forms.GroupBox();
            this.gbDatosFamilia = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.gbAltaFamilia.SuspendLayout();
            this.gbDatosFamilia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAltaFamilia
            // 
            this.gbAltaFamilia.Controls.Add(this.gbDatosFamilia);
            this.gbAltaFamilia.Controls.Add(this.btnCancelar);
            this.gbAltaFamilia.Controls.Add(this.pictureBox1);
            this.gbAltaFamilia.Controls.Add(this.btnFinalizar);
            this.gbAltaFamilia.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAltaFamilia.Location = new System.Drawing.Point(3, 5);
            this.gbAltaFamilia.Name = "gbAltaFamilia";
            this.gbAltaFamilia.Size = new System.Drawing.Size(339, 372);
            this.gbAltaFamilia.TabIndex = 3;
            this.gbAltaFamilia.TabStop = false;
            this.gbAltaFamilia.Text = "ALTA FAMILIA";
            // 
            // gbDatosFamilia
            // 
            this.gbDatosFamilia.Controls.Add(this.lblNombre);
            this.gbDatosFamilia.Controls.Add(this.txtDescripcion);
            this.gbDatosFamilia.Controls.Add(this.lblDescripcion);
            this.gbDatosFamilia.Controls.Add(this.txtNombre);
            this.gbDatosFamilia.Location = new System.Drawing.Point(10, 98);
            this.gbDatosFamilia.Name = "gbDatosFamilia";
            this.gbDatosFamilia.Size = new System.Drawing.Size(317, 233);
            this.gbDatosFamilia.TabIndex = 20;
            this.gbDatosFamilia.TabStop = false;
            this.gbDatosFamilia.Text = "DATOS DE LA FAMILIA";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 19);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(10, 92);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(298, 130);
            this.txtDescripcion.TabIndex = 14;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(6, 70);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 19);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(298, 26);
            this.txtNombre.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(252, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 72);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Green;
            this.btnFinalizar.Location = new System.Drawing.Point(171, 333);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 31);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // AltaFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(349, 382);
            this.Controls.Add(this.gbAltaFamilia);
            this.Name = "AltaFamilia";
            this.Text = "Familia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AltaFamilia_FormClosing);
            this.Load += new System.EventHandler(this.AltaFamilia_Load);
            this.gbAltaFamilia.ResumeLayout(false);
            this.gbDatosFamilia.ResumeLayout(false);
            this.gbDatosFamilia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAltaFamilia;
        private System.Windows.Forms.GroupBox gbDatosFamilia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
    }
}