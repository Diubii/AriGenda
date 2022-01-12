using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario_AriBerg
{
    public class Magazzino
    {
        private string nome;
        private Dictionary<string,Componenti> listacomponenti = new Dictionary<string, Componenti>();

        public Magazzino(string nome, Dictionary<string, Componenti> listacomponenti)
        {
            this.Nome = nome;
            this.Listacomponenti = listacomponenti;
        }
        public Magazzino(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }
        public Dictionary<string, Componenti> Listacomponenti { get => listacomponenti; set => listacomponenti = value; }
    }
}
