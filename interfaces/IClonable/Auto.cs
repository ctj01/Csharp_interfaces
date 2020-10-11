using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClonable
{
    public class Auto : Automovil, ICloneable
    {
        private double costo;
        string modelo;
        private double tenencia;
        public Auto(double Pcosto, string Pmodelo)
        {
            Costo = Pcosto;
            Modelo = Pmodelo;
        }

        public double Costo { get => costo; set => costo = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public double Tenencia { get => tenencia; set => tenencia = value; }

        public void CalculaImpuesto(double imp)
        {
            tenencia = 3000.00 + costo * imp;
        }

        public object Clone()
        {
            Auto nuevo = new Auto(costo, modelo);
            nuevo.Tenencia = tenencia;
            return nuevo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("el modelo del auto es {0} y tiene un precio de {1} y un impuesto de {2} ", modelo, costo, tenencia);
            Console.WriteLine("----------------------");
        }
    }
}
