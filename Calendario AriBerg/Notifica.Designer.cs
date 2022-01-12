

using System.Windows.Forms;

namespace Calendario_AriBerg
{
    partial class Notifica : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTestoNotifica = new System.Windows.Forms.Label();
            this.timerNotifica = new System.Windows.Forms.Timer(this.components);
            this.pxBxChiudiNotifica = new System.Windows.Forms.PictureBox();
            this.pxBxIconaNotifica = new System.Windows.Forms.PictureBox();
            this.btnDiLink = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pxBxChiudiNotifica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBxIconaNotifica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestoNotifica
            // 
            this.lblTestoNotifica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTestoNotifica.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestoNotifica.Location = new System.Drawing.Point(90, 9);
            this.lblTestoNotifica.Name = "lblTestoNotifica";
            this.lblTestoNotifica.Size = new System.Drawing.Size(1738, 84);
            this.lblTestoNotifica.TabIndex = 1;
            this.lblTestoNotifica.Text = "Testo";
            this.lblTestoNotifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerNotifica
            // 
            this.timerNotifica.Tick += new System.EventHandler(this.timerNotifica_Tick);
            // 
            // pxBxChiudiNotifica
            // 
            this.pxBxChiudiNotifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pxBxChiudiNotifica.Image = global::Calendario_AriBerg.Properties.Resources.delete_icon;
            this.pxBxChiudiNotifica.Location = new System.Drawing.Point(1841, 3);
            this.pxBxChiudiNotifica.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pxBxChiudiNotifica.Name = "pxBxChiudiNotifica";
            this.pxBxChiudiNotifica.Padding = new System.Windows.Forms.Padding(100, 100, 100, 100);
            this.pxBxChiudiNotifica.Size = new System.Drawing.Size(38, 32);
            this.pxBxChiudiNotifica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxBxChiudiNotifica.TabIndex = 2;
            this.pxBxChiudiNotifica.TabStop = false;
            this.pxBxChiudiNotifica.Click += new System.EventHandler(this.pxBxChiudiNotifica_Click);
            // 
            // pxBxIconaNotifica
            // 
            this.pxBxIconaNotifica.Image = global::Calendario_AriBerg.Properties.Resources.exclamation_icon;
            this.pxBxIconaNotifica.Location = new System.Drawing.Point(10, 11);
            this.pxBxIconaNotifica.Name = "pxBxIconaNotifica";
            this.pxBxIconaNotifica.Size = new System.Drawing.Size(75, 81);
            this.pxBxIconaNotifica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxBxIconaNotifica.TabIndex = 0;
            this.pxBxIconaNotifica.TabStop = false;
            // 
            // btnDiLink
            // 
            this.btnDiLink.BackgroundImage = global::Calendario_AriBerg.Properties.Resources.time_runnningout_icon;
            this.btnDiLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiLink.Enabled = false;
            this.btnDiLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiLink.Location = new System.Drawing.Point(10, 10);
            this.btnDiLink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiLink.Name = "btnDiLink";
            this.btnDiLink.Size = new System.Drawing.Size(75, 82);
            this.btnDiLink.TabIndex = 3;
            this.btnDiLink.UseVisualStyleBackColor = true;
            this.btnDiLink.Visible = false;
            this.btnDiLink.Click += new System.EventHandler(this.BtnDiLink_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(90, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1739, 47);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Notifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1885, 102);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDiLink);
            this.Controls.Add(this.pxBxChiudiNotifica);
            this.Controls.Add(this.lblTestoNotifica);
            this.Controls.Add(this.pxBxIconaNotifica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notifica";
            this.ShowInTaskbar = false;
            this.Text = "Notifica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notifica_FormClosed);
            this.Load += new System.EventHandler(this.Notifica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxBxChiudiNotifica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBxIconaNotifica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pxBxIconaNotifica;
        private System.Windows.Forms.Label lblTestoNotifica;
        private System.Windows.Forms.PictureBox pxBxChiudiNotifica;
        private System.Windows.Forms.Timer timerNotifica;
        private Button btnDiLink;
        private PictureBox pictureBox1;
    }
}