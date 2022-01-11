using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario_AriBerg
{
    public class Componenti
    {
        internal string Tipo { get; set; }
        internal string Marca { get; set; }
        internal int Soglia { get; set; }
        internal int N_ordine { get; set; }
        internal string Codice { get; set; }
        internal int Quantita { get; set; }

        public Componenti()
        {

        }

        public Componenti(string tipo, string marca, int soglia, int n_ordine, string codice, int quantita)
        {
            this.Tipo = tipo;
            this.Marca = marca;
            this.Soglia = soglia;
            this.N_ordine = n_ordine;
            this.Codice = codice;
            this.Quantita = quantita;
        }
    }
}
