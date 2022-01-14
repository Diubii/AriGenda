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
                string remoteConnectionString = $"Server=192.168.2.252; Database=arigenda; Uid=ariberg-admin; Pwd=merlinO123!;";
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

        internal static bool CheckForNewComponents(ref DataGridView dgvComponenti)
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

            foreach (DataGridViewRow row in dgvComponenti.Rows)
            {
                Componenti comp = row.DataBoundItem as Componenti;
                currentComponents.Add(comp);
            }

            bool different = false;

            foreach(Componenti comp in l)
            {
                if (currentComponents.Count == 0) break;

                Componenti sameCode = currentComponents.Find(x => x?.Codice == comp.Codice);
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

        internal static bool CheckForNewComponentsAndNotify(ref DataGridView dgvComponenti)
        {
            if (Metodi.CheckForNewComponents(ref dgvComponenti))
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
