﻿using CandySur.SEG.Entity;
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

namespace CandySur.UI.Golosina
{
    public partial class Alta_Golosina : Form, IIdiomaObserver
    {
        private SEG.Service.SessionManager Session;
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        CandySur.BLL.Proveedor proveedorService = new BLL.Proveedor();
        CandySur.BLL.Golosina golosinaService = new BLL.Golosina();

        public Alta_Golosina()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alta_Golosina_Load(object sender, EventArgs e)
        {
            try
            {
                Session = SEG.Service.SessionManager.GetInstance();

                this.validarPermisos(Session);

                this.Traducir();
                SEG.Service.IdiomaManager.Suscribir(this);

                cmbProveedores.DataSource = proveedorService.Listar();
                cmbProveedores.DisplayMember = "RazonSocial";
                cmbProveedores.ValueMember = "Cuit";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                string validarCampos = this.ValidarCampos();

                if (!String.IsNullOrEmpty(validarCampos))
                {
                    MessageBox.Show(validarCampos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BE.Proveedor proveedor = (BE.Proveedor)this.cmbProveedores.SelectedItem as BE.Proveedor;

                    BE.Golosina golosina = new BE.Golosina
                    {
                        Descripcion = txtDescripcion.Text,
                        Stock = int.Parse(txtStock.Text),
                        AlertaStock = int.Parse(txtStockAlerta.Text),
                        Eliminado = false,
                        Importe = Decimal.Parse(txtPrecio.Text.Replace(".",",")),
                        Proveedor = proveedor,
                    };

                    golosinaService.Alta(golosina);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Golosina dada de alta. " + txtDescripcion.Text
                    };

                    bitacoraService.Registrar(reg);

                    this.LimpiarCampos();

                    MessageBox.Show("Golosina dada de alta correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string ValidarCampos()
        {
            if (txtDescripcion.Text == "")
            {
                return "El campo descripcion es requerido";
            }
            if (txtPrecio.Text == "")
            {
                return "El campo precio es requerido";
            }
            if (txtStock.Text == "")
            {
                return "El campo stock es requerido";
            }
            if (txtStockAlerta.Text == "")
            {
                return "El campo cantidad stock alerta es requerido";
            }

            return string.Empty;
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtStockAlerta.Text = "";
        }

        private void Traducir()
        {
            SEG.Service.Traductor traductor = new Traductor();
            var idiomaManager = SEG.Service.IdiomaManager.GetInstance();

            var traducciones = traductor.ObtenerTraducciones(idiomaManager.Idioma);

            foreach (Control item in this.Controls)
            {
                if (traducciones.Any(t => t.Etiqueta == item.Name))
                {
                    item.Text = traducciones.FirstOrDefault(t => t.Etiqueta == item.Name).Descripcion;
                }

                TraducirControlesInternos(item, traducciones);
            }
        }

        private void TraducirControlesInternos(Control item, List<Traduccion> traducciones)
        {
            if (item is GroupBox)
            {
                foreach (Control subItem in item.Controls)
                {
                    if (traducciones.Any(t => t.Etiqueta == subItem.Name))
                    {
                        subItem.Text = traducciones.FirstOrDefault(t => t.Etiqueta == subItem.Name).Descripcion;
                    }

                    TraducirControlesInternos(subItem, traducciones);
                }
            }
        }

        public void ActualizarIdioma(SEG.Entity.Idioma idioma)
        {
            this.Traducir();
        }

        private void validarPermisos(SEG.Service.SessionManager Session)
        {
            bool contienePermisos = false;

            foreach (var item in Session.Usuario.Permisos)
            {
                if (item is SEG.Entity.Familia)
                {
                    SEG.Entity.Familia familia = (SEG.Entity.Familia)item;

                    foreach (SEG.Entity.Patente patente in familia.Permisos)
                    {
                        this.validarPatente(patente, ref contienePermisos);
                    }
                }
                else
                {
                    SEG.Entity.Patente patente = (SEG.Entity.Patente)item;

                    this.validarPatente(patente, ref contienePermisos);
                }
            }

            if (!contienePermisos)
                throw new Exception("No tenes los permisos necesarios para ingresar a esta funcionalidad");
        }

        private void validarPatente(SEG.Entity.Patente patente, ref bool contienePermisos)
        {
            switch (patente.Nombre)
            {
                case "Alta Golosina":
                    this.btnFinalizar.Visible = true;
                    this.btnCancelar.Visible = true;
                    contienePermisos = true;
                    break;
            }
        }
    }
}
