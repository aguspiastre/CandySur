namespace CandySur.UI.Paquete
{
    partial class Alta_Paquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_Paquete));
            this.gbAltaPaquete = new System.Windows.Forms.GroupBox();
            this.lblPrecioTotalAltaPaquete = new System.Windows.Forms.Label();
            this.lblPrecioTotalEtiqueta = new System.Windows.Forms.Label();
            this.gbDatosDelPaquete = new System.Windows.Forms.GroupBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStockPaquete = new System.Windows.Forms.Label();
            this.lblDescripcionPaquete = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblGolosinasIncluidas = new System.Windows.Forms.Label();
            this.dgvGolosinasIncluidas = new System.Windows.Forms.DataGridView();
            this.gbIncluirGolosinas = new System.Windows.Forms.GroupBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.txtDescripcionGolosina = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCantidadGolosina = new System.Windows.Forms.TextBox();
            this.txtStockGolosina = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.gbAltaPaquete.SuspendLayout();
            this.gbDatosDelPaquete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGolosinasIncluidas)).BeginInit();
            this.gbIncluirGolosinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAltaPaquete
            // 
            this.gbAltaPaquete.Controls.Add(this.lblPrecioTotalAltaPaquete);
            this.gbAltaPaquete.Controls.Add(this.lblPrecioTotalEtiqueta);
            this.gbAltaPaquete.Controls.Add(this.gbDatosDelPaquete);
            this.gbAltaPaquete.Controls.Add(this.lblGolosinasIncluidas);
            this.gbAltaPaquete.Controls.Add(this.dgvGolosinasIncluidas);
            this.gbAltaPaquete.Controls.Add(this.gbIncluirGolosinas);
            this.gbAltaPaquete.Controls.Add(this.btnCancelar);
            this.gbAltaPaquete.Controls.Add(this.pictureBox1);
            this.gbAltaPaquete.Controls.Add(this.btnFinalizar);
            this.gbAltaPaquete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAltaPaquete.Location = new System.Drawing.Point(3, 2);
            this.gbAltaPaquete.Name = "gbAltaPaquete";
            this.gbAltaPaquete.Size = new System.Drawing.Size(602, 561);
            this.gbAltaPaquete.TabIndex = 4;
            this.gbAltaPaquete.TabStop = false;
            this.gbAltaPaquete.Text = "ALTA PAQUETE";
            // 
            // lblPrecioTotalAltaPaquete
            // 
            this.lblPrecioTotalAltaPaquete.AutoSize = true;
            this.lblPrecioTotalAltaPaquete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotalAltaPaquete.Location = new System.Drawing.Point(97, 522);
            this.lblPrecioTotalAltaPaquete.Name = "lblPrecioTotalAltaPaquete";
            this.lblPrecioTotalAltaPaquete.Size = new System.Drawing.Size(29, 19);
            this.lblPrecioTotalAltaPaquete.TabIndex = 24;
            this.lblPrecioTotalAltaPaquete.Text = "$ 0";
            // 
            // lblPrecioTotalEtiqueta
            // 
            this.lblPrecioTotalEtiqueta.AutoSize = true;
            this.lblPrecioTotalEtiqueta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotalEtiqueta.Location = new System.Drawing.Point(9, 522);
            this.lblPrecioTotalEtiqueta.Name = "lblPrecioTotalEtiqueta";
            this.lblPrecioTotalEtiqueta.Size = new System.Drawing.Size(89, 19);
            this.lblPrecioTotalEtiqueta.TabIndex = 23;
            this.lblPrecioTotalEtiqueta.Text = "Precio Total:";
            // 
            // gbDatosDelPaquete
            // 
            this.gbDatosDelPaquete.Controls.Add(this.txtStock);
            this.gbDatosDelPaquete.Controls.Add(this.lblStockPaquete);
            this.gbDatosDelPaquete.Controls.Add(this.lblDescripcionPaquete);
            this.gbDatosDelPaquete.Controls.Add(this.txtDescripcion);
            this.gbDatosDelPaquete.Location = new System.Drawing.Point(10, 98);
            this.gbDatosDelPaquete.Name = "gbDatosDelPaquete";
            this.gbDatosDelPaquete.Size = new System.Drawing.Size(582, 94);
            this.gbDatosDelPaquete.TabIndex = 22;
            this.gbDatosDelPaquete.TabStop = false;
            this.gbDatosDelPaquete.Text = "DATOS DEL PAQUETE:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(289, 41);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(287, 26);
            this.txtStock.TabIndex = 20;
            // 
            // lblStockPaquete
            // 
            this.lblStockPaquete.AutoSize = true;
            this.lblStockPaquete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPaquete.Location = new System.Drawing.Point(285, 22);
            this.lblStockPaquete.Name = "lblStockPaquete";
            this.lblStockPaquete.Size = new System.Drawing.Size(47, 19);
            this.lblStockPaquete.TabIndex = 21;
            this.lblStockPaquete.Text = "Stock:";
            // 
            // lblDescripcionPaquete
            // 
            this.lblDescripcionPaquete.AutoSize = true;
            this.lblDescripcionPaquete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionPaquete.Location = new System.Drawing.Point(5, 22);
            this.lblDescripcionPaquete.Name = "lblDescripcionPaquete";
            this.lblDescripcionPaquete.Size = new System.Drawing.Size(89, 19);
            this.lblDescripcionPaquete.TabIndex = 18;
            this.lblDescripcionPaquete.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(9, 41);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(263, 26);
            this.txtDescripcion.TabIndex = 19;
            // 
            // lblGolosinasIncluidas
            // 
            this.lblGolosinasIncluidas.AutoSize = true;
            this.lblGolosinasIncluidas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolosinasIncluidas.Location = new System.Drawing.Point(9, 346);
            this.lblGolosinasIncluidas.Name = "lblGolosinasIncluidas";
            this.lblGolosinasIncluidas.Size = new System.Drawing.Size(163, 19);
            this.lblGolosinasIncluidas.TabIndex = 21;
            this.lblGolosinasIncluidas.Text = "GOLOSINAS INCLUIDAS:";
            // 
            // dgvGolosinasIncluidas
            // 
            this.dgvGolosinasIncluidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGolosinasIncluidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGolosinasIncluidas.Location = new System.Drawing.Point(9, 368);
            this.dgvGolosinasIncluidas.MultiSelect = false;
            this.dgvGolosinasIncluidas.Name = "dgvGolosinasIncluidas";
            this.dgvGolosinasIncluidas.ReadOnly = true;
            this.dgvGolosinasIncluidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGolosinasIncluidas.Size = new System.Drawing.Size(582, 148);
            this.dgvGolosinasIncluidas.TabIndex = 20;
            // 
            // gbIncluirGolosinas
            // 
            this.gbIncluirGolosinas.Controls.Add(this.btnSacar);
            this.gbIncluirGolosinas.Controls.Add(this.btnAgregar);
            this.gbIncluirGolosinas.Controls.Add(this.btnBuscarProducto);
            this.gbIncluirGolosinas.Controls.Add(this.lblCodProducto);
            this.gbIncluirGolosinas.Controls.Add(this.txtDescripcionGolosina);
            this.gbIncluirGolosinas.Controls.Add(this.lblDescripcion);
            this.gbIncluirGolosinas.Controls.Add(this.txtCantidadGolosina);
            this.gbIncluirGolosinas.Controls.Add(this.txtStockGolosina);
            this.gbIncluirGolosinas.Controls.Add(this.lblCantidad);
            this.gbIncluirGolosinas.Controls.Add(this.lblStock);
            this.gbIncluirGolosinas.Controls.Add(this.txtCodProducto);
            this.gbIncluirGolosinas.Location = new System.Drawing.Point(9, 198);
            this.gbIncluirGolosinas.Name = "gbIncluirGolosinas";
            this.gbIncluirGolosinas.Size = new System.Drawing.Size(582, 145);
            this.gbIncluirGolosinas.TabIndex = 19;
            this.gbIncluirGolosinas.TabStop = false;
            this.gbIncluirGolosinas.Text = "INCLUIR GOLOSINAS:";
            // 
            // btnSacar
            // 
            this.btnSacar.Image = global::CandySur.UI.Properties.Resources.minus_2_icon_14_256;
            this.btnSacar.Location = new System.Drawing.Point(498, 92);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 28);
            this.btnSacar.TabIndex = 30;
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::CandySur.UI.Properties.Resources.FIRST_SET_ICON_part_4_25_512;
            this.btnAgregar.Location = new System.Drawing.Point(417, 92);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 28);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(230, 39);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(43, 29);
            this.btnBuscarProducto.TabIndex = 28;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProducto.Location = new System.Drawing.Point(6, 22);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(103, 19);
            this.lblCodProducto.TabIndex = 18;
            this.lblCodProducto.Text = "Cod. Producto:";
            // 
            // txtDescripcionGolosina
            // 
            this.txtDescripcionGolosina.Enabled = false;
            this.txtDescripcionGolosina.Location = new System.Drawing.Point(290, 41);
            this.txtDescripcionGolosina.Name = "txtDescripcionGolosina";
            this.txtDescripcionGolosina.Size = new System.Drawing.Size(283, 26);
            this.txtDescripcionGolosina.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(286, 22);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 19);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtCantidadGolosina
            // 
            this.txtCantidadGolosina.Location = new System.Drawing.Point(290, 92);
            this.txtCantidadGolosina.Name = "txtCantidadGolosina";
            this.txtCantidadGolosina.Size = new System.Drawing.Size(121, 26);
            this.txtCantidadGolosina.TabIndex = 22;
            // 
            // txtStockGolosina
            // 
            this.txtStockGolosina.Enabled = false;
            this.txtStockGolosina.Location = new System.Drawing.Point(10, 92);
            this.txtStockGolosina.Name = "txtStockGolosina";
            this.txtStockGolosina.Size = new System.Drawing.Size(263, 26);
            this.txtStockGolosina.TabIndex = 14;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(286, 70);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(71, 19);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(6, 70);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 19);
            this.lblStock.TabIndex = 15;
            this.lblStock.Text = "Stock:";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(10, 41);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(214, 26);
            this.txtCodProducto.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(516, 522);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnFinalizar.Location = new System.Drawing.Point(435, 522);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 31);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Visible = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Alta_Paquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(609, 566);
            this.Controls.Add(this.gbAltaPaquete);
            this.Name = "Alta_Paquete";
            this.Text = "Paquete";
            this.Load += new System.EventHandler(this.Alta_Paquete_Load);
            this.gbAltaPaquete.ResumeLayout(false);
            this.gbAltaPaquete.PerformLayout();
            this.gbDatosDelPaquete.ResumeLayout(false);
            this.gbDatosDelPaquete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGolosinasIncluidas)).EndInit();
            this.gbIncluirGolosinas.ResumeLayout(false);
            this.gbIncluirGolosinas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAltaPaquete;
        private System.Windows.Forms.Label lblGolosinasIncluidas;
        private System.Windows.Forms.DataGridView dgvGolosinasIncluidas;
        private System.Windows.Forms.GroupBox gbIncluirGolosinas;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.TextBox txtDescripcionGolosina;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCantidadGolosina;
        private System.Windows.Forms.TextBox txtStockGolosina;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.GroupBox gbDatosDelPaquete;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStockPaquete;
        private System.Windows.Forms.Label lblDescripcionPaquete;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecioTotalAltaPaquete;
        private System.Windows.Forms.Label lblPrecioTotalEtiqueta;
    }
}