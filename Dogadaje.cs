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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    public partial class Dogadaje : Form
    {
        cKorisnik user = new cKorisnik("UNDEFIND", "Ime Korsnika", 'M');

        internal cKorisnik User { get => user; set => user = value; }
        public Dogadaje()
        {
            InitializeComponent();
            changeName();
            loadDogadaj();
        }
        int ListOrder = 0;
        private void bntUnosDogadaje_Click(object sender, EventArgs e)
        {
            UnosDogadaje frmUnDogadaje = new UnosDogadaje();

            DialogResult rezUnosDogadaje = frmUnDogadaje.ShowDialog();
            if (rezUnosDogadaje == System.Windows.Forms.DialogResult.OK)
                loadDogadaj();
        }

        private void bntListOrder_Click(object sender, EventArgs e)
        {
            ListOrder = (ListOrder + 1) % 4;
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
            foreach(cDogadaja cd in ListaDogadaja)
            {
                if (cd.KrajniDatum==cd.PocetniDatum && cd.PocetniDatum!= DateTime.Now || cd.KrajniDatum != cd.PocetniDatum && cd.KrajniDatum != DateTime.Now)
                {
                    if (text!="")
                    {
                        text += "\n\n|\n\n";
                    }
                    text += "Naziv: " + cd.Ime;
                    if (cd.Lokacija != null)
                    {
                        text += " | Lokacija: " + cd.Lokacija;
                    }
                    text += " | Datum: " + cd.PocetniDatum+" do " + cd.KrajniDatum;
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
