using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    class cKorisnik
    {
        string id = "1", ime = "ime", prezime;
        char spol;

        public string Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public char Spol { get => spol; set => spol = value; }


        public string ToCsvString(){
            string txt = Id + "," + Ime + "," + Spol + ",";
            if (Prezime != null)
            {
                txt += Prezime + ",";
            }
            else
            {
                txt += "NULL,";
            }
            return txt;
        }
        public override string ToString()
        {
            string txt = "Ime: " + Ime;
            if (Prezime != null)
            {
                txt += " "+Prezime;
            }
            if (Spol == 'M')
            {
                txt += " | Spol: Muški";
            }
            else if (Spol == 'Z') {
                txt += " | Spol: Ženski";
            }
            txt += " | ID: "+id;

            return txt;
        }

        public cKorisnik(string uId, string uIme, char uSpol)
        {
            Id = uId;
            Ime = uIme;
            Spol = uSpol;
        }
        public cKorisnik(string uId, string uIme, char uSpol, string uPrezime)
        {
            Id = uId;
            Ime = uIme;
            Spol = uSpol;
            Prezime = uPrezime;
        }
        public cKorisnik() { }
    }
}
