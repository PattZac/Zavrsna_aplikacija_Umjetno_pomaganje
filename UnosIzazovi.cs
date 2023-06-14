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
    public partial class UnosIzazovi : Form
    {
        List<cIzazovi> ListaIzazove = new List<cIzazovi>();
        public UnosIzazovi()
        {
            InitializeComponent();
            string dirMain = "C:\\Users\\" + Environment.UserName + "\\Documents\\UmjetnikPomaganje";
            string fileKlijent = dirMain + "\\Izazove.csv";
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

            if (txtBoxIme != null && txtBoxTezina != null)
            {

            Rando: Random doRan = new Random();
                string ranID = Convert.ToString(doRan.Next());
                foreach (cIzazovi os in ListaIzazove)
                {
                    if (os.Id == ranID)
                    {
                        goto Rando;
                    }
                }

                cIzazovi newIzazove = new cIzazovi(ranID, txtBoxIme.Text, txtBoxOpis.Text, txtBoxTezina.Text);
                ListaIzazove.Add(newIzazove);
                string fileKlijent = dirMain + "\\Izazove.csv";

                String[] headings = { "ID", "Ime", "Težina", "Opis" };
                foreach (cIzazovi os in ListaIzazove)
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
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
