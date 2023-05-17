
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
            this.bntNoviKomisiju = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.bntMjenajPrikaz = new System.Windows.Forms.Button();
            this.bntPrikazajKomisije = new System.Windows.Forms.Button();
            this.groupBOxKomisije.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBOxKomisije
            // 
            this.groupBOxKomisije.Controls.Add(this.rTxtBoxKomisije);
            this.groupBOxKomisije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBOxKomisije.Location = new System.Drawing.Point(413, 42);
            this.groupBOxKomisije.Name = "groupBOxKomisije";
            this.groupBOxKomisije.Size = new System.Drawing.Size(375, 396);
            this.groupBOxKomisije.TabIndex = 10;
            this.groupBOxKomisije.TabStop = false;
            this.groupBOxKomisije.Text = "Komisije";
            // 
            // rTxtBoxKomisije
            // 
            this.rTxtBoxKomisije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtBoxKomisije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rTxtBoxKomisije.Location = new System.Drawing.Point(6, 25);
            this.rTxtBoxKomisije.Name = "rTxtBoxKomisije";
            this.rTxtBoxKomisije.ReadOnly = true;
            this.rTxtBoxKomisije.Size = new System.Drawing.Size(363, 365);
            this.rTxtBoxKomisije.TabIndex = 6;
            this.rTxtBoxKomisije.Text = "";
            // 
            // bntNoviKomisiju
            // 
            this.bntNoviKomisiju.Location = new System.Drawing.Point(64, 365);
            this.bntNoviKomisiju.Name = "bntNoviKomisiju";
            this.bntNoviKomisiju.Size = new System.Drawing.Size(241, 41);
            this.bntNoviKomisiju.TabIndex = 3;
            this.bntNoviKomisiju.Text = "Unesi Novu Komisiju";
            this.bntNoviKomisiju.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(89, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(187, 51);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Komisije";
            // 
            // bntMjenajPrikaz
            // 
            this.bntMjenajPrikaz.Location = new System.Drawing.Point(64, 225);
            this.bntMjenajPrikaz.Name = "bntMjenajPrikaz";
            this.bntMjenajPrikaz.Size = new System.Drawing.Size(241, 41);
            this.bntMjenajPrikaz.TabIndex = 2;
            this.bntMjenajPrikaz.Text = "Mjenaj prikaz listu Komisije";
            this.bntMjenajPrikaz.UseVisualStyleBackColor = true;
            // 
            // bntPrikazajKomisije
            // 
            this.bntPrikazajKomisije.Location = new System.Drawing.Point(64, 95);
            this.bntPrikazajKomisije.Name = "bntPrikazajKomisije";
            this.bntPrikazajKomisije.Size = new System.Drawing.Size(241, 41);
            this.bntPrikazajKomisije.TabIndex = 1;
            this.bntPrikazajKomisije.Text = "Prikazaj sve Komisije";
            this.bntPrikazajKomisije.UseVisualStyleBackColor = true;
            // 
            // Komisije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntPrikazajKomisije);
            this.Controls.Add(this.bntMjenajPrikaz);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.bntNoviKomisiju);
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
        private System.Windows.Forms.Button bntNoviKomisiju;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button bntMjenajPrikaz;
        private System.Windows.Forms.Button bntPrikazajKomisije;
    }
}