using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario_AriBerg
{
    public class Cliente
    {
        public string _Nome { get; set; }
        public string _Indirizzo { get; set; }
        public string _Telefono { get; set; }
        public string _PartIVA { get; set; }
        public string _Email { get; set; }
        public string _Ref { get; set; }

        public List<Macchina> _Mach = new List<Macchina>();

        public Cliente()
        {

        }

        public Cliente(string nome, string indirizzo, string telefono, string partIVA, string email, string _ref, List<Macchina> mach)
        {
            _Nome = nome;
            _Indirizzo = indirizzo;
            _Telefono = telefono;
            _PartIVA = partIVA;
            _Email = email;
            _Ref = _ref;
            if (mach == null)
            {
                _Mach = new List<Macchina>();
            }
            else
            {
                _Mach = mach;
            }
        }
    }
}