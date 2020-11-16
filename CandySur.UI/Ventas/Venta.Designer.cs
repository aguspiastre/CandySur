namespace CandySur.UI
{
    partial class Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.gbGestionarVenta = new System.Windows.Forms.GroupBox();
            this.lblProductosIncluidos = new System.Windows.Forms.Label();
            this.gbDatosDeLaVenta = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblTipoProd = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.rdbPaquete = new System.Windows.Forms.RadioButton();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.rdbProducto = new System.Windows.Forms.RadioButton();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnSacarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblImporteTotalGenerarVenta = new System.Windows.Forms.Label();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.lblImportaTotalLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.gbGestionarVenta.SuspendLayout();
            this.gbDatosDeLaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(10, 312);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(582, 188);
            this.dgvDetalles.TabIndex = 0;
            // 
            // gbGestionarVenta
            // 
            this.gbGestionarVenta.Controls.Add(this.lblProductosIncluidos);
            this.gbGestionarVenta.Controls.Add(this.gbDatosDeLaVenta);
            this.gbGestionarVenta.Controls.Add(this.btnCancelar);
            this.gbGestionarVenta.Controls.Add(this.pictureBox1);
            this.gbGestionarVenta.Controls.Add(this.lblImporteTotalGenerarVenta);
            this.gbGestionarVenta.Controls.Add(this.btnAvanzar);
            this.gbGestionarVenta.Controls.Add(this.lblImportaTotalLbl);
            this.gbGestionarVenta.Controls.Add(this.dgvDetalles);
            this.gbGestionarVenta.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGestionarVenta.Location = new System.Drawing.Point(6, 3);
            this.gbGestionarVenta.Name = "gbGestionarVenta";
            this.gbGestionarVenta.Size = new System.Drawing.Size(602, 548);
            this.gbGestionarVenta.TabIndex = 1;
            this.gbGestionarVenta.TabStop = false;
            this.gbGestionarVenta.Text = "GENERAR VENTA";
            // 
            // lblProductosIncluidos
            // 
            this.lblProductosIncluidos.AutoSize = true;
            this.lblProductosIncluidos.Location = new System.Drawing.Point(7, 291);
            this.lblProductosIncluidos.Name = "lblProductosIncluidos";
            this.lblProductosIncluidos.Size = new System.Drawing.Size(158, 18);
            this.lblProductosIncluidos.TabIndex = 6;
            this.lblProductosIncluidos.Text = "PRODUCTOS INCLUIDOS:";
            // 
            // gbDatosDeLaVenta
            // 
            this.gbDatosDeLaVenta.Controls.Add(this.lblStock);
            this.gbDatosDeLaVenta.Controls.Add(this.lblDescripcion);
            this.gbDatosDeLaVenta.Controls.Add(this.txtDescripcion);
            this.gbDatosDeLaVenta.Controls.Add(this.lblCodProducto);
            this.gbDatosDeLaVenta.Controls.Add(this.txtStock);
            this.gbDatosDeLaVenta.Controls.Add(this.lblTipoProd);
            this.gbDatosDeLaVenta.Controls.Add(this.txtCodProducto);
            this.gbDatosDeLaVenta.Controls.Add(this.lblPrecio);
            this.gbDatosDeLaVenta.Controls.Add(this.lblCantidad);
            this.gbDatosDeLaVenta.Controls.Add(this.rdbPaquete);
            this.gbDatosDeLaVenta.Controls.Add(this.txtPrecio);
            this.gbDatosDeLaVenta.Controls.Add(this.txtCantidad);
            this.gbDatosDeLaVenta.Controls.Add(this.rdbProducto);
            this.gbDatosDeLaVenta.Controls.Add(this.btnBuscarProducto);
            this.gbDatosDeLaVenta.Controls.Add(this.btnSacarProducto);
            this.gbDatosDeLaVenta.Controls.Add(this.btnAgregarProducto);
            this.gbDatosDeLaVenta.Location = new System.Drawing.Point(10, 98);
            this.gbDatosDeLaVenta.Name = "gbDatosDeLaVenta";
            this.gbDatosDeLaVenta.Size = new System.Drawing.Size(582, 190);
            this.gbDatosDeLaVenta.TabIndex = 2;
            this.gbDatosDeLaVenta.TabStop = false;
            this.gbDatosDeLaVenta.Text = "DATOS DE LA VENTA";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(436, 73);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 19);
            this.lblStock.TabIndex = 20;
            this.lblStock.Text = "Stock:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(299, 22);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 19);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(303, 44);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(271, 26);
            this.txtDescripcion.TabIndex = 18;
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProducto.Location = new System.Drawing.Point(5, 74);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(99, 19);
            this.lblCodProducto.TabIndex = 4;
            this.lblCodProducto.Text = "Cod producto:";
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(440, 96);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(134, 26);
            this.txtStock.TabIndex = 21;
            // 
            // lblTipoProd
            // 
            this.lblTipoProd.AutoSize = true;
            this.lblTipoProd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProd.Location = new System.Drawing.Point(5, 26);
            this.lblTipoProd.Name = "lblTipoProd";
            this.lblTipoProd.Size = new System.Drawing.Size(102, 19);
            this.lblTipoProd.TabIndex = 4;
            this.lblTipoProd.Text = "Tipo Producto:";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(9, 98);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(227, 26);
            this.txtCodProducto.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(299, 74);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 19);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(5, 126);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(71, 19);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // rdbPaquete
            // 
            this.rdbPaquete.AutoSize = true;
            this.rdbPaquete.Location = new System.Drawing.Point(115, 48);
            this.rdbPaquete.Name = "rdbPaquete";
            this.rdbPaquete.Size = new System.Drawing.Size(78, 22);
            this.rdbPaquete.TabIndex = 6;
            this.rdbPaquete.TabStop = true;
            this.rdbPaquete.Text = "Paquete";
            this.rdbPaquete.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(303, 96);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(131, 26);
            this.txtPrecio.TabIndex = 12;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(9, 148);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(273, 26);
            this.txtCantidad.TabIndex = 10;
            // 
            // rdbProducto
            // 
            this.rdbProducto.AutoSize = true;
            this.rdbProducto.Location = new System.Drawing.Point(13, 48);
            this.rdbProducto.Name = "rdbProducto";
            this.rdbProducto.Size = new System.Drawing.Size(80, 22);
            this.rdbProducto.TabIndex = 5;
            this.rdbProducto.TabStop = true;
            this.rdbProducto.Text = "Golosina";
            this.rdbProducto.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(239, 96);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(43, 29);
            this.btnBuscarProducto.TabIndex = 8;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnSacarProducto
            // 
            this.btnSacarProducto.Image = global::CandySur.UI.Properties.Resources.minus_2_icon_14_256;
            this.btnSacarProducto.Location = new System.Drawing.Point(440, 146);
            this.btnSacarProducto.Name = "btnSacarProducto";
            this.btnSacarProducto.Size = new System.Drawing.Size(136, 28);
            this.btnSacarProducto.TabIndex = 14;
            this.btnSacarProducto.UseVisualStyleBackColor = true;
            this.btnSacarProducto.Click += new System.EventHandler(this.btnSacarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Image = global::CandySur.UI.Properties.Resources.FIRST_SET_ICON_part_4_25_512;
            this.btnAgregarProducto.Location = new System.Drawing.Point(300, 146);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(134, 28);
            this.btnAgregarProducto.TabIndex = 13;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(517, 506);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 3;
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
            // lblImporteTotalGenerarVenta
            // 
            this.lblImporteTotalGenerarVenta.AutoSize = true;
            this.lblImporteTotalGenerarVenta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotalGenerarVenta.Location = new System.Drawing.Point(102, 511);
            this.lblImporteTotalGenerarVenta.Name = "lblImporteTotalGenerarVenta";
            this.lblImporteTotalGenerarVenta.Size = new System.Drawing.Size(29, 19);
            this.lblImporteTotalGenerarVenta.TabIndex = 4;
            this.lblImporteTotalGenerarVenta.Text = "$ 0";
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.BackColor = System.Drawing.Color.Transparent;
            this.btnAvanzar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvanzar.ForeColor = System.Drawing.Color.Green;
            this.btnAvanzar.Location = new System.Drawing.Point(436, 506);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(75, 31);
            this.btnAvanzar.TabIndex = 2;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = false;
            this.btnAvanzar.Visible = false;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // lblImportaTotalLbl
            // 
            this.lblImportaTotalLbl.AutoSize = true;
            this.lblImportaTotalLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportaTotalLbl.Location = new System.Drawing.Point(6, 511);
            this.lblImportaTotalLbl.Name = "lblImportaTotalLbl";
            this.lblImportaTotalLbl.Size = new System.Drawing.Size(99, 19);
            this.lblImportaTotalLbl.TabIndex = 1;
            this.lblImportaTotalLbl.Text = "Importe Total:";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(614, 556);
            this.Controls.Add(this.gbGestionarVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.gbGestionarVenta.ResumeLayout(false);
            this.gbGestionarVenta.PerformLayout();
            this.gbDatosDeLaVenta.ResumeLayout(false);
            this.gbDatosDeLaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.GroupBox gbGestionarVenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblImporteTotalGenerarVenta;
        private System.Windows.Forms.Button btnSacarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Label lblImportaTotalLbl;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdbPaquete;
        private System.Windows.Forms.RadioButton rdbProducto;
        private System.Windows.Forms.Label lblTipoProd;
        private System.Windows.Forms.Label lblProductosIncluidos;
        private System.Windows.Forms.GroupBox gbDatosDeLaVenta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
    }
}