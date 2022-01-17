using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario_AriBerg
{
    public class Componenti
    {
        public string Codice { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public int Soglia { get; set; }
        public int N_ordine { get; set; }       
        public int Quantita { get; set; }

        public Componenti()
        {

        }

        public Componenti(Componenti Comp)
        {
            this.Tipo = Comp.Tipo;
            this.Marca = Comp.Marca;
            this.Soglia = Comp.Soglia;
            this.N_ordine = Comp.N_ordine;
            this.Codice = Comp.Codice;
            this.Quantita = Comp.Quantita;
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
