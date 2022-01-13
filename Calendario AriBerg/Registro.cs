using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;

namespace Calendario_AriBerg
{
    public class Registro
    {
        internal Dictionary<DateTime, List<Evento>> DizGiorni { get; set; } = new Dictionary<DateTime, List<Evento>>();
        internal Dictionary<string, Cliente> DizClienti { get; set; } = new Dictionary<string, Cliente>();
        internal Dictionary<string, Componenti> DizComponenti { get; set; } = new Dictionary<string, Componenti>();
        internal Dictionary<string, Magazzino> DizMagazzini { get; set; } = new Dictionary<string, Magazzino>();

        internal Dictionary<DateTime, List<Evento>> appDizGiorni { get; set; } = new Dictionary<DateTime, List<Evento>>();
        internal Dictionary<string, Cliente> appDizClienti { get; set; } = new Dictionary<string, Cliente>();
        internal Dictionary<string, Componenti> appDizComponenti { get; set; } = new Dictionary<string, Componenti>();
        internal Dictionary<string, Magazzino> appDizMagazzini { get; set; } = new Dictionary<string, Magazzino>();

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
        public void ModifyEvento(Evento enew, Evento eold)
        {
            if (eold.Giorno != enew.Giorno)
            {
                //se modifica data cosa diversa cerchi in data vecchia id e togli e in nuova aggiungi nuovo evento..
            }
            else
            {

                foreach (Evento app in DizGiorni[enew.Giorno])
                {
                    if (app.ID == eold.ID)
                    {
                        DizGiorni[enew.Giorno].Remove(app);
                        DizGiorni[enew.Giorno].Add(enew);
                        break;
                    }
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

     
        //////////////////////////////////////////
        //Gestione scambio dati con database
       ////////////////////////////////////////////////////
        
        /// <summary>
        /// Pull dei dati dal database
        /// </summary>
        internal void PullDati()
        {
            MySqlConnection conn = Metodi.ConnectToDatabase();

            string query = "SELECT * FROM evento;";
            MySqlCommand PullEventi = new MySqlCommand(query, conn);
            MySqlDataReader res = PullEventi.ExecuteReader();

            while (res.HasRows)
            {
                ///INDICI TABELLA EVENTI
                ///0: id_evento PK
                ///1: data_evento
                ///2: tempo_evento
                ///3: id_cliente FK
                ///4: marca_macchina FK
                ///5: matricola_macchina FK
                ///6: note_evento

                res.Read();
                string id_evento = res.GetString(0);
                DateTime data_evento = res.GetDateTime(1);
                TimeSpan tempo_evento = res.GetTimeSpan(2);
                string id_cliente = res.GetString(3);
                string marca_macchina = res.GetString(4);
                string matricola_macchina = res.GetString(5);
                string note_evento = res.GetString(6);

                Dictionary<DateTime, List<Evento>> tempDizGiorni = new Dictionary<DateTime, List<Evento>>();
                
                foreach(KeyValuePair<DateTime, List<Evento>> kv in DizGiorni)
                {
                    tempDizGiorni.Add(kv.Key, kv.Value);
                }

                foreach(KeyValuePair<DateTime, List<Evento>> kv in tempDizGiorni)
                {
                    //Evento ev = tempDizGiorni.Values.First(x => x.First(y => y.ID.ToString() == id_evento).ID.ToString() == id_evento).First(x => x.ID.ToString() == id_evento);

                    bool found = false;

                    foreach(Evento e in kv.Value)
                    {
                        if(e.ID.ToString() == id_evento)
                        {
                            found = true;
                            
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Applica ai dizionari veri quelli di appoggio
        /// </summary>
        internal void UpdateWithPull()
        {

        }

        /// <summary>
        /// Fa il pull e confronta i dizionari aggiornati di appoggio con quelli veri e pusha le differenze
        /// </summary>
        internal void PushDati()
        {
            PullDati();

            Dictionary<int, Evento> eventiToUpdate = new Dictionary<int, Evento>();

            foreach(KeyValuePair<DateTime,List<Evento>> kv in DizGiorni)
            {
                foreach(Evento e in kv.Value)
                {
                    
                    if(e != appDizGiorni.Values.First(x => x.First(y => y.ID == e.ID).ID == e.ID).First(x => x.ID == e.ID))
                    {
                        eventiToUpdate.Add(e.ID, e);
                    }                  
                }
            }

            string query = "Update eventi";

        }
    }
}