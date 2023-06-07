namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    partial class Korisnik
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxSpol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.bntPrijava = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxKorsinike = new System.Windows.Forms.ListBox();
            this.bntNoviKorsnik = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.cboxSpol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(21, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 190);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novi Korsnik";
            // 
            // cboxSpol
            // 
            this.cboxSpol.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cboxSpol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSpol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboxSpol.FormattingEnabled = true;
            this.cboxSpol.Items.AddRange(new object[] {
            "Muški",
            "Ženski"});
            this.cboxSpol.Location = new System.Drawing.Point(20, 150);
            this.cboxSpol.Name = "cboxSpol";
            this.cboxSpol.Size = new System.Drawing.Size(221, 21);
            this.cboxSpol.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Spol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime (Opcijalan)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrezime.Location = new System.Drawing.Point(20, 100);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(221, 20);
            this.txtPrezime.TabIndex = 1;
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIme.Location = new System.Drawing.Point(20, 50);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(221, 20);
            this.txtIme.TabIndex = 0;
            // 
            // bntPrijava
            // 
            this.bntPrijava.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPrijava.Location = new System.Drawing.Point(21, 397);
            this.bntPrijava.Name = "bntPrijava";
            this.bntPrijava.Size = new System.Drawing.Size(180, 41);
            this.bntPrijava.TabIndex = 24;
            this.bntPrijava.Text = "Prijavi se";
            this.bntPrijava.UseVisualStyleBackColor = false;
            this.bntPrijava.Click += new System.EventHandler(this.bntPrijava_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.listBoxKorsinike);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(21, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 169);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Korisnike";
            // 
            // listBoxKorsinike
            // 
            this.listBoxKorsinike.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxKorsinike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxKorsinike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxKorsinike.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxKorsinike.FormattingEnabled = true;
            this.listBoxKorsinike.Location = new System.Drawing.Point(20, 33);
            this.listBoxKorsinike.Name = "listBoxKorsinike";
            this.listBoxKorsinike.Size = new System.Drawing.Size(372, 119);
            this.listBoxKorsinike.TabIndex = 0;
            // 
            // bntNoviKorsnik
            // 
            this.bntNoviKorsnik.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntNoviKorsnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNoviKorsnik.Location = new System.Drawing.Point(251, 397);
            this.bntNoviKorsnik.Name = "bntNoviKorsnik";
            this.bntNoviKorsnik.Size = new System.Drawing.Size(180, 41);
            this.bntNoviKorsnik.TabIndex = 27;
            this.bntNoviKorsnik.Text = "Napravi novi korsnik";
            this.bntNoviKorsnik.UseVisualStyleBackColor = false;
            this.bntNoviKorsnik.Click += new System.EventHandler(this.bntNoviKorsnik_Click);
            // 
            // Korisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.bntNoviKorsnik);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntPrijava);
            this.Name = "Korisnik";
            this.Text = "Umjetnik pomaganje - Korisnik";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxSpol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button bntPrijava;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxKorsinike;
        private System.Windows.Forms.Button bntNoviKorsnik;
    }
}