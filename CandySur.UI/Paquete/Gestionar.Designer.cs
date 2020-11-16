namespace CandySur.UI.Paquete
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
            this.gbGestionar = new System.Windows.Forms.GroupBox();
            this.gbDatosDelPaquete = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.lblCodPaquete = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblGolosinasIncluidas = new System.Windows.Forms.Label();
            this.dgvGolosinas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbGestionar.SuspendLayout();
            this.gbDatosDelPaquete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGolosinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGestionar
            // 
            this.gbGestionar.Controls.Add(this.gbDatosDelPaquete);
            this.gbGestionar.Controls.Add(this.btnEliminar);
            this.gbGestionar.Controls.Add(this.lblGolosinasIncluidas);
            this.gbGestionar.Controls.Add(this.dgvGolosinas);
            this.gbGestionar.Controls.Add(this.pictureBox1);
            this.gbGestionar.Controls.Add(this.btnAceptar);
            this.gbGestionar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGestionar.Location = new System.Drawing.Point(2, 3);
            this.gbGestionar.Name = "gbGestionar";
            this.gbGestionar.Size = new System.Drawing.Size(602, 460);
            this.gbGestionar.TabIndex = 4;
            this.gbGestionar.TabStop = false;
            this.gbGestionar.Text = "GESTIONAR";
            // 
            // gbDatosDelPaquete
            // 
            this.gbDatosDelPaquete.Controls.Add(this.btnBuscarProducto);
            this.gbDatosDelPaquete.Controls.Add(this.txtCodProducto);
            this.gbDatosDelPaquete.Controls.Add(this.lblCodPaquete);
            this.gbDatosDelPaquete.Controls.Add(this.txtPrecio);
            this.gbDatosDelPaquete.Controls.Add(this.lblPrecio);
            this.gbDatosDelPaquete.Controls.Add(this.txtStock);
            this.gbDatosDelPaquete.Controls.Add(this.lblStock);
            this.gbDatosDelPaquete.Controls.Add(this.lblDescripcion);
            this.gbDatosDelPaquete.Controls.Add(this.txtDescripcion);
            this.gbDatosDelPaquete.Location = new System.Drawing.Point(10, 98);
            this.gbDatosDelPaquete.Name = "gbDatosDelPaquete";
            this.gbDatosDelPaquete.Size = new System.Drawing.Size(582, 140);
            this.gbDatosDelPaquete.TabIndex = 23;
            this.gbDatosDelPaquete.TabStop = false;
            this.gbDatosDelPaquete.Text = "DATOS DEL PAQUETE:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(230, 42);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(43, 29);
            this.btnBuscarProducto.TabIndex = 36;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(10, 44);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(214, 26);
            this.txtCodProducto.TabIndex = 35;
            // 
            // lblCodPaquete
            // 
            this.lblCodPaquete.AutoSize = true;
            this.lblCodPaquete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPaquete.Location = new System.Drawing.Point(6, 22);
            this.lblCodPaquete.Name = "lblCodPaquete";
            this.lblCodPaquete.Size = new System.Drawing.Size(99, 19);
            this.lblCodPaquete.TabIndex = 24;
            this.lblCodPaquete.Text = "Cod. Paquete:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(10, 92);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(263, 26);
            this.txtPrecio.TabIndex = 22;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(6, 70);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 19);
            this.lblPrecio.TabIndex = 23;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(283, 92);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(287, 26);
            this.txtStock.TabIndex = 20;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(279, 70);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 19);
            this.lblStock.TabIndex = 21;
            this.lblStock.Text = "Stock:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(279, 22);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 19);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(283, 41);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(287, 26);
            this.txtDescripcion.TabIndex = 19;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Location = new System.Drawing.Point(436, 417);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 31);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblGolosinasIncluidas
            // 
            this.lblGolosinasIncluidas.AutoSize = true;
            this.lblGolosinasIncluidas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolosinasIncluidas.Location = new System.Drawing.Point(6, 241);
            this.lblGolosinasIncluidas.Name = "lblGolosinasIncluidas";
            this.lblGolosinasIncluidas.Size = new System.Drawing.Size(163, 19);
            this.lblGolosinasIncluidas.TabIndex = 16;
            this.lblGolosinasIncluidas.Text = "GOLOSINAS INCLUIDAS:";
            // 
            // dgvGolosinas
            // 
            this.dgvGolosinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGolosinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGolosinas.Location = new System.Drawing.Point(10, 263);
            this.dgvGolosinas.MultiSelect = false;
            this.dgvGolosinas.Name = "dgvGolosinas";
            this.dgvGolosinas.ReadOnly = true;
            this.dgvGolosinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGolosinas.Size = new System.Drawing.Size(582, 148);
            this.dgvGolosinas.TabIndex = 6;
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
            this.btnAceptar.Location = new System.Drawing.Point(517, 417);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Gestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(610, 468);
            this.Controls.Add(this.gbGestionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Paquete";
            this.Load += new System.EventHandler(this.Gestionar_Load);
            this.gbGestionar.ResumeLayout(false);
            this.gbGestionar.PerformLayout();
            this.gbDatosDelPaquete.ResumeLayout(false);
            this.gbDatosDelPaquete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGolosinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGestionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblGolosinasIncluidas;
        private System.Windows.Forms.DataGridView dgvGolosinas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbDatosDelPaquete;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCodPaquete;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtCodProducto;
    }
}