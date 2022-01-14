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
        private List<Componenti> listacomponenti = new List<Componenti>();

        public Magazzino(string nome, List<Componenti> listacomponenti)
        {
            this.Nome = nome;
            this.Listacomponenti = listacomponenti;
        }
        public Magazzino(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }
        public List<Componenti> Listacomponenti { get => listacomponenti; set => listacomponenti = value; }
    }
}
