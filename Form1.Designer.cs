
namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    partial class MainForm
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.bntDogadaje = new System.Windows.Forms.Button();
            this.bntIdeje = new System.Windows.Forms.Button();
            this.bntKomisiju = new System.Windows.Forms.Button();
            this.rTxtBoxKomisije = new System.Windows.Forms.RichTextBox();
            this.bntMjenajKorisnik = new System.Windows.Forms.Button();
            this.bntIzazovi = new System.Windows.Forms.Button();
            this.groupBOxKomisije = new System.Windows.Forms.GroupBox();
            this.groupBoxDogadaje = new System.Windows.Forms.GroupBox();
            this.rTxtBoxDogadaje = new System.Windows.Forms.RichTextBox();
            this.txtKorsinikIme = new System.Windows.Forms.TextBox();
            this.groupBOxKomisije.SuspendLayout();
            this.groupBoxDogadaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelWelcome.Location = new System.Drawing.Point(12, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(387, 51);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Dobrodošli nazad!";
            // 
            // bntDogadaje
            // 
            this.bntDogadaje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntDogadaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntDogadaje.Location = new System.Drawing.Point(64, 185);
            this.bntDogadaje.Name = "bntDogadaje";
            this.bntDogadaje.Size = new System.Drawing.Size(241, 41);
            this.bntDogadaje.TabIndex = 2;
            this.bntDogadaje.Text = "Događaje";
            this.bntDogadaje.UseVisualStyleBackColor = false;
            this.bntDogadaje.Click += new System.EventHandler(this.bntDogadaje_Click);
            // 
            // bntIdeje
            // 
            this.bntIdeje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntIdeje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntIdeje.Location = new System.Drawing.Point(64, 275);
            this.bntIdeje.Name = "bntIdeje";
            this.bntIdeje.Size = new System.Drawing.Size(241, 41);
            this.bntIdeje.TabIndex = 3;
            this.bntIdeje.Text = "Ideje";
            this.bntIdeje.UseVisualStyleBackColor = false;
            this.bntIdeje.Click += new System.EventHandler(this.bntIdeje_Click);
            // 
            // bntKomisiju
            // 
            this.bntKomisiju.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntKomisiju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntKomisiju.Location = new System.Drawing.Point(64, 365);
            this.bntKomisiju.Name = "bntKomisiju";
            this.bntKomisiju.Size = new System.Drawing.Size(241, 41);
            this.bntKomisiju.TabIndex = 4;
            this.bntKomisiju.Text = "Komisiju";
            this.bntKomisiju.UseVisualStyleBackColor = false;
            this.bntKomisiju.Click += new System.EventHandler(this.bntKomisiju_Click);
            // 
            // rTxtBoxKomisije
            // 
            this.rTxtBoxKomisije.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rTxtBoxKomisije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtBoxKomisije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rTxtBoxKomisije.Location = new System.Drawing.Point(6, 25);
            this.rTxtBoxKomisije.Name = "rTxtBoxKomisije";
            this.rTxtBoxKomisije.ReadOnly = true;
            this.rTxtBoxKomisije.Size = new System.Drawing.Size(363, 169);
            this.rTxtBoxKomisije.TabIndex = 6;
            this.rTxtBoxKomisije.Text = "";
            // 
            // bntMjenajKorisnik
            // 
            this.bntMjenajKorisnik.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntMjenajKorisnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMjenajKorisnik.Location = new System.Drawing.Point(696, 13);
            this.bntMjenajKorisnik.Name = "bntMjenajKorisnik";
            this.bntMjenajKorisnik.Size = new System.Drawing.Size(92, 23);
            this.bntMjenajKorisnik.TabIndex = 5;
            this.bntMjenajKorisnik.Text = "Mjenaj korisnik";
            this.bntMjenajKorisnik.UseVisualStyleBackColor = false;
            this.bntMjenajKorisnik.Click += new System.EventHandler(this.bntMjenajKorisnik_Click);
            // 
            // bntIzazovi
            // 
            this.bntIzazovi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntIzazovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntIzazovi.Location = new System.Drawing.Point(64, 95);
            this.bntIzazovi.Name = "bntIzazovi";
            this.bntIzazovi.Size = new System.Drawing.Size(241, 41);
            this.bntIzazovi.TabIndex = 1;
            this.bntIzazovi.Text = "Izazovi";
            this.bntIzazovi.UseVisualStyleBackColor = false;
            this.bntIzazovi.Click += new System.EventHandler(this.bntIzazovi_Click);
            // 
            // groupBOxKomisije
            // 
            this.groupBOxKomisije.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBOxKomisije.Controls.Add(this.rTxtBoxKomisije);
            this.groupBOxKomisije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBOxKomisije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBOxKomisije.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBOxKomisije.Location = new System.Drawing.Point(413, 42);
            this.groupBOxKomisije.Name = "groupBOxKomisije";
            this.groupBOxKomisije.Size = new System.Drawing.Size(375, 200);
            this.groupBOxKomisije.TabIndex = 9;
            this.groupBOxKomisije.TabStop = false;
            this.groupBOxKomisije.Text = "Komisije";
            // 
            // groupBoxDogadaje
            // 
            this.groupBoxDogadaje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxDogadaje.Controls.Add(this.rTxtBoxDogadaje);
            this.groupBoxDogadaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxDogadaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDogadaje.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxDogadaje.Location = new System.Drawing.Point(413, 248);
            this.groupBoxDogadaje.Name = "groupBoxDogadaje";
            this.groupBoxDogadaje.Size = new System.Drawing.Size(375, 200);
            this.groupBoxDogadaje.TabIndex = 10;
            this.groupBoxDogadaje.TabStop = false;
            this.groupBoxDogadaje.Text = "Događaje";
            // 
            // rTxtBoxDogadaje
            // 
            this.rTxtBoxDogadaje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rTxtBoxDogadaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtBoxDogadaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rTxtBoxDogadaje.Location = new System.Drawing.Point(6, 25);
            this.rTxtBoxDogadaje.Name = "rTxtBoxDogadaje";
            this.rTxtBoxDogadaje.ReadOnly = true;
            this.rTxtBoxDogadaje.Size = new System.Drawing.Size(363, 169);
            this.rTxtBoxDogadaje.TabIndex = 0;
            this.rTxtBoxDogadaje.Text = "";
            // 
            // txtKorsinikIme
            // 
            this.txtKorsinikIme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtKorsinikIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKorsinikIme.Location = new System.Drawing.Point(419, 18);
            this.txtKorsinikIme.Name = "txtKorsinikIme";
            this.txtKorsinikIme.Size = new System.Drawing.Size(271, 13);
            this.txtKorsinikIme.TabIndex = 11;
            this.txtKorsinikIme.Text = "Ime Korsnika |";
            this.txtKorsinikIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKorsinikIme);
            this.Controls.Add(this.groupBoxDogadaje);
            this.Controls.Add(this.groupBOxKomisije);
            this.Controls.Add(this.bntIzazovi);
            this.Controls.Add(this.bntMjenajKorisnik);
            this.Controls.Add(this.bntKomisiju);
            this.Controls.Add(this.bntIdeje);
            this.Controls.Add(this.bntDogadaje);
            this.Controls.Add(this.labelWelcome);
            this.Name = "MainForm";
            this.Text = "Umjetnik pomaganje";
            this.groupBOxKomisije.ResumeLayout(false);
            this.groupBoxDogadaje.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button bntDogadaje;
        private System.Windows.Forms.Button bntIdeje;
        private System.Windows.Forms.Button bntKomisiju;
        private System.Windows.Forms.RichTextBox rTxtBoxKomisije;
        private System.Windows.Forms.Button bntMjenajKorisnik;
        private System.Windows.Forms.Button bntIzazovi;
        private System.Windows.Forms.GroupBox groupBOxKomisije;
        private System.Windows.Forms.GroupBox groupBoxDogadaje;
        private System.Windows.Forms.RichTextBox rTxtBoxDogadaje;
        private System.Windows.Forms.TextBox txtKorsinikIme;
    }
}

