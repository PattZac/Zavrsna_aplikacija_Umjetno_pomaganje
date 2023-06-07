using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            Korisnik frmKorisnik = new Korisnik();

            DialogResult rezKorsnik = frmKorisnik.ShowDialog();

            if (rezKorsnik == System.Windows.Forms.DialogResult.OK)
            {
                User = frmKorisnik.CurrentKorisnik;
            }

            InitializeComponent();

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
    }
}
