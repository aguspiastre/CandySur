using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
