using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Patrocinador
    {
        public string NombreC { get; set; }
        public string Compa { get; set; }

        public Patrocinador()
        {
            NombreC = "Coky";
            Compa = "CocaCola Company";
        }
        public Patrocinador(string nombresito, string compis)
        {
            NombreC = nombresito;
            Compa = compis;
        }
    }
}
