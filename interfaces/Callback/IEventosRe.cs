using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callback
{
    interface IEventosRe
    {
        void ConsumoReserva(int kilos);
        void Edescongelar(int Pgrados);
    }
}
