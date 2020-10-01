namespace CandySur.UI.Perfil
{
    partial class GestionarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarContraseña));
            this.gbCambiarContraseña = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbIngresoDatos = new System.Windows.Forms.GroupBox();
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.txtNuevapw = new System.Windows.Forms.TextBox();
            this.lblContraseñaActual = new System.Windows.Forms.Label();
            this.lblRepetirContraseña = new System.Windows.Forms.Label();
            this.txtRepetirpw = new System.Windows.Forms.TextBox();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.gbCambiarContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbIngresoDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCambiarContraseña
            // 
            this.gbCambiarContraseña.Controls.Add(this.btnAceptar);
            this.gbCambiarContraseña.Controls.Add(this.btnCambiarContraseña);
            this.gbCambiarContraseña.Controls.Add(this.pictureBox2);
            this.gbCambiarContraseña.Controls.Add(this.gbIngresoDatos);
            this.gbCambiarContraseña.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCambiarContraseña.Location = new System.Drawing.Point(3, 4);
            this.gbCambiarContraseña.Name = "gbCambiarContraseña";
            this.gbCambiarContraseña.Size = new System.Drawing.Size(336, 349);
            this.gbCambiarContraseña.TabIndex = 7;
            this.gbCambiarContraseña.TabStop = false;
            this.gbCambiarContraseña.Text = "CAMBIAR CONTRASEÑA";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Green;
            this.btnAceptar.Location = new System.Drawing.Point(232, 310);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 31);
            this.btnAceptar.TabIndex = 38;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContraseña.ForeColor = System.Drawing.Color.Blue;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(77, 310);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(149, 31);
            this.btnCambiarContraseña.TabIndex = 37;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Visible = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 72);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // gbIngresoDatos
            // 
            this.gbIngresoDatos.Controls.Add(this.txtContraseñaActual);
            this.gbIngresoDatos.Controls.Add(this.txtNuevapw);
            this.gbIngresoDatos.Controls.Add(this.lblContraseñaActual);
            this.gbIngresoDatos.Controls.Add(this.lblRepetirContraseña);
            this.gbIngresoDatos.Controls.Add(this.txtRepetirpw);
            this.gbIngresoDatos.Controls.Add(this.lblNuevaContraseña);
            this.gbIngresoDatos.Location = new System.Drawing.Point(9, 98);
            this.gbIngresoDatos.Name = "gbIngresoDatos";
            this.gbIngresoDatos.Size = new System.Drawing.Size(317, 206);
            this.gbIngresoDatos.TabIndex = 22;
            this.gbIngresoDatos.TabStop = false;
            this.gbIngresoDatos.Text = "INGRESO DE DATOS";
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.Location = new System.Drawing.Point(10, 44);
            this.txtContraseñaActual.MaxLength = 10;
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.PasswordChar = '*';
            this.txtContraseñaActual.Size = new System.Drawing.Size(301, 26);
            this.txtContraseñaActual.TabIndex = 33;
            // 
            // txtNuevapw
            // 
            this.txtNuevapw.Location = new System.Drawing.Point(10, 95);
            this.txtNuevapw.MaxLength = 10;
            this.txtNuevapw.Name = "txtNuevapw";
            this.txtNuevapw.PasswordChar = '*';
            this.txtNuevapw.Size = new System.Drawing.Size(301, 26);
            this.txtNuevapw.TabIndex = 32;
            // 
            // lblContraseñaActual
            // 
            this.lblContraseñaActual.AutoSize = true;
            this.lblContraseñaActual.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaActual.Location = new System.Drawing.Point(6, 22);
            this.lblContraseñaActual.Name = "lblContraseñaActual";
            this.lblContraseñaActual.Size = new System.Drawing.Size(131, 19);
            this.lblContraseñaActual.TabIndex = 28;
            this.lblContraseñaActual.Text = "Contraseña actual:";
            // 
            // lblRepetirContraseña
            // 
            this.lblRepetirContraseña.AutoSize = true;
            this.lblRepetirContraseña.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirContraseña.Location = new System.Drawing.Point(6, 124);
            this.lblRepetirContraseña.Name = "lblRepetirContraseña";
            this.lblRepetirContraseña.Size = new System.Drawing.Size(134, 19);
            this.lblRepetirContraseña.TabIndex = 34;
            this.lblRepetirContraseña.Text = "Repetir Contraseña";
            // 
            // txtRepetirpw
            // 
            this.txtRepetirpw.Location = new System.Drawing.Point(9, 146);
            this.txtRepetirpw.MaxLength = 10;
            this.txtRepetirpw.Name = "txtRepetirpw";
            this.txtRepetirpw.PasswordChar = '*';
            this.txtRepetirpw.Size = new System.Drawing.Size(302, 26);
            this.txtRepetirpw.TabIndex = 35;
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContraseña.Location = new System.Drawing.Point(6, 73);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(132, 19);
            this.lblNuevaContraseña.TabIndex = 31;
            this.lblNuevaContraseña.Text = "Nueva Contraseña:";
            // 
            // GestionarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(343, 358);
            this.Controls.Add(this.gbCambiarContraseña);
            this.Name = "GestionarContraseña";
            this.Text = "Gestionar Contraseña";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionarContraseña_FormClosing);
            this.Load += new System.EventHandler(this.GestionarContraseña_Load);
            this.gbCambiarContraseña.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbIngresoDatos.ResumeLayout(false);
            this.gbIngresoDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCambiarContraseña;
        private System.Windows.Forms.GroupBox gbIngresoDatos;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.TextBox txtNuevapw;
        private System.Windows.Forms.Label lblContraseñaActual;
        private System.Windows.Forms.Label lblRepetirContraseña;
        private System.Windows.Forms.TextBox txtRepetirpw;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAceptar;
    }
}