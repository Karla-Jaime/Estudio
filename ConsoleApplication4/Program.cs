using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LA LISTA NEGRA DE LAS TIENDAS MAS CHUCKYS DE OBREGON \n inserte voz de dross \n\n");

            List<Tienda> Tiendas = new List<Tienda>();
            Tienda tiendi1 = new Tienda();

            tiendi1.Nombre = "LA MAGUIE";
            tiendi1.Direccion = "pos la esquina ¿no?";
            tiendi1.Productos.Add(new Producto ("Sabritas clasicas", "Pepsi",5));
            tiendi1.Productos.Add(new Producto("Sabritones con chamoy", "Coca para lavar el baño", 20));
            tiendi1.patro = new Patrocinador();
            tiendi1.patro = new Patrocinador("Coky", "La coca pues");

            Tienda tiendi2 = new Tienda();

            tiendi2.Nombre = "La de Doña Emilia";
            tiendi2.Direccion = "Enfrente de mi casa";
            tiendi2.Productos.Add(new Producto("Chetos Flaming gastritis asegurada", "Fresa para vigotitos rosas",50));
            tiendi2.Productos.Add(new Producto("Churrumais del año de la inquizicion","Vitaaaaa",10));

            Console.WriteLine("Nombresito: " + tiendi1.Nombre);
          
            foreach (Tienda vara in Tiendas)
            {
                Console.WriteLine("Nombre osea helou: " + vara.Nombre);
                Console.WriteLine("Dire para llegarle: " + vara.Direccion);
                Console.WriteLine("Y pues hay les van los productos vara vara \n Oferton: " + vara.Productos);
                if (vara.patro != null)
                {
                    Console.WriteLine("La mascotita wea del equipo: "+ vara.patro.NombreC);
                    Console.WriteLine("Su respaldo: " + vara.patro.Compa);
                }
                else
                {
                    Console.WriteLine("Mas solita que la la vida");
                }
            }
            Console.ReadLine();
        }
    }
}
