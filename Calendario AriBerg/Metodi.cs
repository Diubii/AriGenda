using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using static System.Windows.Forms.Control;

namespace Calendario_AriBerg
{
    public struct Utilizzo
    {
        public int id;
        public string codice;
        public string marca;
        public int numero;
    }

    public struct Intervento
    {
        public int id;
        public InterventiPoss codice_intervento;
    }

    static internal class Metodi
    {
        static internal MySqlConnection ConnectToDatabase(string hostname, string dbname, string username, string password)
        {
            string remoteConnectionString = $"Server={hostname}; Database={dbname}; Uid={username}; Pwd={password};";
            MySqlConnection conn = new MySqlConnection(remoteConnectionString);
            conn.Open();
            return conn;
        }

        static internal MySqlConnection ConnectToDatabase()
        {
            try
            {
                string remoteConnectionString = $"Server=192.168.1.4; Database=arigenda; Uid=ariberg-admin; Pwd=merlinO123!;";
                //string remoteConnectionString = $"Server=127.0.0.1; Database=arigenda; Uid=ariberg-admin; Pwd=merlinO123!;";
                MySqlConnection conn = new MySqlConnection(remoteConnectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                Notifica n = new Notifica();
                n.Show(ex.Message, Notifica.enmType.Error);
                Application.Restart();
                return null;
            }
        }

        public struct Utilizzo
        {
           public int id;
           public string codice;
           public string marca;
           public int numero;
        }

        public struct Intervento
        {
            public int id;
            public InterventiPoss codice_intervento;
        }

        internal static bool CheckForNewEventiMese(DateTime d,bool Update)
        {

            //Ottimizzabile con query mirata

            //Parte Cliente
            MySqlConnection conn = Metodi.ConnectToDatabase();
            ///componenti
            ///0:codice_componente
            ///1:marca_componente
            ///2:tipo_componente
            ///3:soglia_componente
            ///4:n_ordine_componente
            List<Componenti> Catalogo = new List<Componenti>();
            Componenti c = new Componenti();


            string query = $"SELECT * From componente";
            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch { }

            while (reader.Read())
            {
                c = new Componenti(reader.GetString(2), reader.GetString(1), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(0), 0);
                Catalogo.Add(c);
            }

            reader.Close();

            ///Macchina
            ///0:marca_macchina
            ///1:modello_macchina
            ///2:matricola_macchina
            ///3:noleggio_macchina
            ///4:id_cliente
            ///5:note_macchina
            List<Macchina> macchine = new List<Macchina>();
            Macchina m;

           
            query = $"SELECT * From macchina";
            command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                List<Componenti> CompL = new List<Componenti>();
                m = new Macchina(reader.GetInt32(4), reader.GetString(0), reader.GetString(1), reader.GetString(2), CompL, reader.GetBoolean(3), reader.GetString(5));
                macchine.Add(m);
            }
            reader.Close();

            ///Componenti macchina
            ///0:codice_componente
            ///1:marca_componente
            ///2:marca_macchina
            ///3:matricola_macchina

            query = $"SELECT * From componenti_macchina";
            command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                c = new Componenti((Componenti)Catalogo.First(x => x.Codice == reader.GetString(0) && x.Marca == reader.GetString(1)));
                macchine.Find(x => x?._Marca == reader.GetString(2) && x?._Matricola == reader.GetString(3))._Componenti.Add(c);
            }

            reader.Close();
            ///0: id_cliente
            ///1: nome_cliente
            ///2: telefono_cliente
            ///3: mail_cliente
            ///4: indirizzo_cliente
            ///5: p.iva_cliente
            ///6: p.rif_cliente

            List<Cliente> l = new List<Cliente>();
            Cliente Cl = new Cliente();
            query = $"SELECT * FROM cliente";
            command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string p_iva = null;
                if (!reader.IsDBNull(reader.GetOrdinal("p.iva_cliente")))
                {
                    p_iva = reader.GetString(5);
                }

                string p_rif = null;
                if (!reader.IsDBNull(reader.GetOrdinal("p.rif_cliente")))
                {
                    p_rif = reader.GetString(6);
                }
                Cl = new Cliente(reader.GetString(1),
                    reader.GetString(4),
                    reader.GetString(2),
                    p_iva,
                    reader.GetString(3),
                    p_rif,
                    macchine.FindAll(x => x._cliente == GetCustomerID(reader.GetString(3), reader.GetString(2))));
                l.Add(Cl);
            }
            reader.Close();
            //parte clienti
            //parte interventi
            ///0:id_evento
            ///1:codice_intervento
            List<Intervento> Interventi = new List<Intervento>();
            query = $"SELECT * From intervento_evento";
            command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Intervento app= new Intervento();
                app.id = reader.GetInt32(0);
                app.codice_intervento =(InterventiPoss)reader.GetInt32(1);
                Interventi.Add(app);
            }
            reader.Close();
            //parte utilizzi
            ///0:id_evento
            ///1:codice_componente
            ///2:marca_componente
            ///3:n_utilizzato
            List<Utilizzo> Utilizzi = new List<Utilizzo>();
            query = $"SELECT * From utilizzo";
            command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Utilizzo app = new Utilizzo();
                app.id = reader.GetInt32(0);
                app.codice = reader.GetString(1);
                app.marca = reader.GetString(2);
                app.numero = reader.GetInt32(3);
                Utilizzi.Add(app);
            }
            reader.Close();

            //Eventi
            ///0:id_evento
            ///1:idricorrenza_evento
            ///2:data_evento
            ///3id_cliente
            ///4:marca_macchina
            ///5:matricola_macchina
            ///6:note_evento
            ///7:id_magazzino
            List<Evento> newEventiMese = new List<Evento>();
            query = $"SELECT * From evento where Month(data_evento)='{d.Month}' OR idricorrenza_evento IN (SELECT idricorrenza_evento From evento where Month(data_evento)='{d.Month}')";
            command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                
                    //Componenti utilizzati nell'evento
                    List<Componenti> Comp = new List<Componenti>();
                    List<Utilizzo> UtilizziEvento = new List<Utilizzo>();
                    UtilizziEvento = Utilizzi.FindAll(x => x.id == reader.GetInt32(0));
                    foreach (Componenti Componente in Catalogo)
                    {
                        foreach (Utilizzo Cmarcod in UtilizziEvento)
                        {
                            if (Componente.Marca == Cmarcod.marca && Componente.Codice == Cmarcod.codice)
                            {
                                Comp.Add(Componente);
                                break;
                            }
                        }
                    }
                    foreach (Componenti Compino in Comp)
                    {
                        foreach (Utilizzo u in UtilizziEvento)
                        {
                            if (Compino.Codice == u.codice && Compino.Marca == u.marca)
                            {
                                Comp.Find(x => x.Codice == u.codice && x.Marca == u.marca).Quantita = u.numero;
                                Utilizzi.Remove(u);
                            }
                        }
                    }
                    //interventi fatti in evento
                    List<InterventiPoss> InterventiEvento = new List<InterventiPoss>();
                    foreach (Intervento i in Interventi)
                    {
                        if (i.id == reader.GetInt32(0))
                        {
                            InterventiEvento.Add(i.codice_intervento);
                        }
                    }
                    //Cliente
                    Cliente ClienteEvento = new Cliente();
                    foreach (Cliente Client in l)
                    {
                        if (GetCustomerID(Client._Email, Client._Telefono) == reader.GetInt32(3))
                        {
                            ClienteEvento = Client;
                            break;
                        }
                    }
                    //Macchina
                    Macchina MacchinaEvento = new Macchina();
                    MacchinaEvento = ClienteEvento._Mach.Find(x => x._Matricola == reader.GetString(5) && x._Marca == reader.GetString(4));
                    //Listadate
                    string note = reader.GetString(6);
                    Evento ev = new Evento(reader.GetDateTime(2), ClienteEvento, MacchinaEvento, Comp,InterventiEvento, reader.GetString(7), note);
                    ev.ID = reader.GetInt32(0);
                     if (reader.GetInt32(1)==0) ev.Id_ricorrenza = null;
                     else ev.Id_ricorrenza = reader.GetInt32(1);
                    newEventiMese.Add(ev);
            }

            bool different = false;
           
            foreach (Evento eve in newEventiMese)
            {
                if (newEventiMese.Count != Registro.EventiMese.Count) { different = true; break; }
                if (Registro.EventiMese.Count == 0) break;               
                Evento sameCode = Registro.EventiMese.Find(x => x.ID == eve.ID);
                if (sameCode == null)
                {
                    different = true;
                    break;
                }
                else
                {
                    if (JsonConvert.SerializeObject(eve) != JsonConvert.SerializeObject(sameCode))
                    {
                        different = true;
                        break;
                    }
                }
            }

            if (different)
            {
                if (Update == true)
                {
                    newEventiMese.Sort(delegate(Evento x, Evento y)
                    {
                        return x.Giorno.CompareTo(y.Giorno);

                            });
                    Registro.EventiMese = newEventiMese;
                }
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }

        internal static bool CheckForNewEventiMeseAndNotify(DateTime d)
        {
            if (Metodi.CheckForNewEventiMese(d,false))
            {
                Notifica n = new Notifica();
                n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static List<Macchina> LoadMacchine()
        {
            MySqlConnection conn = Metodi.ConnectToDatabase();
            ///componenti
            ///0:codice_componente
            ///1:marca_componente
            ///2:tipo_componente
            ///3:soglia_componente
            ///4:n_ordine_componente
            List<Componenti> Catalogo = new List<Componenti>();
            Componenti c = new Componenti();


            string query = $"SELECT * From componente";
            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                c = new Componenti(reader.GetString(2), reader.GetString(1), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(0), 0);
                Catalogo.Add(c);
            }

            reader.Close();

            ///Macchina
            ///0:marca_macchina
            ///1:modello_macchina
            ///2:matricola_macchina
            ///3:noleggio_macchina
            ///4:id_cliente
            ///5:note_macchina
            List<Macchina> macchine = new List<Macchina>();
            Macchina m;

            query = $"SELECT * From macchina";
            command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                List<Componenti> CompL = new List<Componenti>();
                m = new Macchina(reader.GetInt32(4), reader.GetString(0), reader.GetString(1), reader.GetString(2), CompL, reader.GetBoolean(3), reader.GetString(5));
                macchine.Add(m);
            }
            reader.Close();

            ///Componenti macchina
            ///0:codice_componente
            ///1:marca_componente
            ///2:marca_macchina
            ///3:matricola_macchina

            query = $"SELECT * From componenti_macchina";
            command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                c = new Componenti((Componenti)Catalogo.First(x => x.Codice == reader.GetString(0) && x.Marca == reader.GetString(1)));
                macchine.Find(x => x?._Marca == reader.GetString(2) && x?._Matricola == reader.GetString(3))._Componenti.Add(c);
            }

            reader.Close();

            return macchine;
        }

        internal static bool CheckForNewDatiMagazzini(TabControl tbCtrlMagazzini)
        {
            MySqlConnection Conn = new MySqlConnection();

            Conn = Metodi.ConnectToDatabase();

            MySqlDataReader reader;
            string query = $"SELECT * From magazzino";
            MySqlCommand GetMagazzini = new MySqlCommand(query, Conn);
            reader = GetMagazzini.ExecuteReader();

            Dictionary<string, Magazzino> Magazzininew = new Dictionary<string, Magazzino>();

            while (reader.Read())
            {
                Magazzininew.Add(reader.GetString(0), new Magazzino(reader.GetString(0)));
            }
            Magazzininew.Add("Totale", new Magazzino("Totale"));
            reader.Close();

            List<Componenti> catalogo = new List<Componenti>();
            Componenti c = new Componenti();

            MySqlConnection conn = Metodi.ConnectToDatabase();
            query = $"SELECT * From componente";
            MySqlCommand command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                c = new Componenti(reader.GetString(2), reader.GetString(1), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(0), 0);
                catalogo.Add(c);
            }


            query = $"SELECT * From componenti_magazzino";
            GetMagazzini = new MySqlCommand(query, Conn);
            reader = GetMagazzini.ExecuteReader();

            while (reader.Read())
            {
                Componenti comp = new Componenti((Componenti)catalogo.First(x => x.Codice == reader.GetString(2) && x.Marca == reader.GetString(1)));
                Magazzininew[reader.GetString(0)].Listacomponenti.Add(comp);
                Magazzininew[reader.GetString(0)].Listacomponenti.Find(x => x.Codice == reader.GetString(2) && x.Marca == reader.GetString(1)).Quantita = reader.GetInt32(3);
                if (Magazzininew["Totale"].Listacomponenti.Find(x => x.Codice == reader.GetString(2) && x.Marca == reader.GetString(1)) == null)
                {
                    Componenti Compino = new Componenti((Componenti)catalogo.First(x => x.Codice == reader.GetString(2) && x.Marca == reader.GetString(1)));
                    Compino.Quantita = reader.GetInt32(3);
                    Magazzininew["Totale"].Listacomponenti.Add(Compino);
                }
                else
                {
                    Magazzininew["Totale"].Listacomponenti.Find(x => x.Codice == reader.GetString(2) && x.Marca == reader.GetString(1)).Quantita += reader.GetInt32(3);
                }
            }

            bool different = false;

            foreach (Magazzino mag in Magazzininew.Values)
            {              
                if (Magazzininew.Count != Registro.DizMagazzini.Count) { different = true; break; }
                if (Registro.DizMagazzini.Count == 0) break;
                Magazzino sameCode = Registro.DizMagazzini[mag.Nome];
                if (sameCode == null)
                {
                    different = true;
                    break;
                }
                else
                {
                    if (JsonConvert.SerializeObject(mag) != JsonConvert.SerializeObject(sameCode))
                    {
                        different = true;
                        break;
                    }
                }
            }

            if (different )
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }

        internal static bool CheckForNewDatiMagazziniAndNotify(TabControl tbCtrlMagazzini)
        {
            if (Metodi.CheckForNewDatiMagazzini(tbCtrlMagazzini))
            {
                Notifica n = new Notifica();
                n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool CheckForNewCustomers()
        {
            MySqlConnection conn = Metodi.ConnectToDatabase();
            ///componenti
            ///0:codice_componente
            ///1:marca_componente
            ///2:tipo_componente
            ///3:soglia_componente
            ///4:n_ordine_componente
            List<Componenti> Catalogo = new List<Componenti>();
            Componenti c = new Componenti();


            string query = $"SELECT * From componente";
            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                c = new Componenti(reader.GetString(2), reader.GetString(1), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(0), 0);
                Catalogo.Add(c);
            }

            reader.Close();

            ///Macchina
            ///0:marca_macchina
            ///1:modello_macchina
            ///2:matricola_macchina
            ///3:noleggio_macchina
            ///4:id_cliente
            ///5:note_macchina
            List<Macchina> macchine = new List<Macchina>();
            Macchina m;
           
            query = $"SELECT * From macchina";
            command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                List<Componenti> CompL = new List<Componenti>();
                m = new Macchina(reader.GetInt32(4),reader.GetString(0),reader.GetString(1),reader.GetString(2) ,CompL,reader.GetBoolean(3),reader.GetString(5));
                macchine.Add(m);
            }
            reader.Close();

            ///Componenti macchina
            ///0:codice_componente
            ///1:marca_componente
            ///2:marca_macchina
            ///3:matricola_macchina

            query = $"SELECT * From componenti_macchina";
            command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                c = new Componenti((Componenti)Catalogo.First(x => x.Codice == reader.GetString(0) && x.Marca == reader.GetString(1)));
                macchine.Find(x => x?._Marca == reader.GetString(2) && x?._Matricola == reader.GetString(3))._Componenti.Add(c);
            }

            reader.Close();
            ///0: id_cliente
            ///1: nome_cliente
            ///2: telefono_cliente
            ///3: mail_cliente
            ///4: indirizzo_cliente
            ///5: p.iva_cliente
            ///6: p.rif_cliente

            List<Cliente> l = new List<Cliente>();
            Cliente Cl = new Cliente();
             query = $"SELECT * FROM cliente";
            command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string p_iva = null;
                if (!reader.IsDBNull(reader.GetOrdinal("p.iva_cliente")))
                {
                    p_iva = reader.GetString(5);
                }

                string p_rif = null;
                if (!reader.IsDBNull(reader.GetOrdinal("p.rif_cliente")))
                {
                    p_rif = reader.GetString(6);
                }
                Cl = new Cliente(reader.GetString(1),
                    reader.GetString(4),
                    reader.GetString(2),
                    p_iva,
                    reader.GetString(3),
                    p_rif,
                    macchine.FindAll(x=>x._cliente==GetCustomerID(reader.GetString(3), reader.GetString(2))));
                l.Add(Cl);
            }
                   

            List<Cliente> currentClienti = new List<Cliente>();

            foreach (Cliente cl in Registro.ClientiAttuali)
            {
                currentClienti.Add(cl);
            }

            bool different = false;

            foreach (Cliente cl in l)
            {
                if (currentClienti.Count == 0) break;

                Cliente sameCode = currentClienti.Find(x => x?._Email == cl._Email && x._Telefono == cl._Telefono);
                if (sameCode == null)
                {
                    different = true;
                    break;
                }
                else
                {
                    if (JsonConvert.SerializeObject(cl) != JsonConvert.SerializeObject(sameCode))
                    {
                        different = true;
                        break;
                    }
                }
            }

            if (different || l.Count != currentClienti.Count)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        internal static bool CheckForNewCustomersAndNotify()
        {
            if (Metodi.CheckForNewCustomers())
            {
                Notifica n = new Notifica();
                n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool CheckForNewComponents(bool Update)
        {
            List<Componenti> l = new List<Componenti>();
            Componenti c = new Componenti();

            MySqlConnection conn = Metodi.ConnectToDatabase();
            string query = $"SELECT * From componente";
            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                c = new Componenti(reader.GetString(2), reader.GetString(1), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(0), 0);
                l.Add(c);
            }

            List<Componenti> currentComponents = new List<Componenti>();

            foreach (Componenti comps in Registro.ComponentiAttuali)
            {
                currentComponents.Add(comps);
            }

            bool different = false;

            foreach(Componenti comp in l)
            {
                if (currentComponents.Count == 0) break;

                Componenti sameCode = currentComponents.Find(x => x?.Codice == comp.Codice && x?.Marca== comp.Marca);
                if(sameCode == null)
                {
                    different = true;
                    break;
                }
                else
                {
                    if (JsonConvert.SerializeObject(comp) != JsonConvert.SerializeObject(sameCode))
                    {
                        different = true;
                        break;
                    }
                }
            }

            if (different || l.Count != currentComponents.Count)
            {
                if (Update == true)
                {
                    Registro.ComponentiAttuali = l;
                }
                conn.Close();
                return true;
                
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        internal static bool CheckForNewComponentsAndNotify(bool Update)
        {
            if (Metodi.CheckForNewComponents(Update))
            {
                Notifica n = new Notifica();
                n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static int GetCustomerID(string mail , string cell)
        {
            MySqlConnection conn = ConnectToDatabase();
            string query = $"SELECT id_cliente FROM cliente WHERE telefono_cliente = '{cell}' AND mail_cliente = '{mail}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader res = cmd.ExecuteReader();

            int ris = 0;


            while (res.Read())
            {
               ris = res.GetInt32(0);
            }

            conn.Close();
            return ris;
        }
        internal static int GetCustomerID(DataGridViewRow dgvr)
        {
            Cliente cl = dgvr.DataBoundItem as Cliente;
            MySqlConnection conn = ConnectToDatabase();
            string query = $"SELECT id_cliente FROM cliente WHERE telefono_cliente = '{cl._Telefono}' AND mail_cliente = '{cl._Email}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader res = cmd.ExecuteReader();

            res.Read();
            return res.GetInt32(0);
        }

        internal static bool CheckForNewBrands(ref DataGridView dvgBrands)
        {
            List<string> l = new List<string>();
            string c;

            MySqlConnection conn = Metodi.ConnectToDatabase();
            string query = $"SELECT * From marca_componente";
            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                c = reader.GetString(0);
                l.Add(c);
            }

            List<string> currentBrands = new List<string>();




            foreach (DataGridViewRow row in dvgBrands.Rows)
            {
                string brand = row.Cells[0].Value.ToString();
                currentBrands.Add(brand);
            }

            bool different = false;

            foreach (string brand in l)
            {
                if (currentBrands.Count == 0) break;

                string sameCode = currentBrands.Find(x => x == brand);
                if (sameCode == null)
                {
                    different = true;
                    break;
                }
                else
                {
                    if (brand != sameCode)
                    {
                        different = true;
                        break;
                    }
                }
            }

            if (different || l.Count != currentBrands.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        internal static bool CheckForNewBrandsAndNotify(ref DataGridView dvgBrands)
        {
            if (Metodi.CheckForNewBrands(ref dvgBrands))
            {
                Notifica n = new Notifica();
                n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool CheckForNewTypes(ref DataGridView dvgTypes)
        {
            List<string> l = new List<string>();
            string c;

            MySqlConnection conn = Metodi.ConnectToDatabase();
            string query = $"SELECT * From tipo_componente";
            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                c = reader.GetString(0);
                l.Add(c);
            }

            List<string> currentTypes = new List<string>();


            foreach (DataGridViewRow row in dvgTypes.Rows)
            {
                string tipo = row.Cells[0].Value.ToString();
                currentTypes.Add(tipo);
            }

            bool different = false;

            foreach (string tipo in l)
            {
                if (currentTypes.Count == 0) break;

                string sameCode = currentTypes.Find(x => x == tipo);
                if (sameCode == null)
                {
                    different = true;
                    break;
                }
                else
                {
                    if (tipo != sameCode)
                    {
                        different = true;
                        break;
                    }
                }
            }

            if (different || l.Count != currentTypes.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool CheckForNewTypesAndNotify(ref DataGridView dvgTypes)
        {
            if (Metodi.CheckForNewTypes(ref dvgTypes))
            {
                Notifica n = new Notifica();
                n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);

                return true;
            }
            else
            {
                return false;
            }
        }

        static internal bool AreThereAnyEmptyTextBoxes(List<TextBox> list, string tag = null)
        {
            if (!string.IsNullOrWhiteSpace(tag))
            {
                foreach (TextBox tb in list)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                foreach (TextBox tb in list)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text) && tb.Tag.ToString() == tag)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        static internal bool AreThereAnyEmptyTextBoxes(ControlCollection cc, string tag = null)
        {
            if (!string.IsNullOrWhiteSpace(tag))
            {
                foreach (Control c in cc)
                {
                    if (c is TextBox tb)
                    {
                        if (string.IsNullOrWhiteSpace(tb.Text) && tb.Tag.ToString() == tag)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
            else
            {
                foreach (Control c in cc)
                {
                    if (c is TextBox tb)
                    {
                        if (string.IsNullOrWhiteSpace(tb.Text))
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
        }
    

        static internal bool IsThisTextBoxEmpty(TextBox tb)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
