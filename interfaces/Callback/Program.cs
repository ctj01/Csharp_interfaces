using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callback
{
    class Program
    {
        static void Main(string[] args)
        {
            Refri Myrefri = new Refri(60, -30);
            CTiendaRefri mytienda = new CTiendaRefri();
            Random rnd = new Random();

            Sink Mysink = new Sink();
            Myrefri.agregarSink(Mysink);
            Myrefri.agregarSink(mytienda);
            while (Myrefri.Kilos > 0 && Mysink.Stop == false)
            {
                Myrefri.Trabajar(rnd.Next(1,5));
            }
        }
    }
}
