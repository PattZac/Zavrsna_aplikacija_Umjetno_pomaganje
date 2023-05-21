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
            this.labelKorisink = new System.Windows.Forms.Label();
            this.bntMjenajKorisnik = new System.Windows.Forms.Button();
            this.bntPrikazajKomisije = new System.Windows.Forms.Button();
            this.bntMjenajPrikaz = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.bntNoviKomisiju = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKorisink
            // 
            this.labelKorisink.AutoSize = true;
            this.labelKorisink.Location = new System.Drawing.Point(616, 18);
            this.labelKorisink.Name = "labelKorisink";
            this.labelKorisink.Size = new System.Drawing.Size(74, 13);
            this.labelKorisink.TabIndex = 31;
            this.labelKorisink.Text = "Ime korisnika |";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Vrestu Ideju: ___________";
            // 
            // Ideje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelKorisink);
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

        private System.Windows.Forms.Label labelKorisink;
        private System.Windows.Forms.Button bntMjenajKorisnik;
        private System.Windows.Forms.Button bntPrikazajKomisije;
        private System.Windows.Forms.Button bntMjenajPrikaz;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button bntNoviKomisiju;
        private System.Windows.Forms.Label label1;
    }
}