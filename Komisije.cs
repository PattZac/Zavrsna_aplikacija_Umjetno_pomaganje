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
    public partial class Komisije : Form
    {
        public Komisije()
        {
            InitializeComponent();
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
        }
    }
}
