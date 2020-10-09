using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Tienda_de_autos
    {
        private Auto[] Disponibles;
        public Tienda_de_autos()
        {
            Disponibles = new Auto[4];
            Disponibles[0] = new Auto(45000, "HYNDAY");
            Disponibles[1] = new Auto(55050.0, "MERCEDES");
            Disponibles[2] = new Auto(650.000, "MAZDA");
            Disponibles[3] = new Auto(75000.00, "CAMARO");
        }
        public IEnumerator GetEnumerator() 
        {
            return Disponibles.GetEnumerator();
        }

    }
}
