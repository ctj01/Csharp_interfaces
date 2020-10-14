using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegados
{
    class Crefri
    {
        public delegate void Ereservas(int Ekilos);
        public delegate void Edescongelar(int Egrados);
        private int kilosA =  0;
        private int gradosA = 0;
        private Ereservas Delreservas;
        private Edescongelar Deldescongelar;
        public int KilosA { get => kilosA; set => kilosA = value; }
        public int GradosA { get => gradosA; set => gradosA = value; }

        public Crefri(int pKilos, int Pgrados)
        {
            kilosA = pKilos;
            gradosA = Pgrados;
        }
        public void IngresarReservas(Ereservas pReservas)
        {
            Delreservas = pReservas;
        }
        public void Mdescongelar(Edescongelar pDescongelar)
        {
            Deldescongelar = pDescongelar;
        }
        public void Trabajar(int Pconsumo)
        {
            KilosA -= Pconsumo;
            GradosA += 1;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" kilos {0} Grados {1}", KilosA, GradosA);

            if (kilosA < 10)
                Delreservas(kilosA);
            
            if ( gradosA >= 0)
            {
                Deldescongelar(gradosA);
            }

        }
    }
}
