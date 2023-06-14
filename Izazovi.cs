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
    public partial class Izazovi : Form
    {
        cKorisnik user = new cKorisnik("UNDEFIND", "Ime Korsnika", 'M');

        internal cKorisnik User { get => user; set => user = value; }
        List<cIzazovi> ListaIzazove = new List<cIzazovi>();

        public Izazovi()
        {
            InitializeComponent();
            changeName();
            loadIzazovi();
        }

        private void bntNoviIzazov_Click(object sender, EventArgs e)
        {
            UnosIzazovi frmUnIzazov = new UnosIzazovi();

            DialogResult rezUnosIzazov = frmUnIzazov.ShowDialog();

            if(rezUnosIzazov == DialogResult.OK)
            {
                loadIzazovi();
            }
        }

        private void bntRandomIzazov_Click(object sender, EventArgs e)
        {
            if (ListaIzazove.Count>0)
            {
                try
                {
                    Random doRan = new Random();
                    int ranID = doRan.Next(0,ListaIzazove.Count);
                    MessageBox.Show("Naziv: "+ListaIzazove[ranID].Ime+" | Tezinu "+ ListaIzazove[ranID].Tezinu+" | Opis: "+ ListaIzazove[ranID].Opis);
                }
                catch { }
            }
        }

        private void bntMjenajKorisnik_Click(object sender, EventArgs e)
        {
            Korisnik frmKorisnik = new Korisnik();

            DialogResult rezKorsnik = frmKorisnik.ShowDialog();

            if (rezKorsnik == System.Windows.Forms.DialogResult.OK)
                user = frmKorisnik.CurrentKorisnik;
            changeName();
        }
        public void changeName()
        {
            string name = user.Ime;
            if (user.Prezime != null)
            {
                name += " " + user.Prezime;
            }
            name += " |";
            txtKorsinikIme.Text = name;
        }
        public void loadIzazovi()
        {
            string dirMain = "C:\\Users\\" + Environment.UserName + "\\Documents\\UmjetnikPomaganje";
            string fileKlijent = dirMain + "\\Izazove.csv";
            if (File.Exists(fileKlijent))
            {

                using (StreamReader reader = new StreamReader(File.OpenRead(fileKlijent)))
                {
                    string fileContent = reader.ReadToEnd();
                    string[] content = fileContent.Split(',');
                    int numb = 0;
                    ListaIzazove.Clear();
                    while (content.Length >= numb + 4)
                    {
                        cIzazovi loadKlijent = new cIzazovi(
                            content[numb + 0].Substring(0, content[numb].Length),
                            content[numb + 1].Substring(0, content[numb + 1].Length),
                            content[numb + 2].Substring(0, content[numb + 2].Length),
                            content[numb + 3].Substring(0, content[numb + 3].Length));
                        ListaIzazove.Add(loadKlijent);
                        numb += 4;
                    }

                }
            }
        }
    }
}
