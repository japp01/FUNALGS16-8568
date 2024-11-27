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
            s.descripcion = Console.ReadLine().Trim().ToLower();
            Console.Write("Precio: ");
            s.precio = Convert.ToInt32(Console.ReadLine());

            Program.listaServicio[Program.cantidadServicio] = s;
            Program.cantidadServicio++;
        }
        public void Eliminar()
        {
            Console.Write("Ingrese numero del servicio (lo puede ver en la lista de servicios): ");
            int indice = Convert.ToInt32(Console.ReadLine());
            indice--;
            if (indice < Program.cantidadServicio && indice >= 0)
            {
                for (int i = indice; i < Program.cantidadServicio; i++)
                {
                    Program.listaServicio[i] = Program.listaServicio[i + 1];
                }
                Program.cantidadServicio--;
                Console.WriteLine("\n¡Servicio eliminado!");
            }
            else
            {
                Console.WriteLine("\n¡El servicio no existe!");
            }

            Console.WriteLine("Pulse cualquier tecla para volver al menu...");
            Console.ReadKey();
        }
        public void Listar()
        {
            for(int i = 0; i < Program.cantidadServicio; i++)
            {
                Console.WriteLine($"Servicio {i + 1}\n{Program.listaServicio[i].ToString()}");
            }
        }
    }
}
