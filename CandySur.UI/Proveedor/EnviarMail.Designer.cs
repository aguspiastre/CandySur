namespace CandySur.UI.Proveedor
{
    partial class EnviarMail
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
            this.gbEnviarMail = new System.Windows.Forms.GroupBox();
            this.gbDatosDelProveedor = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.gbDatosDelProducto = new System.Windows.Forms.GroupBox();
            this.txtDescripcionProd = new System.Windows.Forms.TextBox();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.txtCantidadAReponer = new System.Windows.Forms.TextBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.lblCantidReponer = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbEnviarMail.SuspendLayout();
            this.gbDatosDelProveedor.SuspendLayout();
            this.gbDatosDelProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEnviarMail
            // 
            this.gbEnviarMail.Controls.Add(this.gbDatosDelProveedor);
            this.gbEnviarMail.Controls.Add(this.gbDatosDelProducto);
            this.gbEnviarMail.Controls.Add(this.btnCancelar);
            this.gbEnviarMail.Controls.Add(this.btnEnviar);
            this.gbEnviarMail.Controls.Add(this.pictureBox1);
            this.gbEnviarMail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEnviarMail.Location = new System.Drawing.Point(-4, 1);
            this.gbEnviarMail.Name = "gbEnviarMail";
            this.gbEnviarMail.Size = new System.Drawing.Size(602, 404);
            this.gbEnviarMail.TabIndex = 6;
            this.gbEnviarMail.TabStop = false;
            this.gbEnviarMail.Text = "ENVIAR MAIL";
            // 
            // gbDatosDelProveedor
            // 
            this.gbDatosDelProveedor.Controls.Add(this.lblEmail);
            this.gbDatosDelProveedor.Controls.Add(this.lblCuit);
            this.gbDatosDelProveedor.Controls.Add(this.txtEmail);
            this.gbDatosDelProveedor.Controls.Add(this.txtCuit);
            this.gbDatosDelProveedor.Controls.Add(this.lblRazonSocial);
            this.gbDatosDelProveedor.Controls.Add(this.txtTelefono);
            this.gbDatosDelProveedor.Controls.Add(this.txtRazonSocial);
            this.gbDatosDelProveedor.Controls.Add(this.lblTelefono);
            this.gbDatosDelProveedor.Location = new System.Drawing.Point(10, 98);
            this.gbDatosDelProveedor.Name = "gbDatosDelProveedor";
            this.gbDatosDelProveedor.Size = new System.Drawing.Size(585, 125);
            this.gbDatosDelProveedor.TabIndex = 6;
            this.gbDatosDelProveedor.TabStop = false;
            this.gbDatosDelProveedor.Text = "DATOS DEL PROVEEDOR";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(287, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 19);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.Location = new System.Drawing.Point(6, 16);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(39, 19);
            this.lblCuit.TabIndex = 18;
            this.lblCuit.Text = "Cuit:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(290, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 26);
            this.txtEmail.TabIndex = 37;
            // 
            // txtCuit
            // 
            this.txtCuit.Enabled = false;
            this.txtCuit.Location = new System.Drawing.Point(10, 35);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(265, 26);
            this.txtCuit.TabIndex = 19;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(286, 16);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(94, 19);
            this.lblRazonSocial.TabIndex = 34;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(10, 83);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(265, 26);
            this.txtTelefono.TabIndex = 33;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(290, 35);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(279, 26);
            this.txtRazonSocial.TabIndex = 35;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(6, 64);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 19);
            this.lblTelefono.TabIndex = 32;
            this.lblTelefono.Text = "Telefono:";
            // 
            // gbDatosDelProducto
            // 
            this.gbDatosDelProducto.Controls.Add(this.txtDescripcionProd);
            this.gbDatosDelProducto.Controls.Add(this.lblCodProducto);
            this.gbDatosDelProducto.Controls.Add(this.txtCantidadAReponer);
            this.gbDatosDelProducto.Controls.Add(this.txtCodProducto);
            this.gbDatosDelProducto.Controls.Add(this.lblStock);
            this.gbDatosDelProducto.Controls.Add(this.lblDescripcion);
            this.gbDatosDelProducto.Controls.Add(this.txtStockActual);
            this.gbDatosDelProducto.Controls.Add(this.lblCantidReponer);
            this.gbDatosDelProducto.Location = new System.Drawing.Point(10, 229);
            this.gbDatosDelProducto.Name = "gbDatosDelProducto";
            this.gbDatosDelProducto.Size = new System.Drawing.Size(585, 129);
            this.gbDatosDelProducto.TabIndex = 37;
            this.gbDatosDelProducto.TabStop = false;
            this.gbDatosDelProducto.Text = "DATOS DEL PRODUCTO";
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.Enabled = false;
            this.txtDescripcionProd.Location = new System.Drawing.Point(289, 35);
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Size = new System.Drawing.Size(283, 26);
            this.txtDescripcionProd.TabIndex = 36;
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProducto.Location = new System.Drawing.Point(6, 16);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(103, 19);
            this.lblCodProducto.TabIndex = 32;
            this.lblCodProducto.Text = "Cod. Producto:";
            // 
            // txtCantidadAReponer
            // 
            this.txtCantidadAReponer.Location = new System.Drawing.Point(291, 86);
            this.txtCantidadAReponer.Name = "txtCantidadAReponer";
            this.txtCantidadAReponer.Size = new System.Drawing.Size(278, 26);
            this.txtCantidadAReponer.TabIndex = 35;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Enabled = false;
            this.txtCodProducto.Location = new System.Drawing.Point(9, 35);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(263, 26);
            this.txtCodProducto.TabIndex = 33;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(5, 64);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 19);
            this.lblStock.TabIndex = 13;
            this.lblStock.Text = "Stock:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(287, 13);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 19);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtStockActual
            // 
            this.txtStockActual.Enabled = false;
            this.txtStockActual.Location = new System.Drawing.Point(9, 86);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(266, 26);
            this.txtStockActual.TabIndex = 22;
            // 
            // lblCantidReponer
            // 
            this.lblCantidReponer.AutoSize = true;
            this.lblCantidReponer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidReponer.Location = new System.Drawing.Point(287, 64);
            this.lblCantidReponer.Name = "lblCantidReponer";
            this.lblCantidReponer.Size = new System.Drawing.Size(141, 19);
            this.lblCantidReponer.TabIndex = 16;
            this.lblCantidReponer.Text = "Cantidad a Reponer:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(521, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Green;
            this.btnEnviar.Location = new System.Drawing.Point(440, 364);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 31);
            this.btnEnviar.TabIndex = 19;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Visible = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
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
            // EnviarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(602, 410);
            this.Controls.Add(this.gbEnviarMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnviarMail";
            this.Text = "EnviarMail";
            this.Load += new System.EventHandler(this.EnviarMail_Load);
            this.gbEnviarMail.ResumeLayout(false);
            this.gbDatosDelProveedor.ResumeLayout(false);
            this.gbDatosDelProveedor.PerformLayout();
            this.gbDatosDelProducto.ResumeLayout(false);
            this.gbDatosDelProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEnviarMail;
        private System.Windows.Forms.GroupBox gbDatosDelProveedor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox gbDatosDelProducto;
        private System.Windows.Forms.TextBox txtDescripcionProd;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.TextBox txtCantidadAReponer;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Label lblCantidReponer;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}