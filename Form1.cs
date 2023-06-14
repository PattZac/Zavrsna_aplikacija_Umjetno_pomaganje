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
    public partial class MainForm : Form
    {
       cKorisnik User = new cKorisnik("UNDEFIND", "Ime Korsnika", 'M');
        public MainForm() {

            reset: Korisnik frmKorisnik = new Korisnik();

            DialogResult rezKorsnik = frmKorisnik.ShowDialog();

            if (rezKorsnik == System.Windows.Forms.DialogResult.OK)
            {
                User = frmKorisnik.CurrentKorisnik;
            }
            else
            {
                goto reset;
            }

            InitializeComponent();
            loadKomsije();
            loadDogadaj();
            changeName();
        }

        private void bntIzazovi_Click(object sender, EventArgs e)
        {
            Izazovi frmIzazovi = new Izazovi();
            frmIzazovi.User = User;
            frmIzazovi.changeName();
            frmIzazovi.Show();
        }

        private void bntDogadaje_Click(object sender, EventArgs e)
        {
            Dogadaje frmDogadaje = new Dogadaje();
            frmDogadaje.User = User;
            frmDogadaje.changeName();
            frmDogadaje.Show();
            
        }

        private void bntIdeje_Click(object sender, EventArgs e)
        {
            Ideje frmIdeje = new Ideje();
            frmIdeje.User = User;
            frmIdeje.changeName();
            frmIdeje.Show();
            
        }

        private void bntKomisiju_Click(object sender, EventArgs e)
        {
            Komisije frmKomisije = new Komisije();
            frmKomisije.User = User;
            frmKomisije.loadKomsije();
            frmKomisije.changeName();
            frmKomisije.Show();
            
        }
        private void bntMjenajKorisnik_Click(object sender, EventArgs e)
        {
            Korisnik frmKorisnik = new Korisnik();

            DialogResult rezKorsnik = frmKorisnik.ShowDialog();

            if (rezKorsnik == System.Windows.Forms.DialogResult.OK)
                User = frmKorisnik.CurrentKorisnik;
            changeName();
            loadKomsije();
        }
        private void changeName()
        {
            string name = User.Ime;
            if (User.Prezime != null)
            {
                name += " " + User.Prezime;
            }
            name += " |";
            txtKorsinikIme.Text = name;
        }
        List<cKlijent> ListaKlijenta = new List<cKlijent>();
        List<cKomisije> ListaKomisije = new List<cKomisije>();
        List<cDetaljeKomisije> ListaDetaljeKomsije = new List<cDetaljeKomisije>();
        public void loadKomsije()
        {
            rTxtBoxKomisije.Clear();
            string dirMain = "C:\\Users\\" + Environment.UserName + "\\Documents\\UmjetnikPomaganje";
            string fileKlijent = dirMain + "\\Klijenti.csv";
            if (File.Exists(fileKlijent))
            {
                using (StreamReader reader = new StreamReader(File.OpenRead(fileKlijent)))
                {
                    string fileContent = reader.ReadToEnd();
                    string[] content = fileContent.Split(',');
                    int numb = 0;
                    ListaKlijenta.Clear();
                    while (content.Length >= numb + 4)
                    {

                        cKlijent loadKlijent = new cKlijent(
                            content[numb + 0].Substring(0, content[numb].Length),
                            content[numb + 1].Substring(0, content[numb + 1].Length),
                            content[numb + 2].Substring(0, content[numb + 2].Length),
                            content[numb + 3].Substring(0, content[numb + 3].Length));
                        ListaKlijenta.Add(loadKlijent);
                        if (numb > 1)
                        { // Neznam zašto ali ID ima \n na početku i radije grešku non stop pa evo zalucija za to 
                            loadKlijent.Id = content[numb + 0].Substring(2, content[numb].Length - 2);
                        }
                        numb += 4;
                    }
                }
                string fileKomsije = dirMain + "\\Komsije.csv";
                if (File.Exists(fileKomsije))
                {
                    using (StreamReader reader = new StreamReader(File.OpenRead(fileKomsije)))
                    {
                        string fileContent = reader.ReadToEnd();
                        string[] content = fileContent.Split(',');
                        int numb = 0;
                        ListaKomisije.Clear();
                        while (content.Length >= numb + 5)
                        {
                            cKomisije loadKomisje = new cKomisije(
                                content[numb + 0].Substring(0, content[numb].Length),
                                Convert.ToDouble(content[numb + 1].Substring(0, content[numb + 1].Length)),
                                content[numb + 2].Substring(0, content[numb + 2].Length),
                                content[numb + 3].Substring(0, content[numb + 3].Length),
                                content[numb + 4].Substring(0, content[numb + 4].Length));
                            if (loadKomisje.IdDogadaja == "NULL")
                            {
                                loadKomisje.IdDogadaja = null;
                            }
                            ListaKomisije.Add(loadKomisje);
                            numb += 5;
                        }

                    }

                    string fileDetaljeKomsije = dirMain + "\\DetaljeKomsije.csv";
                    if (File.Exists(fileDetaljeKomsije))
                    {
                        using (StreamReader reader = new StreamReader(File.OpenRead(fileDetaljeKomsije)))
                        {
                            string fileContent = reader.ReadToEnd();
                            string[] content = fileContent.Split(',');
                            int numb = 0;
                            ListaDetaljeKomsije.Clear();
                            while (content.Length >= numb + 5)
                            {
                                cDetaljeKomisije loadDetaljeKomisije = new cDetaljeKomisije(
                                    content[numb + 0].Substring(0, content[numb].Length),
                                    content[numb + 1].Substring(0, content[numb + 1].Length),
                                    Convert.ToDateTime(content[numb + 2].Substring(0, content[numb + 2].Length)),
                                    content[numb + 3].Substring(0, content[numb + 3].Length));
                                if (content[numb + 4].Substring(0, content[numb + 4].Length) == "NULL")
                                {
                                    loadDetaljeKomisije.Rok = Convert.ToDateTime(content[numb + 4].Substring(0, content[numb + 4].Length));
                                }
                                ListaDetaljeKomsije.Add(loadDetaljeKomisije);
                                numb += 5;
                            }

                        }

                        string Text = "";
                        //SHOW
                        foreach (cDetaljeKomisije dk in ListaDetaljeKomsije)
                        {
                            int dkKlijentNum = 0;
                            int dkKomisijeNum = 0;

                            foreach (cKlijent k in ListaKlijenta)
                            {
                                if (k.Id == dk.IdKljient)
                                {
                                    dkKlijentNum = ListaKlijenta.IndexOf(k);
                                }
                            }
                            foreach (cKomisije k in ListaKomisije)
                            {
                                if (k.Id == dk.IdKomisije)
                                {
                                    dkKomisijeNum = ListaKomisije.IndexOf(k);
                                }
                            }

                            if (ListaKomisije[dkKomisijeNum].IdKorisnik == User.Id)
                            {
                                if (Text != "")
                                {
                                    Text += "\n\n|\n\n";
                                }
                                Text += ListaKomisije[dkKomisijeNum].ToString() + "\n" + ListaKlijenta[dkKlijentNum].ToString() + "\n\tOpis: " + dk.Opis;
                            }
                        }
                        rTxtBoxKomisije.Text = Text;
                    }
                }
            }
        }
        List<cDogadaja> ListaDogadaja = new List<cDogadaja>();
        public void loadDogadaj()
        {
            string dirMain = "C:\\Users\\" + Environment.UserName + "\\Documents\\UmjetnikPomaganje";
            string fileKlijent = dirMain + "\\Dogadaja.csv";
            if (File.Exists(fileKlijent))
            {

                using (StreamReader reader = new StreamReader(File.OpenRead(fileKlijent)))
                {
                    string fileContent = reader.ReadToEnd();
                    string[] content = fileContent.Split(',');
                    int numb = 0;
                    while (content.Length >= numb + 7)
                    {
                        cDogadaja loadKlijent = new cDogadaja(
                            content[numb + 0].Substring(0, content[numb].Length),
                            content[numb + 1].Substring(0, content[numb + 1].Length),
                            Convert.ToDateTime(content[numb + 2].Substring(0, content[numb + 2].Length)),
                            content[numb + 3].Substring(0, content[numb + 3].Length),
                            Convert.ToDateTime(content[numb + 4].Substring(0, content[numb + 4].Length)),
                            content[numb + 5].Substring(0, content[numb + 5].Length),
                            content[numb + 6].Substring(0, content[numb + 6].Length));
                        if (loadKlijent.Lokacija == "NULL")
                        {
                            loadKlijent.Lokacija = null;
                        }
                        if (loadKlijent.IzazovId == "NULL")
                        {
                            loadKlijent.IzazovId = null;
                        }
                        ListaDogadaja.Add(loadKlijent);
                        numb += 7;
                    }

                }
            }
            string text = "";
            foreach (cDogadaja cd in ListaDogadaja)
            {
                if (cd.KrajniDatum == cd.PocetniDatum && cd.PocetniDatum != DateTime.Now || cd.KrajniDatum != cd.PocetniDatum && cd.KrajniDatum != DateTime.Now)
                {
                    if (text != "")
                    {
                        text += "\n\n|\n\n";
                    }
                    text += "Naziv: " + cd.Ime;
                    if (cd.Lokacija != null)
                    {
                        text += " | Lokacija: " + cd.Lokacija;
                    }
                    text += " | Datum: " + cd.PocetniDatum + " do " + cd.KrajniDatum;
                    if (cd.IzazovId != null)
                    {

                    }
                    text += "\n\t| Opis: " + cd.Opis;
                }
            }
            rTxtBoxDogadaje.Text = text;
        }
    }
}
