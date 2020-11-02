namespace CandySur.UI
{
    partial class Gestionar_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar_Venta));
            this.gbGestionarVenta = new System.Windows.Forms.GroupBox();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblImporteTotalLbl = new System.Windows.Forms.Label();
            this.lblProductosIncluidos = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.txtNumeroVenta = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dvgProductosIncluidos = new System.Windows.Forms.DataGridView();
            this.gbGestionarVenta.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductosIncluidos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGestionarVenta
            // 
            this.gbGestionarVenta.Controls.Add(this.lblImporteTotal);
            this.gbGestionarVenta.Controls.Add(this.lblImporteTotalLbl);
            this.gbGestionarVenta.Controls.Add(this.lblProductosIncluidos);
            this.gbGestionarVenta.Controls.Add(this.gbFiltros);
            this.gbGestionarVenta.Controls.Add(this.btnAceptar);
            this.gbGestionarVenta.Controls.Add(this.pictureBox1);
            this.gbGestionarVenta.Controls.Add(this.btnEliminar);
            this.gbGestionarVenta.Controls.Add(this.dvgProductosIncluidos);
            this.gbGestionarVenta.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGestionarVenta.Location = new System.Drawing.Point(3, 1);
            this.gbGestionarVenta.Name = "gbGestionarVenta";
            this.gbGestionarVenta.Size = new System.Drawing.Size(603, 451);
            this.gbGestionarVenta.TabIndex = 2;
            this.gbGestionarVenta.TabStop = false;
            this.gbGestionarVenta.Text = "GESTIONAR";
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.Location = new System.Drawing.Point(105, 414);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(29, 19);
            this.lblImporteTotal.TabIndex = 10;
            this.lblImporteTotal.Text = "$ 0";
            // 
            // lblImporteTotalLbl
            // 
            this.lblImporteTotalLbl.AutoSize = true;
            this.lblImporteTotalLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotalLbl.Location = new System.Drawing.Point(9, 414);
            this.lblImporteTotalLbl.Name = "lblImporteTotalLbl";
            this.lblImporteTotalLbl.Size = new System.Drawing.Size(99, 19);
            this.lblImporteTotalLbl.TabIndex = 9;
            this.lblImporteTotalLbl.Text = "Importe Total:";
            // 
            // lblProductosIncluidos
            // 
            this.lblProductosIncluidos.AutoSize = true;
            this.lblProductosIncluidos.Location = new System.Drawing.Point(9, 184);
            this.lblProductosIncluidos.Name = "lblProductosIncluidos";
            this.lblProductosIncluidos.Size = new System.Drawing.Size(158, 18);
            this.lblProductosIncluidos.TabIndex = 8;
            this.lblProductosIncluidos.Text = "PRODUCTOS INCLUIDOS:";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.lblNumeroVenta);
            this.gbFiltros.Controls.Add(this.btnBuscarVenta);
            this.gbFiltros.Controls.Add(this.txtNumeroVenta);
            this.gbFiltros.Location = new System.Drawing.Point(9, 98);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(583, 83);
            this.gbFiltros.TabIndex = 3;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "FILTROS";
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVenta.Location = new System.Drawing.Point(6, 22);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(104, 19);
            this.lblNumeroVenta.TabIndex = 4;
            this.lblNumeroVenta.Text = "Numero venta:";
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarVenta.Image")));
            this.btnBuscarVenta.Location = new System.Drawing.Point(267, 42);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(43, 29);
            this.btnBuscarVenta.TabIndex = 8;
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // txtNumeroVenta
            // 
            this.txtNumeroVenta.Location = new System.Drawing.Point(10, 44);
            this.txtNumeroVenta.Name = "txtNumeroVenta";
            this.txtNumeroVenta.Size = new System.Drawing.Size(251, 26);
            this.txtNumeroVenta.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Green;
            this.btnAceptar.Location = new System.Drawing.Point(517, 409);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 7;
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
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Location = new System.Drawing.Point(436, 409);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 31);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dvgProductosIncluidos
            // 
            this.dvgProductosIncluidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgProductosIncluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProductosIncluidos.Location = new System.Drawing.Point(9, 205);
            this.dvgProductosIncluidos.MultiSelect = false;
            this.dvgProductosIncluidos.Name = "dvgProductosIncluidos";
            this.dvgProductosIncluidos.ReadOnly = true;
            this.dvgProductosIncluidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProductosIncluidos.Size = new System.Drawing.Size(582, 198);
            this.dvgProductosIncluidos.TabIndex = 0;
            // 
            // Gestionar_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(613, 456);
            this.Controls.Add(this.gbGestionarVenta);
            this.Name = "Gestionar_Venta";
            this.Text = "Gestionar";
            this.Load += new System.EventHandler(this.Gestionar_Venta_Load);
            this.gbGestionarVenta.ResumeLayout(false);
            this.gbGestionarVenta.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductosIncluidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGestionarVenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.TextBox txtNumeroVenta;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dvgProductosIncluidos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblProductosIncluidos;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label lblImporteTotalLbl;
    }
}