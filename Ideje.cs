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
    public partial class Ideje : Form
    {
        cKorisnik user = new cKorisnik("UNDEFIND", "Ime Korsnika", 'M');

        internal cKorisnik User { get => user; set => user = value; }
        public Ideje()
        {
            InitializeComponent();
            changeName();
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

        private void bntMjenajPrikaz_Click(object sender, EventArgs e)
        {
            MessageBox.Show(generate());
        }
        public string generate()
        {
            Random doRan = new Random();
            int ranID = doRan.Next(0,1);
            string text="";
            switch (ranID)
            {
                case 0: text = "Stablo s " + color() + " listove s jabuke oblika " + oblik() + " koji su boje" + color()+"."; break;
                case 1: text = "Nebo s buno "+oblik()+"kako padaju prema "+color()+"trava."; break;
            }
            return text;
        }
        public string color()
        {
            Random doRan = new Random();
            int ranID = doRan.Next(0, 9);
            string text="";
            switch (ranID)
            {
                case 0: text = "crveno"; break;
                case 1: text = "naračasto"; break;
                case 2: text = "žuto"; break;
                case 3: text = "zeleno"; break;
                case 4: text = "cijan"; break;
                case 5: text = "plavo"; break;
                case 6: text = "ljubičasto"; break;
                case 7: text = "rosa"; break;
                case 8: text = "bijelo"; break;
                case 9: text = "crno"; break;
            }
            return text;
        }
        public string oblik()
        {
            Random doRan = new Random();
            int ranID = doRan.Next(0, 9);
            string text = "";
            switch (ranID)
            {
                case 0: text = "kocka"; break;
                case 1: text = "krug"; break;
                case 2: text = "kvadrat"; break;
                case 3: text = "svijesda"; break;
                case 4: text = "leptir"; break;
                case 5: text = "srce"; break;
                case 6: text = "sunce"; break;
                case 7: text = "cvijet"; break;
                case 8: text = "piramida"; break;
                case 9: text = "prsten"; break;
            }
            return text;
        }
        List<cIzazovi> ListaIzazove = new List<cIzazovi>();
        private void bntNoviKomisiju_Click(object sender, EventArgs e)
        {
            loadIzazovi();
            if (ListaIzazove.Count > 0)
            {
                try
                {
                    Random doRan = new Random();
                    int ranID = doRan.Next(0, ListaIzazove.Count);
                    MessageBox.Show(generate()+"\nIzazov Naziv: " + ListaIzazove[ranID].Ime + " | Tezinu " + ListaIzazove[ranID].Tezinu + " | Opis: " + ListaIzazove[ranID].Opis);
                }
                catch { }
            }
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
