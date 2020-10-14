using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callback
{
    class Refri
    {
        private ArrayList sinks = new ArrayList();
        private int kilos, grados;
        public Refri(int pKilos, int Pgrados)
        {
            Kilos = pKilos;
            Grados = Pgrados;
        }

        public int Kilos { get => kilos; set => kilos = value; }
        public int Grados { get => grados; set => grados = value; }

        public void agregarSink(IEventosRe Mysink)
        {
            if (Mysink != null)
            {
                sinks.Add(Mysink);
            }
        }
        public void Eliminar(IEventosRe Rsink)
        {
            if (sinks.Contains(Rsink))
                sinks.Remove(Rsink);
        }
        public void Trabajar(int consumo)
        {
            kilos -= consumo;
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kilos {0} Grados {1}", kilos, grados);

            if (kilos < 10)
            {
                foreach (IEventosRe handler in sinks)
                {
                    handler.ConsumoReserva(kilos);
                }
            }
            if (grados >= 0)
            {
                foreach (IEventosRe item in sinks)
                {
                    item.Edescongelar(grados);
                }
            }
        
        }
    }
}
