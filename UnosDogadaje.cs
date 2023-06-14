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
    public partial class UnosDogadaje : Form
    {
        List<cDogadaja> ListaDogadaja = new List<cDogadaja>();
        List<cIzazovi> ListaIzazove = new List<cIzazovi>();
        public UnosDogadaje()
        {
            InitializeComponent();
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
                        if (loadKlijent.Lokacija=="NULL") 
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
            fileKlijent = dirMain + "\\Izazove.csv";
            if (File.Exists(fileKlijent))
            {

                using (StreamReader reader = new StreamReader(File.OpenRead(fileKlijent)))
                {
                    string fileContent = reader.ReadToEnd();
                    string[] content = fileContent.Split(',');
                    int numb = 0;
                    while (content.Length >= numb + 4)
                    {
                        cIzazovi loadKlijent = new cIzazovi(
                            content[numb + 0].Substring(0, content[numb].Length),
                            content[numb + 1].Substring(0, content[numb + 1].Length),
                            content[numb + 2].Substring(0, content[numb + 2].Length),
                            content[numb + 3].Substring(0, content[numb + 3].Length));
                        ListaIzazove.Add(loadKlijent);
                        numb += 4;
                    }

                }
            }
        }

        
        private void bntUnos_Click(object sender, EventArgs e)
        {
            string dirMain = "C:\\Users\\" + Environment.UserName + "\\Documents\\UmjetnikPomaganje";
            StringBuilder output = new StringBuilder();
            String separator = ", ";

            if (txtBoxIme!=null && monthCalendar1!=null)
            {

                Rando: Random doRan = new Random();
                string ranID = Convert.ToString(doRan.Next());
                foreach (cDogadaja os in ListaDogadaja)
                {
                    if (os.Id == ranID)
                    {
                         goto Rando;
                    }
                }

                cDogadaja newDogadaj = new cDogadaja(ranID, txtBoxIme.Text, monthCalendar1.SelectionStart, txtBoxOpis.Text, monthCalendar1.SelectionEnd);
                if (txtBoxLokacija.Text != null || txtBoxLokacija.Text != null) {
                    newDogadaj.Lokacija = txtBoxLokacija.Text;
                }
                /*if (cboxIzazov.Text != null || cboxIzazov.Text != "" || cboxIzazov.SelectedIndex> ListaIzazove.Count)
                {
                    newDogadaj.IzazovId = ListaIzazove[cboxIzazov.SelectedIndex].Id;
                }*/
                ListaDogadaja.Add(newDogadaj);
                string fileKlijent = dirMain + "\\Dogadaja.csv";

                String[] headings = { "ID", "Ime", "PocetniDatum", "Opis", "KrajniDatum", "Lokacija", "IzazovId" };
                foreach (cDogadaja os in ListaDogadaja)
                {
                    String[] newLine = { os.ToCsvString() };
                    output.AppendLine(string.Join(separator, newLine));
                }
                //File.Delete(fileKlijent);
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
