namespace CandySur.UI.Bitacora
{
    partial class ConsultarBitacora
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
            this.gbMovimientosBitacora = new System.Windows.Forms.GroupBox();
            this.gbBitacora = new System.Windows.Forms.GroupBox();
            this.dataGridBitacora = new System.Windows.Forms.DataGridView();
            this.gbFiltrosBusquedaBitacora = new System.Windows.Forms.GroupBox();
            this.lblCriticidad = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbCriticidad = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.dateTimeFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDsd = new System.Windows.Forms.Label();
            this.lblFechaHst = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbMovimientosBitacora.SuspendLayout();
            this.gbBitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBitacora)).BeginInit();
            this.gbFiltrosBusquedaBitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMovimientosBitacora
            // 
            this.gbMovimientosBitacora.Controls.Add(this.gbBitacora);
            this.gbMovimientosBitacora.Controls.Add(this.gbFiltrosBusquedaBitacora);
            this.gbMovimientosBitacora.Controls.Add(this.btnBuscar);
            this.gbMovimientosBitacora.Controls.Add(this.pictureBox1);
            this.gbMovimientosBitacora.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovimientosBitacora.Location = new System.Drawing.Point(3, 4);
            this.gbMovimientosBitacora.Name = "gbMovimientosBitacora";
            this.gbMovimientosBitacora.Size = new System.Drawing.Size(602, 578);
            this.gbMovimientosBitacora.TabIndex = 7;
            this.gbMovimientosBitacora.TabStop = false;
            this.gbMovimientosBitacora.Text = "MOVIMIENTOS EN LA BITACORA";
            // 
            // gbBitacora
            // 
            this.gbBitacora.Controls.Add(this.dataGridBitacora);
            this.gbBitacora.Location = new System.Drawing.Point(7, 253);
            this.gbBitacora.Name = "gbBitacora";
            this.gbBitacora.Size = new System.Drawing.Size(585, 279);
            this.gbBitacora.TabIndex = 6;
            this.gbBitacora.TabStop = false;
            this.gbBitacora.Text = "BITACORA";
            // 
            // dataGridBitacora
            // 
            this.dataGridBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBitacora.Location = new System.Drawing.Point(10, 25);
            this.dataGridBitacora.MultiSelect = false;
            this.dataGridBitacora.Name = "dataGridBitacora";
            this.dataGridBitacora.ReadOnly = true;
            this.dataGridBitacora.Size = new System.Drawing.Size(573, 248);
            this.dataGridBitacora.TabIndex = 0;
            // 
            // gbFiltrosBusquedaBitacora
            // 
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.lblCriticidad);
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.lblUsuario);
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.cmbCriticidad);
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.cmbUsuario);
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.dateTimeFechaHasta);
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.dateTimeFechaDesde);
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.lblFechaDsd);
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.lblFechaHst);
            this.gbFiltrosBusquedaBitacora.Location = new System.Drawing.Point(7, 98);
            this.gbFiltrosBusquedaBitacora.Name = "gbFiltrosBusquedaBitacora";
            this.gbFiltrosBusquedaBitacora.Size = new System.Drawing.Size(585, 149);
            this.gbFiltrosBusquedaBitacora.TabIndex = 37;
            this.gbFiltrosBusquedaBitacora.TabStop = false;
            this.gbFiltrosBusquedaBitacora.Text = "FILTROS DE BUSQUEDA";
            // 
            // lblCriticidad
            // 
            this.lblCriticidad.AutoSize = true;
            this.lblCriticidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriticidad.Location = new System.Drawing.Point(299, 23);
            this.lblCriticidad.Name = "lblCriticidad";
            this.lblCriticidad.Size = new System.Drawing.Size(75, 19);
            this.lblCriticidad.TabIndex = 34;
            this.lblCriticidad.Text = "Criticidad:";
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
            // cmbCriticidad
            // 
            this.cmbCriticidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriticidad.FormattingEnabled = true;
            this.cmbCriticidad.Location = new System.Drawing.Point(303, 45);
            this.cmbCriticidad.Name = "cmbCriticidad";
            this.cmbCriticidad.Size = new System.Drawing.Size(276, 26);
            this.cmbCriticidad.TabIndex = 33;
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
            // dateTimeFechaHasta
            // 
            this.dateTimeFechaHasta.Location = new System.Drawing.Point(303, 97);
            this.dateTimeFechaHasta.Name = "dateTimeFechaHasta";
            this.dateTimeFechaHasta.Size = new System.Drawing.Size(276, 26);
            this.dateTimeFechaHasta.TabIndex = 26;
            // 
            // dateTimeFechaDesde
            // 
            this.dateTimeFechaDesde.Location = new System.Drawing.Point(10, 97);
            this.dateTimeFechaDesde.Name = "dateTimeFechaDesde";
            this.dateTimeFechaDesde.Size = new System.Drawing.Size(272, 26);
            this.dateTimeFechaDesde.TabIndex = 25;
            // 
            // lblFechaDsd
            // 
            this.lblFechaDsd.AutoSize = true;
            this.lblFechaDsd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDsd.Location = new System.Drawing.Point(6, 74);
            this.lblFechaDsd.Name = "lblFechaDsd";
            this.lblFechaDsd.Size = new System.Drawing.Size(94, 19);
            this.lblFechaDsd.TabIndex = 15;
            this.lblFechaDsd.Text = "Fecha desde:";
            // 
            // lblFechaHst
            // 
            this.lblFechaHst.AutoSize = true;
            this.lblFechaHst.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHst.Location = new System.Drawing.Point(299, 74);
            this.lblFechaHst.Name = "lblFechaHst";
            this.lblFechaHst.Size = new System.Drawing.Size(91, 19);
            this.lblFechaHst.TabIndex = 24;
            this.lblFechaHst.Text = "Fecha hasta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Green;
            this.btnBuscar.Location = new System.Drawing.Point(517, 538);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 31);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // ConsultarBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(613, 586);
            this.Controls.Add(this.gbMovimientosBitacora);
            this.Name = "ConsultarBitacora";
            this.Text = "Consultar Bitacora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarBitacora_FormClosing);
            this.Load += new System.EventHandler(this.Consultar_Load);
            this.gbMovimientosBitacora.ResumeLayout(false);
            this.gbBitacora.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBitacora)).EndInit();
            this.gbFiltrosBusquedaBitacora.ResumeLayout(false);
            this.gbFiltrosBusquedaBitacora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMovimientosBitacora;
        private System.Windows.Forms.GroupBox gbBitacora;
        private System.Windows.Forms.DataGridView dataGridBitacora;
        private System.Windows.Forms.GroupBox gbFiltrosBusquedaBitacora;
        private System.Windows.Forms.Label lblCriticidad;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbCriticidad;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.DateTimePicker dateTimeFechaHasta;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDesde;
        private System.Windows.Forms.Label lblFechaDsd;
        private System.Windows.Forms.Label lblFechaHst;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}