namespace CandySur.UI.Descuentos
{
    partial class Gestionar
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
            this.gbGestionarDescuentos = new System.Windows.Forms.GroupBox();
            this.gbPromocionesVigentes = new System.Windows.Forms.GroupBox();
            this.dvgPromocionesActivas = new System.Windows.Forms.DataGridView();
            this.dvgPromocionesDesactivadas = new System.Windows.Forms.DataGridView();
            this.lblPromocionesActivas = new System.Windows.Forms.Label();
            this.lblPromocionesDesactivadas = new System.Windows.Forms.Label();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbGestionarDescuentos.SuspendLayout();
            this.gbPromocionesVigentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPromocionesActivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPromocionesDesactivadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGestionarDescuentos
            // 
            this.gbGestionarDescuentos.Controls.Add(this.gbPromocionesVigentes);
            this.gbGestionarDescuentos.Controls.Add(this.btnAceptar);
            this.gbGestionarDescuentos.Controls.Add(this.pictureBox1);
            this.gbGestionarDescuentos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGestionarDescuentos.Location = new System.Drawing.Point(5, 6);
            this.gbGestionarDescuentos.Name = "gbGestionarDescuentos";
            this.gbGestionarDescuentos.Size = new System.Drawing.Size(602, 564);
            this.gbGestionarDescuentos.TabIndex = 24;
            this.gbGestionarDescuentos.TabStop = false;
            this.gbGestionarDescuentos.Text = "ACTIVAR/DESACTIVAR DESCUENTOS";
            // 
            // gbPromocionesVigentes
            // 
            this.gbPromocionesVigentes.Controls.Add(this.dvgPromocionesActivas);
            this.gbPromocionesVigentes.Controls.Add(this.dvgPromocionesDesactivadas);
            this.gbPromocionesVigentes.Controls.Add(this.lblPromocionesActivas);
            this.gbPromocionesVigentes.Controls.Add(this.lblPromocionesDesactivadas);
            this.gbPromocionesVigentes.Controls.Add(this.btnDesactivar);
            this.gbPromocionesVigentes.Controls.Add(this.btnActivar);
            this.gbPromocionesVigentes.Location = new System.Drawing.Point(9, 98);
            this.gbPromocionesVigentes.Name = "gbPromocionesVigentes";
            this.gbPromocionesVigentes.Size = new System.Drawing.Size(582, 423);
            this.gbPromocionesVigentes.TabIndex = 23;
            this.gbPromocionesVigentes.TabStop = false;
            this.gbPromocionesVigentes.Text = "PROMOCIONES VIGENTES";
            // 
            // dvgPromocionesActivas
            // 
            this.dvgPromocionesActivas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgPromocionesActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPromocionesActivas.Location = new System.Drawing.Point(9, 264);
            this.dvgPromocionesActivas.MultiSelect = false;
            this.dvgPromocionesActivas.Name = "dvgPromocionesActivas";
            this.dvgPromocionesActivas.ReadOnly = true;
            this.dvgPromocionesActivas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgPromocionesActivas.Size = new System.Drawing.Size(567, 153);
            this.dvgPromocionesActivas.TabIndex = 26;
            // 
            // dvgPromocionesDesactivadas
            // 
            this.dvgPromocionesDesactivadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgPromocionesDesactivadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPromocionesDesactivadas.Location = new System.Drawing.Point(7, 43);
            this.dvgPromocionesDesactivadas.MultiSelect = false;
            this.dvgPromocionesDesactivadas.Name = "dvgPromocionesDesactivadas";
            this.dvgPromocionesDesactivadas.ReadOnly = true;
            this.dvgPromocionesDesactivadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgPromocionesDesactivadas.Size = new System.Drawing.Size(569, 150);
            this.dvgPromocionesDesactivadas.TabIndex = 25;
            // 
            // lblPromocionesActivas
            // 
            this.lblPromocionesActivas.AutoSize = true;
            this.lblPromocionesActivas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocionesActivas.Location = new System.Drawing.Point(6, 242);
            this.lblPromocionesActivas.Name = "lblPromocionesActivas";
            this.lblPromocionesActivas.Size = new System.Drawing.Size(136, 18);
            this.lblPromocionesActivas.TabIndex = 24;
            this.lblPromocionesActivas.Text = "Promociones Activas";
            // 
            // lblPromocionesDesactivadas
            // 
            this.lblPromocionesDesactivadas.AutoSize = true;
            this.lblPromocionesDesactivadas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocionesDesactivadas.Location = new System.Drawing.Point(6, 22);
            this.lblPromocionesDesactivadas.Name = "lblPromocionesDesactivadas";
            this.lblPromocionesDesactivadas.Size = new System.Drawing.Size(175, 18);
            this.lblPromocionesDesactivadas.TabIndex = 23;
            this.lblPromocionesDesactivadas.Text = "Promociones  Desactivadas";
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesactivar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDesactivar.Location = new System.Drawing.Point(288, 206);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(111, 31);
            this.btnDesactivar.TabIndex = 17;
            this.btnDesactivar.Text = "Desactivar ↑";
            this.btnDesactivar.UseVisualStyleBackColor = false;
            this.btnDesactivar.Visible = false;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.Transparent;
            this.btnActivar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.ForeColor = System.Drawing.Color.Blue;
            this.btnActivar.Location = new System.Drawing.Point(171, 206);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(111, 31);
            this.btnActivar.TabIndex = 2;
            this.btnActivar.Text = "Activar ↓";
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Visible = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(517, 527);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Gestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(613, 574);
            this.Controls.Add(this.gbGestionarDescuentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Descuentos";
            this.Load += new System.EventHandler(this.Gestionar_Load);
            this.gbGestionarDescuentos.ResumeLayout(false);
            this.gbPromocionesVigentes.ResumeLayout(false);
            this.gbPromocionesVigentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPromocionesActivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPromocionesDesactivadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbGestionarDescuentos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbPromocionesVigentes;
        private System.Windows.Forms.Label lblPromocionesActivas;
        private System.Windows.Forms.Label lblPromocionesDesactivadas;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.DataGridView dvgPromocionesActivas;
        private System.Windows.Forms.DataGridView dvgPromocionesDesactivadas;
        private System.Windows.Forms.Button btnAceptar;
    }
}