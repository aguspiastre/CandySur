namespace CandySur.UI
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuUsuarioAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuUsuarioGestionar = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuUsuarioListar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuFamilia = new System.Windows.Forms.ToolStripMenuItem();
            this.SubItemAltaFamilia = new System.Windows.Forms.ToolStripMenuItem();
            this.SubItemGestionarFamilia = new System.Windows.Forms.ToolStripMenuItem();
            this.SubItemListarFamilias = new System.Windows.Forms.ToolStripMenuItem();
            this.SubItemAsignacionFamUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuPatente = new System.Windows.Forms.ToolStripMenuItem();
            this.SubItemListarPatentes = new System.Windows.Forms.ToolStripMenuItem();
            this.SubItemAsignacionPatFamilia = new System.Windows.Forms.ToolStripMenuItem();
            this.SubItemAsignacionPatUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuBitacoraConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuBitacoraControlCambios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBackupRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuBackupRestoreBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMiPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuMiPerfilCambiarContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuMiPerfilGestionaIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuMiPerfilAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuMiPerfilCerrarSession = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuGestionPermisos,
            this.menuBitacora,
            this.menuBackupRestore,
            this.menuMiPerfil});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuUsuarioAlta,
            this.SubMenuUsuarioGestionar,
            this.SubMenuUsuarioListar});
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(64, 20);
            this.menuUsuarios.Text = "Usuarios";
            // 
            // SubMenuUsuarioAlta
            // 
            this.SubMenuUsuarioAlta.Name = "SubMenuUsuarioAlta";
            this.SubMenuUsuarioAlta.Size = new System.Drawing.Size(152, 22);
            this.SubMenuUsuarioAlta.Text = "Alta";
            this.SubMenuUsuarioAlta.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // SubMenuUsuarioGestionar
            // 
            this.SubMenuUsuarioGestionar.Name = "SubMenuUsuarioGestionar";
            this.SubMenuUsuarioGestionar.Size = new System.Drawing.Size(152, 22);
            this.SubMenuUsuarioGestionar.Text = "Gestionar";
            this.SubMenuUsuarioGestionar.Click += new System.EventHandler(this.gestionarToolStripMenuItem_Click);
            // 
            // SubMenuUsuarioListar
            // 
            this.SubMenuUsuarioListar.Name = "SubMenuUsuarioListar";
            this.SubMenuUsuarioListar.Size = new System.Drawing.Size(152, 22);
            this.SubMenuUsuarioListar.Text = "Listar";
            this.SubMenuUsuarioListar.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // menuGestionPermisos
            // 
            this.menuGestionPermisos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuFamilia,
            this.SubMenuPatente});
            this.menuGestionPermisos.Name = "menuGestionPermisos";
            this.menuGestionPermisos.Size = new System.Drawing.Size(126, 20);
            this.menuGestionPermisos.Text = "Gestion de Permisos";
            // 
            // SubMenuFamilia
            // 
            this.SubMenuFamilia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubItemAltaFamilia,
            this.SubItemGestionarFamilia,
            this.SubItemListarFamilias,
            this.SubItemAsignacionFamUsuario});
            this.SubMenuFamilia.Name = "SubMenuFamilia";
            this.SubMenuFamilia.Size = new System.Drawing.Size(152, 22);
            this.SubMenuFamilia.Text = "Familia";
            // 
            // SubItemAltaFamilia
            // 
            this.SubItemAltaFamilia.Name = "SubItemAltaFamilia";
            this.SubItemAltaFamilia.Size = new System.Drawing.Size(185, 22);
            this.SubItemAltaFamilia.Text = "Alta";
            this.SubItemAltaFamilia.Click += new System.EventHandler(this.altaToolStripMenuItem1_Click);
            // 
            // SubItemGestionarFamilia
            // 
            this.SubItemGestionarFamilia.Name = "SubItemGestionarFamilia";
            this.SubItemGestionarFamilia.Size = new System.Drawing.Size(185, 22);
            this.SubItemGestionarFamilia.Text = "Gestionar";
            this.SubItemGestionarFamilia.Click += new System.EventHandler(this.gestionarToolStripMenuItem1_Click);
            // 
            // SubItemListarFamilias
            // 
            this.SubItemListarFamilias.Name = "SubItemListarFamilias";
            this.SubItemListarFamilias.Size = new System.Drawing.Size(185, 22);
            this.SubItemListarFamilias.Text = "Listar";
            this.SubItemListarFamilias.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // SubItemAsignacionFamUsuario
            // 
            this.SubItemAsignacionFamUsuario.Name = "SubItemAsignacionFamUsuario";
            this.SubItemAsignacionFamUsuario.Size = new System.Drawing.Size(185, 22);
            this.SubItemAsignacionFamUsuario.Text = "Asignacion a Usuario";
            this.SubItemAsignacionFamUsuario.Click += new System.EventHandler(this.asignacionAUsuarioToolStripMenuItem_Click);
            // 
            // SubMenuPatente
            // 
            this.SubMenuPatente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubItemListarPatentes,
            this.SubItemAsignacionPatFamilia,
            this.SubItemAsignacionPatUsuario});
            this.SubMenuPatente.Name = "SubMenuPatente";
            this.SubMenuPatente.Size = new System.Drawing.Size(152, 22);
            this.SubMenuPatente.Text = "Patente";
            // 
            // SubItemListarPatentes
            // 
            this.SubItemListarPatentes.Name = "SubItemListarPatentes";
            this.SubItemListarPatentes.Size = new System.Drawing.Size(185, 22);
            this.SubItemListarPatentes.Text = "Listar";
            this.SubItemListarPatentes.Click += new System.EventHandler(this.listarToolStripMenuItem2_Click);
            // 
            // SubItemAsignacionPatFamilia
            // 
            this.SubItemAsignacionPatFamilia.Name = "SubItemAsignacionPatFamilia";
            this.SubItemAsignacionPatFamilia.Size = new System.Drawing.Size(185, 22);
            this.SubItemAsignacionPatFamilia.Text = "Asignacion a Familia";
            this.SubItemAsignacionPatFamilia.Click += new System.EventHandler(this.asignacionAFamiliaToolStripMenuItem_Click);
            // 
            // SubItemAsignacionPatUsuario
            // 
            this.SubItemAsignacionPatUsuario.Name = "SubItemAsignacionPatUsuario";
            this.SubItemAsignacionPatUsuario.Size = new System.Drawing.Size(185, 22);
            this.SubItemAsignacionPatUsuario.Text = "Asignacion a Usuario";
            this.SubItemAsignacionPatUsuario.Click += new System.EventHandler(this.asignacionAUsuarioToolStripMenuItem1_Click);
            // 
            // menuBitacora
            // 
            this.menuBitacora.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuBitacoraConsultar,
            this.SubMenuBitacoraControlCambios});
            this.menuBitacora.Name = "menuBitacora";
            this.menuBitacora.Size = new System.Drawing.Size(62, 20);
            this.menuBitacora.Text = "Bitacora";
            // 
            // SubMenuBitacoraConsultar
            // 
            this.SubMenuBitacoraConsultar.Name = "SubMenuBitacoraConsultar";
            this.SubMenuBitacoraConsultar.Size = new System.Drawing.Size(180, 22);
            this.SubMenuBitacoraConsultar.Text = "Consultar";
            this.SubMenuBitacoraConsultar.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // SubMenuBitacoraControlCambios
            // 
            this.SubMenuBitacoraControlCambios.Name = "SubMenuBitacoraControlCambios";
            this.SubMenuBitacoraControlCambios.Size = new System.Drawing.Size(180, 22);
            this.SubMenuBitacoraControlCambios.Text = "Control de Cambios";
            this.SubMenuBitacoraControlCambios.Click += new System.EventHandler(this.controlDeCambiosToolStripMenuItem_Click);
            // 
            // menuBackupRestore
            // 
            this.menuBackupRestore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuBackupRestoreBackup});
            this.menuBackupRestore.Name = "menuBackupRestore";
            this.menuBackupRestore.Size = new System.Drawing.Size(102, 20);
            this.menuBackupRestore.Text = "Backup/Restore";
            // 
            // SubMenuBackupRestoreBackup
            // 
            this.SubMenuBackupRestoreBackup.Name = "SubMenuBackupRestoreBackup";
            this.SubMenuBackupRestoreBackup.Size = new System.Drawing.Size(152, 22);
            this.SubMenuBackupRestoreBackup.Text = "Backup";
            this.SubMenuBackupRestoreBackup.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // menuMiPerfil
            // 
            this.menuMiPerfil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuMiPerfilCambiarContraseña,
            this.SubMenuMiPerfilGestionaIdioma,
            this.SubMenuMiPerfilAyuda,
            this.SubMenuMiPerfilCerrarSession});
            this.menuMiPerfil.Name = "menuMiPerfil";
            this.menuMiPerfil.Size = new System.Drawing.Size(63, 20);
            this.menuMiPerfil.Text = "Mi Perfil";
            // 
            // SubMenuMiPerfilCambiarContraseña
            // 
            this.SubMenuMiPerfilCambiarContraseña.Name = "SubMenuMiPerfilCambiarContraseña";
            this.SubMenuMiPerfilCambiarContraseña.Size = new System.Drawing.Size(182, 22);
            this.SubMenuMiPerfilCambiarContraseña.Text = "Cambiar Contraseña";
            this.SubMenuMiPerfilCambiarContraseña.Click += new System.EventHandler(this.gestionarToolStripMenuItem2_Click);
            // 
            // SubMenuMiPerfilGestionaIdioma
            // 
            this.SubMenuMiPerfilGestionaIdioma.Name = "SubMenuMiPerfilGestionaIdioma";
            this.SubMenuMiPerfilGestionaIdioma.Size = new System.Drawing.Size(182, 22);
            this.SubMenuMiPerfilGestionaIdioma.Text = "Gestion de Idioma";
            // 
            // SubMenuMiPerfilAyuda
            // 
            this.SubMenuMiPerfilAyuda.Name = "SubMenuMiPerfilAyuda";
            this.SubMenuMiPerfilAyuda.Size = new System.Drawing.Size(182, 22);
            this.SubMenuMiPerfilAyuda.Text = "Ayuda";
            // 
            // SubMenuMiPerfilCerrarSession
            // 
            this.SubMenuMiPerfilCerrarSession.Name = "SubMenuMiPerfilCerrarSession";
            this.SubMenuMiPerfilCerrarSession.Size = new System.Drawing.Size(182, 22);
            this.SubMenuMiPerfilCerrarSession.Text = "Cerrar Sesion";
            this.SubMenuMiPerfilCerrarSession.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 350);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Candy Sur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem SubMenuUsuarioAlta;
        private System.Windows.Forms.ToolStripMenuItem SubMenuUsuarioGestionar;
        private System.Windows.Forms.ToolStripMenuItem SubMenuUsuarioListar;
        private System.Windows.Forms.ToolStripMenuItem menuGestionPermisos;
        private System.Windows.Forms.ToolStripMenuItem SubMenuFamilia;
        private System.Windows.Forms.ToolStripMenuItem SubItemAltaFamilia;
        private System.Windows.Forms.ToolStripMenuItem SubItemGestionarFamilia;
        private System.Windows.Forms.ToolStripMenuItem SubItemListarFamilias;
        private System.Windows.Forms.ToolStripMenuItem SubItemAsignacionFamUsuario;
        private System.Windows.Forms.ToolStripMenuItem SubMenuPatente;
        private System.Windows.Forms.ToolStripMenuItem SubItemListarPatentes;
        private System.Windows.Forms.ToolStripMenuItem SubItemAsignacionPatFamilia;
        private System.Windows.Forms.ToolStripMenuItem menuBitacora;
        private System.Windows.Forms.ToolStripMenuItem SubMenuBitacoraConsultar;
        private System.Windows.Forms.ToolStripMenuItem menuMiPerfil;
        private System.Windows.Forms.ToolStripMenuItem SubMenuMiPerfilCambiarContraseña;
        private System.Windows.Forms.ToolStripMenuItem SubMenuMiPerfilGestionaIdioma;
        private System.Windows.Forms.ToolStripMenuItem SubMenuMiPerfilAyuda;
        private System.Windows.Forms.ToolStripMenuItem SubMenuMiPerfilCerrarSession;
        private System.Windows.Forms.ToolStripMenuItem menuBackupRestore;
        private System.Windows.Forms.ToolStripMenuItem SubMenuBackupRestoreBackup;
        private System.Windows.Forms.ToolStripMenuItem SubItemAsignacionPatUsuario;
        private System.Windows.Forms.ToolStripMenuItem SubMenuBitacoraControlCambios;
    }
}