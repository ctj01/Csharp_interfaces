using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegados
{
    class Ctienda
    {
        public static void MandaViveres(int pkilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("== Estas en la tienda");
            Console.WriteLine("quedan {0}", pkilos);
        }
    }
}
