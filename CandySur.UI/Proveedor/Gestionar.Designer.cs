namespace CandySur.UI.Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar));
            this.gbGestionarProveedor = new System.Windows.Forms.GroupBox();
            this.btnEnviarMailReposicion = new System.Windows.Forms.Button();
            this.gbDatosDelProveedor = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCodPosal = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblProductosSuministrados = new System.Windows.Forms.Label();
            this.dgvProductosSuministrados = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbGestionarProveedor.SuspendLayout();
            this.gbDatosDelProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSuministrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGestionarProveedor
            // 
            this.gbGestionarProveedor.Controls.Add(this.btnEnviarMailReposicion);
            this.gbGestionarProveedor.Controls.Add(this.gbDatosDelProveedor);
            this.gbGestionarProveedor.Controls.Add(this.btnModificar);
            this.gbGestionarProveedor.Controls.Add(this.btnEliminar);
            this.gbGestionarProveedor.Controls.Add(this.lblProductosSuministrados);
            this.gbGestionarProveedor.Controls.Add(this.dgvProductosSuministrados);
            this.gbGestionarProveedor.Controls.Add(this.pictureBox1);
            this.gbGestionarProveedor.Controls.Add(this.btnAceptar);
            this.gbGestionarProveedor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGestionarProveedor.Location = new System.Drawing.Point(4, 5);
            this.gbGestionarProveedor.Name = "gbGestionarProveedor";
            this.gbGestionarProveedor.Size = new System.Drawing.Size(602, 514);
            this.gbGestionarProveedor.TabIndex = 3;
            this.gbGestionarProveedor.TabStop = false;
            this.gbGestionarProveedor.Text = "GESTIONAR";
            // 
            // btnEnviarMailReposicion
            // 
            this.btnEnviarMailReposicion.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviarMailReposicion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarMailReposicion.ForeColor = System.Drawing.Color.Blue;
            this.btnEnviarMailReposicion.Location = new System.Drawing.Point(14, 470);
            this.btnEnviarMailReposicion.Name = "btnEnviarMailReposicion";
            this.btnEnviarMailReposicion.Size = new System.Drawing.Size(174, 31);
            this.btnEnviarMailReposicion.TabIndex = 20;
            this.btnEnviarMailReposicion.Text = "Enviar Mail Reposicion";
            this.btnEnviarMailReposicion.UseVisualStyleBackColor = false;
            this.btnEnviarMailReposicion.Visible = false;
            this.btnEnviarMailReposicion.Click += new System.EventHandler(this.btnEnviarMailReposicion_Click);
            // 
            // gbDatosDelProveedor
            // 
            this.gbDatosDelProveedor.Controls.Add(this.btnBuscarProducto);
            this.gbDatosDelProveedor.Controls.Add(this.lblCuit);
            this.gbDatosDelProveedor.Controls.Add(this.txtEmail);
            this.gbDatosDelProveedor.Controls.Add(this.txtRazonSocial);
            this.gbDatosDelProveedor.Controls.Add(this.lblEmail);
            this.gbDatosDelProveedor.Controls.Add(this.lblRazonSocial);
            this.gbDatosDelProveedor.Controls.Add(this.txtDireccion);
            this.gbDatosDelProveedor.Controls.Add(this.txtCodPostal);
            this.gbDatosDelProveedor.Controls.Add(this.lblDireccion);
            this.gbDatosDelProveedor.Controls.Add(this.lblTelefono);
            this.gbDatosDelProveedor.Controls.Add(this.txtTelefono);
            this.gbDatosDelProveedor.Controls.Add(this.lblCodPosal);
            this.gbDatosDelProveedor.Controls.Add(this.txtCuit);
            this.gbDatosDelProveedor.Location = new System.Drawing.Point(10, 99);
            this.gbDatosDelProveedor.Name = "gbDatosDelProveedor";
            this.gbDatosDelProveedor.Size = new System.Drawing.Size(582, 194);
            this.gbDatosDelProveedor.TabIndex = 19;
            this.gbDatosDelProveedor.TabStop = false;
            this.gbDatosDelProveedor.Text = "DATOS DEL PROVEEDOR";
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
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.Location = new System.Drawing.Point(6, 22);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(39, 19);
            this.lblCuit.TabIndex = 18;
            this.lblCuit.Text = "Cuit:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(10, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 26);
            this.txtEmail.TabIndex = 27;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(290, 41);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(283, 26);
            this.txtRazonSocial.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 19);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(286, 22);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(94, 19);
            this.lblRazonSocial.TabIndex = 4;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(291, 92);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(282, 26);
            this.txtDireccion.TabIndex = 22;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(10, 143);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(263, 26);
            this.txtCodPostal.TabIndex = 21;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(287, 70);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(74, 19);
            this.lblDireccion.TabIndex = 13;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(287, 121);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 19);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(290, 143);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(283, 26);
            this.txtTelefono.TabIndex = 25;
            // 
            // lblCodPosal
            // 
            this.lblCodPosal.AutoSize = true;
            this.lblCodPosal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPosal.Location = new System.Drawing.Point(6, 121);
            this.lblCodPosal.Name = "lblCodPosal";
            this.lblCodPosal.Size = new System.Drawing.Size(70, 19);
            this.lblCodPosal.TabIndex = 16;
            this.lblCodPosal.Text = "C. Postal:";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(10, 41);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(214, 26);
            this.txtCuit.TabIndex = 19;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.Location = new System.Drawing.Point(440, 472);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 31);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Location = new System.Drawing.Point(359, 472);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 31);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblProductosSuministrados
            // 
            this.lblProductosSuministrados.AutoSize = true;
            this.lblProductosSuministrados.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosSuministrados.Location = new System.Drawing.Point(8, 296);
            this.lblProductosSuministrados.Name = "lblProductosSuministrados";
            this.lblProductosSuministrados.Size = new System.Drawing.Size(209, 19);
            this.lblProductosSuministrados.TabIndex = 16;
            this.lblProductosSuministrados.Text = "PRODUCTOS SUMINISTRADOS:";
            // 
            // dgvProductosSuministrados
            // 
            this.dgvProductosSuministrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosSuministrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosSuministrados.Enabled = false;
            this.dgvProductosSuministrados.Location = new System.Drawing.Point(12, 318);
            this.dgvProductosSuministrados.Name = "dgvProductosSuministrados";
            this.dgvProductosSuministrados.ReadOnly = true;
            this.dgvProductosSuministrados.Size = new System.Drawing.Size(582, 148);
            this.dgvProductosSuministrados.TabIndex = 6;
            this.dgvProductosSuministrados.SelectionChanged += new System.EventHandler(this.dgvProductosSuministrados_SelectionChanged);
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
            this.btnAceptar.Location = new System.Drawing.Point(521, 472);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(610, 522);
            this.Controls.Add(this.gbGestionarProveedor);
            this.Name = "Gestionar";
            this.Text = "Gestionar Proveedor";
            this.Load += new System.EventHandler(this.Gestionar_Load);
            this.gbGestionarProveedor.ResumeLayout(false);
            this.gbGestionarProveedor.PerformLayout();
            this.gbDatosDelProveedor.ResumeLayout(false);
            this.gbDatosDelProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSuministrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGestionarProveedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblCodPosal;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblProductosSuministrados;
        private System.Windows.Forms.DataGridView dgvProductosSuministrados;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbDatosDelProveedor;
        private System.Windows.Forms.Button btnEnviarMailReposicion;
    }
}