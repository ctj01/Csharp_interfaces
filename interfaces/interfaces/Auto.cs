using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Auto : Automovil
    {
        string modelo;
        double costo;
        double tenencia;
        public Auto(double Ccosto, string Cmodelo)
        {
             modelo = Cmodelo;
             costo = Ccosto;
        }
        public void Calculaimpuesto(double imp)
        {
            tenencia = costo * imp;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("el modelo del auto es {0} y tiene un precio de {1} y un impuesto de {2} ", modelo, costo, tenencia);
            Console.WriteLine("----------------------");
        }
    }
}
