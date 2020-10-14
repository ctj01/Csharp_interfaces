using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callback
{
    class CTiendaRefri : IEventosRe
    {
        public void ConsumoReserva(int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=== tienda viveres ===");
            Console.WriteLine("Kilos {0}", kilos);
        }

        public void Edescongelar(int Pgrados)
        {
           
        }
    }
}
