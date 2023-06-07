using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    class cKlijent
    {
        string id, ime, platformuKomunikacije, adresaKomunikacije;

        public cKlijent(string id, string ime, string platformuKomunikacije, string adresaKomunikacije)
        {
            this.id = id;
            this.ime = ime;
            this.platformuKomunikacije = platformuKomunikacije;
            this.adresaKomunikacije = adresaKomunikacije;
        }
        public string ToCsvString()
        {
            return Id + "," + Ime + "," + PlatformuKomunikacije + "," + AdresaKomunikacije;
        }
        public override string ToString()
        {
            return "Ime Klijenta: " + Ime + " | Platformu za komunikaciju: " + PlatformuKomunikacije + " | Adressu klijenta na platformu za komunikaciju: " + AdresaKomunikacije + " | ";
        }
        public string Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string PlatformuKomunikacije { get => platformuKomunikacije; set => platformuKomunikacije = value; }
        public string AdresaKomunikacije { get => adresaKomunikacije; set => adresaKomunikacije = value; }
    }
}
