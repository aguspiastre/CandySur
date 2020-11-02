namespace CandySur.UI.Golosina
{
    partial class Listado_Golosinas
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
            this.gbListadoGolosina = new System.Windows.Forms.GroupBox();
            this.lblListadoGolosinas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvListadoGolosinas = new System.Windows.Forms.DataGridView();
            this.gbListadoGolosina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoGolosinas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListadoGolosina
            // 
            this.gbListadoGolosina.Controls.Add(this.lblListadoGolosinas);
            this.gbListadoGolosina.Controls.Add(this.pictureBox1);
            this.gbListadoGolosina.Controls.Add(this.btnAceptar);
            this.gbListadoGolosina.Controls.Add(this.dgvListadoGolosinas);
            this.gbListadoGolosina.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoGolosina.Location = new System.Drawing.Point(2, 2);
            this.gbListadoGolosina.Name = "gbListadoGolosina";
            this.gbListadoGolosina.Size = new System.Drawing.Size(598, 370);
            this.gbListadoGolosina.TabIndex = 5;
            this.gbListadoGolosina.TabStop = false;
            this.gbListadoGolosina.Text = "LISTADO";
            // 
            // lblListadoGolosinas
            // 
            this.lblListadoGolosinas.AutoSize = true;
            this.lblListadoGolosinas.Location = new System.Drawing.Point(7, 95);
            this.lblListadoGolosinas.Name = "lblListadoGolosinas";
            this.lblListadoGolosinas.Size = new System.Drawing.Size(157, 18);
            this.lblListadoGolosinas.TabIndex = 6;
            this.lblListadoGolosinas.Text = "LISTADO DE GOLOSINAS:";
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
            this.btnAceptar.Location = new System.Drawing.Point(517, 331);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvListadoGolosinas
            // 
            this.dgvListadoGolosinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoGolosinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoGolosinas.Location = new System.Drawing.Point(10, 116);
            this.dgvListadoGolosinas.MultiSelect = false;
            this.dgvListadoGolosinas.Name = "dgvListadoGolosinas";
            this.dgvListadoGolosinas.ReadOnly = true;
            this.dgvListadoGolosinas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListadoGolosinas.Size = new System.Drawing.Size(582, 209);
            this.dgvListadoGolosinas.TabIndex = 0;
            // 
            // Listado_Golosinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(605, 378);
            this.Controls.Add(this.gbListadoGolosina);
            this.Name = "Listado_Golosinas";
            this.Text = "Listado de Golosinas";
            this.Load += new System.EventHandler(this.Listado_Golosinas_Load);
            this.gbListadoGolosina.ResumeLayout(false);
            this.gbListadoGolosina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoGolosinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoGolosina;
        private System.Windows.Forms.Label lblListadoGolosinas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvListadoGolosinas;
    }
}