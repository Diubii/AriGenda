using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

namespace Calendario_AriBerg
{
    public class Registro
    {
        private Dictionary<DateTime, List<Evento>> dizGiorni = new Dictionary<DateTime, List<Evento>>();
        private Dictionary<string, Cliente> dizClienti = new Dictionary<string, Cliente>();
        private Dictionary<string, Componenti> dizComponenti = new Dictionary<string, Componenti>();
        private Dictionary<string, Magazzino> dizMagazzini = new Dictionary<string, Magazzino>();


        public Dictionary<string, Componenti> DizComponenti { get => dizComponenti; set => dizComponenti = value; }
        public Dictionary<DateTime, List<Evento>> DizGiorni { get => dizGiorni; set => dizGiorni = value; }
        public Dictionary<string, Cliente> DizClienti { get => dizClienti; set => dizClienti = value; }
        public Dictionary<string, Magazzino> DizMagazzini { get => dizMagazzini; set => dizMagazzini = value; }

        public void AddEvento(Evento e)
        {
            if (DizGiorni.ContainsKey(e.Giorno))
            {
                DizGiorni[e.Giorno].Add(e);
            }
            else
            {
                List<Evento> eventiGiorno = new List<Evento>();
                eventiGiorno.Add(e);
                DizGiorni.Add(e.Giorno, eventiGiorno);
            }
        }

        public void RemoveEvento(Evento e)
        {
            if (DizGiorni.ContainsKey(e.Giorno))
            {
                DizGiorni[e.Giorno].Remove(e);
                if (DizGiorni[e.Giorno].Count == 0)
                {
                    DizGiorni.Remove(e.Giorno);
                }
            }
            else
            {
                throw new Exception("Non c'è niente da cancellare.");
            }
        }

        //Non funziona se viene cambiata la data
        public void ModifyEvento(Evento e, Evento ev)
        {

            foreach (Evento app in DizGiorni[e.Giorno])
            {
                if (app.ID == ev.ID)
                {
                    DizGiorni[e.Giorno].Remove(app);
                    DizGiorni[e.Giorno].Add(e);
                    break;
                }
            }
        }

        public void ModifyCliente(Cliente old,Cliente update)
        {
            DizClienti.Remove(old._Nome);
            DizClienti.Add(update._Nome, update);

        }

        //////////////////////////////////////////
        //Gestione scambio dati con database
       ////////////////////////////////////////////////////


    }
}