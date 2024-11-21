using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria
{
    public class Boleta
    {
        public int codigo {  get; set; }
        public Mascota mascota1 {  get; set; }
        public Servicio servicio1 { get; set; }
        public Servicio servicio2 { get; set; }
    }
}
