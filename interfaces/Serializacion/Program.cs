using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            CAuto autos = new CAuto(8000.00, "Hyndai");
            int opcion = 0;
            Console.WriteLine("selecciones 1 - crear 2- deserializar");
            opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                BinaryFormatter formato = new BinaryFormatter();
                Stream file = new FileStream("file.aut", FileMode.Create, FileAccess.Write, FileShare.None);
                autos.CalcularImpuesto(0.10);
                Console.WriteLine(autos.ToString());
                formato.Serialize(file, autos);
                file.Close();
            }
            if (opcion == 2)
            {
                BinaryFormatter format = new BinaryFormatter();
                Stream fil = new FileStream("file.aut", FileMode.Open, FileAccess.Read, FileShare.None);
                Console.ForegroundColor = ConsoleColor.Yellow;
                CAuto miauto = (CAuto)format.Deserialize(fil);
                fil.Close();
                Console.WriteLine(miauto.ToString());
            }
        }
    }
}
