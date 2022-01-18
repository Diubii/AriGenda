﻿
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
            this.dgvEventi = new System.Windows.Forms.DataGridView();
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
            this.gBxDettagliMacchinaAccessorio = new System.Windows.Forms.GroupBox();
            this.dgvDettagliComponenti = new System.Windows.Forms.DataGridView();
            this.lblDettagliComponenti = new System.Windows.Forms.Label();
            this.lblNoteMacchinaAccessorio = new System.Windows.Forms.Label();
            this.rtbNoteMacchinaAccessorio = new System.Windows.Forms.RichTextBox();
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
            this.pnlCercaEvento = new System.Windows.Forms.Panel();
            this.btnSearchEvento = new System.Windows.Forms.Button();
            this.rdBtnSearchEventoMatricola = new System.Windows.Forms.RadioButton();
            this.rdBtnSearchEventoCliente = new System.Windows.Forms.RadioButton();
            this.cbBxSearchEventoMatricola = new System.Windows.Forms.ComboBox();
            this.cbBxSearchEventoCliente = new System.Windows.Forms.ComboBox();
            this.ariCalendario = new Calendario_AriBerg.AriCalendario();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mur = new System.Windows.Forms.PictureBox();
            this.pnlCommands2 = new System.Windows.Forms.Panel();
            this.btnClientiAddCustomer = new System.Windows.Forms.Button();
            this.btnClientiEditCustomer = new System.Windows.Forms.Button();
            this.btnClientiDeleteCustomer = new System.Windows.Forms.Button();
            this.dgvVisualizzaClienti = new System.Windows.Forms.DataGridView();
            this.leftPanelClienti = new System.Windows.Forms.Panel();
            this.gBxClientiModificaClienti = new System.Windows.Forms.GroupBox();
            this.dgvModificaCliente = new System.Windows.Forms.DataGridView();
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
            this.gBxClientiAggiungiCliente = new System.Windows.Forms.GroupBox();
            this.dgvAggiungiClientiMacchine = new System.Windows.Forms.DataGridView();
            this.pnlAggiungiClienteButtonsMacchina = new System.Windows.Forms.Panel();
            this.btnAggiungiAggiungiMacchina = new System.Windows.Forms.Button();
            this.btnAggiungiModificaMacchina = new System.Windows.Forms.Button();
            this.btnAggiungiEliminaMacchina = new System.Windows.Forms.Button();
            this.lblAggiungiClientiMacchineAccessori = new System.Windows.Forms.Label();
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
            this.RightPanelClienti = new System.Windows.Forms.Panel();
            this.gBxAggiungiMacchina = new System.Windows.Forms.GroupBox();
            this.cbBxAggiungiMacchinaMarcaFiltro = new System.Windows.Forms.ComboBox();
            this.cbBxAggiungiMacchinaCodiceFiltro = new System.Windows.Forms.ComboBox();
            this.dgvComponentiAggiungiMacchina = new System.Windows.Forms.DataGridView();
            this.cbBxAggiungiMacchinaTipoFiltro = new System.Windows.Forms.ComboBox();
            this.lblAggiungiMacchinaMarca = new System.Windows.Forms.Label();
            this.txBxAggiungiMacchinaMarca = new System.Windows.Forms.TextBox();
            this.chBxAggiungiMacchinaNoleggio = new System.Windows.Forms.CheckBox();
            this.rtbAggiungiMacchinaNote = new System.Windows.Forms.RichTextBox();
            this.lblAggiungiMacchinaNote = new System.Windows.Forms.Label();
            this.lblAggiungiMacchinaMatricola = new System.Windows.Forms.Label();
            this.txBxAggiungiMacchinaMatricola = new System.Windows.Forms.TextBox();
            this.lblAggiungiMacchinaComponenti = new System.Windows.Forms.Label();
            this.btnAggiungiMacchinaRimuoviComponenti = new System.Windows.Forms.Button();
            this.btnAggiungiMacchinaAggiungiComponenti = new System.Windows.Forms.Button();
            this.lblAggiungiMacchinaModello = new System.Windows.Forms.Label();
            this.txBxAggiungiMacchinaModello = new System.Windows.Forms.TextBox();
            this.btnChiudigBxAggiungiMacchine = new System.Windows.Forms.Button();
            this.btnConfermaAggiungiMacchina = new System.Windows.Forms.Button();
            this.gBxVisualizzaCliente = new System.Windows.Forms.GroupBox();
            this.lblMostraComponenti = new System.Windows.Forms.Label();
            this.chbxMostraNoleggio = new System.Windows.Forms.CheckBox();
            this.rtbMostraNote = new System.Windows.Forms.RichTextBox();
            this.pbxAlloStoricoMacchina = new System.Windows.Forms.PictureBox();
            this.lblMostraNote = new System.Windows.Forms.Label();
            this.pbxAlloStoricoCliente = new System.Windows.Forms.PictureBox();
            this.lblMostraMacchineAccessori = new System.Windows.Forms.Label();
            this.lblMostraPrif = new System.Windows.Forms.Label();
            this.tbxMostraPrif = new System.Windows.Forms.TextBox();
            this.lblMostraIva = new System.Windows.Forms.Label();
            this.tbxMostraIva = new System.Windows.Forms.TextBox();
            this.gBxModificaMacchina = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
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
            this.btnModificaMacchinaAggiungiComponenti = new System.Windows.Forms.Button();
            this.lblModificaMacchinaModello = new System.Windows.Forms.Label();
            this.tbxModificaMacchinaModello = new System.Windows.Forms.TextBox();
            this.btnChiudigBxModificaMacchina = new System.Windows.Forms.Button();
            this.btnConfermaModificaMacchina = new System.Windows.Forms.Button();
            this.lblClienti = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbxModificaComponente = new System.Windows.Forms.GroupBox();
            this.cbxModificaMarcaComponente = new System.Windows.Forms.ComboBox();
            this.btnModificaComponente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudModificaSoglia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudModificaNOrdine = new System.Windows.Forms.NumericUpDown();
            this.cbxModificaTipoComponente = new System.Windows.Forms.ComboBox();
            this.tbxModificaCodiceComponente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExitEditComponente = new System.Windows.Forms.Button();
            this.tbCtrlMagazzini = new System.Windows.Forms.TabControl();
            this.Totale = new System.Windows.Forms.TabPage();
            this.dgvMagazzinoTotale = new System.Windows.Forms.DataGridView();
            this.Centrale = new System.Windows.Forms.TabPage();
            this.dgvMagazzinoCentrale = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lblMagazziniComponenti = new System.Windows.Forms.Label();
            this.MidMagPanel = new System.Windows.Forms.Panel();
            this.gbxEditComponenti = new System.Windows.Forms.GroupBox();
            this.btnCloseEditComponenti = new System.Windows.Forms.Button();
            this.lblAggiornaComponentiMagazzino = new System.Windows.Forms.Label();
            this.lblModificaComponentiMagazzino = new System.Windows.Forms.Label();
            this.lblEliminaComponenteImmagazzinato = new System.Windows.Forms.Label();
            this.btnEliminaComponenteImmagazzinato = new System.Windows.Forms.Button();
            this.nudEditNcomponenti = new System.Windows.Forms.NumericUpDown();
            this.btnMenoComponenti = new System.Windows.Forms.Button();
            this.btnPlusComponenti = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudNumeroComponenti = new System.Windows.Forms.NumericUpDown();
            this.btnImmagazzinaComponente = new System.Windows.Forms.Button();
            this.LeftMagPanel = new System.Windows.Forms.Panel();
            this.PnlCatalogo = new System.Windows.Forms.Panel();
            this.gBxAggiungiComponente = new System.Windows.Forms.GroupBox();
            this.cbxAggiungiMarcaComponente = new System.Windows.Forms.ComboBox();
            this.btnAggiungiComponente = new System.Windows.Forms.Button();
            this.lblAggiungiComponenteSoglia = new System.Windows.Forms.Label();
            this.nudAggiungiComponenteSoglia = new System.Windows.Forms.NumericUpDown();
            this.lblAggiungiComponenteMarca = new System.Windows.Forms.Label();
            this.lblAggiungiComponenteNOrdine = new System.Windows.Forms.Label();
            this.lblAggiungiComponenteCodice = new System.Windows.Forms.Label();
            this.nudAggiungiComponenteNOrdine = new System.Windows.Forms.NumericUpDown();
            this.cbxAggiungiComponenteTipo = new System.Windows.Forms.ComboBox();
            this.tbxAggiungiComponenteCodice = new System.Windows.Forms.TextBox();
            this.lblAggiungiComponenteTipo = new System.Windows.Forms.Label();
            this.btnExitAggiungiComponente = new System.Windows.Forms.Button();
            this.dgvComponenti = new System.Windows.Forms.DataGridView();
            this.lblCatalogoComponenti = new System.Windows.Forms.Label();
            this.pnlFiltriMagazzino = new System.Windows.Forms.Panel();
            this.cbBxFiltroMagazzinoMarca = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chbxFiltroAMagazzino = new System.Windows.Forms.CheckBox();
            this.chbxFiltroACatalogo = new System.Windows.Forms.CheckBox();
            this.chBxFiltroMagazzinoCodice = new System.Windows.Forms.CheckBox();
            this.chBxFiltroMagazzinoMarca = new System.Windows.Forms.CheckBox();
            this.chBxFiltroMagazzinoTipo = new System.Windows.Forms.CheckBox();
            this.chBxSottoSoglia = new System.Windows.Forms.CheckBox();
            this.btnSearchComponenti = new System.Windows.Forms.Button();
            this.cbBxFiltroMagazzinoCodice = new System.Windows.Forms.ComboBox();
            this.cbBxFiltroMagazzinoTipo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddComponente = new System.Windows.Forms.Button();
            this.btnModifyComponente = new System.Windows.Forms.Button();
            this.btnRemoveComponente = new System.Windows.Forms.Button();
            this.TopMagPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancellaNomeMagazzino = new System.Windows.Forms.Button();
            this.tbxNomeMagazzino = new System.Windows.Forms.TextBox();
            this.btnEliminaMagazzino = new System.Windows.Forms.Button();
            this.btnAggiungiMagazzino = new System.Windows.Forms.Button();
            this.btnModificaMagazzino = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dgvTipiComponenti = new System.Windows.Forms.DataGridView();
            this.dgvMarcheComponenti = new System.Windows.Forms.DataGridView();
            this.topPanelAltro = new System.Windows.Forms.Panel();
            this.pnlTipi = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.bntDeleteTextTipologie = new System.Windows.Forms.Button();
            this.txBxTipoComponente = new System.Windows.Forms.TextBox();
            this.btnDelComponente = new System.Windows.Forms.Button();
            this.btnAddTipoComponente = new System.Windows.Forms.Button();
            this.btnEditComponente = new System.Windows.Forms.Button();
            this.pnlMarche = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bntDeleteTextMarche = new System.Windows.Forms.Button();
            this.txBxMarcaComponente = new System.Windows.Forms.TextBox();
            this.btnDelMarca = new System.Windows.Forms.Button();
            this.btnAddMarca = new System.Windows.Forms.Button();
            this.btnEditMarca = new System.Windows.Forms.Button();
            this.pbxWait = new System.Windows.Forms.PictureBox();
            this.dgvMostraMacchineAccessori = new System.Windows.Forms.DataGridView();
            this.dgvMostraComponentiMacchina = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventi)).BeginInit();
            this.gbxLegenda.SuspendLayout();
            this.gbxAggiungi.SuspendLayout();
            this.gBxDettagliMacchinaAccessorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDettagliComponenti)).BeginInit();
            this.gbxModifica.SuspendLayout();
            this.pnlCommands1.SuspendLayout();
            this.gbxDettagli.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gBxDettagliCliente.SuspendLayout();
            this.pnlCercaEvento.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mur)).BeginInit();
            this.pnlCommands2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizzaClienti)).BeginInit();
            this.leftPanelClienti.SuspendLayout();
            this.gBxClientiModificaClienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificaCliente)).BeginInit();
            this.pnlModificaClienteMacchine.SuspendLayout();
            this.gBxClientiAggiungiCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAggiungiClientiMacchine)).BeginInit();
            this.pnlAggiungiClienteButtonsMacchina.SuspendLayout();
            this.gBxClientiTrova.SuspendLayout();
            this.RightPanelClienti.SuspendLayout();
            this.gBxAggiungiMacchina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentiAggiungiMacchina)).BeginInit();
            this.gBxVisualizzaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlloStoricoMacchina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlloStoricoCliente)).BeginInit();
            this.gBxModificaMacchina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.gbxModificaComponente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModificaSoglia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModificaNOrdine)).BeginInit();
            this.tbCtrlMagazzini.SuspendLayout();
            this.Totale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzinoTotale)).BeginInit();
            this.Centrale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzinoCentrale)).BeginInit();
            this.MidMagPanel.SuspendLayout();
            this.gbxEditComponenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditNcomponenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroComponenti)).BeginInit();
            this.LeftMagPanel.SuspendLayout();
            this.PnlCatalogo.SuspendLayout();
            this.gBxAggiungiComponente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAggiungiComponenteSoglia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAggiungiComponenteNOrdine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponenti)).BeginInit();
            this.pnlFiltriMagazzino.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TopMagPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipiComponenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcheComponenti)).BeginInit();
            this.topPanelAltro.SuspendLayout();
            this.pnlTipi.SuspendLayout();
            this.pnlMarche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraMacchineAccessori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraComponentiMacchina)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventi
            // 
            this.dgvEventi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventi.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvEventi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventi.GridColor = System.Drawing.Color.Black;
            this.dgvEventi.Location = new System.Drawing.Point(622, 82);
            this.dgvEventi.Name = "dgvEventi";
            this.dgvEventi.ReadOnly = true;
            this.dgvEventi.RowHeadersWidth = 51;
            this.dgvEventi.RowTemplate.Height = 24;
            this.dgvEventi.Size = new System.Drawing.Size(810, 719);
            this.dgvEventi.TabIndex = 4;
            this.dgvEventi.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEventi_CellMouseEnter);
            this.dgvEventi.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEventi_CellMouseLeave);
            this.dgvEventi.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgwEventi_CellPainting);
            this.dgvEventi.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgwEventi_CellStateChanged);
            this.dgvEventi.MouseEnter += new System.EventHandler(this.dgwEventi_MouseEnter);
            this.dgvEventi.MouseLeave += new System.EventHandler(this.dgwEventi_MouseLeave);
            // 
            // lblEventi
            // 
            this.lblEventi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEventi.Font = new System.Drawing.Font("Calibri", 22.2F);
            this.lblEventi.ForeColor = System.Drawing.Color.White;
            this.lblEventi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEventi.Location = new System.Drawing.Point(3, 3);
            this.lblEventi.Name = "lblEventi";
            this.lblEventi.Padding = new System.Windows.Forms.Padding(600, 0, 0, 0);
            this.lblEventi.Size = new System.Drawing.Size(1429, 79);
            this.lblEventi.TabIndex = 5;
            this.lblEventi.Text = "Eventi (day)";
            this.lblEventi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLegenda
            // 
            this.btnLegenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLegenda.BackColor = System.Drawing.Color.Teal;
            this.btnLegenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLegenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLegenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLegenda.Location = new System.Drawing.Point(1316, 3);
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
            this.gbxLegenda.Location = new System.Drawing.Point(1198, 0);
            this.gbxLegenda.Name = "gbxLegenda";
            this.gbxLegenda.Size = new System.Drawing.Size(241, 177);
            this.gbxLegenda.TabIndex = 7;
            this.gbxLegenda.TabStop = false;
            this.gbxLegenda.Text = "Legenda";
            this.gbxLegenda.Visible = false;
            // 
            // lblInterventoManut_completa
            // 
            this.lblInterventoManut_completa.AutoSize = true;
            this.lblInterventoManut_completa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInterventoManut_completa.Location = new System.Drawing.Point(6, 29);
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
            this.lblSimboloManut_parziale.Location = new System.Drawing.Point(196, 55);
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
            this.lblSimboloFgas.Location = new System.Drawing.Point(196, 138);
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
            this.lblSimboloSostFiltri.Location = new System.Drawing.Point(196, 109);
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
            this.lblSimboloControllo_generale.Location = new System.Drawing.Point(196, 82);
            this.lblSimboloControllo_generale.Name = "lblSimboloControllo_generale";
            this.lblSimboloControllo_generale.Size = new System.Drawing.Size(18, 17);
            this.lblSimboloControllo_generale.TabIndex = 8;
            this.lblSimboloControllo_generale.Text = "◈";
            // 
            // lblInterventoFgas
            // 
            this.lblInterventoFgas.AutoSize = true;
            this.lblInterventoFgas.Location = new System.Drawing.Point(6, 138);
            this.lblInterventoFgas.Name = "lblInterventoFgas";
            this.lblInterventoFgas.Size = new System.Drawing.Size(96, 17);
            this.lblInterventoFgas.TabIndex = 5;
            this.lblInterventoFgas.Text = "Controllo Fgas:";
            // 
            // lblInterventoSostfiltri
            // 
            this.lblInterventoSostfiltri.AutoSize = true;
            this.lblInterventoSostfiltri.Location = new System.Drawing.Point(6, 109);
            this.lblInterventoSostfiltri.Name = "lblInterventoSostfiltri";
            this.lblInterventoSostfiltri.Size = new System.Drawing.Size(125, 17);
            this.lblInterventoSostfiltri.TabIndex = 4;
            this.lblInterventoSostfiltri.Text = "Sost Filtri e Carboni:";
            // 
            // lblInterventoControllo_Generale
            // 
            this.lblInterventoControllo_Generale.AutoSize = true;
            this.lblInterventoControllo_Generale.Location = new System.Drawing.Point(6, 82);
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
            this.btnExitLegend.Location = new System.Drawing.Point(216, 0);
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
            this.lblInterventoManut_parziale.Location = new System.Drawing.Point(6, 55);
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
            this.lblSimboloManut_completa.Location = new System.Drawing.Point(196, 33);
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
            this.btnExitAggiungi.Location = new System.Drawing.Point(594, 0);
            this.btnExitAggiungi.Name = "btnExitAggiungi";
            this.btnExitAggiungi.Size = new System.Drawing.Size(25, 25);
            this.btnExitAggiungi.TabIndex = 0;
            this.btnExitAggiungi.Text = "X";
            this.btnExitAggiungi.UseVisualStyleBackColor = false;
            this.btnExitAggiungi.Click += new System.EventHandler(this.BtnExitAggiungi_Click);
            // 
            // gbxAggiungi
            // 
            this.gbxAggiungi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxAggiungi.Controls.Add(this.cBxAggiungiEventoMacchine);
            this.gbxAggiungi.Controls.Add(this.cBxAggiungiEventoCliente);
            this.gbxAggiungi.Controls.Add(this.lblAggiungiLista);
            this.gbxAggiungi.Controls.Add(this.btnConfermaAggiungi);
            this.gbxAggiungi.Controls.Add(this.gBxDettagliMacchinaAccessorio);
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
            this.gbxAggiungi.Location = new System.Drawing.Point(3, 81);
            this.gbxAggiungi.Name = "gbxAggiungi";
            this.gbxAggiungi.Size = new System.Drawing.Size(619, 580);
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
            // gBxDettagliMacchinaAccessorio
            // 
            this.gBxDettagliMacchinaAccessorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBxDettagliMacchinaAccessorio.Controls.Add(this.dgvDettagliComponenti);
            this.gBxDettagliMacchinaAccessorio.Controls.Add(this.lblDettagliComponenti);
            this.gBxDettagliMacchinaAccessorio.Controls.Add(this.lblNoteMacchinaAccessorio);
            this.gBxDettagliMacchinaAccessorio.Controls.Add(this.rtbNoteMacchinaAccessorio);
            this.gBxDettagliMacchinaAccessorio.Enabled = false;
            this.gBxDettagliMacchinaAccessorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBxDettagliMacchinaAccessorio.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.gBxDettagliMacchinaAccessorio.ForeColor = System.Drawing.Color.White;
            this.gBxDettagliMacchinaAccessorio.Location = new System.Drawing.Point(23, 228);
            this.gBxDettagliMacchinaAccessorio.Name = "gBxDettagliMacchinaAccessorio";
            this.gBxDettagliMacchinaAccessorio.Size = new System.Drawing.Size(538, 254);
            this.gBxDettagliMacchinaAccessorio.TabIndex = 13;
            this.gBxDettagliMacchinaAccessorio.TabStop = false;
            this.gBxDettagliMacchinaAccessorio.Text = "Dettagli macchina / accessorio";
            this.gBxDettagliMacchinaAccessorio.Visible = false;
            this.gBxDettagliMacchinaAccessorio.MouseLeave += new System.EventHandler(this.gBxDettagliMacchinaAccessorio_MouseLeave);
            this.gBxDettagliMacchinaAccessorio.MouseHover += new System.EventHandler(this.gBxDettagliMacchinaAccessorio_MouseHover);
            // 
            // dgvDettagliComponenti
            // 
            this.dgvDettagliComponenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDettagliComponenti.Location = new System.Drawing.Point(264, 49);
            this.dgvDettagliComponenti.Name = "dgvDettagliComponenti";
            this.dgvDettagliComponenti.Size = new System.Drawing.Size(274, 205);
            this.dgvDettagliComponenti.TabIndex = 35;
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
            // rtbNoteMacchinaAccessorio
            // 
            this.rtbNoteMacchinaAccessorio.Location = new System.Drawing.Point(3, 49);
            this.rtbNoteMacchinaAccessorio.Name = "rtbNoteMacchinaAccessorio";
            this.rtbNoteMacchinaAccessorio.ReadOnly = true;
            this.rtbNoteMacchinaAccessorio.Size = new System.Drawing.Size(262, 202);
            this.rtbNoteMacchinaAccessorio.TabIndex = 1;
            this.rtbNoteMacchinaAccessorio.Text = "";
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
            this.gbxModifica.Location = new System.Drawing.Point(120, 731);
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
            this.pnlCommands1.Location = new System.Drawing.Point(3, 3);
            this.pnlCommands1.Name = "pnlCommands1";
            this.pnlCommands1.Size = new System.Drawing.Size(210, 75);
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
            this.btnAdd.Location = new System.Drawing.Point(5, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 60);
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
            this.btnModify.Location = new System.Drawing.Point(71, 6);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(60, 60);
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
            this.btnRemove.Location = new System.Drawing.Point(137, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 60);
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
            this.gbxDettagli.Location = new System.Drawing.Point(807, 632);
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1443, 835);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.gbxLegenda);
            this.tabPage1.Controls.Add(this.gbxModifica);
            this.tabPage1.Controls.Add(this.gbxAggiungi);
            this.tabPage1.Controls.Add(this.gBxDettagliCliente);
            this.tabPage1.Controls.Add(this.gbxDettagli);
            this.tabPage1.Controls.Add(this.btnLegenda);
            this.tabPage1.Controls.Add(this.pnlCercaEvento);
            this.tabPage1.Controls.Add(this.pnlCommands1);
            this.tabPage1.Controls.Add(this.dgvEventi);
            this.tabPage1.Controls.Add(this.ariCalendario);
            this.tabPage1.Controls.Add(this.lblEventi);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1435, 804);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Eventi";
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
            this.gBxDettagliCliente.Location = new System.Drawing.Point(1397, 755);
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
            // pnlCercaEvento
            // 
            this.pnlCercaEvento.BackColor = System.Drawing.Color.DimGray;
            this.pnlCercaEvento.Controls.Add(this.btnSearchEvento);
            this.pnlCercaEvento.Controls.Add(this.rdBtnSearchEventoMatricola);
            this.pnlCercaEvento.Controls.Add(this.rdBtnSearchEventoCliente);
            this.pnlCercaEvento.Controls.Add(this.cbBxSearchEventoMatricola);
            this.pnlCercaEvento.Controls.Add(this.cbBxSearchEventoCliente);
            this.pnlCercaEvento.Location = new System.Drawing.Point(219, 3);
            this.pnlCercaEvento.Name = "pnlCercaEvento";
            this.pnlCercaEvento.Size = new System.Drawing.Size(403, 75);
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
            this.btnSearchEvento.Location = new System.Drawing.Point(328, 9);
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
            this.rdBtnSearchEventoMatricola.Location = new System.Drawing.Point(18, 41);
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
            this.rdBtnSearchEventoCliente.Location = new System.Drawing.Point(18, 12);
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
            this.cbBxSearchEventoMatricola.Location = new System.Drawing.Point(116, 40);
            this.cbBxSearchEventoMatricola.Name = "cbBxSearchEventoMatricola";
            this.cbBxSearchEventoMatricola.Size = new System.Drawing.Size(206, 26);
            this.cbBxSearchEventoMatricola.TabIndex = 1;
            // 
            // cbBxSearchEventoCliente
            // 
            this.cbBxSearchEventoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBxSearchEventoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBxSearchEventoCliente.FormattingEnabled = true;
            this.cbBxSearchEventoCliente.Location = new System.Drawing.Point(116, 8);
            this.cbBxSearchEventoCliente.Name = "cbBxSearchEventoCliente";
            this.cbBxSearchEventoCliente.Size = new System.Drawing.Size(206, 26);
            this.cbBxSearchEventoCliente.TabIndex = 0;
            // 
            // ariCalendario
            // 
            this.ariCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ariCalendario.Dock = System.Windows.Forms.DockStyle.Left;
            this.ariCalendario.Font = new System.Drawing.Font("Segoe UI Light", 32.25F);
            this.ariCalendario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ariCalendario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ariCalendario.Location = new System.Drawing.Point(3, 82);
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
            this.tabPage2.Controls.Add(this.mur);
            this.tabPage2.Controls.Add(this.pnlCommands2);
            this.tabPage2.Controls.Add(this.dgvVisualizzaClienti);
            this.tabPage2.Controls.Add(this.leftPanelClienti);
            this.tabPage2.Controls.Add(this.RightPanelClienti);
            this.tabPage2.Controls.Add(this.lblClienti);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1435, 804);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clienti";
            // 
            // mur
            // 
            this.mur.Location = new System.Drawing.Point(216, 6);
            this.mur.Name = "mur";
            this.mur.Size = new System.Drawing.Size(67, 73);
            this.mur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mur.TabIndex = 49;
            this.mur.TabStop = false;
            this.mur.Click += new System.EventHandler(this.mur_Click);
            // 
            // pnlCommands2
            // 
            this.pnlCommands2.BackColor = System.Drawing.Color.DimGray;
            this.pnlCommands2.Controls.Add(this.btnClientiAddCustomer);
            this.pnlCommands2.Controls.Add(this.btnClientiEditCustomer);
            this.pnlCommands2.Controls.Add(this.btnClientiDeleteCustomer);
            this.pnlCommands2.Location = new System.Drawing.Point(0, 3);
            this.pnlCommands2.Name = "pnlCommands2";
            this.pnlCommands2.Size = new System.Drawing.Size(210, 75);
            this.pnlCommands2.TabIndex = 12;
            // 
            // btnClientiAddCustomer
            // 
            this.btnClientiAddCustomer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnClientiAddCustomer.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.pipottoadd_icon;
            this.btnClientiAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientiAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnClientiAddCustomer.FlatAppearance.BorderSize = 3;
            this.btnClientiAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientiAddCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientiAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientiAddCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClientiAddCustomer.Location = new System.Drawing.Point(7, 7);
            this.btnClientiAddCustomer.Name = "btnClientiAddCustomer";
            this.btnClientiAddCustomer.Size = new System.Drawing.Size(60, 60);
            this.btnClientiAddCustomer.TabIndex = 1;
            this.btnClientiAddCustomer.UseVisualStyleBackColor = false;
            this.btnClientiAddCustomer.Click += new System.EventHandler(this.btnClientiAddCustomer_Click);
            // 
            // btnClientiEditCustomer
            // 
            this.btnClientiEditCustomer.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClientiEditCustomer.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.pipottoedit_icon;
            this.btnClientiEditCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientiEditCustomer.Enabled = false;
            this.btnClientiEditCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnClientiEditCustomer.FlatAppearance.BorderSize = 3;
            this.btnClientiEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientiEditCustomer.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnClientiEditCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientiEditCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClientiEditCustomer.Location = new System.Drawing.Point(77, 7);
            this.btnClientiEditCustomer.Name = "btnClientiEditCustomer";
            this.btnClientiEditCustomer.Size = new System.Drawing.Size(60, 60);
            this.btnClientiEditCustomer.TabIndex = 2;
            this.btnClientiEditCustomer.UseVisualStyleBackColor = false;
            this.btnClientiEditCustomer.Click += new System.EventHandler(this.btnClientiEditCustomer_Click);
            // 
            // btnClientiDeleteCustomer
            // 
            this.btnClientiDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClientiDeleteCustomer.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.pipottodelete_icon;
            this.btnClientiDeleteCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientiDeleteCustomer.Enabled = false;
            this.btnClientiDeleteCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClientiDeleteCustomer.FlatAppearance.BorderSize = 3;
            this.btnClientiDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientiDeleteCustomer.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnClientiDeleteCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientiDeleteCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClientiDeleteCustomer.Location = new System.Drawing.Point(143, 7);
            this.btnClientiDeleteCustomer.Name = "btnClientiDeleteCustomer";
            this.btnClientiDeleteCustomer.Size = new System.Drawing.Size(60, 60);
            this.btnClientiDeleteCustomer.TabIndex = 3;
            this.btnClientiDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnClientiDeleteCustomer.Click += new System.EventHandler(this.btnClientiDeleteCustomer_Click);
            // 
            // dgvVisualizzaClienti
            // 
            this.dgvVisualizzaClienti.AllowUserToAddRows = false;
            this.dgvVisualizzaClienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisualizzaClienti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVisualizzaClienti.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvVisualizzaClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizzaClienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisualizzaClienti.Location = new System.Drawing.Point(463, 79);
            this.dgvVisualizzaClienti.MultiSelect = false;
            this.dgvVisualizzaClienti.Name = "dgvVisualizzaClienti";
            this.dgvVisualizzaClienti.ReadOnly = true;
            this.dgvVisualizzaClienti.RowHeadersWidth = 51;
            this.dgvVisualizzaClienti.Size = new System.Drawing.Size(586, 722);
            this.dgvVisualizzaClienti.TabIndex = 13;
            this.dgvVisualizzaClienti.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvVisualizzaClienti_CellStateChanged);
            this.dgvVisualizzaClienti.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvVisualizzaClienti_DataError);
            // 
            // leftPanelClienti
            // 
            this.leftPanelClienti.Controls.Add(this.gBxClientiModificaClienti);
            this.leftPanelClienti.Controls.Add(this.gBxClientiAggiungiCliente);
            this.leftPanelClienti.Controls.Add(this.gBxClientiTrova);
            this.leftPanelClienti.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelClienti.Location = new System.Drawing.Point(3, 79);
            this.leftPanelClienti.Name = "leftPanelClienti";
            this.leftPanelClienti.Size = new System.Drawing.Size(460, 722);
            this.leftPanelClienti.TabIndex = 50;
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
            this.gBxClientiModificaClienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBxClientiModificaClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxClientiModificaClienti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBxClientiModificaClienti.Location = new System.Drawing.Point(0, 0);
            this.gBxClientiModificaClienti.Name = "gBxClientiModificaClienti";
            this.gBxClientiModificaClienti.Size = new System.Drawing.Size(460, 722);
            this.gBxClientiModificaClienti.TabIndex = 24;
            this.gBxClientiModificaClienti.TabStop = false;
            this.gBxClientiModificaClienti.Text = "Modifica cliente:";
            this.gBxClientiModificaClienti.Visible = false;
            // 
            // dgvModificaCliente
            // 
            this.dgvModificaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificaCliente.Location = new System.Drawing.Point(23, 389);
            this.dgvModificaCliente.Name = "dgvModificaCliente";
            this.dgvModificaCliente.Size = new System.Drawing.Size(421, 183);
            this.dgvModificaCliente.TabIndex = 60;
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
            this.btnModificaAggiungiMacchina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.btnModificaModificaMacchina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.btnModificaEliminaMacchina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.btnModificaClienteChiudi.Location = new System.Drawing.Point(435, 14);
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
            // gBxClientiAggiungiCliente
            // 
            this.gBxClientiAggiungiCliente.Controls.Add(this.dgvAggiungiClientiMacchine);
            this.gBxClientiAggiungiCliente.Controls.Add(this.pnlAggiungiClienteButtonsMacchina);
            this.gBxClientiAggiungiCliente.Controls.Add(this.lblAggiungiClientiMacchineAccessori);
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
            this.gBxClientiAggiungiCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBxClientiAggiungiCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxClientiAggiungiCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBxClientiAggiungiCliente.Location = new System.Drawing.Point(0, 0);
            this.gBxClientiAggiungiCliente.Name = "gBxClientiAggiungiCliente";
            this.gBxClientiAggiungiCliente.Size = new System.Drawing.Size(460, 722);
            this.gBxClientiAggiungiCliente.TabIndex = 14;
            this.gBxClientiAggiungiCliente.TabStop = false;
            this.gBxClientiAggiungiCliente.Text = "Aggiungi cliente";
            this.gBxClientiAggiungiCliente.Visible = false;
            // 
            // dgvAggiungiClientiMacchine
            // 
            this.dgvAggiungiClientiMacchine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAggiungiClientiMacchine.Location = new System.Drawing.Point(22, 401);
            this.dgvAggiungiClientiMacchine.Name = "dgvAggiungiClientiMacchine";
            this.dgvAggiungiClientiMacchine.Size = new System.Drawing.Size(422, 173);
            this.dgvAggiungiClientiMacchine.TabIndex = 43;
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
            this.tbxAggiungiClientePrif.Tag = "NotMandatory";
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
            this.tbxAggiungiClienteIVA.Tag = "NotMandatory";
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
            this.tbxAggiungiClienteInd.Tag = "Mandatory";
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
            this.tbxAggiungiClienteMail.Tag = "Mandatory";
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
            this.tbxAggiungiClienteTel.Tag = "Mandatory";
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
            this.tbxAggiungiClienteNome.Tag = "Mandatory";
            // 
            // btnAggiungiClienteChiudi
            // 
            this.btnAggiungiClienteChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungiClienteChiudi.BackColor = System.Drawing.Color.Red;
            this.btnAggiungiClienteChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiClienteChiudi.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAggiungiClienteChiudi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAggiungiClienteChiudi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAggiungiClienteChiudi.Location = new System.Drawing.Point(435, 14);
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
            this.gBxClientiTrova.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBxClientiTrova.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxClientiTrova.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBxClientiTrova.Location = new System.Drawing.Point(0, 0);
            this.gBxClientiTrova.Name = "gBxClientiTrova";
            this.gBxClientiTrova.Size = new System.Drawing.Size(460, 722);
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
            this.btnSearch.Location = new System.Drawing.Point(390, 6);
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
            // RightPanelClienti
            // 
            this.RightPanelClienti.Controls.Add(this.gBxAggiungiMacchina);
            this.RightPanelClienti.Controls.Add(this.gBxVisualizzaCliente);
            this.RightPanelClienti.Controls.Add(this.gBxModificaMacchina);
            this.RightPanelClienti.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanelClienti.Location = new System.Drawing.Point(1049, 79);
            this.RightPanelClienti.Name = "RightPanelClienti";
            this.RightPanelClienti.Size = new System.Drawing.Size(383, 722);
            this.RightPanelClienti.TabIndex = 51;
            // 
            // gBxAggiungiMacchina
            // 
            this.gBxAggiungiMacchina.Controls.Add(this.cbBxAggiungiMacchinaMarcaFiltro);
            this.gBxAggiungiMacchina.Controls.Add(this.cbBxAggiungiMacchinaCodiceFiltro);
            this.gBxAggiungiMacchina.Controls.Add(this.dgvComponentiAggiungiMacchina);
            this.gBxAggiungiMacchina.Controls.Add(this.cbBxAggiungiMacchinaTipoFiltro);
            this.gBxAggiungiMacchina.Controls.Add(this.lblAggiungiMacchinaMarca);
            this.gBxAggiungiMacchina.Controls.Add(this.txBxAggiungiMacchinaMarca);
            this.gBxAggiungiMacchina.Controls.Add(this.chBxAggiungiMacchinaNoleggio);
            this.gBxAggiungiMacchina.Controls.Add(this.rtbAggiungiMacchinaNote);
            this.gBxAggiungiMacchina.Controls.Add(this.lblAggiungiMacchinaNote);
            this.gBxAggiungiMacchina.Controls.Add(this.lblAggiungiMacchinaMatricola);
            this.gBxAggiungiMacchina.Controls.Add(this.txBxAggiungiMacchinaMatricola);
            this.gBxAggiungiMacchina.Controls.Add(this.lblAggiungiMacchinaComponenti);
            this.gBxAggiungiMacchina.Controls.Add(this.btnAggiungiMacchinaRimuoviComponenti);
            this.gBxAggiungiMacchina.Controls.Add(this.btnAggiungiMacchinaAggiungiComponenti);
            this.gBxAggiungiMacchina.Controls.Add(this.lblAggiungiMacchinaModello);
            this.gBxAggiungiMacchina.Controls.Add(this.txBxAggiungiMacchinaModello);
            this.gBxAggiungiMacchina.Controls.Add(this.btnChiudigBxAggiungiMacchine);
            this.gBxAggiungiMacchina.Controls.Add(this.btnConfermaAggiungiMacchina);
            this.gBxAggiungiMacchina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBxAggiungiMacchina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxAggiungiMacchina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBxAggiungiMacchina.Location = new System.Drawing.Point(0, 0);
            this.gBxAggiungiMacchina.Name = "gBxAggiungiMacchina";
            this.gBxAggiungiMacchina.Size = new System.Drawing.Size(383, 722);
            this.gBxAggiungiMacchina.TabIndex = 43;
            this.gBxAggiungiMacchina.TabStop = false;
            this.gBxAggiungiMacchina.Text = "Aggiungi macchina/accessorio";
            this.gBxAggiungiMacchina.Visible = false;
            // 
            // cbBxAggiungiMacchinaMarcaFiltro
            // 
            this.cbBxAggiungiMacchinaMarcaFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBxAggiungiMacchinaMarcaFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBxAggiungiMacchinaMarcaFiltro.Enabled = false;
            this.cbBxAggiungiMacchinaMarcaFiltro.FormattingEnabled = true;
            this.cbBxAggiungiMacchinaMarcaFiltro.Location = new System.Drawing.Point(137, 337);
            this.cbBxAggiungiMacchinaMarcaFiltro.Name = "cbBxAggiungiMacchinaMarcaFiltro";
            this.cbBxAggiungiMacchinaMarcaFiltro.Size = new System.Drawing.Size(239, 28);
            this.cbBxAggiungiMacchinaMarcaFiltro.TabIndex = 51;
            this.cbBxAggiungiMacchinaMarcaFiltro.SelectedIndexChanged += new System.EventHandler(this.cbBxAggiungiMacchinaMarcaFiltro_SelectedIndexChanged);
            // 
            // cbBxAggiungiMacchinaCodiceFiltro
            // 
            this.cbBxAggiungiMacchinaCodiceFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBxAggiungiMacchinaCodiceFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBxAggiungiMacchinaCodiceFiltro.Enabled = false;
            this.cbBxAggiungiMacchinaCodiceFiltro.FormattingEnabled = true;
            this.cbBxAggiungiMacchinaCodiceFiltro.Location = new System.Drawing.Point(136, 369);
            this.cbBxAggiungiMacchinaCodiceFiltro.Name = "cbBxAggiungiMacchinaCodiceFiltro";
            this.cbBxAggiungiMacchinaCodiceFiltro.Size = new System.Drawing.Size(240, 28);
            this.cbBxAggiungiMacchinaCodiceFiltro.TabIndex = 50;
            // 
            // dgvComponentiAggiungiMacchina
            // 
            this.dgvComponentiAggiungiMacchina.AllowUserToAddRows = false;
            this.dgvComponentiAggiungiMacchina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComponentiAggiungiMacchina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponentiAggiungiMacchina.Location = new System.Drawing.Point(24, 401);
            this.dgvComponentiAggiungiMacchina.Name = "dgvComponentiAggiungiMacchina";
            this.dgvComponentiAggiungiMacchina.ReadOnly = true;
            this.dgvComponentiAggiungiMacchina.Size = new System.Drawing.Size(352, 117);
            this.dgvComponentiAggiungiMacchina.TabIndex = 48;
            // 
            // cbBxAggiungiMacchinaTipoFiltro
            // 
            this.cbBxAggiungiMacchinaTipoFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBxAggiungiMacchinaTipoFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBxAggiungiMacchinaTipoFiltro.FormattingEnabled = true;
            this.cbBxAggiungiMacchinaTipoFiltro.Location = new System.Drawing.Point(137, 306);
            this.cbBxAggiungiMacchinaTipoFiltro.Name = "cbBxAggiungiMacchinaTipoFiltro";
            this.cbBxAggiungiMacchinaTipoFiltro.Size = new System.Drawing.Size(239, 28);
            this.cbBxAggiungiMacchinaTipoFiltro.TabIndex = 47;
            this.cbBxAggiungiMacchinaTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cbBxAggiungiMacchinaTipoFiltro_SelectedIndexChanged);
            // 
            // lblAggiungiMacchinaMarca
            // 
            this.lblAggiungiMacchinaMarca.AutoSize = true;
            this.lblAggiungiMacchinaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiMacchinaMarca.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiMacchinaMarca.Location = new System.Drawing.Point(165, 39);
            this.lblAggiungiMacchinaMarca.Name = "lblAggiungiMacchinaMarca";
            this.lblAggiungiMacchinaMarca.Size = new System.Drawing.Size(72, 25);
            this.lblAggiungiMacchinaMarca.TabIndex = 46;
            this.lblAggiungiMacchinaMarca.Text = "Marca";
            this.lblAggiungiMacchinaMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txBxAggiungiMacchinaMarca
            // 
            this.txBxAggiungiMacchinaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxAggiungiMacchinaMarca.Location = new System.Drawing.Point(23, 69);
            this.txBxAggiungiMacchinaMarca.Name = "txBxAggiungiMacchinaMarca";
            this.txBxAggiungiMacchinaMarca.Size = new System.Drawing.Size(353, 26);
            this.txBxAggiungiMacchinaMarca.TabIndex = 45;
            // 
            // chBxAggiungiMacchinaNoleggio
            // 
            this.chBxAggiungiMacchinaNoleggio.AutoSize = true;
            this.chBxAggiungiMacchinaNoleggio.Location = new System.Drawing.Point(158, 239);
            this.chBxAggiungiMacchinaNoleggio.Name = "chBxAggiungiMacchinaNoleggio";
            this.chBxAggiungiMacchinaNoleggio.Size = new System.Drawing.Size(90, 24);
            this.chBxAggiungiMacchinaNoleggio.TabIndex = 44;
            this.chBxAggiungiMacchinaNoleggio.Text = "Noleggio";
            this.chBxAggiungiMacchinaNoleggio.UseVisualStyleBackColor = true;
            // 
            // rtbAggiungiMacchinaNote
            // 
            this.rtbAggiungiMacchinaNote.Location = new System.Drawing.Point(24, 559);
            this.rtbAggiungiMacchinaNote.Name = "rtbAggiungiMacchinaNote";
            this.rtbAggiungiMacchinaNote.Size = new System.Drawing.Size(353, 101);
            this.rtbAggiungiMacchinaNote.TabIndex = 38;
            this.rtbAggiungiMacchinaNote.Text = "";
            // 
            // lblAggiungiMacchinaNote
            // 
            this.lblAggiungiMacchinaNote.AutoSize = true;
            this.lblAggiungiMacchinaNote.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblAggiungiMacchinaNote.Location = new System.Drawing.Point(20, 525);
            this.lblAggiungiMacchinaNote.Name = "lblAggiungiMacchinaNote";
            this.lblAggiungiMacchinaNote.Size = new System.Drawing.Size(47, 20);
            this.lblAggiungiMacchinaNote.TabIndex = 37;
            this.lblAggiungiMacchinaNote.Text = "Note:";
            // 
            // lblAggiungiMacchinaMatricola
            // 
            this.lblAggiungiMacchinaMatricola.AutoSize = true;
            this.lblAggiungiMacchinaMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiMacchinaMatricola.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiMacchinaMatricola.Location = new System.Drawing.Point(154, 179);
            this.lblAggiungiMacchinaMatricola.Name = "lblAggiungiMacchinaMatricola";
            this.lblAggiungiMacchinaMatricola.Size = new System.Drawing.Size(100, 25);
            this.lblAggiungiMacchinaMatricola.TabIndex = 35;
            this.lblAggiungiMacchinaMatricola.Text = "Matricola";
            this.lblAggiungiMacchinaMatricola.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txBxAggiungiMacchinaMatricola
            // 
            this.txBxAggiungiMacchinaMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxAggiungiMacchinaMatricola.Location = new System.Drawing.Point(23, 207);
            this.txBxAggiungiMacchinaMatricola.Name = "txBxAggiungiMacchinaMatricola";
            this.txBxAggiungiMacchinaMatricola.Size = new System.Drawing.Size(353, 26);
            this.txBxAggiungiMacchinaMatricola.TabIndex = 34;
            // 
            // lblAggiungiMacchinaComponenti
            // 
            this.lblAggiungiMacchinaComponenti.AutoSize = true;
            this.lblAggiungiMacchinaComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiMacchinaComponenti.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiMacchinaComponenti.Location = new System.Drawing.Point(147, 271);
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
            this.btnAggiungiMacchinaRimuoviComponenti.Location = new System.Drawing.Point(23, 357);
            this.btnAggiungiMacchinaRimuoviComponenti.Name = "btnAggiungiMacchinaRimuoviComponenti";
            this.btnAggiungiMacchinaRimuoviComponenti.Size = new System.Drawing.Size(107, 40);
            this.btnAggiungiMacchinaRimuoviComponenti.TabIndex = 32;
            this.btnAggiungiMacchinaRimuoviComponenti.Text = "Rimuovi ";
            this.btnAggiungiMacchinaRimuoviComponenti.UseVisualStyleBackColor = false;
            this.btnAggiungiMacchinaRimuoviComponenti.Click += new System.EventHandler(this.btnAggiungiMacchinaRimuoviComponenti_Click);
            // 
            // btnAggiungiMacchinaAggiungiComponenti
            // 
            this.btnAggiungiMacchinaAggiungiComponenti.BackColor = System.Drawing.Color.Teal;
            this.btnAggiungiMacchinaAggiungiComponenti.FlatAppearance.BorderSize = 0;
            this.btnAggiungiMacchinaAggiungiComponenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiMacchinaAggiungiComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiMacchinaAggiungiComponenti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAggiungiMacchinaAggiungiComponenti.Location = new System.Drawing.Point(24, 305);
            this.btnAggiungiMacchinaAggiungiComponenti.Name = "btnAggiungiMacchinaAggiungiComponenti";
            this.btnAggiungiMacchinaAggiungiComponenti.Size = new System.Drawing.Size(107, 41);
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
            this.lblAggiungiMacchinaModello.Location = new System.Drawing.Point(159, 103);
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
            this.txBxAggiungiMacchinaModello.Size = new System.Drawing.Size(353, 26);
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
            this.btnChiudigBxAggiungiMacchine.Location = new System.Drawing.Point(358, 14);
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
            this.btnConfermaAggiungiMacchina.Location = new System.Drawing.Point(0, 666);
            this.btnConfermaAggiungiMacchina.Name = "btnConfermaAggiungiMacchina";
            this.btnConfermaAggiungiMacchina.Size = new System.Drawing.Size(380, 56);
            this.btnConfermaAggiungiMacchina.TabIndex = 12;
            this.btnConfermaAggiungiMacchina.Text = "Aggiungi";
            this.btnConfermaAggiungiMacchina.UseVisualStyleBackColor = false;
            this.btnConfermaAggiungiMacchina.Click += new System.EventHandler(this.btnConfermaAggiungiMacchina_Click);
            // 
            // gBxVisualizzaCliente
            // 
            this.gBxVisualizzaCliente.Controls.Add(this.dgvMostraComponentiMacchina);
            this.gBxVisualizzaCliente.Controls.Add(this.dgvMostraMacchineAccessori);
            this.gBxVisualizzaCliente.Controls.Add(this.lblMostraComponenti);
            this.gBxVisualizzaCliente.Controls.Add(this.chbxMostraNoleggio);
            this.gBxVisualizzaCliente.Controls.Add(this.rtbMostraNote);
            this.gBxVisualizzaCliente.Controls.Add(this.pbxAlloStoricoMacchina);
            this.gBxVisualizzaCliente.Controls.Add(this.lblMostraNote);
            this.gBxVisualizzaCliente.Controls.Add(this.pbxAlloStoricoCliente);
            this.gBxVisualizzaCliente.Controls.Add(this.lblMostraMacchineAccessori);
            this.gBxVisualizzaCliente.Controls.Add(this.lblMostraPrif);
            this.gBxVisualizzaCliente.Controls.Add(this.tbxMostraPrif);
            this.gBxVisualizzaCliente.Controls.Add(this.lblMostraIva);
            this.gBxVisualizzaCliente.Controls.Add(this.tbxMostraIva);
            this.gBxVisualizzaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBxVisualizzaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxVisualizzaCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBxVisualizzaCliente.Location = new System.Drawing.Point(0, 0);
            this.gBxVisualizzaCliente.Name = "gBxVisualizzaCliente";
            this.gBxVisualizzaCliente.Size = new System.Drawing.Size(383, 722);
            this.gBxVisualizzaCliente.TabIndex = 42;
            this.gBxVisualizzaCliente.TabStop = false;
            this.gBxVisualizzaCliente.Text = "Dettagli cliente";
            // 
            // lblMostraComponenti
            // 
            this.lblMostraComponenti.AutoSize = true;
            this.lblMostraComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraComponenti.ForeColor = System.Drawing.Color.White;
            this.lblMostraComponenti.Location = new System.Drawing.Point(18, 402);
            this.lblMostraComponenti.Name = "lblMostraComponenti";
            this.lblMostraComponenti.Size = new System.Drawing.Size(127, 25);
            this.lblMostraComponenti.TabIndex = 48;
            this.lblMostraComponenti.Text = "Componenti";
            // 
            // chbxMostraNoleggio
            // 
            this.chbxMostraNoleggio.AutoCheck = false;
            this.chbxMostraNoleggio.AutoSize = true;
            this.chbxMostraNoleggio.Location = new System.Drawing.Point(203, 577);
            this.chbxMostraNoleggio.Name = "chbxMostraNoleggio";
            this.chbxMostraNoleggio.Size = new System.Drawing.Size(116, 29);
            this.chbxMostraNoleggio.TabIndex = 50;
            this.chbxMostraNoleggio.Text = "Noleggio";
            this.chbxMostraNoleggio.UseVisualStyleBackColor = true;
            // 
            // rtbMostraNote
            // 
            this.rtbMostraNote.Location = new System.Drawing.Point(14, 607);
            this.rtbMostraNote.Name = "rtbMostraNote";
            this.rtbMostraNote.ReadOnly = true;
            this.rtbMostraNote.Size = new System.Drawing.Size(359, 109);
            this.rtbMostraNote.TabIndex = 49;
            this.rtbMostraNote.Text = "";
            // 
            // pbxAlloStoricoMacchina
            // 
            this.pbxAlloStoricoMacchina.BackColor = System.Drawing.Color.White;
            this.pbxAlloStoricoMacchina.ErrorImage = null;
            this.pbxAlloStoricoMacchina.Image = global::Calendario_AriBerg.Properties.Resources.Logo_AriGenda;
            this.pbxAlloStoricoMacchina.Location = new System.Drawing.Point(21, 106);
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
            this.lblMostraNote.Location = new System.Drawing.Point(19, 577);
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
            this.lblMostraMacchineAccessori.Location = new System.Drawing.Point(84, 119);
            this.lblMostraMacchineAccessori.Name = "lblMostraMacchineAccessori";
            this.lblMostraMacchineAccessori.Size = new System.Drawing.Size(211, 25);
            this.lblMostraMacchineAccessori.TabIndex = 41;
            this.lblMostraMacchineAccessori.Text = "Macchine/Accessori:";
            // 
            // lblMostraPrif
            // 
            this.lblMostraPrif.AutoSize = true;
            this.lblMostraPrif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraPrif.ForeColor = System.Drawing.Color.White;
            this.lblMostraPrif.Location = new System.Drawing.Point(8, 71);
            this.lblMostraPrif.Name = "lblMostraPrif";
            this.lblMostraPrif.Size = new System.Drawing.Size(64, 25);
            this.lblMostraPrif.TabIndex = 36;
            this.lblMostraPrif.Text = "P.Rif:";
            // 
            // tbxMostraPrif
            // 
            this.tbxMostraPrif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMostraPrif.Location = new System.Drawing.Point(100, 71);
            this.tbxMostraPrif.Name = "tbxMostraPrif";
            this.tbxMostraPrif.ReadOnly = true;
            this.tbxMostraPrif.Size = new System.Drawing.Size(273, 26);
            this.tbxMostraPrif.TabIndex = 35;
            // 
            // lblMostraIva
            // 
            this.lblMostraIva.AutoSize = true;
            this.lblMostraIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraIva.ForeColor = System.Drawing.Color.White;
            this.lblMostraIva.Location = new System.Drawing.Point(8, 36);
            this.lblMostraIva.Name = "lblMostraIva";
            this.lblMostraIva.Size = new System.Drawing.Size(63, 25);
            this.lblMostraIva.TabIndex = 34;
            this.lblMostraIva.Text = "  IVA:";
            // 
            // tbxMostraIva
            // 
            this.tbxMostraIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMostraIva.Location = new System.Drawing.Point(100, 35);
            this.tbxMostraIva.Name = "tbxMostraIva";
            this.tbxMostraIva.ReadOnly = true;
            this.tbxMostraIva.Size = new System.Drawing.Size(273, 26);
            this.tbxMostraIva.TabIndex = 33;
            // 
            // gBxModificaMacchina
            // 
            this.gBxModificaMacchina.Controls.Add(this.dataGridView3);
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
            this.gBxModificaMacchina.Controls.Add(this.btnModificaMacchinaAggiungiComponenti);
            this.gBxModificaMacchina.Controls.Add(this.lblModificaMacchinaModello);
            this.gBxModificaMacchina.Controls.Add(this.tbxModificaMacchinaModello);
            this.gBxModificaMacchina.Controls.Add(this.btnChiudigBxModificaMacchina);
            this.gBxModificaMacchina.Controls.Add(this.btnConfermaModificaMacchina);
            this.gBxModificaMacchina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBxModificaMacchina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxModificaMacchina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBxModificaMacchina.Location = new System.Drawing.Point(0, 0);
            this.gBxModificaMacchina.Name = "gBxModificaMacchina";
            this.gBxModificaMacchina.Size = new System.Drawing.Size(383, 722);
            this.gBxModificaMacchina.TabIndex = 48;
            this.gBxModificaMacchina.TabStop = false;
            this.gBxModificaMacchina.Text = "Modifica macchina/accessorio";
            this.gBxModificaMacchina.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 408);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(367, 122);
            this.dataGridView3.TabIndex = 48;
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
            this.cBxModificaMacchinaTipo.Size = new System.Drawing.Size(67, 28);
            this.cBxModificaMacchinaTipo.TabIndex = 47;
            // 
            // lblModificaMacchinaMarca
            // 
            this.lblModificaMacchinaMarca.AutoSize = true;
            this.lblModificaMacchinaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaMacchinaMarca.ForeColor = System.Drawing.Color.White;
            this.lblModificaMacchinaMarca.Location = new System.Drawing.Point(165, 34);
            this.lblModificaMacchinaMarca.Name = "lblModificaMacchinaMarca";
            this.lblModificaMacchinaMarca.Size = new System.Drawing.Size(72, 25);
            this.lblModificaMacchinaMarca.TabIndex = 46;
            this.lblModificaMacchinaMarca.Text = "Marca";
            // 
            // tbxModificaMacchinaMarca
            // 
            this.tbxModificaMacchinaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModificaMacchinaMarca.Location = new System.Drawing.Point(14, 69);
            this.tbxModificaMacchinaMarca.Name = "tbxModificaMacchinaMarca";
            this.tbxModificaMacchinaMarca.Size = new System.Drawing.Size(359, 26);
            this.tbxModificaMacchinaMarca.TabIndex = 45;
            // 
            // chBxModificaMacchinaNoleggio
            // 
            this.chBxModificaMacchinaNoleggio.AutoSize = true;
            this.chBxModificaMacchinaNoleggio.Location = new System.Drawing.Point(164, 239);
            this.chBxModificaMacchinaNoleggio.Name = "chBxModificaMacchinaNoleggio";
            this.chBxModificaMacchinaNoleggio.Size = new System.Drawing.Size(90, 24);
            this.chBxModificaMacchinaNoleggio.TabIndex = 44;
            this.chBxModificaMacchinaNoleggio.Text = "Noleggio";
            this.chBxModificaMacchinaNoleggio.UseVisualStyleBackColor = true;
            // 
            // txBxModificaMacchinaCodice
            // 
            this.txBxModificaMacchinaCodice.Location = new System.Drawing.Point(164, 369);
            this.txBxModificaMacchinaCodice.Name = "txBxModificaMacchinaCodice";
            this.txBxModificaMacchinaCodice.Size = new System.Drawing.Size(201, 26);
            this.txBxModificaMacchinaCodice.TabIndex = 43;
            // 
            // rtbModificaMacchinaNote
            // 
            this.rtbModificaMacchinaNote.Location = new System.Drawing.Point(6, 561);
            this.rtbModificaMacchinaNote.Name = "rtbModificaMacchinaNote";
            this.rtbModificaMacchinaNote.Size = new System.Drawing.Size(367, 96);
            this.rtbModificaMacchinaNote.TabIndex = 38;
            this.rtbModificaMacchinaNote.Text = "";
            // 
            // lblModificaMacchinaNote
            // 
            this.lblModificaMacchinaNote.AutoSize = true;
            this.lblModificaMacchinaNote.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblModificaMacchinaNote.Location = new System.Drawing.Point(166, 536);
            this.lblModificaMacchinaNote.Name = "lblModificaMacchinaNote";
            this.lblModificaMacchinaNote.Size = new System.Drawing.Size(47, 20);
            this.lblModificaMacchinaNote.TabIndex = 37;
            this.lblModificaMacchinaNote.Text = "Note:";
            // 
            // lblModificaMacchinaMatricola
            // 
            this.lblModificaMacchinaMatricola.AutoSize = true;
            this.lblModificaMacchinaMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaMacchinaMatricola.ForeColor = System.Drawing.Color.White;
            this.lblModificaMacchinaMatricola.Location = new System.Drawing.Point(153, 172);
            this.lblModificaMacchinaMatricola.Name = "lblModificaMacchinaMatricola";
            this.lblModificaMacchinaMatricola.Size = new System.Drawing.Size(100, 25);
            this.lblModificaMacchinaMatricola.TabIndex = 35;
            this.lblModificaMacchinaMatricola.Text = "Matricola";
            // 
            // tbxModificaMacchinaMatricola
            // 
            this.tbxModificaMacchinaMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModificaMacchinaMatricola.Location = new System.Drawing.Point(13, 204);
            this.tbxModificaMacchinaMatricola.Name = "tbxModificaMacchinaMatricola";
            this.tbxModificaMacchinaMatricola.Size = new System.Drawing.Size(360, 26);
            this.tbxModificaMacchinaMatricola.TabIndex = 34;
            // 
            // lblModificaMacchinaComponenti
            // 
            this.lblModificaMacchinaComponenti.AutoSize = true;
            this.lblModificaMacchinaComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificaMacchinaComponenti.ForeColor = System.Drawing.Color.White;
            this.lblModificaMacchinaComponenti.Location = new System.Drawing.Point(132, 273);
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
            this.btnModificaMacchinaRimuoviComponenti.Location = new System.Drawing.Point(6, 362);
            this.btnModificaMacchinaRimuoviComponenti.Name = "btnModificaMacchinaRimuoviComponenti";
            this.btnModificaMacchinaRimuoviComponenti.Size = new System.Drawing.Size(141, 40);
            this.btnModificaMacchinaRimuoviComponenti.TabIndex = 32;
            this.btnModificaMacchinaRimuoviComponenti.Text = "Rimuovi ";
            this.btnModificaMacchinaRimuoviComponenti.UseVisualStyleBackColor = false;
            // 
            // btnModificaMacchinaAggiungiComponenti
            // 
            this.btnModificaMacchinaAggiungiComponenti.BackColor = System.Drawing.Color.Teal;
            this.btnModificaMacchinaAggiungiComponenti.FlatAppearance.BorderSize = 0;
            this.btnModificaMacchinaAggiungiComponenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaMacchinaAggiungiComponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaMacchinaAggiungiComponenti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificaMacchinaAggiungiComponenti.Location = new System.Drawing.Point(6, 314);
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
            this.lblModificaMacchinaModello.Location = new System.Drawing.Point(159, 100);
            this.lblModificaMacchinaModello.Name = "lblModificaMacchinaModello";
            this.lblModificaMacchinaModello.Size = new System.Drawing.Size(88, 25);
            this.lblModificaMacchinaModello.TabIndex = 28;
            this.lblModificaMacchinaModello.Text = "Modello";
            // 
            // tbxModificaMacchinaModello
            // 
            this.tbxModificaMacchinaModello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModificaMacchinaModello.Location = new System.Drawing.Point(13, 132);
            this.tbxModificaMacchinaModello.Name = "tbxModificaMacchinaModello";
            this.tbxModificaMacchinaModello.Size = new System.Drawing.Size(360, 26);
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
            this.btnChiudigBxModificaMacchina.Location = new System.Drawing.Point(358, 11);
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
            this.btnConfermaModificaMacchina.Location = new System.Drawing.Point(0, 663);
            this.btnConfermaModificaMacchina.Name = "btnConfermaModificaMacchina";
            this.btnConfermaModificaMacchina.Size = new System.Drawing.Size(383, 56);
            this.btnConfermaModificaMacchina.TabIndex = 12;
            this.btnConfermaModificaMacchina.Text = "Modifica";
            this.btnConfermaModificaMacchina.UseVisualStyleBackColor = false;
            this.btnConfermaModificaMacchina.Click += new System.EventHandler(this.btnConfermaModificaMacchina_Click);
            // 
            // lblClienti
            // 
            this.lblClienti.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClienti.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienti.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClienti.Location = new System.Drawing.Point(3, 3);
            this.lblClienti.Name = "lblClienti";
            this.lblClienti.Size = new System.Drawing.Size(1429, 76);
            this.lblClienti.TabIndex = 49;
            this.lblClienti.Text = "label1";
            this.lblClienti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.gbxModificaComponente);
            this.tabPage3.Controls.Add(this.tbCtrlMagazzini);
            this.tabPage3.Controls.Add(this.lblMagazziniComponenti);
            this.tabPage3.Controls.Add(this.MidMagPanel);
            this.tabPage3.Controls.Add(this.LeftMagPanel);
            this.tabPage3.Controls.Add(this.pnlFiltriMagazzino);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.TopMagPanel);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1435, 804);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Componenti e Magazzini";
            // 
            // gbxModificaComponente
            // 
            this.gbxModificaComponente.Controls.Add(this.cbxModificaMarcaComponente);
            this.gbxModificaComponente.Controls.Add(this.btnModificaComponente);
            this.gbxModificaComponente.Controls.Add(this.label1);
            this.gbxModificaComponente.Controls.Add(this.nudModificaSoglia);
            this.gbxModificaComponente.Controls.Add(this.label2);
            this.gbxModificaComponente.Controls.Add(this.label3);
            this.gbxModificaComponente.Controls.Add(this.label4);
            this.gbxModificaComponente.Controls.Add(this.nudModificaNOrdine);
            this.gbxModificaComponente.Controls.Add(this.cbxModificaTipoComponente);
            this.gbxModificaComponente.Controls.Add(this.tbxModificaCodiceComponente);
            this.gbxModificaComponente.Controls.Add(this.label5);
            this.gbxModificaComponente.Controls.Add(this.btnExitEditComponente);
            this.gbxModificaComponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxModificaComponente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxModificaComponente.Location = new System.Drawing.Point(3, 85);
            this.gbxModificaComponente.Name = "gbxModificaComponente";
            this.gbxModificaComponente.Size = new System.Drawing.Size(556, 499);
            this.gbxModificaComponente.TabIndex = 57;
            this.gbxModificaComponente.TabStop = false;
            this.gbxModificaComponente.Text = "Modifica componente";
            this.gbxModificaComponente.Visible = false;
            // 
            // cbxModificaMarcaComponente
            // 
            this.cbxModificaMarcaComponente.FormattingEnabled = true;
            this.cbxModificaMarcaComponente.Location = new System.Drawing.Point(23, 232);
            this.cbxModificaMarcaComponente.Name = "cbxModificaMarcaComponente";
            this.cbxModificaMarcaComponente.Size = new System.Drawing.Size(492, 33);
            this.cbxModificaMarcaComponente.TabIndex = 56;
            // 
            // btnModificaComponente
            // 
            this.btnModificaComponente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificaComponente.BackColor = System.Drawing.Color.Goldenrod;
            this.btnModificaComponente.FlatAppearance.BorderSize = 0;
            this.btnModificaComponente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaComponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaComponente.Location = new System.Drawing.Point(0, 442);
            this.btnModificaComponente.Name = "btnModificaComponente";
            this.btnModificaComponente.Size = new System.Drawing.Size(556, 56);
            this.btnModificaComponente.TabIndex = 12;
            this.btnModificaComponente.Text = "Modifica";
            this.btnModificaComponente.UseVisualStyleBackColor = false;
            this.btnModificaComponente.Click += new System.EventHandler(this.btnModificaComponente_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Soglia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudModificaSoglia
            // 
            this.nudModificaSoglia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudModificaSoglia.Location = new System.Drawing.Point(23, 388);
            this.nudModificaSoglia.Name = "nudModificaSoglia";
            this.nudModificaSoglia.Size = new System.Drawing.Size(492, 31);
            this.nudModificaSoglia.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Marca";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(492, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Quantità da ordinare";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(492, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "Codice";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudModificaNOrdine
            // 
            this.nudModificaNOrdine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudModificaNOrdine.Location = new System.Drawing.Point(23, 306);
            this.nudModificaNOrdine.Name = "nudModificaNOrdine";
            this.nudModificaNOrdine.Size = new System.Drawing.Size(492, 31);
            this.nudModificaNOrdine.TabIndex = 49;
            // 
            // cbxModificaTipoComponente
            // 
            this.cbxModificaTipoComponente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxModificaTipoComponente.FormattingEnabled = true;
            this.cbxModificaTipoComponente.Location = new System.Drawing.Point(23, 140);
            this.cbxModificaTipoComponente.Name = "cbxModificaTipoComponente";
            this.cbxModificaTipoComponente.Size = new System.Drawing.Size(492, 33);
            this.cbxModificaTipoComponente.TabIndex = 48;
            // 
            // tbxModificaCodiceComponente
            // 
            this.tbxModificaCodiceComponente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxModificaCodiceComponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModificaCodiceComponente.Location = new System.Drawing.Point(23, 69);
            this.tbxModificaCodiceComponente.Name = "tbxModificaCodiceComponente";
            this.tbxModificaCodiceComponente.Size = new System.Drawing.Size(492, 26);
            this.tbxModificaCodiceComponente.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(492, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitEditComponente
            // 
            this.btnExitEditComponente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitEditComponente.BackColor = System.Drawing.Color.Red;
            this.btnExitEditComponente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitEditComponente.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnExitEditComponente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitEditComponente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExitEditComponente.Location = new System.Drawing.Point(531, 14);
            this.btnExitEditComponente.Name = "btnExitEditComponente";
            this.btnExitEditComponente.Size = new System.Drawing.Size(25, 25);
            this.btnExitEditComponente.TabIndex = 24;
            this.btnExitEditComponente.Text = "X";
            this.btnExitEditComponente.UseVisualStyleBackColor = false;
            this.btnExitEditComponente.Click += new System.EventHandler(this.btnExitEditComponente_Click);
            // 
            // tbCtrlMagazzini
            // 
            this.tbCtrlMagazzini.Controls.Add(this.Totale);
            this.tbCtrlMagazzini.Controls.Add(this.Centrale);
            this.tbCtrlMagazzini.Controls.Add(this.tabPage6);
            this.tbCtrlMagazzini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlMagazzini.Location = new System.Drawing.Point(890, 133);
            this.tbCtrlMagazzini.Name = "tbCtrlMagazzini";
            this.tbCtrlMagazzini.SelectedIndex = 0;
            this.tbCtrlMagazzini.Size = new System.Drawing.Size(542, 668);
            this.tbCtrlMagazzini.TabIndex = 45;
            this.tbCtrlMagazzini.SelectedIndexChanged += new System.EventHandler(this.tbCtrlMagazzini_SelectedIndexChanged);
            // 
            // Totale
            // 
            this.Totale.BackColor = System.Drawing.Color.IndianRed;
            this.Totale.Controls.Add(this.dgvMagazzinoTotale);
            this.Totale.Location = new System.Drawing.Point(4, 27);
            this.Totale.Name = "Totale";
            this.Totale.Size = new System.Drawing.Size(534, 637);
            this.Totale.TabIndex = 0;
            this.Totale.Text = "Totale";
            // 
            // dgvMagazzinoTotale
            // 
            this.dgvMagazzinoTotale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMagazzinoTotale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazzinoTotale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMagazzinoTotale.Location = new System.Drawing.Point(0, 0);
            this.dgvMagazzinoTotale.Margin = new System.Windows.Forms.Padding(0);
            this.dgvMagazzinoTotale.MultiSelect = false;
            this.dgvMagazzinoTotale.Name = "dgvMagazzinoTotale";
            this.dgvMagazzinoTotale.ReadOnly = true;
            this.dgvMagazzinoTotale.Size = new System.Drawing.Size(534, 637);
            this.dgvMagazzinoTotale.TabIndex = 0;
            this.dgvMagazzinoTotale.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMagazzinoTotale_CellDoubleClick);
            // 
            // Centrale
            // 
            this.Centrale.BackColor = System.Drawing.Color.IndianRed;
            this.Centrale.Controls.Add(this.dgvMagazzinoCentrale);
            this.Centrale.Location = new System.Drawing.Point(4, 27);
            this.Centrale.Name = "Centrale";
            this.Centrale.Size = new System.Drawing.Size(534, 637);
            this.Centrale.TabIndex = 1;
            this.Centrale.Text = "Centrale";
            // 
            // dgvMagazzinoCentrale
            // 
            this.dgvMagazzinoCentrale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMagazzinoCentrale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazzinoCentrale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMagazzinoCentrale.Location = new System.Drawing.Point(0, 0);
            this.dgvMagazzinoCentrale.Margin = new System.Windows.Forms.Padding(0);
            this.dgvMagazzinoCentrale.MultiSelect = false;
            this.dgvMagazzinoCentrale.Name = "dgvMagazzinoCentrale";
            this.dgvMagazzinoCentrale.ReadOnly = true;
            this.dgvMagazzinoCentrale.Size = new System.Drawing.Size(534, 637);
            this.dgvMagazzinoCentrale.TabIndex = 1;
            this.dgvMagazzinoCentrale.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMagazzinoCentrale_CellDoubleClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(534, 637);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Altri";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lblMagazziniComponenti
            // 
            this.lblMagazziniComponenti.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMagazziniComponenti.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazziniComponenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMagazziniComponenti.Location = new System.Drawing.Point(890, 79);
            this.lblMagazziniComponenti.Name = "lblMagazziniComponenti";
            this.lblMagazziniComponenti.Size = new System.Drawing.Size(542, 54);
            this.lblMagazziniComponenti.TabIndex = 50;
            this.lblMagazziniComponenti.Text = "Magazzini";
            this.lblMagazziniComponenti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MidMagPanel
            // 
            this.MidMagPanel.Controls.Add(this.gbxEditComponenti);
            this.MidMagPanel.Controls.Add(this.label7);
            this.MidMagPanel.Controls.Add(this.label6);
            this.MidMagPanel.Controls.Add(this.nudNumeroComponenti);
            this.MidMagPanel.Controls.Add(this.btnImmagazzinaComponente);
            this.MidMagPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MidMagPanel.Location = new System.Drawing.Point(773, 79);
            this.MidMagPanel.Name = "MidMagPanel";
            this.MidMagPanel.Size = new System.Drawing.Size(117, 722);
            this.MidMagPanel.TabIndex = 54;
            // 
            // gbxEditComponenti
            // 
            this.gbxEditComponenti.Controls.Add(this.btnCloseEditComponenti);
            this.gbxEditComponenti.Controls.Add(this.lblAggiornaComponentiMagazzino);
            this.gbxEditComponenti.Controls.Add(this.lblModificaComponentiMagazzino);
            this.gbxEditComponenti.Controls.Add(this.lblEliminaComponenteImmagazzinato);
            this.gbxEditComponenti.Controls.Add(this.btnEliminaComponenteImmagazzinato);
            this.gbxEditComponenti.Controls.Add(this.nudEditNcomponenti);
            this.gbxEditComponenti.Controls.Add(this.btnMenoComponenti);
            this.gbxEditComponenti.Controls.Add(this.btnPlusComponenti);
            this.gbxEditComponenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxEditComponenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxEditComponenti.Location = new System.Drawing.Point(0, 0);
            this.gbxEditComponenti.Name = "gbxEditComponenti";
            this.gbxEditComponenti.Size = new System.Drawing.Size(117, 722);
            this.gbxEditComponenti.TabIndex = 52;
            this.gbxEditComponenti.TabStop = false;
            this.gbxEditComponenti.Visible = false;
            // 
            // btnCloseEditComponenti
            // 
            this.btnCloseEditComponenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseEditComponenti.BackColor = System.Drawing.Color.Red;
            this.btnCloseEditComponenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEditComponenti.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCloseEditComponenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseEditComponenti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCloseEditComponenti.Location = new System.Drawing.Point(92, 6);
            this.btnCloseEditComponenti.Name = "btnCloseEditComponenti";
            this.btnCloseEditComponenti.Size = new System.Drawing.Size(25, 25);
            this.btnCloseEditComponenti.TabIndex = 57;
            this.btnCloseEditComponenti.Text = "X";
            this.btnCloseEditComponenti.UseVisualStyleBackColor = false;
            this.btnCloseEditComponenti.Click += new System.EventHandler(this.btnCloseEditComponenti_Click);
            // 
            // lblAggiornaComponentiMagazzino
            // 
            this.lblAggiornaComponentiMagazzino.Location = new System.Drawing.Point(6, 14);
            this.lblAggiornaComponentiMagazzino.Name = "lblAggiornaComponentiMagazzino";
            this.lblAggiornaComponentiMagazzino.Size = new System.Drawing.Size(105, 67);
            this.lblAggiornaComponentiMagazzino.TabIndex = 6;
            this.lblAggiornaComponentiMagazzino.Text = "Aggiorna componente selezionato";
            this.lblAggiornaComponentiMagazzino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModificaComponentiMagazzino
            // 
            this.lblModificaComponentiMagazzino.Location = new System.Drawing.Point(20, 118);
            this.lblModificaComponentiMagazzino.Name = "lblModificaComponentiMagazzino";
            this.lblModificaComponentiMagazzino.Size = new System.Drawing.Size(66, 36);
            this.lblModificaComponentiMagazzino.TabIndex = 5;
            this.lblModificaComponentiMagazzino.Text = "Modifica Quantità:";
            // 
            // lblEliminaComponenteImmagazzinato
            // 
            this.lblEliminaComponenteImmagazzinato.AutoSize = true;
            this.lblEliminaComponenteImmagazzinato.Location = new System.Drawing.Point(32, 388);
            this.lblEliminaComponenteImmagazzinato.Name = "lblEliminaComponenteImmagazzinato";
            this.lblEliminaComponenteImmagazzinato.Size = new System.Drawing.Size(54, 18);
            this.lblEliminaComponenteImmagazzinato.TabIndex = 4;
            this.lblEliminaComponenteImmagazzinato.Text = "Elimina";
            // 
            // btnEliminaComponenteImmagazzinato
            // 
            this.btnEliminaComponenteImmagazzinato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminaComponenteImmagazzinato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaComponenteImmagazzinato.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaComponenteImmagazzinato.Location = new System.Drawing.Point(19, 420);
            this.btnEliminaComponenteImmagazzinato.Name = "btnEliminaComponenteImmagazzinato";
            this.btnEliminaComponenteImmagazzinato.Size = new System.Drawing.Size(77, 67);
            this.btnEliminaComponenteImmagazzinato.TabIndex = 3;
            this.btnEliminaComponenteImmagazzinato.Text = "X";
            this.btnEliminaComponenteImmagazzinato.UseVisualStyleBackColor = false;
            this.btnEliminaComponenteImmagazzinato.Click += new System.EventHandler(this.btnEliminaComponenteImmagazzinato_Click);
            // 
            // nudEditNcomponenti
            // 
            this.nudEditNcomponenti.Location = new System.Drawing.Point(19, 157);
            this.nudEditNcomponenti.Name = "nudEditNcomponenti";
            this.nudEditNcomponenti.Size = new System.Drawing.Size(77, 26);
            this.nudEditNcomponenti.TabIndex = 2;
            // 
            // btnMenoComponenti
            // 
            this.btnMenoComponenti.BackColor = System.Drawing.Color.Red;
            this.btnMenoComponenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenoComponenti.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenoComponenti.Location = new System.Drawing.Point(19, 260);
            this.btnMenoComponenti.Name = "btnMenoComponenti";
            this.btnMenoComponenti.Size = new System.Drawing.Size(77, 53);
            this.btnMenoComponenti.TabIndex = 1;
            this.btnMenoComponenti.Text = "-";
            this.btnMenoComponenti.UseVisualStyleBackColor = false;
            this.btnMenoComponenti.Click += new System.EventHandler(this.btnMenoComponenti_Click);
            // 
            // btnPlusComponenti
            // 
            this.btnPlusComponenti.BackColor = System.Drawing.Color.Lime;
            this.btnPlusComponenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusComponenti.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusComponenti.Location = new System.Drawing.Point(19, 198);
            this.btnPlusComponenti.Name = "btnPlusComponenti";
            this.btnPlusComponenti.Size = new System.Drawing.Size(77, 56);
            this.btnPlusComponenti.TabIndex = 0;
            this.btnPlusComponenti.Text = "+";
            this.btnPlusComponenti.UseVisualStyleBackColor = false;
            this.btnPlusComponenti.Click += new System.EventHandler(this.btnPlusComponenti_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(28, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 53;
            this.label7.Text = "Quantità";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(0, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 68);
            this.label6.TabIndex = 52;
            this.label6.Text = "Immagazzina componente selezionato";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudNumeroComponenti
            // 
            this.nudNumeroComponenti.Location = new System.Drawing.Point(25, 124);
            this.nudNumeroComponenti.Name = "nudNumeroComponenti";
            this.nudNumeroComponenti.Size = new System.Drawing.Size(64, 26);
            this.nudNumeroComponenti.TabIndex = 51;
            // 
            // btnImmagazzinaComponente
            // 
            this.btnImmagazzinaComponente.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImmagazzinaComponente.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.componenti_transfer;
            this.btnImmagazzinaComponente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImmagazzinaComponente.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImmagazzinaComponente.FlatAppearance.BorderSize = 3;
            this.btnImmagazzinaComponente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImmagazzinaComponente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImmagazzinaComponente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImmagazzinaComponente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnImmagazzinaComponente.Location = new System.Drawing.Point(25, 171);
            this.btnImmagazzinaComponente.Name = "btnImmagazzinaComponente";
            this.btnImmagazzinaComponente.Size = new System.Drawing.Size(64, 73);
            this.btnImmagazzinaComponente.TabIndex = 1;
            this.btnImmagazzinaComponente.UseVisualStyleBackColor = false;
            this.btnImmagazzinaComponente.Click += new System.EventHandler(this.btnImmagazzinaComponente_Click);
            // 
            // LeftMagPanel
            // 
            this.LeftMagPanel.Controls.Add(this.PnlCatalogo);
            this.LeftMagPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMagPanel.Location = new System.Drawing.Point(3, 79);
            this.LeftMagPanel.Name = "LeftMagPanel";
            this.LeftMagPanel.Size = new System.Drawing.Size(770, 722);
            this.LeftMagPanel.TabIndex = 52;
            // 
            // PnlCatalogo
            // 
            this.PnlCatalogo.Controls.Add(this.gBxAggiungiComponente);
            this.PnlCatalogo.Controls.Add(this.dgvComponenti);
            this.PnlCatalogo.Controls.Add(this.lblCatalogoComponenti);
            this.PnlCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCatalogo.Location = new System.Drawing.Point(0, 0);
            this.PnlCatalogo.Name = "PnlCatalogo";
            this.PnlCatalogo.Size = new System.Drawing.Size(770, 722);
            this.PnlCatalogo.TabIndex = 52;
            // 
            // gBxAggiungiComponente
            // 
            this.gBxAggiungiComponente.Controls.Add(this.cbxAggiungiMarcaComponente);
            this.gBxAggiungiComponente.Controls.Add(this.btnAggiungiComponente);
            this.gBxAggiungiComponente.Controls.Add(this.lblAggiungiComponenteSoglia);
            this.gBxAggiungiComponente.Controls.Add(this.nudAggiungiComponenteSoglia);
            this.gBxAggiungiComponente.Controls.Add(this.lblAggiungiComponenteMarca);
            this.gBxAggiungiComponente.Controls.Add(this.lblAggiungiComponenteNOrdine);
            this.gBxAggiungiComponente.Controls.Add(this.lblAggiungiComponenteCodice);
            this.gBxAggiungiComponente.Controls.Add(this.nudAggiungiComponenteNOrdine);
            this.gBxAggiungiComponente.Controls.Add(this.cbxAggiungiComponenteTipo);
            this.gBxAggiungiComponente.Controls.Add(this.tbxAggiungiComponenteCodice);
            this.gBxAggiungiComponente.Controls.Add(this.lblAggiungiComponenteTipo);
            this.gBxAggiungiComponente.Controls.Add(this.btnExitAggiungiComponente);
            this.gBxAggiungiComponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxAggiungiComponente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBxAggiungiComponente.Location = new System.Drawing.Point(0, 3);
            this.gBxAggiungiComponente.Name = "gBxAggiungiComponente";
            this.gBxAggiungiComponente.Size = new System.Drawing.Size(556, 502);
            this.gBxAggiungiComponente.TabIndex = 44;
            this.gBxAggiungiComponente.TabStop = false;
            this.gBxAggiungiComponente.Text = "Aggiungi componente";
            this.gBxAggiungiComponente.Visible = false;
            // 
            // cbxAggiungiMarcaComponente
            // 
            this.cbxAggiungiMarcaComponente.FormattingEnabled = true;
            this.cbxAggiungiMarcaComponente.Location = new System.Drawing.Point(23, 233);
            this.cbxAggiungiMarcaComponente.Name = "cbxAggiungiMarcaComponente";
            this.cbxAggiungiMarcaComponente.Size = new System.Drawing.Size(492, 33);
            this.cbxAggiungiMarcaComponente.TabIndex = 57;
            // 
            // btnAggiungiComponente
            // 
            this.btnAggiungiComponente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungiComponente.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAggiungiComponente.FlatAppearance.BorderSize = 0;
            this.btnAggiungiComponente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiComponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiComponente.Location = new System.Drawing.Point(0, 445);
            this.btnAggiungiComponente.Name = "btnAggiungiComponente";
            this.btnAggiungiComponente.Size = new System.Drawing.Size(556, 56);
            this.btnAggiungiComponente.TabIndex = 12;
            this.btnAggiungiComponente.Text = "Aggiungi";
            this.btnAggiungiComponente.UseVisualStyleBackColor = false;
            this.btnAggiungiComponente.Click += new System.EventHandler(this.btnAggiungiComponente_Click);
            // 
            // lblAggiungiComponenteSoglia
            // 
            this.lblAggiungiComponenteSoglia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAggiungiComponenteSoglia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiComponenteSoglia.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiComponenteSoglia.Location = new System.Drawing.Point(23, 360);
            this.lblAggiungiComponenteSoglia.Name = "lblAggiungiComponenteSoglia";
            this.lblAggiungiComponenteSoglia.Size = new System.Drawing.Size(492, 25);
            this.lblAggiungiComponenteSoglia.TabIndex = 55;
            this.lblAggiungiComponenteSoglia.Text = "Soglia";
            this.lblAggiungiComponenteSoglia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAggiungiComponenteSoglia
            // 
            this.nudAggiungiComponenteSoglia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAggiungiComponenteSoglia.Location = new System.Drawing.Point(23, 388);
            this.nudAggiungiComponenteSoglia.Name = "nudAggiungiComponenteSoglia";
            this.nudAggiungiComponenteSoglia.Size = new System.Drawing.Size(492, 31);
            this.nudAggiungiComponenteSoglia.TabIndex = 54;
            // 
            // lblAggiungiComponenteMarca
            // 
            this.lblAggiungiComponenteMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAggiungiComponenteMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiComponenteMarca.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiComponenteMarca.Location = new System.Drawing.Point(23, 193);
            this.lblAggiungiComponenteMarca.Name = "lblAggiungiComponenteMarca";
            this.lblAggiungiComponenteMarca.Size = new System.Drawing.Size(492, 25);
            this.lblAggiungiComponenteMarca.TabIndex = 53;
            this.lblAggiungiComponenteMarca.Text = "Marca";
            this.lblAggiungiComponenteMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAggiungiComponenteNOrdine
            // 
            this.lblAggiungiComponenteNOrdine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAggiungiComponenteNOrdine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiComponenteNOrdine.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiComponenteNOrdine.Location = new System.Drawing.Point(23, 278);
            this.lblAggiungiComponenteNOrdine.Name = "lblAggiungiComponenteNOrdine";
            this.lblAggiungiComponenteNOrdine.Size = new System.Drawing.Size(492, 25);
            this.lblAggiungiComponenteNOrdine.TabIndex = 52;
            this.lblAggiungiComponenteNOrdine.Text = "Quantità da ordinare";
            this.lblAggiungiComponenteNOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAggiungiComponenteCodice
            // 
            this.lblAggiungiComponenteCodice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAggiungiComponenteCodice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiComponenteCodice.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiComponenteCodice.Location = new System.Drawing.Point(23, 41);
            this.lblAggiungiComponenteCodice.Name = "lblAggiungiComponenteCodice";
            this.lblAggiungiComponenteCodice.Size = new System.Drawing.Size(492, 25);
            this.lblAggiungiComponenteCodice.TabIndex = 51;
            this.lblAggiungiComponenteCodice.Text = "Codice";
            this.lblAggiungiComponenteCodice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAggiungiComponenteNOrdine
            // 
            this.nudAggiungiComponenteNOrdine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAggiungiComponenteNOrdine.Location = new System.Drawing.Point(23, 306);
            this.nudAggiungiComponenteNOrdine.Name = "nudAggiungiComponenteNOrdine";
            this.nudAggiungiComponenteNOrdine.Size = new System.Drawing.Size(492, 31);
            this.nudAggiungiComponenteNOrdine.TabIndex = 49;
            // 
            // cbxAggiungiComponenteTipo
            // 
            this.cbxAggiungiComponenteTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAggiungiComponenteTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxAggiungiComponenteTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAggiungiComponenteTipo.FormattingEnabled = true;
            this.cbxAggiungiComponenteTipo.Location = new System.Drawing.Point(23, 140);
            this.cbxAggiungiComponenteTipo.Name = "cbxAggiungiComponenteTipo";
            this.cbxAggiungiComponenteTipo.Size = new System.Drawing.Size(492, 33);
            this.cbxAggiungiComponenteTipo.TabIndex = 48;
            // 
            // tbxAggiungiComponenteCodice
            // 
            this.tbxAggiungiComponenteCodice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAggiungiComponenteCodice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAggiungiComponenteCodice.Location = new System.Drawing.Point(23, 69);
            this.tbxAggiungiComponenteCodice.Name = "tbxAggiungiComponenteCodice";
            this.tbxAggiungiComponenteCodice.Size = new System.Drawing.Size(492, 26);
            this.tbxAggiungiComponenteCodice.TabIndex = 34;
            // 
            // lblAggiungiComponenteTipo
            // 
            this.lblAggiungiComponenteTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAggiungiComponenteTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggiungiComponenteTipo.ForeColor = System.Drawing.Color.White;
            this.lblAggiungiComponenteTipo.Location = new System.Drawing.Point(23, 112);
            this.lblAggiungiComponenteTipo.Name = "lblAggiungiComponenteTipo";
            this.lblAggiungiComponenteTipo.Size = new System.Drawing.Size(492, 25);
            this.lblAggiungiComponenteTipo.TabIndex = 28;
            this.lblAggiungiComponenteTipo.Text = "Tipo";
            this.lblAggiungiComponenteTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitAggiungiComponente
            // 
            this.btnExitAggiungiComponente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitAggiungiComponente.BackColor = System.Drawing.Color.Red;
            this.btnExitAggiungiComponente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitAggiungiComponente.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnExitAggiungiComponente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitAggiungiComponente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExitAggiungiComponente.Location = new System.Drawing.Point(531, 14);
            this.btnExitAggiungiComponente.Name = "btnExitAggiungiComponente";
            this.btnExitAggiungiComponente.Size = new System.Drawing.Size(25, 25);
            this.btnExitAggiungiComponente.TabIndex = 24;
            this.btnExitAggiungiComponente.Text = "X";
            this.btnExitAggiungiComponente.UseVisualStyleBackColor = false;
            this.btnExitAggiungiComponente.Click += new System.EventHandler(this.btnExitAggiungiComponente_Click);
            // 
            // dgvComponenti
            // 
            this.dgvComponenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComponenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComponenti.Location = new System.Drawing.Point(0, 39);
            this.dgvComponenti.MultiSelect = false;
            this.dgvComponenti.Name = "dgvComponenti";
            this.dgvComponenti.ReadOnly = true;
            this.dgvComponenti.Size = new System.Drawing.Size(770, 683);
            this.dgvComponenti.TabIndex = 47;
            // 
            // lblCatalogoComponenti
            // 
            this.lblCatalogoComponenti.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCatalogoComponenti.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogoComponenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCatalogoComponenti.Location = new System.Drawing.Point(0, 0);
            this.lblCatalogoComponenti.Name = "lblCatalogoComponenti";
            this.lblCatalogoComponenti.Size = new System.Drawing.Size(770, 39);
            this.lblCatalogoComponenti.TabIndex = 49;
            this.lblCatalogoComponenti.Text = "Catalogo";
            this.lblCatalogoComponenti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFiltriMagazzino
            // 
            this.pnlFiltriMagazzino.BackColor = System.Drawing.Color.DimGray;
            this.pnlFiltriMagazzino.Controls.Add(this.cbBxFiltroMagazzinoMarca);
            this.pnlFiltriMagazzino.Controls.Add(this.panel3);
            this.pnlFiltriMagazzino.Controls.Add(this.chBxFiltroMagazzinoCodice);
            this.pnlFiltriMagazzino.Controls.Add(this.chBxFiltroMagazzinoMarca);
            this.pnlFiltriMagazzino.Controls.Add(this.chBxFiltroMagazzinoTipo);
            this.pnlFiltriMagazzino.Controls.Add(this.chBxSottoSoglia);
            this.pnlFiltriMagazzino.Controls.Add(this.btnSearchComponenti);
            this.pnlFiltriMagazzino.Controls.Add(this.cbBxFiltroMagazzinoCodice);
            this.pnlFiltriMagazzino.Controls.Add(this.cbBxFiltroMagazzinoTipo);
            this.pnlFiltriMagazzino.ForeColor = System.Drawing.Color.White;
            this.pnlFiltriMagazzino.Location = new System.Drawing.Point(219, 6);
            this.pnlFiltriMagazzino.Name = "pnlFiltriMagazzino";
            this.pnlFiltriMagazzino.Size = new System.Drawing.Size(746, 73);
            this.pnlFiltriMagazzino.TabIndex = 48;
            // 
            // cbBxFiltroMagazzinoMarca
            // 
            this.cbBxFiltroMagazzinoMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBxFiltroMagazzinoMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBxFiltroMagazzinoMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBxFiltroMagazzinoMarca.Enabled = false;
            this.cbBxFiltroMagazzinoMarca.FormattingEnabled = true;
            this.cbBxFiltroMagazzinoMarca.Location = new System.Drawing.Point(78, 38);
            this.cbBxFiltroMagazzinoMarca.Name = "cbBxFiltroMagazzinoMarca";
            this.cbBxFiltroMagazzinoMarca.Size = new System.Drawing.Size(170, 26);
            this.cbBxFiltroMagazzinoMarca.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.chbxFiltroAMagazzino);
            this.panel3.Controls.Add(this.chbxFiltroACatalogo);
            this.panel3.Location = new System.Drawing.Point(500, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 60);
            this.panel3.TabIndex = 35;
            // 
            // chbxFiltroAMagazzino
            // 
            this.chbxFiltroAMagazzino.AutoSize = true;
            this.chbxFiltroAMagazzino.Location = new System.Drawing.Point(12, 32);
            this.chbxFiltroAMagazzino.Name = "chbxFiltroAMagazzino";
            this.chbxFiltroAMagazzino.Size = new System.Drawing.Size(151, 22);
            this.chbxFiltroAMagazzino.TabIndex = 34;
            this.chbxFiltroAMagazzino.Text = "Applica a magazzino";
            this.chbxFiltroAMagazzino.UseVisualStyleBackColor = true;
            // 
            // chbxFiltroACatalogo
            // 
            this.chbxFiltroACatalogo.AutoSize = true;
            this.chbxFiltroACatalogo.Location = new System.Drawing.Point(12, 5);
            this.chbxFiltroACatalogo.Name = "chbxFiltroACatalogo";
            this.chbxFiltroACatalogo.Size = new System.Drawing.Size(138, 22);
            this.chbxFiltroACatalogo.TabIndex = 33;
            this.chbxFiltroACatalogo.Text = "Applica a catalogo";
            this.chbxFiltroACatalogo.UseVisualStyleBackColor = true;
            // 
            // chBxFiltroMagazzinoCodice
            // 
            this.chBxFiltroMagazzinoCodice.AutoSize = true;
            this.chBxFiltroMagazzinoCodice.Location = new System.Drawing.Point(8, 10);
            this.chBxFiltroMagazzinoCodice.Name = "chBxFiltroMagazzinoCodice";
            this.chBxFiltroMagazzinoCodice.Size = new System.Drawing.Size(69, 22);
            this.chBxFiltroMagazzinoCodice.TabIndex = 32;
            this.chBxFiltroMagazzinoCodice.Text = "Codice";
            this.chBxFiltroMagazzinoCodice.UseVisualStyleBackColor = true;
            this.chBxFiltroMagazzinoCodice.CheckedChanged += new System.EventHandler(this.chBxFiltroMagazzinoCodice_CheckedChanged);
            // 
            // chBxFiltroMagazzinoMarca
            // 
            this.chBxFiltroMagazzinoMarca.AutoSize = true;
            this.chBxFiltroMagazzinoMarca.Location = new System.Drawing.Point(8, 40);
            this.chBxFiltroMagazzinoMarca.Name = "chBxFiltroMagazzinoMarca";
            this.chBxFiltroMagazzinoMarca.Size = new System.Drawing.Size(64, 22);
            this.chBxFiltroMagazzinoMarca.TabIndex = 28;
            this.chBxFiltroMagazzinoMarca.Text = "Marca";
            this.chBxFiltroMagazzinoMarca.UseVisualStyleBackColor = true;
            this.chBxFiltroMagazzinoMarca.CheckedChanged += new System.EventHandler(this.chBxFiltroMagazzinoMarca_CheckedChanged);
            // 
            // chBxFiltroMagazzinoTipo
            // 
            this.chBxFiltroMagazzinoTipo.AutoSize = true;
            this.chBxFiltroMagazzinoTipo.Location = new System.Drawing.Point(255, 40);
            this.chBxFiltroMagazzinoTipo.Name = "chBxFiltroMagazzinoTipo";
            this.chBxFiltroMagazzinoTipo.Size = new System.Drawing.Size(54, 22);
            this.chBxFiltroMagazzinoTipo.TabIndex = 27;
            this.chBxFiltroMagazzinoTipo.Text = "Tipo";
            this.chBxFiltroMagazzinoTipo.UseVisualStyleBackColor = true;
            this.chBxFiltroMagazzinoTipo.CheckedChanged += new System.EventHandler(this.chBxFiltroMagazzinoTipo_CheckedChanged);
            // 
            // chBxSottoSoglia
            // 
            this.chBxSottoSoglia.AutoSize = true;
            this.chBxSottoSoglia.Location = new System.Drawing.Point(352, 9);
            this.chBxSottoSoglia.Name = "chBxSottoSoglia";
            this.chBxSottoSoglia.Size = new System.Drawing.Size(100, 22);
            this.chBxSottoSoglia.TabIndex = 31;
            this.chBxSottoSoglia.Text = "Sotto Soglia";
            this.chBxSottoSoglia.UseVisualStyleBackColor = true;
            // 
            // btnSearchComponenti
            // 
            this.btnSearchComponenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchComponenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearchComponenti.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.search_icon;
            this.btnSearchComponenti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchComponenti.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearchComponenti.FlatAppearance.BorderSize = 15;
            this.btnSearchComponenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchComponenti.Location = new System.Drawing.Point(675, 5);
            this.btnSearchComponenti.Name = "btnSearchComponenti";
            this.btnSearchComponenti.Size = new System.Drawing.Size(66, 59);
            this.btnSearchComponenti.TabIndex = 25;
            this.btnSearchComponenti.UseVisualStyleBackColor = false;
            this.btnSearchComponenti.Click += new System.EventHandler(this.btnSearchComponenti_Click);
            // 
            // cbBxFiltroMagazzinoCodice
            // 
            this.cbBxFiltroMagazzinoCodice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBxFiltroMagazzinoCodice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBxFiltroMagazzinoCodice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBxFiltroMagazzinoCodice.Enabled = false;
            this.cbBxFiltroMagazzinoCodice.FormattingEnabled = true;
            this.cbBxFiltroMagazzinoCodice.Location = new System.Drawing.Point(78, 5);
            this.cbBxFiltroMagazzinoCodice.Name = "cbBxFiltroMagazzinoCodice";
            this.cbBxFiltroMagazzinoCodice.Size = new System.Drawing.Size(231, 26);
            this.cbBxFiltroMagazzinoCodice.TabIndex = 30;
            // 
            // cbBxFiltroMagazzinoTipo
            // 
            this.cbBxFiltroMagazzinoTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBxFiltroMagazzinoTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBxFiltroMagazzinoTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBxFiltroMagazzinoTipo.Enabled = false;
            this.cbBxFiltroMagazzinoTipo.FormattingEnabled = true;
            this.cbBxFiltroMagazzinoTipo.Location = new System.Drawing.Point(315, 37);
            this.cbBxFiltroMagazzinoTipo.Name = "cbBxFiltroMagazzinoTipo";
            this.cbBxFiltroMagazzinoTipo.Size = new System.Drawing.Size(170, 26);
            this.cbBxFiltroMagazzinoTipo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnAddComponente);
            this.panel1.Controls.Add(this.btnModifyComponente);
            this.panel1.Controls.Add(this.btnRemoveComponente);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 75);
            this.panel1.TabIndex = 46;
            // 
            // btnAddComponente
            // 
            this.btnAddComponente.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddComponente.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.componente_add;
            this.btnAddComponente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddComponente.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAddComponente.FlatAppearance.BorderSize = 3;
            this.btnAddComponente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComponente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComponente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddComponente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddComponente.Location = new System.Drawing.Point(6, 6);
            this.btnAddComponente.Name = "btnAddComponente";
            this.btnAddComponente.Size = new System.Drawing.Size(60, 60);
            this.btnAddComponente.TabIndex = 1;
            this.btnAddComponente.UseVisualStyleBackColor = false;
            this.btnAddComponente.Click += new System.EventHandler(this.btnAddComponente_Click);
            // 
            // btnModifyComponente
            // 
            this.btnModifyComponente.BackColor = System.Drawing.Color.Goldenrod;
            this.btnModifyComponente.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.componente_edit;
            this.btnModifyComponente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModifyComponente.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnModifyComponente.FlatAppearance.BorderSize = 3;
            this.btnModifyComponente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyComponente.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnModifyComponente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifyComponente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModifyComponente.Location = new System.Drawing.Point(72, 6);
            this.btnModifyComponente.Name = "btnModifyComponente";
            this.btnModifyComponente.Size = new System.Drawing.Size(60, 60);
            this.btnModifyComponente.TabIndex = 2;
            this.btnModifyComponente.UseVisualStyleBackColor = false;
            this.btnModifyComponente.Click += new System.EventHandler(this.btnModifyComponente_Click);
            // 
            // btnRemoveComponente
            // 
            this.btnRemoveComponente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveComponente.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.componente_remove;
            this.btnRemoveComponente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveComponente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveComponente.FlatAppearance.BorderSize = 3;
            this.btnRemoveComponente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveComponente.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnRemoveComponente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveComponente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemoveComponente.Location = new System.Drawing.Point(138, 6);
            this.btnRemoveComponente.Name = "btnRemoveComponente";
            this.btnRemoveComponente.Size = new System.Drawing.Size(60, 60);
            this.btnRemoveComponente.TabIndex = 3;
            this.btnRemoveComponente.UseVisualStyleBackColor = false;
            this.btnRemoveComponente.Click += new System.EventHandler(this.btnRemoveComponente_Click);
            // 
            // TopMagPanel
            // 
            this.TopMagPanel.Controls.Add(this.panel2);
            this.TopMagPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMagPanel.Location = new System.Drawing.Point(3, 3);
            this.TopMagPanel.Name = "TopMagPanel";
            this.TopMagPanel.Size = new System.Drawing.Size(1429, 76);
            this.TopMagPanel.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.btnCancellaNomeMagazzino);
            this.panel2.Controls.Add(this.tbxNomeMagazzino);
            this.panel2.Controls.Add(this.btnEliminaMagazzino);
            this.panel2.Controls.Add(this.btnAggiungiMagazzino);
            this.panel2.Controls.Add(this.btnModificaMagazzino);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(968, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 72);
            this.panel2.TabIndex = 49;
            // 
            // btnCancellaNomeMagazzino
            // 
            this.btnCancellaNomeMagazzino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancellaNomeMagazzino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancellaNomeMagazzino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancellaNomeMagazzino.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancellaNomeMagazzino.FlatAppearance.BorderSize = 0;
            this.btnCancellaNomeMagazzino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancellaNomeMagazzino.ForeColor = System.Drawing.Color.Black;
            this.btnCancellaNomeMagazzino.Location = new System.Drawing.Point(221, 41);
            this.btnCancellaNomeMagazzino.Name = "btnCancellaNomeMagazzino";
            this.btnCancellaNomeMagazzino.Size = new System.Drawing.Size(162, 24);
            this.btnCancellaNomeMagazzino.TabIndex = 29;
            this.btnCancellaNomeMagazzino.Text = "Cancella";
            this.btnCancellaNomeMagazzino.UseVisualStyleBackColor = false;
            this.btnCancellaNomeMagazzino.Click += new System.EventHandler(this.btnCancellaNomeMagazzino_Click);
            // 
            // tbxNomeMagazzino
            // 
            this.tbxNomeMagazzino.Location = new System.Drawing.Point(221, 10);
            this.tbxNomeMagazzino.Name = "tbxNomeMagazzino";
            this.tbxNomeMagazzino.Size = new System.Drawing.Size(162, 26);
            this.tbxNomeMagazzino.TabIndex = 28;
            // 
            // btnEliminaMagazzino
            // 
            this.btnEliminaMagazzino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminaMagazzino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminaMagazzino.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.magazzino_delete;
            this.btnEliminaMagazzino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminaMagazzino.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminaMagazzino.FlatAppearance.BorderSize = 3;
            this.btnEliminaMagazzino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaMagazzino.Location = new System.Drawing.Point(149, 9);
            this.btnEliminaMagazzino.Name = "btnEliminaMagazzino";
            this.btnEliminaMagazzino.Size = new System.Drawing.Size(66, 58);
            this.btnEliminaMagazzino.TabIndex = 27;
            this.btnEliminaMagazzino.UseVisualStyleBackColor = false;
            this.btnEliminaMagazzino.Click += new System.EventHandler(this.btnEliminaMagazzino_Click);
            // 
            // btnAggiungiMagazzino
            // 
            this.btnAggiungiMagazzino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiungiMagazzino.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAggiungiMagazzino.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.magazzino_add;
            this.btnAggiungiMagazzino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAggiungiMagazzino.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAggiungiMagazzino.FlatAppearance.BorderSize = 3;
            this.btnAggiungiMagazzino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiMagazzino.Location = new System.Drawing.Point(5, 9);
            this.btnAggiungiMagazzino.Name = "btnAggiungiMagazzino";
            this.btnAggiungiMagazzino.Size = new System.Drawing.Size(66, 58);
            this.btnAggiungiMagazzino.TabIndex = 26;
            this.btnAggiungiMagazzino.UseVisualStyleBackColor = false;
            this.btnAggiungiMagazzino.Click += new System.EventHandler(this.btnAggiungiMagazzino_Click);
            // 
            // btnModificaMagazzino
            // 
            this.btnModificaMagazzino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificaMagazzino.BackColor = System.Drawing.Color.Goldenrod;
            this.btnModificaMagazzino.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.magazzino_edit;
            this.btnModificaMagazzino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificaMagazzino.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnModificaMagazzino.FlatAppearance.BorderSize = 3;
            this.btnModificaMagazzino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaMagazzino.Location = new System.Drawing.Point(77, 9);
            this.btnModificaMagazzino.Name = "btnModificaMagazzino";
            this.btnModificaMagazzino.Size = new System.Drawing.Size(66, 58);
            this.btnModificaMagazzino.TabIndex = 25;
            this.btnModificaMagazzino.UseVisualStyleBackColor = false;
            this.btnModificaMagazzino.Click += new System.EventHandler(this.btnModificaMagazzino_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage7.Controls.Add(this.dgvTipiComponenti);
            this.tabPage7.Controls.Add(this.dgvMarcheComponenti);
            this.tabPage7.Controls.Add(this.topPanelAltro);
            this.tabPage7.Location = new System.Drawing.Point(4, 27);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1435, 804);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "Altro";
            // 
            // dgvTipiComponenti
            // 
            this.dgvTipiComponenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipiComponenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipiComponenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipiComponenti.Location = new System.Drawing.Point(707, 102);
            this.dgvTipiComponenti.MultiSelect = false;
            this.dgvTipiComponenti.Name = "dgvTipiComponenti";
            this.dgvTipiComponenti.ReadOnly = true;
            this.dgvTipiComponenti.Size = new System.Drawing.Size(725, 699);
            this.dgvTipiComponenti.TabIndex = 51;
            this.dgvTipiComponenti.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTipiComponenti_CellMouseClick);
            // 
            // dgvMarcheComponenti
            // 
            this.dgvMarcheComponenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarcheComponenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcheComponenti.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvMarcheComponenti.Location = new System.Drawing.Point(3, 102);
            this.dgvMarcheComponenti.MultiSelect = false;
            this.dgvMarcheComponenti.Name = "dgvMarcheComponenti";
            this.dgvMarcheComponenti.ReadOnly = true;
            this.dgvMarcheComponenti.Size = new System.Drawing.Size(704, 699);
            this.dgvMarcheComponenti.TabIndex = 52;
            this.dgvMarcheComponenti.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMarcheComponenti_CellMouseClick);
            // 
            // topPanelAltro
            // 
            this.topPanelAltro.Controls.Add(this.pnlTipi);
            this.topPanelAltro.Controls.Add(this.pnlMarche);
            this.topPanelAltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelAltro.Location = new System.Drawing.Point(3, 3);
            this.topPanelAltro.Name = "topPanelAltro";
            this.topPanelAltro.Size = new System.Drawing.Size(1429, 99);
            this.topPanelAltro.TabIndex = 53;
            // 
            // pnlTipi
            // 
            this.pnlTipi.BackColor = System.Drawing.Color.DimGray;
            this.pnlTipi.Controls.Add(this.label9);
            this.pnlTipi.Controls.Add(this.bntDeleteTextTipologie);
            this.pnlTipi.Controls.Add(this.txBxTipoComponente);
            this.pnlTipi.Controls.Add(this.btnDelComponente);
            this.pnlTipi.Controls.Add(this.btnAddTipoComponente);
            this.pnlTipi.Controls.Add(this.btnEditComponente);
            this.pnlTipi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTipi.ForeColor = System.Drawing.Color.White;
            this.pnlTipi.Location = new System.Drawing.Point(704, 0);
            this.pnlTipi.Name = "pnlTipi";
            this.pnlTipi.Size = new System.Drawing.Size(725, 99);
            this.pnlTipi.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 26);
            this.label9.TabIndex = 31;
            this.label9.Text = "Tipologie di componenti";
            // 
            // bntDeleteTextTipologie
            // 
            this.bntDeleteTextTipologie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bntDeleteTextTipologie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntDeleteTextTipologie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bntDeleteTextTipologie.FlatAppearance.BorderSize = 0;
            this.bntDeleteTextTipologie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntDeleteTextTipologie.ForeColor = System.Drawing.Color.Black;
            this.bntDeleteTextTipologie.Location = new System.Drawing.Point(235, 38);
            this.bntDeleteTextTipologie.Name = "bntDeleteTextTipologie";
            this.bntDeleteTextTipologie.Size = new System.Drawing.Size(243, 58);
            this.bntDeleteTextTipologie.TabIndex = 29;
            this.bntDeleteTextTipologie.Text = "Cancella";
            this.bntDeleteTextTipologie.UseVisualStyleBackColor = false;
            this.bntDeleteTextTipologie.Click += new System.EventHandler(this.bntDeleteTextTipologie_Click);
            // 
            // txBxTipoComponente
            // 
            this.txBxTipoComponente.Location = new System.Drawing.Point(235, 10);
            this.txBxTipoComponente.Name = "txBxTipoComponente";
            this.txBxTipoComponente.Size = new System.Drawing.Size(243, 26);
            this.txBxTipoComponente.TabIndex = 28;
            // 
            // btnDelComponente
            // 
            this.btnDelComponente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelComponente.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.components_remove;
            this.btnDelComponente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelComponente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelComponente.FlatAppearance.BorderSize = 3;
            this.btnDelComponente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelComponente.Location = new System.Drawing.Point(159, 38);
            this.btnDelComponente.Name = "btnDelComponente";
            this.btnDelComponente.Size = new System.Drawing.Size(66, 58);
            this.btnDelComponente.TabIndex = 27;
            this.btnDelComponente.UseVisualStyleBackColor = false;
            this.btnDelComponente.Click += new System.EventHandler(this.btnDelComponente_Click);
            // 
            // btnAddTipoComponente
            // 
            this.btnAddTipoComponente.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddTipoComponente.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.components_add;
            this.btnAddTipoComponente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTipoComponente.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAddTipoComponente.FlatAppearance.BorderSize = 3;
            this.btnAddTipoComponente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTipoComponente.Location = new System.Drawing.Point(15, 38);
            this.btnAddTipoComponente.Name = "btnAddTipoComponente";
            this.btnAddTipoComponente.Size = new System.Drawing.Size(66, 58);
            this.btnAddTipoComponente.TabIndex = 26;
            this.btnAddTipoComponente.UseVisualStyleBackColor = false;
            this.btnAddTipoComponente.Click += new System.EventHandler(this.btnAddTipoComponente_Click);
            // 
            // btnEditComponente
            // 
            this.btnEditComponente.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditComponente.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.components_edit;
            this.btnEditComponente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditComponente.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnEditComponente.FlatAppearance.BorderSize = 3;
            this.btnEditComponente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditComponente.Location = new System.Drawing.Point(87, 38);
            this.btnEditComponente.Name = "btnEditComponente";
            this.btnEditComponente.Size = new System.Drawing.Size(66, 58);
            this.btnEditComponente.TabIndex = 25;
            this.btnEditComponente.UseVisualStyleBackColor = false;
            this.btnEditComponente.Click += new System.EventHandler(this.btnEditComponente_Click);
            // 
            // pnlMarche
            // 
            this.pnlMarche.BackColor = System.Drawing.Color.DimGray;
            this.pnlMarche.Controls.Add(this.label8);
            this.pnlMarche.Controls.Add(this.bntDeleteTextMarche);
            this.pnlMarche.Controls.Add(this.txBxMarcaComponente);
            this.pnlMarche.Controls.Add(this.btnDelMarca);
            this.pnlMarche.Controls.Add(this.btnAddMarca);
            this.pnlMarche.Controls.Add(this.btnEditMarca);
            this.pnlMarche.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMarche.ForeColor = System.Drawing.Color.White;
            this.pnlMarche.Location = new System.Drawing.Point(0, 0);
            this.pnlMarche.Name = "pnlMarche";
            this.pnlMarche.Size = new System.Drawing.Size(704, 99);
            this.pnlMarche.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 26);
            this.label8.TabIndex = 30;
            this.label8.Text = "Marche";
            // 
            // bntDeleteTextMarche
            // 
            this.bntDeleteTextMarche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bntDeleteTextMarche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntDeleteTextMarche.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bntDeleteTextMarche.FlatAppearance.BorderSize = 0;
            this.bntDeleteTextMarche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntDeleteTextMarche.ForeColor = System.Drawing.Color.Black;
            this.bntDeleteTextMarche.Location = new System.Drawing.Point(226, 38);
            this.bntDeleteTextMarche.Name = "bntDeleteTextMarche";
            this.bntDeleteTextMarche.Size = new System.Drawing.Size(162, 58);
            this.bntDeleteTextMarche.TabIndex = 29;
            this.bntDeleteTextMarche.Text = "Cancella";
            this.bntDeleteTextMarche.UseVisualStyleBackColor = false;
            this.bntDeleteTextMarche.Click += new System.EventHandler(this.bntDeleteTextMarche_Click);
            // 
            // txBxMarcaComponente
            // 
            this.txBxMarcaComponente.Location = new System.Drawing.Point(82, 9);
            this.txBxMarcaComponente.Name = "txBxMarcaComponente";
            this.txBxMarcaComponente.Size = new System.Drawing.Size(306, 26);
            this.txBxMarcaComponente.TabIndex = 28;
            // 
            // btnDelMarca
            // 
            this.btnDelMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelMarca.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.industrial_remove;
            this.btnDelMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelMarca.FlatAppearance.BorderSize = 3;
            this.btnDelMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelMarca.Location = new System.Drawing.Point(154, 38);
            this.btnDelMarca.Name = "btnDelMarca";
            this.btnDelMarca.Size = new System.Drawing.Size(66, 58);
            this.btnDelMarca.TabIndex = 27;
            this.btnDelMarca.UseVisualStyleBackColor = false;
            this.btnDelMarca.Click += new System.EventHandler(this.btnDelMarca_Click);
            // 
            // btnAddMarca
            // 
            this.btnAddMarca.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddMarca.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.industrial_add;
            this.btnAddMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMarca.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAddMarca.FlatAppearance.BorderSize = 3;
            this.btnAddMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMarca.Location = new System.Drawing.Point(10, 38);
            this.btnAddMarca.Name = "btnAddMarca";
            this.btnAddMarca.Size = new System.Drawing.Size(66, 58);
            this.btnAddMarca.TabIndex = 26;
            this.btnAddMarca.UseVisualStyleBackColor = false;
            this.btnAddMarca.Click += new System.EventHandler(this.btnAddMarca_Click);
            // 
            // btnEditMarca
            // 
            this.btnEditMarca.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditMarca.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.industrial_edit;
            this.btnEditMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditMarca.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnEditMarca.FlatAppearance.BorderSize = 3;
            this.btnEditMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMarca.Location = new System.Drawing.Point(82, 38);
            this.btnEditMarca.Name = "btnEditMarca";
            this.btnEditMarca.Size = new System.Drawing.Size(66, 58);
            this.btnEditMarca.TabIndex = 25;
            this.btnEditMarca.UseVisualStyleBackColor = false;
            this.btnEditMarca.Click += new System.EventHandler(this.btnEditMarca_Click);
            // 
            // pbxWait
            // 
            this.pbxWait.BackColor = System.Drawing.Color.Transparent;
            this.pbxWait.Image = global::Calendario_AriBerg.Properties.Resources.AriLoading_Final_25fps;
            this.pbxWait.Location = new System.Drawing.Point(665, 134);
            this.pbxWait.Name = "pbxWait";
            this.pbxWait.Size = new System.Drawing.Size(219, 208);
            this.pbxWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxWait.TabIndex = 58;
            this.pbxWait.TabStop = false;
            this.pbxWait.Visible = false;
            // 
            // dgvMostraMacchineAccessori
            // 
            this.dgvMostraMacchineAccessori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostraMacchineAccessori.Location = new System.Drawing.Point(13, 165);
            this.dgvMostraMacchineAccessori.Name = "dgvMostraMacchineAccessori";
            this.dgvMostraMacchineAccessori.Size = new System.Drawing.Size(360, 235);
            this.dgvMostraMacchineAccessori.TabIndex = 51;
            // 
            // dgvMostraComponentiMacchina
            // 
            this.dgvMostraComponentiMacchina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostraComponentiMacchina.Location = new System.Drawing.Point(14, 430);
            this.dgvMostraComponentiMacchina.Name = "dgvMostraComponentiMacchina";
            this.dgvMostraComponentiMacchina.Size = new System.Drawing.Size(359, 144);
            this.dgvMostraComponentiMacchina.TabIndex = 52;
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1443, 835);
            this.Controls.Add(this.pbxWait);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormCalendario";
            this.Text = "AriGenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalendario_FormClosing);
            this.Load += new System.EventHandler(this.FormCalendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventi)).EndInit();
            this.gbxLegenda.ResumeLayout(false);
            this.gbxLegenda.PerformLayout();
            this.gbxAggiungi.ResumeLayout(false);
            this.gbxAggiungi.PerformLayout();
            this.gBxDettagliMacchinaAccessorio.ResumeLayout(false);
            this.gBxDettagliMacchinaAccessorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDettagliComponenti)).EndInit();
            this.gbxModifica.ResumeLayout(false);
            this.gbxModifica.PerformLayout();
            this.pnlCommands1.ResumeLayout(false);
            this.gbxDettagli.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gBxDettagliCliente.ResumeLayout(false);
            this.gBxDettagliCliente.PerformLayout();
            this.pnlCercaEvento.ResumeLayout(false);
            this.pnlCercaEvento.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mur)).EndInit();
            this.pnlCommands2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizzaClienti)).EndInit();
            this.leftPanelClienti.ResumeLayout(false);
            this.gBxClientiModificaClienti.ResumeLayout(false);
            this.gBxClientiModificaClienti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificaCliente)).EndInit();
            this.pnlModificaClienteMacchine.ResumeLayout(false);
            this.gBxClientiAggiungiCliente.ResumeLayout(false);
            this.gBxClientiAggiungiCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAggiungiClientiMacchine)).EndInit();
            this.pnlAggiungiClienteButtonsMacchina.ResumeLayout(false);
            this.gBxClientiTrova.ResumeLayout(false);
            this.gBxClientiTrova.PerformLayout();
            this.RightPanelClienti.ResumeLayout(false);
            this.gBxAggiungiMacchina.ResumeLayout(false);
            this.gBxAggiungiMacchina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentiAggiungiMacchina)).EndInit();
            this.gBxVisualizzaCliente.ResumeLayout(false);
            this.gBxVisualizzaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlloStoricoMacchina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlloStoricoCliente)).EndInit();
            this.gBxModificaMacchina.ResumeLayout(false);
            this.gBxModificaMacchina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.gbxModificaComponente.ResumeLayout(false);
            this.gbxModificaComponente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModificaSoglia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModificaNOrdine)).EndInit();
            this.tbCtrlMagazzini.ResumeLayout(false);
            this.Totale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzinoTotale)).EndInit();
            this.Centrale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzinoCentrale)).EndInit();
            this.MidMagPanel.ResumeLayout(false);
            this.MidMagPanel.PerformLayout();
            this.gbxEditComponenti.ResumeLayout(false);
            this.gbxEditComponenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditNcomponenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroComponenti)).EndInit();
            this.LeftMagPanel.ResumeLayout(false);
            this.PnlCatalogo.ResumeLayout(false);
            this.gBxAggiungiComponente.ResumeLayout(false);
            this.gBxAggiungiComponente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAggiungiComponenteSoglia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAggiungiComponenteNOrdine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponenti)).EndInit();
            this.pnlFiltriMagazzino.ResumeLayout(false);
            this.pnlFiltriMagazzino.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.TopMagPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipiComponenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcheComponenti)).EndInit();
            this.topPanelAltro.ResumeLayout(false);
            this.pnlTipi.ResumeLayout(false);
            this.pnlTipi.PerformLayout();
            this.pnlMarche.ResumeLayout(false);
            this.pnlMarche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraMacchineAccessori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraComponentiMacchina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvEventi;
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
        private System.Windows.Forms.Label lblMostraComponenti;
        private System.Windows.Forms.CheckBox chbxMostraNoleggio;
        private System.Windows.Forms.RichTextBox rtbMostraNote;
        private System.Windows.Forms.Label lblMostraNote;
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gBxAggiungiComponente;
        private System.Windows.Forms.TextBox tbxAggiungiComponenteCodice;
        private System.Windows.Forms.Label lblAggiungiComponenteTipo;
        private System.Windows.Forms.Button btnExitAggiungiComponente;
        private System.Windows.Forms.Button btnAggiungiComponente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddComponente;
        private System.Windows.Forms.Button btnModifyComponente;
        private System.Windows.Forms.Button btnRemoveComponente;
        private System.Windows.Forms.TabControl tbCtrlMagazzini;
        private System.Windows.Forms.TabPage Totale;
        private System.Windows.Forms.TabPage Centrale;
        private System.Windows.Forms.DataGridView dgvComponenti;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label lblAggiungiComponenteCodice;
        private System.Windows.Forms.NumericUpDown nudAggiungiComponenteNOrdine;
        private System.Windows.Forms.ComboBox cbxAggiungiComponenteTipo;
        private System.Windows.Forms.Label lblAggiungiComponenteMarca;
        private System.Windows.Forms.Label lblAggiungiComponenteNOrdine;
        private System.Windows.Forms.Label lblAggiungiComponenteSoglia;
        private System.Windows.Forms.NumericUpDown nudAggiungiComponenteSoglia;
        private System.Windows.Forms.Panel pnlFiltriMagazzino;
        private System.Windows.Forms.CheckBox chBxFiltroMagazzinoMarca;
        private System.Windows.Forms.CheckBox chBxFiltroMagazzinoTipo;
        private System.Windows.Forms.Button btnSearchComponenti;
        private System.Windows.Forms.ComboBox cbBxFiltroMagazzinoMarca;
        private System.Windows.Forms.ComboBox cbBxFiltroMagazzinoTipo;
        private System.Windows.Forms.CheckBox chBxFiltroMagazzinoCodice;
        private System.Windows.Forms.CheckBox chBxSottoSoglia;
        private System.Windows.Forms.Label lblMagazziniComponenti;
        private System.Windows.Forms.Label lblCatalogoComponenti;
        private System.Windows.Forms.CheckBox chbxFiltroACatalogo;
        private System.Windows.Forms.ComboBox cbBxFiltroMagazzinoCodice;
        private System.Windows.Forms.CheckBox chbxFiltroAMagazzino;
        private System.Windows.Forms.Button btnImmagazzinaComponente;
        private System.Windows.Forms.NumericUpDown nudNumeroComponenti;
        private System.Windows.Forms.Panel leftPanelClienti;
        private System.Windows.Forms.Panel RightPanelClienti;
        private System.Windows.Forms.Panel MidMagPanel;
        private System.Windows.Forms.Panel LeftMagPanel;
        private System.Windows.Forms.GroupBox gbxModificaComponente;
        private System.Windows.Forms.ComboBox cbxModificaMarcaComponente;
        private System.Windows.Forms.Button btnModificaComponente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudModificaSoglia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudModificaNOrdine;
        private System.Windows.Forms.ComboBox cbxModificaTipoComponente;
        private System.Windows.Forms.TextBox tbxModificaCodiceComponente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExitEditComponente;
        private System.Windows.Forms.Panel PnlCatalogo;
        private System.Windows.Forms.Panel TopMagPanel;
        private System.Windows.Forms.GroupBox gbxEditComponenti;
        private System.Windows.Forms.Button btnEliminaComponenteImmagazzinato;
        private System.Windows.Forms.NumericUpDown nudEditNcomponenti;
        private System.Windows.Forms.Button btnMenoComponenti;
        private System.Windows.Forms.Button btnPlusComponenti;
        private System.Windows.Forms.Label lblAggiornaComponentiMagazzino;
        private System.Windows.Forms.Label lblModificaComponentiMagazzino;
        private System.Windows.Forms.Label lblEliminaComponenteImmagazzinato;
        private System.Windows.Forms.DataGridView dgvMagazzinoTotale;
        private System.Windows.Forms.ComboBox cbxAggiungiMarcaComponente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancellaNomeMagazzino;
        private System.Windows.Forms.TextBox tbxNomeMagazzino;
        private System.Windows.Forms.Button btnEliminaMagazzino;
        private System.Windows.Forms.Button btnAggiungiMagazzino;
        private System.Windows.Forms.Button btnModificaMagazzino;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dgvTipiComponenti;
        private System.Windows.Forms.DataGridView dgvMarcheComponenti;
        private System.Windows.Forms.Panel topPanelAltro;
        private System.Windows.Forms.Panel pnlTipi;
        private System.Windows.Forms.Button bntDeleteTextTipologie;
        private System.Windows.Forms.TextBox txBxTipoComponente;
        private System.Windows.Forms.Button btnDelComponente;
        private System.Windows.Forms.Button btnAddTipoComponente;
        private System.Windows.Forms.Button btnEditComponente;
        private System.Windows.Forms.Panel pnlMarche;
        private System.Windows.Forms.Button bntDeleteTextMarche;
        private System.Windows.Forms.TextBox txBxMarcaComponente;
        private System.Windows.Forms.Button btnDelMarca;
        private System.Windows.Forms.Button btnAddMarca;
        private System.Windows.Forms.DataGridView dgvDettagliComponenti;
        private System.Windows.Forms.DataGridView dgvModificaCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvAggiungiClientiMacchine;
        private System.Windows.Forms.DataGridView dgvComponentiAggiungiMacchina;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnEditMarca;
        private System.Windows.Forms.DataGridView dgvMagazzinoCentrale;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbxWait;
        private System.Windows.Forms.ComboBox cbBxAggiungiMacchinaCodiceFiltro;
        private System.Windows.Forms.ComboBox cbBxAggiungiMacchinaMarcaFiltro;
        private System.Windows.Forms.Button btnCloseEditComponenti;
        private System.Windows.Forms.DataGridView dgvMostraComponentiMacchina;
        private System.Windows.Forms.DataGridView dgvMostraMacchineAccessori;
    }
}

