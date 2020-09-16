namespace CandySur.UI.Familia
{
    partial class ListarFamilias
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
            this.gbListadoFamilia = new System.Windows.Forms.GroupBox();
            this.lblFamiliasDisponibles = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvFamilias = new System.Windows.Forms.DataGridView();
            this.gbListadoFamilia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListadoFamilia
            // 
            this.gbListadoFamilia.Controls.Add(this.lblFamiliasDisponibles);
            this.gbListadoFamilia.Controls.Add(this.pictureBox1);
            this.gbListadoFamilia.Controls.Add(this.btnAceptar);
            this.gbListadoFamilia.Controls.Add(this.dgvFamilias);
            this.gbListadoFamilia.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoFamilia.Location = new System.Drawing.Point(6, 6);
            this.gbListadoFamilia.Name = "gbListadoFamilia";
            this.gbListadoFamilia.Size = new System.Drawing.Size(603, 442);
            this.gbListadoFamilia.TabIndex = 5;
            this.gbListadoFamilia.TabStop = false;
            this.gbListadoFamilia.Text = "LISTADO DE FAMILIAS";
            // 
            // lblFamiliasDisponibles
            // 
            this.lblFamiliasDisponibles.AutoSize = true;
            this.lblFamiliasDisponibles.Location = new System.Drawing.Point(7, 105);
            this.lblFamiliasDisponibles.Name = "lblFamiliasDisponibles";
            this.lblFamiliasDisponibles.Size = new System.Drawing.Size(152, 18);
            this.lblFamiliasDisponibles.TabIndex = 6;
            this.lblFamiliasDisponibles.Text = "FAMILIAS DISPONIBLES:";
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
            // dgvFamilias
            // 
            this.dgvFamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilias.Location = new System.Drawing.Point(10, 126);
            this.dgvFamilias.Name = "dgvFamilias";
            this.dgvFamilias.Size = new System.Drawing.Size(582, 272);
            this.dgvFamilias.TabIndex = 0;
            // 
            // ListarFamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(614, 452);
            this.Controls.Add(this.gbListadoFamilia);
            this.Name = "ListarFamilias";
            this.Text = "Listar Familias";
            this.Load += new System.EventHandler(this.ListarFamilias_Load);
            this.gbListadoFamilia.ResumeLayout(false);
            this.gbListadoFamilia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoFamilia;
        private System.Windows.Forms.Label lblFamiliasDisponibles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvFamilias;
    }
}