namespace CandySur.UI.Usuario
{
    partial class ListarUsuarios
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
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.chkFiltarBloqueados = new System.Windows.Forms.CheckBox();
            this.lblListadoUsuariosActivos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvListarUsuarios = new System.Windows.Forms.DataGridView();
            this.gbListado.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.btnBuscar);
            this.gbListado.Controls.Add(this.gbFiltros);
            this.gbListado.Controls.Add(this.lblListadoUsuariosActivos);
            this.gbListado.Controls.Add(this.pictureBox1);
            this.gbListado.Controls.Add(this.btnAceptar);
            this.gbListado.Controls.Add(this.dgvListarUsuarios);
            this.gbListado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListado.Location = new System.Drawing.Point(4, 5);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(603, 517);
            this.gbListado.TabIndex = 5;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "LISTADO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBuscar.Location = new System.Drawing.Point(436, 480);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 31);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.chkFiltarBloqueados);
            this.gbFiltros.Location = new System.Drawing.Point(10, 98);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(581, 80);
            this.gbFiltros.TabIndex = 11;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "FILTROS";
            // 
            // chkFiltarBloqueados
            // 
            this.chkFiltarBloqueados.AutoSize = true;
            this.chkFiltarBloqueados.Location = new System.Drawing.Point(6, 38);
            this.chkFiltarBloqueados.Name = "chkFiltarBloqueados";
            this.chkFiltarBloqueados.Size = new System.Drawing.Size(164, 22);
            this.chkFiltarBloqueados.TabIndex = 8;
            this.chkFiltarBloqueados.Text = "Filtrar por bloqueados";
            this.chkFiltarBloqueados.UseVisualStyleBackColor = true;
            // 
            // lblListadoUsuariosActivos
            // 
            this.lblListadoUsuariosActivos.AutoSize = true;
            this.lblListadoUsuariosActivos.Location = new System.Drawing.Point(8, 181);
            this.lblListadoUsuariosActivos.Name = "lblListadoUsuariosActivos";
            this.lblListadoUsuariosActivos.Size = new System.Drawing.Size(201, 18);
            this.lblListadoUsuariosActivos.TabIndex = 6;
            this.lblListadoUsuariosActivos.Text = "LISTADO DE USUARIOS ACTIVOS";
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
            this.btnAceptar.Location = new System.Drawing.Point(517, 480);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvListarUsuarios
            // 
            this.dgvListarUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarUsuarios.Location = new System.Drawing.Point(10, 202);
            this.dgvListarUsuarios.Name = "dgvListarUsuarios";
            this.dgvListarUsuarios.Size = new System.Drawing.Size(582, 272);
            this.dgvListarUsuarios.TabIndex = 0;
            // 
            // ListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(611, 527);
            this.Controls.Add(this.gbListado);
            this.Name = "ListarUsuarios";
            this.Text = "Listar Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.ListarUsuarios_Load);
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.Label lblListadoUsuariosActivos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvListarUsuarios;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkFiltarBloqueados;
    }
}