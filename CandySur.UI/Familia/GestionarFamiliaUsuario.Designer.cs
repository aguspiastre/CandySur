namespace CandySur.UI.Familia
{
    partial class GestionarFamiliaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarFamiliaUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbFiltrosBusquedaBitacora = new System.Windows.Forms.GroupBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.lblNombreDelUsuario = new System.Windows.Forms.Label();
            this.gbFamiliasDisponibles = new System.Windows.Forms.GroupBox();
            this.lblFamiliasDesasingar = new System.Windows.Forms.Label();
            this.lblFamiliasAsignar = new System.Windows.Forms.Label();
            this.listFamiliasAsignar = new System.Windows.Forms.ListView();
            this.listFamiliaDesasignar = new System.Windows.Forms.ListView();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbAsignarFamiliaUsuario = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbFiltrosBusquedaBitacora.SuspendLayout();
            this.gbFamiliasDisponibles.SuspendLayout();
            this.gbAsignarFamiliaUsuario.SuspendLayout();
            this.SuspendLayout();
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
            // gbFiltrosBusquedaBitacora
            // 
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.txtNombreUsuario);
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.btnBuscarUsuario);
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
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUsuario.Image")));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(227, 41);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(43, 29);
            this.btnBuscarUsuario.TabIndex = 34;
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // gbFamiliasDisponibles
            // 
            this.gbFamiliasDisponibles.Controls.Add(this.lblFamiliasDesasingar);
            this.gbFamiliasDisponibles.Controls.Add(this.lblFamiliasAsignar);
            this.gbFamiliasDisponibles.Controls.Add(this.listFamiliasAsignar);
            this.gbFamiliasDisponibles.Controls.Add(this.listFamiliaDesasignar);
            this.gbFamiliasDisponibles.Controls.Add(this.btnDesasignar);
            this.gbFamiliasDisponibles.Controls.Add(this.btnAsignar);
            this.gbFamiliasDisponibles.Location = new System.Drawing.Point(10, 193);
            this.gbFamiliasDisponibles.Name = "gbFamiliasDisponibles";
            this.gbFamiliasDisponibles.Size = new System.Drawing.Size(582, 255);
            this.gbFamiliasDisponibles.TabIndex = 22;
            this.gbFamiliasDisponibles.TabStop = false;
            this.gbFamiliasDisponibles.Text = "FAMILIAS DISPONIBLES";
            // 
            // lblFamiliasDesasingar
            // 
            this.lblFamiliasDesasingar.AutoSize = true;
            this.lblFamiliasDesasingar.Location = new System.Drawing.Point(394, 24);
            this.lblFamiliasDesasingar.Name = "lblFamiliasDesasingar";
            this.lblFamiliasDesasingar.Size = new System.Drawing.Size(139, 18);
            this.lblFamiliasDesasingar.TabIndex = 24;
            this.lblFamiliasDesasingar.Text = "Familias a Desasignar";
            // 
            // lblFamiliasAsignar
            // 
            this.lblFamiliasAsignar.AutoSize = true;
            this.lblFamiliasAsignar.Location = new System.Drawing.Point(53, 24);
            this.lblFamiliasAsignar.Name = "lblFamiliasAsignar";
            this.lblFamiliasAsignar.Size = new System.Drawing.Size(118, 18);
            this.lblFamiliasAsignar.TabIndex = 23;
            this.lblFamiliasAsignar.Text = "Familias a Asignar";
            // 
            // listFamiliasAsignar
            // 
            this.listFamiliasAsignar.Location = new System.Drawing.Point(6, 45);
            this.listFamiliasAsignar.MultiSelect = false;
            this.listFamiliasAsignar.Name = "listFamiliasAsignar";
            this.listFamiliasAsignar.Size = new System.Drawing.Size(222, 191);
            this.listFamiliasAsignar.TabIndex = 22;
            this.listFamiliasAsignar.UseCompatibleStateImageBehavior = false;
            this.listFamiliasAsignar.View = System.Windows.Forms.View.List;
            // 
            // listFamiliaDesasignar
            // 
            this.listFamiliaDesasignar.Location = new System.Drawing.Point(351, 45);
            this.listFamiliaDesasignar.Name = "listFamiliaDesasignar";
            this.listFamiliaDesasignar.Size = new System.Drawing.Size(222, 191);
            this.listFamiliaDesasignar.TabIndex = 21;
            this.listFamiliaDesasignar.UseCompatibleStateImageBehavior = false;
            this.listFamiliaDesasignar.View = System.Windows.Forms.View.List;
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
            // gbAsignarFamiliaUsuario
            // 
            this.gbAsignarFamiliaUsuario.Controls.Add(this.btnAceptar);
            this.gbAsignarFamiliaUsuario.Controls.Add(this.gbFamiliasDisponibles);
            this.gbAsignarFamiliaUsuario.Controls.Add(this.gbFiltrosBusquedaBitacora);
            this.gbAsignarFamiliaUsuario.Controls.Add(this.pictureBox1);
            this.gbAsignarFamiliaUsuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAsignarFamiliaUsuario.Location = new System.Drawing.Point(6, 6);
            this.gbAsignarFamiliaUsuario.Name = "gbAsignarFamiliaUsuario";
            this.gbAsignarFamiliaUsuario.Size = new System.Drawing.Size(602, 493);
            this.gbAsignarFamiliaUsuario.TabIndex = 5;
            this.gbAsignarFamiliaUsuario.TabStop = false;
            this.gbAsignarFamiliaUsuario.Text = "ASIGNAR FAMILIA A USUARIO";
            // 
            // GestionarFamiliaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(615, 506);
            this.Controls.Add(this.gbAsignarFamiliaUsuario);
            this.Name = "GestionarFamiliaUsuario";
            this.Text = "Gestion de Familias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionarFamiliaUsuario_FormClosing);
            this.Load += new System.EventHandler(this.AsignarFamiliaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbFiltrosBusquedaBitacora.ResumeLayout(false);
            this.gbFiltrosBusquedaBitacora.PerformLayout();
            this.gbFamiliasDisponibles.ResumeLayout(false);
            this.gbFamiliasDisponibles.PerformLayout();
            this.gbAsignarFamiliaUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbFiltrosBusquedaBitacora;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Label lblNombreDelUsuario;
        private System.Windows.Forms.GroupBox gbFamiliasDisponibles;
        private System.Windows.Forms.Label lblFamiliasDesasingar;
        private System.Windows.Forms.Label lblFamiliasAsignar;
        private System.Windows.Forms.ListView listFamiliasAsignar;
        private System.Windows.Forms.ListView listFamiliaDesasignar;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbAsignarFamiliaUsuario;
    }
}