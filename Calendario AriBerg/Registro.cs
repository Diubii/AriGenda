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
    public static class Registro
    {
        internal static List<Componenti> ComponentiAttuali { get; set; } = new List<Componenti>();
        internal static List<Cliente> ClientiAttuali { get; set; } = new List<Cliente>();

        internal static Dictionary<string, Cliente> DizClienti { get; set; } = new Dictionary<string, Cliente>();
        internal static Dictionary<string, Magazzino> DizMagazzini { get; set; } = new Dictionary<string, Magazzino>();

        internal static List<Evento> EventiMese = new List<Evento>();
    }

}