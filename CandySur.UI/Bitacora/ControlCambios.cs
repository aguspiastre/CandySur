using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandySur.UI.Bitacora
{
    public partial class ControlCambios : Form
    {
        private CandySur.SEG.Service.SessionManager Session;
        private CandySur.SEG.Entity.Usuario Usuario;
        CandySur.SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();
        CandySur.SEG.Service.ControlCambios controlService = new SEG.Service.ControlCambios();
        public ControlCambios()
        {
            InitializeComponent();
        }

        private void ControlCambios_Load(object sender, EventArgs e)
        {
            Session = SEG.Service.SessionManager.GetInstance();

            Dictionary<string, string> comboUser = new Dictionary<string, string>();
            cmbUsuario.DisplayMember = "Value";
            cmbUsuario.ValueMember = "Key";

            foreach (var item in usuarioService.Listar())
            {
                comboUser.Add(item.Id.ToString(), item.NombreUsuario);
            }

            cmbUsuario.DataSource = new BindingSource(comboUser, null);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)cmbUsuario.SelectedItem).Key;

            this.dataGridCambios.DataSource = controlService.Consultar(Convert.ToInt32(value));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Usuario == null)
                {
                    MessageBox.Show("Seleccionar un registro antes de actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    usuarioService.Modificar(Usuario, true);

                    this.dataGridCambios.DataSource = null;

                    MessageBox.Show("Usuario reestablecido con exito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridCambios_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridCambios.SelectedRows)
            {
                SEG.Entity.ControlCambios r = (SEG.Entity.ControlCambios)row.DataBoundItem;

                this.Usuario = new SEG.Entity.Usuario
                {
                    Id = r.Id_Usuario,
                    Apellido = r.Apellido,
                    Bloqueado = r.Bloqueado,
                    Contraseña = r.Contraseña,
                    Direccion = r.Direccion,
                    DNI = r.DNI,
                    Eliminado = r.Eliminado,
                    FechaNac = r.FechaNac,
                    Mail = r.Mail,
                    Nombre = r.Nombre,
                    NombreUsuario = r.NombreUsuario,
                    Reintentos = r.Reintentos,
                    Telefono = r.Telefono,
                };
            }
        }
    }
}
