using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegados
{
    public delegate int pointer(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            pointer delegdo = new pointer(Csuma.suma);
            int num = delegdo(5, 10);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(num);
            delegdo = new pointer(Cresta.resta);
            num = delegdo(20, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(num);
        }
    }
}
