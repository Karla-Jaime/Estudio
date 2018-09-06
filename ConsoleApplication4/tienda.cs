using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Tienda
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Producto> Productos{get; set;}
        public Patrocinador patro { get; set; }

        public Tienda()
        {
            Productos =  new List<Producto>();
        }
    }
}
