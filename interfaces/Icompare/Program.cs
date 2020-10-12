using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icompare
{
    class Program
    {
        static void Main(string[] args)
        {
            CRectangulo[] rects = new CRectangulo[5];
            rects[0] = new CRectangulo(5, 10);
            rects[1] = new CRectangulo(15, 20);
            rects[2] = new CRectangulo(15, 9);
            rects[3] = new CRectangulo(21, 3);
            rects[4] = new CRectangulo(15, 12);
            Array.Sort(rects);

            foreach (CRectangulo item in rects)
            {
                Console.WriteLine(item);
            }
        }
    }
}
