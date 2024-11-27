using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria
{
    internal class OpMas
    {
        public void Crear()
        {
            Mascota m = new Mascota();
            Console.Write("Ingrese nombre: ");
            m.nombre = Console.ReadLine();
            Console.Write("Ingrese edad: ");
            m.edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese especie: ");
            m.especie = Console.ReadLine();

            Program.listaMascota[Program.cantidadMascota] = m;
            Program.cantidadMascota++;

            Console.WriteLine("¡Mascota creada!");
        }
        public void Eliminar()
        {
            Console.Write("Ingrese el numero de mascota (visible en la lista de mascotas): ");
            int indice = Convert.ToInt32(Console.ReadLine());
            indice--;

            if(indice >= 0 && indice < Program.cantidadMascota)
            {
                for(int i = indice; i <  Program.cantidadMascota; i++)
                {
                    Program.listaMascota[i] = Program.listaMascota[i + 1];
                }
                Program.cantidadMascota--;

                Console.WriteLine("¡Mascota eliminada!");
            }
            else
            {
                Console.WriteLine("¡La mascota no existe!");
            }
        }
        public void Listar()
        {
            for (int i = 0; i < Program.cantidadMascota; i++)
            {
                Console.WriteLine($"Mascota {i + 1}\n{Program.listaMascota[i].ToString()}");
            }
        }
    }
}
