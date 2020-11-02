namespace CandySur.UI.Descuentos
{
    partial class Descuentos
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
            this.gbConfigurarDescuentos = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbPromocionesVigentes = new System.Windows.Forms.GroupBox();
            this.dgvDescuentos = new System.Windows.Forms.DataGridView();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.lblComprasSuperiores = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.gbConfigurarDescuentos.SuspendLayout();
            this.gbPromocionesVigentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConfigurarDescuentos
            // 
            this.gbConfigurarDescuentos.Controls.Add(this.btnCancelar);
            this.gbConfigurarDescuentos.Controls.Add(this.gbPromocionesVigentes);
            this.gbConfigurarDescuentos.Controls.Add(this.pictureBox1);
            this.gbConfigurarDescuentos.Controls.Add(this.btnFinalizar);
            this.gbConfigurarDescuentos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConfigurarDescuentos.Location = new System.Drawing.Point(2, 5);
            this.gbConfigurarDescuentos.Name = "gbConfigurarDescuentos";
            this.gbConfigurarDescuentos.Size = new System.Drawing.Size(602, 510);
            this.gbConfigurarDescuentos.TabIndex = 6;
            this.gbConfigurarDescuentos.TabStop = false;
            this.gbConfigurarDescuentos.Text = "CONFIGURAR DESCUENTOS";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(516, 470);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbPromocionesVigentes
            // 
            this.gbPromocionesVigentes.Controls.Add(this.dgvDescuentos);
            this.gbPromocionesVigentes.Controls.Add(this.lblPorcentaje);
            this.gbPromocionesVigentes.Controls.Add(this.txtPorcentaje);
            this.gbPromocionesVigentes.Controls.Add(this.lblComprasSuperiores);
            this.gbPromocionesVigentes.Controls.Add(this.txtImporte);
            this.gbPromocionesVigentes.Location = new System.Drawing.Point(10, 98);
            this.gbPromocionesVigentes.Name = "gbPromocionesVigentes";
            this.gbPromocionesVigentes.Size = new System.Drawing.Size(581, 366);
            this.gbPromocionesVigentes.TabIndex = 3;
            this.gbPromocionesVigentes.TabStop = false;
            this.gbPromocionesVigentes.Text = "PROMOCIONES VIGENTES";
            // 
            // dgvDescuentos
            // 
            this.dgvDescuentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentos.Location = new System.Drawing.Point(6, 26);
            this.dgvDescuentos.Name = "dgvDescuentos";
            this.dgvDescuentos.Size = new System.Drawing.Size(267, 325);
            this.dgvDescuentos.TabIndex = 19;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(282, 73);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(142, 19);
            this.lblPorcentaje.TabIndex = 17;
            this.lblPorcentaje.Text = "Porcentaje a aplicar:";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(283, 95);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(292, 26);
            this.txtPorcentaje.TabIndex = 18;
            // 
            // lblComprasSuperiores
            // 
            this.lblComprasSuperiores.AutoSize = true;
            this.lblComprasSuperiores.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprasSuperiores.Location = new System.Drawing.Point(279, 22);
            this.lblComprasSuperiores.Name = "lblComprasSuperiores";
            this.lblComprasSuperiores.Size = new System.Drawing.Size(185, 19);
            this.lblComprasSuperiores.TabIndex = 15;
            this.lblComprasSuperiores.Text = "Para compras superiores a:";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(283, 44);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(292, 26);
            this.txtImporte.TabIndex = 16;
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
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Green;
            this.btnFinalizar.Location = new System.Drawing.Point(435, 470);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 31);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Visible = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Descuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(610, 522);
            this.Controls.Add(this.gbConfigurarDescuentos);
            this.Name = "Descuentos";
            this.Text = "Descuentos";
            this.Load += new System.EventHandler(this.Descuentos_Load);
            this.gbConfigurarDescuentos.ResumeLayout(false);
            this.gbPromocionesVigentes.ResumeLayout(false);
            this.gbPromocionesVigentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfigurarDescuentos;
        private System.Windows.Forms.GroupBox gbPromocionesVigentes;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label lblComprasSuperiores;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvDescuentos;
    }
}