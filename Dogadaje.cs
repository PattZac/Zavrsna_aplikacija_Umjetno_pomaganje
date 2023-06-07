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
    public partial class Dogadaje : Form
    {
        cKorisnik user = new cKorisnik("UNDEFIND", "Ime Korsnika", 'M');

        internal cKorisnik User { get => user; set => user = value; }
        public Dogadaje()
        {
            InitializeComponent();
            changeName();
        }
        int ListOrder = 0;
        private void bntUnosDogadaje_Click(object sender, EventArgs e)
        {
            UnosDogadaje frmUnDogadaje = new UnosDogadaje();

            DialogResult rezUnosDogadaje = frmUnDogadaje.ShowDialog();
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
    }
}
