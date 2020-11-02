namespace CandySur.UI.Proveedor
{
    partial class Listado_Proveedores
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
            this.gbListadoProveedores = new System.Windows.Forms.GroupBox();
            this.lblListadoProveedores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvListadoProveedores = new System.Windows.Forms.DataGridView();
            this.gbListadoProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListadoProveedores
            // 
            this.gbListadoProveedores.Controls.Add(this.lblListadoProveedores);
            this.gbListadoProveedores.Controls.Add(this.pictureBox1);
            this.gbListadoProveedores.Controls.Add(this.btnAceptar);
            this.gbListadoProveedores.Controls.Add(this.dgvListadoProveedores);
            this.gbListadoProveedores.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoProveedores.Location = new System.Drawing.Point(7, 6);
            this.gbListadoProveedores.Name = "gbListadoProveedores";
            this.gbListadoProveedores.Size = new System.Drawing.Size(603, 442);
            this.gbListadoProveedores.TabIndex = 4;
            this.gbListadoProveedores.TabStop = false;
            this.gbListadoProveedores.Text = "LISTADO";
            // 
            // lblListadoProveedores
            // 
            this.lblListadoProveedores.AutoSize = true;
            this.lblListadoProveedores.Location = new System.Drawing.Point(7, 105);
            this.lblListadoProveedores.Name = "lblListadoProveedores";
            this.lblListadoProveedores.Size = new System.Drawing.Size(175, 18);
            this.lblListadoProveedores.TabIndex = 6;
            this.lblListadoProveedores.Text = "LISTADO DE PROVEEDORES:";
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
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvListadoProveedores
            // 
            this.dgvListadoProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProveedores.Location = new System.Drawing.Point(10, 126);
            this.dgvListadoProveedores.Name = "dgvListadoProveedores";
            this.dgvListadoProveedores.Size = new System.Drawing.Size(582, 272);
            this.dgvListadoProveedores.TabIndex = 0;
            // 
            // Listado_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(616, 456);
            this.Controls.Add(this.gbListadoProveedores);
            this.Name = "Listado_Proveedores";
            this.Text = "Listado de Proveedores";
            this.Load += new System.EventHandler(this.Listado_Proveedores_Load);
            this.gbListadoProveedores.ResumeLayout(false);
            this.gbListadoProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoProveedores;
        private System.Windows.Forms.Label lblListadoProveedores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvListadoProveedores;
    }
}