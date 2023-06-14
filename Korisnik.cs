using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    public partial class Korisnik : Form
    {
        List<cKorisnik> ListaKorsnike = new List<cKorisnik>();

        public Korisnik()
        {
            InitializeComponent();
            string dirMain = "C:\\Users\\" + Environment.UserName + "\\Documents\\UmjetnikPomaganje";
            string fileKorsnik = dirMain + "\\Korisnike.csv";
            if (File.Exists(fileKorsnik))
            {

                using (StreamReader reader = new StreamReader(File.OpenRead(fileKorsnik)))
                {
                    string fileContent = reader.ReadToEnd();
                    string[] content = fileContent.Split(',');
                    int numb = 0;
                    while (content.Length >= numb + 4)
                    {
                        cKorisnik loadKorsnike = new cKorisnik(
                            content[numb + 0].Substring(0, content[numb].Length),
                            content[numb + 1].Substring(0, content[numb + 1].Length),
                            Convert.ToChar(content[numb + 2].Substring(0, 1)),
                            content[numb + 3].Substring(0, content[numb + 3].Length));
                        if (loadKorsnike.Prezime == "NULL")
                        {
                            loadKorsnike.Prezime = null;
                        }
                        ListaKorsnike.Add(loadKorsnike);
                        numb += 4;
                    }
                    
                }

                foreach (cKorisnik os in ListaKorsnike)
                {
                    listBoxKorsinike.Items.Add(os.ToString());
                }
            }
        }


        private void bntNoviKorsnik_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != "" && cboxSpol.Text != "")
            {
                Rando: Random doRan = new Random();
                string ranID = Convert.ToString(doRan.Next());
                foreach(cKorisnik os in ListaKorsnike)
                {
                    if (os.Id==ranID) {
                        goto Rando;
                    }
                }
            
                char spol = 'Z';
                if (cboxSpol.Text=="Muški")
                {
                    spol = 'M';
                }

                if (txtPrezime.Text=="") 
                {
                    cKorisnik oKorisnik= new cKorisnik(ranID, txtIme.Text, spol);
                    ListaKorsnike.Add(oKorisnik);
                }
                else
                {
                    cKorisnik oKorisnik = new cKorisnik(ranID, txtIme.Text, spol, txtPrezime.Text);
                    ListaKorsnike.Add(oKorisnik);
                }
                
            
                

                string dirMain = "C:\\Users\\"+Environment.UserName+"\\Documents\\UmjetnikPomaganje";

                if (!Directory.Exists(dirMain))
                {
                    Directory.CreateDirectory(dirMain);
                }

                string fileKorsnik = dirMain+"\\Korisnike.csv";
                
                    StringBuilder output = new StringBuilder();
                    String separator = ", ";
                    String[] headings = { "ID", "Ime", "Spol", "Prezime" };
                    foreach (cKorisnik os in ListaKorsnike)
                    {
                        String[] newLine = { os.ToCsvString() };
                        output.AppendLine(string.Join(separator, newLine));
                    }
                    File.Delete(fileKorsnik);
                    try
                    {
                        File.AppendAllText(fileKorsnik, output.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Pogrešan u spremanje podatke", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                listBoxKorsinike.Items.Clear();
                foreach (cKorisnik os in ListaKorsnike)
                {
                    listBoxKorsinike.Items.Add(os.ToString());
                }
                txtIme.Clear();
                cboxSpol.Text="";
                txtPrezime.Clear();
            }
        }
        private cKorisnik currentKorisnik;
        internal cKorisnik CurrentKorisnik { get => currentKorisnik; set => currentKorisnik = value; }
        private void bntPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentKorisnik = ListaKorsnike[listBoxKorsinike.SelectedIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Izabraj korisnik iz listu kornsnika, ako nema onda napravite novi i izabraj korsnik","Greška!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
