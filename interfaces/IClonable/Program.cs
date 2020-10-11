using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClonable
{
    class Program
    {
        static void Main(string[] args)
        {
            ///sin clonacion
            Auto auto1 = new Auto(50000.00, "MAZDA");
            Auto auto2 = auto1;
            auto1.CalculaImpuesto(0.10);
            auto2.CalculaImpuesto(0.10);
            auto1.MostrarInformacion();
            auto2.MostrarInformacion();
            auto1.Costo = 60000.00;
            auto1.MostrarInformacion();
            auto2.MostrarInformacion();

            //clonancion
            Auto auto3 = (Auto)auto1.Clone();
            auto1.MostrarInformacion();
            auto3.MostrarInformacion();
            Console.WriteLine("================================");
            auto1.Costo = 900000.00;
            auto1.MostrarInformacion();
            auto3.MostrarInformacion();

        }
    }
}
