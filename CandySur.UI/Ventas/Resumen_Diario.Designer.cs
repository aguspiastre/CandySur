namespace CandySur.UI
{
    partial class Resumen_Diario
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
            this.gbResumenDiario = new System.Windows.Forms.GroupBox();
            this.lblTotalResumenDiario = new System.Windows.Forms.Label();
            this.lblTotalComer = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblResumenDiarioVentas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dvgVentasDiarias = new System.Windows.Forms.DataGridView();
            this.gbResumenDiario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVentasDiarias)).BeginInit();
            this.SuspendLayout();
            // 
            // gbResumenDiario
            // 
            this.gbResumenDiario.Controls.Add(this.lblTotalResumenDiario);
            this.gbResumenDiario.Controls.Add(this.lblTotalComer);
            this.gbResumenDiario.Controls.Add(this.lblFecha);
            this.gbResumenDiario.Controls.Add(this.lblResumenDiarioVentas);
            this.gbResumenDiario.Controls.Add(this.pictureBox1);
            this.gbResumenDiario.Controls.Add(this.btnAceptar);
            this.gbResumenDiario.Controls.Add(this.dvgVentasDiarias);
            this.gbResumenDiario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumenDiario.Location = new System.Drawing.Point(8, 6);
            this.gbResumenDiario.Name = "gbResumenDiario";
            this.gbResumenDiario.Size = new System.Drawing.Size(603, 442);
            this.gbResumenDiario.TabIndex = 3;
            this.gbResumenDiario.TabStop = false;
            this.gbResumenDiario.Text = "Resumen diario";
            // 
            // lblTotalResumenDiario
            // 
            this.lblTotalResumenDiario.AutoSize = true;
            this.lblTotalResumenDiario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResumenDiario.Location = new System.Drawing.Point(147, 405);
            this.lblTotalResumenDiario.Name = "lblTotalResumenDiario";
            this.lblTotalResumenDiario.Size = new System.Drawing.Size(0, 18);
            this.lblTotalResumenDiario.TabIndex = 9;
            // 
            // lblTotalComer
            // 
            this.lblTotalComer.AutoSize = true;
            this.lblTotalComer.Location = new System.Drawing.Point(10, 405);
            this.lblTotalComer.Name = "lblTotalComer";
            this.lblTotalComer.Size = new System.Drawing.Size(140, 18);
            this.lblTotalComer.TabIndex = 8;
            this.lblTotalComer.Text = "Total Comercializado:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(236, 105);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(76, 18);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "18/05/2020";
            // 
            // lblResumenDiarioVentas
            // 
            this.lblResumenDiarioVentas.AutoSize = true;
            this.lblResumenDiarioVentas.Location = new System.Drawing.Point(7, 105);
            this.lblResumenDiarioVentas.Name = "lblResumenDiarioVentas";
            this.lblResumenDiarioVentas.Size = new System.Drawing.Size(232, 18);
            this.lblResumenDiarioVentas.TabIndex = 6;
            this.lblResumenDiarioVentas.Text = "RESUMEN DIARIO DE VENTAS FECHA:";
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
            // dvgVentasDiarias
            // 
            this.dvgVentasDiarias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgVentasDiarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVentasDiarias.Location = new System.Drawing.Point(10, 126);
            this.dvgVentasDiarias.MultiSelect = false;
            this.dvgVentasDiarias.Name = "dvgVentasDiarias";
            this.dvgVentasDiarias.ReadOnly = true;
            this.dvgVentasDiarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgVentasDiarias.Size = new System.Drawing.Size(582, 272);
            this.dvgVentasDiarias.TabIndex = 0;
            // 
            // Resumen_Diario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(623, 453);
            this.Controls.Add(this.gbResumenDiario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resumen_Diario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen_Diario";
            this.Load += new System.EventHandler(this.Resumen_Diario_Load);
            this.gbResumenDiario.ResumeLayout(false);
            this.gbResumenDiario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVentasDiarias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbResumenDiario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dvgVentasDiarias;
        private System.Windows.Forms.Label lblTotalResumenDiario;
        private System.Windows.Forms.Label lblTotalComer;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblResumenDiarioVentas;
    }
}