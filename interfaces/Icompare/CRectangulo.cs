using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icompare
{
    class CRectangulo:IComparable
    {
        private int alto;
        private int ancho;
        private int area;
        public CRectangulo(int Palto, int Pancho)
        {
            alto = Palto;
            ancho = Pancho;
            calculaArea();

        }
        void calculaArea() 
        {
            area = ancho * alto;
        }
        public override string ToString()
        {
            return string.Format("el alto del rectangulo es {0} y el ancho es {1} y su area es {2}", alto , ancho, area);
        }

        public int CompareTo(object obj)
        {
            CRectangulo nuevo = (CRectangulo)obj;
            if (area > nuevo.area)
            {
                return (1);
            }
            else if (area < nuevo.area)
            {
                return (-1);
            }
            return (0);
        }
    }
}
