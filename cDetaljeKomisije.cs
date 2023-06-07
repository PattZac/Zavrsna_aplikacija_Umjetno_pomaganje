using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    class cDetaljeKomisije
    {
        DateTime datumNapravljen, rok;
        string opis, idKomisije, idKljient;

        public cDetaljeKomisije(string idKomisije, string idKljient, DateTime datumNapravljen,/* DateTime rok,*/ string opis)
        {
            this.idKomisije = idKomisije;
            this.idKljient = idKljient;
            this.datumNapravljen = datumNapravljen;
            //this.rok = rok;
            this.opis = opis;
        }
        public string ToCsvString()
        {
            string output= IdKomisije+","+IdKljient + "," +DatumNapravljen + "," +opis + ",";
            if (rok!=null)
            {
                output += rok + ",";
            }
            else
            {
                output += "NULL,";
            }
            return output;
        }
        public DateTime DatumNapravljen { get => datumNapravljen; set => datumNapravljen = value; }
        public DateTime Rok { get => rok; set => rok = value; }
        public string Opis { get => opis; set => opis = value; }
        public string IdKomisije { get => idKomisije; set => idKomisije = value; }
        public string IdKljient { get => idKljient; set => idKljient = value; }
    }
}
