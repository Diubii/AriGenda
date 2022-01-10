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

        public Dictionary<string, Cliente> DizClienti
        {
            get
            {
                return dizClienti;
            }

            set
            {
                dizClienti = value;
            }
        }

        public Dictionary<DateTime, List<Evento>> DizGiorni
        {
            get
            {
                return dizGiorni;
            }

            set
            {
                dizGiorni = value;
            }
        }

        public void AddEvento(Evento e)
        {
            if (dizGiorni.ContainsKey(e.Giorno))
            {
                dizGiorni[e.Giorno].Add(e);
            }
            else
            {
                List<Evento> eventiGiorno = new List<Evento>();
                eventiGiorno.Add(e);
                dizGiorni.Add(e.Giorno, eventiGiorno);
            }
        }

        public void RemoveEvento(Evento e)
        {
            if (dizGiorni.ContainsKey(e.Giorno))
            {
                dizGiorni[e.Giorno].Remove(e);
                if (dizGiorni[e.Giorno].Count == 0)
                {
                    dizGiorni.Remove(e.Giorno);
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

            foreach (Evento app in dizGiorni[e.Giorno])
            {
                if (app.ID == ev.ID)
                {
                    dizGiorni[e.Giorno].Remove(app);
                    dizGiorni[e.Giorno].Add(e);
                    break;
                }
            }
        }

        public void ModifyCliente(Cliente old,Cliente update)
        {
            dizClienti.Remove(old._Nome);
            dizClienti.Add(update._Nome, update);

        }

        public void salvaEventi()
        {
            JsonSerializer serializzatore = new JsonSerializer();
            StreamWriter sw = new StreamWriter("eventi.bababooey");

            serializzatore.Formatting = Formatting.Indented;

            using (JsonWriter scriba = new JsonTextWriter(sw))
            {
                serializzatore.Serialize(scriba, dizGiorni);
            }
        }

        public void salvaClienti()
        {
            JsonSerializer serializzatore = new JsonSerializer();
            StreamWriter sw = new StreamWriter("clienti.bababooey");

            serializzatore.Formatting = Formatting.Indented;

            using (JsonWriter scriba = new JsonTextWriter(sw))
            {
                serializzatore.Serialize(scriba, dizClienti);
            }
        }

        public void caricaEventi()
        {
            if (File.Exists("eventi.bababooey"))
            {
                dizGiorni = JsonConvert.DeserializeObject<Dictionary<DateTime, List<Evento>>>(File.ReadAllText("eventi.bababooey"));
            }
            else
            {
                throw new FileNotFoundException("File di salvataggio non trovato.");
            }
        }

        public void caricaClienti()
        {
            if (File.Exists("clienti.bababooey"))
            {
                dizClienti = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(File.ReadAllText("clienti.bababooey"));
            }
            else
            {
                throw new FileNotFoundException("File di salvataggio non trovato.");
            }
        }

        public void inviaSalvataggi()
        {
            if (File.Exists(@"\\DESKTOP-B2K8OHJ\Users\AriBerg Files\eventi.bababooey") && File.Exists(@"\\DESKTOP-B2K8OHJ\Users\AriBerg Files\clienti.bababooey"))
            {
                File.Copy("eventi.bababooey", @"\\DESKTOP-B2K8OHJ\Users\AriBerg Files\eventi.bababooey", true);
                File.Copy("clienti.bababooey", @"\\DESKTOP-B2K8OHJ\Users\AriBerg Files\clienti.bababooey", true);
            }
        }

        public bool riceviSalvataggiClienti()
        {
            string percorsoClienti = @"\\DESKTOP-B2K8OHJ\Users\AriBerg Files\clienti.bababooey";
            FileInfo FIPercorsoClienti = new FileInfo(percorsoClienti);
            FileInfo FIFileClienti = new FileInfo("clienti.bababooey");

        Start:
            if (File.Exists("clienti.bababooey") && File.Exists(percorsoClienti) && !FileInUso(FIPercorsoClienti) && !FileInUso(FIFileClienti))
            {
                string shaRisLocal;
                string shaRisRemote;

                using (SHA256 sha = SHA256Managed.Create())
                {
                    using (FileStream fs = File.OpenRead(percorsoClienti))
                    {
                        shaRisRemote = Convert.ToBase64String(sha.ComputeHash(fs));
                    }

                    using (FileStream fs = File.OpenRead("clienti.bababooey"))
                    {
                        shaRisLocal = Convert.ToBase64String(sha.ComputeHash(fs));
                    }
                }

                if (shaRisLocal != shaRisRemote)
                {
                    File.Copy(percorsoClienti, "clienti.bababooey", true);

                    caricaClienti();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (!File.Exists("clienti.bababooey"))
                {
                    File.Create("clienti.bababooey");
                }
                goto Start;
            }
        }

        public bool riceviSalvataggiEventi()
        {
            string percorsoEventi = @"\\DESKTOP-B2K8OHJ\Users\AriBerg Files\eventi.bababooey";
            FileInfo FIPercorsoEventi = new FileInfo(percorsoEventi);
            FileInfo FIFileEventi = new FileInfo("eventi.bababooey");

        Start:
            if (File.Exists("eventi.bababooey") && File.Exists(percorsoEventi) && !FileInUso(FIPercorsoEventi) && !FileInUso(FIFileEventi))
            {
                Thread.Sleep(100);
                string shaRisLocal = null;
                string shaRisRemote = null;

                using (SHA256 sha = SHA256Managed.Create())
                {
                    try
                    {
                        using (FileStream fs = File.OpenRead(percorsoEventi))
                        {
                            shaRisRemote = Convert.ToBase64String(sha.ComputeHash(fs));
                        }

                        using (FileStream fs = File.OpenRead("eventi.bababooey"))
                        {
                            shaRisLocal = Convert.ToBase64String(sha.ComputeHash(fs));
                        }
                    }
                    catch (Exception e)
                    {
                        Notifica notifica = new Notifica();
                        notifica.Show(e.Message, Notifica.enmType.Warning);
                    }
                }

                if (shaRisLocal != shaRisRemote)
                {
                    File.Copy(percorsoEventi, "eventi.bababooey", true);

                    caricaEventi();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (!File.Exists("eventi.bababooey"))
                {
                    File.Create("eventi.bababooey");
                }
                goto Start;
            }
        }

        private bool FileInUso(FileInfo nomeFile)
        {
            try
            {
                using (FileStream stream = nomeFile.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch
            {
                return true;
            }

            return false;
        }
    }
}