using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Entity
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal DNI { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Direccion { get; set; }
        public decimal Telefono { get; set; }
        public int Reintentos { get; set; }
        public string Mail { get; set; }
        public DateTime FechaNac { get; set; }
        public bool Eliminado { get; set; }
        public bool Bloqueado { get; set; }
        public string DVH { get; set; }
        public List<Permiso> Permisos { get; set; }
    }
}
