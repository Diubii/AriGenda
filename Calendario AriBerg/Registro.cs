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
        internal Dictionary<DateTime, List<Evento>> DizGiorni { get; set; } = new Dictionary<DateTime, List<Evento>>();
        internal Dictionary<string, Cliente> DizClienti { get; set; } = new Dictionary<string, Cliente>();
        internal Dictionary<string, Componenti> DizComponenti { get; set; } = new Dictionary<string, Componenti>();
        internal Dictionary<string, Magazzino> DizMagazzini { get; set; } = new Dictionary<string, Magazzino>();


        //Gestione eventi
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

        //Gestione Clienti
        public void AddCliente()
        {

        }
        public void ModifyCliente(Cliente old,Cliente update)
        {
            DizClienti.Remove(old._Nome);
            DizClienti.Add(update._Nome, update);

        }
        public void RemoveCliente()
        {

        }
    
        
        //Gestione Componenti
        public void AddComponenti()
        {

        }

        public void ModifyComponenti()
        {

        }

        public void RemoveComponenti()
        {

        }

        //Gestione Magazzini
        public void AddMagazzino(Magazzino m)
        {
            if (DizMagazzini.ContainsKey(m.Nome) == false)
            {
                DizMagazzini.Add(m.Nome, m);
            }
            else
            {
                throw new Exception("Nomw magazzino già in uso");
            }
        }

        public void ModifyMagazzino()
        {

        }

        public void DeleteMagazzino()
        {

        }

        //Gestione Immagazzinamento
        public void ImmagazzinaComponente(string nomeMagazzino,)
        {

        }

        public void ModificaQuantitàComponente()
        {

        }

        public void RemoveComponenteMagazzino()
        {

        }
        //////////////////////////////////////////
        //Gestione scambio dati con database
       ////////////////////////////////////////////////////


    }
}