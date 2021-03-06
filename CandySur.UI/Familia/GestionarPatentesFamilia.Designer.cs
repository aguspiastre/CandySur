﻿namespace CandySur.UI.Familia
{
    partial class GestionarPatentesFamilia
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
            this.gbAsignarPatenteFamilia = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbPatentesDisponibles = new System.Windows.Forms.GroupBox();
            this.lblPatentesDesasignar = new System.Windows.Forms.Label();
            this.lblPatentesAsignar = new System.Windows.Forms.Label();
            this.listPatentesAsignar = new System.Windows.Forms.ListView();
            this.listPatentesDesasignar = new System.Windows.Forms.ListView();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.gbFiltrosBusquedaBitacora = new System.Windows.Forms.GroupBox();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbAsignarPatenteFamilia.SuspendLayout();
            this.gbPatentesDisponibles.SuspendLayout();
            this.gbFiltrosBusquedaBitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAsignarPatenteFamilia
            // 
            this.gbAsignarPatenteFamilia.Controls.Add(this.btnAceptar);
            this.gbAsignarPatenteFamilia.Controls.Add(this.gbPatentesDisponibles);
            this.gbAsignarPatenteFamilia.Controls.Add(this.gbFiltrosBusquedaBitacora);
            this.gbAsignarPatenteFamilia.Controls.Add(this.pictureBox1);
            this.gbAsignarPatenteFamilia.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAsignarPatenteFamilia.Location = new System.Drawing.Point(4, 7);
            this.gbAsignarPatenteFamilia.Name = "gbAsignarPatenteFamilia";
            this.gbAsignarPatenteFamilia.Size = new System.Drawing.Size(602, 493);
            this.gbAsignarPatenteFamilia.TabIndex = 6;
            this.gbAsignarPatenteFamilia.TabStop = false;
            this.gbAsignarPatenteFamilia.Text = "ASIGNAR PATENTES A FAMILIA";
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
            this.gbPatentesDisponibles.Controls.Add(this.listPatentesAsignar);
            this.gbPatentesDisponibles.Controls.Add(this.listPatentesDesasignar);
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
            this.lblPatentesDesasignar.Location = new System.Drawing.Point(391, 24);
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
            this.lblPatentesAsignar.Size = new System.Drawing.Size(122, 18);
            this.lblPatentesAsignar.TabIndex = 23;
            this.lblPatentesAsignar.Text = "Patentes a Asignar";
            // 
            // listPatentesAsignar
            // 
            this.listPatentesAsignar.Location = new System.Drawing.Point(6, 45);
            this.listPatentesAsignar.Name = "listPatentesAsignar";
            this.listPatentesAsignar.Size = new System.Drawing.Size(222, 191);
            this.listPatentesAsignar.TabIndex = 22;
            this.listPatentesAsignar.UseCompatibleStateImageBehavior = false;
            this.listPatentesAsignar.View = System.Windows.Forms.View.List;
            // 
            // listPatentesDesasignar
            // 
            this.listPatentesDesasignar.Location = new System.Drawing.Point(351, 45);
            this.listPatentesDesasignar.Name = "listPatentesDesasignar";
            this.listPatentesDesasignar.Size = new System.Drawing.Size(222, 191);
            this.listPatentesDesasignar.TabIndex = 21;
            this.listPatentesDesasignar.UseCompatibleStateImageBehavior = false;
            this.listPatentesDesasignar.View = System.Windows.Forms.View.List;
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
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.cmbFamilia);
            this.gbFiltrosBusquedaBitacora.Controls.Add(this.lblFamilia);
            this.gbFiltrosBusquedaBitacora.Location = new System.Drawing.Point(10, 99);
            this.gbFiltrosBusquedaBitacora.Name = "gbFiltrosBusquedaBitacora";
            this.gbFiltrosBusquedaBitacora.Size = new System.Drawing.Size(582, 88);
            this.gbFiltrosBusquedaBitacora.TabIndex = 19;
            this.gbFiltrosBusquedaBitacora.TabStop = false;
            this.gbFiltrosBusquedaBitacora.Text = "FILTROS DE BUSQUEDA";
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(10, 44);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(218, 26);
            this.cmbFamilia.TabIndex = 19;
            this.cmbFamilia.SelectedIndexChanged += new System.EventHandler(this.cmbFamilia_SelectedIndexChanged);
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilia.Location = new System.Drawing.Point(6, 22);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(60, 19);
            this.lblFamilia.TabIndex = 18;
            this.lblFamilia.Text = "Familia:";
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
            // GestionarPatentesFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(613, 504);
            this.Controls.Add(this.gbAsignarPatenteFamilia);
            this.Name = "GestionarPatentesFamilia";
            this.Text = "Gestion de Patentes/Familia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionarPatentesFamilia_FormClosing);
            this.Load += new System.EventHandler(this.AsignarPatentesFamilia_Load);
            this.gbAsignarPatenteFamilia.ResumeLayout(false);
            this.gbPatentesDisponibles.ResumeLayout(false);
            this.gbPatentesDisponibles.PerformLayout();
            this.gbFiltrosBusquedaBitacora.ResumeLayout(false);
            this.gbFiltrosBusquedaBitacora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAsignarPatenteFamilia;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbPatentesDisponibles;
        private System.Windows.Forms.Label lblPatentesDesasignar;
        private System.Windows.Forms.Label lblPatentesAsignar;
        private System.Windows.Forms.ListView listPatentesAsignar;
        private System.Windows.Forms.ListView listPatentesDesasignar;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.GroupBox gbFiltrosBusquedaBitacora;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbFamilia;
    }
}