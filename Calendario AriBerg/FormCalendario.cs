﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario_AriBerg
{
    public partial class FormCalendario : Form
    {
        public System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        private Point p = new Point();
        private DateTime SelectedDate;

        //Inizializzazione del Thread che riceve i files

        //private Macchina macchina;
        private List<Macchina> listaMacchine;

        private string FiltroAttivoMagazzino = null;
        private string FiltroAttivoCatalogo = null;

        private string CurrentComponentiFiltroTipo = null;
        private string CurrentComponentiFiltroCodice = null;
        private string CurrentComponentiFiltroMarca = null;
        private bool CurrentComponentiFiltroSottoSoglia = false;

        public FormCalendario()
        {
            InitializeComponent();
        }

        private void FormCalendario_Load(object sender, EventArgs e)
        {
            bool error = false;

            //Configurazione data
            SelectedDate = DateTime.Now.Date;

            /*//Connessione database query test
            Connection = Metodi.ConnectToDatabase();
            string query = "Update cliente set indirizzo_cliente = 'prova' where id_cliente='1'";
            MySqlCommand command = new MySqlCommand(query,Connection);
            command.ExecuteNonQuery();
            Connection.Close();*/

            //configurazione registro
            if (Registro.DizClienti == null)
            {
                Registro.DizClienti = new Dictionary<string, Cliente>();
            }
            if (Registro.DizGiorni == null)
            {
                Registro.DizGiorni = new Dictionary<DateTime, List<Evento>>();
            }

            ariCalendario.Refresh();
            lblEventi.Text = "Eventi del: " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            lblClienti.Text = "Tutti i clienti";
            dgvEventi.RowTemplate.Height = 45;

            //confiddatagrid
            dgvEventi.DefaultCellStyle.BackColor = Color.LightGray;

            //configPannelloAggiungi
            comboBoxAggiungi.Items.Add(InterventiPoss.Manut_Completa);
            comboBoxAggiungi.Items.Add(InterventiPoss.Manut_Parziale);
            comboBoxAggiungi.Items.Add(InterventiPoss.Controllo_Generale);
            comboBoxAggiungi.Items.Add(InterventiPoss.Sost_Elementi_Filtrantiecc);
            comboBoxAggiungi.Items.Add(InterventiPoss.Controllo_Fgas);

            //configPannelloModifica
            cbxModificaListaOperazioni.Items.Add(InterventiPoss.Manut_Completa);
            cbxModificaListaOperazioni.Items.Add(InterventiPoss.Manut_Parziale);
            cbxModificaListaOperazioni.Items.Add(InterventiPoss.Controllo_Generale);
            cbxModificaListaOperazioni.Items.Add(InterventiPoss.Sost_Elementi_Filtrantiecc);
            cbxModificaListaOperazioni.Items.Add(InterventiPoss.Controllo_Fgas);

            //Controllo ora per scadenze
            DateTime min = new DateTime(1, 1, 1, 7, 0, 0);
            DateTime max = new DateTime(1, 1, 1, 15, 0, 0);
            if (DateTime.Now.Hour >= min.Hour && DateTime.Now.Hour <= max.Hour && error == false)
            {
                GeneraScadenze();
            }

            //configdgwEventi
            if (Registro.DizGiorni != null && Registro.DizGiorni.ContainsKey(SelectedDate))
            {
                dgvEventi.DataSource = Registro.DizGiorni[SelectedDate];
                HideColumnsEventi();
            }

            if (DateTime.Now.Date == new DateTime(DateTime.Now.Year, 4, 1))
            {
                mur.Visible = true;
            }
            else
            {
                mur.Visible = false;
            }

            //configdgwEventi
            if (Registro.DizClienti != null)
            {
                dgvVisualizzaClienti.DataSource = Registro.DizClienti.Values.ToList();
                HideColumnsClienti();
                dgvVisualizzaClienti.AutoGenerateColumns = true;
            }

            rdBtnTrovaPerNome.Checked = true;
            AggiornaComboBox();

            dgvComponenti.AllowUserToAddRows = false;

            dgvMostraMacchineAccessori.DefaultCellStyle.ForeColor = Color.Black;
            dgvMostraMacchineAccessori.ColumnHeadersDefaultCellStyle.Font = new Font("Yu Gothic UI", 10);
            dgvMostraMacchineAccessori.DefaultCellStyle.Font = new Font("Yu Gothic UI", 8);

            dgvMostraComponentiMacchina.DefaultCellStyle.ForeColor = Color.Black;
            dgvMostraComponentiMacchina.ColumnHeadersDefaultCellStyle.Font = new Font("Yu Gothic UI", 10);
            dgvMostraComponentiMacchina.DefaultCellStyle.Font = new Font("Yu Gothic UI", 8);

            dgvModificaCliente.DefaultCellStyle.ForeColor = Color.Black;
            dgvModificaCliente.ColumnHeadersDefaultCellStyle.Font = new Font("Yu Gothic UI", 10);
            dgvModificaCliente.DefaultCellStyle.Font = new Font("Yu Gothic UI", 8);

            dgvComponentiAggiungiMacchina.DefaultCellStyle.ForeColor = Color.Black;
            dgvComponentiAggiungiMacchina.ColumnHeadersDefaultCellStyle.Font = new Font("Yu Gothic UI", 10);
            dgvComponentiAggiungiMacchina.DefaultCellStyle.Font = new Font("Yu Gothic UI", 8);

            dgvAggiungiClientiMacchine.DefaultCellStyle.ForeColor = Color.Black;
            dgvAggiungiClientiMacchine.ColumnHeadersDefaultCellStyle.Font = new Font("Yu Gothic UI", 10);
            dgvAggiungiClientiMacchine.DefaultCellStyle.Font = new Font("Yu Gothic UI", 8);

            //timerUpdatePagina con database
            //t.Interval = 20000;
            //t.Tick += TimerTick;
            //t.Start();
        }

        private void Caricamento()
        {
            Cursor = Cursors.AppStarting;
            foreach (Control c in Controls)
            {
                c.Enabled = false;
            }
            pbxWait.Location = new Point(this.Width / 2 - pbxWait.Width / 2, this.Height / 2 - pbxWait.Height / 2 - pbxWait.Height / 4);
            pbxWait.Enabled = true;
            pbxWait.Visible = true;
            pbxWait.BringToFront();
        }

        private void EndCaricamento()
        {
            foreach (Control c in Controls)
            {
                c.Enabled = true;
            }
            Cursor = Cursors.Default;
            pbxWait.Enabled = true;
            pbxWait.Visible = false;
            pbxWait.SendToBack();
        }

        private void RefreshCurrentTab()
        {
            int a = 0;
            Invoke(new Action(() =>
            {
                a = tabControl1.SelectedIndex;
            }));
            switch (a)
            {
                case 0:
                    break;

                case 1:

                    if (Metodi.CheckForNewCustomers())
                    {
                        RefreshCustomers();
                    }

                    if (Metodi.CheckForNewTypes(ref dgvTipiComponenti) || Metodi.CheckForNewBrands(ref dgvMarcheComponenti) || Metodi.CheckForNewComponents())
                    {
                        RefreshComponentTypesDataGridView();
                        RefreshComponentBrandsDataGridView();
                        RefreshComponentsCatalogoAndCBX();
                        List<string> types = new List<string>();
                        foreach (DataGridViewRow dgvr in dgvTipiComponenti.Rows) types.Add(dgvr.Cells[0].Value.ToString());
                        cbBxAggiungiMacchinaTipoFiltro.DataSource = types;
                        List<string> marche = new List<string>();
                        foreach (DataGridViewRow dgvr in dgvMarcheComponenti.Rows) marche.Add(dgvr.Cells[0].Value.ToString());
                        cbBxAggiungiMacchinaMarca.DataSource = marche;
                        Invoke(new Action(() =>
                        {
                            Notifica n = new Notifica();
                            n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);
                        }));
                    }                                                          
                    break;

                case 2:
                    UpdateCBXTipi();


                    if (Metodi.CheckForNewComponents())
                    {
                        RefreshComponentsCatalogoAndCBX();
                        RefreshMagazzini();
                        RefreshConetnutiMagazzini();
                        Invoke(new Action(() =>
                        {
                            Notifica n = new Notifica();
                            n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);
                        }));
                    }
                    break;

                case 3:
                    if (Metodi.CheckForNewBrands(ref dgvMarcheComponenti) || Metodi.CheckForNewTypes(ref dgvTipiComponenti))
                    {
                        RefreshComponentBrandsDataGridView();
                        RefreshComponentTypesDataGridView();
                        UpdateComboboxTabc2MarcType();
                        Invoke(new Action(() =>
                        {
                            Notifica n = new Notifica();
                            n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);
                        }));
                    }
                    break;
            }

            Invoke(new Action(() => { EndCaricamento(); }));
        }

        private void UpdateCBXTipi()
        {
            List<string> tipiAttuali = new List<string>();
            foreach (string s in cbBxFiltroMagazzinoTipo.Items) tipiAttuali.Add(s);

            List<string> tipiDatabase = new List<string>();
            foreach (DataGridViewRow dgvr in dgvTipiComponenti.Rows) tipiDatabase.Add(dgvr.Cells[0].Value.ToString());

            var res = false;

            if (tipiDatabase.Count > 0)
            {
                res = tipiDatabase.All(tipiAttuali.Contains) && tipiDatabase.Count == tipiAttuali.Count;
            }

            if (!res) UpdateComboboxTabc2MarcType();
        }

        private void RefreshConetnutiMagazzini()
        {
            MySqlConnection Conn = new MySqlConnection();

            Conn = Metodi.ConnectToDatabase();

            MySqlDataReader reader;
            List<Componenti> catalogo = new List<Componenti>();
            Componenti c = new Componenti();

            MySqlConnection conn = Metodi.ConnectToDatabase();
            string query = $"SELECT * From componente";
            MySqlCommand command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                c = new Componenti(reader.GetString(2), reader.GetString(1), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(0), 0);
                catalogo.Add(c);
            }

            //tante liste quante sono i magazzini
            Dictionary<string, Magazzino> MagazziniAssemblyMegazord = new Dictionary<string, Magazzino>();
            foreach (TabPage t in tbCtrlMagazzini.TabPages)
            {
                Magazzino m = new Magazzino(t.Name);
                MagazziniAssemblyMegazord.Add(t.Name, m);
            }

            ///0: id_magazzino
            ///1:marca_componente
            ///2:codice_componente
            ///3:qiantità_componente
            query = $"SELECT * From componenti_magazzino";
            MySqlCommand GetMagazzini = new MySqlCommand(query, Conn);
            reader = GetMagazzini.ExecuteReader();

            while (reader.Read())
            {
                Componenti comp = new Componenti((Componenti)catalogo.First(x => x.Codice == reader.GetString(2) && x.Marca == reader.GetString(1)));
                MagazziniAssemblyMegazord[reader.GetString(0)].Listacomponenti.Add(comp); 
                MagazziniAssemblyMegazord[reader.GetString(0)].Listacomponenti.Find(x => x.Codice == reader.GetString(2) && x.Marca == reader.GetString(1)).Quantita = reader.GetInt32(3); 
                if (MagazziniAssemblyMegazord["Totale"].Listacomponenti.Find(x => x.Codice == reader.GetString(2) && x.Marca == reader.GetString(1)) == null)
                {
                    Componenti Compino = new Componenti((Componenti)catalogo.First(x => x.Codice == reader.GetString(2) && x.Marca == reader.GetString(1)));
                    Compino.Quantita = reader.GetInt32(3);
                    MagazziniAssemblyMegazord["Totale"].Listacomponenti.Add(Compino);
                }
                else
                {
                    MagazziniAssemblyMegazord["Totale"].Listacomponenti.Find(x => x.Codice == reader.GetString(2) && x.Marca == reader.GetString(1)).Quantita += reader.GetInt32(3);
                }
            }

            foreach (TabPage t in tbCtrlMagazzini.TabPages)
            {
                DataGridView d = (DataGridView)t.Controls["dgvMagazzino" + t.Name];
                Invoke(new Action(() => { d.DataSource = MagazziniAssemblyMegazord[t.Name].Listacomponenti; }));
            }

            Registro.DizMagazzini=MagazziniAssemblyMegazord;
        }

        private void RefreshMagazzini()
        {
            ///0:id_magazzino

            MySqlConnection Conn = new MySqlConnection();

            Conn = Metodi.ConnectToDatabase();

            MySqlDataReader reader;
            string query = $"SELECT * From magazzino";
            MySqlCommand GetMagazzini = new MySqlCommand(query, Conn);
            reader = GetMagazzini.ExecuteReader();

            List<string> Magazzini = new List<string>();

            while (reader.Read())
            {
                Magazzini.Add(reader.GetString(0));
            }

            foreach (TabPage t in tbCtrlMagazzini.TabPages)
            {
                if (t.Name != "Totale" && t.Name != "Centrale")
                {
                    Invoke(new Action(() => { tbCtrlMagazzini.TabPages.Remove(t); }));
                }
            }

            foreach (string s in Magazzini)
            {
                if (!tbCtrlMagazzini.TabPages.ContainsKey(s))
                {
                    TabPage t = new TabPage(s);
                    t.Name = s;
                    Invoke(new Action(() =>
                    {
                        tbCtrlMagazzini.TabPages.Add(t);
                    }));

                    DataGridView d = new DataGridView();
                    d.AllowUserToAddRows = false;
                    d.Name = "dgvMagazzino" + s;
                    d.Dock = DockStyle.Fill;
                    d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    d.CellDoubleClick += CommonCellDoubleClickEvent;

                    Invoke(new Action(() =>
                    {
                        tbCtrlMagazzini.TabPages[s].Controls.Add(d);
                    }));
                }
            }
        }

        private void RefreshComponentsCatalogoAndCBX()
        {
            MySqlDataReader reader;
            List<Componenti> l = new List<Componenti>();
            Componenti c = new Componenti();

            MySqlConnection conn = Metodi.ConnectToDatabase();
            string query = $"SELECT * From componente";
            MySqlCommand command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                c = new Componenti(reader.GetString(2), reader.GetString(1), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(0), 0);
                l.Add(c);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = l;
            Invoke(new Action(() =>
            {
                dgvComponenti.DataSource = bs;

                int app = cbBxFiltroMagazzinoCodice.SelectedIndex;
                cbBxFiltroMagazzinoCodice.DataSource = l.Select(x => x.Codice).Distinct().ToList();
                if (cbBxFiltroMagazzinoCodice.Items.Count > app) cbBxFiltroMagazzinoCodice.SelectedIndex = app;

                dgvComponenti.Columns["Quantita"].Visible = false;
            }));
            Registro.ComponentiAttuali = l;
        }

        private void UpdateComboboxTabc2MarcType()
        {
            List<string> brands = new List<string>();
            List<string> types = new List<string>();
            string query = "SELECT * FROM marca_componente";

            MySqlCommand FetchTypes = new MySqlCommand(query, Metodi.ConnectToDatabase());
            MySqlDataReader res = FetchTypes.ExecuteReader();

            while (res.Read())
            {
                brands.Add(res.GetString(0));
            }

            query = "SELECT * FROM tipo_componente";

            FetchTypes = new MySqlCommand(query, Metodi.ConnectToDatabase());
            res = FetchTypes.ExecuteReader();

            while (res.Read())
            {
                types.Add(res.GetString(0));
            }

            int app = 0;
            Invoke(new Action(() =>
            {
                app = cbxAggiungiComponenteTipo.SelectedIndex;
                cbxAggiungiComponenteTipo.DataSource = types;
                if (cbxAggiungiComponenteTipo.Items.Count > app) cbxAggiungiComponenteTipo.SelectedIndex = app;

                app = cbxAggiungiMarcaComponente.SelectedIndex;
                cbxAggiungiMarcaComponente.DataSource = brands;
                if (cbxAggiungiMarcaComponente.Items.Count > app) cbxAggiungiMarcaComponente.SelectedIndex = app;

                app = cbxModificaMarcaComponente.SelectedIndex;
                cbxModificaMarcaComponente.DataSource = brands;
                if (cbxModificaMarcaComponente.Items.Count > app) cbxModificaMarcaComponente.SelectedIndex = app;

                app = cbxModificaTipoComponente.SelectedIndex;
                cbxModificaTipoComponente.DataSource = types;
                if (cbxModificaTipoComponente.Items.Count > app) cbxModificaTipoComponente.SelectedIndex = app;

                app = cbBxFiltroMagazzinoMarca.SelectedIndex;
                cbBxFiltroMagazzinoMarca.DataSource = brands;
                if (cbBxFiltroMagazzinoMarca.Items.Count > app) cbBxFiltroMagazzinoMarca.SelectedIndex = app;

                app = cbBxFiltroMagazzinoTipo.SelectedIndex;
                cbBxFiltroMagazzinoTipo.DataSource = types;
                if (cbBxFiltroMagazzinoTipo.Items.Count > app) cbBxFiltroMagazzinoTipo.SelectedIndex = app;
            }));
        }

        private void AggiornaComboBox() //Da mettere in modifica ed elimina cliente
        {
            if (Registro.DizClienti != null)
            {
                cbBxTrovaPerNome.Items.Clear();
                cbBxTrovaPerMail.Items.Clear();
                cbBxTrovaPerPRif.Items.Clear();
                cbBxTrovaPerMatricola.Items.Clear();

                cBxAggiungiEventoCliente.Items.Clear();
                cBxAggiungiEventoMacchine.Items.Clear();
                cBxModificaEventoCliente.Items.Clear();
                cBxModificaEventoMacchine.Items.Clear();

                cbBxSearchEventoCliente.Items.Clear();
                cbBxSearchEventoMatricola.Items.Clear();

                foreach (KeyValuePair<string, Cliente> kv in Registro.DizClienti)
                {
                    cbBxTrovaPerNome.Items.Add(kv.Key);
                    cbBxTrovaPerPRif.Items.Add(kv.Value._Ref);
                    cbBxTrovaPerMail.Items.Add(kv.Value._Email);

                    foreach (Macchina macchina in kv.Value._Mach)
                    {
                        cbBxTrovaPerMatricola.Items.Add(macchina._Marca + "/" + macchina._Modello + "/" + macchina._Matricola);
                        cBxAggiungiEventoMacchine.Items.Add(macchina._Marca + "/" + macchina._Modello + "/" + macchina._Matricola);
                        cBxModificaEventoMacchine.Items.Add(macchina._Marca + "/" + macchina._Modello + "/" + macchina._Matricola);
                        cbBxSearchEventoMatricola.Items.Add(macchina._Marca + "/" + macchina._Modello + "/" + macchina._Matricola);
                    }

                    cBxAggiungiEventoCliente.Items.Add(kv.Key);
                    cBxModificaEventoCliente.Items.Add(kv.Key);
                    cbBxSearchEventoCliente.Items.Add(kv.Key);
                }

                cbBxTrovaPerNome.Refresh();
                cbBxTrovaPerMail.Refresh();
                cbBxTrovaPerPRif.Refresh();
                cbBxTrovaPerMatricola.Refresh();

                cBxAggiungiEventoCliente.Refresh();
                cBxAggiungiEventoMacchine.Refresh();
                cBxModificaEventoCliente.Refresh();
                cBxModificaEventoMacchine.Refresh();

                cbBxSearchEventoCliente.Refresh();
                cbBxSearchEventoMatricola.Refresh();
            }
        }

        private void HideColumnsEventi()
        {
            dgvEventi.Columns["NomeCliente"].HeaderText = "Nome Cliente";
            dgvEventi.Columns["Giorno"].Visible = false;
            dgvEventi.Columns["note"].Visible = false;
            dgvEventi.Columns["ID"].Visible = false;
            dgvEventi.Columns["NumEventi"].Visible = false;
            //dgwEventi.Columns["Macchina"].Visible = false;
        }

        private void HideColumnsClienti()
        {
            dgvVisualizzaClienti.Columns["_PartIVA"].Visible = false;
            dgvVisualizzaClienti.Columns["_Ref"].Visible = false;

            dgvVisualizzaClienti.Columns["_Nome"].HeaderText = "Nome";
            dgvVisualizzaClienti.Columns["_Indirizzo"].HeaderText = "Indirizzo";
            dgvVisualizzaClienti.Columns["_Telefono"].HeaderText = "Telefono";
            dgvVisualizzaClienti.Columns["_Email"].HeaderText = "Email";
        }

        private void AriCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            dgvEventi.CurrentCell = null;
            lblEventi.Text = "Eventi del: " + ariCalendario.SelectionStart.Day + "/" + ariCalendario.SelectionStart.Month + "/" + ariCalendario.SelectionStart.Year;
            SelectedDate = ariCalendario.SelectionStart;
            btnAdd.Enabled = true;

            if (Registro.DizGiorni != null && Registro.DizGiorni.ContainsKey(SelectedDate))
            {
                dgvEventi.DataSource = Registro.DizGiorni[SelectedDate];
                HideColumnsEventi();
                //ResizeDetilsCose();
            }
            else
            {
                dgvEventi.DataSource = null;
            }
        }

        private void GeneraScadenze()
        {
            Notifica notifica = new Notifica();

            try
            {
                if (Registro.DizGiorni.ContainsKey(DateTime.Now.Date.AddDays(1)))
                {
                    foreach (Evento ev in Registro.DizGiorni[DateTime.Now.Date.AddDays(1)])
                    {
                        Notifica n = new Notifica(ev, this);
                        n.Show("Cliente:" + ev.NomeCliente + "\nMacchina:" + ev.Macchina, Notifica.enmType.Scadenza);
                    }
                }
            }
            catch (Exception e)
            {
                notifica.Show(e.Message, Notifica.enmType.Error);
            }
        }

        public void SetCalendarValue(Evento ev)
        {
            ariCalendario.SelectionStart = ev.Giorno;
            int i = 0;
            foreach (Evento evnt in Registro.DizGiorni[ev.Giorno])
            {
                if (evnt.ID == ev.ID)
                {
                    break;
                }
                i++;
            }
            dgvEventi.CurrentCell = dgvEventi[3, i];
            Rectangle re = dgvEventi.GetCellDisplayRectangle(3, i, false);
            p.Y = dgvEventi.Location.Y + Location.Y + (Width / 30) + re.Y + re.Height;
            p.X = dgvEventi.Location.X + Location.X + dgvEventi.RowHeadersWidth + 30;
            Cursor.Position = p;
        }

        private void BtnExitLegend_Click(object sender, EventArgs e)
        {
            gbxLegenda.Enabled = false;
            gbxLegenda.Visible = false;
        }

        private void BtnLegenda_Click(object sender, EventArgs e)
        {
            gbxLegenda.Enabled = true;
            gbxLegenda.Visible = true;
        }

        private void dgwEventi_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (Registro.DizGiorni.ContainsKey(SelectedDate) && dgvEventi.DataSource == Registro.DizGiorni[SelectedDate])
            {
                if (e.RowIndex != -1 && e.Value != null && e.ColumnIndex == 6)
                {
                    if (!e.Handled)
                    {
                        e.Handled = true;
                        e.PaintBackground(e.CellBounds, dgvEventi.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected);
                    }
                    if ((e.PaintParts & DataGridViewPaintParts.ContentForeground) != DataGridViewPaintParts.None)
                    {
                        string text = e.Value.ToString();
                        Size fullsize = TextRenderer.MeasureText(text, e.CellStyle.Font);
                        Rectangle rect1 = new Rectangle(e.CellBounds.Location, e.CellBounds.Size);
                        Size size;
                        Color appcolore;

                        for (int i = 0; i < text.Length; i++)
                        {
                            string textPart = text.Substring(i, 1);
                            size = TextRenderer.MeasureText(textPart, e.CellStyle.Font);

                            switch (Registro.DizGiorni[SelectedDate][e.RowIndex].Interventi[i])
                            {
                                case InterventiPoss.Manut_Completa:
                                    appcolore = Color.Red;
                                    break;

                                case InterventiPoss.Manut_Parziale:
                                    appcolore = Color.Orange;
                                    break;

                                case InterventiPoss.Controllo_Generale:
                                    appcolore = Color.Yellow;
                                    break;

                                case InterventiPoss.Sost_Elementi_Filtrantiecc:
                                    appcolore = Color.Blue;
                                    break;

                                case InterventiPoss.Controllo_Fgas:
                                    appcolore = Color.Green;
                                    break;

                                default:
                                    appcolore = Color.Black;
                                    break;
                            }
                            using (Brush cellForeBrush = new SolidBrush(appcolore))
                            {
                                e.Graphics.DrawString(textPart, e.CellStyle.Font, cellForeBrush, rect1);
                            }
                            Size previousSize = size;
                            rect1.X += size.Width / 2;
                            rect1.Width = size.Width;
                        }
                    }
                }
            }
            else
            {
                if (e.RowIndex != -1 && e.Value != null && e.ColumnIndex == 6)
                {
                    if (!e.Handled)
                    {
                        e.Handled = true;
                        e.PaintBackground(e.CellBounds, dgvEventi.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected);
                    }
                    if ((e.PaintParts & DataGridViewPaintParts.ContentForeground) != DataGridViewPaintParts.None)
                    {
                        string text = e.Value.ToString();
                        Size fullsize = TextRenderer.MeasureText(text, e.CellStyle.Font);
                        Rectangle rect1 = new Rectangle(e.CellBounds.Location, e.CellBounds.Size);
                        Size size;
                        Color appcolore;

                        for (int i = 0; i < text.Length; i++)
                        {
                            string textPart = text.Substring(i, 1);
                            size = TextRenderer.MeasureText(textPart, e.CellStyle.Font);

                            List<Evento> momentlist = (List<Evento>)dgvEventi.DataSource;

                            switch (momentlist[e.RowIndex].Interventi[i])
                            {
                                case InterventiPoss.Manut_Completa:
                                    appcolore = Color.Red;
                                    break;

                                case InterventiPoss.Manut_Parziale:
                                    appcolore = Color.Orange;
                                    break;

                                case InterventiPoss.Controllo_Generale:
                                    appcolore = Color.Yellow;
                                    break;

                                case InterventiPoss.Sost_Elementi_Filtrantiecc:
                                    appcolore = Color.Blue;
                                    break;

                                case InterventiPoss.Controllo_Fgas:
                                    appcolore = Color.Green;
                                    break;

                                default:
                                    appcolore = Color.Black;
                                    break;
                            }

                            using (Brush cellForeBrush = new SolidBrush(appcolore))
                            {
                                e.Graphics.DrawString(textPart, e.CellStyle.Font, cellForeBrush, rect1);
                            }
                            Size previousSize = size;
                            rect1.X += size.Width / 2;
                            rect1.Width = size.Width;
                        }
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (gbxAggiungi.Visible == true)
            {
                gbxAggiungi.Visible = false;
                gbxAggiungi.Enabled = false;
            }
            else
            {
                gbxAggiungi.Visible = true;
                gbxAggiungi.Enabled = true;
            }
        }

        private void BtnExitAggiungi_Click(object sender, EventArgs e)
        {
            gbxAggiungi.Visible = false;
            gbxAggiungi.Enabled = false;
        }


        private void btnAggiungiAddintervento_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBoxAggiungi.Text))
            {
                listViewAggiungiIntervento.Items.Add(comboBoxAggiungi.Text);
            }
        }

        private void btnAggiungiRimuoviintervento_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewAggiungiIntervento.SelectedItems)
            {
                listViewAggiungiIntervento.Items.Remove(item);
            }
        }

        private void btnConfermaAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Registro.DizClienti.ContainsKey(cBxAggiungiEventoCliente.Text))
                {
                    throw new Exception("Inserire Cliente Valido");
                }
                bool checkmacchina = false;
                foreach (Macchina m in Registro.DizClienti[cBxAggiungiEventoCliente.Text]._Mach)
                {
                    if (m._Marca + "/" + m._Modello + "/" + m._Matricola == cBxAggiungiEventoMacchine.Text)
                    {
                        checkmacchina = true;
                    }
                }
                if (checkmacchina == false)
                {
                    throw new Exception("Inserire macchina valida");
                }
                List<InterventiPoss> interventis = new List<InterventiPoss>();
                foreach (ListViewItem item in listViewAggiungiIntervento.Items)
                {
                    switch (item.Text)
                    {
                        case "Manut_Completa":
                            interventis.Add(InterventiPoss.Manut_Completa);
                            break;

                        case "Manut_Parziale":
                            interventis.Add(InterventiPoss.Manut_Parziale);
                            break;

                        case "Controllo_Generale":
                            interventis.Add(InterventiPoss.Controllo_Generale);
                            break;

                        case "Sost_Elementi_Filtrantiecc":
                            interventis.Add(InterventiPoss.Sost_Elementi_Filtrantiecc);
                            break;

                        case "Controllo_Fgas":
                            interventis.Add(InterventiPoss.Controllo_Fgas);
                            break;

                        default:
                            throw new Exception("Intervento non valido");
                    }
                }
                if (SelectedDate.Date < DateTime.Now.Date)
                {
                    throw new Exception("Data passata.");
                }
                //Errore
                //Evento app = new Evento(SelectedDate, cBxAggiungiEventoCliente.Text, cBxAggiungiEventoMacchine.Text, interventis, rtbAggiungiNote.Text);
                //r.AddEvento(app);

                dgvEventi.DataSource = null;
                dgvEventi.DataSource = Registro.DizGiorni[SelectedDate];
                HideColumnsEventi();
                dgvEventi.Refresh();

                //Interazione DB
                //r.salvaEventi();
                //r.inviaSalvataggi();

                Notifica notifica = new Notifica();
                notifica.Show("Evento aggiunto correttamente!", Notifica.enmType.Success);
            }
            catch (Exception exc)
            {
                Notifica notifica = new Notifica();
                if (exc.Message == "Data passata.")
                {
                    notifica.Show("ACHIEVEMENT UNLOCKED:\n BACK TO THE FUTURE \n(Questo è un errore comunque :D)", Notifica.enmType.TimeTravel);
                }
                else
                {
                    notifica.Show(exc.Message, Notifica.enmType.Warning);
                }
            }
        }

        private void dgwEventi_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Registro.DizClienti.ContainsKey(dgvEventi[3, e.RowIndex].Value.ToString()))
            {
                if (e.ColumnIndex == 3)
                {
                    gBxDettagliCliente.Visible = true;
                    gBxDettagliCliente.Enabled = true;
                    Rectangle re = dgvEventi.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    if (re.Y > dgvEventi.Height / 2)
                    {
                        p.Y = dgvEventi.Location.Y + re.Y - gBxDettagliCliente.Height;
                    }
                    else
                    {
                        p.Y = dgvEventi.Location.Y + re.Y + re.Height;
                    }
                    p.X = gbxDettagli.Location.X;
                    gBxDettagliCliente.Location = p;

                    txBxDettagliClienteTel.Text = Registro.DizClienti[dgvEventi[3, e.RowIndex].Value.ToString()]._Telefono;
                    txBxDettagliClienteMail.Text = Registro.DizClienti[dgvEventi[3, e.RowIndex].Value.ToString()]._Email;
                    txBxDettagliClienteIndirizzo.Text = Registro.DizClienti[dgvEventi[3, e.RowIndex].Value.ToString()]._Indirizzo;
                    txBxDettagliClienteIva.Text = Registro.DizClienti[dgvEventi[3, e.RowIndex].Value.ToString()]._PartIVA;
                    txBxDettagliClientePrif.Text = Registro.DizClienti[dgvEventi[3, e.RowIndex].Value.ToString()]._Ref;
                }
                else if (e.ColumnIndex == 4)
                {
                    gBxDettagliMacchinaAccessorio.Visible = true;
                    gBxDettagliMacchinaAccessorio.Enabled = true;
                    Rectangle re = dgvEventi.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    if (re.Y > dgvEventi.Height / 2)
                    {
                        p.Y = dgvEventi.Location.Y + re.Y - gBxDettagliMacchinaAccessorio.Height;
                    }
                    else
                    {
                        p.Y = dgvEventi.Location.Y + re.Y + re.Height;
                    }
                    p.X = gbxDettagli.Location.X;
                    gBxDettagliMacchinaAccessorio.Location = p;

                    //lvwDettagliComponenti.Items.Clear();

                    foreach (Macchina m in Registro.DizClienti[dgvEventi[3, e.RowIndex].Value.ToString()]._Mach)
                    {
                        if (dgvEventi[4, e.RowIndex].Value.ToString() == m._Marca + "/" + m._Modello + "/" + m._Matricola)
                        {
                            rtbNoteMacchinaAccessorio.Text = m._Note;
                            foreach (Componenti c in m._Componenti)
                            {
                                ListViewItem item = new ListViewItem
                                {
                                    Text = c.Tipo
                                };
                                item.SubItems.Add(c.Codice);
                                //lvwDettagliComponenti.Items.Add(item);
                            }
                        }
                    }
                }
                else if (e.ColumnIndex == 6)
                {
                    gbxDettagli.Visible = true;
                    gbxDettagli.Enabled = true;
                    Rectangle re = dgvEventi.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    if (re.Y > dgvEventi.Height / 2)
                    {
                        p.Y = dgvEventi.Location.Y + re.Y - gbxDettagli.Height;
                    }
                    else
                    {
                        p.Y = dgvEventi.Location.Y + re.Y + re.Height;
                    }
                    p.X = gbxDettagli.Location.X;
                    gbxDettagli.Location = p;

                    if (Registro.DizGiorni != null && Registro.DizGiorni.ContainsKey(SelectedDate) && dgvEventi.DataSource == Registro.DizGiorni[SelectedDate])
                    {
                        rtbNoteDettagli.Text = Registro.DizGiorni[SelectedDate][e.RowIndex].Note;
                    }
                    else
                    {
                        List<Evento> momentlist = (List<Evento>)dgvEventi.DataSource;
                        rtbNoteDettagli.Text = momentlist[e.RowIndex].Note;
                    }
                }
            }
            else if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3)
                {
                    gBxDettagliCliente.Visible = true;
                    gBxDettagliCliente.Enabled = true;
                    Rectangle re = dgvEventi.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    if (re.Y > dgvEventi.Height / 2)
                    {
                        p.Y = dgvEventi.Location.Y + re.Y - gBxDettagliCliente.Height;
                    }
                    else
                    {
                        p.Y = dgvEventi.Location.Y + re.Y + re.Height;
                    }
                    p.X = gbxDettagli.Location.X;
                    gBxDettagliCliente.Location = p;

                    txBxDettagliClienteTel.Text = "Cliente Eliminato";
                    txBxDettagliClienteMail.Text = "Cliente Eliminato";
                    txBxDettagliClienteIndirizzo.Text = "Cliente Eliminato";
                    txBxDettagliClienteIva.Text = "Cliente Eliminato";
                    txBxDettagliClientePrif.Text = "Cliente Eliminato";
                }
                else if (e.ColumnIndex == 6)
                {
                    gbxDettagli.Visible = true;
                    gbxDettagli.Enabled = true;
                    Rectangle re = dgvEventi.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    if (re.Y > dgvEventi.Height / 2)
                    {
                        p.Y = dgvEventi.Location.Y + re.Y - gbxDettagli.Height;
                    }
                    else
                    {
                        p.Y = dgvEventi.Location.Y + re.Y + re.Height;
                    }
                    p.X = gbxDettagli.Location.X;
                    gbxDettagli.Location = p;

                    if (Registro.DizGiorni != null && Registro.DizGiorni.ContainsKey(SelectedDate) && dgvEventi.DataSource == Registro.DizGiorni[SelectedDate])
                    {
                        rtbNoteDettagli.Text = Registro.DizGiorni[SelectedDate][e.RowIndex].Note;
                    }
                    else
                    {
                        List<Evento> momentlist = (List<Evento>)dgvEventi.DataSource;
                        rtbNoteDettagli.Text = momentlist[e.RowIndex].Note;
                    }
                }
            }
        }

        private void dgwEventi_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                gBxDettagliCliente.Visible = false;
                gBxDettagliCliente.Enabled = false;
            }
            else if (e.ColumnIndex == 4)
            {
                if (dgvEventi.Rows.Count > 0)
                {
                    if (Form.ActiveForm.PointToClient(Cursor.Position).Y - dgvEventi.Rows[0].Height > gBxDettagliMacchinaAccessorio.Bounds.Y && Form.ActiveForm.PointToClient(Cursor.Position).Y - dgvEventi.Rows[0].Height < gBxDettagliMacchinaAccessorio.Bounds.Y + 20)
                    {
                    }
                    else
                    {
                        gBxDettagliMacchinaAccessorio.Visible = false;
                        gBxDettagliMacchinaAccessorio.Enabled = false;
                    }
                }
            }
            else if (e.ColumnIndex == 6)
            {
                gbxDettagli.Visible = false;
                gbxDettagli.Enabled = false;
            }
        }

        private void dgwEventi_MouseEnter(object sender, EventArgs e)
        {
            ariCalendario.Enabled = false;
        }

        private void dgwEventi_MouseLeave(object sender, EventArgs e)
        {
            ariCalendario.Enabled = true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (gbxModifica.Visible == false)
            {
                gbxModifica.Enabled = true;
                gbxModifica.Visible = true;
            }
            else
            {
                gbxModifica.Enabled = false;
                gbxModifica.Visible = false;
            }
        }

        private void dgwEventi_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            Notifica notifica = new Notifica();

            try
            {
                if (Registro.DizGiorni.ContainsKey(SelectedDate) && dgvEventi.DataSource == Registro.DizGiorni[SelectedDate])
                {
                    if (e.Cell.ColumnIndex == 3 && Registro.DizGiorni.ContainsKey(SelectedDate))
                    {
                        cBxModificaEventoCliente.Text = Registro.DizGiorni[SelectedDate][e.Cell.RowIndex].NomeCliente;
                        rtbModificaNote.Text = Registro.DizGiorni[SelectedDate][e.Cell.RowIndex].Note;
                        //errore
                        // cBxModificaEventoMacchine.Text = r.DizGiorni[SelectedDate][e.Cell.RowIndex].Macchina;

                        listViewModificaOperazioni.Clear();

                        foreach (object obj in Registro.DizGiorni[SelectedDate][e.Cell.RowIndex].Interventi)
                        {
                            listViewModificaOperazioni.Items.Add(obj.ToString());
                        }

                        btnModify.Enabled = true;
                        btnRemove.Enabled = true;
                    }
                    else
                    {
                        btnModify.Enabled = false;
                        btnRemove.Enabled = false;
                    }
                }
                else
                {
                    if (e.Cell.ColumnIndex == 3)
                    {
                        cBxModificaEventoCliente.Text = dgvEventi[3, e.Cell.RowIndex].Value.ToString();
                        rtbModificaNote.Text = dgvEventi["Note", e.Cell.RowIndex].Value.ToString();
                        cBxModificaEventoMacchine.Text = dgvEventi[4, e.Cell.RowIndex].Value.ToString();

                        listViewModificaOperazioni.Clear();

                        List<Evento> applist = (List<Evento>)dgvEventi.DataSource;

                        foreach (InterventiPoss inter in applist[e.Cell.RowIndex].Interventi)
                        {
                            listViewModificaOperazioni.Items.Add(inter.ToString());
                        }

                        btnModify.Enabled = true;
                        btnRemove.Enabled = true;
                    }
                    else
                    {
                        btnModify.Enabled = false;
                        btnRemove.Enabled = false;
                    }
                }
            }
            catch (ArgumentNullException exc)
            {
                notifica.Show(exc.Message, Notifica.enmType.Warning);
            }
        }

        private void btnConfermaModifica_Click(object sender, EventArgs e)
        {
            Notifica notifica = new Notifica();

            try
            {
                if (dgvEventi.CurrentCell == null)
                {
                    throw new Exception("Selezionare un evento \n per modificarlo");
                }
                if (!Registro.DizClienti.ContainsKey(cBxModificaEventoCliente.Text))
                {
                    throw new Exception("Inserire Cliente Valido");
                }
                bool checkmacchina = false;
                foreach (Macchina m in Registro.DizClienti[cBxModificaEventoCliente.Text]._Mach)
                {
                    if (m._Marca + "/" + m._Modello + "/" + m._Matricola == cBxModificaEventoMacchine.Text)
                    {
                        checkmacchina = true;
                    }
                }
                if (checkmacchina == false)
                {
                    throw new Exception("Inserire macchina valida");
                }
                List<InterventiPoss> interventis = new List<InterventiPoss>();

                foreach (ListViewItem item in listViewModificaOperazioni.Items)
                {
                    switch (item.Text)
                    {
                        case "Manut_Completa":
                            interventis.Add(InterventiPoss.Manut_Completa);
                            break;

                        case "Manut_Parziale":
                            interventis.Add(InterventiPoss.Manut_Parziale);
                            break;

                        case "Controllo_Generale":
                            interventis.Add(InterventiPoss.Controllo_Generale);
                            break;

                        case "Sost_Elementi_Filtrantiecc":
                            interventis.Add(InterventiPoss.Sost_Elementi_Filtrantiecc);
                            break;

                        case "Controllo_Fgas":
                            interventis.Add(InterventiPoss.Controllo_Fgas);
                            break;

                        default:
                            throw new Exception("Intervento non valido");
                    }
                }
                //errore
                // Evento ev = new Evento(SelectedDate, cBxModificaEventoCliente.Text, cBxModificaEventoMacchine.Text, interventis, rtbModificaNote.Text);
                /*
                 Evento.numEventi--;
                 List<Evento> momentlist = (List<Evento>)dgwEventi.DataSource;
                 if (r.DizGiorni.ContainsKey(SelectedDate) && dgwEventi.DataSource == r.DizGiorni[SelectedDate])
                 {
                     r.ModifyEvento(ev, r.DizGiorni[SelectedDate][dgwEventi.CurrentCell.RowIndex]);
                 }
                 else
                 {
                     r.ModifyEvento(ev, momentlist[dgwEventi.CurrentCell.RowIndex]);
                     momentlist.RemoveAt(dgwEventi.CurrentCell.RowIndex);
                     momentlist.Add(ev);
                 }
                 //Salvataggio
                 r.salvaEventi();
                 r.inviaSalvataggi();

                 dgwEventi.DataSource = null;
                 if (r.DizGiorni.ContainsKey(SelectedDate) && dgwEventi.DataSource == r.DizGiorni[SelectedDate])
                 {
                     dgwEventi.DataSource = r.DizGiorni[SelectedDate];
                     HideColumnsEventi();
                 }
                 else
                 {
                     dgwEventi.DataSource = momentlist;
                     HideColumnsEventi();
                 }
                */
                notifica.Show("Evento modificato correttamente!", Notifica.enmType.Success);
            }
            catch (Exception exc)
            {
                notifica.Show(exc.Message, Notifica.enmType.Warning);
            }
        }

        private void btnExitModifica_Click(object sender, EventArgs e)
        {
            gbxModifica.Enabled = false;
            gbxModifica.Visible = false;
        }

        private void btnModificaAggiungiOperazioni_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbxModificaListaOperazioni.Text))
            {
                listViewModificaOperazioni.Items.Add(cbxModificaListaOperazioni.Text);
            }
        }

        private void btnModificaRimuoviOperazioni_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewModificaOperazioni.SelectedItems)
            {
                listViewModificaOperazioni.Items.Remove(item);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Notifica notifica = new Notifica();

            try
            {
                int app = dgvEventi.CurrentCell.RowIndex;
                List<Evento> momentList = (List<Evento>)dgvEventi.DataSource;
                bool filtrato = false;

                if (Registro.DizGiorni.ContainsKey(SelectedDate) && dgvEventi.DataSource == Registro.DizGiorni[SelectedDate])
                {
                    dgvEventi.DataSource = null;
                    Registro.RemoveEvento(Registro.DizGiorni[SelectedDate][app]);
                }
                else
                {
                    filtrato = true;
                    foreach (Evento ev in Registro.DizGiorni[(DateTime)dgvEventi["Giorno", app].Value])
                    {
                        if (ev.ID == momentList[app].ID)
                        {
                            dgvEventi.DataSource = null;
                            Registro.RemoveEvento(ev);
                            momentList.RemoveAt(app);
                            break;
                        }
                    }
                }

                //Salvataggio
                //Interazione DB
                //r.salvaEventi();
                //r.inviaSalvataggi();

                if (Registro.DizGiorni.ContainsKey(SelectedDate) && filtrato == false)
                {
                    dgvEventi.DataSource = Registro.DizGiorni[SelectedDate];
                    HideColumnsEventi();
                    ariCalendario.SelectionStart = SelectedDate.AddDays(1);
                    ariCalendario.SelectionStart = SelectedDate.AddDays(-1);
                }
                else
                {
                    dgvEventi.DataSource = momentList;
                    HideColumnsEventi();
                    dgvEventi.Columns["Giorno"].Visible = true;
                }

                notifica.Show("Evento eliminato correttamente!", Notifica.enmType.Success);
            }
            catch (Exception exc)
            {
                notifica.Show(exc.Message, Notifica.enmType.Warning);
            }
        }

        private void btnClientiAddCustomer_Click(object sender, EventArgs e)
        {
            if (gBxClientiAggiungiCliente.Visible == true)
            {
                gBxClientiAggiungiCliente.SendToBack();
                gBxClientiAggiungiCliente.Visible = false;
            }
            else
            {
                gBxClientiAggiungiCliente.BringToFront();
                gBxClientiAggiungiCliente.Visible = true;
                gBxClientiModificaClienti.Visible = false;
            }
        }

        private void btnAggiungiClienteChiudi_Click(object sender, EventArgs e)
        {
            gBxClientiAggiungiCliente.Visible = false;
        }

        private void btnConfermaAggiungiMacchina_Click(object sender, EventArgs e)
        {
            ///INDICI TABELLA MACCHINA
            ///0: marca_macchina
            ///1: modello_macchina
            ///2: matricola_macchina
            ///3: noleggio_macchina
            ///4: id_cliente
            ///5: note_macchina

            Notifica notifica = new Notifica();
            try
            {
                if (!Metodi.AreThereAnyEmptyTextBoxes(gBxAggiungiMacchina.Controls))
                {


                    //listaMacchine = new List<Macchina>();

                    List<Componenti> componenti = new List<Componenti>();

                    foreach (DataGridViewRow dgvr in dgvComponentiAggiungiMacchina.Rows)
                    {
                        componenti.Add(dgvr.DataBoundItem as Componenti);
                    }

                    Macchina macchina = new Macchina(0, cbBxAggiungiMacchinaMarca.Text, txBxAggiungiMacchinaModello.Text,
                        txBxAggiungiMacchinaMatricola.Text, componenti, chBxAggiungiMacchinaNoleggio.Checked, rtbAggiungiMacchinaNote.Text);

                    List<Macchina> macchineCliente = new List<Macchina>();

                    foreach (DataGridViewRow dgvr in dgvAggiungiClientiMacchine.Rows)
                    {
                        macchineCliente.Add(dgvr.DataBoundItem as Macchina);
                    }

                    macchineCliente.Add(macchina);

                    BindingSource bs = new BindingSource()
                    {
                        DataSource = macchineCliente
                    };

                    dgvAggiungiClientiMacchine.DataSource = bs;

                    dgvAggiungiClientiMacchine.Columns["_cliente"].Visible = false;
                    dgvAggiungiClientiMacchine.Columns["_Marca"].HeaderText = "Marca";
                    dgvAggiungiClientiMacchine.Columns["_Modello"].HeaderText = "Modello";
                    dgvAggiungiClientiMacchine.Columns["_Matricola"].HeaderText = "Matricola";
                    dgvAggiungiClientiMacchine.Columns["_Noleggio"].HeaderText = "Noleggio";
                    dgvAggiungiClientiMacchine.Columns["_Note"].HeaderText = "Note";

                    foreach (Control c in gBxAggiungiMacchina.Controls)
                    {
                        if(c is TextBox tb)
                        {
                            tb.Clear();
                        }
                    }
                    dgvComponentiAggiungiMacchina.DataSource = null;
                    rtbAggiungiMacchinaNote.Clear();

                    gBxAggiungiMacchina.Visible = false;
                }
                else
                {
                    throw new ArgumentNullException();
                }
                //MySqlConnection conn = Metodi.ConnectToDatabase();
                //string query = $"INSERT INTO macchina VALUES('{txBxAggiungiMacchinaMarca.Text}', " +
                //    $"'{txBxAggiungiMacchinaModello.Text}', " +
                //    $"'{txBxAggiungiMacchinaMatricola.Text}', " +
                //    $"'{chBxAggiungiMacchinaNoleggio.Checked}', " +
                //    $"'{Metodi.GetCustomerID(dgvVisualizzaClienti.CurrentRow)}'" +
                //    $"'{rtbAggiungiMacchinaNote.Text}')";
                //MySqlCommand cmd = new MySqlCommand(query, conn);
                //cmd.ExecuteNonQuery();
                //conn.Close();

                //conn = Metodi.ConnectToDatabase();
                //foreach (Componenti c in componenti)
                //{
                //    query = $"INSERT INTO componenti_macchina VALUES('{c.Codice}', " +
                //                        $"'{c.Marca}', " +
                //                        $"'{txBxAggiungiMacchinaMarca.Text}', " +
                //                        $"'{txBxAggiungiMacchinaMatricola.Text}'";
                //    cmd = new MySqlCommand(query, conn);
                //    cmd.ExecuteNonQuery();
                //}
                //conn.Close();

                //listaMacchine.Add(macchina);

                //ListViewItem items = new ListViewItem
                //{
                //    Text = macchina._Marca
                //};
                //items.SubItems.Add(macchina._Modello);
                //items.SubItems.Add(macchina._Matricola);

                //BindingSource bs = new BindingSource()
                //{
                //    DataSource = items
                //};

                //if (gBxClientiModificaClienti.Visible == true)
                //{
                //    dgvModificaCliente.DataSource = bs;
                //}
                //else
                //{
                //    dgvAggiungiClientiMacchine.DataSource = bs;
                //}

                //notifica.Show("Macchina aggiunta correttamente!", Notifica.enmType.Success); 
                //macchina = null;
                //gBxAggiungiMacchina.Visible = false;

                //foreach (Control c in gBxAggiungiMacchina.Controls)
                //{
                //    if (c is TextBox || c is ComboBox || c is RichTextBox)
                //    {
                //        c.Text = null;
                //    }

                //    if (c is ListView)
                //    {
                //        ListView listView = (ListView)c;
                //        listView.Items.Clear();
                //    }
                //}
            }
            catch (Exception exc)
            {
                notifica.Show(exc.Message, Notifica.enmType.Warning);
            }
        }

        private void btnAggiungiMacchinaAggiungiComponenti_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbBxAggiungiMacchinaTipoFiltro.Text) && 
                !string.IsNullOrWhiteSpace(cbBxAggiungiMacchinaCodiceFiltro.Text) && 
                !string.IsNullOrWhiteSpace(cbBxAggiungiMacchinaMarcaFiltro.Text))
            {
                Componenti c = Registro.ComponentiAttuali.Find(x => x.Codice == cbBxAggiungiMacchinaCodiceFiltro.Text && x.Marca == cbBxAggiungiMacchinaMarcaFiltro.Text && x.Tipo == cbBxAggiungiMacchinaTipoFiltro.Text);

                List<Componenti> compsInDGV = new List<Componenti>();
                compsInDGV.Add(c);

                foreach(DataGridViewRow dgvr in dgvComponentiAggiungiMacchina.Rows)
                {
                    compsInDGV.Add(dgvr.DataBoundItem as Componenti);
                }

                BindingSource bs = new BindingSource()
                {
                    DataSource = compsInDGV
                };

                dgvComponentiAggiungiMacchina.DataSource = bs;
                dgvComponentiAggiungiMacchina.Columns["Quantita"].Visible = false;
                dgvComponentiAggiungiMacchina.Columns["Soglia"].Visible = false;
                dgvComponentiAggiungiMacchina.Columns["N_ordine"].Visible = false;
            }
        }

        private void btnAggiungiAggiungiMacchina_Click(object sender, EventArgs e)
        {
            if (gBxAggiungiMacchina.Visible == false)
            {
                gBxAggiungiMacchina.Visible = true;
            }
            else
            {
                gBxAggiungiMacchina.Visible = false;
                gBxModificaMacchina.Visible = false;
            }
        }

        private void RefreshCustomers()
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

            List<Componenti> CompL = new List<Componenti>();
            query = $"SELECT * From macchina";
            command = new MySqlCommand(query, conn);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
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
            List<Cliente> l = new List<Cliente>();

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
                Cliente Cl = new Cliente(reader.GetString(1),
                    reader.GetString(4),
                    reader.GetString(2),
                    p_iva,
                    reader.GetString(3),
                    p_rif,
                    macchine.FindAll(x => x._cliente == Metodi.GetCustomerID(reader.GetString(3), reader.GetString(2))));
                l.Add(Cl);
            }

            Registro.ClientiAttuali = l;

            BindingSource bs = new BindingSource()
            {
                DataSource = l
            };
            
            Invoke(new Action(() => { dgvVisualizzaClienti.DataSource = bs; }));
        }

        private void btnConfermaAggiungiCliente_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = null;
            Notifica notifica = new Notifica();

            if (Metodi.CheckForNewCustomersAndNotify()) return;

            try
            {
                List<TextBox> txBxs = new List<TextBox>();
                foreach (Control c in gBxClientiAggiungiCliente.Controls)
                {
                    if (c is TextBox box) 
                    {
                        if (!string.IsNullOrWhiteSpace(c.Tag.ToString()))
                        {
                            if (c.Tag.ToString() == "Mandatory") txBxs.Add(box);
                        } 
                    } 
                }

                if (!Metodi.AreThereAnyEmptyTextBoxes(txBxs))
                {
                    conn = Metodi.ConnectToDatabase();
                    string query = $"INSERT INTO cliente VALUES('{0}', " +
                        $"'{tbxAggiungiClienteNome.Text}', " +
                        $"'{tbxAggiungiClienteTel.Text}', " +
                        $"'{tbxAggiungiClienteMail.Text}', " +
                        $"'{tbxAggiungiClienteInd.Text}'" +
                        ", @IVA" +
                        ", @P_RIF"+
                        ");";
                                              
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IVA", tbxAggiungiClienteIVA.Text);
                    cmd.Parameters.AddWithValue("@P_RIF", tbxAggiungiClientePrif.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    List<Macchina> macc = new List<Macchina>();

                    foreach(DataGridViewRow dgvr in dgvAggiungiClientiMacchine.Rows)
                    {
                        Macchina macchina = dgvr.DataBoundItem as Macchina;
                        macc.Add(macchina);
                        query = $"INSERT INTO macchina VALUES('{macchina._Marca}', " +
                            $"'{macchina._Modello}', " +
                            $"'{macchina._Matricola}', " +
                            $"'{Convert.ToInt32(macchina._Noleggio)}', " +
                            $"'{Metodi.GetCustomerID(tbxAggiungiClienteMail.Text, tbxAggiungiClienteTel.Text)}', " +
                            $"'{macchina._Note}')";
                        cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }

                    foreach(Macchina macchina in macc)
                    {
                        foreach(Componenti comp in macchina._Componenti)
                        {
                            query = $"INSERT INTO componenti_macchina VALUES('{comp.Codice}', " +
                            $"'{comp.Marca}', " +
                            $"'{macchina._Marca}', " +
                            $"'{macchina._Matricola}')";
                            cmd = new MySqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }                       
                    }

                    
                    gBxClientiAggiungiCliente.Visible = false;

                    //threadRicevi.Suspend();
                    dgvVisualizzaClienti.DataSource = null;
                    dgvVisualizzaClienti.DataSource = Registro.DizClienti.Values.ToList();
                    HideColumnsClienti();

                    dgvAggiungiClientiMacchine.DataSource = null;

                    //Interazione DB
                    //r.salvaClienti();
                    //r.inviaSalvataggi();

                    AggiornaComboBox();
                    //threadRicevi.Resume();

                    foreach (Control c in gBxClientiAggiungiCliente.Controls)
                    {
                        if (c is TextBox tb)
                        {
                            tb.Clear();
                        }
                    }

                    gBxAggiungiMacchina.Visible = false;
                    gBxModificaMacchina.Visible = false;

                    RefreshCustomers();
                    //notifica.Show("Cliente aggiunto correttamente!", Notifica.enmType.Success);
                }
                else
                {
                    throw new Exception("Completare tutti i campi obbligatori.");
                }
            }
            catch (Exception exc)
            {
                notifica.Show(exc.Message, Notifica.enmType.Warning);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnChiudigBxAggiungiMacchine_Click(object sender, EventArgs e)
        {
            gBxAggiungiMacchina.Visible = false;
        }


        private void lvwMostraMacchineAccessori_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*lvwMostraComponenti.Items.Clear();

            foreach (ListViewItem item in lvwMostraMacchineAccessori.SelectedItems)
            {
                if (dgvVisualizzaClienti.CurrentCell.ColumnIndex == 0)
                {
                    chbxMostraNoleggio.Checked = Registro.DizClienti[dgvVisualizzaClienti.CurrentCell.Value.ToString()]._Mach[item.Index]._Noleggio;
                    rtbMostraNote.Text = Registro.DizClienti[dgvVisualizzaClienti.CurrentCell.Value.ToString()]._Mach[item.Index]._Note;

                    foreach (Componenti componente in Registro.DizClienti[dgvVisualizzaClienti.CurrentCell.Value.ToString()]._Mach[item.Index]._Componenti)
                    {
                        ListViewItem listViewItem = new ListViewItem
                        {
                            Text = componente.Tipo
                        };
                        listViewItem.SubItems.Add(componente.Codice);

                        lvwMostraComponenti.Items.Add(listViewItem);
                    }
                }
            }*/ //errore
        }

        private void btnAggiungiMacchinaRimuoviComponenti_Click(object sender, EventArgs e)
        {
            //foreach (ListViewItem item in lvAggiungiMacchinaFiltri.SelectedItems)
            //{
            //    lvAggiungiMacchinaFiltri.Items.Remove(item);
            //}
        }

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Caricamento();
            await Task.Run(new Action(() => { RefreshCurrentTab(); }));
        }

        private void btnClientiEditCustomer_Click(object sender, EventArgs e)
        {
            if (gBxClientiModificaClienti.Visible == true)
            {
                gBxClientiModificaClienti.SendToBack();
                gBxClientiModificaClienti.Visible = false;
            }
            else
            {
                gBxClientiModificaClienti.BringToFront();
                gBxClientiModificaClienti.Visible = true;
                gBxClientiAggiungiCliente.Visible = false;
            }
        }

        private void FormCalendario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rdBtnTrovaPerNome_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdBtnTrovaPerNome.Checked)
            {
                cbBxTrovaPerNome.Enabled = false;
                cbBxTrovaPerNome.Text = null;
            }
            else
            {
                cbBxTrovaPerNome.Enabled = true;
            }

            if (!rdBtnTrovaPerPRif.Checked)
            {
                cbBxTrovaPerPRif.Enabled = false;
                cbBxTrovaPerPRif.Text = null;
            }
            else
            {
                cbBxTrovaPerPRif.Enabled = true;
            }

            if (!rdBtnTrovaPerMatricola.Checked)
            {
                cbBxTrovaPerMatricola.Enabled = false;
                cbBxTrovaPerMatricola.Text = null;
            }
            else
            {
                cbBxTrovaPerMatricola.Enabled = true;
            }

            if (!rdBtnTrovaPerMail.Checked)
            {
                cbBxTrovaPerMail.Enabled = false;
                cbBxTrovaPerMail.Text = null;
            }
            else
            {
                cbBxTrovaPerMail.Enabled = true;
            }
        }

        private void rdBtnTrovaPerPRif_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdBtnTrovaPerNome.Checked)
            {
                cbBxTrovaPerNome.Enabled = false;
                cbBxTrovaPerNome.Text = null;
            }
            else
            {
                cbBxTrovaPerNome.Enabled = true;
            }

            if (!rdBtnTrovaPerPRif.Checked)
            {
                cbBxTrovaPerPRif.Enabled = false;
                cbBxTrovaPerPRif.Text = null;
            }
            else
            {
                cbBxTrovaPerPRif.Enabled = true;
            }

            if (!rdBtnTrovaPerMatricola.Checked)
            {
                cbBxTrovaPerMatricola.Enabled = false;
                cbBxTrovaPerMatricola.Text = null;
            }
            else
            {
                cbBxTrovaPerMatricola.Enabled = true;
            }

            if (!rdBtnTrovaPerMail.Checked)
            {
                cbBxTrovaPerMail.Enabled = false;
                cbBxTrovaPerMail.Text = null;
            }
            else
            {
                cbBxTrovaPerMail.Enabled = true;
            }
        }

        private void rdBtnTrovaPerMail_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdBtnTrovaPerNome.Checked)
            {
                cbBxTrovaPerNome.Enabled = false;
                cbBxTrovaPerNome.Text = null;
            }
            else
            {
                cbBxTrovaPerNome.Enabled = true;
            }

            if (!rdBtnTrovaPerPRif.Checked)
            {
                cbBxTrovaPerPRif.Enabled = false;
                cbBxTrovaPerPRif.Text = null;
            }
            else
            {
                cbBxTrovaPerPRif.Enabled = true;
            }

            if (!rdBtnTrovaPerMatricola.Checked)
            {
                cbBxTrovaPerMatricola.Enabled = false;
                cbBxTrovaPerMatricola.Text = null;
            }
            else
            {
                cbBxTrovaPerMatricola.Enabled = true;
            }

            if (!rdBtnTrovaPerMail.Checked)
            {
                cbBxTrovaPerMail.Enabled = false;
                cbBxTrovaPerMail.Text = null;
            }
            else
            {
                cbBxTrovaPerMail.Enabled = true;
            }
        }

        private void rdBtnTrovaPerMatricola_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdBtnTrovaPerNome.Checked)
            {
                cbBxTrovaPerNome.Enabled = false;
                cbBxTrovaPerNome.Text = null;
            }
            else
            {
                cbBxTrovaPerNome.Enabled = true;
            }

            if (!rdBtnTrovaPerPRif.Checked)
            {
                cbBxTrovaPerPRif.Enabled = false;
                cbBxTrovaPerPRif.Text = null;
            }
            else
            {
                cbBxTrovaPerPRif.Enabled = true;
            }

            if (!rdBtnTrovaPerMatricola.Checked)
            {
                cbBxTrovaPerMatricola.Enabled = false;
                cbBxTrovaPerMatricola.Text = null;
            }
            else
            {
                cbBxTrovaPerMatricola.Enabled = true;
            }

            if (!rdBtnTrovaPerMail.Checked)
            {
                cbBxTrovaPerMail.Enabled = false;
                cbBxTrovaPerMail.Text = null;
            }
            else
            {
                cbBxTrovaPerMail.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Notifica notifica = new Notifica();

            if (Registro.DizClienti != null)
            {
                if (rdBtnTrovaPerNome.Checked)
                {
                    List<Cliente> nomeCliente = new List<Cliente>();

                    foreach (KeyValuePair<string, Cliente> kv in Registro.DizClienti)
                    {
                        if (kv.Key == cbBxTrovaPerNome.Text)
                        {
                            nomeCliente.Add(Registro.DizClienti[kv.Key]);
                        }
                    }

                    if (nomeCliente.Count > 0)
                    {
                        dgvVisualizzaClienti.DataSource = null;
                        dgvVisualizzaClienti.DataSource = nomeCliente;
                        HideColumnsClienti();
                        lblClienti.Text = "Filtrato per nome: " + cbBxTrovaPerNome.Text;
                        return;
                    }
                    else
                    {
                        notifica.Show("Nessun risultato trovato.", Notifica.enmType.Warning);
                        return;
                    }
                }
                else if (rdBtnTrovaPerPRif.Checked)
                {
                    List<Cliente> prifCliente = new List<Cliente>();

                    foreach (KeyValuePair<string, Cliente> kv in Registro.DizClienti)
                    {
                        if (kv.Value._Ref == cbBxTrovaPerPRif.Text)
                        {
                            prifCliente.Add(Registro.DizClienti[kv.Key]);
                        }
                    }

                    if (prifCliente.Count > 0)
                    {
                        dgvVisualizzaClienti.DataSource = null;
                        dgvVisualizzaClienti.DataSource = prifCliente;
                        HideColumnsClienti();
                        lblClienti.Text = "Filtrato per P.Rif: " + cbBxTrovaPerPRif.Text;
                        return;
                    }
                    else
                    {
                        notifica.Show("Nessun risultato trovato.", Notifica.enmType.Warning);
                        return;
                    }
                }
                else if (rdBtnTrovaPerMatricola.Checked)
                {
                    List<Cliente> matricolaMacchina = new List<Cliente>();

                    foreach (KeyValuePair<string, Cliente> kv in Registro.DizClienti)
                    {
                        foreach (Macchina macchina in kv.Value._Mach)
                        {
                            if (macchina._Marca + "/" + macchina._Modello + "/" + macchina._Matricola == cbBxTrovaPerMatricola.Text)
                            {
                                matricolaMacchina.Add(Registro.DizClienti[kv.Key]);
                            }
                        }
                    }

                    if (matricolaMacchina.Count > 0)
                    {
                        dgvVisualizzaClienti.DataSource = null;
                        dgvVisualizzaClienti.DataSource = matricolaMacchina;
                        HideColumnsClienti();
                        lblClienti.Text = "Filtrato per macchina: " + cbBxTrovaPerMatricola.Text;
                        return;
                    }
                    else
                    {
                        notifica.Show("Nessun risultato trovato.", Notifica.enmType.Warning);
                        return;
                    }
                }
                else if (rdBtnTrovaPerMail.Checked)
                {
                    List<Cliente> emailCliente = new List<Cliente>();

                    foreach (KeyValuePair<string, Cliente> kv in Registro.DizClienti)
                    {
                        if (kv.Value._Email == cbBxTrovaPerMail.Text)
                        {
                            emailCliente.Add(Registro.DizClienti[kv.Key]);
                        }
                    }

                    if (emailCliente.Count > 0)
                    {
                        dgvVisualizzaClienti.DataSource = null;
                        dgvVisualizzaClienti.DataSource = emailCliente;
                        HideColumnsClienti();
                        lblClienti.Text = "Filtrato per mail: " + cbBxTrovaPerMail.Text;
                        return;
                    }
                    else
                    {
                        notifica.Show("Nessun risultato trovato.", Notifica.enmType.Warning);
                        return;
                    }
                }
            }
        }

        private void dgvVisualizzaClienti_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Notifica notifica = new Notifica();
            notifica.Show(e.ToString(), Notifica.enmType.Error);
        }

        private void btnEliminaFiltridgvVisualizzaClienti_Click(object sender, EventArgs e)
        {
            rdBtnTrovaPerNome.Checked = false;
            rdBtnTrovaPerMail.Checked = false;
            rdBtnTrovaPerMatricola.Checked = false;
            rdBtnTrovaPerPRif.Checked = false;

            dgvVisualizzaClienti.DataSource = Registro.DizClienti.Values.ToList();
            HideColumnsClienti();
            lblClienti.Text = "Tutti i clienti";
        }

        private void cBxAggiungiEventoCliente_TextChanged(object sender, EventArgs e)
        {
            if (Registro.DizClienti.ContainsKey(cBxAggiungiEventoCliente.Text))
            {
                cBxAggiungiEventoMacchine.Items.Clear();
                cBxAggiungiEventoMacchine.Text = null;
                foreach (Macchina macchina in Registro.DizClienti[cBxAggiungiEventoCliente.Text]._Mach)
                {
                    cBxAggiungiEventoMacchine.Items.Add(macchina._Marca + "/" + macchina._Modello + "/" + macchina._Matricola);
                }
                cBxAggiungiEventoMacchine.Refresh();
            }
        }

        private void btnClientiDeleteCustomer_Click(object sender, EventArgs e)
        {
            int cellIndex = dgvVisualizzaClienti.CurrentCell.ColumnIndex;
            string key = dgvVisualizzaClienti.CurrentCell.Value.ToString();
            dgvVisualizzaClienti.CurrentCell = null;
            Notifica notifica = new Notifica();

            if (cellIndex == 0)
            {
                Registro.DizClienti.Remove(key);

                dgvVisualizzaClienti.DataSource = null;
                dgvVisualizzaClienti.DataSource = Registro.DizClienti.Values.ToList();
                HideColumnsClienti();
                AggiornaComboBox();

                //Interazione DB
                //r.salvaClienti();
                //r.inviaSalvataggi();

                notifica.Show("Cliente eliminato correttamente!", Notifica.enmType.Success);
            }
            else
            {
                notifica.Show("Scegliere la cella col nome del cliente.", Notifica.enmType.Warning);
            }
        }

        private void btnAggiungiModificaMacchina_Click(object sender, EventArgs e)
        {
            if (gBxModificaMacchina.Visible == true)
            {
                gBxModificaMacchina.Visible = false;
            }
            else
            {
                gBxModificaMacchina.Visible = true;
                gBxAggiungiMacchina.Visible = false;
            }
        }

        private void btnSearchEvento_Click(object sender, EventArgs e)
        {
            Notifica notifica = new Notifica();

            if (Registro.DizGiorni != null)
            {
                List<Evento> eventiTrovati = new List<Evento>();
                string s = null;

                if (rdBtnSearchEventoCliente.Checked)
                {
                    s = cbBxSearchEventoCliente.Text;

                    foreach (KeyValuePair<DateTime, List<Evento>> kv in Registro.DizGiorni)
                    {
                        foreach (Evento eventoLista in kv.Value)
                        {
                            if (eventoLista.NomeCliente == s)
                            {
                                eventiTrovati.Add(eventoLista);
                            }
                        }
                    }

                    if (eventiTrovati.Count > 0)
                    {
                        lblEventi.Text = "Eventi di: " + eventiTrovati[0].NomeCliente;
                        dgvEventi.DataSource = eventiTrovati;
                        //ariCalendario.SelectionStart = SelectedDate;
                        HideColumnsEventi();
                        dgvEventi.Columns["Giorno"].Visible = true;
                    }
                    else
                    {
                        notifica.Show("Nessun evento del cliente trovato.", Notifica.enmType.Warning);
                    }
                }
                else if (rdBtnSearchEventoMatricola.Checked)
                {
                    s = cbBxSearchEventoMatricola.Text;

                    foreach (KeyValuePair<DateTime, List<Evento>> kv in Registro.DizGiorni)
                    {
                        foreach (Evento eventoLista in kv.Value)
                        {
                            // magari errore
                            if (eventoLista.Macchina._Matricola == s)
                            {
                                eventiTrovati.Add(eventoLista);
                            }
                        }
                    }

                    if (eventiTrovati.Count > 0)
                    {
                        lblEventi.Text = "Eventi su: " + eventiTrovati[0].Macchina;
                        dgvEventi.DataSource = eventiTrovati;
                        HideColumnsEventi();
                        dgvEventi.Columns["Giorno"].Visible = true;
                    }
                    else
                    {
                        notifica.Show("Nessuna evento della macchina trovato.", Notifica.enmType.Warning);
                    }
                }
                if (dgvEventi.DataSource != null)
                {
                    //ResizeDetilsCose();
                }
            }
        }

        private void rdBtnSearchEventoCliente_CheckedChanged(object sender, EventArgs e)
        {
            cbBxSearchEventoCliente.Enabled = true;
            cbBxSearchEventoMatricola.Enabled = false;
        }

        private void rdBtnSearchEventoMatricola_CheckedChanged(object sender, EventArgs e)
        {
            cbBxSearchEventoCliente.Enabled = false;
            cbBxSearchEventoMatricola.Enabled = true;
        }

        private void gBxDettagliMacchinaAccessorio_MouseLeave(object sender, EventArgs e)
        {
            bool b = gBxDettagliMacchinaAccessorio.ClientRectangle.Contains(gBxDettagliMacchinaAccessorio.PointToClient(Cursor.Position));
            if (b)
            {
            }
            else
            {
                gBxDettagliMacchinaAccessorio.Visible = false;
                gBxDettagliMacchinaAccessorio.Enabled = false;
            }
        }

        private void gBxDettagliMacchinaAccessorio_MouseHover(object sender, EventArgs e)
        {
            gBxDettagliMacchinaAccessorio.Visible = false;
            gBxDettagliMacchinaAccessorio.Enabled = false;
        }

        private void gBxDettagliCliente_MouseEnter(object sender, EventArgs e)
        {
            gBxDettagliCliente.Visible = false;
        }

        private void pbxAlloStoricoCliente_Click(object sender, EventArgs e)
        {
            if (dgvVisualizzaClienti.CurrentCell.ColumnIndex == 0)
            {
                rdBtnSearchEventoCliente.Checked = true;
                rdBtnSearchEventoMatricola.Checked = false;
                cbBxSearchEventoCliente.Text = dgvVisualizzaClienti.CurrentCell.Value.ToString();
                btnSearchEvento_Click(sender, e);
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void pbxAlloStoricoMacchina_Click(object sender, EventArgs e)
        {
           /* if (lvwMostraMacchineAccessori.SelectedItems.Count > 0)
            {
                if (dgvVisualizzaClienti.CurrentCell.ColumnIndex == 0)
                {
                    rdBtnSearchEventoCliente.Checked = false;
                    rdBtnSearchEventoMatricola.Checked = true;

                    cbBxSearchEventoMatricola.Text = lvwMostraMacchineAccessori.SelectedItems[0].Text + "/" + lvwMostraMacchineAccessori.SelectedItems[0].SubItems[1].Text + "/" + lvwMostraMacchineAccessori.SelectedItems[0].SubItems[2].Text;

                    btnSearchEvento_Click(sender, e);
                    tabControl1.SelectedTab = tabPage1;
                }
            }
            else
            {
                Notifica n = new Notifica();
                n.Show("Seleziona una macchina", Notifica.enmType.Info);
            }*/ //errore
        }

        private void btnModificaClienteChiudi_Click(object sender, EventArgs e)
        {
            gBxClientiModificaClienti.Visible = false;
        }

        private void btnModificaAggiungiMacchina_Click(object sender, EventArgs e)
        {
            if (gBxAggiungiMacchina.Visible == true)
            {
                gBxAggiungiMacchina.Visible = false;
            }
            else
            {
                gBxAggiungiMacchina.Visible = true;
                gBxModificaMacchina.Visible = false;
            }
        }

        private void lvwModificaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnModificaModificaMacchina.Enabled = true;
            btnModificaEliminaMacchina.Enabled = true;

            //tbxModificaMacchinaMarca.Text = listaMacchine[lvwModificaCliente.SelectedItems[0].Index]._Marca;
            //tbxModificaMacchinaModello.Text = listaMacchine[lvwModificaCliente.SelectedItems[0].Index]._Modello;
            //tbxModificaMacchinaMatricola.Text = listaMacchine[lvwModificaCliente.SelectedItems[0].Index]._Matricola;
            //chBxModificaMacchinaNoleggio.Checked = listaMacchine[lvwModificaCliente.SelectedItems[0].Index]._Noleggio;
            //rtbModificaMacchinaNote.Text = listaMacchine[lvwModificaCliente.SelectedItems[0].Index]._Note;

            //lvwModificaComponentiMacchina.Items.Clear();
            //foreach (Componenti c in listaMacchine[lvwModificaCliente.SelectedItems[0].Index]._Componenti)
            //{
            //    ListViewItem item = new ListViewItem
            //    {
            //        Text = c.Tipo
            //    };
            //    item.SubItems.Add(c.Codice);
            //    lvwModificaComponentiMacchina.Items.Add(item);
            //}
        }

        private void btnModificaModificaMacchina_Click(object sender, EventArgs e)
        {
            if (gBxModificaMacchina.Visible == true)
            {
                gBxModificaMacchina.Visible = false;
            }
            else
            {
                gBxModificaMacchina.Visible = true;
                gBxAggiungiMacchina.Visible = false;
            }
        }

        private void btnConfermaModificaMacchina_Click(object sender, EventArgs e)
        {
            Notifica notifica = new Notifica();
            try
            {
                listaMacchine = new List<Macchina>();

                List<Componenti> componenti = new List<Componenti>();

                //foreach (ListViewItem item in lvwModificaComponentiMacchina.Items)
                {
                    //errore
                    //Componenti componente = new Componenti(item.Text, item.SubItems[1].Text);
                    //componenti.Add(componente);
                }

                Macchina macchina = new Macchina(Metodi.GetCustomerID(dgvVisualizzaClienti.CurrentRow),tbxModificaMacchinaMarca.Text, tbxModificaMacchinaModello.Text,
                    tbxModificaMacchinaMatricola.Text, componenti, chBxModificaMacchinaNoleggio.Checked, rtbModificaMacchinaNote.Text);
                listaMacchine.Add(macchina);

                ListViewItem items = new ListViewItem
                {
                    Text = macchina._Marca
                };
                items.SubItems.Add(macchina._Modello);
                items.SubItems.Add(macchina._Matricola);

                //lvwAggiungiClientiMacchine.Items.Add(items);

                notifica.Show("Macchina modificata correttamente!", Notifica.enmType.Success);
                macchina = null;
                gBxModificaMacchina.Visible = false;

                foreach (Control c in gBxModificaMacchina.Controls)
                {
                    if (c is TextBox || c is ComboBox || c is RichTextBox)
                    {
                        c.Text = null;
                    }

                    if (c is ListView)
                    {
                        ListView listView = (ListView)c;
                        listView.Items.Clear();
                    }
                }
            }
            catch (Exception exc)
            {
                notifica.Show(exc.Message, Notifica.enmType.Warning);
            }
        }

        private void btnModificaEliminaMacchina_Click(object sender, EventArgs e)
        {
            //lvwModificaCliente.Items.Remove(lvwModificaCliente.SelectedItems[0]);
        }

        private void btnAggiungiEliminaMacchina_Click(object sender, EventArgs e)
        {
            //lvwAggiungiClientiMacchine.Items.Remove(lvwAggiungiClientiMacchine.SelectedItems[0]);
        }

        private void lvwAggiungiClientiMacchine_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnAggiungiModificaMacchina.Enabled = true;
            //btnAggiungiEliminaMacchina.Enabled = true;

            //tbxModificaMacchinaMarca.Text = listaMacchine[lvwAggiungiClientiMacchine.SelectedItems[0].Index]._Marca;
            //tbxModificaMacchinaModello.Text = listaMacchine[lvwAggiungiClientiMacchine.SelectedItems[0].Index]._Modello;
            //tbxModificaMacchinaMatricola.Text = listaMacchine[lvwAggiungiClientiMacchine.SelectedItems[0].Index]._Matricola;
            //chBxModificaMacchinaNoleggio.Checked = listaMacchine[lvwAggiungiClientiMacchine.SelectedItems[0].Index]._Noleggio;
            //rtbModificaMacchinaNote.Text = listaMacchine[lvwAggiungiClientiMacchine.SelectedItems[0].Index]._Note;

            //lvwModificaComponentiMacchina.Items.Clear();
            //foreach (Componenti c in listaMacchine[lvwAggiungiClientiMacchine.SelectedItems[0].Index]._Componenti)
            //{
            //    ListViewItem item = new ListViewItem
            //    {
            //        Text = c.Tipo
            //    };
            //    item.SubItems.Add(c.Codice);
            //    lvwModificaComponentiMacchina.Items.Add(item);
            //}
        }

        private void btnChiudigBxModificaMacchina_Click(object sender, EventArgs e)
        {
            gBxModificaMacchina.Visible = false;
        }

        private void btnConfermaModificaCliente_Click(object sender, EventArgs e)
        {
            Notifica n = new Notifica();
            try
            {                
                if (!Metodi.AreThereAnyEmptyTextBoxes(gBxClientiModificaClienti.Controls, "Mandatory") && !Metodi.CheckForNewCustomersAndNotify())
                {
                    string nome = txBxModificaClienteNome.Text;
                    string mail = txBxModificaClienteMail.Text;
                    string tel = txBxModificaClienteTel.Text;
                    string ind = txBxModificaClienteInd.Text;
                    string iva = txBxModificaClienteIva.Text;
                    string prif = txBxDettagliClientePrif.Text;

                    MySqlConnection conn = Metodi.ConnectToDatabase();
                    string query = $"UPDATE cliente SET nome_cliente = '{nome}', " +
                        $"telefono_cliente = '{tel}', " +
                        $"mail_cliente = '{mail}', " +
                        $"indirizzo_cliente = '{ind}'";

                    if (!string.IsNullOrWhiteSpace(iva)) query += $", p.iva_cliente = '{iva}'";
                    if (!string.IsNullOrWhiteSpace(prif)) query += $", p.rif_cliente = '{prif}'";

                    query += $"WHERE id_cliente = {Metodi.GetCustomerID(mail, tel)};";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int row = cmd.ExecuteNonQuery();

                    if(row > 0)
                    {
                        RefreshCustomers();
                        n.Show("Modifica avvenuta correttamente!", Notifica.enmType.Success);
                    }
                    else
                    {
                        n.Show("Modifica non riuscita.", Notifica.enmType.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                n.Show(ex.Message, Notifica.enmType.Warning);
            }
        }

        private void btnModificaMacchinaAggiungiComponenti_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cBxModificaMacchinaTipo.Text) || string.IsNullOrWhiteSpace(txBxModificaMacchinaCodice.Text))
            {
            }
            else
            {
                ListViewItem item = new ListViewItem
                {
                    Text = cBxModificaMacchinaTipo.Text
                };
                item.SubItems.Add(txBxModificaMacchinaCodice.Text);
                //lvwModificaComponentiMacchina.Items.Add(item);
            }
        }

        private void btnAddComponente_Click(object sender, EventArgs e)
        {
            Caricamento();
            UpdateCBXTipi();

            if (Metodi.CheckForNewComponentsAndNotify())
            {
                RefreshComponentsCatalogoAndCBX();
                EndCaricamento();
                return;
            }

            gBxAggiungiComponente.Visible = true;
            EndCaricamento();
        }

        private void btnExitAggiungiComponente_Click(object sender, EventArgs e)
        {
            gBxAggiungiComponente.Visible = false;
        }

        private void btnRemoveComponente_Click(object sender, EventArgs e)
        {
            Caricamento();

            if (Metodi.CheckForNewComponentsAndNotify())
            {
                RefreshComponentsCatalogoAndCBX();
                EndCaricamento();
                return;
            }

            MySqlConnection conn = null;
            try
            {
                Componenti componente = (Componenti)dgvComponenti.CurrentRow.DataBoundItem;
                conn = Metodi.ConnectToDatabase();
                string query = $"DELETE FROM componente WHERE codice_componente = '{componente.Codice}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int row = cmd.ExecuteNonQuery();
                

                if (row == 0) throw new Exception("Nessuna riga modificata.");

                Notifica n = new Notifica();
                n.Show("Componente eliminato con successo!", Notifica.enmType.Success);

                if (!string.IsNullOrWhiteSpace(FiltroAttivoCatalogo))
                {
                    if(dgvComponenti.Rows.Count > 0)
                    {
                        if(!string.IsNullOrWhiteSpace(FiltroAttivoCatalogo)) ReApplyFiltroCatalogo();
                    }
                    else
                    {
                        RefreshComponentsCatalogoAndCBX();
                    }                    
                }
            }
            catch (Exception ex)
            {
                Notifica n = new Notifica();
                n.Show(ex.Message, Notifica.enmType.Warning);
            }
            finally
            {
                conn.Close();
                EndCaricamento();
            }
        }

        private void btnModifyComponente_Click(object sender, EventArgs e)
        {
            Caricamento();
            UpdateCBXTipi();
            if (Metodi.CheckForNewComponentsAndNotify())
            {
                RefreshComponentsCatalogoAndCBX();
                EndCaricamento();
                return;
            }

            Componenti componente = (Componenti)dgvComponenti.CurrentRow.DataBoundItem;
            tbxModificaCodiceComponente.Text = componente.Codice;
            cbxModificaMarcaComponente.SelectedItem = componente.Marca;
            cbxModificaTipoComponente.SelectedItem = componente.Tipo;
            nudModificaNOrdine.Value = componente.N_ordine;
            nudModificaSoglia.Value = componente.Soglia;

            dgvComponenti.Enabled = false;
            gbxModificaComponente.Visible = true;
            EndCaricamento();
        }

        private void btnAggiungiMagazzino_Click(object sender, EventArgs e)
        {
            Notifica n = new Notifica();
            Caricamento();
            if (Metodi.CheckForNewComponents() || Metodi.CheckForNewDatiMagazzini(tbCtrlMagazzini))
            {
                RefreshComponentsCatalogoAndCBX();
                RefreshMagazzini();
                RefreshConetnutiMagazzini();
                EndCaricamento();
                n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbxNomeMagazzino.Text))
            {
                n.Show("Inserire un nome valido", Notifica.enmType.Warning);
            }
            else
            {
                MySqlConnection conn = null;
                try
                {
                    Caricamento();
                    conn = Metodi.ConnectToDatabase();
                    string query = $"INSERT INTO magazzino VALUES('{tbxNomeMagazzino.Text}')";

                    MySqlCommand InsertMagazzino = new MySqlCommand(query, conn);
                    InsertMagazzino.ExecuteNonQuery();

                    RefreshMagazzini();
                    RefreshConetnutiMagazzini();
                    if (!string.IsNullOrWhiteSpace(FiltroAttivoMagazzino)) ReApplyFiltroMagazzino(CurrentComponentiFiltroMarca, CurrentComponentiFiltroCodice, CurrentComponentiFiltroTipo, CurrentComponentiFiltroSottoSoglia);
                }
                catch (Exception ex)
                {
                    n.Show(ex.Message, Notifica.enmType.Warning);
                }
                finally
                {
                    conn.Close();
                    EndCaricamento();
                }
                
                n.Show("Magazzino aggiunto con successo!", Notifica.enmType.Success);
            }
        }

        private void ReApplyFiltroMagazzino(string marca, string codice, string tipo, bool sottoSoglia)
        {
            MySqlCommand cmd = new MySqlCommand(FiltroAttivoMagazzino, Metodi.ConnectToDatabase());
            MySqlDataReader res = cmd.ExecuteReader();

            List<Componenti> components = new List<Componenti>();

            if (!res.HasRows)
            {
                RefreshComponentsCatalogoAndCBX();
                throw new Exception("Nessun risultato.");
            }

            while (res.Read())
            {
                Componenti component = new Componenti(res.GetString("tipo_componente"),
                    res.GetString("marca_componente"),
                    res.GetInt32("soglia_componente"),
                    res.GetInt32("n_ordine_componente"),
                    res.GetString("codice_componente"),
                    0);

                components.Add(component);
            }

            RefreshConetnutiMagazzini();

            List<DataGridView> dgvs = new List<DataGridView>();

            foreach (TabPage tp in tbCtrlMagazzini.TabPages)
            {
                foreach (Control c in tp.Controls)
                {
                    if (c is DataGridView)
                    {
                        dgvs.Add((DataGridView)c);
                    }
                }
            }

            foreach (DataGridView dg in dgvs)
            {
                List<Componenti> componentiInMagSel = new List<Componenti>();
                foreach (DataGridViewRow dgvr in dg.Rows)
                {
                    componentiInMagSel.Add(dgvr.DataBoundItem as Componenti);
                }

                List<Componenti> filtered = (from comp in componentiInMagSel
                                             where (marca == null || comp.Marca == marca)
                                                && (codice == null || comp.Codice == codice)
                                                && (tipo == null || comp.Tipo == tipo)
                                                && (sottoSoglia == false || comp.Soglia > comp.Quantita)
                                             select comp).ToList();

                BindingSource bs = new BindingSource()
                {
                    DataSource = filtered
                };

                dg.DataSource = bs;
            }
        }

        private void btnAddTipoComponente_Click(object sender, EventArgs e)
        {
            Notifica n = new Notifica();
            if (string.IsNullOrWhiteSpace(txBxTipoComponente.Text))
            {         
                n.Show("Inserisci un nome valido per la tipologia.", Notifica.enmType.Warning);
            }
            else
            {
                MySqlConnection conn = null;
                try
                {
                    Caricamento();
                    if (Metodi.CheckForNewTypesAndNotify(ref dgvTipiComponenti))
                    {
                        RefreshComponentTypesDataGridView();
                        return;
                    }

                    conn = Metodi.ConnectToDatabase();
                    string query = $"INSERT INTO tipo_componente VALUES('{txBxTipoComponente.Text}')";

                    MySqlCommand InsertComponentType = new MySqlCommand(query, conn);
                    int row = InsertComponentType.ExecuteNonQuery();

                    if (row > 0)
                    {
                        n.Show("Tipo aggiunto correttamente!", Notifica.enmType.Success);
                        RefreshComponentTypesDataGridView();
                    }
                    else
                    {
                        n.Show("Il tipo del componente non è stato aggiunto correttamente, riprovare.", Notifica.enmType.Warning);
                    }
                }
                catch (Exception ex)
                {
                    n.Show(ex.Message, Notifica.enmType.Warning);
                }
                finally
                {
                    conn.Close();
                    EndCaricamento();
                }
            }
        }

        private void btnEditComponente_Click(object sender, EventArgs e)
        {
            Notifica n = new Notifica();
            if (string.IsNullOrWhiteSpace(txBxTipoComponente.Text))
            {
                n.Show("Inserisci un nome valido per la tipologia.", Notifica.enmType.Warning);
            }
            else
            {
                MySqlConnection conn = null;
                try
                {
                    Caricamento();

                    if (Metodi.CheckForNewTypesAndNotify(ref dgvTipiComponenti))
                    {
                        RefreshComponentTypesDataGridView();
                        return;
                    }
                    conn = Metodi.ConnectToDatabase();
                    string selectedType = dgvTipiComponenti.SelectedCells[0].Value.ToString();
                    string query = $"UPDATE tipo_componente SET tipo_componente = '{txBxTipoComponente.Text}' WHERE tipo_componente = '{selectedType}'";
                    MySqlCommand UpdateComponentType = new MySqlCommand(query, conn);
                    int row = UpdateComponentType.ExecuteNonQuery();

                    if (row > 0)
                    {
                        n.Show("Tipo modificato correttamente!", Notifica.enmType.Success);
                        RefreshComponentTypesDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    n.Show(ex.Message, Notifica.enmType.Warning);
                }
                finally
                {
                    conn.Close();
                    EndCaricamento();
                }
            }
        }

        private void btnDelComponente_Click(object sender, EventArgs e)
        {
            Notifica n = new Notifica();
            MySqlConnection conn = null;
            try
            {
                Caricamento();

                if (Metodi.CheckForNewTypesAndNotify(ref dgvTipiComponenti))
                {
                    RefreshComponentTypesDataGridView();
                    return;
                }

                conn = Metodi.ConnectToDatabase();
                string selectedType = dgvTipiComponenti.SelectedCells[0].Value.ToString();
                string query = $"DELETE FROM tipo_componente WHERE tipo_componente = '{selectedType}'";
                MySqlCommand DeleteComponentType = new MySqlCommand(query, conn);
                int row = DeleteComponentType.ExecuteNonQuery();

                if (row > 0)
                {
                    n.Show("Tipo eliminato correttamente!", Notifica.enmType.Success);
                    RefreshComponentTypesDataGridView();
                }
            }
            catch (Exception ex)
            {
                n.Show(ex.Message, Notifica.enmType.Warning);
            }
            finally
            {
                conn.Close();
                EndCaricamento();
            }
        }

        private void RefreshComponentTypesDataGridView()
        {
            List<string> types = new List<string>();
            string query = "SELECT * FROM tipo_componente";

            MySqlCommand FetchTypes = new MySqlCommand(query, Metodi.ConnectToDatabase());
            MySqlDataReader res = FetchTypes.ExecuteReader();

            while (res.Read())
            {
                types.Add(res.GetString(0));
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = types.Select(x => new { Value = x }).ToList();

            Invoke(new Action(() =>
            {
                dgvTipiComponenti.DataSource = bs;
                dgvTipiComponenti.Columns["Value"].HeaderText = "Tipi dei componenti";
            }));
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            Notifica n = new Notifica();
            if (string.IsNullOrWhiteSpace(txBxMarcaComponente.Text))
            {                
                n.Show("Inserisci un nome valido per la marca.", Notifica.enmType.Warning);
            }
            else
            {

                MySqlConnection conn = null;
                try
                {
                    Caricamento();
                    if (Metodi.CheckForNewBrandsAndNotify(ref dgvMarcheComponenti))
                    {
                        RefreshComponentBrandsDataGridView();
                        return;
                    }
                    conn = Metodi.ConnectToDatabase();
                    string query = $"INSERT INTO marca_componente VALUES('{txBxMarcaComponente.Text}')";

                    MySqlCommand InsertComponentBrand = new MySqlCommand(query, conn);
                    int row = InsertComponentBrand.ExecuteNonQuery();

                    if (row > 0)
                    {
                        RefreshComponentBrandsDataGridView();
                        n.Show("Marca aggiunta correttamente!", Notifica.enmType.Success);
                    }
                    else
                    {
                        n.Show("La marca del componente non è stata aggiunta correttamente, riprovare.", Notifica.enmType.Warning);
                    }
                }
                catch (Exception ex)
                {
                    n.Show(ex.Message, Notifica.enmType.Warning);
                }
                finally
                {
                    conn.Close();
                    EndCaricamento();
                }
            }
        }

        private void btnEditMarca_Click(object sender, EventArgs e)
        {
            Notifica n = new Notifica();
            if (string.IsNullOrWhiteSpace(txBxMarcaComponente.Text))
            {
                n.Show("Inserisci un nome valido per la marca.", Notifica.enmType.Warning);
            }
            else
            {
                MySqlConnection conn = null;
                try
                {
                    if (Metodi.CheckForNewBrandsAndNotify(ref dgvMarcheComponenti))
                    {
                        RefreshComponentBrandsDataGridView();
                        return;
                    }

                    conn = Metodi.ConnectToDatabase();
                    string selectedType = dgvMarcheComponenti.SelectedCells[0].Value.ToString();
                    string query = $"UPDATE marca_componente SET marca_componente = '{txBxMarcaComponente.Text}' WHERE marca_componente = '{selectedType}'";

                    MySqlCommand EditComponentBrand = new MySqlCommand(query, conn);
                    int row = EditComponentBrand.ExecuteNonQuery();

                    if (row > 0)
                    {
                        n.Show("Marca modificata correttamente!", Notifica.enmType.Success);
                        RefreshComponentBrandsDataGridView();
                    }
                    else
                    {
                        n.Show("La marca del componente non è stata aggiornata correttamente, riprovare.", Notifica.enmType.Warning);
                    }
                }
                catch (Exception ex)
                {
                    n.Show(ex.Message, Notifica.enmType.Warning);
                }
                finally
                {
                    conn.Close();
                    EndCaricamento();
                }
            }
        }

        private void btnDelMarca_Click(object sender, EventArgs e)
        {
            Notifica n = new Notifica();
            MySqlConnection conn = null;
            try
            {
                if (Metodi.CheckForNewBrandsAndNotify(ref dgvMarcheComponenti))
                {
                    RefreshComponentBrandsDataGridView();
                    return;
                }

                conn = Metodi.ConnectToDatabase();
                string selectedType = dgvMarcheComponenti.SelectedCells[0].Value.ToString();
                string query = $"DELETE FROM marca_componente WHERE marca_componente = '{selectedType}'";
                MySqlCommand DeleteComponentBrand = new MySqlCommand(query, conn);
                int row = DeleteComponentBrand.ExecuteNonQuery();

                if (row > 0)
                {
                    n.Show("Marca eliminata correttamente!", Notifica.enmType.Success);
                    RefreshComponentBrandsDataGridView();
                }
                else
                {                   
                    n.Show("La marca del componente non è stata cancellata correttamente, riprovare.", Notifica.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                n.Show(ex.Message, Notifica.enmType.Warning);
            }
            finally
            {
                conn.Close();
                EndCaricamento();
            }
        }

        private void RefreshComponentBrandsDataGridView()
        {
            List<string> brands = new List<string>();
            string query = "SELECT * FROM marca_componente";

            MySqlCommand FetchTypes = new MySqlCommand(query, Metodi.ConnectToDatabase());
            MySqlDataReader res = FetchTypes.ExecuteReader();

            while (res.Read())
            {
                brands.Add(res.GetString(0));
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = brands.Select(x => new { Value = x }).ToList();

            Invoke(new Action(() =>
            {
                dgvMarcheComponenti.DataSource = bs;
                dgvMarcheComponenti.Columns["Value"].HeaderText = "Marche dei componenti";
            }));
        }

        private void chBxFiltroMagazzinoTipo_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                cbBxFiltroMagazzinoTipo.Enabled = true;
            }
            else
            {
                cbBxFiltroMagazzinoTipo.Enabled = false;
            }
        }

        private void chBxFiltroMagazzinoMarca_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                cbBxFiltroMagazzinoMarca.Enabled = true;
            }
            else
            {
                cbBxFiltroMagazzinoMarca.Enabled = false;
            }
        }

        private void chBxFiltroMagazzinoCodice_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                cbBxFiltroMagazzinoCodice.Enabled = true;
            }
            else
            {
                cbBxFiltroMagazzinoCodice.Enabled = false;
            }
        }

        private void btnAggiungiComponente_Click(object sender, EventArgs e)
        {
            ///INDICI TABELLA COMPONENTI
            ///0: codice_componente
            ///1: marca_componente
            ///2: tipo_componente
            ///3: soglia_componente
            ///4: n_ordine_componente
            if (string.IsNullOrWhiteSpace(tbxAggiungiComponenteCodice.Text) || string.IsNullOrWhiteSpace(cbxAggiungiComponenteTipo.Text) || string.IsNullOrWhiteSpace(cbxAggiungiMarcaComponente.Text))
            {
                Notifica n = new Notifica();
                n.Show("Compila tutti i campi", Notifica.enmType.Warning);
            }
            else
            {
                MySqlConnection conn = null;
                try
                {
                    conn = Metodi.ConnectToDatabase();
                    string query = $"INSERT INTO componente VALUES('{tbxAggiungiComponenteCodice.Text}','{cbxAggiungiMarcaComponente.Text}','{cbxAggiungiComponenteTipo.Text}','{(int)nudAggiungiComponenteSoglia.Value}','{(int)nudAggiungiComponenteNOrdine.Value}')";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();

                    MySqlDataReader reader;
                    List<Componenti> l = new List<Componenti>();
                    Componenti c = new Componenti();

                    query = $"SELECT * From componente";
                    command = new MySqlCommand(query, conn);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        c = new Componenti(reader.GetString(2), reader.GetString(1), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(0), 0);
                        l.Add(c);
                    }

                    BindingSource bs = new BindingSource();
                    bs.DataSource = l;
                    dgvComponenti.DataSource = bs;
                    dgvComponenti.Columns["Quantita"].Visible = false;

                    Notifica n = new Notifica();
                    n.Show("Componente aggiunto con successo!", Notifica.enmType.Success);
                    gBxAggiungiComponente.Visible = false;
                    Registro.ComponentiAttuali = l;
                    ReApplyFiltroCatalogo();
                }
                catch (Exception ex)
                {
                    Notifica n = new Notifica();
                    n.Show(ex.Message, Notifica.enmType.Warning);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnExitEditComponente_Click(object sender, EventArgs e)
        {
            gbxModificaComponente.Visible = false;
            dgvComponenti.Enabled = true;
        }

        private void btnModificaComponente_Click(object sender, EventArgs e)
        {
            ///INDICI TABELLA COMPONENTI
            ///0: codice_componente
            ///1: marca_componente
            ///2: tipo_componente
            ///3: soglia_componente
            ///4: n_ordine_componente

            if (string.IsNullOrWhiteSpace(tbxModificaCodiceComponente.Text) || string.IsNullOrWhiteSpace(cbxModificaMarcaComponente.Text) || string.IsNullOrWhiteSpace(cbxModificaTipoComponente.Text))
            {
                Notifica n = new Notifica();
                n.Show("Compila tutti i campi", Notifica.enmType.Warning);
            }
            else
            {
                MySqlConnection conn = null;

                try
                {
                    Componenti comp = (Componenti)dgvComponenti.CurrentRow.DataBoundItem;

                    List<TextBox> tx = new List<TextBox>();

                    foreach (Control c in gbxModificaComponente.Controls)
                    {
                        if (c is TextBox) tx.Add((TextBox)c);
                    }

                    if (Metodi.AreThereAnyEmptyTextBoxes(tx)) throw new ArgumentNullException();

                    conn = Metodi.ConnectToDatabase();
                    string query = $"UPDATE componente SET codice_componente = '{tbxModificaCodiceComponente.Text}', " +
                        $"marca_componente = '{cbxModificaMarcaComponente.Text}', " +
                        $"tipo_componente = '{cbxModificaTipoComponente.Text}', " +
                        $"soglia_componente = '{nudModificaSoglia.Value}', " +
                        $"n_ordine_componente = '{nudModificaNOrdine.Value}' " +
                        $"WHERE codice_componente = '{comp.Codice}' and marca_componente = '{comp.Marca}'";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();

                    RefreshComponentsCatalogoAndCBX();
                    gbxModificaComponente.Visible = false;
                    dgvComponenti.Enabled = true;

                    Notifica n = new Notifica();
                    n.Show("Componente modificato con successo!", Notifica.enmType.Success);
                    gbxModificaComponente.Visible = false;

                    ReApplyFiltroCatalogo();
                }
                catch (Exception ex)
                {
                    Notifica n = new Notifica();
                    n.Show(ex.Message, Notifica.enmType.Warning);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void ReApplyFiltroCatalogo()
        {
            if (!string.IsNullOrWhiteSpace(FiltroAttivoCatalogo))
            {
                MySqlCommand cmd = new MySqlCommand(FiltroAttivoCatalogo, Metodi.ConnectToDatabase());
                MySqlDataReader res = cmd.ExecuteReader();

                List<Componenti> components = new List<Componenti>();

                if (!res.HasRows)
                {
                    RefreshComponentsCatalogoAndCBX();
                    throw new Exception("Nessun risultato.");
                }

                while (res.Read())
                {
                    Componenti component = new Componenti(res.GetString("tipo_componente"),
                        res.GetString("marca_componente"),
                        res.GetInt32("soglia_componente"),
                        res.GetInt32("n_ordine_componente"),
                        res.GetString("codice_componente"),
                        0);

                    components.Add(component);
                }

                BindingSource bsCatalogo = new BindingSource()
                {
                    DataSource = components
                };

                dgvComponenti.DataSource = bsCatalogo;
            }
        }

        private void btnCancellaNomeMagazzino_Click(object sender, EventArgs e)
        {
            tbxNomeMagazzino.Text = null;
        }

        private void bntDeleteTextMarche_Click(object sender, EventArgs e)
        {
            txBxMarcaComponente.Text = null;
        }

        private void bntDeleteTextTipologie_Click(object sender, EventArgs e)
        {
            txBxTipoComponente.Text = null;
        }

        private void dgvMarcheComponenti_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txBxMarcaComponente.Text = (string)dgvMarcheComponenti.CurrentRow.Cells[0].Value;
        }

        private void dgvTipiComponenti_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txBxTipoComponente.Text = (string)dgvTipiComponenti.CurrentRow.Cells[0].Value;
        }

        private void tbCtrlMagazzini_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbCtrlMagazzini.SelectedTab.Name != "Totale" && tbCtrlMagazzini.SelectedTab.Name != "Centrale")
            {
                tbxNomeMagazzino.Text = tbCtrlMagazzini.SelectedTab.Name;
            }
        }

        private void btnModificaMagazzino_Click(object sender, EventArgs e)
        {
            Caricamento();
            if (Metodi.CheckForNewComponents() || Metodi.CheckForNewDatiMagazzini(tbCtrlMagazzini))
            {
                RefreshComponentsCatalogoAndCBX();
                RefreshMagazzini();
                RefreshConetnutiMagazzini();
                EndCaricamento();
                Notifica n = new Notifica();
                n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbxNomeMagazzino.Text))
            {
                Notifica n = new Notifica();
                n.Show("Inserire un nome valido", Notifica.enmType.Warning);
            }
            else
            {
                Caricamento();
                MySqlConnection conn = null;
                try
                {
                    conn = Metodi.ConnectToDatabase();
                    string query = $"UPDATE magazzino SET id_magazzino = '{tbxNomeMagazzino.Text}' WHERE id_magazzino = '{tbCtrlMagazzini.SelectedTab.Name}'";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();

                    RefreshMagazzini();
                    RefreshConetnutiMagazzini();
                    if (!string.IsNullOrWhiteSpace(FiltroAttivoMagazzino)) ReApplyFiltroMagazzino(CurrentComponentiFiltroMarca, CurrentComponentiFiltroCodice, CurrentComponentiFiltroTipo, CurrentComponentiFiltroSottoSoglia);
                    Notifica n = new Notifica();
                    n.Show("Magazzino modificato con successo!", Notifica.enmType.Success);
                }
                catch (Exception ex)
                {
                    Notifica n = new Notifica();
                    n.Show(ex.Message, Notifica.enmType.Warning);
                }
                finally
                {
                    conn.Close();
                    EndCaricamento();
                }
            }
        }

        private void btnEliminaMagazzino_Click(object sender, EventArgs e)
        {
            Caricamento();
            if (Metodi.CheckForNewComponents() || Metodi.CheckForNewDatiMagazzini(tbCtrlMagazzini))
            {
                RefreshComponentsCatalogoAndCBX();
                RefreshMagazzini();
                RefreshConetnutiMagazzini();
                EndCaricamento();
                Notifica n = new Notifica();
                n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);
                return;
            }
            MySqlConnection conn = null;
            try
            {
                conn = Metodi.ConnectToDatabase();
                //string selectedType = dgvMarcheComponenti.SelectedCells[0].Value.ToString();
                string query = $"DELETE FROM magazzino WHERE id_magazzino = '{tbCtrlMagazzini.SelectedTab.Name}'";
                MySqlCommand DeleteComponentBrand = new MySqlCommand(query, conn);
                int row = DeleteComponentBrand.ExecuteNonQuery();

                if (row > 0)
                {
                    RefreshMagazzini();
                    Notifica n = new Notifica();
                    n.Show("Magazzino eliminato con successo!", Notifica.enmType.Success);
                    RefreshConetnutiMagazzini();
                    if(!string.IsNullOrWhiteSpace(FiltroAttivoMagazzino)) ReApplyFiltroMagazzino(CurrentComponentiFiltroMarca, CurrentComponentiFiltroCodice, CurrentComponentiFiltroTipo, CurrentComponentiFiltroSottoSoglia);
                }
                else
                {
                    Notifica n = new Notifica();
                    n.Show("Il magazzino non è stato cancellato correttamente, riprovare.", Notifica.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                Notifica n = new Notifica();
                n.Show(ex.Message, Notifica.enmType.Warning);
            }
            finally
            {
                conn.Close();
                EndCaricamento();
            }
        }

        private void btnSearchComponenti_Click(object sender, EventArgs e)
        {
            Caricamento();

            ///INDICI TABELLA COMPONENTI
            ///0: codice_componente
            ///1: marca_componente
            ///2: tipo_componente
            ///3: soglia_componente
            ///4: n_ordine_componente

            MySqlConnection conn = null;

            try
            {
                using (conn = Metodi.ConnectToDatabase())
                {
                    string marca = null;
                    if (chBxFiltroMagazzinoMarca.Checked) marca = cbBxFiltroMagazzinoMarca.Text;

                    string tipo = null;
                    if (chBxFiltroMagazzinoTipo.Checked) tipo = cbBxFiltroMagazzinoTipo.Text;

                    string codice = null;
                    if (chBxFiltroMagazzinoCodice.Checked) codice = cbBxFiltroMagazzinoCodice.Text;

                    bool applicaAMagazzino = false;
                    if (chbxFiltroAMagazzino.Checked) applicaAMagazzino = true;

                    bool applicaACatalogo = false;
                    if (chbxFiltroACatalogo.Checked) applicaACatalogo = true;

                    bool sottoSoglia = false;
                    if (chBxSottoSoglia.Checked) sottoSoglia = true;

                    if (string.IsNullOrWhiteSpace(marca + tipo + codice) && sottoSoglia == false)
                    {
                        RefreshComponentsCatalogoAndCBX();
                        RefreshConetnutiMagazzini();
                        return;
                    }

                    if (!applicaACatalogo && !applicaAMagazzino)
                    {
                        FiltroAttivoCatalogo = null;
                        FiltroAttivoMagazzino = null;
                        throw new Exception("Applicare il filtro al catalogo o al magazzino.");                      
                    }

                    string query = "SELECT * FROM componente";

                    if (marca != null) query += $"WHERE marca_componente = '{marca}'";
                    if (tipo != null && query.EndsWith("componente")) query += $" tipo_componente = '{tipo}'"; else if (tipo != null) query += $" AND tipo_componente = '{tipo}'";
                    if (codice != null && query.EndsWith("componente")) query += $" codice_componente = '{codice}'"; else if (codice != null) query += $" AND codice_componente = '{codice}'";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader res = cmd.ExecuteReader();

                    List<Componenti> components = new List<Componenti>();

                    if (!res.HasRows)
                    {
                        RefreshComponentsCatalogoAndCBX();
                        throw new Exception("Nessun risultato.");
                    }

                    while (res.Read())
                    {
                        Componenti component = new Componenti(res.GetString("tipo_componente"),
                            res.GetString("marca_componente"),
                            res.GetInt32("soglia_componente"),
                            res.GetInt32("n_ordine_componente"),
                            res.GetString("codice_componente"),
                            0);

                        components.Add(component);
                    }

                    BindingSource bsCatalogo = new BindingSource()
                    {
                        DataSource = components
                    };

                    if (applicaACatalogo)
                    {
                        dgvComponenti.DataSource = bsCatalogo;
                        FiltroAttivoCatalogo = query;
                    }
                    else
                    {
                        FiltroAttivoCatalogo = null;
                    }

                    if (applicaAMagazzino)
                    {
                        RefreshConetnutiMagazzini();

                        List<DataGridView> dgvs = new List<DataGridView>();

                        foreach (TabPage tp in tbCtrlMagazzini.TabPages)
                        {
                            foreach (Control c in tp.Controls)
                            {
                                if (c is DataGridView)
                                {
                                    dgvs.Add((DataGridView)c);
                                }
                            }
                        }

                        foreach (DataGridView dg in dgvs)
                        {
                            List<Componenti> componentiInMagSel = new List<Componenti>();
                            foreach (DataGridViewRow dgvr in dg.Rows)
                            {
                                componentiInMagSel.Add(dgvr.DataBoundItem as Componenti);
                            }

                            List<Componenti> filtered = (from comp in componentiInMagSel
                                                         where (marca == null || comp.Marca == marca)
                                                            && (codice == null || comp.Codice == codice)
                                                            && (tipo == null || comp.Tipo == tipo)
                                                            && (sottoSoglia == false || comp.Soglia > comp.Quantita)
                                                         select comp).ToList();

                            BindingSource bs = new BindingSource()
                            {
                                DataSource = filtered
                            };

                            dg.DataSource = bs;

                            FiltroAttivoMagazzino = query;
                        }
                    }
                    else
                    {
                        FiltroAttivoMagazzino = null;
                    }

                    CurrentComponentiFiltroCodice = codice;
                    CurrentComponentiFiltroMarca = marca;
                    CurrentComponentiFiltroTipo = tipo;
                    CurrentComponentiFiltroSottoSoglia = sottoSoglia;
                }                
            }
            catch (Exception ex)
            {
                Notifica n = new Notifica();
                n.Show(ex.Message, Notifica.enmType.Warning);
            }
            finally
            {
                conn.Close();
                EndCaricamento();
            }
        }

        private void mur_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesce di apvile a tutti da mavva!!");
        }

        private void btnImmagazzinaComponente_Click(object sender, EventArgs e)
        {
            Caricamento();
            if (Metodi.CheckForNewComponents()||Metodi.CheckForNewDatiMagazzini(tbCtrlMagazzini))
            {
                RefreshComponentsCatalogoAndCBX();
                RefreshMagazzini();
                RefreshConetnutiMagazzini();
                EndCaricamento();
                Notifica n = new Notifica();
                n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);
                return;
            }

            if (tbCtrlMagazzini.SelectedTab.Name == "Totale")
            {
                Notifica n = new Notifica();
                n.Show("Per favore selezionare un magazzino specifico non Totale che è la somma di tutti.", Notifica.enmType.Warning);
                EndCaricamento();
                return;
            }

            MySqlConnection conn = null;
            try
            {
                Caricamento();
                conn = Metodi.ConnectToDatabase();
                string query = $"INSERT INTO componenti_magazzino VALUES('{tbCtrlMagazzini.SelectedTab.Name}','{dgvComponenti.CurrentRow.Cells[1].Value}','{dgvComponenti.CurrentRow.Cells[0].Value}','{(int)nudNumeroComponenti.Value}')";
                MySqlCommand InsertMagazzino = new MySqlCommand(query, conn);
                InsertMagazzino.ExecuteNonQuery();

                RefreshMagazzini();
                RefreshConetnutiMagazzini();
            }
            catch (Exception ex)
            {
                Notifica n = new Notifica();
                n.Show(ex.Message, Notifica.enmType.Warning);
            }
            finally
            {
                conn.Close();
                EndCaricamento();
            }


        }

        private void EditContenutiMagazzinoApply(bool remove,bool pos)
        {
            Caricamento();
            if (Metodi.CheckForNewComponents() || Metodi.CheckForNewDatiMagazzini(tbCtrlMagazzini))
            {
                RefreshComponentsCatalogoAndCBX();
                RefreshMagazzini();
                RefreshConetnutiMagazzini();
                EndCaricamento();
                gbxEditComponenti.Visible = false;
                Notifica n = new Notifica();
                n.Show("Sono stati scaricati dei dati aggiornati, si prega di controllare prima di effettuare modifiche.", Notifica.enmType.Info);
                return;
            }
            MySqlConnection conn = null;
            try
            {
                Caricamento();
                conn = Metodi.ConnectToDatabase();
                if (remove == false)
                {
                    int quantapp = (int)((DataGridView)tbCtrlMagazzini.SelectedTab.Controls[0]).CurrentRow.Cells[5].Value;
                    if (pos == true) { quantapp += (int)nudEditNcomponenti.Value; }
                    else { quantapp -= (int)nudEditNcomponenti.Value; }
                    if(quantapp<0)
                    {
                        Notifica naa = new Notifica();
                        naa.Show("La modifica porta il valore sotto lo zero. Operazione non valida.", Notifica.enmType.Warning);
                        return;
                    }
                    string query = $"UPDATE componenti_magazzino SET quantità_componente='{quantapp}' WHERE id_magazzino='{tbCtrlMagazzini.SelectedTab.Name}' and marca_componente='{((DataGridView)tbCtrlMagazzini.SelectedTab.Controls[0]).CurrentRow.Cells[1].Value}' and codice_componente='{((DataGridView)tbCtrlMagazzini.SelectedTab.Controls[0]).CurrentRow.Cells[0].Value}'";
                    MySqlCommand InsertMagazzino = new MySqlCommand(query, conn);
                    InsertMagazzino.ExecuteNonQuery();

                }
                else
                {
                    string query = $"DELETE FROM componenti_magazzino WHERE id_magazzino='{tbCtrlMagazzini.SelectedTab.Name}' and marca_componente='{((DataGridView)tbCtrlMagazzini.SelectedTab.Controls[0]).CurrentRow.Cells[1].Value}' and codice_componente='{((DataGridView)tbCtrlMagazzini.SelectedTab.Controls[0]).CurrentRow.Cells[0].Value}'";
                    MySqlCommand InsertMagazzino = new MySqlCommand(query, conn);
                    InsertMagazzino.ExecuteNonQuery();
                }
                RefreshMagazzini();
                RefreshConetnutiMagazzini();
                Notifica n = new Notifica();
                n.Show("Modifica apportata correttamente.", Notifica.enmType.Success);
            }
            catch (Exception ex)
            {
                Notifica n = new Notifica();
                n.Show(ex.Message, Notifica.enmType.Warning);
            }
            finally
            {
                conn.Close();
                EndCaricamento();
                gbxModificaComponente.Visible = false;
            }
        }

        private void EditContenutiMagazzino()
        {
            if (tbCtrlMagazzini.SelectedTab.Name!="Totale") 
            {
                gbxEditComponenti.Visible = true;
            }
            else
            {
                Notifica n = new Notifica();
                n.Show("Seleziona il componente all'interno del singolo magazzino per modificarne la quantità. La modifica si ripercuoterà anche sul totale.", Notifica.enmType.Warning);
            }
        }

       
        private void CommonCellDoubleClickEvent(object sender, DataGridViewCellEventArgs e)
        {
            EditContenutiMagazzino();
        }
        private void dgvMagazzinoTotale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditContenutiMagazzino();
        }

        private void dgvMagazzinoCentrale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditContenutiMagazzino();
        }

        private void btnPlusComponenti_Click(object sender, EventArgs e)
        {
            EditContenutiMagazzinoApply(false, true);
        }

        private void btnMenoComponenti_Click(object sender, EventArgs e)
        {
            EditContenutiMagazzinoApply(false, false);
        }

        private void btnEliminaComponenteImmagazzinato_Click(object sender, EventArgs e)
        {
            EditContenutiMagazzinoApply(true, false);
        }

        private void cbBxAggiungiMacchinaTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbBxAggiungiMacchinaTipoFiltro.Text))
            {
                cbBxAggiungiMacchinaCodiceFiltro.DataSource = null;
                cbBxAggiungiMacchinaMarcaFiltro.DataSource = null;
                MySqlConnection conn = Metodi.ConnectToDatabase();
                string query = $"SELECT marca_componente, codice_componente FROM componente WHERE tipo_componente = '{cbBxAggiungiMacchinaTipoFiltro.Text}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader res = cmd.ExecuteReader();

                List<string> marche = new List<string>();
                List<string> codici = new List<string>();
                while (res.Read())
                {
                    marche.Add(res.GetString(0));
                    codici.Add(res.GetString(1));
                }

                if (marche.Count == 0) return;

                cbBxAggiungiMacchinaMarcaFiltro.Enabled = true;
                cbBxAggiungiMacchinaCodiceFiltro.Enabled = true;

                BindingSource bsMarche = new BindingSource()
                {
                    DataSource = marche
                };

                BindingSource bsCodici = new BindingSource()
                {
                    DataSource = codici
                };

                cbBxAggiungiMacchinaCodiceFiltro.DataSource = bsCodici;
                cbBxAggiungiMacchinaMarcaFiltro.DataSource = bsMarche;
            }
        }

        private void cbBxAggiungiMacchinaMarcaFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbBxAggiungiMacchinaTipoFiltro.Text))
            {
                cbBxAggiungiMacchinaCodiceFiltro.DataSource = null;
                MySqlConnection conn = Metodi.ConnectToDatabase();
                string query = $"SELECT codice_componente FROM componente WHERE tipo_componente = '{cbBxAggiungiMacchinaTipoFiltro.Text}' AND marca_componente = '{cbBxAggiungiMacchinaMarcaFiltro.Text}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader res = cmd.ExecuteReader();

                List<string> codici = new List<string>();
                while (res.Read())
                {
                    codici.Add(res.GetString(0));
                }

                cbBxAggiungiMacchinaCodiceFiltro.Enabled = true;

                BindingSource bsCodici = new BindingSource()
                {
                    DataSource = codici
                };

                cbBxAggiungiMacchinaCodiceFiltro.DataSource = bsCodici;
            }
        }

        private void btnCloseEditComponenti_Click(object sender, EventArgs e)
        {
            gbxEditComponenti.Visible = false;
        }

        private void dgvVisualizzaClienti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnClientiEditCustomer.Enabled = true;
            btnClientiDeleteCustomer.Enabled = true;

            Cliente CurrentCliente = (Cliente)dgvVisualizzaClienti.CurrentRow.DataBoundItem;
            tbxMostraIva.Text = CurrentCliente._PartIVA;
            if (string.IsNullOrWhiteSpace(tbxMostraIva.Text)) tbxMostraIva.Text = "None";
            tbxMostraPrif.Text = CurrentCliente._Ref;
            if (string.IsNullOrWhiteSpace(tbxMostraPrif.Text)) tbxMostraPrif.Text = "None";

            

            BindingSource bs = new BindingSource() { DataSource=Registro.ClientiAttuali.Find(x => x._Email == CurrentCliente._Email &&
            x._Telefono == CurrentCliente._Telefono)._Mach.ToList() };
            dgvMostraMacchineAccessori.DataSource = bs;
            dgvMostraMacchineAccessori.Columns[0].Visible = false;
            dgvMostraMacchineAccessori.Columns["_Marca"].HeaderText = "Marca";
            dgvMostraMacchineAccessori.Columns["_Modello"].HeaderText = "Modello";
            dgvMostraMacchineAccessori.Columns["_Matricola"].HeaderText = "Matricola";
            dgvMostraMacchineAccessori.Columns["_Noleggio"].HeaderText = "Noleggio";
            dgvMostraMacchineAccessori.Columns[5].Visible = false;

            if (dgvModificaCliente.DataSource != null)
            {
                dgvModificaCliente.Columns["_cliente"].Visible = false;
                dgvModificaCliente.Columns["_Marca"].HeaderText = "Marca";
                dgvModificaCliente.Columns["_Modello"].HeaderText = "Modello";
                dgvModificaCliente.Columns["_Matricola"].HeaderText = "Matricola";
                dgvModificaCliente.Columns["_Noleggio"].HeaderText = "Noleggio";
                dgvModificaCliente.Columns["_Note"].HeaderText = "Note";
            }

            txBxModificaClienteNome.Text = CurrentCliente._Nome;
            txBxModificaClienteTel.Text = CurrentCliente._Telefono;
            txBxModificaClienteMail.Text = CurrentCliente._Email;
            txBxModificaClienteInd.Text = CurrentCliente._Indirizzo;
            txBxModificaClienteIva.Text = CurrentCliente._PartIVA;
            txBxModificaClientePrif.Text = CurrentCliente._Ref;
            dgvModificaCliente.DataSource = bs;
        }

        private void dgvMostraMacchineAccessori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente CurrentCliente = (Cliente)dgvVisualizzaClienti.CurrentRow.DataBoundItem;
            Cliente CattualeCompleto = Registro.ClientiAttuali.Find(x => x._Email == CurrentCliente._Email && x._Telefono == CurrentCliente._Telefono);
            Macchina Mattuale = CattualeCompleto._Mach.Find(x => x?._Marca == (string)dgvMostraMacchineAccessori.CurrentRow.Cells[1].Value && x?._Matricola == (string)dgvMostraMacchineAccessori.CurrentRow.Cells[3].Value);
            BindingSource bs = new BindingSource()
            {
                DataSource = Mattuale._Componenti.ToList()
            };
            rtbMostraNote.Text = Mattuale._Note;
            chbxMostraNoleggio.Checked = Mattuale._Noleggio;
            dgvMostraComponentiMacchina.DataSource = bs;
            dgvMostraComponentiMacchina.Columns[3].Visible=false;
            dgvMostraComponentiMacchina.Columns[4].Visible = false;
            dgvMostraComponentiMacchina.Columns[5].Visible = false;

        }
    }
}