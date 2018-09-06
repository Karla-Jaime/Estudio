using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Producto
    {
        public string Sabrita { get; set; }
        public string Soda { get; set; }
        public int Total { get; set; }
        public Producto()
        {
            Sabrita = "Chetos";
            Soda = "Sprite";
            Total = 20;
        }
        public Producto( string sabritas, string soda, int total)
        {
            Sabrita = sabritas;
            Soda = soda;
            Total = total;
        }
    }
}
