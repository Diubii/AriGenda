using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Calendario_AriBerg
{
    public partial class Notifica : Form
    {
        private Evento Event = new Evento();
        private static int i;
        private FormCalendario FC;
        private Bitmap img;
        private Graphics G;

        public delegate void SetCalendarDateCallBack(Evento ev);

        public SetCalendarDateCallBack SetCalendarDate;

        public Notifica(Evento ev, FormCalendario Fc)
        {
            InitializeComponent();
            Event = ev;
            FC = Fc;
        }

        public Notifica()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Scadenza,
            TimeTravel,
            Success,
            Warning,
            Error,
            Info
        }

        private Notifica.enmAction action;
        private Notifica.enmType Type;
        private int x, y;

        private void timerNotifica_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    if (Type == enmType.Scadenza || Type == enmType.Error)
                    {
                        timerNotifica.Interval = 999999999;
                        action = enmAction.close;
                    }
                    else
                    {
                        timerNotifica.Interval = 5000;
                        action = enmAction.close;
                    }
                    break;

                case Notifica.enmAction.start:
                    this.timerNotifica.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Notifica.enmAction.wait;
                        }
                    }
                    break;

                case enmAction.close:
                    timerNotifica.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void pxBxChiudiNotifica_Click(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timerNotifica.Interval = 5000;
                    action = enmAction.close;
                    break;

                case Notifica.enmAction.start:
                    this.timerNotifica.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Notifica.enmAction.wait;
                        }
                    }
                    break;

                case enmAction.close:
                    timerNotifica.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void Notifica_Load(object sender, EventArgs e)
        {
            if (this.Type == enmType.Scadenza)
            {
                this.SetCalendarDate += new SetCalendarDateCallBack(FC.SetCalendarValue);
            }
        }

        private void BtnDiLink_Click(object sender, EventArgs e)
        {
            SetCalendarDate(Event);
            timerNotifica.Interval = 40;
            action = enmAction.close;
        }

        private void Notifica_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (i = 1; i < 200; i++)
            {
                fname = "alert" + i.ToString();
                Notifica frm = (Notifica)Application.OpenForms[fname];

                if (frm != null && this.Location.Y > frm.Location.Y)
                {
                    frm.Name = "alert" + (i - 1).ToString();
                    frm.y += this.Height + 5;
                    frm.Location = new Point(frm.x, frm.y);
                }
            }
        }

        public void Show(string msg, enmType type)
        {
            this.TopMost = true;
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;
            Type = type;

            for (i = 1; i < 200; i++)
            {
                fname = "alert" + i.ToString();
                Notifica frm = (Notifica)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            SoundPlayer sp = new SoundPlayer();

            switch (type)
            {
                case enmType.Scadenza:
                    this.btnDiLink.Visible = true;
                    this.btnDiLink.Enabled = true;
                    this.BackColor = Color.Cyan;
                    sp.SoundLocation = "Resources\\scadenza_notification.wav";
                    sp.Play();
                    break;

                case enmType.TimeTravel:
                    lblTestoNotifica.Location = new Point(lblTestoNotifica.Location.X, lblTestoNotifica.Location.Y - 40);
                    this.pxBxIconaNotifica.Image = Image.FromFile("Resources\\delorean_icon.png");
                    this.BackColor = Color.Bisque;
                    sp.SoundLocation = "Resources\\timetravel_notification.wav";
                    sp.Play();
                    break;

                case enmType.Success:
                    this.pxBxIconaNotifica.Image = Image.FromFile("Resources\\success_icon.png");
                    this.BackColor = Color.SeaGreen;
                    sp.SoundLocation = "Resources\\success_notification.wav";
                    sp.Play();
                    break;

                case enmType.Error:
                    this.pxBxIconaNotifica.Image = Image.FromFile("Resources\\skull_icon.png");
                    this.BackColor = Color.DarkRed;
                    sp.SoundLocation = "Resources\\error_notification.wav";
                    sp.Play();
                    break;

                case enmType.Info:
                    this.pxBxIconaNotifica.Image = Image.FromFile("Resources\\info_icon.png");
                    this.BackColor = Color.RoyalBlue;
                    sp.SoundLocation = "Resources\\info_notification.wav";
                    sp.Play();
                    break;

                case enmType.Warning:
                    this.pxBxIconaNotifica.Image = Image.FromFile("Resources\\exclamation_icon.png");
                    this.BackColor = Color.DarkOrange;
                    sp.SoundLocation = "Resources\\warning_notification.wav";
                    sp.Play();
                    break;
            }

            if (Type == enmType.Scadenza)
            {
                img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = img;
                G = Graphics.FromImage(img);

                this.lblTestoNotifica.Text = msg;
                pictureBox1.Visible = true;
                pictureBox1.Enabled = true;
                string text = Event.Operazioni;
                Point p = new Point(0, 0);
                Size size;
                Color appcolore;

                for (int i = 0; i < text.Length; i++)
                {
                    string textPart = text.Substring(i, 1);
                    size = TextRenderer.MeasureText(textPart, lblTestoNotifica.Font);

                    switch (Event.Interventi[i])
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
                        Font f = new Font("Calibri", 40);
                        G.DrawString(textPart, f, cellForeBrush, p);
                    }
                    p.X += (size.Width + 20) / 2;
                    pictureBox1.Refresh();
                }
            }
            else
            {
                this.lblTestoNotifica.Text = msg;
            }
            this.Show();
            this.action = enmAction.start;
            this.timerNotifica.Interval = 1;
            this.timerNotifica.Start();
        }
    }
}