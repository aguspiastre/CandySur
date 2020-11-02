namespace CandySur.UI.Paquete
{
    partial class Listado_Paquetes
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
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblListadoPaquete = new System.Windows.Forms.Label();
            this.gbListadoPaquete = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbListadoPaquete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaquetes.Location = new System.Drawing.Point(10, 126);
            this.dgvPaquetes.MultiSelect = false;
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.ReadOnly = true;
            this.dgvPaquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaquetes.Size = new System.Drawing.Size(582, 272);
            this.dgvPaquetes.TabIndex = 0;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CandySur.UI.Properties.Resources.FINAL;
            this.pictureBox1.Location = new System.Drawing.Point(10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 72);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblListadoPaquete
            // 
            this.lblListadoPaquete.AutoSize = true;
            this.lblListadoPaquete.Location = new System.Drawing.Point(7, 105);
            this.lblListadoPaquete.Name = "lblListadoPaquete";
            this.lblListadoPaquete.Size = new System.Drawing.Size(148, 18);
            this.lblListadoPaquete.TabIndex = 6;
            this.lblListadoPaquete.Text = "LISTADO DE PAQUETES:";
            // 
            // gbListadoPaquete
            // 
            this.gbListadoPaquete.Controls.Add(this.lblListadoPaquete);
            this.gbListadoPaquete.Controls.Add(this.pictureBox1);
            this.gbListadoPaquete.Controls.Add(this.btnAceptar);
            this.gbListadoPaquete.Controls.Add(this.dgvPaquetes);
            this.gbListadoPaquete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoPaquete.Location = new System.Drawing.Point(3, 3);
            this.gbListadoPaquete.Name = "gbListadoPaquete";
            this.gbListadoPaquete.Size = new System.Drawing.Size(603, 442);
            this.gbListadoPaquete.TabIndex = 5;
            this.gbListadoPaquete.TabStop = false;
            this.gbListadoPaquete.Text = "LISTADO";
            // 
            // Listado_Paquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(611, 453);
            this.Controls.Add(this.gbListadoPaquete);
            this.Name = "Listado_Paquetes";
            this.Text = "Listado de Paquetes";
            this.Load += new System.EventHandler(this.Listado_Paquetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbListadoPaquete.ResumeLayout(false);
            this.gbListadoPaquete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaquetes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblListadoPaquete;
        private System.Windows.Forms.GroupBox gbListadoPaquete;
    }
}