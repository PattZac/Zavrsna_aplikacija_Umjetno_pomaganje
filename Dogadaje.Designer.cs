
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxDogadaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTxtBoxDogadaje
            // 
            this.rTxtBoxDogadaje.BackColor = System.Drawing.SystemColors.Control;
            this.rTxtBoxDogadaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtBoxDogadaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rTxtBoxDogadaje.Location = new System.Drawing.Point(6, 25);
            this.rTxtBoxDogadaje.Name = "rTxtBoxDogadaje";
            this.rTxtBoxDogadaje.Size = new System.Drawing.Size(363, 365);
            this.rTxtBoxDogadaje.TabIndex = 0;
            this.rTxtBoxDogadaje.Text = "";
            // 
            // groupBoxDogadaje
            // 
            this.groupBoxDogadaje.Controls.Add(this.rTxtBoxDogadaje);
            this.groupBoxDogadaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(80, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(207, 51);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Događaje";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Prikazaj sve Komisije";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "Mjenaj prikaz listu Komisije";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(64, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 41);
            this.button3.TabIndex = 15;
            this.button3.Text = "Unesi Novu Komisiju";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Dogadaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}