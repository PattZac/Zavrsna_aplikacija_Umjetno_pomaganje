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
        public MainForm()
        {
            /*Korisnik frmKorisnik = new Korisnik();

            DialogResult rezKorsnik = frmKorisnik.ShowDialog();

            if (rezKorsnik == DialogResult.OK)
            {
                cKorisnik User = new cKorisnik(frmKorisnik.User);
            }*/
            InitializeComponent();

            //cKorisnik User = new cKorisnik("SampleName", 'M', "SamplePrezime");
            //txtKorsinikIme.Text = User.Ime + " " + User.Prezime+" |";
            txtKorsinikIme.Text = Environment.UserName + " |";
        }

        private void bntIzazovi_Click(object sender, EventArgs e)
        {
            Izazovi frmIzazovi = new Izazovi();

            frmIzazovi.Show();
        }

        private void bntDogadaje_Click(object sender, EventArgs e)
        {
            Dogadaje frmDogadaje = new Dogadaje();

            frmDogadaje.Show();
        }

        private void bntIdeje_Click(object sender, EventArgs e)
        {
            Ideje frmIdeje = new Ideje();

            frmIdeje.Show();
        }

        private void bntKomisiju_Click(object sender, EventArgs e)
        {
            Komisije frmKomisije = new Komisije();

            frmKomisije.Show();
        }

        private void bntMjenajKorisnik_Click(object sender, EventArgs e)
        {
            Korisnik frmKorisnik = new Korisnik();

            DialogResult rezKorsnik = frmKorisnik.ShowDialog();
        }
    }
}
