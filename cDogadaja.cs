using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    class cDogadaja
    {
        string id, ime, opis, lokacija, izazovId;
        DateTime pocetniDatum, krajniDatum;

        public string Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public DateTime PocetniDatum { get => pocetniDatum; set => pocetniDatum = value; }
        public string Opis { get => opis; set => opis = value; }
        public DateTime KrajniDatum { get => krajniDatum; set => krajniDatum = value; }
        public string Lokacija { get => lokacija; set => lokacija = value; }
        public string IzazovId { get => izazovId; set => izazovId = value; }

        public cDogadaja(string uId, string uIme, DateTime uPocetniDatum, string uOpis, DateTime uKrajniDatum/*, string uLokacija, string uIzazovId*/)
        {
            Id = uId;
            Ime = uIme;
            PocetniDatum = uPocetniDatum;
            Opis = uOpis;
            KrajniDatum = uKrajniDatum;
            //Lokacija = uLokacija;
            //IzazovId = uIzazovId;
        }
        public cDogadaja(string uId, string uIme, DateTime uPocetniDatum, string uOpis, DateTime uKrajniDatum, string uLokacija, string uIzazovId)
        {
            Id = uId;
            Ime = uIme;
            PocetniDatum = uPocetniDatum;
            Opis = uOpis;
            KrajniDatum = uKrajniDatum;
            Lokacija = uLokacija;
            IzazovId = uIzazovId;
        }
        public cDogadaja() { }
        public string ToCsvString()
        {
            string output = Id + "," + Ime + "," + PocetniDatum + "," + Opis + "," + KrajniDatum + ",";
            if (Lokacija!=null)
            {
                output += Lokacija + ",";
            }
            else
            {
                output += "NULL,";
            }
            if (IzazovId!=null)
            {
                output += IzazovId + ",";
            }
            else { output += "NULL,"; }
            return output;
        }
    }
}
