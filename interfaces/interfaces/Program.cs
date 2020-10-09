using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Ccontent datos = new Ccontent();
            foreach (int valor in datos)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
