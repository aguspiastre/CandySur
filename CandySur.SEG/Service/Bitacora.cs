﻿using CandySur.SEG.Request;
using CandySur.SEG.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static CandySur.SEG.Util.Enums;

namespace CandySur.SEG.Service
{
    public class Bitacora
    {
        private Repository.Bitacora repository;
        private Service.DigitoVerificador dv;

        public Bitacora()
        {
            repository = new Repository.Bitacora();
            dv = new Service.DigitoVerificador();
        }
        public int Registrar(Entity.Bitacora reg)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
            {
                reg.Descripcion = Encrypt.Encriptar(reg.Descripcion, (int)TipoEncriptacion.Reversible);
                reg.DVH = dv.CalcularDVH(this.ConcatenarRegistro(reg));

                int result = repository.Registrar(reg);

                dv.ActualizarDVV("Bitacora");

                scope.Complete();

                return result;
            }
        }

        public List<Entity.Bitacora> Consultar(ConsultarBitacoraRequest request)
        {
            return repository.Consultar(request);
        }

        private string ConcatenarRegistro(Entity.Bitacora bitacora)
        {
            return bitacora.Fecha.ToString() + bitacora.IdCriticidad + bitacora.Descripcion + bitacora.IdUsuario;
        }
    }
}
