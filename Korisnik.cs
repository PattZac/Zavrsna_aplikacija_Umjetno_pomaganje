using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    public partial class Korisnik : Form
    {
        public Korisnik()
        {
            InitializeComponent();
        }

        private void bntNoviKorsnik_Click(object sender, EventArgs e)
        {
            //var fileStream = "C:\Users\korisnik\Documents\UmjetnikPomaganje".OpenFile();

            //Directory local = "C:\\Users\\"+Environment.UserName+"\\Documents\\UmjetnikPomaganje";

            /*using (StreamReader reader = new StreamReader(fileStream))
            {
                        /*string fileContent = reader.ReadToEnd();
                        string[] content = fileContent.Split(',');
                        int numb = 5;
                        while (content.Length >= numb + 5)
                        {
                            Osoba osoba = new Osoba(content[numb].Substring(1, content[numb].Length - 1),
                                content[numb + 1].Substring(1, content[numb + 1].Length - 1),
                                Convert.ToInt16(content[numb + 2].Substring(1, content[numb + 2].Length - 1)),
                                Convert.ToChar(content[numb + 3].Substring(1, 1)));
                            ListaOsoba.Add(osoba);
                            numb += 5;
                        }
                        textBox4.Text = "File Loadded!";
            }*/
        }
    }
}
