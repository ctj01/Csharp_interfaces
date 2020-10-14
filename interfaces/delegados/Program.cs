using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegados
{
    public delegate int pointer(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Crefri myrefri = new Crefri(50, -10);
            Random rnd = new Random();

            myrefri.IngresarReservas(new Crefri.Ereservas(informeKilos));
            myrefri.Mdescongelar(new Crefri.Edescongelar(informeGrados));

            while (myrefri.KilosA > 0)
            {
                myrefri.Trabajar(rnd.Next(1, 5));
            }
        }
        public static void informeKilos(int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==== quedan ===");
            Console.WriteLine("hay Kilos {0}", kilos);
        }
        public static void informeGrados(int grados)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("====== me estoy descongelando =====");
            Console.WriteLine("{0}", grados);
        }
    }
}
