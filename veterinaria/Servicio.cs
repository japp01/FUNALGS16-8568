﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria
{
    public class Servicio
    {
        public string descripcion {  get; set; }
        public int precio { get; set; }
        public override string ToString()
        {
            return $"Descripcion: {descripcion}\nPrecio: S/{precio}\n";
        }
    }
}
