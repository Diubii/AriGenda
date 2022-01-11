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
        private string marca;
        private int soglia;
        private int n_ordine;
        private string codice;
        private int quantita;

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

        public string Tipo { get => tipo; set => tipo = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Soglia { get => soglia; set => soglia = value; }
        public int N_ordine { get => n_ordine; set => n_ordine = value; }
        public string Codice { get => codice; set => codice = value; }
        public int Quantita { get => quantita; set => quantita = value; }
    }
}
