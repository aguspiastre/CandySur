﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Entity
{
    public class Familia : Permiso
    {
        public Familia()
        {
            this.Permisos = new List<Permiso>();
        }
        public List<Permiso> Permisos { get; set; }
    }
}
