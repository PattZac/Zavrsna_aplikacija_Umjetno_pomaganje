
namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    partial class Komisije
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
            this.groupBOxKomisije = new System.Windows.Forms.GroupBox();
            this.rTxtBoxKomisije = new System.Windows.Forms.RichTextBox();
            this.bntUnosKomisiju = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.bntListOrder = new System.Windows.Forms.Button();
            this.bntPrikazajKomisije = new System.Windows.Forms.Button();
            this.bntMjenajKorisnik = new System.Windows.Forms.Button();
            this.txtBoxListOrder = new System.Windows.Forms.TextBox();
            this.txtKorsinikIme = new System.Windows.Forms.TextBox();
            this.groupBOxKomisije.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBOxKomisije
            // 
            this.groupBOxKomisije.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBOxKomisije.Controls.Add(this.rTxtBoxKomisije);
            this.groupBOxKomisije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBOxKomisije.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBOxKomisije.Location = new System.Drawing.Point(413, 42);
            this.groupBOxKomisije.Name = "groupBOxKomisije";
            this.groupBOxKomisije.Size = new System.Drawing.Size(375, 396);
            this.groupBOxKomisije.TabIndex = 10;
            this.groupBOxKomisije.TabStop = false;
            this.groupBOxKomisije.Text = "Komisije";
            // 
            // rTxtBoxKomisije
            // 
            this.rTxtBoxKomisije.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rTxtBoxKomisije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtBoxKomisije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rTxtBoxKomisije.Location = new System.Drawing.Point(6, 25);
            this.rTxtBoxKomisije.Name = "rTxtBoxKomisije";
            this.rTxtBoxKomisije.ReadOnly = true;
            this.rTxtBoxKomisije.Size = new System.Drawing.Size(363, 365);
            this.rTxtBoxKomisije.TabIndex = 6;
            this.rTxtBoxKomisije.Text = "";
            // 
            // bntUnosKomisiju
            // 
            this.bntUnosKomisiju.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntUnosKomisiju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntUnosKomisiju.Location = new System.Drawing.Point(64, 365);
            this.bntUnosKomisiju.Name = "bntUnosKomisiju";
            this.bntUnosKomisiju.Size = new System.Drawing.Size(241, 41);
            this.bntUnosKomisiju.TabIndex = 3;
            this.bntUnosKomisiju.Text = "Unesi Novu Komisiju";
            this.bntUnosKomisiju.UseVisualStyleBackColor = false;
            this.bntUnosKomisiju.Click += new System.EventHandler(this.bntUnosKomisiju_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitle.Location = new System.Drawing.Point(87, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(195, 51);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Komisije";
            // 
            // bntListOrder
            // 
            this.bntListOrder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntListOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntListOrder.Location = new System.Drawing.Point(64, 225);
            this.bntListOrder.Name = "bntListOrder";
            this.bntListOrder.Size = new System.Drawing.Size(241, 41);
            this.bntListOrder.TabIndex = 2;
            this.bntListOrder.Text = "Mjenaj prikaz listu Komisije";
            this.bntListOrder.UseVisualStyleBackColor = false;
            this.bntListOrder.Click += new System.EventHandler(this.bntListOrder_Click);
            // 
            // bntPrikazajKomisije
            // 
            this.bntPrikazajKomisije.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntPrikazajKomisije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPrikazajKomisije.Location = new System.Drawing.Point(64, 95);
            this.bntPrikazajKomisije.Name = "bntPrikazajKomisije";
            this.bntPrikazajKomisije.Size = new System.Drawing.Size(241, 41);
            this.bntPrikazajKomisije.TabIndex = 1;
            this.bntPrikazajKomisije.Text = "Prikazaj sve Komisije";
            this.bntPrikazajKomisije.UseVisualStyleBackColor = false;
            // 
            // bntMjenajKorisnik
            // 
            this.bntMjenajKorisnik.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntMjenajKorisnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMjenajKorisnik.Location = new System.Drawing.Point(696, 13);
            this.bntMjenajKorisnik.Name = "bntMjenajKorisnik";
            this.bntMjenajKorisnik.Size = new System.Drawing.Size(92, 23);
            this.bntMjenajKorisnik.TabIndex = 18;
            this.bntMjenajKorisnik.Text = "Mjenaj korisnik";
            this.bntMjenajKorisnik.UseVisualStyleBackColor = false;
            this.bntMjenajKorisnik.Click += new System.EventHandler(this.bntMjenajKorisnik_Click);
            // 
            // txtBoxListOrder
            // 
            this.txtBoxListOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtBoxListOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxListOrder.Location = new System.Drawing.Point(64, 272);
            this.txtBoxListOrder.Name = "txtBoxListOrder";
            this.txtBoxListOrder.Size = new System.Drawing.Size(241, 13);
            this.txtBoxListOrder.TabIndex = 20;
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
            this.txtKorsinikIme.TabIndex = 21;
            this.txtKorsinikIme.Text = "Ime Korsnika |";
            this.txtKorsinikIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Komisije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKorsinikIme);
            this.Controls.Add(this.txtBoxListOrder);
            this.Controls.Add(this.bntMjenajKorisnik);
            this.Controls.Add(this.bntPrikazajKomisije);
            this.Controls.Add(this.bntListOrder);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.bntUnosKomisiju);
            this.Controls.Add(this.groupBOxKomisije);
            this.Name = "Komisije";
            this.Text = "Umjetnik pomaganje - Komisije";
            this.groupBOxKomisije.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBOxKomisije;
        private System.Windows.Forms.RichTextBox rTxtBoxKomisije;
        private System.Windows.Forms.Button bntUnosKomisiju;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button bntListOrder;
        private System.Windows.Forms.Button bntPrikazajKomisije;
        private System.Windows.Forms.Button bntMjenajKorisnik;
        private System.Windows.Forms.TextBox txtBoxListOrder;
        private System.Windows.Forms.TextBox txtKorsinikIme;
    }
}