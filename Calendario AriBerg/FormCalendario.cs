﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

namespace Calendario_AriBerg
{
    public partial class FormCalendario : Form
    {
        public static Registro r = new Registro();

        private Point p = new Point();
        private DateTime SelectedDate;

        //Inizializzazione del Thread che riceve i files
        private Thread threadRicevi = null;

        public bool going = true;

        private Macchina macchina;
        private List<Macchina> listaMacchine;

        public FormCalendario()
        {
            InitializeComponent();
        }

        private void FormCalendario_Load(object sender, EventArgs e)
        {
            
            CheckForIllegalCrossThreadCalls = false;

            bool error = false;

            //Configurazione data
            SelectedDate = DateTime.Now.Date;
            try
            {
                if (File.Exists(@"\\DESKTOP-B2K8OHJ\Users\AriBerg Files\eventi.bababooey") && File.Exists(@"\\DESKTOP-B2K8OHJ\Users\AriBerg Files\clienti.bababooey"))
                {
                    r.riceviSalvataggiClienti();
                    r.riceviSalvataggiEventi();
                }
                else
                {
                    throw new Exception("Salvataggio condiviso non trovato");
                }
            }
            catch(Exception exc)
            {
                Notifica notificaErr = new Notifica();
                notificaErr.Show(exc.Message, Notifica.enmType.Error);
            }
            try
            {
                
                r.caricaClienti();
                r.caricaEventi();
                threadRicevi = new Thread(AGGIORNATUTTO);
                threadRicevi.Name = "Invia files";
            }
            catch (Exception exc)
            {
                error = true;
                Notifica notificaErr = new Notifica();
                notificaErr.Show(exc.Message, Notifica.enmType.Error);
            }

            //configurazione registro
            if (r.DizClienti == null) 
            {
                r.DizClienti = new Dictionary<string, Cliente>();
            }
            if (r.DizGiorni == null)
            {
                r.DizGiorni = new Dictionary<DateTime, List<Evento>>();
            }
                       
            
            ariCalendario.Refresh();
            lblEventi.Text = "Eventi del: " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            lblClienti.Text = "Tutti i clienti";
            dgwEventi.RowTemplate.Height = 45;

            //confiddatagrid
            dgwEventi.DefaultCellStyle.BackColor = Color.LightGray;

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
            if (r.DizGiorni!=null&& r.DizGiorni.ContainsKey(SelectedDate))
            {
                dgwEventi.DataSource = r.DizGiorni[SelectedDate];
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
            if (r.DizClienti != null )
            {
                dgvVisualizzaClienti.DataSource = r.DizClienti.Values.ToList();
                HideColumnsClienti();
                dgvVisualizzaClienti.AutoGenerateColumns = true;
            }


            rdBtnTrovaPerNome.Checked = true;
            AggiornaComboBox();

            ResizeHandle();
            threadRicevi.Start();
        }

        private void AggiornaComboBox() //Da mettere in modifica ed elimina cliente
        {
            if (r.DizClienti != null)
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

                foreach (KeyValuePair<string, Cliente> kv in r.DizClienti)
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
            dgwEventi.Columns["NomeCliente"].HeaderText = "Nome Cliente";
            dgwEventi.Columns["Giorno"].Visible = false;
            dgwEventi.Columns["note"].Visible = false;
            dgwEventi.Columns["ID"].Visible = false;
            dgwEventi.Columns["NumEventi"].Visible = false;
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
            dgwEventi.CurrentCell = null;
            lblEventi.Text = "Eventi del: " + ariCalendario.SelectionStart.Day + "/" + ariCalendario.SelectionStart.Month + "/" + ariCalendario.SelectionStart.Year;
            SelectedDate = ariCalendario.SelectionStart;
            btnAdd.Enabled = true;

            if (r.DizGiorni!=null&& r.DizGiorni.ContainsKey(SelectedDate))
            {
                dgwEventi.DataSource = r.DizGiorni[SelectedDate];
                HideColumnsEventi();
                ResizeDetilsCose();
            }
            else
            {
                dgwEventi.DataSource = null;
            }

        }

        private void GeneraScadenze()
        {
            Notifica notifica = new Notifica();

            try
            {
                if (r.DizGiorni.ContainsKey(DateTime.Now.Date.AddDays(1)))
                {
                    foreach (Evento ev in r.DizGiorni[DateTime.Now.Date.AddDays(1)])
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
            foreach (Evento evnt in r.DizGiorni[ev.Giorno])
            {
                if (evnt.ID == ev.ID)
                {
                    break;
                }
                i++;
            }
            dgwEventi.CurrentCell = dgwEventi[3, i];
            Rectangle re = dgwEventi.GetCellDisplayRectangle(3, i, false);
            p.Y = dgwEventi.Location.Y + this.Location.Y + (this.Width / 30) + re.Y + re.Height;
            p.X = dgwEventi.Location.X + this.Location.X + dgwEventi.RowHeadersWidth + 30;
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

        private void ResizeDetilsCose()
        {
            int dimCharcolumn = this.Width / 85;
            Font ColumnFont = new Font("Calibri", dimCharcolumn);
            int buffer = 8;
            gbxDettagli.Height = (int)(this.Height / 3.5);
            gbxDettagli.Width = dgwEventi.Columns["NomeCliente"].Width * 2;
            p.X = dgwEventi.Location.X + dgwEventi.Columns["NomeCliente"].Width + dgwEventi.RowHeadersWidth;
            p.Y = dgwEventi.Location.Y;
            gbxDettagli.Location = p;
            gbxDettagli.Font = ColumnFont;
            rtbAggiungiNote.Font = ColumnFont;

            gBxDettagliCliente.Height = (int)(this.Height / 3.1);
            gBxDettagliCliente.Width = gbxDettagli.Width;
            gBxDettagliCliente.Location = gbxDettagli.Location;
            gBxDettagliCliente.Font = ColumnFont;

            gBxDettagliMacchinaAccessorio.Height = (int)(this.Height / 3.5);
            gBxDettagliMacchinaAccessorio.Width = gbxDettagli.Width;
            gBxDettagliMacchinaAccessorio.Location = gbxDettagli.Location;
            gBxDettagliMacchinaAccessorio.Font = ColumnFont;
            //1strow
            p.X = buffer;
            p.Y = ColumnFont.Height + buffer;
            lblDettagliClienteTel.Location = p;
            lblDettagliClienteTel.Font = ColumnFont;
            p.X = lblDettagliClienteTel.Location.X + lblDettagliClienteTel.Width + buffer * 4;
            txBxDettagliClienteTel.Location = p;
            txBxDettagliClienteTel.Width = gBxDettagliCliente.Width - txBxDettagliClienteTel.Location.X - buffer;
            txBxDettagliClienteTel.Height = lblDettagliClienteTel.Height;
            txBxDettagliClienteTel.Font = ColumnFont;
            //2ndrow
            p.X = buffer;
            p.Y = lblDettagliClienteTel.Location.Y + lblDettagliClienteTel.Height + buffer;
            lblDettagliClienteMail.Location = p;
            lblDettagliClienteMail.Font = ColumnFont;
            p.X = lblDettagliClienteTel.Location.X + lblDettagliClienteTel.Width + buffer * 4;
            txBxDettagliClienteMail.Location = p;
            txBxDettagliClienteMail.Width = gBxDettagliCliente.Width - txBxDettagliClienteTel.Location.X - buffer;
            txBxDettagliClienteMail.Height = lblDettagliClienteTel.Height;
            txBxDettagliClienteMail.Font = ColumnFont;
            //3rdrow
            p.X = buffer;
            p.Y = lblDettagliClienteMail.Location.Y + lblDettagliClienteMail.Height + buffer;
            lblDettagliClienteIndirizzo.Location = p;
            lblDettagliClienteIndirizzo.Font = ColumnFont;
            p.X = lblDettagliClienteTel.Location.X + lblDettagliClienteTel.Width + buffer * 4;
            txBxDettagliClienteIndirizzo.Location = p;
            txBxDettagliClienteIndirizzo.Width = gBxDettagliCliente.Width - txBxDettagliClienteTel.Location.X - buffer;
            txBxDettagliClienteIndirizzo.Height = lblDettagliClienteTel.Height;
            txBxDettagliClienteIndirizzo.Font = ColumnFont;
            //4throw
            p.X = buffer;
            p.Y = lblDettagliClienteIndirizzo.Location.Y + lblDettagliClienteIndirizzo.Height + buffer;
            lblDettagliClienteIva.Location = p;
            lblDettagliClienteIva.Font = ColumnFont;
            p.X = lblDettagliClienteTel.Location.X + lblDettagliClienteTel.Width + buffer * 4;
            txBxDettagliClienteIva.Location = p;
            txBxDettagliClienteIva.Width = gBxDettagliCliente.Width - txBxDettagliClienteTel.Location.X - buffer;
            txBxDettagliClienteIva.Height = lblDettagliClienteTel.Height;
            txBxDettagliClienteIva.Font = ColumnFont;
            //5throw
            p.X = buffer;
            p.Y = lblDettagliClienteIva.Location.Y + lblDettagliClienteIva.Height + buffer;
            lblDettagliClientePrif.Location = p;
            lblDettagliClientePrif.Font = ColumnFont;
            p.X = lblDettagliClienteTel.Location.X + lblDettagliClienteTel.Width + buffer * 4;
            txBxDettagliClientePrif.Location = p;
            txBxDettagliClientePrif.Width = gBxDettagliCliente.Width - txBxDettagliClienteTel.Location.X - buffer;
            txBxDettagliClientePrif.Height = lblDettagliClienteTel.Height;
            txBxDettagliClientePrif.Font = ColumnFont;

            //interni dettagli macchina
            p.X = 8;
            p.Y = ColumnFont.Height + 8;
            lblNoteMacchinaAccessorio.Font = ColumnFont;
            lblNoteMacchinaAccessorio.Location = p;
            p.Y = lblNoteMacchinaAccessorio.Location.Y + ColumnFont.Height + 8;
            rtbNoteMacchinaAccessorio.Location = p;
            rtbNoteMacchinaAccessorio.Width = (gBxDettagliMacchinaAccessorio.Width - 24) / 2;
            rtbNoteMacchinaAccessorio.Height = gBxDettagliMacchinaAccessorio.Height - rtbNoteMacchinaAccessorio.Location.Y - buffer;
            p.Y = ColumnFont.Height + 8;
            p.X = rtbNoteMacchinaAccessorio.Width + rtbNoteMacchinaAccessorio.Location.X + 8;
            lblDettagliComponenti.Location = p;
            lblDettagliComponenti.Font = ColumnFont;
            p.Y = lblNoteMacchinaAccessorio.Location.Y + ColumnFont.Height + 8;
            lvwDettagliComponenti.Location = p;
            lvwDettagliComponenti.Width = (gBxDettagliMacchinaAccessorio.Width - 24) / 2;
            lvwDettagliComponenti.Columns[0].Width = (int)(lvwDettagliComponenti.Width / 2.03);
            lvwDettagliComponenti.Columns[1].Width = (int)(lvwDettagliComponenti.Width / 2.03);
            lvwDettagliComponenti.Height = rtbNoteMacchinaAccessorio.Height;
        }
        private void ResizeHandle()
        {
            //reimposta bordo per bug demaximise
            this.FormBorderStyle = FormBorderStyle.Sizable;

            int buffer = 8;
            int dim = this.Width / 55;
            Font lblEventiFont = new Font("Calibri", dim);
            int dimCharcolumn = this.Width / 85;
            Font ColumnFont = new Font("Calibri", dimCharcolumn);


            //tabControl
            tabControl1.Height = this.Height;
            tabControl1.Width = this.Width;

            //configurationPanel
            p.X = buffer;
            p.Y = buffer;
            pnlCommands1.Location = p;
            pnlCommands1.Height = lblEventiFont.Height;
            pnlCommands1.Width = (lblEventiFont.Height - buffer) * 3 + buffer * 4;
            pnlCommands2.Location = pnlCommands1.Location;
            pnlCommands2.Width = (lblEventiFont.Height - buffer) * 3 + buffer * 4;
            pnlCommands2.Height = pnlCommands1.Height;

            //eastereggpart
            if (mur.Visible == true)
            {
                pnlCommands2.Width = (lblEventiFont.Height - buffer) * 4 + buffer * 5;
            }

            //PanelEvennti
            //test cambio dimensioni calendario
            this.Height = (this.Width / 16) * 9;
            int carattere = this.Width / (60 - this.Width / 185);
            p.Y = buffer * 2 + lblEventiFont.Height;
            p.X = pnlCommands1.Location.X;
            ariCalendario.Location = p;
            for (int i = 0; i < 15; i++)
            {
                if (ariCalendario.Height < (int)(this.Height / 1.6))
                {
                    carattere++;
                }
                else
                {
                    carattere--;
                }
                Font CalendFont = new Font("Segoe UI Light", carattere);
                ariCalendario.Font = CalendFont;
            }
            //panel ricerca eventi
            p.Y = buffer;
            p.X = buffer * 2 + pnlCommands1.Width;
            pnlCercaEvento.Location = p;
            pnlCercaEvento.Width = ariCalendario.Width - pnlCercaEvento.Location.X + buffer;
            pnlCercaEvento.Height = pnlCommands1.Height;
            //radiobuttons
            int dimCharpanelsearch = this.Height / 110;
            Font Panelsearchfont = new Font("Calibri", dimCharpanelsearch); ;
            for (int i = 0; i < 10; i++)
            {
                Panelsearchfont = new Font("Calibri", dimCharpanelsearch);
                if (Panelsearchfont.Height < pnlCercaEvento.Height / 2 - buffer - 2)
                {
                    dimCharpanelsearch++;
                }
                else
                {
                    dimCharpanelsearch--;
                }
            }
            p.X = buffer;
            rdBtnSearchEventoCliente.Location = p;
            rdBtnSearchEventoCliente.Font = Panelsearchfont;
            p.Y = buffer * 2 + Panelsearchfont.Height;
            rdBtnSearchEventoMatricola.Location = p;
            rdBtnSearchEventoMatricola.Font = Panelsearchfont;
            //btnsearch eventi
            btnSearchEvento.Height = pnlCercaEvento.Height - buffer;
            btnSearchEvento.Width = btnSearchEvento.Height;
            p.Y = buffer / 2;
            p.X = pnlCercaEvento.Width - btnSearchEvento.Width - buffer;
            btnSearchEvento.Location = p;
            btnSearchEvento.FlatAppearance.BorderSize = 10;
            //combobox
            cbBxSearchEventoCliente.Font = Panelsearchfont;
            cbBxSearchEventoMatricola.Font = Panelsearchfont;
            p.Y = rdBtnSearchEventoCliente.Location.Y - buffer / 2;
            p.X = rdBtnSearchEventoMatricola.Width + buffer;
            cbBxSearchEventoCliente.Location = p;
            p.Y = rdBtnSearchEventoMatricola.Location.Y - buffer / 2;
            cbBxSearchEventoMatricola.Location = p;
            cbBxSearchEventoMatricola.Width = pnlCercaEvento.Width - cbBxSearchEventoMatricola.Location.X - btnSearchEvento.Width - buffer * 2;
            cbBxSearchEventoCliente.Width = cbBxSearchEventoMatricola.Width;

            //lblEventi
            p.X = ariCalendario.Location.X + ariCalendario.Width + buffer;
            p.Y = buffer;
            lblEventi.Location = p;
            lblEventi.Font = lblEventiFont;
            //btnLegenda
            int dimChar = this.Width / 70;
            Font EverithingFont = new Font("Calibri", dimChar);
            btnLegenda.Font = EverithingFont;
            btnLegenda.Width = this.Width / 8;
            btnLegenda.Height = lblEventi.Height;
            p.X = tabPage1.Width - (buffer * 3) - btnLegenda.Width;
            p.Y = buffer;
            btnLegenda.Location = p;
            //gbxLegenda
            p.Y = lblEventi.Location.Y;
            p.X = lblEventi.Location.X + lblEventi.Width + buffer;
            gbxLegenda.Location = p;
            gbxLegenda.Width = tabPage1.Width - lblEventi.Location.X - lblEventi.Width - (buffer * 4);
            gbxLegenda.Height = tabPage1.Height / 3;
            //btnexitLegenda
            gbxLegenda.Font = ColumnFont;
            gbxLegenda.Font = ColumnFont;
            int dimCharcLegenda = this.Width / 55;
            Font LegendaFont = new Font("Calibri", dimCharcLegenda);
            lblInterventoFgas.Font = ColumnFont;
            lblInterventoControllo_Generale.Font = ColumnFont;
            lblInterventoManut_completa.Font = ColumnFont;
            lblInterventoManut_parziale.Font = ColumnFont;
            lblInterventoSostfiltri.Font = ColumnFont;
            lblSimboloControllo_generale.Font = LegendaFont;
            lblSimboloFgas.Font = LegendaFont;
            lblSimboloManut_completa.Font = LegendaFont;
            lblSimboloManut_parziale.Font = LegendaFont;
            lblSimboloSostFiltri.Font = LegendaFont;
            //1
            p.X = buffer;
            p.Y = ColumnFont.Height;
            lblInterventoManut_completa.Location = p;
            p.X = gbxLegenda.Width - LegendaFont.Height - buffer * 2;
            lblSimboloManut_completa.Location = p;
            //2
            p.X = buffer;
            p.Y = lblInterventoManut_completa.Location.Y + ColumnFont.Height + buffer;
            lblInterventoManut_parziale.Location = p;
            p.X = lblSimboloManut_completa.Location.X;
            lblSimboloManut_parziale.Location = p;
            //3
            p.X = buffer;
            p.Y = lblInterventoManut_parziale.Location.Y + ColumnFont.Height + buffer;
            lblInterventoControllo_Generale.Location = p;
            p.X = lblSimboloManut_completa.Location.X;
            lblSimboloControllo_generale.Location = p;
            //4
            p.X = buffer;
            p.Y = lblInterventoControllo_Generale.Location.Y + ColumnFont.Height + buffer;
            lblInterventoSostfiltri.Location = p;
            p.X = lblSimboloManut_completa.Location.X;
            lblSimboloSostFiltri.Location = p;
            //5
            p.X = buffer;
            p.Y = lblInterventoSostfiltri.Location.Y + ColumnFont.Height + buffer;
            lblInterventoFgas.Location = p;
            p.X = lblSimboloManut_completa.Location.X;
            lblSimboloFgas.Location = p;

            //dgwEventi
            p.X = lblEventi.Location.X;
            p.Y = lblEventi.Location.Y + lblEventi.Height + buffer;
            dgwEventi.Location = p;
            dgwEventi.Width = (tabPage1.Width - dgwEventi.Location.X) - (buffer * 3);
            dgwEventi.Height = ariCalendario.Height;
            dgwEventi.ColumnHeadersDefaultCellStyle.Font = ColumnFont;
            Font tabfont = new Font("Calibri", 20);
            dgwEventi.Font = tabfont;

            //fonttabcontrol
            tabControl1.Font = ColumnFont;

            //Command Strips
            //btnAdd
            p.Y = buffer / 2;
            p.X = buffer;
            btnAdd.Location = p;
            btnAdd.Width = btnLegenda.Height - buffer;
            btnAdd.Height = btnLegenda.Height - buffer;
            //btnModify
            p.X = btnAdd.Location.X + buffer + btnAdd.Width;
            btnModify.Location = p;
            btnModify.Width = btnAdd.Width;
            btnModify.Height = btnAdd.Width;
            //btnRemove
            p.X = btnModify.Location.X + buffer + btnAdd.Width;
            btnRemove.Location = p;
            btnRemove.Width = btnAdd.Width;
            btnRemove.Height = btnAdd.Width;

            //btnAddCustomer
            p.X = btnAdd.Location.X;
            btnClientiAddCustomer.Location = p;
            btnClientiAddCustomer.Width = btnAdd.Width;
            btnClientiAddCustomer.Height = btnAdd.Width;
            //btnEditCustomer
            p.X = btnClientiAddCustomer.Location.X + buffer + btnAdd.Width;
            btnClientiEditCustomer.Location = p;
            btnClientiEditCustomer.Width = btnAdd.Width;
            btnClientiEditCustomer.Height = btnAdd.Width;
            //btnDeleteCustomer
            p.X = btnClientiEditCustomer.Location.X + buffer + btnAdd.Width;
            btnClientiDeleteCustomer.Location = p;
            btnClientiDeleteCustomer.Width = btnAdd.Width;
            btnClientiDeleteCustomer.Height = btnAdd.Width;
            //eastereggpart
            if (mur.Visible == true)
            {
                p.X = btnClientiDeleteCustomer.Location.X + buffer + btnAdd.Width;
                mur.Location = p;
                mur.Width = btnClientiDeleteCustomer.Width;
                mur.Height = mur.Width;
            }


            //gbxDettagli
            if (r.DizGiorni!=null&& r.DizGiorni.ContainsKey(SelectedDate))
            {
                ResizeDetilsCose();
            }
            //
            //gbxaggiungi
            //
            p.X = ariCalendario.Location.X;
            p.Y = ariCalendario.Location.Y;
            gbxAggiungi.Location = p;
            gbxAggiungi.Width = ariCalendario.Width;
            gbxAggiungi.Height = (int)(tabPage1.Height / 1.17);
            //btnxonfermaaggiunta
            btnConfermaAggiungi.Height = gbxAggiungi.Height / 8;
            btnConfermaAggiungi.Width = gbxAggiungi.Width;
            p.X = 0;
            p.Y = gbxAggiungi.Height - btnConfermaAggiungi.Height;
            btnConfermaAggiungi.Location = p;
            btnConfermaAggiungi.Font = ColumnFont;
            //lblaggiungicliente
            p.X = buffer * 2;
            p.Y = gbxAggiungi.Height / 16;
            lblAggCliente.Location = p;
            lblAggCliente.Font = ColumnFont;
            //lblaggiungimacchina
            p.Y = lblAggCliente.Location.Y + ColumnFont.Height + gbxAggiungi.Height / 50;
            lblMacchina.Location = p;
            lblMacchina.Font = ColumnFont;
            //cbxaggiungicliente
            p.Y = lblAggCliente.Location.Y;
            p.X = lblMacchina.Location.X + lblMacchina.Width;
            cBxAggiungiEventoCliente.Location = p;
            cBxAggiungiEventoCliente.Font = ColumnFont;
            cBxAggiungiEventoCliente.Width = gbxAggiungi.Width - cBxAggiungiEventoCliente.Location.X - buffer * 2;
            //cbxaggiungimacchina
            p.X = cBxAggiungiEventoCliente.Location.X;
            p.Y = lblMacchina.Location.Y;
            cBxAggiungiEventoMacchine.Location = p;
            cBxAggiungiEventoMacchine.Font = ColumnFont;
            cBxAggiungiEventoMacchine.Width = gbxAggiungi.Width - cBxAggiungiEventoCliente.Location.X - buffer * 2;
            //lblaggiungiinterventi
            p.X = buffer * 2;
            p.Y = lblMacchina.Location.Y + ColumnFont.Height + gbxAggiungi.Height / 50;
            lblAggiungiDispListaIntervent.Location = p;
            lblAggiungiDispListaIntervent.Font = ColumnFont;
            //lbllista
            p.X = lblAggiungiDispListaIntervent.Width + gbxAggiungi.Width / 6;
            lblAggiungiLista.Location = p;
            lblAggiungiLista.Font = ColumnFont;
            //btnaggiungiintervento
            p.X = buffer * 2;
            p.Y = lblAggiungiDispListaIntervent.Location.Y + ColumnFont.Height + gbxAggiungi.Height / 50;
            btnAggiungiAddintervento.Location = p;
            btnAggiungiAddintervento.Width = lblAggiungiDispListaIntervent.Width;
            //cbxintterventi
            p.X = btnAggiungiAddintervento.Location.X + btnAggiungiAddintervento.Width + buffer;
            comboBoxAggiungi.Location = p;
            comboBoxAggiungi.Width = gbxAggiungi.Width - comboBoxAggiungi.Location.X - buffer * 2;
            comboBoxAggiungi.Font = ColumnFont;
            comboBoxAggiungi.Height = btnAggiungiAddintervento.Height;
            //btnaggiungiintervento ancora
            btnAggiungiAddintervento.Height = comboBoxAggiungi.Height;
            //btnrimuoviintervento
            p.X = buffer * 2;
            p.Y = btnAggiungiAddintervento.Location.Y + btnAggiungiAddintervento.Height + buffer;
            btnAggiungiRimuoviintervento.Location = p;
            btnAggiungiRimuoviintervento.Width = btnAggiungiAddintervento.Width;
            btnAggiungiRimuoviintervento.Height = btnAggiungiAddintervento.Height;
            //listview
            p.X = comboBoxAggiungi.Location.X;
            listViewAggiungiIntervento.Location = p;
            listViewAggiungiIntervento.Width = comboBoxAggiungi.Width;
            listViewAggiungiIntervento.Height = (int)(gbxAggiungi.Height / 5);
            //lblnote
            p.X = buffer * 2;
            p.Y = listViewAggiungiIntervento.Location.Y + listViewAggiungiIntervento.Height + gbxAggiungi.Height / 50;
            lblAggiungiNote.Location = p;
            lblAggiungiNote.Font = ColumnFont;
            //rtbnote
            p.Y = lblAggiungiNote.Location.Y + ColumnFont.Height + buffer;
            rtbAggiungiNote.Location = p;
            rtbAggiungiNote.Width = gbxAggiungi.Width - buffer * 4;
            rtbAggiungiNote.Height = gbxAggiungi.Height - rtbAggiungiNote.Location.Y - btnConfermaAggiungi.Height - buffer;

            //
            //gbxmodifica
            //
            gbxModifica.Location = gbxAggiungi.Location;
            gbxModifica.Width = gbxAggiungi.Width;
            gbxModifica.Height = gbxAggiungi.Height;
            //btnconfermamodifica
            btnConfermaModifica.Location = btnConfermaAggiungi.Location;
            btnConfermaModifica.Width = btnConfermaAggiungi.Width;
            btnConfermaModifica.Height = btnConfermaAggiungi.Height;
            btnConfermaModifica.Font = ColumnFont;
            //
            //lblmodificacliente
            p.X = buffer * 2;
            p.Y = gbxAggiungi.Height / 16;
            lblModificaCliente.Location = p;
            lblModificaCliente.Font = ColumnFont;
            //lblaggiungimacchina
            p.Y = lblModificaCliente.Location.Y + ColumnFont.Height + gbxAggiungi.Height / 50;
            lblModificaEventoMacchine.Location = p;
            lblModificaEventoMacchine.Font = ColumnFont;
            //cbxaggiungicliente
            p.Y = lblAggCliente.Location.Y;
            p.X = lblModificaEventoMacchine.Location.X + lblModificaEventoMacchine.Width;
            cBxModificaEventoCliente.Location = p;
            cBxModificaEventoCliente.Font = ColumnFont;
            cBxModificaEventoCliente.Width = gbxAggiungi.Width - cBxModificaEventoCliente.Location.X - buffer * 2;
            //cbxaggiungimacchina
            p.X = cBxModificaEventoCliente.Location.X;
            p.Y = lblModificaEventoMacchine.Location.Y;
            cBxModificaEventoMacchine.Location = p;
            cBxModificaEventoMacchine.Font = ColumnFont;
            cBxModificaEventoMacchine.Width = gbxAggiungi.Width - cBxModificaEventoCliente.Location.X - buffer * 2;
            //lblaggiungiinterventi
            p.X = buffer * 2;
            p.Y = lblMacchina.Location.Y + ColumnFont.Height + gbxAggiungi.Height / 50;
            lblModificaEventoInterventi.Location = p;
            lblModificaEventoInterventi.Font = ColumnFont;
            //lbllista
            p.X = lblAggiungiDispListaIntervent.Width + gbxAggiungi.Width / 6;
            lblModificaEventoLista.Location = p;
            lblModificaEventoLista.Font = ColumnFont;
            //btnaggiungiintervento
            p.X = buffer * 2;
            p.Y = lblAggiungiDispListaIntervent.Location.Y + ColumnFont.Height + gbxAggiungi.Height / 50;
            btnModificaAggiungiOperazioni.Location = p;
            btnModificaAggiungiOperazioni.Width = lblAggiungiDispListaIntervent.Width;
            //cbxintterventi
            p.X = btnAggiungiAddintervento.Location.X + btnAggiungiAddintervento.Width + buffer;
            cbxModificaListaOperazioni.Location = p;
            cbxModificaListaOperazioni.Width = gbxAggiungi.Width - comboBoxAggiungi.Location.X - buffer * 2;
            cbxModificaListaOperazioni.Font = ColumnFont;
            cbxModificaListaOperazioni.Height = btnAggiungiAddintervento.Height;
            //btnaggiungiintervento ancora
            btnModificaAggiungiOperazioni.Height = comboBoxAggiungi.Height;
            //btnrimuoviintervento
            p.X = buffer * 2;
            p.Y = btnAggiungiAddintervento.Location.Y + btnAggiungiAddintervento.Height + buffer;
            btnModificaRimuoviOperazioni.Location = p;
            btnModificaRimuoviOperazioni.Width = btnAggiungiAddintervento.Width;
            btnModificaRimuoviOperazioni.Height = btnAggiungiAddintervento.Height;
            //listview
            p.X = comboBoxAggiungi.Location.X;
            listViewModificaOperazioni.Location = p;
            listViewModificaOperazioni.Width = comboBoxAggiungi.Width;
            listViewModificaOperazioni.Height = (int)(gbxAggiungi.Height / 5);
            //lblnote
            p.X = buffer * 2;
            p.Y = listViewAggiungiIntervento.Location.Y + listViewAggiungiIntervento.Height + gbxAggiungi.Height / 50;
            lblModificaEventoNote.Location = p;
            lblModificaEventoNote.Font = ColumnFont;
            //rtbnote
            p.Y = lblAggiungiNote.Location.Y + ColumnFont.Height + buffer;
            rtbModificaNote.Location = p;
            rtbModificaNote.Width = gbxAggiungi.Width - buffer * 4;
            rtbModificaNote.Height = gbxAggiungi.Height - rtbAggiungiNote.Location.Y - btnConfermaAggiungi.Height - buffer;



            //
            //PanelClienti
            //
            //gbxClientiTrova
            p.X = pnlCommands2.Location.X;
            p.Y = pnlCommands2.Location.Y + pnlCommands2.Height + buffer;
            gBxClientiTrova.Location = p;
            gBxClientiTrova.Width = (int)(tabPage2.Width / 3.4);
            gBxClientiTrova.Height = (int)(tabPage2.Height / 1.17);
            gBxClientiTrova.Font = ColumnFont;
            p.X = buffer * 2;
            p.Y = ColumnFont.Height + buffer;
            rdBtnTrovaPerNome.Location = p;
            p.Y = rdBtnTrovaPerNome.Location.Y + ColumnFont.Height + buffer;
            cbBxTrovaPerNome.Location = p;
            p.Y = cbBxTrovaPerNome.Location.Y + cbBxTrovaPerNome.Height + buffer;
            rdBtnTrovaPerPRif.Location = p;
            p.Y = rdBtnTrovaPerPRif.Location.Y + ColumnFont.Height + buffer;
            cbBxTrovaPerPRif.Location = p;
            p.Y = cbBxTrovaPerPRif.Location.Y + cbBxTrovaPerPRif.Height + buffer;
            rdBtnTrovaPerMail.Location = p;
            p.Y = rdBtnTrovaPerMail.Location.Y + ColumnFont.Height + buffer;
            cbBxTrovaPerMail.Location = p;
            p.Y = cbBxTrovaPerMail.Location.Y + cbBxTrovaPerMail.Height + buffer;
            rdBtnTrovaPerMatricola.Location = p;
            p.Y = rdBtnTrovaPerMatricola.Location.Y + ColumnFont.Height + buffer;
            cbBxTrovaPerMatricola.Location = p;
            //btneliminafiltri
            btnEliminaFiltridgvVisualizzaClienti.Width = gBxClientiTrova.Width;
            btnEliminaFiltridgvVisualizzaClienti.Height = (int)(gBxClientiTrova.Height / 12);
            p.X = 0;
            p.Y = gBxClientiTrova.Height - btnEliminaFiltridgvVisualizzaClienti.Height;
            btnEliminaFiltridgvVisualizzaClienti.Location = p;
            //
            //gbxaggiungiclienti
            //
            gBxClientiAggiungiCliente.Location = gBxClientiTrova.Location;
            gBxClientiAggiungiCliente.Width = gBxClientiTrova.Width;
            gBxClientiAggiungiCliente.Height = gBxClientiTrova.Height;
            gBxClientiAggiungiCliente.Font = ColumnFont;
            lblAggiungiClienteNome.Font = ColumnFont;
            //1strow
            p.X = buffer * 2;
            p.Y = ColumnFont.Height + buffer;
            lblAggiungiClienteNome.Location = p;
            p.X = lblAggiungiClienteNome.Location.X + lblAggiungiClienteNome.Width;
            tbxAggiungiClienteNome.Location = p;
            tbxAggiungiClienteNome.Width = gBxClientiAggiungiCliente.Width - (p.X) - (buffer * 2);
            tbxAggiungiClienteNome.Font = ColumnFont;
            //2ndtrow
            p.X = buffer * 2;
            p.Y = lblAggiungiClienteNome.Location.Y + lblAggiungiClienteNome.Height + buffer;
            lblAggiungiClienteTel.Font = ColumnFont;
            lblAggiungiClienteTel.Location = p;
            p.X = tbxAggiungiClienteNome.Location.X;
            tbxAggiungiClienteTel.Location = p;
            tbxAggiungiClienteTel.Width = gBxClientiAggiungiCliente.Width - (p.X) - (buffer * 2);
            tbxAggiungiClienteTel.Font = ColumnFont;
            //3rdtrow
            p.X = buffer * 2;
            p.Y = lblAggiungiClienteTel.Location.Y + lblAggiungiClienteTel.Height + buffer;
            lblAggiungiClienteMail.Font = ColumnFont;
            lblAggiungiClienteMail.Location = p;
            p.X = tbxAggiungiClienteTel.Location.X;
            tbxAggiungiClienteMail.Location = p;
            tbxAggiungiClienteMail.Width = gBxClientiAggiungiCliente.Width - (p.X) - (buffer * 2);
            tbxAggiungiClienteMail.Font = ColumnFont;
            //4thtrow
            p.X = buffer * 2;
            p.Y = lblAggiungiClienteMail.Location.Y + lblAggiungiClienteMail.Height + buffer;
            lblAggiungiClienteInd.Font = ColumnFont;
            lblAggiungiClienteInd.Location = p;
            p.X = tbxAggiungiClienteMail.Location.X;
            tbxAggiungiClienteInd.Location = p;
            tbxAggiungiClienteInd.Width = gBxClientiAggiungiCliente.Width - (p.X) - (buffer * 2);
            tbxAggiungiClienteInd.Font = ColumnFont;
            //5thtrow
            p.X = buffer * 2;
            p.Y = lblAggiungiClienteInd.Location.Y + lblAggiungiClienteInd.Height + buffer;
            lblAggiungiClienteIVA.Font = ColumnFont;
            lblAggiungiClienteIVA.Location = p;
            p.X = tbxAggiungiClienteInd.Location.X;
            tbxAggiungiClienteIVA.Location = p;
            tbxAggiungiClienteIVA.Width = gBxClientiAggiungiCliente.Width - (p.X) - (buffer * 2);
            tbxAggiungiClienteIVA.Font = ColumnFont;
            //6thtrow
            p.X = buffer * 2;
            p.Y = lblAggiungiClienteIVA.Location.Y + lblAggiungiClienteIVA.Height + buffer;
            lblAggiungiClientePrif.Font = ColumnFont;
            lblAggiungiClientePrif.Location = p;
            p.X = tbxAggiungiClienteIVA.Location.X;
            tbxAggiungiClientePrif.Location = p;
            tbxAggiungiClientePrif.Width = gBxClientiAggiungiCliente.Width - (p.X) - (buffer * 2);
            tbxAggiungiClientePrif.Font = ColumnFont;
            //macchine/accessori
            lblAggiungiClientiMacchineAccessori.Font = ColumnFont;
            p.Y = lblAggiungiClientePrif.Location.Y + lblAggiungiClientePrif.Height + (buffer * 2);
            lblAggiungiClientiMacchineAccessori.Location = p;
            //pnlbuttons
            p.X = buffer * 2;
            p.Y = lblAggiungiClientiMacchineAccessori.Location.Y + lblAggiungiClientiMacchineAccessori.Height + buffer;
            pnlAggiungiClienteButtonsMacchina.Location = p;
            pnlAggiungiClienteButtonsMacchina.Width = (int)((lblEventiFont.Height - buffer) * 1.3) * 3 + buffer * 4;
            pnlAggiungiClienteButtonsMacchina.Height = pnlCommands2.Height;
            //buttons
            p.X = buffer;
            p.Y = buffer / 2;
            btnAggiungiAggiungiMacchina.Location = p;
            btnAggiungiAggiungiMacchina.Height = btnClientiAddCustomer.Height;
            btnAggiungiAggiungiMacchina.Width = (int)(btnAggiungiAggiungiMacchina.Height * 1.3);
            p.X = btnAggiungiAggiungiMacchina.Location.X + btnAggiungiAggiungiMacchina.Width + buffer;
            btnAggiungiModificaMacchina.Location = p;
            btnAggiungiModificaMacchina.Height = btnClientiAddCustomer.Height;
            btnAggiungiModificaMacchina.Width = btnAggiungiAggiungiMacchina.Width;
            p.X = btnAggiungiModificaMacchina.Location.X + btnAggiungiModificaMacchina.Width + buffer;
            btnAggiungiEliminaMacchina.Location = p;
            btnAggiungiEliminaMacchina.Height = btnClientiAddCustomer.Height;
            btnAggiungiEliminaMacchina.Width = btnAggiungiAggiungiMacchina.Width;
            //btnconfermaaggiungicliente
            btnConfermaAggiungiCliente.Height = gBxClientiAggiungiCliente.Height / 12;
            p.Y = gBxClientiAggiungiCliente.Height - btnConfermaAggiungiCliente.Height;
            p.X = 0;
            btnConfermaAggiungiCliente.Location = p;
            btnConfermaAggiungiCliente.Font = EverithingFont;
            btnConfermaAggiungiCliente.Width = gBxClientiAggiungiCliente.Width;
            //tabella
            p.Y = pnlAggiungiClienteButtonsMacchina.Location.Y + pnlAggiungiClienteButtonsMacchina.Height + buffer;
            p.X = buffer;
            lvwAggiungiClientiMacchine.Location = p;
            lvwAggiungiClientiMacchine.Width = gBxClientiAggiungiCliente.Width - buffer * 2;
            lvwAggiungiClientiMacchine.Columns[0].Width = (int)(lvwAggiungiClientiMacchine.Width / 3.02);
            lvwAggiungiClientiMacchine.Columns[1].Width = (int)(lvwAggiungiClientiMacchine.Width / 3.02);
            lvwAggiungiClientiMacchine.Columns[2].Width = (int)(lvwAggiungiClientiMacchine.Width / 3.02);
            lvwAggiungiClientiMacchine.Height = btnConfermaAggiungiCliente.Location.Y - lvwAggiungiClientiMacchine.Location.Y - buffer;
            //dgvvisualizzaclienti

            p.X = gBxClientiTrova.Location.X + gBxClientiTrova.Width + buffer;
            p.Y = ColumnFont.Height;
            lblClienti.Font = ColumnFont;
            lblClienti.Location = p;
            p.Y = gBxClientiTrova.Location.Y;
            dgvVisualizzaClienti.Location = p;
            dgvVisualizzaClienti.Height = gBxClientiTrova.Height;
            dgvVisualizzaClienti.Width = tabPage2.Width - gBxClientiTrova.Width * 2 - buffer * 6;
            Font tabfontclienti = new Font("Calibri", 14);
            dgvVisualizzaClienti.Font = tabfontclienti;
            dgvVisualizzaClienti.ColumnHeadersDefaultCellStyle.Font = ColumnFont;
            //gbxvisualizza clienti
            p.Y = gBxClientiTrova.Location.Y;
            p.X = dgvVisualizzaClienti.Location.X + dgvVisualizzaClienti.Width + buffer;
            gBxVisualizzaCliente.Location = p;
            gBxVisualizzaCliente.Width = gBxClientiTrova.Width;
            gBxVisualizzaCliente.Height = gBxClientiTrova.Height;
            gBxVisualizzaCliente.Font = ColumnFont;
            //picture per clienti
            pbxAlloStoricoCliente.Width = (int)(gBxVisualizzaCliente.Width / 8);
            pbxAlloStoricoCliente.Height = pbxAlloStoricoCliente.Width;
            p.Y = 0;
            p.X = gBxVisualizzaCliente.Width - pbxAlloStoricoCliente.Width;
            pbxAlloStoricoCliente.Location = p;
            //1st row
            p.X = buffer * 2;
            p.Y = pbxAlloStoricoCliente.Height + buffer;
            lblMostraIva.Location = p;
            lblMostraIva.Font = ColumnFont;
            p.X = lblMostraIva.Location.X + lblMostraIva.Width;
            tbxMostraIva.Location = p;
            tbxMostraIva.Font = ColumnFont;
            tbxMostraIva.Width = gBxVisualizzaCliente.Width - tbxMostraIva.Location.X - buffer * 2;
            //2st row
            p.X = buffer * 2;
            p.Y = lblMostraIva.Location.Y + lblMostraIva.Height + buffer;
            lblMostraPrif.Location = p;
            lblMostraPrif.Font = ColumnFont;
            p.X = tbxMostraIva.Location.X;
            tbxMostraPrif.Location = p;
            tbxMostraPrif.Font = ColumnFont;
            tbxMostraPrif.Width = tbxMostraIva.Width;
            //picture per macchine
            pbxAlloStoricoMacchina.Width = (int)(pbxAlloStoricoCliente.Width / 1.5);
            pbxAlloStoricoMacchina.Height = pbxAlloStoricoMacchina.Width;
            p.Y = tbxMostraPrif.Location.Y + tbxMostraPrif.Height + buffer;
            p.X = buffer * 2;
            pbxAlloStoricoMacchina.Location = p;
            //labelmacchine
            p.X = pbxAlloStoricoMacchina.Location.X + pbxAlloStoricoMacchina.Width + buffer;
            lblMostraMacchineAccessori.Location = p;
            lblMostraMacchineAccessori.Font = ColumnFont;
            //lvwmostramacchine
            p.X = buffer * 2;
            p.Y = lblMostraMacchineAccessori.Location.Y + ColumnFont.Height + buffer;
            lvwMostraMacchineAccessori.Location = p;
            lvwMostraMacchineAccessori.Width = gBxVisualizzaCliente.Width - buffer * 4;
            lvwMostraMacchineAccessori.Columns[0].Width = (int)(lvwMostraMacchineAccessori.Width / 3.5);
            lvwMostraMacchineAccessori.Columns[1].Width = (int)(lvwMostraMacchineAccessori.Width / 2.85);
            lvwMostraMacchineAccessori.Columns[2].Width = (int)(lvwMostraMacchineAccessori.Width / 2.85);
            lvwMostraMacchineAccessori.Height = gBxVisualizzaCliente.Height / 4;
            //lblnote
            p.X = buffer * 2;
            p.Y = lvwMostraMacchineAccessori.Location.Y + lvwMostraMacchineAccessori.Height + buffer;
            lblMostraNote.Location = p;
            lblMostraNote.Font = ColumnFont;
            //lblcomponenti
            p.X = gBxVisualizzaCliente.Width / 2;
            lblMostraComponenti.Location = p;
            lblMostraComponenti.Font = ColumnFont;
            //rtbNote
            p.X = buffer * 2;
            p.Y = lblMostraNote.Location.Y + lblMostraNote.Height;
            rtbMostraNote.Font = tabfont;
            rtbMostraNote.Location = p;
            rtbMostraNote.Width = (int)(gBxVisualizzaCliente.Width / 3.5);
            rtbMostraNote.Height = gBxVisualizzaCliente.Height - p.Y - buffer * 2 - ColumnFont.Height;
            rtbMostraNote.Font = tabfontclienti;
            //chbxmostranoleggio
            chbxMostraNoleggio.Font = ColumnFont;
            p.X = buffer * 2;
            p.Y = rtbMostraNote.Location.Y + rtbMostraNote.Height + buffer;
            chbxMostraNoleggio.Location = p;
            //lvwcomponenti
            p.Y = rtbMostraNote.Location.Y;
            p.X = rtbMostraNote.Location.X + rtbMostraNote.Width + buffer;
            lvwMostraComponenti.Location = p;
            lvwMostraComponenti.Height = rtbMostraNote.Height + ColumnFont.Height + buffer;
            lvwMostraComponenti.Width = gBxVisualizzaCliente.Width - rtbMostraNote.Width - buffer * 5;
            lvwMostraComponenti.Columns[0].Width = (int)(lvwMostraComponenti.Width / 2.03);
            lvwMostraComponenti.Columns[1].Width = (int)(lvwMostraComponenti.Width / 2.03);

            //
            //gbxmodificaclienti
            //
            gBxClientiModificaClienti.Location = gBxClientiTrova.Location;
            gBxClientiModificaClienti.Width = gBxClientiTrova.Width;
            gBxClientiModificaClienti.Height = gBxClientiTrova.Height;
            gBxClientiModificaClienti.Font = ColumnFont;
            lblModificaClienteNome.Font = ColumnFont;
            //1strow
            p.X = buffer * 2;
            p.Y = ColumnFont.Height + buffer;
            lblModificaClienteNome.Location = p;
            p.X = lblAggiungiClienteNome.Location.X + lblAggiungiClienteNome.Width;
            txBxModificaClienteNome.Location = p;
            txBxModificaClienteNome.Width = gBxClientiAggiungiCliente.Width - (p.X) - (buffer * 2);
            txBxModificaClienteNome.Font = ColumnFont;
            //2ndtrow
            p.X = buffer * 2;
            p.Y = lblAggiungiClienteNome.Location.Y + lblAggiungiClienteNome.Height + buffer;
            lblModificaClienteTel.Font = ColumnFont;
            lblModificaClienteTel.Location = p;
            p.X = tbxAggiungiClienteNome.Location.X;
            txBxModificaClienteTel.Location = p;
            txBxModificaClienteTel.Width = gBxClientiAggiungiCliente.Width - (p.X) - (buffer * 2);
            txBxModificaClienteTel.Font = ColumnFont;
            //3rdtrow
            p.X = buffer * 2;
            p.Y = lblAggiungiClienteTel.Location.Y + lblAggiungiClienteTel.Height + buffer;
            lblModificaClienteMail.Font = ColumnFont;
            lblModificaClienteMail.Location = p;
            p.X = tbxAggiungiClienteTel.Location.X;
            txBxModificaClienteMail.Location = p;
            txBxModificaClienteMail.Width = gBxClientiAggiungiCliente.Width - (p.X) - (buffer * 2);
            txBxModificaClienteMail.Font = ColumnFont;
            //4thtrow
            p.X = buffer * 2;
            p.Y = lblAggiungiClienteMail.Location.Y + lblAggiungiClienteMail.Height + buffer;
            lblModificaClienteInd.Font = ColumnFont;
            lblModificaClienteInd.Location = p;
            p.X = tbxAggiungiClienteMail.Location.X;
            txBxModificaClienteInd.Location = p;
            txBxModificaClienteInd.Width = gBxClientiAggiungiCliente.Width - (p.X) - (buffer * 2);
            txBxModificaClienteInd.Font = ColumnFont;
            //5thtrow
            p.X = buffer * 2;
            p.Y = lblAggiungiClienteInd.Location.Y + lblAggiungiClienteInd.Height + buffer;
            lblModificaClienteIva.Font = ColumnFont;
            lblModificaClienteIva.Location = p;
            p.X = tbxAggiungiClienteInd.Location.X;
            txBxModificaClienteIva.Location = p;
            txBxModificaClienteIva.Width = gBxClientiAggiungiCliente.Width - (p.X) - (buffer * 2);
            txBxModificaClienteIva.Font = ColumnFont;
            //6thtrow
            p.X = buffer * 2;
            p.Y = lblAggiungiClienteIVA.Location.Y + lblAggiungiClienteIVA.Height + buffer;
            lblModificaClientePrif.Font = ColumnFont;
            lblModificaClientePrif.Location = p;
            p.X = tbxAggiungiClienteIVA.Location.X;
            txBxModificaClientePrif.Location = p;
            txBxModificaClientePrif.Width = gBxClientiAggiungiCliente.Width - (p.X) - (buffer * 2);
            txBxModificaClientePrif.Font = ColumnFont;
            //macchine/accessori
            lblModificaClienteMacchinaAccessori.Font = ColumnFont;
            p.Y = lblAggiungiClientePrif.Location.Y + lblAggiungiClientePrif.Height + (buffer * 2);
            lblModificaClienteMacchinaAccessori.Location = p;
            //pnlbuttons
            p.X = buffer * 2;
            p.Y = lblAggiungiClientiMacchineAccessori.Location.Y + lblAggiungiClientiMacchineAccessori.Height + buffer;
            pnlModificaClienteMacchine.Location = p;
            pnlModificaClienteMacchine.Width = (int)((lblEventiFont.Height - buffer) * 1.3) * 3 + buffer * 4;
            pnlModificaClienteMacchine.Height = pnlCommands2.Height;
            //buttons
            p.X = buffer;
            p.Y = buffer / 2;
            btnModificaAggiungiMacchina.Location = p;
            btnModificaAggiungiMacchina.Height = btnClientiAddCustomer.Height;
            btnModificaAggiungiMacchina.Width = (int)(btnAggiungiAggiungiMacchina.Height * 1.3);
            p.X = btnAggiungiAggiungiMacchina.Location.X + btnAggiungiAggiungiMacchina.Width + buffer;
            btnModificaModificaMacchina.Location = p;
            btnModificaModificaMacchina.Height = btnClientiAddCustomer.Height;
            btnModificaModificaMacchina.Width = btnAggiungiAggiungiMacchina.Width;
            p.X = btnAggiungiModificaMacchina.Location.X + btnAggiungiModificaMacchina.Width + buffer;
            btnModificaEliminaMacchina.Location = p;
            btnModificaEliminaMacchina.Height = btnClientiAddCustomer.Height;
            btnModificaEliminaMacchina.Width = btnAggiungiAggiungiMacchina.Width;
            //btnconfermaaggiungicliente
            btnConfermaModificaCliente.Height = gBxClientiAggiungiCliente.Height / 12;
            p.Y = gBxClientiAggiungiCliente.Height - btnConfermaAggiungiCliente.Height;
            p.X = 0;
            btnConfermaModificaCliente.Location = p;
            btnConfermaModificaCliente.Font = EverithingFont;
            btnConfermaModificaCliente.Width = gBxClientiAggiungiCliente.Width;
            //tabella
            p.Y = pnlAggiungiClienteButtonsMacchina.Location.Y + pnlAggiungiClienteButtonsMacchina.Height + buffer;
            p.X = buffer;
            lvwModificaCliente.Location = p;
            lvwModificaCliente.Width = gBxClientiAggiungiCliente.Width - buffer * 2;
            lvwModificaCliente.Columns[0].Width = (int)(lvwAggiungiClientiMacchine.Width / 3.02);
            lvwModificaCliente.Columns[1].Width = (int)(lvwAggiungiClientiMacchine.Width / 3.02);
            lvwModificaCliente.Columns[2].Width = (int)(lvwAggiungiClientiMacchine.Width / 3.02);
            lvwModificaCliente.Height = btnConfermaAggiungiCliente.Location.Y - lvwAggiungiClientiMacchine.Location.Y - buffer;
            //
            //dgvvisualizzaclienti
            //
            p.X = gBxClientiTrova.Location.X + gBxClientiTrova.Width + buffer;
            p.X = gBxClientiTrova.Location.X + gBxClientiTrova.Width + buffer;
            p.Y = gBxClientiTrova.Location.Y;
            dgvVisualizzaClienti.Location = p;
            dgvVisualizzaClienti.Height = gBxClientiTrova.Height;
            dgvVisualizzaClienti.Width = tabPage2.Width - gBxClientiTrova.Width * 2 - buffer * 6;
            dgvVisualizzaClienti.Font = tabfontclienti;
            dgvVisualizzaClienti.ColumnHeadersDefaultCellStyle.Font = ColumnFont;
            //gbxvisualizza clienti
            p.Y = gBxClientiTrova.Location.Y;
            p.X = dgvVisualizzaClienti.Location.X + dgvVisualizzaClienti.Width + buffer;
            gBxVisualizzaCliente.Location = p;
            gBxVisualizzaCliente.Width = gBxClientiTrova.Width;
            gBxVisualizzaCliente.Height = gBxClientiTrova.Height;
            gBxVisualizzaCliente.Font = ColumnFont;
            //picture per clienti
            pbxAlloStoricoCliente.Width = (int)(gBxVisualizzaCliente.Width / 8);
            pbxAlloStoricoCliente.Height = pbxAlloStoricoCliente.Width;
            p.Y = 0;
            p.X = gBxVisualizzaCliente.Width - pbxAlloStoricoCliente.Width;
            pbxAlloStoricoCliente.Location = p;
            //1st row
            p.X = buffer * 2;
            p.Y = pbxAlloStoricoCliente.Height + buffer;
            lblMostraIva.Location = p;
            lblMostraIva.Font = ColumnFont;
            p.X = lblMostraIva.Location.X + lblMostraIva.Width;
            tbxMostraIva.Location = p;
            tbxMostraIva.Font = ColumnFont;
            tbxMostraIva.Width = gBxVisualizzaCliente.Width - tbxMostraIva.Location.X - buffer * 2;
            //2st row
            p.X = buffer * 2;
            p.Y = lblMostraIva.Location.Y + lblMostraIva.Height + buffer;
            lblMostraPrif.Location = p;
            lblMostraPrif.Font = ColumnFont;
            p.X = tbxMostraIva.Location.X;
            tbxMostraPrif.Location = p;
            tbxMostraPrif.Font = ColumnFont;
            tbxMostraPrif.Width = tbxMostraIva.Width;
            //picture per macchine
            pbxAlloStoricoMacchina.Width = (int)(pbxAlloStoricoCliente.Width / 1.5);
            pbxAlloStoricoMacchina.Height = pbxAlloStoricoMacchina.Width;
            p.Y = tbxMostraPrif.Location.Y + tbxMostraPrif.Height + buffer;
            p.X = buffer * 2;
            pbxAlloStoricoMacchina.Location = p;
            //labelmacchine
            p.X = pbxAlloStoricoMacchina.Location.X + pbxAlloStoricoMacchina.Width + buffer;
            lblMostraMacchineAccessori.Location = p;
            lblMostraMacchineAccessori.Font = ColumnFont;
            //lvwmostramacchine
            p.X = buffer * 2;
            p.Y = lblMostraMacchineAccessori.Location.Y + ColumnFont.Height + buffer;
            lvwMostraMacchineAccessori.Location = p;
            lvwMostraMacchineAccessori.Width = gBxVisualizzaCliente.Width - buffer * 4;
            lvwMostraMacchineAccessori.Columns[0].Width = (int)(lvwMostraMacchineAccessori.Width / 3.5);
            lvwMostraMacchineAccessori.Columns[1].Width = (int)(lvwMostraMacchineAccessori.Width / 2.85);
            lvwMostraMacchineAccessori.Columns[2].Width = (int)(lvwMostraMacchineAccessori.Width / 2.85);
            lvwMostraMacchineAccessori.Height = gBxVisualizzaCliente.Height / 4;
            //lblnote
            p.X = buffer * 2;
            p.Y = lvwMostraMacchineAccessori.Location.Y + lvwMostraMacchineAccessori.Height + buffer;
            lblMostraNote.Location = p;
            lblMostraNote.Font = ColumnFont;
            //lblcomponenti
            p.X = gBxVisualizzaCliente.Width / 2;
            lblMostraComponenti.Location = p;
            lblMostraComponenti.Font = ColumnFont;
            //rtbNote
            p.X = buffer * 2;
            p.Y = lblMostraNote.Location.Y + lblMostraNote.Height;
            rtbMostraNote.Font = tabfont;
            rtbMostraNote.Location = p;
            rtbMostraNote.Width = (int)(gBxVisualizzaCliente.Width / 3.5);
            rtbMostraNote.Height = gBxVisualizzaCliente.Height - p.Y - buffer * 2 - ColumnFont.Height;
            rtbMostraNote.Font = tabfontclienti;
            //chbxmostranoleggio
            chbxMostraNoleggio.Font = ColumnFont;
            p.X = buffer * 2;
            p.Y = rtbMostraNote.Location.Y + rtbMostraNote.Height + buffer;
            chbxMostraNoleggio.Location = p;
            //lvwcomponenti
            p.Y = rtbMostraNote.Location.Y;
            p.X = rtbMostraNote.Location.X + rtbMostraNote.Width + buffer;
            lvwMostraComponenti.Location = p;
            lvwMostraComponenti.Height = rtbMostraNote.Height + ColumnFont.Height + buffer;
            lvwMostraComponenti.Width = gBxVisualizzaCliente.Width - rtbMostraNote.Width - buffer * 5;
            lvwMostraComponenti.Columns[0].Width = (int)(lvwMostraComponenti.Width / 2.03);
            lvwMostraComponenti.Columns[1].Width = (int)(lvwMostraComponenti.Width / 2.03);

            //
            //gbxaggiungimacchina
            //
            gBxAggiungiMacchina.Font = ColumnFont;
            p = dgvVisualizzaClienti.Location;
            gBxAggiungiMacchina.Location = p;
            gBxAggiungiMacchina.Width = dgvVisualizzaClienti.Width;
            gBxAggiungiMacchina.Height = gBxClientiAggiungiCliente.Height;
            //lblmarca
            lblAggiungiMacchinaMarca.Font = ColumnFont;
            p.X = buffer * 2;
            p.Y = lblAggiungiClienteNome.Location.Y;
            lblAggiungiMacchinaMarca.Location = p;
            //tbxmarca
            p.Y = lblAggiungiMacchinaMarca.Location.Y + ColumnFont.Height + buffer;
            txBxAggiungiMacchinaMarca.Location = p;
            txBxAggiungiMacchinaMarca.Width = gBxAggiungiMacchina.Width - buffer * 4;
            //lblmodello
            p.Y = txBxAggiungiMacchinaMarca.Location.Y + txBxAggiungiMacchinaMarca.Height;
            lblAggiungiMacchinaModello.Location = p;
            lblAggiungiMacchinaModello.Font = ColumnFont;
            //tbxmodello
            p.Y = lblAggiungiMacchinaModello.Location.Y + ColumnFont.Height + buffer;
            txBxAggiungiMacchinaModello.Location = p;
            txBxAggiungiMacchinaModello.Width = gBxAggiungiMacchina.Width - buffer * 4;
            //lblmatricola
            p.Y = txBxAggiungiMacchinaModello.Location.Y + txBxAggiungiMacchinaModello.Height + buffer;
            lblAggiungiMacchinaMatricola.Location = p;
            lblAggiungiMacchinaMatricola.Font = ColumnFont;
            //tbxmatricola
            p.Y = lblAggiungiMacchinaMatricola.Location.Y + ColumnFont.Height + buffer;
            txBxAggiungiMacchinaMatricola.Location = p;
            txBxAggiungiMacchinaMatricola.Width = gBxAggiungiMacchina.Width - buffer * 4;
            //chbxnodello
            p.Y = txBxAggiungiMacchinaMatricola.Location.Y + txBxAggiungiMacchinaMatricola.Height + buffer;
            chBxAggiungiMacchinaNoleggio.Location = p;
            chBxAggiungiMacchinaNoleggio.Font = ColumnFont;
            //lblcomponenti
            p.X = chBxAggiungiMacchinaNoleggio.Location.X + chBxAggiungiMacchinaNoleggio.Width + gBxAggiungiMacchina.Width / 5;
            lblAggiungiMacchinaComponenti.Location = p;
            lblAggiungiMacchinaComponenti.Font = ColumnFont;
            //bntaggiungicomponente
            p.Y = lblAggiungiMacchinaComponenti.Location.Y + ColumnFont.Height + buffer;
            p.X = buffer * 2;
            btnAggiungiMacchinaAggiungiComponenti.Location = p;
            btnAggiungiMacchinaAggiungiComponenti.Width = lblAggiungiMacchinaComponenti.Width;
            btnAggiungiMacchinaAggiungiComponenti.Height = btnAggiungiAddintervento.Height;
            //cbxtipologia
            p.X = btnAggiungiMacchinaAggiungiComponenti.Location.X + btnAggiungiMacchinaAggiungiComponenti.Width + buffer;
            cbBxAggiungiMacchinaTipoFiltro.Location = p;
            cbBxAggiungiMacchinaTipoFiltro.Width = (gBxAggiungiMacchina.Width - cbBxAggiungiMacchinaTipoFiltro.Location.X - buffer) / 3;
            cbBxAggiungiMacchinaTipoFiltro.Height = btnAggiungiMacchinaAggiungiComponenti.Height;
            //btn aggiungi ancora
            btnAggiungiMacchinaAggiungiComponenti.Height = cbBxAggiungiMacchinaTipoFiltro.Height;
            //tbx aggiungi componente
            p.X = cbBxAggiungiMacchinaTipoFiltro.Location.X + cbBxAggiungiMacchinaTipoFiltro.Width + buffer;
            txBxAggiungiMacchinaCodiceFiltro.Location = p;
            txBxAggiungiMacchinaCodiceFiltro.Width = ((gBxAggiungiMacchina.Width - cbBxAggiungiMacchinaTipoFiltro.Location.X - buffer) / 3) * 2 - buffer * 2;
            //btnrimuovicomponenti
            p.X = buffer * 2;
            p.Y = btnAggiungiMacchinaAggiungiComponenti.Location.Y + btnAggiungiMacchinaAggiungiComponenti.Height + buffer;
            btnAggiungiMacchinaRimuoviComponenti.Location = p;
            btnAggiungiMacchinaRimuoviComponenti.Width = lblAggiungiMacchinaComponenti.Width;
            btnAggiungiMacchinaRimuoviComponenti.Height = btnAggiungiMacchinaAggiungiComponenti.Height;
            //listviewcomponenti
            p.X = cbBxAggiungiMacchinaTipoFiltro.Location.X;
            lvAggiungiMacchinaFiltri.Location = p;
            lvAggiungiMacchinaFiltri.Width = cbBxAggiungiMacchinaTipoFiltro.Width + buffer + txBxAggiungiMacchinaCodiceFiltro.Width;
            lvAggiungiMacchinaFiltri.Height = gBxAggiungiMacchina.Height / 5;
            lvAggiungiMacchinaFiltri.Columns[0].Width = (int)(lvAggiungiMacchinaFiltri.Width / 2.03);
            lvAggiungiMacchinaFiltri.Columns[1].Width = (int)(lvAggiungiMacchinaFiltri.Width / 2.03);
            //lblnote
            p.X = buffer * 2;
            p.Y = lvAggiungiMacchinaFiltri.Location.Y + lvAggiungiMacchinaFiltri.Height - ColumnFont.Height;
            lblAggiungiMacchinaNote.Font = ColumnFont;
            lblAggiungiMacchinaNote.Location = p;
            //rtbnote
            p.Y = lblAggiungiMacchinaNote.Location.Y + ColumnFont.Height + buffer;
            rtbAggiungiMacchinaNote.Location = p;
            rtbAggiungiMacchinaNote.Width = gBxAggiungiMacchina.Width - buffer * 4;
            rtbAggiungiMacchinaNote.Height = gBxAggiungiMacchina.Height - rtbAggiungiMacchinaNote.Location.Y - btnConfermaAggiungiCliente.Height - buffer;
            //btnconfermaaggiuntamacchina
            btnConfermaAggiungiMacchina.Location = btnConfermaAggiungiCliente.Location;
            btnConfermaAggiungiMacchina.Width = gBxAggiungiMacchina.Width;
            btnConfermaAggiungiMacchina.Height = btnConfermaAggiungiCliente.Height;
            btnConfermaAggiungiMacchina.Font = btnConfermaAggiungiCliente.Font;
            //
            //gbxmodificamacchina
            //
            gBxModificaMacchina.Font = ColumnFont;
            p = dgvVisualizzaClienti.Location;
            gBxModificaMacchina.Location = p;
            gBxModificaMacchina.Width = dgvVisualizzaClienti.Width;
            gBxModificaMacchina.Height = gBxClientiAggiungiCliente.Height;
            //lblmarca
            lblModificaMacchinaMarca.Font = ColumnFont;
            p.X = buffer * 2;
            p.Y = lblAggiungiClienteNome.Location.Y;
            lblModificaMacchinaMarca.Location = p;
            //tbxmarca
            p.Y = lblAggiungiMacchinaMarca.Location.Y + ColumnFont.Height + buffer;
            tbxModificaMacchinaMarca.Location = p;
            tbxModificaMacchinaMarca.Width = gBxAggiungiMacchina.Width - buffer * 4;
            //lblmodello
            p.Y = txBxAggiungiMacchinaMarca.Location.Y + txBxAggiungiMacchinaMarca.Height;
            lblModificaMacchinaModello.Location = p;
            lblModificaMacchinaModello.Font = ColumnFont;
            //tbxmodello
            p.Y = lblAggiungiMacchinaModello.Location.Y + ColumnFont.Height + buffer;
            tbxModificaMacchinaModello.Location = p;
            tbxModificaMacchinaModello.Width = gBxAggiungiMacchina.Width - buffer * 4;
            //lblmatricola
            p.Y = txBxAggiungiMacchinaModello.Location.Y + txBxAggiungiMacchinaModello.Height + buffer;
            lblModificaMacchinaMatricola.Location = p;
            lblModificaMacchinaMatricola.Font = ColumnFont;
            //tbxmatricola
            p.Y = lblAggiungiMacchinaMatricola.Location.Y + ColumnFont.Height + buffer;
            tbxModificaMacchinaMatricola.Location = p;
            tbxModificaMacchinaMatricola.Width = gBxAggiungiMacchina.Width - buffer * 4;
            //chbxnodello
            p.Y = txBxAggiungiMacchinaMatricola.Location.Y + txBxAggiungiMacchinaMatricola.Height + buffer;
            chBxModificaMacchinaNoleggio.Location = p;
            chBxModificaMacchinaNoleggio.Font = ColumnFont;
            //lblcomponenti
            p.X = chBxAggiungiMacchinaNoleggio.Location.X + chBxAggiungiMacchinaNoleggio.Width + gBxAggiungiMacchina.Width / 5;
            lblModificaMacchinaComponenti.Location = p;
            lblModificaMacchinaComponenti.Font = ColumnFont;
            //bntaggiungicomponente
            p.Y = lblAggiungiMacchinaComponenti.Location.Y + ColumnFont.Height + buffer;
            p.X = buffer * 2;
            btnModificaMacchinaAggiungiComponenti.Location = p;
            btnModificaMacchinaAggiungiComponenti.Width = lblAggiungiMacchinaComponenti.Width;
            btnModificaMacchinaAggiungiComponenti.Height = btnAggiungiAddintervento.Height;
            //cbxtipologia
            p.X = btnAggiungiMacchinaAggiungiComponenti.Location.X + btnAggiungiMacchinaAggiungiComponenti.Width + buffer;
            cBxModificaMacchinaTipo.Location = p;
            cBxModificaMacchinaTipo.Width = (gBxAggiungiMacchina.Width - cbBxAggiungiMacchinaTipoFiltro.Location.X - buffer) / 3;
            cBxModificaMacchinaTipo.Height = btnAggiungiMacchinaAggiungiComponenti.Height;
            //btn aggiungi ancora
            btnModificaMacchinaAggiungiComponenti.Height = cbBxAggiungiMacchinaTipoFiltro.Height;
            //tbx aggiungi componente
            p.X = cbBxAggiungiMacchinaTipoFiltro.Location.X + cbBxAggiungiMacchinaTipoFiltro.Width + buffer;
            txBxModificaMacchinaCodice.Location = p;
            txBxModificaMacchinaCodice.Width = ((gBxAggiungiMacchina.Width - cbBxAggiungiMacchinaTipoFiltro.Location.X - buffer) / 3) * 2 - buffer * 2;
            //btnrimuovicomponenti
            p.X = buffer * 2;
            p.Y = btnAggiungiMacchinaAggiungiComponenti.Location.Y + btnAggiungiMacchinaAggiungiComponenti.Height + buffer;
            btnModificaMacchinaRimuoviComponenti.Location = p;
            btnModificaMacchinaRimuoviComponenti.Width = lblAggiungiMacchinaComponenti.Width;
            btnModificaMacchinaRimuoviComponenti.Height = btnAggiungiMacchinaAggiungiComponenti.Height;
            //listviewcomponenti
            p.X = cbBxAggiungiMacchinaTipoFiltro.Location.X;
            lvwModificaComponentiMacchina.Location = p;
            lvwModificaComponentiMacchina.Width = cbBxAggiungiMacchinaTipoFiltro.Width + buffer + txBxAggiungiMacchinaCodiceFiltro.Width;
            lvwModificaComponentiMacchina.Height = gBxAggiungiMacchina.Height / 5;
            lvwModificaComponentiMacchina.Columns[0].Width = (int)(lvAggiungiMacchinaFiltri.Width / 2.03);
            lvwModificaComponentiMacchina.Columns[1].Width = (int)(lvAggiungiMacchinaFiltri.Width / 2.03);
            //lblnote
            p.X = buffer * 2;
            p.Y = lvAggiungiMacchinaFiltri.Location.Y + lvAggiungiMacchinaFiltri.Height - ColumnFont.Height;
            lblModificaMacchinaNote.Font = ColumnFont;
            lblModificaMacchinaNote.Location = p;
            //rtbnote
            p.Y = lblAggiungiMacchinaNote.Location.Y + ColumnFont.Height + buffer;
            rtbModificaMacchinaNote.Location = p;
            rtbModificaMacchinaNote.Width = gBxAggiungiMacchina.Width - buffer * 4;
            rtbModificaMacchinaNote.Height = gBxAggiungiMacchina.Height - rtbAggiungiMacchinaNote.Location.Y - btnConfermaAggiungiCliente.Height - buffer;
            //btnconfermaaggiuntamacchina
            btnConfermaModificaMacchina.Location = btnConfermaAggiungiCliente.Location;
            btnConfermaModificaMacchina.Width = gBxAggiungiMacchina.Width;
            btnConfermaModificaMacchina.Height = btnConfermaAggiungiCliente.Height;
            btnConfermaModificaMacchina.Font = btnConfermaAggiungiCliente.Font;

        }

        private void dgwEventi_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
          
                if (r.DizGiorni.ContainsKey(SelectedDate) && dgwEventi.DataSource == r.DizGiorni[SelectedDate]) 
                {
                    if (e.RowIndex != -1 && e.Value != null && e.ColumnIndex == 6)
                    {
                        if (!e.Handled)
                        {
                            e.Handled = true;
                            e.PaintBackground(e.CellBounds, dgwEventi.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected);
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

                                switch (r.DizGiorni[SelectedDate][e.RowIndex].Interventi[i])
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
                            e.PaintBackground(e.CellBounds, dgwEventi.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected);
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

                             
                                    List<Evento> momentlist = (List<Evento>)dgwEventi.DataSource;
                                    
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

        private void FormCalendario_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                // Maximized!
                ResizeHandle();
            }
            if (WindowState == FormWindowState.Normal)
            {
                // Restored!
                ResizeHandle();
            }
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
                if(!r.DizClienti.ContainsKey(cBxAggiungiEventoCliente.Text))
                {
                    throw new Exception("Inserire Cliente Valido");
                }
                bool checkmacchina = false;
                foreach( Macchina m in r.DizClienti[cBxAggiungiEventoCliente.Text]._Mach)
                {
                    if (m._Marca + "/" + m._Modello + "/" + m._Matricola == cBxAggiungiEventoMacchine.Text)
                    {
                        checkmacchina = true;
                    }
                }
                if (checkmacchina==false)
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
                Evento app = new Evento(SelectedDate, cBxAggiungiEventoCliente.Text, cBxAggiungiEventoMacchine.Text, interventis, rtbAggiungiNote.Text);
                r.AddEvento(app);

                dgwEventi.DataSource = null;
                dgwEventi.DataSource = r.DizGiorni[SelectedDate];
                HideColumnsEventi();
                dgwEventi.Refresh();

                r.salvaEventi();
                r.inviaSalvataggi();

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
            if ( e.RowIndex >= 0 && r.DizClienti.ContainsKey(dgwEventi[3, e.RowIndex].Value.ToString()))
            {
                if (e.ColumnIndex == 3)
                {
                    gBxDettagliCliente.Visible = true;
                    gBxDettagliCliente.Enabled = true;
                    Rectangle re = dgwEventi.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    if (re.Y > dgwEventi.Height / 2)
                    {
                        p.Y = dgwEventi.Location.Y + re.Y - gBxDettagliCliente.Height;
                    }
                    else
                    {
                        p.Y = dgwEventi.Location.Y + re.Y + re.Height;
                    }
                    p.X = gbxDettagli.Location.X;
                    gBxDettagliCliente.Location = p;

                    txBxDettagliClienteTel.Text = r.DizClienti[dgwEventi[3, e.RowIndex].Value.ToString()]._Telefono;
                    txBxDettagliClienteMail.Text = r.DizClienti[dgwEventi[3, e.RowIndex].Value.ToString()]._Email;
                    txBxDettagliClienteIndirizzo.Text = r.DizClienti[dgwEventi[3, e.RowIndex].Value.ToString()]._Indirizzo;
                    txBxDettagliClienteIva.Text = r.DizClienti[dgwEventi[3, e.RowIndex].Value.ToString()]._PartIVA;
                    txBxDettagliClientePrif.Text = r.DizClienti[dgwEventi[3, e.RowIndex].Value.ToString()]._Ref;

                }
                else if (e.ColumnIndex == 4 )
                {
                    gBxDettagliMacchinaAccessorio.Visible = true;
                    gBxDettagliMacchinaAccessorio.Enabled = true;
                    Rectangle re = dgwEventi.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    if (re.Y > dgwEventi.Height / 2)
                    {
                        p.Y = dgwEventi.Location.Y + re.Y - gBxDettagliMacchinaAccessorio.Height;
                    }
                    else
                    {
                        p.Y = dgwEventi.Location.Y + re.Y + re.Height;
                    }
                    p.X = gbxDettagli.Location.X;
                    gBxDettagliMacchinaAccessorio.Location = p;

                    lvwDettagliComponenti.Items.Clear();

                    foreach (Macchina m in r.DizClienti[dgwEventi[3, e.RowIndex].Value.ToString()]._Mach)
                    {
                        if (dgwEventi[4, e.RowIndex].Value.ToString() == m._Marca + "/" + m._Modello + "/" + m._Matricola)
                        {
                            rtbNoteMacchinaAccessorio.Text = m._Note;
                            foreach (Componenti c in m._Componenti)
                            {
                                ListViewItem item = new ListViewItem();
                                item.Text = c.Tipo;
                                item.SubItems.Add(c.Codice);
                                lvwDettagliComponenti.Items.Add(item);
                            }
                        }
                    }


                }
                else if (e.ColumnIndex == 6)
                {
                    gbxDettagli.Visible = true;
                    gbxDettagli.Enabled = true;
                    Rectangle re = dgwEventi.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    if (re.Y > dgwEventi.Height / 2)
                    {
                        p.Y = dgwEventi.Location.Y + re.Y - gbxDettagli.Height;
                    }
                    else
                    {
                        p.Y = dgwEventi.Location.Y + re.Y + re.Height;
                    }
                    p.X = gbxDettagli.Location.X;
                    gbxDettagli.Location = p;

                    if (r.DizGiorni != null && r.DizGiorni.ContainsKey(SelectedDate) && dgwEventi.DataSource == r.DizGiorni[SelectedDate])
                    {
                        rtbNoteDettagli.Text = r.DizGiorni[SelectedDate][e.RowIndex].Note;
                    }
                    else
                    {

                        List<Evento> momentlist = (List<Evento>)dgwEventi.DataSource;
                        rtbNoteDettagli.Text = momentlist[e.RowIndex].Note;
                    }
                }
            }
            else if(e.RowIndex>=0)
            {
                if (e.ColumnIndex == 3)
                {
                    gBxDettagliCliente.Visible = true;
                    gBxDettagliCliente.Enabled = true;
                    Rectangle re = dgwEventi.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    if (re.Y > dgwEventi.Height / 2)
                    {
                        p.Y = dgwEventi.Location.Y + re.Y - gBxDettagliCliente.Height;
                    }
                    else
                    {
                        p.Y = dgwEventi.Location.Y + re.Y + re.Height;
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
                    Rectangle re = dgwEventi.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    if (re.Y > dgwEventi.Height / 2)
                    {
                        p.Y = dgwEventi.Location.Y + re.Y - gbxDettagli.Height;
                    }
                    else
                    {
                        p.Y = dgwEventi.Location.Y + re.Y + re.Height;
                    }
                    p.X = gbxDettagli.Location.X;
                    gbxDettagli.Location = p;

                    if (r.DizGiorni != null && r.DizGiorni.ContainsKey(SelectedDate) && dgwEventi.DataSource == r.DizGiorni[SelectedDate])
                    {
                        rtbNoteDettagli.Text = r.DizGiorni[SelectedDate][e.RowIndex].Note;
                    }
                    else
                    {

                        List<Evento> momentlist = (List<Evento>)dgwEventi.DataSource;
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

                if (dgwEventi.Rows.Count > 0)
                {
                    if (Form.ActiveForm.PointToClient(Cursor.Position).Y - dgwEventi.Rows[0].Height > gBxDettagliMacchinaAccessorio.Bounds.Y && Form.ActiveForm.PointToClient(Cursor.Position).Y - dgwEventi.Rows[0].Height < gBxDettagliMacchinaAccessorio.Bounds.Y + 20)
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
                if (r.DizGiorni.ContainsKey(SelectedDate) && dgwEventi.DataSource == r.DizGiorni[SelectedDate])
                {
                    if (e.Cell.ColumnIndex == 3 && r.DizGiorni.ContainsKey(SelectedDate))
                    {
                        cBxModificaEventoCliente.Text = r.DizGiorni[SelectedDate][e.Cell.RowIndex].NomeCliente;
                        rtbModificaNote.Text = r.DizGiorni[SelectedDate][e.Cell.RowIndex].Note;
                        cBxModificaEventoMacchine.Text = r.DizGiorni[SelectedDate][e.Cell.RowIndex].Macchina;

                        listViewModificaOperazioni.Clear();

                        foreach (object obj in r.DizGiorni[SelectedDate][e.Cell.RowIndex].Interventi)
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
                        cBxModificaEventoCliente.Text = dgwEventi[3, e.Cell.RowIndex].Value.ToString();
                        rtbModificaNote.Text = dgwEventi["Note", e.Cell.RowIndex].Value.ToString();
                        cBxModificaEventoMacchine.Text = dgwEventi[4, e.Cell.RowIndex].Value.ToString();

                        listViewModificaOperazioni.Clear();

                        List<Evento> applist = (List<Evento>)dgwEventi.DataSource;

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
                
                if (dgwEventi.CurrentCell == null)
                {
                    throw new Exception("Selezionare un evento \n per modificarlo");
                }
                if (!r.DizClienti.ContainsKey(cBxModificaEventoCliente.Text))
                {
                    throw new Exception("Inserire Cliente Valido");
                }
                bool checkmacchina = false;
                foreach (Macchina m in r.DizClienti[cBxModificaEventoCliente.Text]._Mach)
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

                Evento ev = new Evento(SelectedDate, cBxModificaEventoCliente.Text, cBxModificaEventoMacchine.Text, interventis, rtbModificaNote.Text);
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
                int app = dgwEventi.CurrentCell.RowIndex;
                List<Evento> momentList = (List<Evento>)dgwEventi.DataSource;
                bool filtrato = false;
                
                if (r.DizGiorni.ContainsKey(SelectedDate) && dgwEventi.DataSource == r.DizGiorni[SelectedDate])
                {
                    dgwEventi.DataSource = null;
                    r.RemoveEvento(r.DizGiorni[SelectedDate][app]);
                }
                else
                {
                    
                    filtrato = true;
                    foreach(Evento ev in r.DizGiorni[(DateTime)dgwEventi["Giorno",app].Value])
                    {
                        if (ev.ID == momentList[app].ID)
                        {
                            dgwEventi.DataSource = null;
                            r.RemoveEvento(ev);
                            momentList.RemoveAt(app);
                            break;
                        }
                    }
                    
                    
                }

                //Salvataggio
                r.salvaEventi();
                r.inviaSalvataggi();

                if (r.DizGiorni.ContainsKey(SelectedDate)&&filtrato==false)
                {
                    dgwEventi.DataSource = r.DizGiorni[SelectedDate];
                    HideColumnsEventi();
                    ariCalendario.SelectionStart = SelectedDate.AddDays(1);
                    ariCalendario.SelectionStart = SelectedDate.AddDays(-1);
                }
                else
                {
                    dgwEventi.DataSource = momentList;
                    HideColumnsEventi();
                    dgwEventi.Columns["Giorno"].Visible = true;
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
                gBxClientiAggiungiCliente.Visible = false;
            }
            else
            {
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
            Notifica notifica = new Notifica();
            try
            {
                listaMacchine = new List<Macchina>();

                List<Componenti> componenti = new List<Componenti>();

                foreach (ListViewItem item in lvAggiungiMacchinaFiltri.Items)
                {
                    Componenti componente = new Componenti(item.Text, item.SubItems[1].Text);
                    componenti.Add(componente);
                }

                macchina = new Macchina(txBxAggiungiMacchinaMarca.Text, txBxAggiungiMacchinaModello.Text,
                    txBxAggiungiMacchinaMatricola.Text, componenti, chBxAggiungiMacchinaNoleggio.Checked, rtbAggiungiMacchinaNote.Text);
               
                listaMacchine.Add(macchina);

                ListViewItem items = new ListViewItem();
                items.Text = macchina._Marca;
                items.SubItems.Add(macchina._Modello);
                items.SubItems.Add(macchina._Matricola);

                if (gBxClientiModificaClienti.Visible == true)
                {
                    lvwModificaCliente.Items.Add(items);
                }
                else
                {
                    lvwAggiungiClientiMacchine.Items.Add(items);
                }

                notifica.Show("Macchina aggiunta correttamente!", Notifica.enmType.Success); //pepepe
                macchina = null;
                gBxAggiungiMacchina.Visible = false;

                foreach (Control c in gBxAggiungiMacchina.Controls)
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

        private void btnAggiungiMacchinaAggiungiComponenti_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbBxAggiungiMacchinaTipoFiltro.Text) || string.IsNullOrWhiteSpace(txBxAggiungiMacchinaCodiceFiltro.Text))
            {

            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = cbBxAggiungiMacchinaTipoFiltro.Text;
                item.SubItems.Add(txBxAggiungiMacchinaCodiceFiltro.Text);
                lvAggiungiMacchinaFiltri.Items.Add(item);
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

        private void btnConfermaAggiungiCliente_Click(object sender, EventArgs e)
        {
            Notifica notifica = new Notifica();

            try
            {
                if (!string.IsNullOrWhiteSpace(tbxAggiungiClienteNome.Text) && !string.IsNullOrWhiteSpace(tbxAggiungiClienteTel.Text) && !string.IsNullOrWhiteSpace(tbxAggiungiClienteMail.Text)
                    && !string.IsNullOrWhiteSpace(tbxAggiungiClienteMail.Text) && !string.IsNullOrWhiteSpace(tbxAggiungiClienteInd.Text) && !string.IsNullOrWhiteSpace(tbxAggiungiClienteIVA.Text)
                    && !string.IsNullOrWhiteSpace(tbxAggiungiClientePrif.Text))
                {
                    Cliente cliente = new Cliente(tbxAggiungiClienteNome.Text, tbxAggiungiClienteInd.Text, tbxAggiungiClienteTel.Text, tbxAggiungiClienteIVA.Text, tbxAggiungiClienteMail.Text,
                        tbxAggiungiClientePrif.Text, listaMacchine);

                    r.DizClienti.Add(cliente._Nome, cliente);

                    gBxClientiAggiungiCliente.Visible = false;

                    threadRicevi.Suspend();
                    dgvVisualizzaClienti.DataSource = null;
                    dgvVisualizzaClienti.DataSource = r.DizClienti.Values.ToList();
                    HideColumnsClienti();
                    r.salvaClienti();
                    r.inviaSalvataggi();
                    AggiornaComboBox();
                    threadRicevi.Resume();

                    foreach (Control c in gBxClientiAggiungiCliente.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = null;
                        }

                        if (c is ListView)
                        {
                            ListView listView = (ListView)c;
                            listView.Items.Clear();
                        }
                    }

                    gBxAggiungiMacchina.Visible = false;
                    gBxModificaMacchina.Visible = false;
                    notifica.Show("Cliente aggiunto correttamente!", Notifica.enmType.Success);
                }
                else
                {
                    throw new Exception("Completare tutti i campi");
                }
            }
            catch (Exception exc)
            {
                notifica.Show(exc.Message, Notifica.enmType.Warning);
            }
        }

        private void btnChiudigBxAggiungiMacchine_Click(object sender, EventArgs e)
        {
            gBxAggiungiMacchina.Visible = false;
        }

        private void dgvVisualizzaClienti_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.Cell.ColumnIndex == 0)
            {
                btnClientiEditCustomer.Enabled = true;
                btnClientiDeleteCustomer.Enabled = true;

                lvwMostraMacchineAccessori.Items.Clear();
                lvwModificaCliente.Items.Clear();
                tbxMostraIva.Text = r.DizClienti[e.Cell.Value.ToString()]._PartIVA;
                tbxMostraPrif.Text = r.DizClienti[e.Cell.Value.ToString()]._Ref;
                if (listaMacchine != null)
                { 
                     listaMacchine.Clear();
                }
                else
                {
                    listaMacchine = new List<Macchina>();
                }
                foreach (Macchina macchina in r.DizClienti[e.Cell.Value.ToString()]._Mach)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = macchina._Marca;
                    item.SubItems.Add(macchina._Modello);
                    item.SubItems.Add(macchina._Matricola);

                    lvwMostraMacchineAccessori.Items.Add(item);

                    ListViewItem itemm = new ListViewItem();
                    itemm.Text = macchina._Marca;
                    itemm.SubItems.Add(macchina._Modello);
                    itemm.SubItems.Add(macchina._Matricola);
                    lvwModificaCliente.Items.Add(itemm);

                    listaMacchine.Add(macchina);
                }

                txBxModificaClienteNome.Text = r.DizClienti[e.Cell.Value.ToString()]._Nome;
                txBxModificaClienteTel.Text = r.DizClienti[e.Cell.Value.ToString()]._Telefono;
                txBxModificaClienteMail.Text = r.DizClienti[e.Cell.Value.ToString()]._Email;
                txBxModificaClienteInd.Text = r.DizClienti[e.Cell.Value.ToString()]._Indirizzo;
                txBxModificaClienteIva.Text= r.DizClienti[e.Cell.Value.ToString()]._PartIVA;
                txBxModificaClientePrif.Text= r.DizClienti[e.Cell.Value.ToString()]._Ref;

            }
            else
            {
                btnClientiEditCustomer.Enabled = false;
                btnClientiDeleteCustomer.Enabled = false;
            }
        }

        private void lvwMostraMacchineAccessori_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwMostraComponenti.Items.Clear();

            foreach (ListViewItem item in lvwMostraMacchineAccessori.SelectedItems)
            {
                if (dgvVisualizzaClienti.CurrentCell.ColumnIndex == 0)
                {
                    chbxMostraNoleggio.Checked = r.DizClienti[dgvVisualizzaClienti.CurrentCell.Value.ToString()]._Mach[item.Index]._Noleggio;
                    rtbMostraNote.Text = r.DizClienti[dgvVisualizzaClienti.CurrentCell.Value.ToString()]._Mach[item.Index]._Note;

                    foreach (Componenti componente in r.DizClienti[dgvVisualizzaClienti.CurrentCell.Value.ToString()]._Mach[item.Index]._Componenti)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Text = componente.Tipo;
                        listViewItem.SubItems.Add(componente.Codice);

                        lvwMostraComponenti.Items.Add(listViewItem);
                    }
                }
            }
        }

        private void btnAggiungiMacchinaRimuoviComponenti_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvAggiungiMacchinaFiltri.SelectedItems)
            {
                lvAggiungiMacchinaFiltri.Items.Remove(item);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResizeHandle();
        }

        private void btnClientiEditCustomer_Click(object sender, EventArgs e)
        {
            if (gBxClientiModificaClienti.Visible == true)
            {
                gBxClientiModificaClienti.Visible = false;
            }
            else
            {
                gBxClientiModificaClienti.Visible = true;
                gBxClientiAggiungiCliente.Visible = false;
                
            }
        }

        public void AGGIORNATUTTO()
        {
            while (going == true)
            {
                Thread.Sleep(100);

                if (r.riceviSalvataggiClienti())
                {
                    if (r.DizClienti.Count > 0)
                    {
                        dgvVisualizzaClienti.DataSource = null;
                        dgvVisualizzaClienti.DataSource = r.DizClienti.Values.ToList();
                        dgvVisualizzaClienti.Refresh();

                        if (dgvVisualizzaClienti.Columns.Count > 0)
                        {
                            HideColumnsClienti();
                        }
                    }
                    else
                    {
                        dgvVisualizzaClienti.DataSource = null;
                    }
                }

                if (r.riceviSalvataggiEventi())
                {
                    if (r.DizGiorni.ContainsKey(SelectedDate))
                    {
                        dgwEventi.DataSource = null;
                        dgwEventi.DataSource = r.DizGiorni[SelectedDate];
                        dgwEventi.Refresh();
                        HideColumnsEventi();
                    }
                    else
                    {
                        dgwEventi.DataSource = null;
                    }
                }
            }
        }

        private void FormCalendario_FormClosing(object sender, FormClosingEventArgs e)
        {
            going = false;
            threadRicevi.Abort();
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

            if (r.DizClienti != null)
            {
                if (rdBtnTrovaPerNome.Checked)
                {
                    List<Cliente> nomeCliente = new List<Cliente>();

                    foreach (KeyValuePair<string, Cliente> kv in r.DizClienti)
                    {
                        if (kv.Key == cbBxTrovaPerNome.Text)
                        {
                            nomeCliente.Add(r.DizClienti[kv.Key]);
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

                    foreach (KeyValuePair<string, Cliente> kv in r.DizClienti)
                    {
                        if (kv.Value._Ref == cbBxTrovaPerPRif.Text)
                        {
                            prifCliente.Add(r.DizClienti[kv.Key]);
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

                    foreach (KeyValuePair<string, Cliente> kv in r.DizClienti)
                    {
                        foreach (Macchina macchina in kv.Value._Mach)
                        {
                            if (macchina._Marca + "/"+macchina._Modello+"/"+macchina._Matricola == cbBxTrovaPerMatricola.Text)
                            {
                                matricolaMacchina.Add(r.DizClienti[kv.Key]);
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

                    foreach (KeyValuePair<string, Cliente> kv in r.DizClienti)
                    {
                        if (kv.Value._Email == cbBxTrovaPerMail.Text)
                        {
                            emailCliente.Add(r.DizClienti[kv.Key]);
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

            dgvVisualizzaClienti.DataSource = r.DizClienti.Values.ToList();
            HideColumnsClienti();
            lblClienti.Text = "Tutti i clienti";
        }

        private void cBxAggiungiEventoCliente_TextChanged(object sender, EventArgs e)
        {
            if (r.DizClienti.ContainsKey(cBxAggiungiEventoCliente.Text))
            {
                cBxAggiungiEventoMacchine.Items.Clear();
                cBxAggiungiEventoMacchine.Text = null;
                foreach (Macchina macchina in r.DizClienti[cBxAggiungiEventoCliente.Text]._Mach)
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
                r.DizClienti.Remove(key);

                dgvVisualizzaClienti.DataSource = null;
                dgvVisualizzaClienti.DataSource = r.DizClienti.Values.ToList();
                HideColumnsClienti();
                AggiornaComboBox();

                r.salvaClienti();
                r.inviaSalvataggi();

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

            if (r.DizGiorni != null)
            {
                
                List<Evento> eventiTrovati = new List<Evento>();
                string s = null;

                if (rdBtnSearchEventoCliente.Checked)
                {
                    s = cbBxSearchEventoCliente.Text;

                    foreach (KeyValuePair<DateTime, List<Evento>> kv in r.DizGiorni)
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
                        dgwEventi.DataSource = eventiTrovati;
                        //ariCalendario.SelectionStart = SelectedDate;
                        HideColumnsEventi();
                        dgwEventi.Columns["Giorno"].Visible = true;
                    }
                    else
                    {
                        notifica.Show("Nessun evento del cliente trovato.", Notifica.enmType.Warning);
                    }
                }
                else if (rdBtnSearchEventoMatricola.Checked)
                {
                    s = cbBxSearchEventoMatricola.Text;


                    foreach (KeyValuePair<DateTime, List<Evento>> kv in r.DizGiorni)
                    {
                        foreach (Evento eventoLista in kv.Value)
                        {
                            if (eventoLista.Macchina == s)
                            {                               
                                eventiTrovati.Add(eventoLista);
                            }
                        }
                    }

                    if (eventiTrovati.Count > 0)
                    {
                     
                        lblEventi.Text = "Eventi su: " + eventiTrovati[0].Macchina;
                        dgwEventi.DataSource = eventiTrovati;
                        HideColumnsEventi();
                        dgwEventi.Columns["Giorno"].Visible = true;
                    }
                    else
                    {
                        notifica.Show("Nessuna evento della macchina trovato.", Notifica.enmType.Warning);
                    }
                }
                if (dgwEventi.DataSource != null)
                {
                    ResizeDetilsCose();
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
            var b = gBxDettagliMacchinaAccessorio.ClientRectangle.Contains(gBxDettagliMacchinaAccessorio.PointToClient(Cursor.Position));
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
            if (lvwMostraMacchineAccessori.SelectedItems.Count > 0)
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
            }
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

            tbxModificaMacchinaMarca.Text = listaMacchine[lvwModificaCliente.SelectedItems[0].Index]._Marca;
            tbxModificaMacchinaModello.Text = listaMacchine[lvwModificaCliente.SelectedItems[0].Index]._Modello;
            tbxModificaMacchinaMatricola.Text = listaMacchine[lvwModificaCliente.SelectedItems[0].Index]._Matricola;
            chBxModificaMacchinaNoleggio.Checked = listaMacchine[lvwModificaCliente.SelectedItems[0].Index]._Noleggio;
            rtbModificaMacchinaNote.Text = listaMacchine[lvwModificaCliente.SelectedItems[0].Index]._Note;

            lvwModificaComponentiMacchina.Items.Clear();
            foreach (Componenti c in listaMacchine[lvwModificaCliente.SelectedItems[0].Index]._Componenti)
            {
                ListViewItem item = new ListViewItem();
                item.Text = c.Tipo;
                item.SubItems.Add(c.Codice);
                lvwModificaComponentiMacchina.Items.Add(item);
            }

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

                foreach (ListViewItem item in lvwModificaComponentiMacchina.Items)
                {
                    Componenti componente = new Componenti(item.Text, item.SubItems[1].Text);
                    componenti.Add(componente);
                }

                macchina = new Macchina(tbxModificaMacchinaMarca.Text, tbxModificaMacchinaModello.Text,
                    tbxModificaMacchinaMatricola.Text, componenti, chBxModificaMacchinaNoleggio.Checked, rtbModificaMacchinaNote.Text);
                listaMacchine.Add(macchina);

                ListViewItem items = new ListViewItem();
                items.Text = macchina._Marca;
                items.SubItems.Add(macchina._Modello);
                items.SubItems.Add(macchina._Matricola);


                lvwAggiungiClientiMacchine.Items.Add(items);

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
            lvwModificaCliente.Items.Remove(lvwModificaCliente.SelectedItems[0]);
        }

        private void btnAggiungiEliminaMacchina_Click(object sender, EventArgs e)
        {
            lvwAggiungiClientiMacchine.Items.Remove(lvwAggiungiClientiMacchine.SelectedItems[0]);
        }

        private void lvwAggiungiClientiMacchine_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAggiungiModificaMacchina.Enabled = true;
            btnAggiungiEliminaMacchina.Enabled = true;

            tbxModificaMacchinaMarca.Text = listaMacchine[lvwAggiungiClientiMacchine.SelectedItems[0].Index]._Marca;
            tbxModificaMacchinaModello.Text = listaMacchine[lvwAggiungiClientiMacchine.SelectedItems[0].Index]._Modello;
            tbxModificaMacchinaMatricola.Text = listaMacchine[lvwAggiungiClientiMacchine.SelectedItems[0].Index]._Matricola;
            chBxModificaMacchinaNoleggio.Checked = listaMacchine[lvwAggiungiClientiMacchine.SelectedItems[0].Index]._Noleggio;
            rtbModificaMacchinaNote.Text = listaMacchine[lvwAggiungiClientiMacchine.SelectedItems[0].Index]._Note;

            lvwModificaComponentiMacchina.Items.Clear();
            foreach(Componenti c in listaMacchine[lvwAggiungiClientiMacchine.SelectedItems[0].Index]._Componenti)
            {
                ListViewItem item = new ListViewItem();
                item.Text = c.Tipo;
                item.SubItems.Add(c.Codice);
                lvwModificaComponentiMacchina.Items.Add(item);
            }
        }

        private void btnChiudigBxModificaMacchina_Click(object sender, EventArgs e)
        {
            gBxModificaMacchina.Visible = false;
        }

        private void btnConfermaModificaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tbxAggiungiClienteNome.Text) && !string.IsNullOrWhiteSpace(tbxAggiungiClienteTel.Text) && !string.IsNullOrWhiteSpace(tbxAggiungiClienteMail.Text)
                        && !string.IsNullOrWhiteSpace(tbxAggiungiClienteMail.Text) && !string.IsNullOrWhiteSpace(tbxAggiungiClienteInd.Text) && !string.IsNullOrWhiteSpace(tbxAggiungiClienteIVA.Text)
                        && !string.IsNullOrWhiteSpace(tbxAggiungiClientePrif.Text))
                {
                }
            }
            catch
            {

            }
        }

        private void btnModificaMacchinaAggiungiComponenti_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cBxModificaMacchinaTipo.Text) || string.IsNullOrWhiteSpace(txBxModificaMacchinaCodice.Text))
            {

            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = cBxModificaMacchinaTipo.Text;
                item.SubItems.Add(txBxModificaMacchinaCodice.Text);
                lvwModificaComponentiMacchina.Items.Add(item);
            }
        }
    }
}