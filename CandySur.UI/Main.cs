using CandySur.SEG.Service;
using CandySur.SEG.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CandySur.SEG.Entity;

namespace CandySur.UI
{
    public partial class Main : Form, IIdiomaObserver
    {
        private SEG.Service.SessionManager Session;
        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Session = SEG.Service.SessionManager.GetInstance();

            this.Traducir();
            SEG.Service.IdiomaManager.Suscribir(this);

            this.KeyDown += Form11_KeyDown;
            this.KeyPreview = true;

            helpProvider.HelpNamespace = System.IO.Path.Combine(Application.StartupPath, "CandySur - Ayuda en linea.chm");
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consultarBitacora = new Bitacora.ConsultarBitacora();
            consultarBitacora.MdiParent = this;
            consultarBitacora.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var backupRestore = new Backup_Restore.BackupRestore();
            backupRestore.MdiParent = this;
            backupRestore.Show();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var altaUsuario = new Usuario.AltaUsuario();
            altaUsuario.MdiParent = this;
            altaUsuario.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea cerrar sesión?";
            string tittle = "Cerrar Sesion";

            var idiomaManager = SEG.Service.IdiomaManager.GetInstance();

            if (idiomaManager.Idioma != null && !idiomaManager.Idioma.Principal)
            {
                msg = "¿Are you sure that you want to sign off?";
                tittle = "Sign Off";
            }

            DialogResult result = MessageBox.Show(msg, tittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                {
                    IdUsuario = Session.Usuario.Id,
                    IdCriticidad = (int)Enums.Criticidad.Baja,
                    Fecha = DateTime.Now,
                    Descripcion = "Cierre de sesión"
                };

                bitacoraService.Registrar(reg);

                SEG.Service.SessionManager.LogOut();

                this.Close();
            }
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionarUsuario = new Usuario.GestionarUsuario();
            gestionarUsuario.MdiParent = this;
            gestionarUsuario.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listarUsuarios = new Usuario.ListarUsuarios();
            listarUsuarios.MdiParent = this;
            listarUsuarios.Show();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var listarPatentes = new Patente.ListarPatentes();
            listarPatentes.MdiParent = this;
            listarPatentes.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var altaFamilia = new Familia.AltaFamilia();
            altaFamilia.MdiParent = this;
            altaFamilia.Show();
        }

        private void gestionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var gestionarFamilia = new Familia.GestionarFamilia();
            gestionarFamilia.MdiParent = this;
            gestionarFamilia.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listarFamilia = new Familia.ListarFamilias();
            listarFamilia.MdiParent = this;
            listarFamilia.Show();
        }

        private void asignacionAUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var asignarFamilia = new Familia.GestionarFamiliaUsuario();
            asignarFamilia.MdiParent = this;
            asignarFamilia.Show();
        }

        private void asignacionAUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var asignarPatenteUsuario = new Patente.GestionarPatenteUsuario();
            asignarPatenteUsuario.MdiParent = this;
            asignarPatenteUsuario.Show();
        }

        private void gestionarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var gestionarContraseña = new Perfil.GestionarContraseña();
            gestionarContraseña.MdiParent = this;
            gestionarContraseña.Show();
        }

        private void asignacionAFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var asignarPatenteFamilia = new Familia.GestionarPatentesFamilia();
            asignarPatenteFamilia.MdiParent = this;
            asignarPatenteFamilia.Show();
        }

        private void controlDeCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var controlCambios = new Bitacora.ControlCambios();
            controlCambios.MdiParent = this;
            controlCambios.Show();
        }

        public void ActualizarIdioma(SEG.Entity.Idioma idioma)
        {
            this.Traducir();
        }

        private void Traducir()
        {
            SEG.Service.Traductor traductor = new Traductor();
            var idiomaManager = SEG.Service.IdiomaManager.GetInstance();

            var traducciones = traductor.ObtenerTraducciones(idiomaManager.Idioma);

            //Menu.
            this.menuUsuarios.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.menuUsuarios.Name).Descripcion;

            this.menuBitacora.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.menuBitacora.Name).Descripcion;

            this.menuBackupRestore.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.menuBackupRestore.Name).Descripcion;

            this.menuGestionPermisos.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.menuGestionPermisos.Name).Descripcion;

            this.menuMiPerfil.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.menuMiPerfil.Name).Descripcion;

            this.menuDescuentos.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.menuDescuentos.Name).Descripcion;

            this.menuVentas.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.menuVentas.Name).Descripcion;

            this.menuGolosinas.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.menuGolosinas.Name).Descripcion;

            this.menuProveedores.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.menuProveedores.Name).Descripcion;

            this.menuPaquetes.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.menuPaquetes.Name).Descripcion;

            this.menuReportes.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.menuReportes.Name).Descripcion;

            //Sub-Menues.
            this.SubMenuBackupRestoreBackup.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuBackupRestoreBackup.Name).Descripcion;

            this.SubMenuBitacoraConsultar.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuBitacoraConsultar.Name).Descripcion;

            this.SubMenuBitacoraControlCambios.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuBitacoraControlCambios.Name).Descripcion;

            this.SubMenuFamilia.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuFamilia.Name).Descripcion;

            this.SubMenuMiPerfilAyuda.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuMiPerfilAyuda.Name).Descripcion;

            this.SubMenuMiPerfilCambiarContraseña.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuMiPerfilCambiarContraseña.Name).Descripcion;

            this.SubMenuMiPerfilCerrarSession.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuMiPerfilCerrarSession.Name).Descripcion;

            this.SubMenuMiPerfilGestionaIdioma.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuMiPerfilGestionaIdioma.Name).Descripcion;

            this.SubMenuPatente.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuPatente.Name).Descripcion;

            this.SubMenuUsuarioAlta.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuUsuarioAlta.Name).Descripcion;

            this.SubMenuUsuarioGestionar.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuUsuarioGestionar.Name).Descripcion;

            this.SubMenuUsuarioListar.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuUsuarioListar.Name).Descripcion;

            this.SubMenuVentasGenerar.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuVentasGenerar.Name).Descripcion;

            this.SubMenuVentasGestionar.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuVentasGestionar.Name).Descripcion;

            this.SubMenuVentasResumenDiario.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuVentasResumenDiario.Name).Descripcion;

            this.SubMenuGolosinasAlta.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuGolosinasAlta.Name).Descripcion;

            this.SubMenuGolosinasGestionar.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuGolosinasGestionar.Name).Descripcion;

            this.SubMenuGolosinasListar.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuGolosinasListar.Name).Descripcion;

            this.SubMenuPaquetesAlta.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuPaquetesAlta.Name).Descripcion;

            this.SubMenuPaquetesGestionar.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuPaquetesGestionar.Name).Descripcion;

            this.SubMenuPaquetesListado.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuPaquetesListado.Name).Descripcion;

            this.SubMenuProveedoresAlta.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuProveedoresAlta.Name).Descripcion;

            this.SubMenuProveedoresGestionar.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuProveedoresGestionar.Name).Descripcion;
        
            this.SubMenuProveedoresListado.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuProveedoresListado.Name).Descripcion;

            this.SubMenuDescuentosConfigurar.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuDescuentosConfigurar.Name).Descripcion;

            this.SubMenuDescuentosGestionar.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuDescuentosGestionar.Name).Descripcion;

            this.SubMenuReportesGolosinasMasVendidas.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuReportesGolosinasMasVendidas.Name).Descripcion;

            this.SubMenuReiniciarSistema.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuReiniciarSistema.Name).Descripcion;

            //Sub items.
            this.SubItemAltaFamilia.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubItemAltaFamilia.Name).Descripcion;

            this.SubItemAsignacionPatFamilia.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubItemAsignacionPatFamilia.Name).Descripcion;

            this.SubItemAsignacionPatUsuario.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubItemAsignacionPatUsuario.Name).Descripcion;

            this.SubItemGestionarFamilia.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubItemGestionarFamilia.Name).Descripcion;

            this.SubItemListarFamilias.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubItemListarFamilias.Name).Descripcion;

            this.SubItemListarPatentes.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubItemListarPatentes.Name).Descripcion;

            this.SubItemAsignacionFamUsuario.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubItemAsignacionFamUsuario.Name).Descripcion;

            this.SubMenuEspañol.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuEspañol.Name).Descripcion;

            this.SubMenuIngles.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuIngles.Name).Descripcion;

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SEG.Service.IdiomaManager.Desuscribir(this);
        }

        private void SubMenuEspañol_Click(object sender, EventArgs e)
        {
            // TODO MEJORAR ESTO.
            SEG.Entity.Idioma idioma = new SEG.Entity.Idioma
            {
                Id = 1,
                Nombre = "Español",
                Principal = true
            };

            SEG.Service.IdiomaManager.CambiarIdioma(idioma);
        }

        private void SubMenuIngles_Click(object sender, EventArgs e)
        {
            // TODO MEJORAR ESTO.
            SEG.Entity.Idioma idioma = new SEG.Entity.Idioma
            {
                Id = 2,
                Nombre = "Ingles",
                Principal = false
            };

            SEG.Service.IdiomaManager.CambiarIdioma(idioma);
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var generarVenta = new Venta();
            generarVenta.MdiParent = this;
            generarVenta.Show();
        }

        private void gestionarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var gestionarVenta = new Gestionar_Venta();
            gestionarVenta.MdiParent = this;
            gestionarVenta.Show();
        }

        private void resumenDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resumenDiario = new Resumen_Diario();
            resumenDiario.MdiParent = this;
            resumenDiario.Show();
        }

        private void altaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var alta = new Golosina.Alta_Golosina();
            alta.MdiParent = this;
            alta.Show();
        }

        private void gestionarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            var form = new Golosina.Gestionar();
            form.MdiParent = this;
            form.Show();
        }

        private void listarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new Golosina.Listado_Golosinas();
            form.MdiParent = this;
            form.Show();
        }

        private void altaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            var form = new Paquete.Alta_Paquete();
            form.MdiParent = this;
            form.Show();
        }

        private void gestionarToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            var form = new Paquete.Gestionar();
            form.MdiParent = this;
            form.Show();
        }

        private void listadoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Paquete.Listado_Paquetes();
            form.MdiParent = this;
            form.Show();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new Proveedor.Proveedor();
            form.MdiParent = this;
            form.Show();
        }

        private void gestionarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var form = new Proveedor.Gestionar();
            form.MdiParent = this;
            form.Show();
        }

        private void listadoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Proveedor.Listado_Proveedores();
            form.MdiParent = this;
            form.Show();
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Descuentos.Descuentos();
            form.MdiParent = this;
            form.Show();
        }

        private void gestionarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var form = new Descuentos.Gestionar();
            form.MdiParent = this;
            form.Show();
        }

        private void reiniciarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Backup_Restore.ReiniciarSistema();
            form.MdiParent = this;
            form.Show();
        }

        private void SubMenuMiPerfilAyuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, helpProvider.HelpNamespace, HelpNavigator.TableOfContents);
        }

        private void SubMenuReportesGolosinasMasVendidas_Click(object sender, EventArgs e)
        {
            var form = new Reportes.Reportes();
            form.MdiParent = this;
            form.Show();
        }

        void Form11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                System.Windows.Forms.Help.ShowHelp(this, helpProvider.HelpNamespace, HelpNavigator.TableOfContents);
        }
    }
}
