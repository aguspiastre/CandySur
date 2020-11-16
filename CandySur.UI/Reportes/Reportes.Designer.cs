namespace CandySur.UI.Reportes
{
    partial class Reportes
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
            this.gbGenerarReportes = new System.Windows.Forms.GroupBox();
            this.gbReporte = new System.Windows.Forms.GroupBox();
            this.dgReporte = new System.Windows.Forms.DataGridView();
            this.gbFiltrosBusqueda = new System.Windows.Forms.GroupBox();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.rbdPaquetes = new System.Windows.Forms.RadioButton();
            this.rbdGolosinas = new System.Windows.Forms.RadioButton();
            this.rdbVentas = new System.Windows.Forms.RadioButton();
            this.dtpFechaHst = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDsd = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDsd = new System.Windows.Forms.Label();
            this.lblFechaHst = new System.Windows.Forms.Label();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbGenerarReportes.SuspendLayout();
            this.gbReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).BeginInit();
            this.gbFiltrosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGenerarReportes
            // 
            this.gbGenerarReportes.Controls.Add(this.gbReporte);
            this.gbGenerarReportes.Controls.Add(this.gbFiltrosBusqueda);
            this.gbGenerarReportes.Controls.Add(this.btnExportarPDF);
            this.gbGenerarReportes.Controls.Add(this.btnCancelar);
            this.gbGenerarReportes.Controls.Add(this.btnBuscar);
            this.gbGenerarReportes.Controls.Add(this.pictureBox1);
            this.gbGenerarReportes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenerarReportes.Location = new System.Drawing.Point(4, 4);
            this.gbGenerarReportes.Name = "gbGenerarReportes";
            this.gbGenerarReportes.Size = new System.Drawing.Size(602, 584);
            this.gbGenerarReportes.TabIndex = 6;
            this.gbGenerarReportes.TabStop = false;
            this.gbGenerarReportes.Text = "GENERAR REPORTES";
            // 
            // gbReporte
            // 
            this.gbReporte.Controls.Add(this.dgReporte);
            this.gbReporte.Location = new System.Drawing.Point(7, 262);
            this.gbReporte.Name = "gbReporte";
            this.gbReporte.Size = new System.Drawing.Size(585, 279);
            this.gbReporte.TabIndex = 6;
            this.gbReporte.TabStop = false;
            this.gbReporte.Text = "REPORTE";
            // 
            // dgReporte
            // 
            this.dgReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporte.Location = new System.Drawing.Point(6, 25);
            this.dgReporte.MultiSelect = false;
            this.dgReporte.Name = "dgReporte";
            this.dgReporte.ReadOnly = true;
            this.dgReporte.Size = new System.Drawing.Size(573, 248);
            this.dgReporte.TabIndex = 0;
            // 
            // gbFiltrosBusqueda
            // 
            this.gbFiltrosBusqueda.Controls.Add(this.lblTipoReporte);
            this.gbFiltrosBusqueda.Controls.Add(this.rbdPaquetes);
            this.gbFiltrosBusqueda.Controls.Add(this.rbdGolosinas);
            this.gbFiltrosBusqueda.Controls.Add(this.rdbVentas);
            this.gbFiltrosBusqueda.Controls.Add(this.dtpFechaHst);
            this.gbFiltrosBusqueda.Controls.Add(this.dtpFechaDsd);
            this.gbFiltrosBusqueda.Controls.Add(this.lblFechaDsd);
            this.gbFiltrosBusqueda.Controls.Add(this.lblFechaHst);
            this.gbFiltrosBusqueda.Location = new System.Drawing.Point(7, 98);
            this.gbFiltrosBusqueda.Name = "gbFiltrosBusqueda";
            this.gbFiltrosBusqueda.Size = new System.Drawing.Size(585, 158);
            this.gbFiltrosBusqueda.TabIndex = 37;
            this.gbFiltrosBusqueda.TabStop = false;
            this.gbFiltrosBusqueda.Text = "FILTROS DE BUSQUEDA";
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReporte.Location = new System.Drawing.Point(6, 22);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(112, 19);
            this.lblTipoReporte.TabIndex = 30;
            this.lblTipoReporte.Text = "Tipo de reporte:";
            // 
            // rbdPaquetes
            // 
            this.rbdPaquetes.AutoSize = true;
            this.rbdPaquetes.Location = new System.Drawing.Point(176, 51);
            this.rbdPaquetes.Name = "rbdPaquetes";
            this.rbdPaquetes.Size = new System.Drawing.Size(84, 22);
            this.rbdPaquetes.TabIndex = 29;
            this.rbdPaquetes.TabStop = true;
            this.rbdPaquetes.Text = "Paquetes";
            this.rbdPaquetes.UseVisualStyleBackColor = true;
            // 
            // rbdGolosinas
            // 
            this.rbdGolosinas.AutoSize = true;
            this.rbdGolosinas.Location = new System.Drawing.Point(84, 51);
            this.rbdGolosinas.Name = "rbdGolosinas";
            this.rbdGolosinas.Size = new System.Drawing.Size(86, 22);
            this.rbdGolosinas.TabIndex = 28;
            this.rbdGolosinas.TabStop = true;
            this.rbdGolosinas.Text = "Golosinas";
            this.rbdGolosinas.UseVisualStyleBackColor = true;
            // 
            // rdbVentas
            // 
            this.rdbVentas.AutoSize = true;
            this.rdbVentas.Location = new System.Drawing.Point(10, 51);
            this.rdbVentas.Name = "rdbVentas";
            this.rdbVentas.Size = new System.Drawing.Size(68, 22);
            this.rdbVentas.TabIndex = 27;
            this.rdbVentas.TabStop = true;
            this.rdbVentas.Text = "Ventas";
            this.rdbVentas.UseVisualStyleBackColor = true;
            // 
            // dtpFechaHst
            // 
            this.dtpFechaHst.Location = new System.Drawing.Point(303, 108);
            this.dtpFechaHst.Name = "dtpFechaHst";
            this.dtpFechaHst.Size = new System.Drawing.Size(276, 26);
            this.dtpFechaHst.TabIndex = 26;
            // 
            // dtpFechaDsd
            // 
            this.dtpFechaDsd.Location = new System.Drawing.Point(10, 108);
            this.dtpFechaDsd.Name = "dtpFechaDsd";
            this.dtpFechaDsd.Size = new System.Drawing.Size(272, 26);
            this.dtpFechaDsd.TabIndex = 25;
            // 
            // lblFechaDsd
            // 
            this.lblFechaDsd.AutoSize = true;
            this.lblFechaDsd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDsd.Location = new System.Drawing.Point(6, 85);
            this.lblFechaDsd.Name = "lblFechaDsd";
            this.lblFechaDsd.Size = new System.Drawing.Size(94, 19);
            this.lblFechaDsd.TabIndex = 15;
            this.lblFechaDsd.Text = "Fecha desde:";
            // 
            // lblFechaHst
            // 
            this.lblFechaHst.AutoSize = true;
            this.lblFechaHst.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHst.Location = new System.Drawing.Point(299, 85);
            this.lblFechaHst.Name = "lblFechaHst";
            this.lblFechaHst.Size = new System.Drawing.Size(91, 19);
            this.lblFechaHst.TabIndex = 24;
            this.lblFechaHst.Text = "Fecha hasta:";
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarPDF.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPDF.ForeColor = System.Drawing.Color.Blue;
            this.btnExportarPDF.Location = new System.Drawing.Point(6, 547);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(150, 31);
            this.btnExportarPDF.TabIndex = 21;
            this.btnExportarPDF.Text = "Exportar PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = false;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(517, 547);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Green;
            this.btnBuscar.Location = new System.Drawing.Point(436, 547);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 31);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
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
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(612, 593);
            this.Controls.Add(this.gbGenerarReportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.gbGenerarReportes.ResumeLayout(false);
            this.gbReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgReporte)).EndInit();
            this.gbFiltrosBusqueda.ResumeLayout(false);
            this.gbFiltrosBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGenerarReportes;
        private System.Windows.Forms.GroupBox gbReporte;
        private System.Windows.Forms.GroupBox gbFiltrosBusqueda;
        private System.Windows.Forms.Label lblFechaDsd;
        private System.Windows.Forms.Label lblFechaHst;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgReporte;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.RadioButton rbdPaquetes;
        private System.Windows.Forms.RadioButton rbdGolosinas;
        private System.Windows.Forms.RadioButton rdbVentas;
        private System.Windows.Forms.DateTimePicker dtpFechaHst;
        private System.Windows.Forms.DateTimePicker dtpFechaDsd;
    }
}