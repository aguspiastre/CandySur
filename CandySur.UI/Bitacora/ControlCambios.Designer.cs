namespace CandySur.UI.Bitacora
{
    partial class ControlCambios
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbFiltrosBusquedaBitacora = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.gbCambios = new System.Windows.Forms.GroupBox();
            this.dataGridCambios = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbControlCambios = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbFiltrosBusquedaBitacora.SuspendLayout();
            this.gbCambios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCambios)).BeginInit();
            this.gbControlCambios.SuspendLayout();
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Green;
            this.btnBuscar.Location = new System.Drawing.Point(348, 514);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 31);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbFiltrosBusquedaBitacora
            // 
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.lblUsuario);
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.cmbUsuario);
            this.gbFiltrosBusquedaBitacora.Location = new System.Drawing.Point(7, 98);
            this.gbFiltrosBusquedaBitacora.Name = "gbFiltrosBusquedaBitacora";
            this.gbFiltrosBusquedaBitacora.Size = new System.Drawing.Size(585, 89);
            this.gbFiltrosBusquedaBitacora.TabIndex = 37;
            this.gbFiltrosBusquedaBitacora.TabStop = false;
            this.gbFiltrosBusquedaBitacora.Text = "FILTROS DE BUSQUEDA";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(6, 23);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 19);
            this.lblUsuario.TabIndex = 32;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(10, 45);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(276, 26);
            this.cmbUsuario.TabIndex = 31;
            // 
            // gbCambios
            // 
            this.gbCambios.Controls.Add(this.dataGridCambios);
            this.gbCambios.Location = new System.Drawing.Point(7, 193);
            this.gbCambios.Name = "gbCambios";
            this.gbCambios.Size = new System.Drawing.Size(585, 315);
            this.gbCambios.TabIndex = 6;
            this.gbCambios.TabStop = false;
            this.gbCambios.Text = "CAMBIOS";
            // 
            // dataGridCambios
            // 
            this.dataGridCambios.AllowUserToAddRows = false;
            this.dataGridCambios.AllowUserToDeleteRows = false;
            this.dataGridCambios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCambios.Location = new System.Drawing.Point(10, 25);
            this.dataGridCambios.MultiSelect = false;
            this.dataGridCambios.Name = "dataGridCambios";
            this.dataGridCambios.ReadOnly = true;
            this.dataGridCambios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCambios.Size = new System.Drawing.Size(573, 280);
            this.dataGridCambios.TabIndex = 0;
            this.dataGridCambios.SelectionChanged += new System.EventHandler(this.dataGridCambios_SelectionChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Blue;
            this.btnActualizar.Location = new System.Drawing.Point(432, 514);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 31);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseMnemonic = false;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gbControlCambios
            // 
            this.gbControlCambios.Controls.Add(this.btnCancelar);
            this.gbControlCambios.Controls.Add(this.btnActualizar);
            this.gbControlCambios.Controls.Add(this.gbCambios);
            this.gbControlCambios.Controls.Add(this.gbFiltrosBusquedaBitacora);
            this.gbControlCambios.Controls.Add(this.btnBuscar);
            this.gbControlCambios.Controls.Add(this.pictureBox1);
            this.gbControlCambios.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControlCambios.Location = new System.Drawing.Point(8, 8);
            this.gbControlCambios.Name = "gbControlCambios";
            this.gbControlCambios.Size = new System.Drawing.Size(602, 554);
            this.gbControlCambios.TabIndex = 8;
            this.gbControlCambios.TabStop = false;
            this.gbControlCambios.Text = "CONTROL DE CAMBIOS";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(517, 514);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ControlCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 565);
            this.Controls.Add(this.gbControlCambios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlCambios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Cambios";
            this.Load += new System.EventHandler(this.ControlCambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbFiltrosBusquedaBitacora.ResumeLayout(false);
            this.gbFiltrosBusquedaBitacora.PerformLayout();
            this.gbCambios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCambios)).EndInit();
            this.gbControlCambios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbFiltrosBusquedaBitacora;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.GroupBox gbCambios;
        private System.Windows.Forms.DataGridView dataGridCambios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox gbControlCambios;
        private System.Windows.Forms.Button btnCancelar;
    }
}