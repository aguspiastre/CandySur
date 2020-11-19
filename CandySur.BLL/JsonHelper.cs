using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.BLL
{
    public class JsonHelper
    {
        public JsonHelper()
        {

        }

        public static string Read(string fileName)
        {
            string RUTA_DESTINO = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            var path = Path.Combine(
            RUTA_DESTINO,
            fileName);

            string jsonResult = string.Empty;

            if (!File.Exists(path))
                Write(fileName, JsonDefault());

            using (StreamReader streamReader = new StreamReader(path))
            {
                jsonResult = streamReader.ReadToEnd();
            }
            return jsonResult;
        }

        public static void Write(string fileName, string jSONString)
        {
            string RUTA_DESTINO = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            var path = Path.Combine(
            RUTA_DESTINO,
            fileName);

            using (var streamWriter = File.CreateText(path))
            {
                streamWriter.Write(jSONString);
            }
        }

        private static string JsonDefault()
        {
            List<BE.Proveedor> proveedores = new List<BE.Proveedor>();

            proveedores.Add(new BE.Proveedor
            {
                Cuit = "203948773",
                RazonSocial = "ARCOR",
                Direccion = "Independencia 2017",
                CodPostal = "1838",
                Telefono = "42968420",
                Mail = "agustin.piastrellini@hotmail.com",
                Eliminado = 0,
                Golosinas = null
            });

            proveedores.Add(new BE.Proveedor
            {
                Cuit = "209874453",
                RazonSocial = "MILKA",
                Direccion = "Garcia Lorca 121",
                CodPostal = "2313",
                Telefono = "42968420",
                Mail = "agustin.piastrellini@hotmail.com",
                Eliminado = 0,
                Golosinas = null
            });

            return JsonConvert.SerializeObject(proveedores);
        }
    }
}
