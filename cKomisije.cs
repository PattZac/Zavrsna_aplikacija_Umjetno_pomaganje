using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    class cKomisije
    {
        double cijenu;
        string id, vrstu, idDogadaja;

        public cKomisije(string id,double cijenu, string vrstu)
        {
            this.id = id;
            this.cijenu = cijenu;
            this.vrstu = vrstu;
        }
        public string ToCsvString()
        {
            return Id + "," + Cijenu + "," + Vrstu;
        }
        public override string ToString()
        {
            return "Vrtsu Komsiju: " + Vrstu + " | Cijenu: " + Cijenu + "euro |";
        }
        public double Cijenu { get => cijenu; set => cijenu = value; }
        public string Vrstu { get => vrstu; set => vrstu = value; }
        public string Id { get => id; set => id = value; }
        public string IdDogadaja { get => idDogadaja; set => idDogadaja = value; }
    }
}
