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
            Crefri myrefri = new Crefri(70, -20);
            Random rnd = new Random();

            Ereservas kilos1 = new Ereservas(informeKilos);
            Ereservas kilos2 = new Ereservas(Ctienda.MandaViveres);
            Edescongelar des = new Edescongelar(informeGrados);
            myrefri.IngresarReservas(kilos1);
            myrefri.IngresarReservas(kilos2);
            myrefri.Mdescongelar(des);

            while (myrefri.KilosA > 0)
            {
                myrefri.Trabajar(rnd.Next(1, 5));
            }
            
            myrefri.EliminarReserva(kilos2);
            myrefri.KilosA = 50;
            myrefri.GradosA = -20;
            
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
