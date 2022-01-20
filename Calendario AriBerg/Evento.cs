using System;
using System.Collections.Generic;
using System.Linq;

namespace Calendario_AriBerg
{
    public enum InterventiPoss
    {
        Manut_Completa,
        Manut_Parziale,
        Controllo_Generale,
        Sost_Elementi_Filtrantiecc,
        Controllo_Fgas
    }

    public class Evento : IComparable<Evento>
    {
        static public int numEventi;      
        private int id;
        private int? id_ricorrenza;
        private DateTime giorno;          //da data selezionata +cadenza quindi lista di date possibile
        private Cliente cliente;       //modficare la data è ok e anche la ricorrenza da uno qualunque degli eventi e sposta tutti gli altri                                   
        private Macchina macchina;        //se vuole modificare altro però diverrà un evento singolo farlo capire bene
        public TimeSpan Tempo { get; set; }               //se cambia cadenza o termine influenza solo eventi nuovi... quindi quando giorno passa eventi divengono singoli
        private List<InterventiPoss> interventi = new List<InterventiPoss>();
        private List<Componenti> componenti = new List<Componenti>();  //metti i componenti anche pianificati ma solo quando la data è passata aggiorna il magazzino
        private string operazioni;
        private string note;

        public Evento()
        {
        }

        public Evento(DateTime giorno, Cliente Cliente, Macchina macchina, List<InterventiPoss> interventi, string note = null)
        {
            id = NumEventi;
            Giorno = giorno;
            this.Cliente = Cliente;
            Macchina = macchina;
            Interventi = interventi;
            Note = note;
            Operazioni = string.Concat(Enumerable.Repeat("◈", interventi.Count));
            NumEventi++;

        }

        public int NumEventi
        {
            get
            {
                return numEventi;
            }

            set
            {
                numEventi = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DateTime Giorno
        {
            get => giorno;

            set
            {
                giorno = value;
            }
        }

        public Cliente Cliente
        {
            get => cliente;

            set
            {
                cliente = value;
            }
        }

        public Macchina Macchina
        {
            get => macchina;

            set
            {
                if (!string.IsNullOrWhiteSpace(value._Matricola))
                {
                    macchina = value;
                }
                else
                {
                    throw new Exception("Aggiungere il codice della macchina.");
                }
            }
        }

        public string Note { get => note; set => note = value; }

        public List<InterventiPoss> Interventi
        {
            get => interventi;

            set
            {
                if (value.Count != 0)
                {
                    interventi = value;
                }
                else
                {
                    throw new Exception("Aggiungere un intervento.");
                }
            }
        }

        public string Operazioni { get => operazioni; set => operazioni = value; }
        public int? Id_ricorrenza { get => id_ricorrenza; set => id_ricorrenza = value; }

        public int CompareTo(Evento other)
        {
            if (this == other)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}