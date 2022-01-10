using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario_AriBerg
{
    public class Componenti
    {
        private string tipo;
        private string codice;

        public Componenti()
        {

        }

        public Componenti(string tipo, string codice)
        {
            this.Tipo = tipo;
            this.Codice = codice;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Codice { get => codice; set => codice = value; }
    }
}
