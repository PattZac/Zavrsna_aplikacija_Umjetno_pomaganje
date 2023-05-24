namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    partial class Izazovi
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
            this.bntMjenajKorisnik = new System.Windows.Forms.Button();
            this.bntPrikazajIzazovi = new System.Windows.Forms.Button();
            this.bntRandomIzazov = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.bntNoviIzazov = new System.Windows.Forms.Button();
            this.txtKorsinikIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntMjenajKorisnik
            // 
            this.bntMjenajKorisnik.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntMjenajKorisnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMjenajKorisnik.Location = new System.Drawing.Point(696, 13);
            this.bntMjenajKorisnik.Name = "bntMjenajKorisnik";
            this.bntMjenajKorisnik.Size = new System.Drawing.Size(92, 23);
            this.bntMjenajKorisnik.TabIndex = 24;
            this.bntMjenajKorisnik.Text = "Mjenaj korisnik";
            this.bntMjenajKorisnik.UseVisualStyleBackColor = false;
            this.bntMjenajKorisnik.Click += new System.EventHandler(this.bntMjenajKorisnik_Click);
            // 
            // bntPrikazajIzazovi
            // 
            this.bntPrikazajIzazovi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntPrikazajIzazovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPrikazajIzazovi.Location = new System.Drawing.Point(64, 95);
            this.bntPrikazajIzazovi.Name = "bntPrikazajIzazovi";
            this.bntPrikazajIzazovi.Size = new System.Drawing.Size(241, 41);
            this.bntPrikazajIzazovi.TabIndex = 20;
            this.bntPrikazajIzazovi.Text = "Prikazaj sve Izazovi";
            this.bntPrikazajIzazovi.UseVisualStyleBackColor = false;
            // 
            // bntRandomIzazov
            // 
            this.bntRandomIzazov.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntRandomIzazov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntRandomIzazov.Location = new System.Drawing.Point(64, 225);
            this.bntRandomIzazov.Name = "bntRandomIzazov";
            this.bntRandomIzazov.Size = new System.Drawing.Size(241, 41);
            this.bntRandomIzazov.TabIndex = 21;
            this.bntRandomIzazov.Text = "Prikazi po slučajni odabirau jedan izazov";
            this.bntRandomIzazov.UseVisualStyleBackColor = false;
            this.bntRandomIzazov.Click += new System.EventHandler(this.bntRandomIzazov_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitle.Location = new System.Drawing.Point(101, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(165, 51);
            this.labelTitle.TabIndex = 23;
            this.labelTitle.Text = "Izazovi";
            // 
            // bntNoviIzazov
            // 
            this.bntNoviIzazov.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntNoviIzazov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNoviIzazov.Location = new System.Drawing.Point(64, 365);
            this.bntNoviIzazov.Name = "bntNoviIzazov";
            this.bntNoviIzazov.Size = new System.Drawing.Size(241, 41);
            this.bntNoviIzazov.TabIndex = 22;
            this.bntNoviIzazov.Text = "Unesi Novu Izazov";
            this.bntNoviIzazov.UseVisualStyleBackColor = false;
            this.bntNoviIzazov.Click += new System.EventHandler(this.bntNoviIzazov_Click);
            // 
            // txtKorsinikIme
            // 
            this.txtKorsinikIme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtKorsinikIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKorsinikIme.Location = new System.Drawing.Point(419, 18);
            this.txtKorsinikIme.Name = "txtKorsinikIme";
            this.txtKorsinikIme.Size = new System.Drawing.Size(271, 13);
            this.txtKorsinikIme.TabIndex = 25;
            this.txtKorsinikIme.Text = "Ime Korsnika |";
            this.txtKorsinikIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Izazovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKorsinikIme);
            this.Controls.Add(this.bntMjenajKorisnik);
            this.Controls.Add(this.bntPrikazajIzazovi);
            this.Controls.Add(this.bntRandomIzazov);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.bntNoviIzazov);
            this.Name = "Izazovi";
            this.Text = "Umjetnik pomaganje - Izazovi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntMjenajKorisnik;
        private System.Windows.Forms.Button bntPrikazajIzazovi;
        private System.Windows.Forms.Button bntRandomIzazov;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button bntNoviIzazov;
        private System.Windows.Forms.TextBox txtKorsinikIme;
    }
}