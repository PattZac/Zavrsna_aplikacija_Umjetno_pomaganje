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
    public partial class Izazovi : Form
    {
        cKorisnik user = new cKorisnik("UNDEFIND", "Ime Korsnika", 'M');

        internal cKorisnik User { get => user; set => user = value; }

        public Izazovi()
        {
            InitializeComponent();
            changeName();
        }

        private void bntNoviIzazov_Click(object sender, EventArgs e)
        {
            UnosKomisije frmUnKomisije = new UnosKomisije();

            DialogResult rezUnosKomsije = frmUnKomisije.ShowDialog();
        }

        private void bntRandomIzazov_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Random Izazov'");
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
    }
}
