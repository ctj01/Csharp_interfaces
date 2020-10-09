using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Ccontent : IEnumerable
    {
        int [] array  = new int[5];
        public Ccontent()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * i;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return (new Enumerator(array));
        }
    }
   class Enumerator : IEnumerator
    {
        public int [] array;
        int posicion = -1;
        public Enumerator(int [] pArray)
        {
            array = pArray;

        }
        public bool MoveNext()
        {
            posicion++;
            
            if (posicion < array.Length)
            {
                return (true);
            }
            return (false);
        }

        public void Reset()
        {
            posicion = -1;
        }

        public object Current
        {
            get
            {
                return array[posicion];
            }
        }
    }
}
