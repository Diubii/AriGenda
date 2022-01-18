using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario_AriBerg
{
    public class Macchina
    {
        //public int _cliente { get; set; }
        public string _Marca { get; set; }
        public string _Modello { get; set; }
        public string _Matricola { get; set; }
        public bool _Noleggio { get; set; }

        public List<Componenti> _Componenti = new List<Componenti>();

        public string _Note { get; set; }

        public Macchina( string marca, string modello, string matricola, List<Componenti> componenti, bool noleggio = false, string note = null)
        {
            //_cliente = cliente;
            _Marca = marca;
            _Modello = modello;
            _Matricola = matricola;
            _Componenti = componenti;
            _Noleggio = noleggio;
            _Note = note;
        }
    }
}