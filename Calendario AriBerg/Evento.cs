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

    public class Evento: IComparable<Evento>
    {
        static public int numEventi;
        private int id;
        private DateTime giorno;          //da data selezionata
        private string nomeCliente;
        private Macchina macchina;
        private TimeSpan Tempo { get; set; }
        private List<InterventiPoss> interventi = new List<InterventiPoss>();
        private List<Componenti> componenti = new List<Componenti>();  //metti i componenti anche pianificati ma solo quando la data è passata aggiorna il magazzino
        private string operazioni;
        private string note;

        public Evento()
        {
        }

        public Evento(DateTime giorno, string nomeCliente, Macchina macchina, List<InterventiPoss> interventi, string note = null)
        {
            id = NumEventi;
            Giorno = giorno;
            NomeCliente = nomeCliente;
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

        public string NomeCliente
        {
            get => nomeCliente; 
            
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nomeCliente = value;
                }
                else
                {
                    throw new Exception("Aggiungere il nome del cliente.");
                }
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

        public int CompareTo(Evento other)
        {
            if(this == other)
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