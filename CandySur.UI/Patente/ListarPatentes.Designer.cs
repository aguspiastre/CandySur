namespace CandySur.UI.Patente
{
    partial class ListarPatentes
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
            this.gbListadoPatentes = new System.Windows.Forms.GroupBox();
            this.lblPatentesDisponibles = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvPatentes = new System.Windows.Forms.DataGridView();
            this.gbListadoPatentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatentes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListadoPatentes
            // 
            this.gbListadoPatentes.Controls.Add(this.lblPatentesDisponibles);
            this.gbListadoPatentes.Controls.Add(this.pictureBox1);
            this.gbListadoPatentes.Controls.Add(this.btnAceptar);
            this.gbListadoPatentes.Controls.Add(this.dgvPatentes);
            this.gbListadoPatentes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoPatentes.Location = new System.Drawing.Point(3, 4);
            this.gbListadoPatentes.Name = "gbListadoPatentes";
            this.gbListadoPatentes.Size = new System.Drawing.Size(603, 442);
            this.gbListadoPatentes.TabIndex = 4;
            this.gbListadoPatentes.TabStop = false;
            this.gbListadoPatentes.Text = "LISTADO DE PATENTES";
            // 
            // lblPatentesDisponibles
            // 
            this.lblPatentesDisponibles.AutoSize = true;
            this.lblPatentesDisponibles.Location = new System.Drawing.Point(7, 105);
            this.lblPatentesDisponibles.Name = "lblPatentesDisponibles";
            this.lblPatentesDisponibles.Size = new System.Drawing.Size(155, 18);
            this.lblPatentesDisponibles.TabIndex = 6;
            this.lblPatentesDisponibles.Text = "PATENTES DISPONIBLES:";
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
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Green;
            this.btnAceptar.Location = new System.Drawing.Point(517, 404);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvPatentes
            // 
            this.dgvPatentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatentes.Location = new System.Drawing.Point(10, 126);
            this.dgvPatentes.Name = "dgvPatentes";
            this.dgvPatentes.Size = new System.Drawing.Size(582, 272);
            this.dgvPatentes.TabIndex = 0;
            // 
            // ListarPatentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(611, 451);
            this.Controls.Add(this.gbListadoPatentes);
            this.Name = "ListarPatentes";
            this.Text = "Listar Patentes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarPatentes_FormClosing);
            this.Load += new System.EventHandler(this.ListarPatentes_Load);
            this.gbListadoPatentes.ResumeLayout(false);
            this.gbListadoPatentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoPatentes;
        private System.Windows.Forms.Label lblPatentesDisponibles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvPatentes;
    }
}