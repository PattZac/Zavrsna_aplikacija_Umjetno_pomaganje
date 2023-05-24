using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    class cIzazovi
    {
        string id, ime, opis, težinu;

        public cIzazovi(string id, string ime, string opis, string težinu)
        {
            this.id = id;
            this.ime = ime;
            this.opis = opis;
            this.težinu = težinu;
        }

        public string Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Opis { get => opis; set => opis = value; }
        public string Težinu { get => težinu; set => težinu = value; }
    }
}
