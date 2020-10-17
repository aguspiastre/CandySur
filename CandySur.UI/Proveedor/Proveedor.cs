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

namespace CandySur.UI.Proveedor
{
    public partial class Proveedor : Form
    {
        private SEG.Service.SessionManager Session;
        CandySur.BLL.Proveedor proveedorService = new CandySur.BLL.Proveedor();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();

        public Proveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    CandySur.BE.Proveedor prov = new CandySur.BE.Proveedor
                    {
                        Telefono = txtTelefono.Text,
                        Direccion = txtDireccion.Text,
                        Mail = txtEmail.Text,
                        Eliminado = 0,
                        CodPostal = txtCodPostal.Text,
                        Cuit = txtCuit.Text,
                        RazonSocial = txtCuit.Text 
                    };

                    proveedorService.Alta(prov);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Proveedor dado de alta."
                    };

                    bitacoraService.Registrar(reg);

                    MessageBox.Show("Proveedor dado de alta correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidarCampos()
        {
            if (txtCodPostal.Text == "")
            {
                return "El campo codigo postal es requerido";
            }
            if (txtCuit.Text == "")
            {
                return "El campo cuit es requerido";
            }
            if (txtDireccion.Text == "")
            {
                return "El campo direccion es requerido";
            }
            if (txtEmail.Text == "")
            {
                return "El campo email es requerido";
            }
            if (txtRazonSocial.Text == "")
            {
                return "El campo razon social es requerido";
            }
            if (txtTelefono.Text == "")
            {
                return "El campo telefono es requerido";
            }

            return string.Empty;
        }
    }
}
