using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    [Serializable]
    class CAuto
    {
        private double costo = 0;
        private string modelo;
        private double impuesto;
        public CAuto(double pcosto, string Pmodelo)
        {
            Costo = pcosto;
            Modelo = Pmodelo;
        }
        public void CalcularImpuesto(double pImp) 
        {
            Impuesto = (costo + 5000.00) * pImp;
        }
        public override string ToString()
        {
            return string.Format( "el modelo del auto es {0} y tiene un costo de {1} con una tenencia de {2} ", modelo, costo, impuesto);
        }
        public double Costo { get => costo; set => costo = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public double Impuesto { get => impuesto; set => impuesto = value; }
    }
}
