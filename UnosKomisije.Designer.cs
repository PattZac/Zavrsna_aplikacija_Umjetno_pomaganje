
namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    partial class UnosKomisije
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxKlijent = new System.Windows.Forms.ComboBox();
            this.txtAdressu = new System.Windows.Forms.TextBox();
            this.txtPlatformu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listDogadaj = new System.Windows.Forms.ComboBox();
            this.calendarRok = new System.Windows.Forms.MonthCalendar();
            this.bntUnos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVrstu = new System.Windows.Forms.TextBox();
            this.txtCijenu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIme.Location = new System.Drawing.Point(20, 50);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(221, 20);
            this.txtIme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime Klijenta";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.cboxKlijent);
            this.groupBox1.Controls.Add(this.txtAdressu);
            this.groupBox1.Controls.Add(this.txtPlatformu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klijent";
            // 
            // cboxKlijent
            // 
            this.cboxKlijent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cboxKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxKlijent.FormattingEnabled = true;
            this.cboxKlijent.Location = new System.Drawing.Point(81, -2);
            this.cboxKlijent.Name = "cboxKlijent";
            this.cboxKlijent.Size = new System.Drawing.Size(160, 28);
            this.cboxKlijent.TabIndex = 6;
            this.cboxKlijent.Text = "Novi Klijent";
            this.cboxKlijent.SelectedIndexChanged += new System.EventHandler(this.cboxKlijent_SelectedIndexChanged);
            // 
            // txtAdressu
            // 
            this.txtAdressu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAdressu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdressu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtAdressu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAdressu.Location = new System.Drawing.Point(20, 150);
            this.txtAdressu.Name = "txtAdressu";
            this.txtAdressu.Size = new System.Drawing.Size(221, 20);
            this.txtAdressu.TabIndex = 5;
            // 
            // txtPlatformu
            // 
            this.txtPlatformu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPlatformu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlatformu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPlatformu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPlatformu.Location = new System.Drawing.Point(20, 100);
            this.txtPlatformu.Name = "txtPlatformu";
            this.txtPlatformu.Size = new System.Drawing.Size(221, 20);
            this.txtPlatformu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(17, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adressu klijenta na platformu za komunikaciju";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Platformu za komunikacije klijenta";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.listDogadaj);
            this.groupBox2.Controls.Add(this.calendarRok);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(13, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opcijalan Ditalje Komisije";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(247, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Koji Događaj je vezan Komisiju";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Rok Komisije";
            // 
            // listDogadaj
            // 
            this.listDogadaj.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listDogadaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listDogadaj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listDogadaj.FormattingEnabled = true;
            this.listDogadaj.Location = new System.Drawing.Point(250, 49);
            this.listDogadaj.Name = "listDogadaj";
            this.listDogadaj.Size = new System.Drawing.Size(150, 21);
            this.listDogadaj.TabIndex = 1;
            // 
            // calendarRok
            // 
            this.calendarRok.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calendarRok.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calendarRok.Location = new System.Drawing.Point(11, 49);
            this.calendarRok.Name = "calendarRok";
            this.calendarRok.TabIndex = 0;
            // 
            // bntUnos
            // 
            this.bntUnos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntUnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntUnos.Location = new System.Drawing.Point(458, 378);
            this.bntUnos.Name = "bntUnos";
            this.bntUnos.Size = new System.Drawing.Size(312, 41);
            this.bntUnos.TabIndex = 20;
            this.bntUnos.Text = "Unesi";
            this.bntUnos.UseVisualStyleBackColor = false;
            this.bntUnos.Click += new System.EventHandler(this.bntUnos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.txtOpis);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtVrstu);
            this.groupBox3.Controls.Add(this.txtCijenu);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(438, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 348);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Komisiju";
            // 
            // txtOpis
            // 
            this.txtOpis.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtOpis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOpis.Location = new System.Drawing.Point(20, 154);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(312, 175);
            this.txtOpis.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(17, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Opis Komisije";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(17, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vrstu Komisiju";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cijenu Komisiju";
            // 
            // txtVrstu
            // 
            this.txtVrstu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtVrstu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVrstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVrstu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtVrstu.Location = new System.Drawing.Point(20, 100);
            this.txtVrstu.Name = "txtVrstu";
            this.txtVrstu.Size = new System.Drawing.Size(221, 20);
            this.txtVrstu.TabIndex = 1;
            // 
            // txtCijenu
            // 
            this.txtCijenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCijenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCijenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCijenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCijenu.Location = new System.Drawing.Point(20, 50);
            this.txtCijenu.Name = "txtCijenu";
            this.txtCijenu.Size = new System.Drawing.Size(221, 20);
            this.txtCijenu.TabIndex = 0;
            // 
            // UnosKomisije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bntUnos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UnosKomisije";
            this.Text = "Umjetnik pomaganje - Unos Komisije";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdressu;
        private System.Windows.Forms.TextBox txtPlatformu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntUnos;
        private System.Windows.Forms.MonthCalendar calendarRok;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVrstu;
        private System.Windows.Forms.TextBox txtCijenu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox listDogadaj;
        private System.Windows.Forms.ComboBox cboxKlijent;
    }
}