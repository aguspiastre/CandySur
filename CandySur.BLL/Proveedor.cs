using CandySur.UTIL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandySur.DLL;

namespace CandySur.BLL
{
    public class Proveedor
    {
        public void Alta(CandySur.BE.Proveedor proveedor)
        {
            try
            {
                List<CandySur.BE.Proveedor> proveedores = JsonConvert.DeserializeObject<List<CandySur.BE.Proveedor>>(JsonHelper.Read("Proveedores.json", "data"));
                CandySur.BE.Proveedor prov = proveedores.FirstOrDefault(x => x.Cuit == proveedor.Cuit);

                if (!proveedores.Any(x => x.Cuit == proveedor.Cuit))
                {
                    proveedores.Add(proveedor);
                }
                else
                    throw new Exception("No se puede ingresar, el proveedor ya se encuentra dado de alta.");

                string jSONString = JsonConvert.SerializeObject(proveedores);
                JsonHelper.Write("Proveedores.json", "data", jSONString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(CandySur.BE.Proveedor proveedor)
        {
            try
            {
                List<CandySur.BE.Proveedor> proveedores = JsonConvert.DeserializeObject<List<CandySur.BE.Proveedor>>(JsonHelper.Read("Proveedores.json", "data"));
                CandySur.BE.Proveedor prov = proveedores.FirstOrDefault(x => x.Cuit == proveedor.Cuit);

                int index = proveedores.FindIndex(x => x.Cuit == proveedor.Cuit);
                proveedores[index] = proveedor;

                string jSONString = JsonConvert.SerializeObject(proveedores);
                JsonHelper.Write("Proveedores.json", "data", jSONString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(string cuit)
        {
            try
            {
                List<CandySur.BE.Proveedor> proveedores = JsonConvert.DeserializeObject<List<CandySur.BE.Proveedor>>(JsonHelper.Read("Proveedores.json", "data"));

                proveedores.RemoveAt(proveedores.FindIndex(x => x.Cuit == cuit));

                string jSONString = JsonConvert.SerializeObject(proveedores);
                JsonHelper.Write("Proveedores.json", "data", jSONString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CandySur.BE.Proveedor ObtenerDetalle(string cuit)
        {
            try
            {
                DLL.Repository.Proveedor repository = new DLL.Repository.Proveedor();

                List<CandySur.BE.Proveedor> proveedores = JsonConvert.DeserializeObject<List<CandySur.BE.Proveedor>>(JsonHelper.Read("Proveedores.json", "data"));
                CandySur.BE.Proveedor prov = proveedores.FirstOrDefault(x => x.Cuit == cuit && x.Eliminado == 0);

                if (prov == null)
                    throw new Exception("No se encontro al proveedor solicitado.");

                prov.Golosinas = repository.ConsultarGolosinasProveedor(prov.Cuit);

                return prov;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CandySur.BE.Proveedor> Listar()
        {
            try
            {
                List<CandySur.BE.Proveedor> proveedores = JsonConvert.DeserializeObject<List<CandySur.BE.Proveedor>>(JsonHelper.Read("Proveedores.json", "data"));

                return proveedores.Where(p => p.Eliminado == 0).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

