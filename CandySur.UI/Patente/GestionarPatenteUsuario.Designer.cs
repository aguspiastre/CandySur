namespace CandySur.UI.Patente
{
    partial class GestionarPatenteUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPatenteUsuario));
            this.gbAsignarPatenteUsuario = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbPatentesDisponibles = new System.Windows.Forms.GroupBox();
            this.lblPatentesDesasignar = new System.Windows.Forms.Label();
            this.lblPatentesAsignar = new System.Windows.Forms.Label();
            this.listPatenteAsignar = new System.Windows.Forms.ListView();
            this.listPatenteDesasignar = new System.Windows.Forms.ListView();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.gbFiltrosBusquedaBitacora = new System.Windows.Forms.GroupBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombreDelUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbAsignarPatenteUsuario.SuspendLayout();
            this.gbPatentesDisponibles.SuspendLayout();
            this.gbFiltrosBusquedaBitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAsignarPatenteUsuario
            // 
            this.gbAsignarPatenteUsuario.Controls.Add(this.btnAceptar);
            this.gbAsignarPatenteUsuario.Controls.Add(this.gbPatentesDisponibles);
            this.gbAsignarPatenteUsuario.Controls.Add(this.gbFiltrosBusquedaBitacora);
            this.gbAsignarPatenteUsuario.Controls.Add(this.pictureBox1);
            this.gbAsignarPatenteUsuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAsignarPatenteUsuario.Location = new System.Drawing.Point(3, 6);
            this.gbAsignarPatenteUsuario.Name = "gbAsignarPatenteUsuario";
            this.gbAsignarPatenteUsuario.Size = new System.Drawing.Size(602, 493);
            this.gbAsignarPatenteUsuario.TabIndex = 6;
            this.gbAsignarPatenteUsuario.TabStop = false;
            this.gbAsignarPatenteUsuario.Text = "ASIGNAR PATENTE A USUARIO";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Green;
            this.btnAceptar.Location = new System.Drawing.Point(517, 454);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbPatentesDisponibles
            // 
            this.gbPatentesDisponibles.Controls.Add(this.lblPatentesDesasignar);
            this.gbPatentesDisponibles.Controls.Add(this.lblPatentesAsignar);
            this.gbPatentesDisponibles.Controls.Add(this.listPatenteAsignar);
            this.gbPatentesDisponibles.Controls.Add(this.listPatenteDesasignar);
            this.gbPatentesDisponibles.Controls.Add(this.btnDesasignar);
            this.gbPatentesDisponibles.Controls.Add(this.btnAsignar);
            this.gbPatentesDisponibles.Location = new System.Drawing.Point(10, 193);
            this.gbPatentesDisponibles.Name = "gbPatentesDisponibles";
            this.gbPatentesDisponibles.Size = new System.Drawing.Size(582, 255);
            this.gbPatentesDisponibles.TabIndex = 22;
            this.gbPatentesDisponibles.TabStop = false;
            this.gbPatentesDisponibles.Text = "PATENTES DISPONIBLES";
            // 
            // lblPatentesDesasignar
            // 
            this.lblPatentesDesasignar.AutoSize = true;
            this.lblPatentesDesasignar.Location = new System.Drawing.Point(394, 24);
            this.lblPatentesDesasignar.Name = "lblPatentesDesasignar";
            this.lblPatentesDesasignar.Size = new System.Drawing.Size(143, 18);
            this.lblPatentesDesasignar.TabIndex = 24;
            this.lblPatentesDesasignar.Text = "Patentes a Desasignar";
            // 
            // lblPatentesAsignar
            // 
            this.lblPatentesAsignar.AutoSize = true;
            this.lblPatentesAsignar.Location = new System.Drawing.Point(53, 24);
            this.lblPatentesAsignar.Name = "lblPatentesAsignar";
            this.lblPatentesAsignar.Size = new System.Drawing.Size(125, 18);
            this.lblPatentesAsignar.TabIndex = 23;
            this.lblPatentesAsignar.Text = "Patentes  a Asignar";
            // 
            // listPatenteAsignar
            // 
            this.listPatenteAsignar.Location = new System.Drawing.Point(6, 45);
            this.listPatenteAsignar.MultiSelect = false;
            this.listPatenteAsignar.Name = "listPatenteAsignar";
            this.listPatenteAsignar.Size = new System.Drawing.Size(222, 191);
            this.listPatenteAsignar.TabIndex = 22;
            this.listPatenteAsignar.UseCompatibleStateImageBehavior = false;
            this.listPatenteAsignar.View = System.Windows.Forms.View.List;
            // 
            // listPatenteDesasignar
            // 
            this.listPatenteDesasignar.Location = new System.Drawing.Point(351, 45);
            this.listPatenteDesasignar.Name = "listPatenteDesasignar";
            this.listPatenteDesasignar.Size = new System.Drawing.Size(222, 191);
            this.listPatenteDesasignar.TabIndex = 21;
            this.listPatenteDesasignar.UseCompatibleStateImageBehavior = false;
            this.listPatenteDesasignar.View = System.Windows.Forms.View.List;
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesasignar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDesasignar.Location = new System.Drawing.Point(234, 139);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(111, 31);
            this.btnDesasignar.TabIndex = 17;
            this.btnDesasignar.Text = "<- Desasignar ";
            this.btnDesasignar.UseVisualStyleBackColor = false;
            this.btnDesasignar.Visible = false;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.Blue;
            this.btnAsignar.Location = new System.Drawing.Point(234, 102);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(111, 31);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar ->";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Visible = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // gbFiltrosBusquedaBitacora
            // 
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.txtNombreUsuario);
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.btnBuscar);
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.lblNombreDelUsuario);
            this.gbFiltrosBusquedaBitacora.Location = new System.Drawing.Point(10, 99);
            this.gbFiltrosBusquedaBitacora.Name = "gbFiltrosBusquedaBitacora";
            this.gbFiltrosBusquedaBitacora.Size = new System.Drawing.Size(582, 88);
            this.gbFiltrosBusquedaBitacora.TabIndex = 19;
            this.gbFiltrosBusquedaBitacora.TabStop = false;
            this.gbFiltrosBusquedaBitacora.Text = "FILTROS DE BUSQUEDA";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(10, 43);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(211, 26);
            this.txtNombreUsuario.TabIndex = 35;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(227, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(43, 29);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombreDelUsuario
            // 
            this.lblNombreDelUsuario.AutoSize = true;
            this.lblNombreDelUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDelUsuario.Location = new System.Drawing.Point(6, 22);
            this.lblNombreDelUsuario.Name = "lblNombreDelUsuario";
            this.lblNombreDelUsuario.Size = new System.Drawing.Size(140, 19);
            this.lblNombreDelUsuario.TabIndex = 18;
            this.lblNombreDelUsuario.Text = "Nombre del usuario:";
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
            // GestionarPatenteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(611, 503);
            this.Controls.Add(this.gbAsignarPatenteUsuario);
            this.Name = "GestionarPatenteUsuario";
            this.Text = "Gestion de Patentes";
            this.Load += new System.EventHandler(this.AsignarPatenteUsuario_Load);
            this.gbAsignarPatenteUsuario.ResumeLayout(false);
            this.gbPatentesDisponibles.ResumeLayout(false);
            this.gbPatentesDisponibles.PerformLayout();
            this.gbFiltrosBusquedaBitacora.ResumeLayout(false);
            this.gbFiltrosBusquedaBitacora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAsignarPatenteUsuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbPatentesDisponibles;
        private System.Windows.Forms.Label lblPatentesDesasignar;
        private System.Windows.Forms.Label lblPatentesAsignar;
        private System.Windows.Forms.ListView listPatenteAsignar;
        private System.Windows.Forms.ListView listPatenteDesasignar;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.GroupBox gbFiltrosBusquedaBitacora;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombreDelUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}