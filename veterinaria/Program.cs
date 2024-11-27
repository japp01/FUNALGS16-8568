/*
cree una aplicativo de veterinaria
clases con propiedades: 
    Mascota: nombre, edad, especie
    Servicio: descripcion, precio
    Boleta: codigo, mascota, servicio1, servicio2, total

Use arreglos estáticos de las clases
Debe tener un menu con estas opciones:
- crear, eliminar, listar Servicios
- crear, eliminar, listar Mascotas
- crear, listar Boletas

Para crear boletas debe seleccionar la Mascota y el Servicio de 
sus respectivos arreglos

Divida entre sus integrantes, el lider consolida y los integrantes uno hace lo de servicios y el otro el de mascotas
Debe tener una rama por integrante, el lider debe tener por lo menos 2 ramas: main y dev. debe trabajar y consolidar en dev
*/

namespace veterinaria
{
    public class Program
    {
        public static Servicio[] listaServicio = new Servicio[100];
        public static int cantidadServicio = 0;
        public static Mascota[] listaMascota = new Mascota[100];
        public static int cantidadMascota = 0;
        public static void Main(string[] args)
        {
            int opcion = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDO AL MENU");
                Console.WriteLine("1. Crear Servicio");
                Console.WriteLine("2. Eliminar Servicio");
                Console.WriteLine("3. Listar Servicios");
                Console.WriteLine();
                Console.WriteLine("4. Crear Mascota");
                Console.WriteLine("5. Eliminar Mascota");
                Console.WriteLine("6. Listar Mascotas");
                Console.WriteLine("0. Salir");
                Console.Write("\nEliga una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                OpSer opser = new OpSer();
                OpMas opmas = new OpMas();
                switch (opcion)
                {
                    case 1:
                        opser.Crear();
                        Console.WriteLine("\n¡Servicio creado!");
                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;
                    case 2:
                        opser.Eliminar();
                        Console.ReadKey();
                        break;
                    case 3:
                        opser.Listar();
                        Console.WriteLine("\nPresione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;
                    case 4:
                        opmas.Crear();
                        Console.WriteLine("\nPresione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;
                    case 5:
                        opmas.Eliminar();
                        Console.WriteLine("\nPresione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;
                    case 6:
                        opmas.Listar();
                        Console.WriteLine("\nPresione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 0);
        }
    }
}