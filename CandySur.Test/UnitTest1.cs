using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CandySur.SEG.Util.Enums;
using CandySur.UTIL;

namespace CandySur.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GenerarDVH()
        {
            SEG.Entity.Usuario user = new SEG.Entity.Usuario();

            user.Apellido = "Piastrellini";

            SEG.Service.DigitoVerificador dv = new SEG.Service.DigitoVerificador();

            string dvh = dv.CalcularDVH(user.Apellido);
        }

        [TestMethod]
        public void Encriptar()
        {
            string nombre = Encrypt.Encriptar("Listar Usuarios", (int)TipoEncriptacion.Reversible);
        }


        [TestMethod]
        public void AumentarContadorReintentos()
        {
            SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();

            SEG.Entity.Usuario user = usuarioService.Consultar("agustin.piastrellini");

            int result = usuarioService.AumentarContador(user);
        }
        [TestMethod]
        public void ReiniciarContadorReintentos()
        {
            SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();

            SEG.Entity.Usuario user = usuarioService.Consultar("agustin.piastrellini");

            int result = usuarioService.ReiniciarContador(user);
        }

        [TestMethod]
        public void BloquearUsuario()
        {
            SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();

            SEG.Entity.Usuario user = usuarioService.Consultar("agustin.piastrellini");

            int result = usuarioService.BloquearUsuario(user);
        }

        [TestMethod]
        public void Desbloquear()
        {
            SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();

            SEG.Entity.Usuario user = usuarioService.Consultar("agustin.piastrellini");

            int result = usuarioService.Desbloquear(user);
        }

        [TestMethod]
        public void GenerarContraseña()
        {
            SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();

            usuarioService.GenerarContraseña("agustin.piastrellini", "agustin.e.piastrellini@gmail.com");
        }

        [TestMethod]
        public void VerificarIntegridad()
        {
            SEG.Service.DigitoVerificador dvService = new SEG.Service.DigitoVerificador();

            bool integridad = dvService.VerificarIntegridad();

        }

        [TestMethod]
        public void RecalcularDigitos()
        {
            SEG.Service.DigitoVerificador dvService = new SEG.Service.DigitoVerificador();

            dvService.RecalcularDVV();
        }


        [TestMethod]
        public void ConsultarFamilia()
        {
            SEG.Service.Familia familiaService = new SEG.Service.Familia();

            familiaService.Consultar("PruebaAgus");
        }


        [TestMethod]
        public void ListarVenas()
        {
            CandySur.BLL.Venta ventaService = new CandySur.BLL.Venta();

            foreach (var item in ventaService.ListarDiarias())
            {
                ventaService.ConcatenarRegistro(item);
            } 
        }
    }

}
