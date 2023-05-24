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
        public Izazovi()
        {
            InitializeComponent();
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
        }
    }
}
