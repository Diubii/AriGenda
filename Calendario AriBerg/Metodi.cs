using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
            string remoteConnectionString = $"Server=192.168.2.252; Database=arigenda; Uid=ariberg-admin; Pwd=merlinO123!;";
            MySqlConnection conn = new MySqlConnection(remoteConnectionString);
            conn.Open();
            return conn;
        }
    }
}
