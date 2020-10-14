using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callback
{
    class Sink : IEventosRe
    {
        private bool stop = false;

        public bool Stop { get => stop; set => stop = value; }

        public void ConsumoReserva(int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Reservas de alimentos");
            Console.WriteLine("Quedan {0} kilos", kilos);
        }

        public void Edescongelar(int Pgrados)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("el refri se descongela");
            if (Pgrados >= 0)
                stop = true;
        }
    }
}
