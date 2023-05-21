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
            this.labelKorisink = new System.Windows.Forms.Label();
            this.bntMjenajKorisnik = new System.Windows.Forms.Button();
            this.bntPrikazajKomisije = new System.Windows.Forms.Button();
            this.bntMjenajPrikaz = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.bntNoviKomisiju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKorisink
            // 
            this.labelKorisink.AutoSize = true;
            this.labelKorisink.Location = new System.Drawing.Point(616, 18);
            this.labelKorisink.Name = "labelKorisink";
            this.labelKorisink.Size = new System.Drawing.Size(74, 13);
            this.labelKorisink.TabIndex = 25;
            this.labelKorisink.Text = "Ime korisnika |";
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
            // 
            // bntPrikazajKomisije
            // 
            this.bntPrikazajKomisije.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntPrikazajKomisije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPrikazajKomisije.Location = new System.Drawing.Point(64, 95);
            this.bntPrikazajKomisije.Name = "bntPrikazajKomisije";
            this.bntPrikazajKomisije.Size = new System.Drawing.Size(241, 41);
            this.bntPrikazajKomisije.TabIndex = 20;
            this.bntPrikazajKomisije.Text = "Prikazaj sve Izazovi";
            this.bntPrikazajKomisije.UseVisualStyleBackColor = false;
            // 
            // bntMjenajPrikaz
            // 
            this.bntMjenajPrikaz.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntMjenajPrikaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMjenajPrikaz.Location = new System.Drawing.Point(64, 225);
            this.bntMjenajPrikaz.Name = "bntMjenajPrikaz";
            this.bntMjenajPrikaz.Size = new System.Drawing.Size(241, 41);
            this.bntMjenajPrikaz.TabIndex = 21;
            this.bntMjenajPrikaz.Text = "Prikazi po slučajni odabirau jedan izazov";
            this.bntMjenajPrikaz.UseVisualStyleBackColor = false;
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
            // bntNoviKomisiju
            // 
            this.bntNoviKomisiju.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntNoviKomisiju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNoviKomisiju.Location = new System.Drawing.Point(64, 365);
            this.bntNoviKomisiju.Name = "bntNoviKomisiju";
            this.bntNoviKomisiju.Size = new System.Drawing.Size(241, 41);
            this.bntNoviKomisiju.TabIndex = 22;
            this.bntNoviKomisiju.Text = "Unesi Novu Izazov";
            this.bntNoviKomisiju.UseVisualStyleBackColor = false;
            // 
            // Izazovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKorisink);
            this.Controls.Add(this.bntMjenajKorisnik);
            this.Controls.Add(this.bntPrikazajKomisije);
            this.Controls.Add(this.bntMjenajPrikaz);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.bntNoviKomisiju);
            this.Name = "Izazovi";
            this.Text = "Umjetnik pomaganje - Izazovi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKorisink;
        private System.Windows.Forms.Button bntMjenajKorisnik;
        private System.Windows.Forms.Button bntPrikazajKomisije;
        private System.Windows.Forms.Button bntMjenajPrikaz;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button bntNoviKomisiju;
    }
}