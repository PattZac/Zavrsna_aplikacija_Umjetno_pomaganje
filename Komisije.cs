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
    public partial class Komisije : Form
    {
        cKorisnik user = new cKorisnik("UNDEFIND", "Ime Korsnika", 'M');

        internal cKorisnik User { get => user; set => user = value; }
        public Komisije()
        {
            InitializeComponent();
            changeName();
        }
        int ListOrder = 0;
        private void bntListOrder_Click(object sender, EventArgs e)
        {
            ListOrder = (ListOrder + 1) % 6;
            switch (ListOrder)
            {
                case 0:
                    txtBoxListOrder.Text = "Prikaz List: Naj blizi";
                    break;
                case 1:
                    txtBoxListOrder.Text = "Prikaz List: Naj daletko";
                    break;
                case 2:
                    txtBoxListOrder.Text = "Prikaz List: Abecedi ascend";
                    break;
                case 3:
                    txtBoxListOrder.Text = "Prikaz List: Abecedi descend";
                    break;
                case 4:
                    txtBoxListOrder.Text = "Prikaz List: Cijenu ascend";
                    break;
                case 5:
                    txtBoxListOrder.Text = "Prikaz List: Cijenu descend";
                    break;
            }
        }

        private void bntUnosKomisiju_Click(object sender, EventArgs e)
        {
            UnosKomisije frmUnKomsije = new UnosKomisije();

            DialogResult rezUnosKomsije = frmUnKomsije.ShowDialog();
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
        List<cKlijent> ListaKlijenta = new List<cKlijent>();
        List<cKomisije> ListaKomisije = new List<cKomisije>();
        List<cDetaljeKomisije> ListaDetaljeKomsije = new List<cDetaljeKomisije>();
        public void loadKomsije()
        {
            string dirMain = "C:\\Users\\" + Environment.UserName + "\\Documents\\UmjetnikPomaganje";
            string fileKlijent = dirMain + "\\Klijenti.csv";
            if (File.Exists(fileKlijent))
            {

                using (StreamReader reader = new StreamReader(File.OpenRead(fileKlijent)))
                {
                    string fileContent = reader.ReadToEnd();
                    string[] content = fileContent.Split(',');
                    int numb = 0;
                    while (content.Length >= numb + 4)
                    {
                        cKlijent loadKlijent = new cKlijent(
                            content[numb + 0].Substring(0, content[numb].Length),
                            content[numb + 1].Substring(0, content[numb + 1].Length),
                            content[numb + 2].Substring(0, content[numb + 2].Length),
                            content[numb + 3].Substring(0, content[numb + 3].Length));
                        ListaKlijenta.Add(loadKlijent);
                        numb += 4;
                    }

                }
            }
            string fileKomsije = dirMain + "\\Komsije.csv";
            if (File.Exists(fileKlijent))
            {

                using (StreamReader reader = new StreamReader(File.OpenRead(fileKlijent)))
                {
                    string fileContent = reader.ReadToEnd();
                    string[] content = fileContent.Split(',');
                    int numb = 0;
                    while (content.Length >= numb + 3)
                    {
                        cKomisije loadKomisje = new cKomisije(
                            content[numb + 0].Substring(0, content[numb].Length),
                            Convert.ToDouble(content[numb + 1].Substring(0, content[numb + 1].Length)),
                            content[numb + 2].Substring(0, content[numb + 2].Length));
                        ListaKomisije.Add(loadKomisje);
                        numb += 3;
                    }

                }
            }
            string fileDetaljeKomsije = dirMain + "\\DetaljeKomsije.csv";
            if (File.Exists(fileKlijent))
            {

                using (StreamReader reader = new StreamReader(File.OpenRead(fileKlijent)))
                {
                    string fileContent = reader.ReadToEnd();
                    string[] content = fileContent.Split(',');
                    int numb = 0;
                    while (content.Length >= numb + 4)
                    {
                        cDetaljeKomisije loadDetaljeKomisije = new cDetaljeKomisije(
                            content[numb + 0].Substring(0, content[numb].Length),
                            content[numb + 1].Substring(0, content[numb + 1].Length),
                            Convert.ToDateTime(content[numb + 2].Substring(0, content[numb + 2].Length)),
                            content[numb + 3].Substring(0, content[numb + 3].Length));
                        ListaDetaljeKomsije.Add(loadDetaljeKomisije);
                        numb += 4;
                    }

                }
            }

            //SHOW
            foreach(cDetaljeKomisije dk in ListaDetaljeKomsije)
            {
                int dkKlijentNum = 0;
                int dkKomisijeNum = 0;
                foreach (cKlijent k in ListaKlijenta)
                {
                    if (k.Id == dk.IdKljient) {
                        dkKlijentNum= ListaKlijenta.IndexOf(k);
                    }
                }
                foreach (cKomisije k in ListaKomisije)
                {
                    if (k.Id == dk.IdKomisije) {
                        dkKomisijeNum = ListaKomisije.IndexOf(k);
                    }
                }
                Text = ListaKomisije[dkKomisijeNum].ToString() + ListaKlijenta[dkKlijentNum] + dk.Opis;
            }
            //rTxtBoxKomisije =;

        }
    }
}
