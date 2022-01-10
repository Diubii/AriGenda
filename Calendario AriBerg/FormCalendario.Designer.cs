
namespace Calendario_AriBerg
{
    partial class FormCalendario
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendario));
            this.dgwEventi = new System.Windows.Forms.DataGridView();
            this.lblEventi = new System.Windows.Forms.Label();
            this.btnLegenda = new System.Windows.Forms.Button();
            this.gbxLegenda = new System.Windows.Forms.GroupBox();
            this.lblInterventoManut_completa = new System.Windows.Forms.Label();
            this.lblSimboloManut_parziale = new System.Windows.Forms.Label();
            this.lblSimboloFgas = new System.Windows.Forms.Label();
            this.lblSimboloSostFiltri = new System.Windows.Forms.Label();
            this.lblSimboloControllo_generale = new System.Windows.Forms.Label();
            this.lblInterventoFgas = new System.Windows.Forms.Label();
            this.lblInterventoSostfiltri = new System.Windows.Forms.Label();
            this.lblInterventoControllo_Generale = new System.Windows.Forms.Label();
            this.btnExitLegend = new System.Windows.Forms.Button();
            this.lblInterventoManut_parziale = new System.Windows.Forms.Label();
            this.lblSimboloManut_completa = new System.Windows.Forms.Label();
            this.btnExitAggiungi = new System.Windows.Forms.Button();
            this.gbxAggiungi = new System.Windows.Forms.GroupBox();
            this.cBxAggiungiEventoMacchine = new System.Windows.Forms.ComboBox();
            this.cBxAggiungiEventoCliente = new System.Windows.Forms.ComboBox();
            this.lblAggiungiLista = new System.Windows.Forms.Label();
            this.btnConfermaAggiungi = new System.Windows.Forms.Button();
            this.btnAggiungiRimuoviintervento = new System.Windows.Forms.Button();
            this.lblAggiungiDispListaIntervent = new System.Windows.Forms.Label();
            this.listViewAggiungiIntervento = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAggiungiAddintervento = new System.Windows.Forms.Button();
            this.comboBoxAggiungi = new System.Windows.Forms.ComboBox();
            this.lblMacchina = new System.Windows.Forms.Label();
            this.rtbAggiungiNote = new System.Windows.Forms.RichTextBox();
            this.lblAggiungiNote = new System.Windows.Forms.Label();
            this.lblAggCliente = new System.Windows.Forms.Label();
            this.gbxModifica = new System.Windows.Forms.GroupBox();
            this.cBxModificaEventoMacchine = new System.Windows.Forms.ComboBox();
            this.cBxModificaEventoCliente = new System.Windows.Forms.ComboBox();
            this.btnModificaRimuoviOperazioni = new System.Windows.Forms.Button();
            this.lblModificaEventoLista = new System.Windows.Forms.Label();
            this.btnConfermaModifica = new System.Windows.Forms.Button();
            this.lblModificaEventoInterventi = new System.Windows.Forms.Label();
            this.listViewModificaOperazioni = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModificaAggiungiOperazioni = new System.Windows.Forms.Button();
            this.cbxModificaListaOperazioni = new System.Windows.Forms.ComboBox();
            this.lblModificaEventoMacchine = new System.Windows.Forms.Label();
            this.rtbModificaNote = new System.Windows.Forms.RichTextBox();
            this.lblModificaEventoNote = new System.Windows.Forms.Label();
            this.lblModificaCliente = new System.Windows.Forms.Label();
            this.btnExitModifica = new System.Windows.Forms.Button();
            this.pnlCommands1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxDettagli = new System.Windows.Forms.GroupBox();
            this.rtbNoteDettagli = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlCercaEvento = new System.Windows.Forms.Panel();
            this.btnSearchEvento = new System.Windows.Forms.Button();
            this.rdBtnSearchEventoMatricola = new System.Windows.Forms.RadioButton();
            this.rdBtnSearchEventoCliente = new System.Windows.Forms.RadioButton();
            this.cbBxSearchEventoMatricola = new System.Windows.Forms.ComboBox();
            this.cbBxSearchEventoCliente = new System.Windows.Forms.ComboBox();
            this.gBxDettagliCliente = new System.Windows.Forms.GroupBox();
            this.lblDettagliClientePrif = new System.Windows.Forms.Label();
            this.txBxDettagliClientePrif = new System.Windows.Forms.TextBox();
            this.lblDettagliClienteIva = new System.Windows.Forms.Label();
            this.txBxDettagliClienteIva = new System.Windows.Forms.TextBox();
            this.lblDettagliClienteIndirizzo = new System.Windows.Forms.Label();
            this.txBxDettagliClienteIndirizzo = new System.Windows.Forms.TextBox();
            this.lblDettagliClienteMail = new System.Windows.Forms.Label();
            this.txBxDettagliClienteMail = new System.Windows.Forms.TextBox();
            this.lblDettagliClienteTel = new System.Windows.Forms.Label();
            this.txBxDettagliClienteTel = new System.Windows.Forms.TextBox();
            this.gBxDettagliMacchinaAccessorio = new System.Windows.Forms.GroupBox();
            this.lblDettagliComponenti = new System.Windows.Forms.Label();
            this.lblNoteMacchinaAccessorio = new System.Windows.Forms.Label();
            this.lvwDettagliComponenti = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtbNoteMacchinaAccessorio = new System.Windows.Forms.RichTextBox();
            this.ariCalendario = new Calendario_AriBerg.AriCalendario();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gBxAggiungiMacchina = new System.Windows.Forms.GroupBox();
            this.cbBxAggiungiMacchinaTipoFiltro = new System.Windows.Forms.ComboBox();
            this.lblAggiungiMacchinaMarca = new System.Windows.Forms.Label();
            this.txBxAggiungiMacchinaMarca = new System.Windows.Forms.TextBox();
            this.chBxAggiungiMacchinaNoleggio = new System.Windows.Forms.CheckBox();
            this.txBxAggiungiMacchinaCodiceFiltro = new System.Windows.Forms.TextBox();
            this.rtbAggiungiMacchinaNote = new System.Windows.Forms.RichTextBox();
            this.lblAggiungiMacchinaNote = new System.Windows.Forms.Label();
            this.lblAggiungiMacchinaMatricola = new System.Windows.Forms.Label();
            this.txBxAggiungiMacchinaMatricola = new System.Windows.Forms.TextBox();
            this.lblAggiungiMacchinaComponenti = new System.Windows.Forms.Label();
            this.btnAggiungiMacchinaRimuoviComponenti = new System.Windows.Forms.Button();
            this.lvAggiungiMacchinaFiltri = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAggiungiMacchinaAggiungiComponenti = new System.Windows.Forms.Button();
            this.lblAggiungiMacchinaModello = new System.Windows.Forms.Label();
            this.txBxAggiungiMacchinaModello = new System.Windows.Forms.TextBox();
            this.btnChiudigBxAggiungiMacchine = new System.Windows.Forms.Button();
            this.btnConfermaAggiungiMacchina = new System.Windows.Forms.Button();
            this.gBxModificaMacchina = new System.Windows.Forms.GroupBox();
            this.cBxModificaMacchinaTipo = new System.Windows.Forms.ComboBox();
            this.lblModificaMacchinaMarca = new System.Windows.Forms.Label();
            this.tbxModificaMacchinaMarca = new System.Windows.Forms.TextBox();
            this.chBxModificaMacchinaNoleggio = new System.Windows.Forms.CheckBox();
            this.txBxModificaMacchinaCodice = new System.Windows.Forms.TextBox();
            this.rtbModificaMacchinaNote = new System.Windows.Forms.RichTextBox();
            this.lblModificaMacchinaNote = new System.Windows.Forms.Label();
            this.lblModificaMacchinaMatricola = new System.Windows.Forms.Label();
            this.tbxModificaMacchinaMatricola = new System.Windows.Forms.TextBox();
            this.lblModificaMacchinaComponenti = new System.Windows.Forms.Label();
            this.btnModificaMacchinaRimuoviComponenti = new System.Windows.Forms.Button();
            this.lvwModificaComponentiMacchina = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModificaMacchinaAggiungiComponenti = new System.Windows.Forms.Button();
            this.lblModificaMacchinaModello = new System.Windows.Forms.Label();
            this.tbxModificaMacchinaModello = new System.Windows.Forms.TextBox();
            this.btnChiudigBxModificaMacchina = new System.Windows.Forms.Button();
            this.btnConfermaModificaMacchina = new System.Windows.Forms.Button();
            this.gBxClientiAggiungiCliente = new System.Windows.Forms.GroupBox();
            this.pnlAggiungiClienteButtonsMacchina = new System.Windows.Forms.Panel();
            this.btnAggiungiAggiungiMacchina = new System.Windows.Forms.Button();
            this.btnAggiungiModificaMacchina = new System.Windows.Forms.Button();
            this.btnAggiungiEliminaMacchina = new System.Windows.Forms.Button();
            this.lblAggiungiClientiMacchineAccessori = new System.Windows.Forms.Label();
            this.lvwAggiungiClientiMacchine = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAggiungiClientePrif = new System.Windows.Forms.Label();
            this.tbxAggiungiClientePrif = new System.Windows.Forms.TextBox();
            this.lblAggiungiClienteIVA = new System.Windows.Forms.Label();
            this.tbxAggiungiClienteIVA = new System.Windows.Forms.TextBox();
            this.lblAggiungiClienteInd = new System.Windows.Forms.Label();
            this.tbxAggiungiClienteInd = new System.Windows.Forms.TextBox();
            this.lblAggiungiClienteMail = new System.Windows.Forms.Label();
            this.tbxAggiungiClienteMail = new System.Windows.Forms.TextBox();
            this.lblAggiungiClienteTel = new System.Windows.Forms.Label();
            this.tbxAggiungiClienteTel = new System.Windows.Forms.TextBox();
            this.lblAggiungiClienteNome = new System.Windows.Forms.Label();
            this.tbxAggiungiClienteNome = new System.Windows.Forms.TextBox();
            this.btnAggiungiClienteChiudi = new System.Windows.Forms.Button();
            this.btnConfermaAggiungiCliente = new System.Windows.Forms.Button();
            this.gBxClientiModificaClienti = new System.Windows.Forms.GroupBox();
            this.pnlModificaClienteMacchine = new System.Windows.Forms.Panel();
            this.btnModificaAggiungiMacchina = new System.Windows.Forms.Button();
            this.btnModificaModificaMacchina = new System.Windows.Forms.Button();
            this.btnModificaEliminaMacchina = new System.Windows.Forms.Button();
            this.lblModificaClienteMacchinaAccessori = new System.Windows.Forms.Label();
            this.lblModificaClientePrif = new System.Windows.Forms.Label();
            this.txBxModificaClientePrif = new System.Windows.Forms.TextBox();
            this.lblModificaClienteIva = new System.Windows.Forms.Label();
            this.txBxModificaClienteIva = new System.Windows.Forms.TextBox();
            this.lblModificaClienteInd = new System.Windows.Forms.Label();
            this.txBxModificaClienteInd = new System.Windows.Forms.TextBox();
            this.lblModificaClienteMail = new System.Windows.Forms.Label();
            this.txBxModificaClienteMail = new System.Windows.Forms.TextBox();
            this.lblModificaClienteTel = new System.Windows.Forms.Label();
            this.txBxModificaClienteTel = new System.Windows.Forms.TextBox();
            this.lblModificaClienteNome = new System.Windows.Forms.Label();
            this.txBxModificaClienteNome = new System.Windows.Forms.TextBox();
            this.btnModificaClienteChiudi = new System.Windows.Forms.Button();
            this.btnConfermaModificaCliente = new System.Windows.Forms.Button();
            this.lblClienti = new System.Windows.Forms.Label();
            this.gBxVisualizzaCliente = new System.Windows.Forms.GroupBox();
            this.lblMostraComponenti = new System.Windows.Forms.Label();
            this.lvwMostraComponenti = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chbxMostraNoleggio = new System.Windows.Forms.CheckBox();
            this.rtbMostraNote = new System.Windows.Forms.RichTextBox();
            this.pbxAlloStoricoMacchina = new System.Windows.Forms.PictureBox();
            this.lblMostraNote = new System.Windows.Forms.Label();
            this.pbxAlloStoricoCliente = new System.Windows.Forms.PictureBox();
            this.lblMostraMacchineAccessori = new System.Windows.Forms.Label();
            this.lvwMostraMacchineAccessori = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMostraPrif = new System.Windows.Forms.Label();
            this.tbxMostraPrif = new System.Windows.Forms.TextBox();
            this.lblMostraIva = new System.Windows.Forms.Label();
            this.tbxMostraIva = new System.Windows.Forms.TextBox();
            this.pnlCommands2 = new System.Windows.Forms.Panel();
            this.btnClientiAddCustomer = new System.Windows.Forms.Button();
            this.btnClientiEditCustomer = new System.Windows.Forms.Button();
            this.btnClientiDeleteCustomer = new System.Windows.Forms.Button();
            this.mur = new System.Windows.Forms.PictureBox();
            this.dgvVisualizzaClienti = new System.Windows.Forms.DataGridView();
            this.gBxClientiTrova = new System.Windows.Forms.GroupBox();
            this.btnEliminaFiltridgvVisualizzaClienti = new System.Windows.Forms.Button();
            this.rdBtnTrovaPerNome = new System.Windows.Forms.RadioButton();
            this.rdBtnTrovaPerPRif = new System.Windows.Forms.RadioButton();
            this.rdBtnTrovaPerMail = new System.Windows.Forms.RadioButton();
            this.rdBtnTrovaPerMatricola = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbBxTrovaPerMatricola = new System.Windows.Forms.ComboBox();
            this.cbBxTrovaPerMail = new System.Windows.Forms.ComboBox();
            this.cbBxTrovaPerPRif = new System.Windows.Forms.ComboBox();
            this.cbBxTrovaPerNome = new System.Windows.Forms.ComboBox();
            this.dgvModificaCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEventi)).BeginInit();
            this.gbxLegenda.SuspendLayout();
            this.gbxAggiungi.SuspendLayout();
            this.gbxModifica.SuspendLayout();
            this.pnlCommands1.SuspendLayout();
            this.gbxDettagli.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlCercaEvento.SuspendLayout();
            this.gBxDettagliCliente.SuspendLayout();
            this.gBxDettagliMacchinaAccessorio.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gBxAggiungiMacchina.SuspendLayout();
            this.gBxModificaMacchina.SuspendLayout();
            this.gBxClientiAggiungiCliente.SuspendLayout();
            this.pnlAggiungiClienteButtonsMacchina.SuspendLayout();
            this.gBxClientiModificaClienti.SuspendLayout();
            this.pnlModificaClienteMacchine.SuspendLayout();
            this.gBxVisualizzaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlloStoricoMacchina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlloStoricoCliente)).BeginInit();
            this.pnlCommands2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizzaClienti)).BeginInit();
            this.gBxClientiTrova.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwEventi
            // 
            this.dgwEventi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwEventi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwEventi.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgwEventi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEventi.GridColor = System.Drawing.Color.Black;
            this.dgwEventi.Location = new System.Drawing.Point(890, 142);
            this.dgwEventi.Name = "dgwEventi";
            this.dgwEventi.ReadOnly = true;
            this.dgwEventi.RowHeadersWidth = 51;
            this.dgwEventi.RowTemplate.Height = 24;
            this.dgwEventi.Size = new System.Drawing.Size(553, 459);
            this.dgwEventi.TabIndex = 4;
            this.dgwEventi.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEventi_CellMouseEnter);
            this.dgwEventi.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEventi_CellMouseLeave);
            this.dgwEventi.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgwEventi_CellPainting);
            this.dgwEventi.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgwEventi_CellStateChanged);
            this.dgwEventi.MouseEnter += new System.EventHandler(this.dgwEventi_MouseEnter);
            this.dgwEventi.MouseLeave += new System.EventHandler(this.dgwEventi_MouseLeave);
            // 
            // lblEventi
            // 
            this.lblEventi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventi.AutoSize = true;
            this.lblEventi.Font = new System.Drawing.Font("Calibri", 22.2F);
            this.lblEventi.ForeColor = System.Drawing.Color.White;
            this.lblEventi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEventi.Location = new System.Drawing.Point(882, 86);
            this.lblEventi.Name = "lblEventi";
            this.lblEventi.Size = new System.Drawing.Size(161, 37);
            this.lblEventi.TabIndex = 5;
            this.lblEventi.Text = "Eventi (day)";
            // 
            // btnLegenda
            // 
            this.btnLegenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLegenda.BackColor = System.Drawing.Color.Teal;
            this.btnLegenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLegenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLegenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLegenda.Location = new System.Drawing.Point(1537, 75);
            this.btnLegenda.Name = "btnLegenda";
            this.btnLegenda.Size = new System.Drawing.Size(116, 46);
            this.btnLegenda.TabIndex = 6;
            this.btnLegenda.Text = "Legenda";
            this.btnLegenda.UseVisualStyleBackColor = false;
            this.btnLegenda.Click += new System.EventHandler(this.BtnLegenda_Click);
            // 
            // gbxLegenda
            // 
            this.gbxLegenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLegenda.Controls.Add(this.lblInterventoManut_completa);
            this.gbxLegenda.Controls.Add(this.lblSimboloManut_parziale);
            this.gbxLegenda.Controls.Add(this.lblSimboloFgas);
            this.gbxLegenda.Controls.Add(this.lblSimboloSostFiltri);
            this.gbxLegenda.Controls.Add(this.lblSimboloControllo_generale);
            this.gbxLegenda.Controls.Add(this.lblInterventoFgas);
            this.gbxLegenda.Controls.Add(this.lblInterventoSostfiltri);
            this.gbxLegenda.Controls.Add(this.lblInterventoControllo_Generale);
            this.gbxLegenda.Controls.Add(this.btnExitLegend);
            this.gbxLegenda.Controls.Add(this.lblInterventoManut_parziale);
            this.gbxLegenda.Controls.Add(this.lblSimboloManut_completa);
            this.gbxLegenda.Enabled = false;
            this.gbxLegenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxLegenda.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxLegenda.ForeColor = System.Drawing.Color.White;
            this.gbxLegenda.Location = new System.Drawing.Point(1241, 75);
            this.gbxLegenda.Name = "gbxLegenda";
            this.gbxLegenda.Size = new System.Drawing.Size(202, 230);
            this.gbxLegenda.TabIndex = 7;
            this.gbxLegenda.TabStop = false;
            this.gbxLegenda.Text = "Legenda";
            this.gbxLegenda.Visible = false;
            // 
            // lblInterventoManut_completa
            // 
            this.lblInterventoManut_completa.AutoSize = true;
            this.lblInterventoManut_completa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInterventoManut_completa.Location = new System.Drawing.Point(6, 37);
            this.lblInterventoManut_completa.Name = "lblInterventoManut_completa";
            this.lblInterventoManut_completa.Size = new System.Drawing.Size(158, 17);
            this.lblInterventoManut_completa.TabIndex = 1;
            this.lblInterventoManut_completa.Text = "Manutenzione Completa:";
            // 
            // lblSimboloManut_parziale
            // 
            this.lblSimboloManut_parziale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimboloManut_parziale.AutoSize = true;
            this.lblSimboloManut_parziale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSimboloManut_parziale.ForeColor = System.Drawing.Color.Orange;
            this.lblSimboloManut_parziale.Location = new System.Drawing.Point(157, 62);
            this.lblSimboloManut_parziale.Name = "lblSimboloManut_parziale";
            this.lblSimboloManut_parziale.Size = new System.Drawing.Size(18, 17);
            this.lblSimboloManut_parziale.TabIndex = 7;
            this.lblSimboloManut_parziale.Text = "◈";
            // 
            // lblSimboloFgas
            // 
            this.lblSimboloFgas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimboloFgas.AutoSize = true;
            this.lblSimboloFgas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSimboloFgas.ForeColor = System.Drawing.Color.Green;
            this.lblSimboloFgas.Location = new System.Drawing.Point(157, 145);
            this.lblSimboloFgas.Name = "lblSimboloFgas";
            this.lblSimboloFgas.Size = new System.Drawing.Size(18, 17);
            this.lblSimboloFgas.TabIndex = 10;
            this.lblSimboloFgas.Text = "◈";
            // 
            // lblSimboloSostFiltri
            // 
            this.lblSimboloSostFiltri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimboloSostFiltri.AutoSize = true;
            this.lblSimboloSostFiltri.ForeColor = System.Drawing.Color.Blue;
            this.lblSimboloSostFiltri.Location = new System.Drawing.Point(157, 113);
            this.lblSimboloSostFiltri.Name = "lblSimboloSostFiltri";
            this.lblSimboloSostFiltri.Size = new System.Drawing.Size(18, 17);
            this.lblSimboloSostFiltri.TabIndex = 9;
            this.lblSimboloSostFiltri.Text = "◈";
            // 
            // lblSimboloControllo_generale
            // 
            this.lblSimboloControllo_generale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimboloControllo_generale.AutoSize = true;
            this.lblSimboloControllo_generale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSimboloControllo_generale.ForeColor = System.Drawing.Color.Yellow;
            this.lblSimboloControllo_generale.Location = new System.Drawing.Point(157, 92);
            this.lblSimboloControllo_generale.Name = "lblSimboloControllo_generale";
            this.lblSimboloControllo_generale.Size = new System.Drawing.Size(18, 17);
            this.lblSimboloControllo_generale.TabIndex = 8;
            this.lblSimboloControllo_generale.Text = "◈";
            // 
            // lblInterventoFgas
            // 
            this.lblInterventoFgas.AutoSize = true;
            this.lblInterventoFgas.Location = new System.Drawing.Point(6, 145);
            this.lblInterventoFgas.Name = "lblInterventoFgas";
            this.lblInterventoFgas.Size = new System.Drawing.Size(96, 17);
            this.lblInterventoFgas.TabIndex = 5;
            this.lblInterventoFgas.Text = "Controllo Fgas:";
            // 
            // lblInterventoSostfiltri
            // 
            this.lblInterventoSostfiltri.AutoSize = true;
            this.lblInterventoSostfiltri.Location = new System.Drawing.Point(6, 113);
            this.lblInterventoSostfiltri.Name = "lblInterventoSostfiltri";
            this.lblInterventoSostfiltri.Size = new System.Drawing.Size(125, 17);
            this.lblInterventoSostfiltri.TabIndex = 4;
            this.lblInterventoSostfiltri.Text = "Sost Filtri e Carboni:";
            // 
            // lblInterventoControllo_Generale
            // 
            this.lblInterventoControllo_Generale.AutoSize = true;
            this.lblInterventoControllo_Generale.Location = new System.Drawing.Point(6, 83);
            this.lblInterventoControllo_Generale.Name = "lblInterventoControllo_Generale";
            this.lblInterventoControllo_Generale.Size = new System.Drawing.Size(123, 17);
            this.lblInterventoControllo_Generale.TabIndex = 3;
            this.lblInterventoControllo_Generale.Text = "Controllo Generale:";
            // 
            // btnExitLegend
            // 
            this.btnExitLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitLegend.BackColor = System.Drawing.Color.Red;
            this.btnExitLegend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitLegend.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnExitLegend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitLegend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExitLegend.Location = new System.Drawing.Point(177, 9);
            this.btnExitLegend.Name = "btnExitLegend";
            this.btnExitLegend.Size = new System.Drawing.Size(25, 25);
            this.btnExitLegend.TabIndex = 0;
            this.btnExitLegend.Text = "X";
            this.btnExitLegend.UseVisualStyleBackColor = false;
            this.btnExitLegend.Click += new System.EventHandler(this.BtnExitLegend_Click);
            // 
            // lblInterventoManut_parziale
            // 
            this.lblInterventoManut_parziale.AutoSize = true;
            this.lblInterventoManut_parziale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInterventoManut_parziale.Location = new System.Drawing.Point(6, 58);
            this.lblInterventoManut_parziale.Name = "lblInterventoManut_parziale";
            this.lblInterventoManut_parziale.Size = new System.Drawing.Size(147, 17);
            this.lblInterventoManut_parziale.TabIndex = 2;
            this.lblInterventoManut_parziale.Text = "Manutenzione Parziale:";
            // 
            // lblSimboloManut_completa
            // 
            this.lblSimboloManut_completa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimboloManut_completa.AutoSize = true;
            this.lblSimboloManut_completa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSimboloManut_completa.ForeColor = System.Drawing.Color.Red;
            this.lblSimboloManut_completa.Location = new System.Drawing.Point(157, 41);
            this.lblSimboloManut_completa.Name = "lblSimboloManut_completa";
            this.lblSimboloManut_completa.Size = new System.Drawing.Size(18, 17);
            this.lblSimboloManut_completa.TabIndex = 6;
            this.lblSimboloManut_completa.Text = "◈";
            // 
            // btnExitAggiungi
            // 
            this.btnExitAggiungi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitAggiungi.BackColor = System.Drawing.Color.Red;
            this.btnExitAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitAggiungi.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnExitAggiungi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitAggiungi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExitAggiungi.Location = new System.Drawing.Point(596, 0);
            this.btnExitAggiungi.Name = "btnExitAggiungi";
            this.btnExitAggiungi.Size = new System.Drawing.Size(25, 25);
            this.btnExitAggiungi.TabIndex = 0;
            this.btnExitAggiungi.Text = "X";
            this.btnExitAggiungi.UseVisualStyleBackColor = false;
            this.btnExitAggiungi.Click += new System.EventHandler(this.BtnExitAggiungi_Click);
            // 
            // gbxAggiungi
            // 
            this.gbxAggiungi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAggiungi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxAggiungi.Controls.Add(this.cBxAggiungiEventoMacchine);
            this.gbxAggiungi.Controls.Add(this.cBxAggiungiEventoCliente);
            this.gbxAggiungi.Controls.Add(this.lblAggiungiLista);
            this.gbxAggiungi.Controls.Add(this.btnConfermaAggiungi);
            this.gbxAggiungi.Controls.Add(this.btnAggiungiRimuoviintervento);
            this.gbxAggiungi.Controls.Add(this.lblAggiungiDispListaIntervent);
            this.gbxAggiungi.Controls.Add(this.listViewAggiungiIntervento);
            this.gbxAggiungi.Controls.Add(this.btnAggiungiAddintervento);
            this.gbxAggiungi.Controls.Add(this.comboBoxAggiungi);
            this.gbxAggiungi.Controls.Add(this.lblMacchina);
            this.gbxAggiungi.Controls.Add(this.rtbAggiungiNote);
            this.gbxAggiungi.Controls.Add(this.lblAggiungiNote);
            this.gbxAggiungi.Controls.Add(this.lblAggCliente);
            this.gbxAggiungi.Controls.Add(this.btnExitAggiungi);
            this.gbxAggiungi.Enabled = false;
            this.gbxAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxAggiungi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxAggiungi.ForeColor = System.Drawing.Color.White;
            this.gbxAggiungi.Location = new System.Drawing.Point(31, 75);
            this.gbxAggiungi.Name = "gbxAggiungi";
            this.gbxAggiungi.Size = new System.Drawing.Size(621, 574);
            this.gbxAggiungi.TabIndex = 8;
            this.gbxAggiungi.TabStop = false;
            this.gbxAggiungi.Text = "Aggiungi Evento";
            this.gbxAggiungi.Visible = false;
            // 
            // cBxAggiungiEventoMacchine
            // 
            this.cBxAggiungiEventoMacchine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBxAggiungiEventoMacchine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBxAggiungiEventoMacchine.FormattingEnabled = true;
            this.cBxAggiungiEventoMacchine.Location = new System.Drawing.Point(362, 67);
            this.cBxAggiungiEventoMacchine.Name = "cBxAggiungiEventoMacchine";
            this.cBxAggiungiEventoMacchine.Size = new System.Drawing.Size(216, 25);
            this.cBxAggiungiEventoMacchine.TabIndex = 23;
            // 
            // cBxAggiungiEventoCliente
            // 
            this.cBxAggiungiEventoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBxAggiungiEventoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBxAggiungiEventoCliente.FormattingEnabled = true;
            this.cBxAggiungiEventoCliente.Location = new System.Drawing.Point(41, 65);
            this.cBxAggiungiEventoCliente.Name = "cBxAggiungiEventoCliente";
            this.cBxAggiungiEventoCliente.Size = new System.Drawing.Size(216, 25);
            this.cBxAggiungiEventoCliente.TabIndex = 22;
            this.cBxAggiungiEventoCliente.TextChanged += new System.EventHandler(this.cBxAggiungiEventoCliente_TextChanged);
            // 
            // lblAggiungiLista
            // 
            this.lblAggiungiLista.AutoSize = true;
            this.lblAggiungiLista.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAggiungiLista.Location = new System.Drawing.Point(422, 145);
            this.lblAggiungiLista.Name = "lblAggiungiLista";
            this.lblAggiungiLista.Size = new System.Drawing.Size(39, 17);
            this.lblAggiungiLista.TabIndex = 21;
            this.lblAggiungiLista.Text = "Lista:";
            // 
            // btnConfermaAggiungi
            // 
            this.btnConfermaAggiungi.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfermaAggiungi.FlatAppearance.BorderSize = 0;
            this.btnConfermaAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfermaAggiungi.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfermaAggiungi.Location = new System.Drawing.Point(0, 511);
            this.btnConfermaAggiungi.Name = "btnConfermaAggiungi";
            this.btnConfermaAggiungi.Size = new System.Drawing.Size(628, 63);
            this.btnConfermaAggiungi.TabIndex = 20;
            this.btnConfermaAggiungi.Text = "Conferma Evento";
            this.btnConfermaAggiungi.UseVisualStyleBackColor = false;
            this.btnConfermaAggiungi.Click += new System.EventHandler(this.btnConfermaAggiungi_Click);
            // 
            // btnAggiungiRimuoviintervento
            // 
            this.btnAggiungiRimuoviintervento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAggiungiRimuoviintervento.FlatAppearance.BorderSize = 0;
            this.btnAggiungiRimuoviintervento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiRimuoviintervento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAggiungiRimuoviintervento.Location = new System.Drawing.Point(56, 228);
            this.btnAggiungiRimuoviintervento.Name = "btnAggiungiRimuoviintervento";
            this.btnAggiungiRimuoviintervento.Size = new System.Drawing.Size(137, 57);
            this.btnAggiungiRimuoviintervento.TabIndex = 18;
            this.btnAggiungiRimuoviintervento.Text = "Rimuovi ";
            this.btnAggiungiRimuoviintervento.UseVisualStyleBackColor = false;
            this.btnAggiungiRimuoviintervento.Click += new System.EventHandler(this.btnAggiungiRimuoviintervento_Click);
            // 
            // lblAggiungiDispListaIntervent
            // 
            this.lblAggiungiDispListaIntervent.AutoSize = true;
            this.lblAggiungiDispListaIntervent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAggiungiDispListaIntervent.Location = new System.Drawing.Point(245, 125);
            this.lblAggiungiDispListaIntervent.Name = "lblAggiungiDispListaIntervent";
            this.lblAggiungiDispListaIntervent.Size = new System.Drawing.Size(113, 17);
            this.lblAggiungiDispListaIntervent.TabIndex = 17;
            this.lblAggiungiDispListaIntervent.Text = "Elenco Interventi:";
            // 
            // listViewAggiungiIntervento
            // 
            this.listViewAggiungiIntervento.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewAggiungiIntervento.BackColor = System.Drawing.Color.White;
            this.listViewAggiungiIntervento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewAggiungiIntervento.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listViewAggiungiIntervento.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAggiungiIntervento.HideSelection = false;
            this.listViewAggiungiIntervento.HoverSelection = true;
            this.listViewAggiungiIntervento.Location = new System.Drawing.Point(313, 200);
            this.listViewAggiungiIntervento.Name = "listViewAggiungiIntervento";
            this.listViewAggiungiIntervento.Size = new System.Drawing.Size(265, 85);
            this.listViewAggiungiIntervento.TabIndex = 16;
            this.listViewAggiungiIntervento.UseCompatibleStateImageBehavior = false;
            this.listViewAggiungiIntervento.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Interventi";
            this.columnHeader1.Width = 123;
            // 
            // btnAggiungiAddintervento
            // 
            this.btnAggiungiAddintervento.BackColor = System.Drawing.Color.Teal;
            this.btnAggiungiAddintervento.FlatAppearance.BorderSize = 0;
            this.btnAggiungiAddintervento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiAddintervento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAggiungiAddintervento.Location = new System.Drawing.Point(56, 162);
            this.btnAggiungiAddintervento.Name = "btnAggiungiAddintervento";
            this.btnAggiungiAddintervento.Size = new System.Drawing.Size(137, 54);
            this.btnAggiungiAddintervento.TabIndex = 15;
            this.btnAggiungiAddintervento.Text = "Aggiungi ";
            this.btnAggiungiAddintervento.UseVisualStyleBackColor = false;
            this.btnAggiungiAddintervento.Click += new System.EventHandler(this.btnAggiungiAddintervento_Click);
            // 
            // comboBoxAggiungi
            // 
            this.comboBoxAggiungi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAggiungi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAggiungi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAggiungi.FormattingEnabled = true;
            this.comboBoxAggiungi.Location = new System.Drawing.Point(313, 165);
            this.comboBoxAggiungi.MaxDropDownItems = 3;
            this.comboBoxAggiungi.Name = "comboBoxAggiungi";
            this.comboBoxAggiungi.Size = new System.Drawing.Size(265, 25);
            this.comboBoxAggiungi.TabIndex = 14;
            // 
            // lblMacchina
            // 
            this.lblMacchina.AutoSize = true;
            this.lblMacchina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMacchina.Location = new System.Drawing.Point(437, 52);
            this.lblMacchina.Name = "lblMacchina";
            this.lblMacchina.Size = new System.Drawing.Size(69, 17);
            this.lblMacchina.TabIndex = 12;
            this.lblMacchina.Text = "Macchine:";
            // 
            // rtbAggiungiNote
            // 
            this.rtbAggiungiNote.Location = new System.Drawing.Point(0, 328);
            this.rtbAggiungiNote.Name = "rtbAggiungiNote";
            this.rtbAggiungiNote.Size = new System.Drawing.Size(621, 177);
            this.rtbAggiungiNote.TabIndex = 10;
            this.rtbAggiungiNote.Text = "";
            // 
            // lblAggiungiNote
            // 
            this.lblAggiungiNote.AutoSize = true;
            this.lblAggiungiNote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAggiungiNote.Location = new System.Drawing.Point(290, 308);
            this.lblAggiungiNote.Name = "lblAggiungiNote";
            this.lblAggiungiNote.Size = new System.Drawing.Size(41, 17);
            this.lblAggiungiNote.TabIndex = 6;
            this.lblAggiungiNote.Text = "Note:";
            // 
            // lblAggCliente
            // 
            this.lblAggCliente.AutoSize = true;
            this.lblAggCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAggCliente.Location = new System.Drawing.Point(120, 48);
            this.lblAggCliente.Name = "lblAggCliente";
            this.lblAggCliente.Size = new System.Drawing.Size(52, 17);
            this.lblAggCliente.TabIndex = 4;
            this.lblAggCliente.Text = "Cliente:";
            // 
            // gbxModifica
            // 
            this.gbxModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxModifica.Controls.Add(this.cBxModificaEventoMacchine);
            this.gbxModifica.Controls.Add(this.cBxModificaEventoCliente);
            this.gbxModifica.Controls.Add(this.btnModificaRimuoviOperazioni);
            this.gbxModifica.Controls.Add(this.lblModificaEventoLista);
            this.gbxModifica.Controls.Add(this.btnConfermaModifica);
            this.gbxModifica.Controls.Add(this.lblModificaEventoInterventi);
            this.gbxModifica.Controls.Add(this.listViewModificaOperazioni);
            this.gbxModifica.Controls.Add(this.btnModificaAggiungiOperazioni);
            this.gbxModifica.Controls.Add(this.cbxModificaListaOperazioni);
            this.gbxModifica.Controls.Add(this.lblModificaEventoMacchine);
            this.gbxModifica.Controls.Add(this.rtbModificaNote);
            this.gbxModifica.Controls.Add(this.lblModificaEventoNote);
            this.gbxModifica.Controls.Add(this.lblModificaCliente);
            this.gbxModifica.Controls.Add(this.btnExitModifica);
            this.gbxModifica.Enabled = false;
            this.gbxModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxModifica.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxModifica.ForeColor = System.Drawing.Color.White;
            this.gbxModifica.Location = new System.Drawing.Point(807, 75);
            this.gbxModifica.Name = "gbxModifica";
            this.gbxModifica.Size = new System.Drawing.Size(681, 574);
            this.gbxModifica.TabIndex = 9;
            this.gbxModifica.TabStop = false;
            this.gbxModifica.Text = "Modifica Evento";
            this.gbxModifica.Visible = false;
            // 
            // cBxModificaEventoMacchine
            // 
            this.cBxModificaEventoMacchine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBxModificaEventoMacchine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBxModificaEventoMacchine.FormattingEnabled = true;
            this.cBxModificaEventoMacchine.Location = new System.Drawing.Point(389, 86);
            this.cBxModificaEventoMacchine.Name = "cBxModificaEventoMacchine";
            this.cBxModificaEventoMacchine.Size = new System.Drawing.Size(216, 25);
            this.cBxModificaEventoMacchine.TabIndex = 25;
            // 
            // cBxModificaEventoCliente
            // 
            this.cBxModificaEventoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBxModificaEventoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBxModificaEventoCliente.FormattingEnabled = true;
            this.cBxModificaEventoCliente.Location = new System.Drawing.Point(68, 84);
            this.cBxModificaEventoCliente.Name = "cBxModificaEventoCliente";
            this.cBxModificaEventoCliente.Size = new System.Drawing.Size(216, 25);
            this.cBxModificaEventoCliente.TabIndex = 24;
            // 
            // btnModificaRimuoviOperazioni
            // 
            this.btnModificaRimuoviOperazioni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModificaRimuoviOperazioni.FlatAppearance.BorderSize = 0;
            this.btnModificaRimuoviOperazioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaRimuoviOperazioni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificaRimuoviOperazioni.Location = new System.Drawing.Point(112, 224);
            this.btnModificaRimuoviOperazioni.Name = "btnModificaRimuoviOperazioni";
            this.btnModificaRimuoviOperazioni.Size = new System.Drawing.Size(137, 57);
            this.btnModificaRimuoviOperazioni.TabIndex = 34;
            this.btnModificaRimuoviOperazioni.Text = "Rimuovi ";
            this.btnModificaRimuoviOperazioni.UseVisualStyleBackColor = false;
            this.btnModificaRimuoviOperazioni.Click += new System.EventHandler(this.btnModificaRimuoviOperazioni_Click);
            // 
            // lblModificaEventoLista
            // 
            this.lblModificaEventoLista.AutoSize = true;
            this.lblModificaEventoLista.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModificaEventoLista.Location = new System.Drawing.Point(475, 141);
            this.lblModificaEventoLista.Name = "lblModificaEventoLista";
            this.lblModificaEventoLista.Size = new System.Drawing.Size(39, 17);
            this.lblModificaEventoLista.TabIndex = 33;
            this.lblModificaEventoLista.Text = "Lista:";
            // 
            // btnConfermaModifica
            // 
            this.btnConfermaModifica.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfermaModifica.FlatAppearance.BorderSize = 0;
            this.btnConfermaModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfermaModifica.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfermaModifica.Location = new System.Drawing.Point(0, 511);
            this.btnConfermaModifica.Name = "btnConfermaModifica";
            this.btnConfermaModifica.Size = new System.Drawing.Size(681, 63);
            this.btnConfermaModifica.TabIndex = 32;
            this.btnConfermaModifica.Text = "Conferma modifica";
            this.btnConfermaModifica.UseVisualStyleBackColor = false;
            this.btnConfermaModifica.Click += new System.EventHandler(this.btnConfermaModifica_Click);
            // 
            // lblModificaEventoInterventi
            // 
            this.lblModificaEventoInterventi.AutoSize = true;
            this.lblModificaEventoInterventi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModificaEventoInterventi.Location = new System.Drawing.Point(263, 125);
            this.lblModificaEventoInterventi.Name = "lblModificaEventoInterventi";
            this.lblModificaEventoInterventi.Size = new System.Drawing.Size(113, 17);
            this.lblModificaEventoInterventi.TabIndex = 31;
            this.lblModificaEventoInterventi.Text = "Elenco Interventi:";
            // 
            // listViewModificaOperazioni
            // 
            this.listViewModificaOperazioni.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewModificaOperazioni.BackColor = System.Drawing.Color.White;
            this.listViewModificaOperazioni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewModificaOperazioni.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listViewModificaOperazioni.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewModificaOperazioni.HideSelection = false;
            this.listViewModificaOperazioni.HoverSelection = true;
            this.listViewModificaOperazioni.Location = new System.Drawing.Point(362, 192);
            this.listViewModificaOperazioni.Name = "listViewModificaOperazioni";
            this.listViewModificaOperazioni.Size = new System.Drawing.Size(265, 89);
            this.listViewModificaOperazioni.TabIndex = 30;
            this.listViewModificaOperazioni.UseCompatibleStateImageBehavior = false;
            this.listViewModificaOperazioni.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Interventi";
            this.columnHeader2.Width = 123;
            // 
            // btnModificaAggiungiOperazioni
            // 
            this.btnModificaAggiungiOperazioni.BackColor = System.Drawing.Color.Teal;
            this.btnModificaAggiungiOperazioni.FlatAppearance.BorderSize = 0;
            this.btnModificaAggiungiOperazioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaAggiungiOperazioni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificaAggiungiOperazioni.Location = new System.Drawing.Point(112, 156);
            this.btnModificaAggiungiOperazioni.Name = "btnModificaAggiungiOperazioni";
            this.btnModificaAggiungiOperazioni.Size = new System.Drawing.Size(137, 51);
            this.btnModificaAggiungiOperazioni.TabIndex = 29;
            this.btnModificaAggiungiOperazioni.Text = "Aggiungi ";
            this.btnModificaAggiungiOperazioni.UseVisualStyleBackColor = false;
            this.btnModificaAggiungiOperazioni.Click += new System.EventHandler(this.btnModificaAggiungiOperazioni_Click);
            // 
            // cbxModificaListaOperazioni
            // 
            this.cbxModificaListaOperazioni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModificaListaOperazioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxModificaListaOperazioni.FormattingEnabled = true;
            this.cbxModificaListaOperazioni.Location = new System.Drawing.Point(362, 161);
            this.cbxModificaListaOperazioni.MaxDropDownItems = 3;
            this.cbxModificaListaOperazioni.Name = "cbxModificaListaOperazioni";
            this.cbxModificaListaOperazioni.Size = new System.Drawing.Size(265, 25);
            this.cbxModificaListaOperazioni.TabIndex = 28;
            // 
            // lblModificaEventoMacchine
            // 
            this.lblModificaEventoMacchine.AutoSize = true;
            this.lblModificaEventoMacchine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModificaEventoMacchine.Location = new System.Drawing.Point(466, 52);
            this.lblModificaEventoMacchine.Name = "lblModificaEventoMacchine";
            this.lblModificaEventoMacchine.Size = new System.Drawing.Size(69, 17);
            this.lblModificaEventoMacchine.TabIndex = 26;
            this.lblModificaEventoMacchine.Text = "Macchine:";
            // 
            // rtbModificaNote
            // 
            this.rtbModificaNote.Location = new System.Drawing.Point(0, 328);
            this.rtbModificaNote.Name = "rtbModificaNote";
            this.rtbModificaNote.Size = new System.Drawing.Size(681, 177);
            this.rtbModificaNote.TabIndex = 24;
            this.rtbModificaNote.Text = "";
            // 
            // lblModificaEventoNote
            // 
            this.lblModificaEventoNote.AutoSize = true;
            this.lblModificaEventoNote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModificaEventoNote.Location = new System.Drawing.Point(300, 308);
            this.lblModificaEventoNote.Name = "lblModificaEventoNote";
            this.lblModificaEventoNote.Size = new System.Drawing.Size(41, 17);
            this.lblModificaEventoNote.TabIndex = 23;
            this.lblModificaEventoNote.Text = "Note:";
            // 
            // lblModificaCliente
            // 
            this.lblModificaCliente.AutoSize = true;
            this.lblModificaCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModificaCliente.Location = new System.Drawing.Point(152, 52);
            this.lblModificaCliente.Name = "lblModificaCliente";
            this.lblModificaCliente.Size = new System.Drawing.Size(52, 17);
            this.lblModificaCliente.TabIndex = 3;
            this.lblModificaCliente.Text = "Cliente:";
            // 
            // btnExitModifica
            // 
            this.btnExitModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitModifica.BackColor = System.Drawing.Color.Red;
            this.btnExitModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitModifica.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnExitModifica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitModifica.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExitModifica.Location = new System.Drawing.Point(656, 0);
            this.btnExitModifica.Name = "btnExitModifica";
            this.btnExitModifica.Size = new System.Drawing.Size(25, 25);
            this.btnExitModifica.TabIndex = 0;
            this.btnExitModifica.Text = "X";
            this.btnExitModifica.UseVisualStyleBackColor = false;
            this.btnExitModifica.Click += new System.EventHandler(this.btnExitModifica_Click);
            // 
            // pnlCommands1
            // 
            this.pnlCommands1.BackColor = System.Drawing.Color.DimGray;
            this.pnlCommands1.Controls.Add(this.btnAdd);
            this.pnlCommands1.Controls.Add(this.btnModify);
            this.pnlCommands1.Controls.Add(this.btnRemove);
            this.pnlCommands1.Location = new System.Drawing.Point(0, 3);
            this.pnlCommands1.Name = "pnlCommands1";
            this.pnlCommands1.Size = new System.Drawing.Size(302, 72);
            this.pnlCommands1.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.add_icon;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(83, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.BackColor = System.Drawing.Color.Goldenrod;
            this.btnModify.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.modify_icon;
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModify.Enabled = false;
            this.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnModify.FlatAppearance.BorderSize = 3;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnModify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModify.Location = new System.Drawing.Point(153, 8);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(68, 51);
            this.btnModify.TabIndex = 2;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.remove_icon;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatAppearance.BorderSize = 3;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemove.Location = new System.Drawing.Point(227, 8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(61, 50);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxDettagli
            // 
            this.gbxDettagli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDettagli.Controls.Add(this.rtbNoteDettagli);
            this.gbxDettagli.Enabled = false;
            this.gbxDettagli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxDettagli.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxDettagli.ForeColor = System.Drawing.Color.White;
            this.gbxDettagli.Location = new System.Drawing.Point(757, 716);
            this.gbxDettagli.Name = "gbxDettagli";
            this.gbxDettagli.Size = new System.Drawing.Size(538, 254);
            this.gbxDettagli.TabIndex = 10;
            this.gbxDettagli.TabStop = false;
            this.gbxDettagli.Text = "Note Evento";
            this.gbxDettagli.Visible = false;
            // 
            // rtbNoteDettagli
            // 
            this.rtbNoteDettagli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNoteDettagli.Location = new System.Drawing.Point(3, 20);
            this.rtbNoteDettagli.Name = "rtbNoteDettagli";
            this.rtbNoteDettagli.ReadOnly = true;
            this.rtbNoteDettagli.Size = new System.Drawing.Size(532, 231);
            this.rtbNoteDettagli.TabIndex = 1;
            this.rtbNoteDettagli.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1492, 757);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.gbxLegenda);
            this.tabPage1.Controls.Add(this.gbxModifica);
            this.tabPage1.Controls.Add(this.gbxAggiungi);
            this.tabPage1.Controls.Add(this.pnlCercaEvento);
            this.tabPage1.Controls.Add(this.gBxDettagliCliente);
            this.tabPage1.Controls.Add(this.gBxDettagliMacchinaAccessorio);
            this.tabPage1.Controls.Add(this.ariCalendario);
            this.tabPage1.Controls.Add(this.gbxDettagli);
            this.tabPage1.Controls.Add(this.pnlCommands1);
            this.tabPage1.Controls.Add(this.btnLegenda);
            this.tabPage1.Controls.Add(this.lblEventi);
            this.tabPage1.Controls.Add(this.dgwEventi);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1484, 731);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Eventi";
            // 
            // pnlCercaEvento
            // 
            this.pnlCercaEvento.BackColor = System.Drawing.Color.DimGray;
            this.pnlCercaEvento.Controls.Add(this.btnSearchEvento);
            this.pnlCercaEvento.Controls.Add(this.rdBtnSearchEventoMatricola);
            this.pnlCercaEvento.Controls.Add(this.rdBtnSearchEventoCliente);
            this.pnlCercaEvento.Controls.Add(this.cbBxSearchEventoMatricola);
            this.pnlCercaEvento.Controls.Add(this.cbBxSearchEventoCliente);
            this.pnlCercaEvento.Location = new System.Drawing.Point(309, 0);
            this.pnlCercaEvento.Name = "pnlCercaEvento";
            this.pnlCercaEvento.Size = new System.Drawing.Size(312, 75);
            this.pnlCercaEvento.TabIndex = 15;
            // 
            // btnSearchEvento
            // 
            this.btnSearchEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearchEvento.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.search_icon;
            this.btnSearchEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchEvento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearchEvento.FlatAppearance.BorderSize = 15;
            this.btnSearchEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEvento.Location = new System.Drawing.Point(243, 12);
            this.btnSearchEvento.Name = "btnSearchEvento";
            this.btnSearchEvento.Size = new System.Drawing.Size(66, 58);
            this.btnSearchEvento.TabIndex = 25;
            this.btnSearchEvento.UseVisualStyleBackColor = false;
            this.btnSearchEvento.Click += new System.EventHandler(this.btnSearchEvento_Click);
            // 
            // rdBtnSearchEventoMatricola
            // 
            this.rdBtnSearchEventoMatricola.AutoSize = true;
            this.rdBtnSearchEventoMatricola.ForeColor = System.Drawing.Color.White;
            this.rdBtnSearchEventoMatricola.Location = new System.Drawing.Point(15, 44);
            this.rdBtnSearchEventoMatricola.Name = "rdBtnSearchEventoMatricola";
            this.rdBtnSearchEventoMatricola.Size = new System.Drawing.Size(84, 22);
            this.rdBtnSearchEventoMatricola.TabIndex = 3;
            this.rdBtnSearchEventoMatricola.Text = "Macchina";
            this.rdBtnSearchEventoMatricola.UseVisualStyleBackColor = true;
            this.rdBtnSearchEventoMatricola.CheckedChanged += new System.EventHandler(this.rdBtnSearchEventoMatricola_CheckedChanged);
            // 
            // rdBtnSearchEventoCliente
            // 
            this.rdBtnSearchEventoCliente.AutoSize = true;
            this.rdBtnSearchEventoCliente.Checked = true;
            this.rdBtnSearchEventoCliente.ForeColor = System.Drawing.Color.White;
            this.rdBtnSearchEventoCliente.Location = new System.Drawing.Point(15, 12);
            this.rdBtnSearchEventoCliente.Name = "rdBtnSearchEventoCliente";
            this.rdBtnSearchEventoCliente.Size = new System.Drawing.Size(71, 22);
            this.rdBtnSearchEventoCliente.TabIndex = 2;
            this.rdBtnSearchEventoCliente.TabStop = true;
            this.rdBtnSearchEventoCliente.Text = "Cliente";
            this.rdBtnSearchEventoCliente.UseVisualStyleBackColor = true;
            this.rdBtnSearchEventoCliente.CheckedChanged += new System.EventHandler(this.rdBtnSearchEventoCliente_CheckedChanged);
            // 
            // cbBxSearchEventoMatricola
            // 
            this.cbBxSearchEventoMatricola.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBxSearchEventoMatricola.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBxSearchEventoMatricola.Enabled = false;
            this.cbBxSearchEventoMatricola.FormattingEnabled = true;
            this.cbBxSearchEventoMatricola.Location = new System.Drawing.Point(116, 43);
            this.cbBxSearchEventoMatricola.Name = "cbBxSearchEventoMatricola";
            this.cbBxSearchEventoMatricola.Size = new System.Drawing.Size(121, 26);
            this.cbBxSearchEventoMatricola.TabIndex = 1;
            // 
            // cbBxSearchEventoCliente
            // 
            this.cbBxSearchEventoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBxSearchEventoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBxSearchEventoCliente.FormattingEnabled = true;
            this.cbBxSearchEventoCliente.Location = new System.Drawing.Point(116, 11);
            this.cbBxSearchEventoCliente.Name = "cbBxSearchEventoCliente";
            this.cbBxSearchEventoCliente.Size = new System.Drawing.Size(121, 26);
            this.cbBxSearchEventoCliente.TabIndex = 0;
            // 
            // gBxDettagliCliente
            // 
            this.gBxDettagliCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBxDettagliCliente.Controls.Add(this.lblDettagliClientePrif);
            this.gBxDettagliCliente.Controls.Add(this.txBxDettagliClientePrif);
            this.gBxDettagliCliente.Controls.Add(this.lblDettagliClienteIva);
            this.gBxDettagliCliente.Controls.Add(this.txBxDettagliClienteIva);
            this.gBxDettagliCliente.Controls.Add(this.lblDettagliClienteIndirizzo);
            this.gBxDettagliCliente.Controls.Add(this.txBxDettagliClienteIndirizzo);
            this.gBxDettagliCliente.Controls.Add(this.lblDettagliClienteMail);
            this.gBxDettagliCliente.Controls.Add(this.txBxDettagliClienteMail);
            this.gBxDettagliCliente.Controls.Add(this.lblDettagliClienteTel);
            this.gBxDettagliCliente.Controls.Add(this.txBxDettagliClienteTel);
            this.gBxDettagliCliente.Enabled = false;
            this.gBxDettagliCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBxDettagliCliente.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBxDettagliCliente.ForeColor = System.Drawing.Color.White;
            this.gBxDettagliCliente.Location = new System.Drawing.Point(1181, 655);
            this.gBxDettagliCliente.Name = "gBxDettagliCliente";
            this.gBxDettagliCliente.Size = new System.Drawing.Size(538, 254);
            this.gBxDettagliCliente.TabIndex = 14;
            this.gBxDettagliCliente.TabStop = false;
            this.gBxDettagliCliente.Text = "Dettagli cliente";
            this.gBxDettagliCliente.Visible = false;
            this.gBxDettagliCliente.MouseEnter += new System.EventHandler(this.gBxDettagliCliente_MouseEnter);
            // 
            // lblDettagliClientePrif
            // 
            this.lblDettagliClientePrif.AutoSize = true;
            this.lblDettagliClientePrif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDettagliClientePrif.ForeColor = System.Drawing.Color.White;
            this.lblDettagliClientePrif.Location = new System.Drawing.Point(44, 207);
            this.lblDettagliClientePrif.Name = "lblDettagliClientePrif";
            this.lblDettagliClientePrif.Size = new System.Drawing.Size(64, 25);
            this.lblDettagliClientePrif.TabIndex = 48;
            this.lblDettagliClientePrif.Text = "P.Rif:";
            // 
            // txBxDettagliClientePrif
            // 
            this.txBxDettagliClientePrif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxDettagliClientePrif.Location = new System.Drawing.Point(136, 207);
            this.txBxDettagliClientePrif.Name = "txBxDettagliClientePrif";
            this.txBxDettagliClientePrif.ReadOnly = true;
            this.txBxDettagliClientePrif.Size = new System.Drawing.Size(335, 26);
            this.txBxDettagliClientePrif.TabIndex = 47;
            // 
            // lblDettagliClienteIva
            // 
            this.lblDettagliClienteIva.AutoSize = true;
            this.lblDettagliClienteIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDettagliClienteIva.ForeColor = System.Drawing.Color.White;
            this.lblDettagliClienteIva.Location = new System.Drawing.Point(44, 172);
            this.lblDettagliClienteIva.Name = "lblDettagliClienteIva";
            this.lblDettagliClienteIva.Size = new System.Drawing.Size(57, 25);
            this.lblDettagliClienteIva.TabIndex = 46;
            this.lblDettagliClienteIva.Text = " IVA:";
            // 
            // txBxDettagliClienteIva
            // 
            this.txBxDettagliClienteIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxDettagliClienteIva.Location = new System.Drawing.Point(136, 171);
            this.txBxDettagliClienteIva.Name = "txBxDettagliClienteIva";
            this.txBxDettagliClienteIva.ReadOnly = true;
            this.txBxDettagliClienteIva.Size = new System.Drawing.Size(335, 26);
            this.txBxDettagliClienteIva.TabIndex = 45;
            // 
            // lblDettagliClienteIndirizzo
            // 
            this.lblDettagliClienteIndirizzo.AutoSize = true;
            this.lblDettagliClienteIndirizzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDettagliClienteIndirizzo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDettagliClienteIndirizzo.Location = new System.Drawing.Point(44, 135);
            this.lblDettagliClienteIndirizzo.Name = "lblDettagliClienteIndirizzo";
            this.lblDettagliClienteIndirizzo.Size = new System.Drawing.Size(47, 25);
            this.lblDettagliClienteIndirizzo.TabIndex = 44;
            this.lblDettagliClienteIndirizzo.Text = "Ind:";
            // 
            // txBxDettagliClienteIndirizzo
            // 
            this.txBxDettagliClienteIndirizzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxDettagliClienteIndirizzo.Location = new System.Drawing.Point(136, 135);
            this.txBxDettagliClienteIndirizzo.Name = "txBxDettagliClienteIndirizzo";
            this.txBxDettagliClienteIndirizzo.ReadOnly = true;
            this.txBxDettagliClienteIndirizzo.Size = new System.Drawing.Size(335, 26);
            this.txBxDettagliClienteIndirizzo.TabIndex = 43;
            // 
            // lblDettagliClienteMail
            // 
            this.lblDettagliClienteMail.AutoSize = true;
            this.lblDettagliClienteMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDettagliClienteMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDettagliClienteMail.Location = new System.Drawing.Point(44, 97);
            this.lblDettagliClienteMail.Name = "lblDettagliClienteMail";
            this.lblDettagliClienteMail.Size = new System.Drawing.Size(58, 25);
            this.lblDettagliClienteMail.TabIndex = 42;
            this.lblDettagliClienteMail.Text = "Mail:";
            // 
            // txBxDettagliClienteMail
            // 
            this.txBxDettagliClienteMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxDettagliClienteMail.Location = new System.Drawing.Point(136, 99);
            this.txBxDettagliClienteMail.Name = "txBxDettagliClienteMail";
            this.txBxDettagliClienteMail.ReadOnly = true;
            this.txBxDettagliClienteMail.Size = new System.Drawing.Size(335, 26);
            this.txBxDettagliClienteMail.TabIndex = 41;
            // 
            // lblDettagliClienteTel
            // 
            this.lblDettagliClienteTel.AutoSize = true;
            this.lblDettagliClienteTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDettagliClienteTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDettagliClienteTel.Location = new System.Drawing.Point(44, 67);
            this.lblDettagliClienteTel.Name = "lblDettagliClienteTel";
            this.lblDettagliClienteTel.Size = new System.Drawing.Size(48, 25);
            this.lblDettagliClienteTel.TabIndex = 40;
            this.lblDettagliClienteTel.Text = "Tel:";
            // 
            // txBxDettagliClienteTel
            // 
            this.txBxDettagliClienteTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxDettagliClienteTel.Location = new System.Drawing.Point(136, 63);
            this.txBxDettagliClienteTel.Name = "txBxDettagliClienteTel";
            this.txBxDettagliClienteTel.ReadOnly = true;
            this.txBxDettagliClienteTel.Size = new System.Drawing.Size(335, 26);
            this.txBxDettagliClienteTel.TabIndex = 39;
            // 
            // gBxDettagliMacchinaAccessorio
            // 
            this.gBxDettagliMacchinaAccessorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBxDettagliMacchinaAccessorio.Controls.Add(this.lblDettagliComponenti);
            this.gBxDettagliMacchinaAccessorio.Controls.Add(this.lblNoteMacchinaAccessorio);
            this.gBxDettagliMacchinaAccessorio.Controls.Add(this.lvwDettagliComponenti);
            this.gBxDettagliMacchinaAccessorio.Controls.Add(this.rtbNoteMacchinaAccessorio);
            this.gBxDettagliMacchinaAccessorio.Enabled = false;
            this.gBxDettagliMacchinaAccessorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBxDettagliMacchinaAccessorio.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBxDettagliMacchinaAccessorio.ForeColor = System.Drawing.Color.White;
            this.gBxDettagliMacchinaAccessorio.Location = new System.Drawing.Point(810, 666);
            this.gBxDettagliMacchinaAccessorio.Name = "gBxDettagliMacchinaAccessorio";
            this.gBxDettagliMacchinaAccessorio.Size = new System.Drawing.Size(538, 254);
            this.gBxDettagliMacchinaAccessorio.TabIndex = 13;
            this.gBxDettagliMacchinaAccessorio.TabStop = false;
            this.gBxDettagliMacchinaAccessorio.Text = "Dettagli macchina / accessorio";
            this.gBxDettagliMacchinaAccessorio.Visible = false;
            this.gBxDettagliMacchinaAccessorio.MouseLeave += new System.EventHandler(this.gBxDettagliMacchinaAccessorio_MouseLeave);
            this.gBxDettagliMacchinaAccessorio.MouseHover += new System.EventHandler(this.gBxDettagliMacchinaAccessorio_MouseHover);
            // 
            // lblDettagliComponenti
            // 
            this.lblDettagliComponenti.AutoSize = true;
            this.lblDettagliComponenti.Location = new System.Drawing.Point(351, 29);
            this.lblDettagliComponenti.Name = "lblDettagliComponenti";
            this.lblDettagliComponenti.Size = new System.Drawing.Size(81, 17);
            this.lblDettagliComponenti.TabIndex = 34;
            this.lblDettagliComponenti.Text = "Componenti";
            // 
            // lblNoteMacchinaAccessorio
            // 
            this.lblNoteMacchinaAccessorio.AutoSize = true;
            this.lblNoteMacchinaAccessorio.Location = new System.Drawing.Point(46, 29);
            this.lblNoteMacchinaAccessorio.Name = "lblNoteMacchinaAccessorio";
            this.lblNoteMacchinaAccessorio.Size = new System.Drawing.Size(40, 17);
            this.lblNoteMacchinaAccessorio.TabIndex = 33;
            this.lblNoteMacchinaAccessorio.Text = "Note ";
            // 
            // lvwDettagliComponenti
            // 
            this.lvwDettagliComponenti.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwDettagliComponenti.BackColor = System.Drawing.Color.White;
            this.lvwDettagliComponenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18});
            this.lvwDettagliComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDettagliComponenti.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lvwDettagliComponenti.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwDettagliComponenti.HideSelection = false;
            this.lvwDettagliComponenti.HoverSelection = true;
            this.lvwDettagliComponenti.Location = new System.Drawing.Point(264, 49);
            this.lvwDettagliComponenti.Name = "lvwDettagliComponenti";
            this.lvwDettagliComponenti.Size = new System.Drawing.Size(274, 202);
            this.lvwDettagliComponenti.TabIndex = 32;
            this.lvwDettagliComponenti.UseCompatibleStateImageBehavior = false;
            this.lvwDettagliComponenti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Tipo";
            this.columnHeader17.Width = 123;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Codice";
            this.columnHeader18.Width = 145;
            // 
            // rtbNoteMacchinaAccessorio
            // 
            this.rtbNoteMacchinaAccessorio.Location = new System.Drawing.Point(3, 49);
            this.rtbNoteMacchinaAccessorio.Name = "rtbNoteMacchinaAccessorio";
            this.rtbNoteMacchinaAccessorio.ReadOnly = true;
            this.rtbNoteMacchinaAccessorio.Size = new System.Drawing.Size(262, 202);
            this.rtbNoteMacchinaAccessorio.TabIndex = 1;
            this.rtbNoteMacchinaAccessorio.Text = "";
            // 
            // ariCalendario
            // 
            this.ariCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ariCalendario.Font = new System.Drawing.Font("Segoe UI Light", 32.25F);
            this.ariCalendario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ariCalendario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ariCalendario.Location = new System.Drawing.Point(2, 75);
            this.ariCalendario.Margin = new System.Windows.Forms.Padding(20);
            this.ariCalendario.MaxDate = new System.DateTime(2059, 12, 31, 0, 0, 0, 0);
            this.ariCalendario.MaxSelectionCount = 1;
            this.ariCalendario.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.ariCalendario.Name = "ariCalendario";
            this.ariCalendario.TabIndex = 12;
            this.ariCalendario.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ariCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.AriCalendario_DateChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.gBxAggiungiMacchina);
            this.tabPage2.Controls.Add(this.gBxModificaMacchina);
            this.tabPage2.Controls.Add(this.gBxClientiAggiungiCliente);
            this.tabPage2.Controls.Add(this.gBxClientiModificaClienti);
            this.tabPage2.Controls.Add(this.lblClienti);
            this.tabPage2.Controls.Add(this.gBxVisualizzaCliente);
            this.tabPage2.Controls.Add(this.pnlCommands2);
            this.tabPage2.Controls.Add(this.dgvVisualizzaClienti);
            this.tabPage2.Controls.Add(this.gBxClientiTrova);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1484, 731);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clienti";
            // 
            // gBxAggiungiMacchina
            // 
            this.gBxAggiungiMacchina.Controls.Add(this.cbBxAggiungiMacchinaTipoFiltro);
            this.gBxAggiungiMacchina.Controls.Add(this.lblAggiungiMacchinaMarca);
            this.gBxAggiungiMacchina.Controls.Add(this.txBxAggiungiMacchinaMarca);
            this.gBxAggiungiMacchina.Controls.Add(this.chBxAggiungiMacchinaNoleggio);
            this.gBxAggiungiMacchina.Controls.Add(this.txBxAggiungiMacchinaCodiceFiltro);
            this.gBxAggiungiMacchina.Controls.Add(this.rtbAggiungiMacchinaNote);
            this.gBxAggiungiMacchina.Controls.Add(this.lblAggiungiMacchinaNote);
            this.gBxAggiungiMacchina.Controls.Add(this.lblAggiungiMacchinaMatricola);
            this.gBxAggiungiMacchina.Controls.Add(this.txBxAggiungiMacchinaMatricola);
            this.gBxAggiungiMacchina.Controls.Add(this.lblAggiungiMacchinaComponenti);
            this.gBxAggiungiMacchina.Controls.Add(this.btnAggiungiMacchinaRimuoviComponenti);
            this.gBxAggiungiMacchina.Controls.Add(this.lvAggiungiMacchinaFiltri);
            this.gBxAggiungiMacchina.Controls.Add(this.btnAggiungiMacchinaAggiungiComponenti);
            this.gBxAggiungiMacchina.Controls.Add(this.lblAggiungiMacchinaModello);
            this.gBxAggiungiMacchina.Controls.Add(this.txBxAggiungiMacchinaModello);
            this.gBxAggiungiMacchina.Controls.Add(this.btnChiudigBxAggiungiMacchine);
            this.gBxAggiungiMacchina.Controls.Add(this.btnConfermaAggiungiMacchina);
            this.gBxAggiungiMacchina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxAggiungiMacchina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBxAggiungiMacchina.Location = new System.Drawing.Point(263, 43);
            this.gBxAggiungiMacchina.Name = "gBxAggiungiMacchina";
            this.gBxAggiungiMacchina.Size = new System.Drawing.Size(485, 645);
            this.gBxAggiungiMacchina.TabIndex = 43;
            this.gBxAggiungiMacchina.TabStop = false;
            this.gBxAggiungiMacchina.Text = "Aggiungi macchina/accessorio";
            this.gBxAggiungiMacchina.Visible = false;
            // 
            // cbBxAggiungiMacchinaTipoFiltro
            // 
            this.cbBxAggiungiMacchinaTipoFiltro.FormattingEnabled = true;
            this.cbBxAggiungiMacchinaTipoFiltro.Items.AddRange(new object[] {
            "Fa",
            "Fo",
            "Fi",
            "GA"});
            this.cbBxAggiungiMacchinaTipoFiltro.Location = new System.Drawing.Point(180, 321);
            this.cbBxAggiungiMacchinaTipoFiltro.Name = "cbBxAggiungiMacchinaTipoFiltro";
            this.cbBxAggiungiMacchinaTipoFiltro.Size = new System.Drawing.Size(67, 33);
            this.cbBxAggiungiMacchinaTipoFiltro.TabIndex = 47;
            // 
            // lblAggiungiMacchinaMarca
            // 
            this.lblAggiungiMacchinaMarca.AutoSize = true;
            this.lblAggiungiMacchinaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiMacchinaMarca.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiMacchinaMarca.Location = new System.Drawing.Point(172, 35);
            this.lblAggiungiMacchinaMarca.Name = "lblAggiungiMacchinaMarca";
            this.lblAggiungiMacchinaMarca.Size = new System.Drawing.Size(72, 25);
            this.lblAggiungiMacchinaMarca.TabIndex = 46;
            this.lblAggiungiMacchinaMarca.Text = "Marca";
            // 
            // txBxAggiungiMacchinaMarca
            // 
            this.txBxAggiungiMacchinaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxAggiungiMacchinaMarca.Location = new System.Drawing.Point(23, 69);
            this.txBxAggiungiMacchinaMarca.Name = "txBxAggiungiMacchinaMarca";
            this.txBxAggiungiMacchinaMarca.Size = new System.Drawing.Size(421, 26);
            this.txBxAggiungiMacchinaMarca.TabIndex = 45;
            // 
            // chBxAggiungiMacchinaNoleggio
            // 
            this.chBxAggiungiMacchinaNoleggio.AutoSize = true;
            this.chBxAggiungiMacchinaNoleggio.Location = new System.Drawing.Point(153, 236);
            this.chBxAggiungiMacchinaNoleggio.Name = "chBxAggiungiMacchinaNoleggio";
            this.chBxAggiungiMacchinaNoleggio.Size = new System.Drawing.Size(116, 29);
            this.chBxAggiungiMacchinaNoleggio.TabIndex = 44;
            this.chBxAggiungiMacchinaNoleggio.Text = "Noleggio";
            this.chBxAggiungiMacchinaNoleggio.UseVisualStyleBackColor = true;
            // 
            // txBxAggiungiMacchinaCodiceFiltro
            // 
            this.txBxAggiungiMacchinaCodiceFiltro.Location = new System.Drawing.Point(253, 322);
            this.txBxAggiungiMacchinaCodiceFiltro.Name = "txBxAggiungiMacchinaCodiceFiltro";
            this.txBxAggiungiMacchinaCodiceFiltro.Size = new System.Drawing.Size(201, 31);
            this.txBxAggiungiMacchinaCodiceFiltro.TabIndex = 43;
            // 
            // rtbAggiungiMacchinaNote
            // 
            this.rtbAggiungiMacchinaNote.Location = new System.Drawing.Point(33, 476);
            this.rtbAggiungiMacchinaNote.Name = "rtbAggiungiMacchinaNote";
            this.rtbAggiungiMacchinaNote.Size = new System.Drawing.Size(421, 96);
            this.rtbAggiungiMacchinaNote.TabIndex = 38;
            this.rtbAggiungiMacchinaNote.Text = "";
            // 
            // lblAggiungiMacchinaNote
            // 
            this.lblAggiungiMacchinaNote.AutoSize = true;
            this.lblAggiungiMacchinaNote.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblAggiungiMacchinaNote.Location = new System.Drawing.Point(27, 435);
            this.lblAggiungiMacchinaNote.Name = "lblAggiungiMacchinaNote";
            this.lblAggiungiMacchinaNote.Size = new System.Drawing.Size(63, 25);
            this.lblAggiungiMacchinaNote.TabIndex = 37;
            this.lblAggiungiMacchinaNote.Text = "Note:";
            // 
            // lblAggiungiMacchinaMatricola
            // 
            this.lblAggiungiMacchinaMatricola.AutoSize = true;
            this.lblAggiungiMacchinaMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiMacchinaMatricola.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiMacchinaMatricola.Location = new System.Drawing.Point(172, 165);
            this.lblAggiungiMacchinaMatricola.Name = "lblAggiungiMacchinaMatricola";
            this.lblAggiungiMacchinaMatricola.Size = new System.Drawing.Size(100, 25);
            this.lblAggiungiMacchinaMatricola.TabIndex = 35;
            this.lblAggiungiMacchinaMatricola.Text = "Matricola";
            // 
            // txBxAggiungiMacchinaMatricola
            // 
            this.txBxAggiungiMacchinaMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxAggiungiMacchinaMatricola.Location = new System.Drawing.Point(23, 204);
            this.txBxAggiungiMacchinaMatricola.Name = "txBxAggiungiMacchinaMatricola";
            this.txBxAggiungiMacchinaMatricola.Size = new System.Drawing.Size(421, 26);
            this.txBxAggiungiMacchinaMatricola.TabIndex = 34;
            // 
            // lblAggiungiMacchinaComponenti
            // 
            this.lblAggiungiMacchinaComponenti.AutoSize = true;
            this.lblAggiungiMacchinaComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiMacchinaComponenti.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiMacchinaComponenti.Location = new System.Drawing.Point(147, 278);
            this.lblAggiungiMacchinaComponenti.Name = "lblAggiungiMacchinaComponenti";
            this.lblAggiungiMacchinaComponenti.Size = new System.Drawing.Size(127, 25);
            this.lblAggiungiMacchinaComponenti.TabIndex = 33;
            this.lblAggiungiMacchinaComponenti.Text = "Componenti";
            // 
            // btnAggiungiMacchinaRimuoviComponenti
            // 
            this.btnAggiungiMacchinaRimuoviComponenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAggiungiMacchinaRimuoviComponenti.FlatAppearance.BorderSize = 0;
            this.btnAggiungiMacchinaRimuoviComponenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiMacchinaRimuoviComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiMacchinaRimuoviComponenti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAggiungiMacchinaRimuoviComponenti.Location = new System.Drawing.Point(33, 368);
            this.btnAggiungiMacchinaRimuoviComponenti.Name = "btnAggiungiMacchinaRimuoviComponenti";
            this.btnAggiungiMacchinaRimuoviComponenti.Size = new System.Drawing.Size(141, 40);
            this.btnAggiungiMacchinaRimuoviComponenti.TabIndex = 32;
            this.btnAggiungiMacchinaRimuoviComponenti.Text = "Rimuovi ";
            this.btnAggiungiMacchinaRimuoviComponenti.UseVisualStyleBackColor = false;
            this.btnAggiungiMacchinaRimuoviComponenti.Click += new System.EventHandler(this.btnAggiungiMacchinaRimuoviComponenti_Click);
            // 
            // lvAggiungiMacchinaFiltri
            // 
            this.lvAggiungiMacchinaFiltri.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvAggiungiMacchinaFiltri.BackColor = System.Drawing.Color.White;
            this.lvAggiungiMacchinaFiltri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader5});
            this.lvAggiungiMacchinaFiltri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAggiungiMacchinaFiltri.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lvAggiungiMacchinaFiltri.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAggiungiMacchinaFiltri.HideSelection = false;
            this.lvAggiungiMacchinaFiltri.HoverSelection = true;
            this.lvAggiungiMacchinaFiltri.Location = new System.Drawing.Point(180, 368);
            this.lvAggiungiMacchinaFiltri.Name = "lvAggiungiMacchinaFiltri";
            this.lvAggiungiMacchinaFiltri.Size = new System.Drawing.Size(274, 98);
            this.lvAggiungiMacchinaFiltri.TabIndex = 31;
            this.lvAggiungiMacchinaFiltri.UseCompatibleStateImageBehavior = false;
            this.lvAggiungiMacchinaFiltri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tipo";
            this.columnHeader9.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Codice";
            this.columnHeader5.Width = 145;
            // 
            // btnAggiungiMacchinaAggiungiComponenti
            // 
            this.btnAggiungiMacchinaAggiungiComponenti.BackColor = System.Drawing.Color.Teal;
            this.btnAggiungiMacchinaAggiungiComponenti.FlatAppearance.BorderSize = 0;
            this.btnAggiungiMacchinaAggiungiComponenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiMacchinaAggiungiComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiMacchinaAggiungiComponenti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAggiungiMacchinaAggiungiComponenti.Location = new System.Drawing.Point(33, 322);
            this.btnAggiungiMacchinaAggiungiComponenti.Name = "btnAggiungiMacchinaAggiungiComponenti";
            this.btnAggiungiMacchinaAggiungiComponenti.Size = new System.Drawing.Size(141, 41);
            this.btnAggiungiMacchinaAggiungiComponenti.TabIndex = 30;
            this.btnAggiungiMacchinaAggiungiComponenti.Text = "Aggiungi ";
            this.btnAggiungiMacchinaAggiungiComponenti.UseVisualStyleBackColor = false;
            this.btnAggiungiMacchinaAggiungiComponenti.Click += new System.EventHandler(this.btnAggiungiMacchinaAggiungiComponenti_Click);
            // 
            // lblAggiungiMacchinaModello
            // 
            this.lblAggiungiMacchinaModello.AutoSize = true;
            this.lblAggiungiMacchinaModello.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiMacchinaModello.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiMacchinaModello.Location = new System.Drawing.Point(172, 97);
            this.lblAggiungiMacchinaModello.Name = "lblAggiungiMacchinaModello";
            this.lblAggiungiMacchinaModello.Size = new System.Drawing.Size(88, 25);
            this.lblAggiungiMacchinaModello.TabIndex = 28;
            this.lblAggiungiMacchinaModello.Text = "Modello";
            // 
            // txBxAggiungiMacchinaModello
            // 
            this.txBxAggiungiMacchinaModello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxAggiungiMacchinaModello.Location = new System.Drawing.Point(23, 132);
            this.txBxAggiungiMacchinaModello.Name = "txBxAggiungiMacchinaModello";
            this.txBxAggiungiMacchinaModello.Size = new System.Drawing.Size(421, 26);
            this.txBxAggiungiMacchinaModello.TabIndex = 27;
            // 
            // btnChiudigBxAggiungiMacchine
            // 
            this.btnChiudigBxAggiungiMacchine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiudigBxAggiungiMacchine.BackColor = System.Drawing.Color.Red;
            this.btnChiudigBxAggiungiMacchine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiudigBxAggiungiMacchine.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnChiudigBxAggiungiMacchine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChiudigBxAggiungiMacchine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChiudigBxAggiungiMacchine.Location = new System.Drawing.Point(460, 14);
            this.btnChiudigBxAggiungiMacchine.Name = "btnChiudigBxAggiungiMacchine";
            this.btnChiudigBxAggiungiMacchine.Size = new System.Drawing.Size(25, 25);
            this.btnChiudigBxAggiungiMacchine.TabIndex = 24;
            this.btnChiudigBxAggiungiMacchine.Text = "X";
            this.btnChiudigBxAggiungiMacchine.UseVisualStyleBackColor = false;
            this.btnChiudigBxAggiungiMacchine.Click += new System.EventHandler(this.btnChiudigBxAggiungiMacchine_Click);
            // 
            // btnConfermaAggiungiMacchina
            // 
            this.btnConfermaAggiungiMacchina.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfermaAggiungiMacchina.FlatAppearance.BorderSize = 0;
            this.btnConfermaAggiungiMacchina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfermaAggiungiMacchina.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfermaAggiungiMacchina.Location = new System.Drawing.Point(0, 588);
            this.btnConfermaAggiungiMacchina.Name = "btnConfermaAggiungiMacchina";
            this.btnConfermaAggiungiMacchina.Size = new System.Drawing.Size(485, 56);
            this.btnConfermaAggiungiMacchina.TabIndex = 12;
            this.btnConfermaAggiungiMacchina.Text = "Aggiungi";
            this.btnConfermaAggiungiMacchina.UseVisualStyleBackColor = false;
            this.btnConfermaAggiungiMacchina.Click += new System.EventHandler(this.btnConfermaAggiungiMacchina_Click);
            // 
            // gBxModificaMacchina
            // 
            this.gBxModificaMacchina.Controls.Add(this.cBxModificaMacchinaTipo);
            this.gBxModificaMacchina.Controls.Add(this.lblModificaMacchinaMarca);
            this.gBxModificaMacchina.Controls.Add(this.tbxModificaMacchinaMarca);
            this.gBxModificaMacchina.Controls.Add(this.chBxModificaMacchinaNoleggio);
            this.gBxModificaMacchina.Controls.Add(this.txBxModificaMacchinaCodice);
            this.gBxModificaMacchina.Controls.Add(this.rtbModificaMacchinaNote);
            this.gBxModificaMacchina.Controls.Add(this.lblModificaMacchinaNote);
            this.gBxModificaMacchina.Controls.Add(this.lblModificaMacchinaMatricola);
            this.gBxModificaMacchina.Controls.Add(this.tbxModificaMacchinaMatricola);
            this.gBxModificaMacchina.Controls.Add(this.lblModificaMacchinaComponenti);
            this.gBxModificaMacchina.Controls.Add(this.btnModificaMacchinaRimuoviComponenti);
            this.gBxModificaMacchina.Controls.Add(this.lvwModificaComponentiMacchina);
            this.gBxModificaMacchina.Controls.Add(this.btnModificaMacchinaAggiungiComponenti);
            this.gBxModificaMacchina.Controls.Add(this.lblModificaMacchinaModello);
            this.gBxModificaMacchina.Controls.Add(this.tbxModificaMacchinaModello);
            this.gBxModificaMacchina.Controls.Add(this.btnChiudigBxModificaMacchina);
            this.gBxModificaMacchina.Controls.Add(this.btnConfermaModificaMacchina);
            this.gBxModificaMacchina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxModificaMacchina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBxModificaMacchina.Location = new System.Drawing.Point(257, 6);
            this.gBxModificaMacchina.Name = "gBxModificaMacchina";
            this.gBxModificaMacchina.Size = new System.Drawing.Size(485, 645);
            this.gBxModificaMacchina.TabIndex = 48;
            this.gBxModificaMacchina.TabStop = false;
            this.gBxModificaMacchina.Text = "Modifica macchina/accessorio";
            this.gBxModificaMacchina.Visible = false;
            // 
            // cBxModificaMacchinaTipo
            // 
            this.cBxModificaMacchinaTipo.FormattingEnabled = true;
            this.cBxModificaMacchinaTipo.Items.AddRange(new object[] {
            "Fa",
            "Fo",
            "Fi",
            "GA"});
            this.cBxModificaMacchinaTipo.Location = new System.Drawing.Point(180, 321);
            this.cBxModificaMacchinaTipo.Name = "cBxModificaMacchinaTipo";
            this.cBxModificaMacchinaTipo.Size = new System.Drawing.Size(67, 33);
            this.cBxModificaMacchinaTipo.TabIndex = 47;
            // 
            // lblModificaMacchinaMarca
            // 
            this.lblModificaMacchinaMarca.AutoSize = true;
            this.lblModificaMacchinaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaMacchinaMarca.ForeColor = System.Drawing.Color.White;
            this.lblModificaMacchinaMarca.Location = new System.Drawing.Point(172, 35);
            this.lblModificaMacchinaMarca.Name = "lblModificaMacchinaMarca";
            this.lblModificaMacchinaMarca.Size = new System.Drawing.Size(72, 25);
            this.lblModificaMacchinaMarca.TabIndex = 46;
            this.lblModificaMacchinaMarca.Text = "Marca";
            // 
            // tbxModificaMacchinaMarca
            // 
            this.tbxModificaMacchinaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModificaMacchinaMarca.Location = new System.Drawing.Point(23, 69);
            this.tbxModificaMacchinaMarca.Name = "tbxModificaMacchinaMarca";
            this.tbxModificaMacchinaMarca.Size = new System.Drawing.Size(421, 26);
            this.tbxModificaMacchinaMarca.TabIndex = 45;
            // 
            // chBxModificaMacchinaNoleggio
            // 
            this.chBxModificaMacchinaNoleggio.AutoSize = true;
            this.chBxModificaMacchinaNoleggio.Location = new System.Drawing.Point(153, 236);
            this.chBxModificaMacchinaNoleggio.Name = "chBxModificaMacchinaNoleggio";
            this.chBxModificaMacchinaNoleggio.Size = new System.Drawing.Size(116, 29);
            this.chBxModificaMacchinaNoleggio.TabIndex = 44;
            this.chBxModificaMacchinaNoleggio.Text = "Noleggio";
            this.chBxModificaMacchinaNoleggio.UseVisualStyleBackColor = true;
            // 
            // txBxModificaMacchinaCodice
            // 
            this.txBxModificaMacchinaCodice.Location = new System.Drawing.Point(253, 322);
            this.txBxModificaMacchinaCodice.Name = "txBxModificaMacchinaCodice";
            this.txBxModificaMacchinaCodice.Size = new System.Drawing.Size(201, 31);
            this.txBxModificaMacchinaCodice.TabIndex = 43;
            // 
            // rtbModificaMacchinaNote
            // 
            this.rtbModificaMacchinaNote.Location = new System.Drawing.Point(33, 476);
            this.rtbModificaMacchinaNote.Name = "rtbModificaMacchinaNote";
            this.rtbModificaMacchinaNote.Size = new System.Drawing.Size(421, 96);
            this.rtbModificaMacchinaNote.TabIndex = 38;
            this.rtbModificaMacchinaNote.Text = "";
            // 
            // lblModificaMacchinaNote
            // 
            this.lblModificaMacchinaNote.AutoSize = true;
            this.lblModificaMacchinaNote.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblModificaMacchinaNote.Location = new System.Drawing.Point(27, 435);
            this.lblModificaMacchinaNote.Name = "lblModificaMacchinaNote";
            this.lblModificaMacchinaNote.Size = new System.Drawing.Size(63, 25);
            this.lblModificaMacchinaNote.TabIndex = 37;
            this.lblModificaMacchinaNote.Text = "Note:";
            // 
            // lblModificaMacchinaMatricola
            // 
            this.lblModificaMacchinaMatricola.AutoSize = true;
            this.lblModificaMacchinaMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaMacchinaMatricola.ForeColor = System.Drawing.Color.White;
            this.lblModificaMacchinaMatricola.Location = new System.Drawing.Point(172, 165);
            this.lblModificaMacchinaMatricola.Name = "lblModificaMacchinaMatricola";
            this.lblModificaMacchinaMatricola.Size = new System.Drawing.Size(100, 25);
            this.lblModificaMacchinaMatricola.TabIndex = 35;
            this.lblModificaMacchinaMatricola.Text = "Matricola";
            // 
            // tbxModificaMacchinaMatricola
            // 
            this.tbxModificaMacchinaMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModificaMacchinaMatricola.Location = new System.Drawing.Point(23, 204);
            this.tbxModificaMacchinaMatricola.Name = "tbxModificaMacchinaMatricola";
            this.tbxModificaMacchinaMatricola.Size = new System.Drawing.Size(421, 26);
            this.tbxModificaMacchinaMatricola.TabIndex = 34;
            // 
            // lblModificaMacchinaComponenti
            // 
            this.lblModificaMacchinaComponenti.AutoSize = true;
            this.lblModificaMacchinaComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaMacchinaComponenti.ForeColor = System.Drawing.Color.White;
            this.lblModificaMacchinaComponenti.Location = new System.Drawing.Point(147, 278);
            this.lblModificaMacchinaComponenti.Name = "lblModificaMacchinaComponenti";
            this.lblModificaMacchinaComponenti.Size = new System.Drawing.Size(127, 25);
            this.lblModificaMacchinaComponenti.TabIndex = 33;
            this.lblModificaMacchinaComponenti.Text = "Componenti";
            // 
            // btnModificaMacchinaRimuoviComponenti
            // 
            this.btnModificaMacchinaRimuoviComponenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModificaMacchinaRimuoviComponenti.FlatAppearance.BorderSize = 0;
            this.btnModificaMacchinaRimuoviComponenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaMacchinaRimuoviComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaMacchinaRimuoviComponenti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificaMacchinaRimuoviComponenti.Location = new System.Drawing.Point(33, 368);
            this.btnModificaMacchinaRimuoviComponenti.Name = "btnModificaMacchinaRimuoviComponenti";
            this.btnModificaMacchinaRimuoviComponenti.Size = new System.Drawing.Size(141, 40);
            this.btnModificaMacchinaRimuoviComponenti.TabIndex = 32;
            this.btnModificaMacchinaRimuoviComponenti.Text = "Rimuovi ";
            this.btnModificaMacchinaRimuoviComponenti.UseVisualStyleBackColor = false;
            // 
            // lvwModificaComponentiMacchina
            // 
            this.lvwModificaComponentiMacchina.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwModificaComponentiMacchina.BackColor = System.Drawing.Color.White;
            this.lvwModificaComponentiMacchina.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16});
            this.lvwModificaComponentiMacchina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwModificaComponentiMacchina.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lvwModificaComponentiMacchina.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwModificaComponentiMacchina.HideSelection = false;
            this.lvwModificaComponentiMacchina.HoverSelection = true;
            this.lvwModificaComponentiMacchina.Location = new System.Drawing.Point(180, 368);
            this.lvwModificaComponentiMacchina.Name = "lvwModificaComponentiMacchina";
            this.lvwModificaComponentiMacchina.Size = new System.Drawing.Size(274, 98);
            this.lvwModificaComponentiMacchina.TabIndex = 31;
            this.lvwModificaComponentiMacchina.UseCompatibleStateImageBehavior = false;
            this.lvwModificaComponentiMacchina.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Tipo";
            this.columnHeader15.Width = 123;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Codice";
            this.columnHeader16.Width = 145;
            // 
            // btnModificaMacchinaAggiungiComponenti
            // 
            this.btnModificaMacchinaAggiungiComponenti.BackColor = System.Drawing.Color.Teal;
            this.btnModificaMacchinaAggiungiComponenti.FlatAppearance.BorderSize = 0;
            this.btnModificaMacchinaAggiungiComponenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaMacchinaAggiungiComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaMacchinaAggiungiComponenti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificaMacchinaAggiungiComponenti.Location = new System.Drawing.Point(33, 322);
            this.btnModificaMacchinaAggiungiComponenti.Name = "btnModificaMacchinaAggiungiComponenti";
            this.btnModificaMacchinaAggiungiComponenti.Size = new System.Drawing.Size(141, 41);
            this.btnModificaMacchinaAggiungiComponenti.TabIndex = 30;
            this.btnModificaMacchinaAggiungiComponenti.Text = "Aggiungi ";
            this.btnModificaMacchinaAggiungiComponenti.UseVisualStyleBackColor = false;
            this.btnModificaMacchinaAggiungiComponenti.Click += new System.EventHandler(this.btnModificaMacchinaAggiungiComponenti_Click);
            // 
            // lblModificaMacchinaModello
            // 
            this.lblModificaMacchinaModello.AutoSize = true;
            this.lblModificaMacchinaModello.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaMacchinaModello.ForeColor = System.Drawing.Color.White;
            this.lblModificaMacchinaModello.Location = new System.Drawing.Point(172, 97);
            this.lblModificaMacchinaModello.Name = "lblModificaMacchinaModello";
            this.lblModificaMacchinaModello.Size = new System.Drawing.Size(88, 25);
            this.lblModificaMacchinaModello.TabIndex = 28;
            this.lblModificaMacchinaModello.Text = "Modello";
            // 
            // tbxModificaMacchinaModello
            // 
            this.tbxModificaMacchinaModello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModificaMacchinaModello.Location = new System.Drawing.Point(23, 132);
            this.tbxModificaMacchinaModello.Name = "tbxModificaMacchinaModello";
            this.tbxModificaMacchinaModello.Size = new System.Drawing.Size(421, 26);
            this.tbxModificaMacchinaModello.TabIndex = 27;
            // 
            // btnChiudigBxModificaMacchina
            // 
            this.btnChiudigBxModificaMacchina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiudigBxModificaMacchina.BackColor = System.Drawing.Color.Red;
            this.btnChiudigBxModificaMacchina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiudigBxModificaMacchina.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnChiudigBxModificaMacchina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChiudigBxModificaMacchina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChiudigBxModificaMacchina.Location = new System.Drawing.Point(460, 11);
            this.btnChiudigBxModificaMacchina.Name = "btnChiudigBxModificaMacchina";
            this.btnChiudigBxModificaMacchina.Size = new System.Drawing.Size(25, 25);
            this.btnChiudigBxModificaMacchina.TabIndex = 24;
            this.btnChiudigBxModificaMacchina.Text = "X";
            this.btnChiudigBxModificaMacchina.UseVisualStyleBackColor = false;
            this.btnChiudigBxModificaMacchina.Click += new System.EventHandler(this.btnChiudigBxModificaMacchina_Click);
            // 
            // btnConfermaModificaMacchina
            // 
            this.btnConfermaModificaMacchina.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfermaModificaMacchina.FlatAppearance.BorderSize = 0;
            this.btnConfermaModificaMacchina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfermaModificaMacchina.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfermaModificaMacchina.Location = new System.Drawing.Point(0, 588);
            this.btnConfermaModificaMacchina.Name = "btnConfermaModificaMacchina";
            this.btnConfermaModificaMacchina.Size = new System.Drawing.Size(485, 56);
            this.btnConfermaModificaMacchina.TabIndex = 12;
            this.btnConfermaModificaMacchina.Text = "Modifica";
            this.btnConfermaModificaMacchina.UseVisualStyleBackColor = false;
            this.btnConfermaModificaMacchina.Click += new System.EventHandler(this.btnConfermaModificaMacchina_Click);
            // 
            // gBxClientiAggiungiCliente
            // 
            this.gBxClientiAggiungiCliente.Controls.Add(this.pnlAggiungiClienteButtonsMacchina);
            this.gBxClientiAggiungiCliente.Controls.Add(this.lblAggiungiClientiMacchineAccessori);
            this.gBxClientiAggiungiCliente.Controls.Add(this.lvwAggiungiClientiMacchine);
            this.gBxClientiAggiungiCliente.Controls.Add(this.lblAggiungiClientePrif);
            this.gBxClientiAggiungiCliente.Controls.Add(this.tbxAggiungiClientePrif);
            this.gBxClientiAggiungiCliente.Controls.Add(this.lblAggiungiClienteIVA);
            this.gBxClientiAggiungiCliente.Controls.Add(this.tbxAggiungiClienteIVA);
            this.gBxClientiAggiungiCliente.Controls.Add(this.lblAggiungiClienteInd);
            this.gBxClientiAggiungiCliente.Controls.Add(this.tbxAggiungiClienteInd);
            this.gBxClientiAggiungiCliente.Controls.Add(this.lblAggiungiClienteMail);
            this.gBxClientiAggiungiCliente.Controls.Add(this.tbxAggiungiClienteMail);
            this.gBxClientiAggiungiCliente.Controls.Add(this.lblAggiungiClienteTel);
            this.gBxClientiAggiungiCliente.Controls.Add(this.tbxAggiungiClienteTel);
            this.gBxClientiAggiungiCliente.Controls.Add(this.lblAggiungiClienteNome);
            this.gBxClientiAggiungiCliente.Controls.Add(this.tbxAggiungiClienteNome);
            this.gBxClientiAggiungiCliente.Controls.Add(this.btnAggiungiClienteChiudi);
            this.gBxClientiAggiungiCliente.Controls.Add(this.btnConfermaAggiungiCliente);
            this.gBxClientiAggiungiCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxClientiAggiungiCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBxClientiAggiungiCliente.Location = new System.Drawing.Point(1236, 26);
            this.gBxClientiAggiungiCliente.Name = "gBxClientiAggiungiCliente";
            this.gBxClientiAggiungiCliente.Size = new System.Drawing.Size(474, 636);
            this.gBxClientiAggiungiCliente.TabIndex = 14;
            this.gBxClientiAggiungiCliente.TabStop = false;
            this.gBxClientiAggiungiCliente.Text = "Aggiungi cliente";
            this.gBxClientiAggiungiCliente.Visible = false;
            // 
            // pnlAggiungiClienteButtonsMacchina
            // 
            this.pnlAggiungiClienteButtonsMacchina.BackColor = System.Drawing.Color.DimGray;
            this.pnlAggiungiClienteButtonsMacchina.Controls.Add(this.btnAggiungiAggiungiMacchina);
            this.pnlAggiungiClienteButtonsMacchina.Controls.Add(this.btnAggiungiModificaMacchina);
            this.pnlAggiungiClienteButtonsMacchina.Controls.Add(this.btnAggiungiEliminaMacchina);
            this.pnlAggiungiClienteButtonsMacchina.Location = new System.Drawing.Point(25, 319);
            this.pnlAggiungiClienteButtonsMacchina.Name = "pnlAggiungiClienteButtonsMacchina";
            this.pnlAggiungiClienteButtonsMacchina.Size = new System.Drawing.Size(236, 76);
            this.pnlAggiungiClienteButtonsMacchina.TabIndex = 42;
            // 
            // btnAggiungiAggiungiMacchina
            // 
            this.btnAggiungiAggiungiMacchina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungiAggiungiMacchina.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAggiungiAggiungiMacchina.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.aircompressoradd_icon;
            this.btnAggiungiAggiungiMacchina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAggiungiAggiungiMacchina.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAggiungiAggiungiMacchina.FlatAppearance.BorderSize = 3;
            this.btnAggiungiAggiungiMacchina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiAggiungiMacchina.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiAggiungiMacchina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAggiungiAggiungiMacchina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAggiungiAggiungiMacchina.Location = new System.Drawing.Point(12, 13);
            this.btnAggiungiAggiungiMacchina.Name = "btnAggiungiAggiungiMacchina";
            this.btnAggiungiAggiungiMacchina.Size = new System.Drawing.Size(64, 51);
            this.btnAggiungiAggiungiMacchina.TabIndex = 4;
            this.btnAggiungiAggiungiMacchina.UseVisualStyleBackColor = false;
            this.btnAggiungiAggiungiMacchina.Click += new System.EventHandler(this.btnAggiungiAggiungiMacchina_Click);
            // 
            // btnAggiungiModificaMacchina
            // 
            this.btnAggiungiModificaMacchina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungiModificaMacchina.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAggiungiModificaMacchina.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.aircompressoredit_icon;
            this.btnAggiungiModificaMacchina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAggiungiModificaMacchina.Enabled = false;
            this.btnAggiungiModificaMacchina.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnAggiungiModificaMacchina.FlatAppearance.BorderSize = 3;
            this.btnAggiungiModificaMacchina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiModificaMacchina.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnAggiungiModificaMacchina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAggiungiModificaMacchina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAggiungiModificaMacchina.Location = new System.Drawing.Point(82, 12);
            this.btnAggiungiModificaMacchina.Name = "btnAggiungiModificaMacchina";
            this.btnAggiungiModificaMacchina.Size = new System.Drawing.Size(68, 51);
            this.btnAggiungiModificaMacchina.TabIndex = 5;
            this.btnAggiungiModificaMacchina.UseVisualStyleBackColor = false;
            this.btnAggiungiModificaMacchina.Click += new System.EventHandler(this.btnAggiungiModificaMacchina_Click);
            // 
            // btnAggiungiEliminaMacchina
            // 
            this.btnAggiungiEliminaMacchina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungiEliminaMacchina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAggiungiEliminaMacchina.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.aircompressordelete_icon;
            this.btnAggiungiEliminaMacchina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAggiungiEliminaMacchina.Enabled = false;
            this.btnAggiungiEliminaMacchina.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAggiungiEliminaMacchina.FlatAppearance.BorderSize = 3;
            this.btnAggiungiEliminaMacchina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiEliminaMacchina.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnAggiungiEliminaMacchina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAggiungiEliminaMacchina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAggiungiEliminaMacchina.Location = new System.Drawing.Point(156, 13);
            this.btnAggiungiEliminaMacchina.Name = "btnAggiungiEliminaMacchina";
            this.btnAggiungiEliminaMacchina.Size = new System.Drawing.Size(61, 50);
            this.btnAggiungiEliminaMacchina.TabIndex = 6;
            this.btnAggiungiEliminaMacchina.UseVisualStyleBackColor = false;
            this.btnAggiungiEliminaMacchina.Click += new System.EventHandler(this.btnAggiungiEliminaMacchina_Click);
            // 
            // lblAggiungiClientiMacchineAccessori
            // 
            this.lblAggiungiClientiMacchineAccessori.AutoSize = true;
            this.lblAggiungiClientiMacchineAccessori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiClientiMacchineAccessori.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiClientiMacchineAccessori.Location = new System.Drawing.Point(19, 280);
            this.lblAggiungiClientiMacchineAccessori.Name = "lblAggiungiClientiMacchineAccessori";
            this.lblAggiungiClientiMacchineAccessori.Size = new System.Drawing.Size(209, 25);
            this.lblAggiungiClientiMacchineAccessori.TabIndex = 41;
            this.lblAggiungiClientiMacchineAccessori.Text = "Macchine/accessori:";
            // 
            // lvwAggiungiClientiMacchine
            // 
            this.lvwAggiungiClientiMacchine.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwAggiungiClientiMacchine.BackColor = System.Drawing.Color.White;
            this.lvwAggiungiClientiMacchine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.lvwAggiungiClientiMacchine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAggiungiClientiMacchine.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lvwAggiungiClientiMacchine.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwAggiungiClientiMacchine.HideSelection = false;
            this.lvwAggiungiClientiMacchine.HoverSelection = true;
            this.lvwAggiungiClientiMacchine.Location = new System.Drawing.Point(25, 407);
            this.lvwAggiungiClientiMacchine.MultiSelect = false;
            this.lvwAggiungiClientiMacchine.Name = "lvwAggiungiClientiMacchine";
            this.lvwAggiungiClientiMacchine.Size = new System.Drawing.Size(421, 167);
            this.lvwAggiungiClientiMacchine.TabIndex = 39;
            this.lvwAggiungiClientiMacchine.UseCompatibleStateImageBehavior = false;
            this.lvwAggiungiClientiMacchine.View = System.Windows.Forms.View.Details;
            this.lvwAggiungiClientiMacchine.SelectedIndexChanged += new System.EventHandler(this.lvwAggiungiClientiMacchine_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marca";
            this.columnHeader3.Width = 147;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Modello";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Matricola";
            this.columnHeader6.Width = 138;
            // 
            // lblAggiungiClientePrif
            // 
            this.lblAggiungiClientePrif.AutoSize = true;
            this.lblAggiungiClientePrif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiClientePrif.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiClientePrif.Location = new System.Drawing.Point(19, 228);
            this.lblAggiungiClientePrif.Name = "lblAggiungiClientePrif";
            this.lblAggiungiClientePrif.Size = new System.Drawing.Size(64, 25);
            this.lblAggiungiClientePrif.TabIndex = 36;
            this.lblAggiungiClientePrif.Text = "P.Rif:";
            // 
            // tbxAggiungiClientePrif
            // 
            this.tbxAggiungiClientePrif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAggiungiClientePrif.Location = new System.Drawing.Point(111, 228);
            this.tbxAggiungiClientePrif.Name = "tbxAggiungiClientePrif";
            this.tbxAggiungiClientePrif.Size = new System.Drawing.Size(335, 26);
            this.tbxAggiungiClientePrif.TabIndex = 35;
            // 
            // lblAggiungiClienteIVA
            // 
            this.lblAggiungiClienteIVA.AutoSize = true;
            this.lblAggiungiClienteIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiClienteIVA.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiClienteIVA.Location = new System.Drawing.Point(19, 193);
            this.lblAggiungiClienteIVA.Name = "lblAggiungiClienteIVA";
            this.lblAggiungiClienteIVA.Size = new System.Drawing.Size(57, 25);
            this.lblAggiungiClienteIVA.TabIndex = 34;
            this.lblAggiungiClienteIVA.Text = " IVA:";
            // 
            // tbxAggiungiClienteIVA
            // 
            this.tbxAggiungiClienteIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAggiungiClienteIVA.Location = new System.Drawing.Point(111, 192);
            this.tbxAggiungiClienteIVA.Name = "tbxAggiungiClienteIVA";
            this.tbxAggiungiClienteIVA.Size = new System.Drawing.Size(335, 26);
            this.tbxAggiungiClienteIVA.TabIndex = 33;
            // 
            // lblAggiungiClienteInd
            // 
            this.lblAggiungiClienteInd.AutoSize = true;
            this.lblAggiungiClienteInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiClienteInd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAggiungiClienteInd.Location = new System.Drawing.Point(19, 156);
            this.lblAggiungiClienteInd.Name = "lblAggiungiClienteInd";
            this.lblAggiungiClienteInd.Size = new System.Drawing.Size(47, 25);
            this.lblAggiungiClienteInd.TabIndex = 32;
            this.lblAggiungiClienteInd.Text = "Ind:";
            // 
            // tbxAggiungiClienteInd
            // 
            this.tbxAggiungiClienteInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAggiungiClienteInd.Location = new System.Drawing.Point(111, 156);
            this.tbxAggiungiClienteInd.Name = "tbxAggiungiClienteInd";
            this.tbxAggiungiClienteInd.Size = new System.Drawing.Size(335, 26);
            this.tbxAggiungiClienteInd.TabIndex = 31;
            // 
            // lblAggiungiClienteMail
            // 
            this.lblAggiungiClienteMail.AutoSize = true;
            this.lblAggiungiClienteMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiClienteMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAggiungiClienteMail.Location = new System.Drawing.Point(19, 118);
            this.lblAggiungiClienteMail.Name = "lblAggiungiClienteMail";
            this.lblAggiungiClienteMail.Size = new System.Drawing.Size(58, 25);
            this.lblAggiungiClienteMail.TabIndex = 30;
            this.lblAggiungiClienteMail.Text = "Mail:";
            // 
            // tbxAggiungiClienteMail
            // 
            this.tbxAggiungiClienteMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAggiungiClienteMail.Location = new System.Drawing.Point(111, 120);
            this.tbxAggiungiClienteMail.Name = "tbxAggiungiClienteMail";
            this.tbxAggiungiClienteMail.Size = new System.Drawing.Size(335, 26);
            this.tbxAggiungiClienteMail.TabIndex = 29;
            // 
            // lblAggiungiClienteTel
            // 
            this.lblAggiungiClienteTel.AutoSize = true;
            this.lblAggiungiClienteTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiClienteTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAggiungiClienteTel.Location = new System.Drawing.Point(19, 88);
            this.lblAggiungiClienteTel.Name = "lblAggiungiClienteTel";
            this.lblAggiungiClienteTel.Size = new System.Drawing.Size(48, 25);
            this.lblAggiungiClienteTel.TabIndex = 28;
            this.lblAggiungiClienteTel.Text = "Tel:";
            // 
            // tbxAggiungiClienteTel
            // 
            this.tbxAggiungiClienteTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAggiungiClienteTel.Location = new System.Drawing.Point(111, 84);
            this.tbxAggiungiClienteTel.Name = "tbxAggiungiClienteTel";
            this.tbxAggiungiClienteTel.Size = new System.Drawing.Size(335, 26);
            this.tbxAggiungiClienteTel.TabIndex = 27;
            // 
            // lblAggiungiClienteNome
            // 
            this.lblAggiungiClienteNome.AutoSize = true;
            this.lblAggiungiClienteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiClienteNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAggiungiClienteNome.Location = new System.Drawing.Point(19, 48);
            this.lblAggiungiClienteNome.Name = "lblAggiungiClienteNome";
            this.lblAggiungiClienteNome.Size = new System.Drawing.Size(74, 25);
            this.lblAggiungiClienteNome.TabIndex = 26;
            this.lblAggiungiClienteNome.Text = "Nome:";
            // 
            // tbxAggiungiClienteNome
            // 
            this.tbxAggiungiClienteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAggiungiClienteNome.Location = new System.Drawing.Point(111, 49);
            this.tbxAggiungiClienteNome.Name = "tbxAggiungiClienteNome";
            this.tbxAggiungiClienteNome.Size = new System.Drawing.Size(335, 26);
            this.tbxAggiungiClienteNome.TabIndex = 25;
            // 
            // btnAggiungiClienteChiudi
            // 
            this.btnAggiungiClienteChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungiClienteChiudi.BackColor = System.Drawing.Color.Red;
            this.btnAggiungiClienteChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiClienteChiudi.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAggiungiClienteChiudi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAggiungiClienteChiudi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAggiungiClienteChiudi.Location = new System.Drawing.Point(449, 14);
            this.btnAggiungiClienteChiudi.Name = "btnAggiungiClienteChiudi";
            this.btnAggiungiClienteChiudi.Size = new System.Drawing.Size(25, 25);
            this.btnAggiungiClienteChiudi.TabIndex = 24;
            this.btnAggiungiClienteChiudi.Text = "X";
            this.btnAggiungiClienteChiudi.UseVisualStyleBackColor = false;
            this.btnAggiungiClienteChiudi.Click += new System.EventHandler(this.btnAggiungiClienteChiudi_Click);
            // 
            // btnConfermaAggiungiCliente
            // 
            this.btnConfermaAggiungiCliente.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfermaAggiungiCliente.FlatAppearance.BorderSize = 0;
            this.btnConfermaAggiungiCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfermaAggiungiCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfermaAggiungiCliente.Location = new System.Drawing.Point(0, 580);
            this.btnConfermaAggiungiCliente.Name = "btnConfermaAggiungiCliente";
            this.btnConfermaAggiungiCliente.Size = new System.Drawing.Size(474, 56);
            this.btnConfermaAggiungiCliente.TabIndex = 12;
            this.btnConfermaAggiungiCliente.Text = "Aggiungi";
            this.btnConfermaAggiungiCliente.UseVisualStyleBackColor = false;
            this.btnConfermaAggiungiCliente.Click += new System.EventHandler(this.btnConfermaAggiungiCliente_Click);
            // 
            // gBxClientiModificaClienti
            // 
            this.gBxClientiModificaClienti.Controls.Add(this.dgvModificaCliente);
            this.gBxClientiModificaClienti.Controls.Add(this.pnlModificaClienteMacchine);
            this.gBxClientiModificaClienti.Controls.Add(this.lblModificaClienteMacchinaAccessori);
            this.gBxClientiModificaClienti.Controls.Add(this.lblModificaClientePrif);
            this.gBxClientiModificaClienti.Controls.Add(this.txBxModificaClientePrif);
            this.gBxClientiModificaClienti.Controls.Add(this.lblModificaClienteIva);
            this.gBxClientiModificaClienti.Controls.Add(this.txBxModificaClienteIva);
            this.gBxClientiModificaClienti.Controls.Add(this.lblModificaClienteInd);
            this.gBxClientiModificaClienti.Controls.Add(this.txBxModificaClienteInd);
            this.gBxClientiModificaClienti.Controls.Add(this.lblModificaClienteMail);
            this.gBxClientiModificaClienti.Controls.Add(this.txBxModificaClienteMail);
            this.gBxClientiModificaClienti.Controls.Add(this.lblModificaClienteTel);
            this.gBxClientiModificaClienti.Controls.Add(this.txBxModificaClienteTel);
            this.gBxClientiModificaClienti.Controls.Add(this.lblModificaClienteNome);
            this.gBxClientiModificaClienti.Controls.Add(this.txBxModificaClienteNome);
            this.gBxClientiModificaClienti.Controls.Add(this.btnModificaClienteChiudi);
            this.gBxClientiModificaClienti.Controls.Add(this.btnConfermaModificaCliente);
            this.gBxClientiModificaClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxClientiModificaClienti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBxClientiModificaClienti.Location = new System.Drawing.Point(754, 3);
            this.gBxClientiModificaClienti.Name = "gBxClientiModificaClienti";
            this.gBxClientiModificaClienti.Size = new System.Drawing.Size(455, 636);
            this.gBxClientiModificaClienti.TabIndex = 24;
            this.gBxClientiModificaClienti.TabStop = false;
            this.gBxClientiModificaClienti.Text = "Modifica cliente:";
            this.gBxClientiModificaClienti.Visible = false;
            // 
            // pnlModificaClienteMacchine
            // 
            this.pnlModificaClienteMacchine.BackColor = System.Drawing.Color.DimGray;
            this.pnlModificaClienteMacchine.Controls.Add(this.btnModificaAggiungiMacchina);
            this.pnlModificaClienteMacchine.Controls.Add(this.btnModificaModificaMacchina);
            this.pnlModificaClienteMacchine.Controls.Add(this.btnModificaEliminaMacchina);
            this.pnlModificaClienteMacchine.Location = new System.Drawing.Point(23, 305);
            this.pnlModificaClienteMacchine.Name = "pnlModificaClienteMacchine";
            this.pnlModificaClienteMacchine.Size = new System.Drawing.Size(236, 76);
            this.pnlModificaClienteMacchine.TabIndex = 57;
            // 
            // btnModificaAggiungiMacchina
            // 
            this.btnModificaAggiungiMacchina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificaAggiungiMacchina.BackColor = System.Drawing.Color.LimeGreen;
            this.btnModificaAggiungiMacchina.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.aircompressoradd_icon;
            this.btnModificaAggiungiMacchina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificaAggiungiMacchina.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnModificaAggiungiMacchina.FlatAppearance.BorderSize = 3;
            this.btnModificaAggiungiMacchina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaAggiungiMacchina.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaAggiungiMacchina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificaAggiungiMacchina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificaAggiungiMacchina.Location = new System.Drawing.Point(12, 13);
            this.btnModificaAggiungiMacchina.Name = "btnModificaAggiungiMacchina";
            this.btnModificaAggiungiMacchina.Size = new System.Drawing.Size(64, 51);
            this.btnModificaAggiungiMacchina.TabIndex = 4;
            this.btnModificaAggiungiMacchina.UseVisualStyleBackColor = false;
            this.btnModificaAggiungiMacchina.Click += new System.EventHandler(this.btnModificaAggiungiMacchina_Click);
            // 
            // btnModificaModificaMacchina
            // 
            this.btnModificaModificaMacchina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificaModificaMacchina.BackColor = System.Drawing.Color.Goldenrod;
            this.btnModificaModificaMacchina.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.aircompressoredit_icon;
            this.btnModificaModificaMacchina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificaModificaMacchina.Enabled = false;
            this.btnModificaModificaMacchina.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnModificaModificaMacchina.FlatAppearance.BorderSize = 3;
            this.btnModificaModificaMacchina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaModificaMacchina.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnModificaModificaMacchina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificaModificaMacchina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificaModificaMacchina.Location = new System.Drawing.Point(82, 12);
            this.btnModificaModificaMacchina.Name = "btnModificaModificaMacchina";
            this.btnModificaModificaMacchina.Size = new System.Drawing.Size(68, 51);
            this.btnModificaModificaMacchina.TabIndex = 5;
            this.btnModificaModificaMacchina.UseVisualStyleBackColor = false;
            this.btnModificaModificaMacchina.Click += new System.EventHandler(this.btnModificaModificaMacchina_Click);
            // 
            // btnModificaEliminaMacchina
            // 
            this.btnModificaEliminaMacchina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificaEliminaMacchina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModificaEliminaMacchina.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.aircompressordelete_icon;
            this.btnModificaEliminaMacchina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificaEliminaMacchina.Enabled = false;
            this.btnModificaEliminaMacchina.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModificaEliminaMacchina.FlatAppearance.BorderSize = 3;
            this.btnModificaEliminaMacchina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaEliminaMacchina.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnModificaEliminaMacchina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificaEliminaMacchina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificaEliminaMacchina.Location = new System.Drawing.Point(156, 13);
            this.btnModificaEliminaMacchina.Name = "btnModificaEliminaMacchina";
            this.btnModificaEliminaMacchina.Size = new System.Drawing.Size(61, 50);
            this.btnModificaEliminaMacchina.TabIndex = 6;
            this.btnModificaEliminaMacchina.UseVisualStyleBackColor = false;
            this.btnModificaEliminaMacchina.Click += new System.EventHandler(this.btnModificaEliminaMacchina_Click);
            // 
            // lblModificaClienteMacchinaAccessori
            // 
            this.lblModificaClienteMacchinaAccessori.AutoSize = true;
            this.lblModificaClienteMacchinaAccessori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaClienteMacchinaAccessori.ForeColor = System.Drawing.Color.White;
            this.lblModificaClienteMacchinaAccessori.Location = new System.Drawing.Point(17, 271);
            this.lblModificaClienteMacchinaAccessori.Name = "lblModificaClienteMacchinaAccessori";
            this.lblModificaClienteMacchinaAccessori.Size = new System.Drawing.Size(209, 25);
            this.lblModificaClienteMacchinaAccessori.TabIndex = 56;
            this.lblModificaClienteMacchinaAccessori.Text = "Macchine/accessori:";
            // 
            // lblModificaClientePrif
            // 
            this.lblModificaClientePrif.AutoSize = true;
            this.lblModificaClientePrif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaClientePrif.ForeColor = System.Drawing.Color.White;
            this.lblModificaClientePrif.Location = new System.Drawing.Point(17, 219);
            this.lblModificaClientePrif.Name = "lblModificaClientePrif";
            this.lblModificaClientePrif.Size = new System.Drawing.Size(64, 25);
            this.lblModificaClientePrif.TabIndex = 54;
            this.lblModificaClientePrif.Text = "P.Rif:";
            // 
            // txBxModificaClientePrif
            // 
            this.txBxModificaClientePrif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxModificaClientePrif.Location = new System.Drawing.Point(109, 219);
            this.txBxModificaClientePrif.Name = "txBxModificaClientePrif";
            this.txBxModificaClientePrif.Size = new System.Drawing.Size(335, 26);
            this.txBxModificaClientePrif.TabIndex = 53;
            // 
            // lblModificaClienteIva
            // 
            this.lblModificaClienteIva.AutoSize = true;
            this.lblModificaClienteIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaClienteIva.ForeColor = System.Drawing.Color.White;
            this.lblModificaClienteIva.Location = new System.Drawing.Point(17, 184);
            this.lblModificaClienteIva.Name = "lblModificaClienteIva";
            this.lblModificaClienteIva.Size = new System.Drawing.Size(57, 25);
            this.lblModificaClienteIva.TabIndex = 52;
            this.lblModificaClienteIva.Text = " IVA:";
            // 
            // txBxModificaClienteIva
            // 
            this.txBxModificaClienteIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxModificaClienteIva.Location = new System.Drawing.Point(109, 183);
            this.txBxModificaClienteIva.Name = "txBxModificaClienteIva";
            this.txBxModificaClienteIva.Size = new System.Drawing.Size(335, 26);
            this.txBxModificaClienteIva.TabIndex = 51;
            // 
            // lblModificaClienteInd
            // 
            this.lblModificaClienteInd.AutoSize = true;
            this.lblModificaClienteInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaClienteInd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblModificaClienteInd.Location = new System.Drawing.Point(17, 147);
            this.lblModificaClienteInd.Name = "lblModificaClienteInd";
            this.lblModificaClienteInd.Size = new System.Drawing.Size(47, 25);
            this.lblModificaClienteInd.TabIndex = 50;
            this.lblModificaClienteInd.Text = "Ind:";
            // 
            // txBxModificaClienteInd
            // 
            this.txBxModificaClienteInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxModificaClienteInd.Location = new System.Drawing.Point(109, 147);
            this.txBxModificaClienteInd.Name = "txBxModificaClienteInd";
            this.txBxModificaClienteInd.Size = new System.Drawing.Size(335, 26);
            this.txBxModificaClienteInd.TabIndex = 49;
            // 
            // lblModificaClienteMail
            // 
            this.lblModificaClienteMail.AutoSize = true;
            this.lblModificaClienteMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaClienteMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblModificaClienteMail.Location = new System.Drawing.Point(17, 109);
            this.lblModificaClienteMail.Name = "lblModificaClienteMail";
            this.lblModificaClienteMail.Size = new System.Drawing.Size(58, 25);
            this.lblModificaClienteMail.TabIndex = 48;
            this.lblModificaClienteMail.Text = "Mail:";
            // 
            // txBxModificaClienteMail
            // 
            this.txBxModificaClienteMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxModificaClienteMail.Location = new System.Drawing.Point(109, 111);
            this.txBxModificaClienteMail.Name = "txBxModificaClienteMail";
            this.txBxModificaClienteMail.Size = new System.Drawing.Size(335, 26);
            this.txBxModificaClienteMail.TabIndex = 47;
            // 
            // lblModificaClienteTel
            // 
            this.lblModificaClienteTel.AutoSize = true;
            this.lblModificaClienteTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaClienteTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblModificaClienteTel.Location = new System.Drawing.Point(17, 79);
            this.lblModificaClienteTel.Name = "lblModificaClienteTel";
            this.lblModificaClienteTel.Size = new System.Drawing.Size(48, 25);
            this.lblModificaClienteTel.TabIndex = 46;
            this.lblModificaClienteTel.Text = "Tel:";
            // 
            // txBxModificaClienteTel
            // 
            this.txBxModificaClienteTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxModificaClienteTel.Location = new System.Drawing.Point(109, 75);
            this.txBxModificaClienteTel.Name = "txBxModificaClienteTel";
            this.txBxModificaClienteTel.Size = new System.Drawing.Size(335, 26);
            this.txBxModificaClienteTel.TabIndex = 45;
            // 
            // lblModificaClienteNome
            // 
            this.lblModificaClienteNome.AutoSize = true;
            this.lblModificaClienteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaClienteNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblModificaClienteNome.Location = new System.Drawing.Point(17, 39);
            this.lblModificaClienteNome.Name = "lblModificaClienteNome";
            this.lblModificaClienteNome.Size = new System.Drawing.Size(74, 25);
            this.lblModificaClienteNome.TabIndex = 44;
            this.lblModificaClienteNome.Text = "Nome:";
            // 
            // txBxModificaClienteNome
            // 
            this.txBxModificaClienteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxModificaClienteNome.Location = new System.Drawing.Point(109, 40);
            this.txBxModificaClienteNome.Name = "txBxModificaClienteNome";
            this.txBxModificaClienteNome.Size = new System.Drawing.Size(335, 26);
            this.txBxModificaClienteNome.TabIndex = 43;
            // 
            // btnModificaClienteChiudi
            // 
            this.btnModificaClienteChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificaClienteChiudi.BackColor = System.Drawing.Color.Red;
            this.btnModificaClienteChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaClienteChiudi.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnModificaClienteChiudi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificaClienteChiudi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificaClienteChiudi.Location = new System.Drawing.Point(430, 14);
            this.btnModificaClienteChiudi.Name = "btnModificaClienteChiudi";
            this.btnModificaClienteChiudi.Size = new System.Drawing.Size(25, 25);
            this.btnModificaClienteChiudi.TabIndex = 24;
            this.btnModificaClienteChiudi.Text = "X";
            this.btnModificaClienteChiudi.UseVisualStyleBackColor = false;
            this.btnModificaClienteChiudi.Click += new System.EventHandler(this.btnModificaClienteChiudi_Click);
            // 
            // btnConfermaModificaCliente
            // 
            this.btnConfermaModificaCliente.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConfermaModificaCliente.FlatAppearance.BorderSize = 0;
            this.btnConfermaModificaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfermaModificaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfermaModificaCliente.Location = new System.Drawing.Point(0, 580);
            this.btnConfermaModificaCliente.Name = "btnConfermaModificaCliente";
            this.btnConfermaModificaCliente.Size = new System.Drawing.Size(474, 56);
            this.btnConfermaModificaCliente.TabIndex = 12;
            this.btnConfermaModificaCliente.Text = "Modifica";
            this.btnConfermaModificaCliente.UseVisualStyleBackColor = false;
            this.btnConfermaModificaCliente.Click += new System.EventHandler(this.btnConfermaModificaCliente_Click);
            // 
            // lblClienti
            // 
            this.lblClienti.AutoSize = true;
            this.lblClienti.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClienti.Location = new System.Drawing.Point(608, 17);
            this.lblClienti.Name = "lblClienti";
            this.lblClienti.Size = new System.Drawing.Size(37, 13);
            this.lblClienti.TabIndex = 49;
            this.lblClienti.Text = "label1";
            // 
            // gBxVisualizzaCliente
            // 
            this.gBxVisualizzaCliente.Controls.Add(this.lblMostraComponenti);
            this.gBxVisualizzaCliente.Controls.Add(this.lvwMostraComponenti);
            this.gBxVisualizzaCliente.Controls.Add(this.chbxMostraNoleggio);
            this.gBxVisualizzaCliente.Controls.Add(this.rtbMostraNote);
            this.gBxVisualizzaCliente.Controls.Add(this.pbxAlloStoricoMacchina);
            this.gBxVisualizzaCliente.Controls.Add(this.lblMostraNote);
            this.gBxVisualizzaCliente.Controls.Add(this.pbxAlloStoricoCliente);
            this.gBxVisualizzaCliente.Controls.Add(this.lblMostraMacchineAccessori);
            this.gBxVisualizzaCliente.Controls.Add(this.lvwMostraMacchineAccessori);
            this.gBxVisualizzaCliente.Controls.Add(this.lblMostraPrif);
            this.gBxVisualizzaCliente.Controls.Add(this.tbxMostraPrif);
            this.gBxVisualizzaCliente.Controls.Add(this.lblMostraIva);
            this.gBxVisualizzaCliente.Controls.Add(this.tbxMostraIva);
            this.gBxVisualizzaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxVisualizzaCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBxVisualizzaCliente.Location = new System.Drawing.Point(1356, 233);
            this.gBxVisualizzaCliente.Name = "gBxVisualizzaCliente";
            this.gBxVisualizzaCliente.Size = new System.Drawing.Size(474, 636);
            this.gBxVisualizzaCliente.TabIndex = 42;
            this.gBxVisualizzaCliente.TabStop = false;
            this.gBxVisualizzaCliente.Text = "Dettagli cliente";
            // 
            // lblMostraComponenti
            // 
            this.lblMostraComponenti.AutoSize = true;
            this.lblMostraComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraComponenti.ForeColor = System.Drawing.Color.White;
            this.lblMostraComponenti.Location = new System.Drawing.Point(233, 468);
            this.lblMostraComponenti.Name = "lblMostraComponenti";
            this.lblMostraComponenti.Size = new System.Drawing.Size(127, 25);
            this.lblMostraComponenti.TabIndex = 48;
            this.lblMostraComponenti.Text = "Componenti";
            // 
            // lvwMostraComponenti
            // 
            this.lvwMostraComponenti.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwMostraComponenti.BackColor = System.Drawing.Color.White;
            this.lvwMostraComponenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13});
            this.lvwMostraComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMostraComponenti.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lvwMostraComponenti.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwMostraComponenti.HideSelection = false;
            this.lvwMostraComponenti.HoverSelection = true;
            this.lvwMostraComponenti.Location = new System.Drawing.Point(158, 496);
            this.lvwMostraComponenti.Name = "lvwMostraComponenti";
            this.lvwMostraComponenti.Size = new System.Drawing.Size(297, 113);
            this.lvwMostraComponenti.TabIndex = 48;
            this.lvwMostraComponenti.UseCompatibleStateImageBehavior = false;
            this.lvwMostraComponenti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tipo";
            this.columnHeader12.Width = 123;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Codice";
            this.columnHeader13.Width = 145;
            // 
            // chbxMostraNoleggio
            // 
            this.chbxMostraNoleggio.AutoCheck = false;
            this.chbxMostraNoleggio.AutoSize = true;
            this.chbxMostraNoleggio.Location = new System.Drawing.Point(14, 575);
            this.chbxMostraNoleggio.Name = "chbxMostraNoleggio";
            this.chbxMostraNoleggio.Size = new System.Drawing.Size(116, 29);
            this.chbxMostraNoleggio.TabIndex = 50;
            this.chbxMostraNoleggio.Text = "Noleggio";
            this.chbxMostraNoleggio.UseVisualStyleBackColor = true;
            // 
            // rtbMostraNote
            // 
            this.rtbMostraNote.Location = new System.Drawing.Point(14, 468);
            this.rtbMostraNote.Name = "rtbMostraNote";
            this.rtbMostraNote.ReadOnly = true;
            this.rtbMostraNote.Size = new System.Drawing.Size(138, 114);
            this.rtbMostraNote.TabIndex = 49;
            this.rtbMostraNote.Text = "";
            // 
            // pbxAlloStoricoMacchina
            // 
            this.pbxAlloStoricoMacchina.BackColor = System.Drawing.Color.White;
            this.pbxAlloStoricoMacchina.ErrorImage = null;
            this.pbxAlloStoricoMacchina.Image = global::Calendario_AriBerg.Properties.Resources.Logo_AriGenda;
            this.pbxAlloStoricoMacchina.Location = new System.Drawing.Point(24, 146);
            this.pbxAlloStoricoMacchina.Name = "pbxAlloStoricoMacchina";
            this.pbxAlloStoricoMacchina.Size = new System.Drawing.Size(57, 48);
            this.pbxAlloStoricoMacchina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAlloStoricoMacchina.TabIndex = 43;
            this.pbxAlloStoricoMacchina.TabStop = false;
            this.pbxAlloStoricoMacchina.Click += new System.EventHandler(this.pbxAlloStoricoMacchina_Click);
            // 
            // lblMostraNote
            // 
            this.lblMostraNote.AutoSize = true;
            this.lblMostraNote.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMostraNote.Location = new System.Drawing.Point(51, 442);
            this.lblMostraNote.Name = "lblMostraNote";
            this.lblMostraNote.Size = new System.Drawing.Size(63, 25);
            this.lblMostraNote.TabIndex = 48;
            this.lblMostraNote.Text = "Note:";
            // 
            // pbxAlloStoricoCliente
            // 
            this.pbxAlloStoricoCliente.BackColor = System.Drawing.Color.White;
            this.pbxAlloStoricoCliente.ErrorImage = null;
            this.pbxAlloStoricoCliente.Image = global::Calendario_AriBerg.Properties.Resources.Logo_AriGenda;
            this.pbxAlloStoricoCliente.Location = new System.Drawing.Point(413, 0);
            this.pbxAlloStoricoCliente.Name = "pbxAlloStoricoCliente";
            this.pbxAlloStoricoCliente.Size = new System.Drawing.Size(61, 50);
            this.pbxAlloStoricoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAlloStoricoCliente.TabIndex = 42;
            this.pbxAlloStoricoCliente.TabStop = false;
            this.pbxAlloStoricoCliente.Click += new System.EventHandler(this.pbxAlloStoricoCliente_Click);
            // 
            // lblMostraMacchineAccessori
            // 
            this.lblMostraMacchineAccessori.AutoSize = true;
            this.lblMostraMacchineAccessori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraMacchineAccessori.ForeColor = System.Drawing.Color.White;
            this.lblMostraMacchineAccessori.Location = new System.Drawing.Point(87, 159);
            this.lblMostraMacchineAccessori.Name = "lblMostraMacchineAccessori";
            this.lblMostraMacchineAccessori.Size = new System.Drawing.Size(211, 25);
            this.lblMostraMacchineAccessori.TabIndex = 41;
            this.lblMostraMacchineAccessori.Text = "Macchine/Accessori:";
            // 
            // lvwMostraMacchineAccessori
            // 
            this.lvwMostraMacchineAccessori.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwMostraMacchineAccessori.BackColor = System.Drawing.Color.White;
            this.lvwMostraMacchineAccessori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader14});
            this.lvwMostraMacchineAccessori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMostraMacchineAccessori.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lvwMostraMacchineAccessori.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwMostraMacchineAccessori.HideSelection = false;
            this.lvwMostraMacchineAccessori.HoverSelection = true;
            this.lvwMostraMacchineAccessori.Location = new System.Drawing.Point(24, 200);
            this.lvwMostraMacchineAccessori.MultiSelect = false;
            this.lvwMostraMacchineAccessori.Name = "lvwMostraMacchineAccessori";
            this.lvwMostraMacchineAccessori.Size = new System.Drawing.Size(431, 189);
            this.lvwMostraMacchineAccessori.TabIndex = 39;
            this.lvwMostraMacchineAccessori.UseCompatibleStateImageBehavior = false;
            this.lvwMostraMacchineAccessori.View = System.Windows.Forms.View.Details;
            this.lvwMostraMacchineAccessori.SelectedIndexChanged += new System.EventHandler(this.lvwMostraMacchineAccessori_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Marca";
            this.columnHeader7.Width = 156;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Modello";
            this.columnHeader8.Width = 129;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Matricola";
            this.columnHeader14.Width = 141;
            // 
            // lblMostraPrif
            // 
            this.lblMostraPrif.AutoSize = true;
            this.lblMostraPrif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraPrif.ForeColor = System.Drawing.Color.White;
            this.lblMostraPrif.Location = new System.Drawing.Point(11, 102);
            this.lblMostraPrif.Name = "lblMostraPrif";
            this.lblMostraPrif.Size = new System.Drawing.Size(64, 25);
            this.lblMostraPrif.TabIndex = 36;
            this.lblMostraPrif.Text = "P.Rif:";
            // 
            // tbxMostraPrif
            // 
            this.tbxMostraPrif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMostraPrif.Location = new System.Drawing.Point(103, 102);
            this.tbxMostraPrif.Name = "tbxMostraPrif";
            this.tbxMostraPrif.ReadOnly = true;
            this.tbxMostraPrif.Size = new System.Drawing.Size(335, 26);
            this.tbxMostraPrif.TabIndex = 35;
            // 
            // lblMostraIva
            // 
            this.lblMostraIva.AutoSize = true;
            this.lblMostraIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraIva.ForeColor = System.Drawing.Color.White;
            this.lblMostraIva.Location = new System.Drawing.Point(11, 67);
            this.lblMostraIva.Name = "lblMostraIva";
            this.lblMostraIva.Size = new System.Drawing.Size(63, 25);
            this.lblMostraIva.TabIndex = 34;
            this.lblMostraIva.Text = "  IVA:";
            // 
            // tbxMostraIva
            // 
            this.tbxMostraIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMostraIva.Location = new System.Drawing.Point(103, 66);
            this.tbxMostraIva.Name = "tbxMostraIva";
            this.tbxMostraIva.ReadOnly = true;
            this.tbxMostraIva.Size = new System.Drawing.Size(335, 26);
            this.tbxMostraIva.TabIndex = 33;
            // 
            // pnlCommands2
            // 
            this.pnlCommands2.BackColor = System.Drawing.Color.DimGray;
            this.pnlCommands2.Controls.Add(this.btnClientiAddCustomer);
            this.pnlCommands2.Controls.Add(this.btnClientiEditCustomer);
            this.pnlCommands2.Controls.Add(this.btnClientiDeleteCustomer);
            this.pnlCommands2.Controls.Add(this.mur);
            this.pnlCommands2.Location = new System.Drawing.Point(0, 0);
            this.pnlCommands2.Name = "pnlCommands2";
            this.pnlCommands2.Size = new System.Drawing.Size(233, 78);
            this.pnlCommands2.TabIndex = 12;
            // 
            // btnClientiAddCustomer
            // 
            this.btnClientiAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientiAddCustomer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnClientiAddCustomer.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.pipottoadd_icon;
            this.btnClientiAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientiAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnClientiAddCustomer.FlatAppearance.BorderSize = 3;
            this.btnClientiAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientiAddCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientiAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientiAddCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClientiAddCustomer.Location = new System.Drawing.Point(13, 12);
            this.btnClientiAddCustomer.Name = "btnClientiAddCustomer";
            this.btnClientiAddCustomer.Size = new System.Drawing.Size(64, 51);
            this.btnClientiAddCustomer.TabIndex = 1;
            this.btnClientiAddCustomer.UseVisualStyleBackColor = false;
            this.btnClientiAddCustomer.Click += new System.EventHandler(this.btnClientiAddCustomer_Click);
            // 
            // btnClientiEditCustomer
            // 
            this.btnClientiEditCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientiEditCustomer.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClientiEditCustomer.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.pipottoedit_icon;
            this.btnClientiEditCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientiEditCustomer.Enabled = false;
            this.btnClientiEditCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnClientiEditCustomer.FlatAppearance.BorderSize = 3;
            this.btnClientiEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientiEditCustomer.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnClientiEditCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientiEditCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClientiEditCustomer.Location = new System.Drawing.Point(83, 12);
            this.btnClientiEditCustomer.Name = "btnClientiEditCustomer";
            this.btnClientiEditCustomer.Size = new System.Drawing.Size(68, 51);
            this.btnClientiEditCustomer.TabIndex = 2;
            this.btnClientiEditCustomer.UseVisualStyleBackColor = false;
            this.btnClientiEditCustomer.Click += new System.EventHandler(this.btnClientiEditCustomer_Click);
            // 
            // btnClientiDeleteCustomer
            // 
            this.btnClientiDeleteCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientiDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClientiDeleteCustomer.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.pipottodelete_icon;
            this.btnClientiDeleteCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientiDeleteCustomer.Enabled = false;
            this.btnClientiDeleteCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClientiDeleteCustomer.FlatAppearance.BorderSize = 3;
            this.btnClientiDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientiDeleteCustomer.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnClientiDeleteCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientiDeleteCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClientiDeleteCustomer.Location = new System.Drawing.Point(157, 12);
            this.btnClientiDeleteCustomer.Name = "btnClientiDeleteCustomer";
            this.btnClientiDeleteCustomer.Size = new System.Drawing.Size(61, 50);
            this.btnClientiDeleteCustomer.TabIndex = 3;
            this.btnClientiDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnClientiDeleteCustomer.Click += new System.EventHandler(this.btnClientiDeleteCustomer_Click);
            // 
            // mur
            // 
            this.mur.Image = ((System.Drawing.Image)(resources.GetObject("mur.Image")));
            this.mur.Location = new System.Drawing.Point(157, -1);
            this.mur.Name = "mur";
            this.mur.Size = new System.Drawing.Size(71, 78);
            this.mur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mur.TabIndex = 49;
            this.mur.TabStop = false;
            // 
            // dgvVisualizzaClienti
            // 
            this.dgvVisualizzaClienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisualizzaClienti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVisualizzaClienti.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvVisualizzaClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizzaClienti.Location = new System.Drawing.Point(492, 91);
            this.dgvVisualizzaClienti.MultiSelect = false;
            this.dgvVisualizzaClienti.Name = "dgvVisualizzaClienti";
            this.dgvVisualizzaClienti.ReadOnly = true;
            this.dgvVisualizzaClienti.RowHeadersWidth = 51;
            this.dgvVisualizzaClienti.Size = new System.Drawing.Size(760, 627);
            this.dgvVisualizzaClienti.TabIndex = 13;
            this.dgvVisualizzaClienti.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvVisualizzaClienti_CellStateChanged);
            this.dgvVisualizzaClienti.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvVisualizzaClienti_DataError);
            // 
            // gBxClientiTrova
            // 
            this.gBxClientiTrova.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gBxClientiTrova.Controls.Add(this.btnEliminaFiltridgvVisualizzaClienti);
            this.gBxClientiTrova.Controls.Add(this.rdBtnTrovaPerNome);
            this.gBxClientiTrova.Controls.Add(this.rdBtnTrovaPerPRif);
            this.gBxClientiTrova.Controls.Add(this.rdBtnTrovaPerMail);
            this.gBxClientiTrova.Controls.Add(this.rdBtnTrovaPerMatricola);
            this.gBxClientiTrova.Controls.Add(this.btnSearch);
            this.gBxClientiTrova.Controls.Add(this.cbBxTrovaPerMatricola);
            this.gBxClientiTrova.Controls.Add(this.cbBxTrovaPerMail);
            this.gBxClientiTrova.Controls.Add(this.cbBxTrovaPerPRif);
            this.gBxClientiTrova.Controls.Add(this.cbBxTrovaPerNome);
            this.gBxClientiTrova.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxClientiTrova.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBxClientiTrova.Location = new System.Drawing.Point(13, 81);
            this.gBxClientiTrova.Name = "gBxClientiTrova";
            this.gBxClientiTrova.Size = new System.Drawing.Size(473, 636);
            this.gBxClientiTrova.TabIndex = 25;
            this.gBxClientiTrova.TabStop = false;
            this.gBxClientiTrova.Text = "Trova";
            // 
            // btnEliminaFiltridgvVisualizzaClienti
            // 
            this.btnEliminaFiltridgvVisualizzaClienti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminaFiltridgvVisualizzaClienti.FlatAppearance.BorderSize = 0;
            this.btnEliminaFiltridgvVisualizzaClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaFiltridgvVisualizzaClienti.Location = new System.Drawing.Point(70, 485);
            this.btnEliminaFiltridgvVisualizzaClienti.Name = "btnEliminaFiltridgvVisualizzaClienti";
            this.btnEliminaFiltridgvVisualizzaClienti.Size = new System.Drawing.Size(336, 78);
            this.btnEliminaFiltridgvVisualizzaClienti.TabIndex = 32;
            this.btnEliminaFiltridgvVisualizzaClienti.Text = "Elimina filtri";
            this.btnEliminaFiltridgvVisualizzaClienti.UseVisualStyleBackColor = false;
            this.btnEliminaFiltridgvVisualizzaClienti.Click += new System.EventHandler(this.btnEliminaFiltridgvVisualizzaClienti_Click);
            // 
            // rdBtnTrovaPerNome
            // 
            this.rdBtnTrovaPerNome.AutoSize = true;
            this.rdBtnTrovaPerNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdBtnTrovaPerNome.Location = new System.Drawing.Point(14, 37);
            this.rdBtnTrovaPerNome.Name = "rdBtnTrovaPerNome";
            this.rdBtnTrovaPerNome.Size = new System.Drawing.Size(205, 29);
            this.rdBtnTrovaPerNome.TabIndex = 31;
            this.rdBtnTrovaPerNome.TabStop = true;
            this.rdBtnTrovaPerNome.Text = "Ricerca per nome ";
            this.rdBtnTrovaPerNome.UseVisualStyleBackColor = true;
            this.rdBtnTrovaPerNome.CheckedChanged += new System.EventHandler(this.rdBtnTrovaPerNome_CheckedChanged);
            // 
            // rdBtnTrovaPerPRif
            // 
            this.rdBtnTrovaPerPRif.AutoSize = true;
            this.rdBtnTrovaPerPRif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdBtnTrovaPerPRif.Location = new System.Drawing.Point(14, 132);
            this.rdBtnTrovaPerPRif.Name = "rdBtnTrovaPerPRif";
            this.rdBtnTrovaPerPRif.Size = new System.Drawing.Size(192, 29);
            this.rdBtnTrovaPerPRif.TabIndex = 30;
            this.rdBtnTrovaPerPRif.TabStop = true;
            this.rdBtnTrovaPerPRif.Text = "Ricerca per P.Rif";
            this.rdBtnTrovaPerPRif.UseVisualStyleBackColor = true;
            this.rdBtnTrovaPerPRif.CheckedChanged += new System.EventHandler(this.rdBtnTrovaPerPRif_CheckedChanged);
            // 
            // rdBtnTrovaPerMail
            // 
            this.rdBtnTrovaPerMail.AutoSize = true;
            this.rdBtnTrovaPerMail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdBtnTrovaPerMail.Location = new System.Drawing.Point(14, 223);
            this.rdBtnTrovaPerMail.Name = "rdBtnTrovaPerMail";
            this.rdBtnTrovaPerMail.Size = new System.Drawing.Size(186, 29);
            this.rdBtnTrovaPerMail.TabIndex = 29;
            this.rdBtnTrovaPerMail.TabStop = true;
            this.rdBtnTrovaPerMail.Text = "Ricerca per Mail";
            this.rdBtnTrovaPerMail.UseVisualStyleBackColor = true;
            this.rdBtnTrovaPerMail.CheckedChanged += new System.EventHandler(this.rdBtnTrovaPerMail_CheckedChanged);
            // 
            // rdBtnTrovaPerMatricola
            // 
            this.rdBtnTrovaPerMatricola.AutoSize = true;
            this.rdBtnTrovaPerMatricola.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdBtnTrovaPerMatricola.Location = new System.Drawing.Point(14, 334);
            this.rdBtnTrovaPerMatricola.Name = "rdBtnTrovaPerMatricola";
            this.rdBtnTrovaPerMatricola.Size = new System.Drawing.Size(239, 29);
            this.rdBtnTrovaPerMatricola.TabIndex = 28;
            this.rdBtnTrovaPerMatricola.TabStop = true;
            this.rdBtnTrovaPerMatricola.Text = "Ricerca per Macchina";
            this.rdBtnTrovaPerMatricola.UseVisualStyleBackColor = true;
            this.rdBtnTrovaPerMatricola.CheckedChanged += new System.EventHandler(this.rdBtnTrovaPerMatricola_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearch.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.search_icon;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.BorderSize = 15;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(403, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 70);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbBxTrovaPerMatricola
            // 
            this.cbBxTrovaPerMatricola.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBxTrovaPerMatricola.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBxTrovaPerMatricola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBxTrovaPerMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBxTrovaPerMatricola.FormattingEnabled = true;
            this.cbBxTrovaPerMatricola.Location = new System.Drawing.Point(14, 388);
            this.cbBxTrovaPerMatricola.MaxDropDownItems = 3;
            this.cbBxTrovaPerMatricola.Name = "cbBxTrovaPerMatricola";
            this.cbBxTrovaPerMatricola.Size = new System.Drawing.Size(284, 28);
            this.cbBxTrovaPerMatricola.TabIndex = 23;
            // 
            // cbBxTrovaPerMail
            // 
            this.cbBxTrovaPerMail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBxTrovaPerMail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBxTrovaPerMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBxTrovaPerMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBxTrovaPerMail.FormattingEnabled = true;
            this.cbBxTrovaPerMail.Location = new System.Drawing.Point(14, 274);
            this.cbBxTrovaPerMail.MaxDropDownItems = 3;
            this.cbBxTrovaPerMail.Name = "cbBxTrovaPerMail";
            this.cbBxTrovaPerMail.Size = new System.Drawing.Size(284, 28);
            this.cbBxTrovaPerMail.TabIndex = 22;
            // 
            // cbBxTrovaPerPRif
            // 
            this.cbBxTrovaPerPRif.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBxTrovaPerPRif.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBxTrovaPerPRif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBxTrovaPerPRif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBxTrovaPerPRif.FormattingEnabled = true;
            this.cbBxTrovaPerPRif.Location = new System.Drawing.Point(14, 173);
            this.cbBxTrovaPerPRif.MaxDropDownItems = 3;
            this.cbBxTrovaPerPRif.Name = "cbBxTrovaPerPRif";
            this.cbBxTrovaPerPRif.Size = new System.Drawing.Size(284, 28);
            this.cbBxTrovaPerPRif.TabIndex = 21;
            // 
            // cbBxTrovaPerNome
            // 
            this.cbBxTrovaPerNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBxTrovaPerNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBxTrovaPerNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBxTrovaPerNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBxTrovaPerNome.FormattingEnabled = true;
            this.cbBxTrovaPerNome.Location = new System.Drawing.Point(14, 78);
            this.cbBxTrovaPerNome.MaxDropDownItems = 3;
            this.cbBxTrovaPerNome.Name = "cbBxTrovaPerNome";
            this.cbBxTrovaPerNome.Size = new System.Drawing.Size(284, 28);
            this.cbBxTrovaPerNome.TabIndex = 20;
            // 
            // dgvModificaCliente
            // 
            this.dgvModificaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificaCliente.Location = new System.Drawing.Point(23, 389);
            this.dgvModificaCliente.Name = "dgvModificaCliente";
            this.dgvModificaCliente.Size = new System.Drawing.Size(421, 185);
            this.dgvModificaCliente.TabIndex = 58;
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1489, 835);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormCalendario";
            this.Text = "AriGenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalendario_FormClosing);
            this.Load += new System.EventHandler(this.FormCalendario_Load);
            this.Resize += new System.EventHandler(this.FormCalendario_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEventi)).EndInit();
            this.gbxLegenda.ResumeLayout(false);
            this.gbxLegenda.PerformLayout();
            this.gbxAggiungi.ResumeLayout(false);
            this.gbxAggiungi.PerformLayout();
            this.gbxModifica.ResumeLayout(false);
            this.gbxModifica.PerformLayout();
            this.pnlCommands1.ResumeLayout(false);
            this.gbxDettagli.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlCercaEvento.ResumeLayout(false);
            this.pnlCercaEvento.PerformLayout();
            this.gBxDettagliCliente.ResumeLayout(false);
            this.gBxDettagliCliente.PerformLayout();
            this.gBxDettagliMacchinaAccessorio.ResumeLayout(false);
            this.gBxDettagliMacchinaAccessorio.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gBxAggiungiMacchina.ResumeLayout(false);
            this.gBxAggiungiMacchina.PerformLayout();
            this.gBxModificaMacchina.ResumeLayout(false);
            this.gBxModificaMacchina.PerformLayout();
            this.gBxClientiAggiungiCliente.ResumeLayout(false);
            this.gBxClientiAggiungiCliente.PerformLayout();
            this.pnlAggiungiClienteButtonsMacchina.ResumeLayout(false);
            this.gBxClientiModificaClienti.ResumeLayout(false);
            this.gBxClientiModificaClienti.PerformLayout();
            this.pnlModificaClienteMacchine.ResumeLayout(false);
            this.gBxVisualizzaCliente.ResumeLayout(false);
            this.gBxVisualizzaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlloStoricoMacchina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlloStoricoCliente)).EndInit();
            this.pnlCommands2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizzaClienti)).EndInit();
            this.gBxClientiTrova.ResumeLayout(false);
            this.gBxClientiTrova.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgwEventi;
        private System.Windows.Forms.Label lblEventi;
        private System.Windows.Forms.Button btnLegenda;
        private System.Windows.Forms.GroupBox gbxLegenda;
        private System.Windows.Forms.Button btnExitLegend;
        private System.Windows.Forms.Button btnExitAggiungi;
        private System.Windows.Forms.GroupBox gbxAggiungi;
        private System.Windows.Forms.GroupBox gbxModifica;
        private System.Windows.Forms.Button btnExitModifica;
        private System.Windows.Forms.Label lblAggCliente;
        private System.Windows.Forms.Label lblModificaCliente;
        private System.Windows.Forms.Label lblAggiungiNote;
        private System.Windows.Forms.RichTextBox rtbAggiungiNote;
        private System.Windows.Forms.Label lblMacchina;
        private System.Windows.Forms.ListView listViewAggiungiIntervento;
        private System.Windows.Forms.Button btnAggiungiAddintervento;
        private System.Windows.Forms.ComboBox comboBoxAggiungi;
        private System.Windows.Forms.Button btnAggiungiRimuoviintervento;
        private System.Windows.Forms.Label lblAggiungiDispListaIntervent;
        private System.Windows.Forms.Button btnConfermaAggiungi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblAggiungiLista;
        private System.Windows.Forms.Panel pnlCommands1;
        private System.Windows.Forms.GroupBox gbxDettagli;
        private System.Windows.Forms.RichTextBox rtbNoteDettagli;
        private System.Windows.Forms.Button btnModificaRimuoviOperazioni;
        private System.Windows.Forms.Label lblModificaEventoLista;
        private System.Windows.Forms.Button btnConfermaModifica;
        private System.Windows.Forms.Label lblModificaEventoInterventi;
        private System.Windows.Forms.ListView listViewModificaOperazioni;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnModificaAggiungiOperazioni;
        private System.Windows.Forms.ComboBox cbxModificaListaOperazioni;
        private System.Windows.Forms.Label lblModificaEventoMacchine;
        private System.Windows.Forms.RichTextBox rtbModificaNote;
        private System.Windows.Forms.Label lblModificaEventoNote;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AriCalendario ariCalendario;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvVisualizzaClienti;
        private System.Windows.Forms.Panel pnlCommands2;
        private System.Windows.Forms.Button btnClientiAddCustomer;
        private System.Windows.Forms.Button btnClientiEditCustomer;
        private System.Windows.Forms.Button btnClientiDeleteCustomer;
        private System.Windows.Forms.GroupBox gBxClientiAggiungiCliente;
        private System.Windows.Forms.Button btnConfermaAggiungiCliente;
        private System.Windows.Forms.GroupBox gBxClientiModificaClienti;
        private System.Windows.Forms.Button btnConfermaModificaCliente;
        private System.Windows.Forms.Button btnAggiungiClienteChiudi;
        private System.Windows.Forms.Button btnModificaClienteChiudi;
        private System.Windows.Forms.GroupBox gBxClientiTrova;
        private System.Windows.Forms.Label lblAggiungiClientiMacchineAccessori;
        private System.Windows.Forms.ListView lvwAggiungiClientiMacchine;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblAggiungiClientePrif;
        private System.Windows.Forms.TextBox tbxAggiungiClientePrif;
        private System.Windows.Forms.Label lblAggiungiClienteIVA;
        private System.Windows.Forms.TextBox tbxAggiungiClienteIVA;
        private System.Windows.Forms.Label lblAggiungiClienteInd;
        private System.Windows.Forms.TextBox tbxAggiungiClienteInd;
        private System.Windows.Forms.Label lblAggiungiClienteMail;
        private System.Windows.Forms.TextBox tbxAggiungiClienteMail;
        private System.Windows.Forms.Label lblAggiungiClienteTel;
        private System.Windows.Forms.TextBox tbxAggiungiClienteTel;
        private System.Windows.Forms.Label lblAggiungiClienteNome;
        private System.Windows.Forms.TextBox tbxAggiungiClienteNome;
        private System.Windows.Forms.ComboBox cbBxTrovaPerMatricola;
        private System.Windows.Forms.ComboBox cbBxTrovaPerMail;
        private System.Windows.Forms.ComboBox cbBxTrovaPerPRif;
        private System.Windows.Forms.ComboBox cbBxTrovaPerNome;
        private System.Windows.Forms.RadioButton rdBtnTrovaPerMatricola;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdBtnTrovaPerNome;
        private System.Windows.Forms.RadioButton rdBtnTrovaPerPRif;
        private System.Windows.Forms.RadioButton rdBtnTrovaPerMail;
        private System.Windows.Forms.GroupBox gBxVisualizzaCliente;
        private System.Windows.Forms.Label lblMostraMacchineAccessori;
        private System.Windows.Forms.ListView lvwMostraMacchineAccessori;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblMostraPrif;
        private System.Windows.Forms.TextBox tbxMostraPrif;
        private System.Windows.Forms.Label lblMostraIva;
        private System.Windows.Forms.TextBox tbxMostraIva;
        private System.Windows.Forms.GroupBox gBxAggiungiMacchina;
        private System.Windows.Forms.RichTextBox rtbAggiungiMacchinaNote;
        private System.Windows.Forms.Label lblAggiungiMacchinaNote;
        private System.Windows.Forms.Label lblAggiungiMacchinaMatricola;
        private System.Windows.Forms.TextBox txBxAggiungiMacchinaMatricola;
        private System.Windows.Forms.Label lblAggiungiMacchinaComponenti;
        private System.Windows.Forms.Button btnAggiungiMacchinaRimuoviComponenti;
        private System.Windows.Forms.ListView lvAggiungiMacchinaFiltri;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnAggiungiMacchinaAggiungiComponenti;
        private System.Windows.Forms.Label lblAggiungiMacchinaModello;
        private System.Windows.Forms.TextBox txBxAggiungiMacchinaModello;
        private System.Windows.Forms.Button btnChiudigBxAggiungiMacchine;
        private System.Windows.Forms.Button btnConfermaAggiungiMacchina;
        private System.Windows.Forms.Panel pnlAggiungiClienteButtonsMacchina;
        private System.Windows.Forms.Button btnAggiungiAggiungiMacchina;
        private System.Windows.Forms.Button btnAggiungiModificaMacchina;
        private System.Windows.Forms.Button btnAggiungiEliminaMacchina;
        private System.Windows.Forms.TextBox txBxAggiungiMacchinaCodiceFiltro;
        private System.Windows.Forms.Panel pnlModificaClienteMacchine;
        private System.Windows.Forms.Button btnModificaAggiungiMacchina;
        private System.Windows.Forms.Button btnModificaModificaMacchina;
        private System.Windows.Forms.Button btnModificaEliminaMacchina;
        private System.Windows.Forms.Label lblModificaClienteMacchinaAccessori;
        private System.Windows.Forms.Label lblModificaClientePrif;
        private System.Windows.Forms.TextBox txBxModificaClientePrif;
        private System.Windows.Forms.Label lblModificaClienteIva;
        private System.Windows.Forms.TextBox txBxModificaClienteIva;
        private System.Windows.Forms.Label lblModificaClienteInd;
        private System.Windows.Forms.TextBox txBxModificaClienteInd;
        private System.Windows.Forms.Label lblModificaClienteMail;
        private System.Windows.Forms.TextBox txBxModificaClienteMail;
        private System.Windows.Forms.Label lblModificaClienteTel;
        private System.Windows.Forms.TextBox txBxModificaClienteTel;
        private System.Windows.Forms.Label lblModificaClienteNome;
        private System.Windows.Forms.TextBox txBxModificaClienteNome;
        private System.Windows.Forms.PictureBox pbxAlloStoricoMacchina;
        private System.Windows.Forms.PictureBox pbxAlloStoricoCliente;
        private System.Windows.Forms.CheckBox chBxAggiungiMacchinaNoleggio;
        private System.Windows.Forms.ComboBox cbBxAggiungiMacchinaTipoFiltro;
        private System.Windows.Forms.Label lblAggiungiMacchinaMarca;
        private System.Windows.Forms.TextBox txBxAggiungiMacchinaMarca;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblMostraComponenti;
        private System.Windows.Forms.ListView lvwMostraComponenti;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.CheckBox chbxMostraNoleggio;
        private System.Windows.Forms.RichTextBox rtbMostraNote;
        private System.Windows.Forms.Label lblMostraNote;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Label lblSimboloFgas;
        private System.Windows.Forms.Label lblSimboloSostFiltri;
        private System.Windows.Forms.Label lblSimboloControllo_generale;
        private System.Windows.Forms.Label lblSimboloManut_parziale;
        private System.Windows.Forms.Label lblSimboloManut_completa;
        private System.Windows.Forms.Label lblInterventoFgas;
        private System.Windows.Forms.Label lblInterventoSostfiltri;
        private System.Windows.Forms.Label lblInterventoControllo_Generale;
        private System.Windows.Forms.Label lblInterventoManut_parziale;
        private System.Windows.Forms.Label lblInterventoManut_completa;
        private System.Windows.Forms.GroupBox gBxModificaMacchina;
        private System.Windows.Forms.ComboBox cBxModificaMacchinaTipo;
        private System.Windows.Forms.Label lblModificaMacchinaMarca;
        private System.Windows.Forms.TextBox tbxModificaMacchinaMarca;
        private System.Windows.Forms.CheckBox chBxModificaMacchinaNoleggio;
        private System.Windows.Forms.TextBox txBxModificaMacchinaCodice;
        private System.Windows.Forms.RichTextBox rtbModificaMacchinaNote;
        private System.Windows.Forms.Label lblModificaMacchinaNote;
        private System.Windows.Forms.Label lblModificaMacchinaMatricola;
        private System.Windows.Forms.TextBox tbxModificaMacchinaMatricola;
        private System.Windows.Forms.Label lblModificaMacchinaComponenti;
        private System.Windows.Forms.Button btnModificaMacchinaRimuoviComponenti;
        private System.Windows.Forms.ListView lvwModificaComponentiMacchina;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button btnModificaMacchinaAggiungiComponenti;
        private System.Windows.Forms.Label lblModificaMacchinaModello;
        private System.Windows.Forms.TextBox tbxModificaMacchinaModello;
        private System.Windows.Forms.Button btnChiudigBxModificaMacchina;
        private System.Windows.Forms.Button btnConfermaModificaMacchina;
        private System.Windows.Forms.ComboBox cBxAggiungiEventoMacchine;
        private System.Windows.Forms.ComboBox cBxAggiungiEventoCliente;
        private System.Windows.Forms.ComboBox cBxModificaEventoMacchine;
        private System.Windows.Forms.ComboBox cBxModificaEventoCliente;
        private System.Windows.Forms.GroupBox gBxDettagliMacchinaAccessorio;
        private System.Windows.Forms.RichTextBox rtbNoteMacchinaAccessorio;
        private System.Windows.Forms.Label lblDettagliComponenti;
        private System.Windows.Forms.Label lblNoteMacchinaAccessorio;
        private System.Windows.Forms.ListView lvwDettagliComponenti;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.GroupBox gBxDettagliCliente;
        private System.Windows.Forms.Label lblDettagliClientePrif;
        private System.Windows.Forms.TextBox txBxDettagliClientePrif;
        private System.Windows.Forms.Label lblDettagliClienteIva;
        private System.Windows.Forms.TextBox txBxDettagliClienteIva;
        private System.Windows.Forms.Label lblDettagliClienteIndirizzo;
        private System.Windows.Forms.TextBox txBxDettagliClienteIndirizzo;
        private System.Windows.Forms.Label lblDettagliClienteMail;
        private System.Windows.Forms.TextBox txBxDettagliClienteMail;
        private System.Windows.Forms.Label lblDettagliClienteTel;
        private System.Windows.Forms.TextBox txBxDettagliClienteTel;
        private System.Windows.Forms.Panel pnlCercaEvento;
        private System.Windows.Forms.Button btnSearchEvento;
        private System.Windows.Forms.RadioButton rdBtnSearchEventoMatricola;
        private System.Windows.Forms.RadioButton rdBtnSearchEventoCliente;
        private System.Windows.Forms.ComboBox cbBxSearchEventoMatricola;
        private System.Windows.Forms.ComboBox cbBxSearchEventoCliente;
        private System.Windows.Forms.Button btnEliminaFiltridgvVisualizzaClienti;
        private System.Windows.Forms.PictureBox mur;
        private System.Windows.Forms.Label lblClienti;
        private System.Windows.Forms.DataGridView dgvModificaCliente;
    }
}

