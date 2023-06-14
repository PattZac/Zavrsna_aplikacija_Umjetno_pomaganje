namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    partial class Ideje
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
            this.bntPrikazajKomisije = new System.Windows.Forms.Button();
            this.bntMjenajPrikaz = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.bntNoviKomisiju = new System.Windows.Forms.Button();
            this.txtBoxIdeaType = new System.Windows.Forms.TextBox();
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
            this.bntMjenajKorisnik.TabIndex = 30;
            this.bntMjenajKorisnik.Text = "Mjenaj korisnik";
            this.bntMjenajKorisnik.UseVisualStyleBackColor = false;
            this.bntMjenajKorisnik.Click += new System.EventHandler(this.bntMjenajKorisnik_Click);
            // 
            // bntPrikazajKomisije
            // 
            this.bntPrikazajKomisije.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntPrikazajKomisije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPrikazajKomisije.Location = new System.Drawing.Point(64, 95);
            this.bntPrikazajKomisije.Name = "bntPrikazajKomisije";
            this.bntPrikazajKomisije.Size = new System.Drawing.Size(241, 41);
            this.bntPrikazajKomisije.TabIndex = 26;
            this.bntPrikazajKomisije.Text = "Izabraj vrstu ideju";
            this.bntPrikazajKomisije.UseVisualStyleBackColor = false;
            // 
            // bntMjenajPrikaz
            // 
            this.bntMjenajPrikaz.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntMjenajPrikaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMjenajPrikaz.Location = new System.Drawing.Point(64, 225);
            this.bntMjenajPrikaz.Name = "bntMjenajPrikaz";
            this.bntMjenajPrikaz.Size = new System.Drawing.Size(241, 41);
            this.bntMjenajPrikaz.TabIndex = 27;
            this.bntMjenajPrikaz.Text = "Generiraje novi ideju bez izazova";
            this.bntMjenajPrikaz.UseVisualStyleBackColor = false;
            this.bntMjenajPrikaz.Click += new System.EventHandler(this.bntMjenajPrikaz_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitle.Location = new System.Drawing.Point(121, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(121, 51);
            this.labelTitle.TabIndex = 29;
            this.labelTitle.Text = "Ideje";
            // 
            // bntNoviKomisiju
            // 
            this.bntNoviKomisiju.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntNoviKomisiju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNoviKomisiju.Location = new System.Drawing.Point(64, 365);
            this.bntNoviKomisiju.Name = "bntNoviKomisiju";
            this.bntNoviKomisiju.Size = new System.Drawing.Size(241, 41);
            this.bntNoviKomisiju.TabIndex = 28;
            this.bntNoviKomisiju.Text = "Generiraje novi ideju sa izazova";
            this.bntNoviKomisiju.UseVisualStyleBackColor = false;
            this.bntNoviKomisiju.Click += new System.EventHandler(this.bntNoviKomisiju_Click);
            // 
            // txtBoxIdeaType
            // 
            this.txtBoxIdeaType.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtBoxIdeaType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxIdeaType.Location = new System.Drawing.Point(64, 143);
            this.txtBoxIdeaType.Name = "txtBoxIdeaType";
            this.txtBoxIdeaType.Size = new System.Drawing.Size(241, 13);
            this.txtBoxIdeaType.TabIndex = 32;
            this.txtBoxIdeaType.Text = "Vrestu Ideju:";
            this.txtBoxIdeaType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKorsinikIme
            // 
            this.txtKorsinikIme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtKorsinikIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKorsinikIme.Location = new System.Drawing.Point(419, 18);
            this.txtKorsinikIme.Name = "txtKorsinikIme";
            this.txtKorsinikIme.Size = new System.Drawing.Size(271, 13);
            this.txtKorsinikIme.TabIndex = 33;
            this.txtKorsinikIme.Text = "Ime Korsnika |";
            this.txtKorsinikIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Ideje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKorsinikIme);
            this.Controls.Add(this.txtBoxIdeaType);
            this.Controls.Add(this.bntMjenajKorisnik);
            this.Controls.Add(this.bntPrikazajKomisije);
            this.Controls.Add(this.bntMjenajPrikaz);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.bntNoviKomisiju);
            this.Name = "Ideje";
            this.Text = "Umjetnik pomaganje - Ideje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntMjenajKorisnik;
        private System.Windows.Forms.Button bntPrikazajKomisije;
        private System.Windows.Forms.Button bntMjenajPrikaz;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button bntNoviKomisiju;
        private System.Windows.Forms.TextBox txtBoxIdeaType;
        private System.Windows.Forms.TextBox txtKorsinikIme;
    }
}