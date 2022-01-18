using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Calendario_AriBerg
{
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
                string remoteConnectionString = $"Server=database.diubi.dev; Database=arigenda; Uid=ariberg-admin; Pwd=merlinO123!;";
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

            if (different || Magazzininew.Count != Registro.DizMagazzini.Count)
            {
                return true;
            }
            else
            {
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
            ///0: id_cliente
            ///1: nome_cliente
            ///2: telefono_cliente
            ///3: mail_cliente
            ///4: indirizzo_cliente
            ///5: p.iva_cliente
            ///6: p.rif_cliente

            List<Cliente> l = new List<Cliente>();
            Cliente c = new Cliente();

            MySqlConnection conn = Metodi.ConnectToDatabase();
            string query = $"SELECT * FROM cliente";
            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader reader = command.ExecuteReader();

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
                c = new Cliente(reader.GetString(1),
                    reader.GetString(4),
                    reader.GetString(2),
                    p_iva,
                    reader.GetString(3),
                    p_rif,
                    null);
                l.Add(c);
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
                return true;
            }
            else
            {
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

        internal static bool CheckForNewComponents()
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
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool CheckForNewComponentsAndNotify()
        {
            if (Metodi.CheckForNewComponents())
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

        internal static int GetCustomerID(DataGridViewRow dgvr)
        {
            Cliente cl = dgvr.DataBoundItem as Cliente;
            MySqlConnection conn = ConnectToDatabase();
            string query = $"SELECT id_cliente FROM cliente WHERE telefono_cliente = {cl._Telefono} AND mail_cliente = {cl._Email}";
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

            static internal bool AreThereAnyEmptyTextBoxes(List<TextBox> list)
        {
            foreach(TextBox tb in list)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    return true;
                }
            }

            return false;
        }

        static internal bool AreThereAnyEmptyTextBoxes(TextBox tb)
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
