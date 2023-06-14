
namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    partial class Dogadaje
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
            this.rTxtBoxDogadaje = new System.Windows.Forms.RichTextBox();
            this.groupBoxDogadaje = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.bntPrikazajDogadaje = new System.Windows.Forms.Button();
            this.bntListOrder = new System.Windows.Forms.Button();
            this.bntUnosDogadaje = new System.Windows.Forms.Button();
            this.bntMjenajKorisnik = new System.Windows.Forms.Button();
            this.txtBoxListOrder = new System.Windows.Forms.TextBox();
            this.txtKorsinikIme = new System.Windows.Forms.TextBox();
            this.groupBoxDogadaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTxtBoxDogadaje
            // 
            this.rTxtBoxDogadaje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rTxtBoxDogadaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtBoxDogadaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rTxtBoxDogadaje.Location = new System.Drawing.Point(6, 25);
            this.rTxtBoxDogadaje.Name = "rTxtBoxDogadaje";
            this.rTxtBoxDogadaje.ReadOnly = true;
            this.rTxtBoxDogadaje.Size = new System.Drawing.Size(363, 365);
            this.rTxtBoxDogadaje.TabIndex = 0;
            this.rTxtBoxDogadaje.Text = "";
            // 
            // groupBoxDogadaje
            // 
            this.groupBoxDogadaje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxDogadaje.Controls.Add(this.rTxtBoxDogadaje);
            this.groupBoxDogadaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDogadaje.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxDogadaje.Location = new System.Drawing.Point(413, 42);
            this.groupBoxDogadaje.Name = "groupBoxDogadaje";
            this.groupBoxDogadaje.Size = new System.Drawing.Size(375, 396);
            this.groupBoxDogadaje.TabIndex = 11;
            this.groupBoxDogadaje.TabStop = false;
            this.groupBoxDogadaje.Text = "Događaje";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitle.Location = new System.Drawing.Point(78, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(215, 51);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Događaje";
            // 
            // bntPrikazajDogadaje
            // 
            this.bntPrikazajDogadaje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntPrikazajDogadaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPrikazajDogadaje.Location = new System.Drawing.Point(64, 95);
            this.bntPrikazajDogadaje.Name = "bntPrikazajDogadaje";
            this.bntPrikazajDogadaje.Size = new System.Drawing.Size(241, 41);
            this.bntPrikazajDogadaje.TabIndex = 13;
            this.bntPrikazajDogadaje.Text = "Prikazaj sve Događaje";
            this.bntPrikazajDogadaje.UseVisualStyleBackColor = false;
            // 
            // bntListOrder
            // 
            this.bntListOrder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntListOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntListOrder.Location = new System.Drawing.Point(64, 225);
            this.bntListOrder.Name = "bntListOrder";
            this.bntListOrder.Size = new System.Drawing.Size(241, 41);
            this.bntListOrder.TabIndex = 14;
            this.bntListOrder.Text = "Mjenaj prikaz listu Događaje";
            this.bntListOrder.UseVisualStyleBackColor = false;
            this.bntListOrder.Click += new System.EventHandler(this.bntListOrder_Click);
            // 
            // bntUnosDogadaje
            // 
            this.bntUnosDogadaje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntUnosDogadaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntUnosDogadaje.Location = new System.Drawing.Point(64, 365);
            this.bntUnosDogadaje.Name = "bntUnosDogadaje";
            this.bntUnosDogadaje.Size = new System.Drawing.Size(241, 41);
            this.bntUnosDogadaje.TabIndex = 15;
            this.bntUnosDogadaje.Text = "Unesi Novi Događaj";
            this.bntUnosDogadaje.UseVisualStyleBackColor = false;
            this.bntUnosDogadaje.Click += new System.EventHandler(this.bntUnosDogadaje_Click);
            // 
            // bntMjenajKorisnik
            // 
            this.bntMjenajKorisnik.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntMjenajKorisnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMjenajKorisnik.Location = new System.Drawing.Point(696, 13);
            this.bntMjenajKorisnik.Name = "bntMjenajKorisnik";
            this.bntMjenajKorisnik.Size = new System.Drawing.Size(92, 23);
            this.bntMjenajKorisnik.TabIndex = 16;
            this.bntMjenajKorisnik.Text = "Mjenaj korisnik";
            this.bntMjenajKorisnik.UseVisualStyleBackColor = false;
            this.bntMjenajKorisnik.Click += new System.EventHandler(this.bntMjenajKorisnik_Click);
            // 
            // txtBoxListOrder
            // 
            this.txtBoxListOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtBoxListOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxListOrder.Location = new System.Drawing.Point(64, 273);
            this.txtBoxListOrder.Name = "txtBoxListOrder";
            this.txtBoxListOrder.Size = new System.Drawing.Size(241, 13);
            this.txtBoxListOrder.TabIndex = 18;
            this.txtBoxListOrder.Text = "Prikaz List: Najblizi";
            this.txtBoxListOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKorsinikIme
            // 
            this.txtKorsinikIme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtKorsinikIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKorsinikIme.Location = new System.Drawing.Point(419, 18);
            this.txtKorsinikIme.Name = "txtKorsinikIme";
            this.txtKorsinikIme.Size = new System.Drawing.Size(271, 13);
            this.txtKorsinikIme.TabIndex = 19;
            this.txtKorsinikIme.Text = "Ime Korsnika |";
            this.txtKorsinikIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Dogadaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKorsinikIme);
            this.Controls.Add(this.txtBoxListOrder);
            this.Controls.Add(this.bntMjenajKorisnik);
            this.Controls.Add(this.bntUnosDogadaje);
            this.Controls.Add(this.bntListOrder);
            this.Controls.Add(this.bntPrikazajDogadaje);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxDogadaje);
            this.Name = "Dogadaje";
            this.Text = "Umjetnik pomaganje - Događaje";
            this.groupBoxDogadaje.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtBoxDogadaje;
        private System.Windows.Forms.GroupBox groupBoxDogadaje;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button bntPrikazajDogadaje;
        private System.Windows.Forms.Button bntListOrder;
        private System.Windows.Forms.Button bntUnosDogadaje;
        private System.Windows.Forms.Button bntMjenajKorisnik;
        private System.Windows.Forms.TextBox txtBoxListOrder;
        private System.Windows.Forms.TextBox txtKorsinikIme;
    }
}