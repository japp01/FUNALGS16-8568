using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veterinaria;
namespace veterinaria
{
    public class OpSer
    {
        public void Crear()
        {
            Servicio s = new Servicio();
            Console.Write("Descripcion: ");
            s.descripcion = Console.ReadLine();
            Console.WriteLine("Precio: ");
            s.precio = Convert.ToInt32(Console.ReadLine());
            ;
        }
        public void Eliminar()
        {

        }
        public void Listar()
        {

        }
    }
}
