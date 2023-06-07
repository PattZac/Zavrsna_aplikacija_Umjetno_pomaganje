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
    public partial class UnosKomisije : Form
    {
        List<cKlijent> ListaKlijenta = new List<cKlijent>();
        public UnosKomisije()
        {
            InitializeComponent();
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

                foreach (cKlijent os in ListaKlijenta)
                {
                    cboxKlijent.Items.Add(os.Ime);
                }
            }
        }

        private void bntUnos_Click(object sender, EventArgs e)
        {
            string dirMain = "C:\\Users\\" + Environment.UserName + "\\Documents\\UmjetnikPomaganje";
            StringBuilder output = new StringBuilder();
            String separator = ", ";

            if (cboxKlijent.Text == "Novi Klijent" || cboxKlijent.Text == "") {
                Rando: Random doRan = new Random();
                string ranID = Convert.ToString(doRan.Next());
                foreach (cKlijent os in ListaKlijenta)
                {
                    if (os.Id == ranID)
                    {
                        goto Rando;
                    }
                }
                cKlijent oKlijent = new cKlijent(ranID, txtIme.Text, txtPlatformu.Text, txtAdressu.Text);
                ListaKlijenta.Add(oKlijent);
                cboxKlijent.Items.Clear();
                foreach (cKlijent os in ListaKlijenta)
                {
                    cboxKlijent.Items.Add(os);
                }
                cboxKlijent.SelectedIndex = ListaKlijenta.Count-1; //error rn

                string fileKlijent = dirMain + "\\Klijenti.csv";

                String[] headings = { "ID", "Ime", "Platformu", "Adresu" };
                foreach(cKlijent os in ListaKlijenta)
                {
                    String[] newLine = { os.ToCsvString() };
                    output.AppendLine(string.Join(separator, newLine));
                }
                File.Delete(fileKlijent);
                try
                {
                    File.AppendAllText(fileKlijent, output.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Pogrešan u spremanje podatke", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Rando2: Random doRan2 = new Random();
            string ranID2 = Convert.ToString(doRan2.Next());
            foreach (cKlijent os in ListaKlijenta)
            {
                if (os.Id == ranID2)
                {
                    goto Rando2;
                }
            }
            cKomisije oKomisije = new cKomisije(ranID2,Convert.ToDouble(txtCijenu.Text),txtVrstu.Text);
            cDetaljeKomisije oDetaljeKomsije = new cDetaljeKomisije(oKomisije.Id, ListaKlijenta[cboxKlijent.SelectedIndex].Id, DateTime.Now, txtOpis.Text);


            string fileKomsije = dirMain + "\\Komsije.csv";
            string fileDetaljeKomsije = dirMain + "\\DetaljeKomsije.csv";

            output = new StringBuilder();
            String[] headingsKomsije = { "ID", "Cijenu", "Vrstu" };
            String[] newLineKomsije = { oKomisije.ToCsvString() };
            output.AppendLine(string.Join(separator, newLineKomsije));
            File.Delete(fileKomsije);
            try
            {
                File.AppendAllText(fileKomsije, output.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pogrešan u spremanje podatke", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            output = new StringBuilder();
            String[] headingsDetaljeKomsije = { "ID Komsije", "ID Klijent", "Datum Napravljen",  "Opis", "Rok" };
            String[] newLineDetaljeKomsije = { oKomisije.ToCsvString() };
            output.AppendLine(string.Join(separator, newLineDetaljeKomsije));
            File.Delete(fileKomsije);
            try
            {
                File.AppendAllText(fileDetaljeKomsije, output.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pogrešan u spremanje podatke", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
