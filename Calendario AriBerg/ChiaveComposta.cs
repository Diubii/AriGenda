using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario_AriBerg
{
    internal static class ChiaveComposta
    {
        internal static string Componente(string marca, string codice)
        {
            return marca + codice;
        }

        internal static string Macchina(string marca, string matricola)
        {
            return marca + matricola;
        }
    }
}
