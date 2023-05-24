using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsna_aplikacija_Umjetno_pomaganje
{
    class cKomisije
    {
        float cijenu;
        string id, vrstu;

        public cKomisije(string id,float cijenu, string vrstu)
        {
            this.id = id;
            this.cijenu = cijenu;
            this.vrstu = vrstu;
        }

        public float Cijenu { get => cijenu; set => cijenu = value; }
        public string Vrstu { get => vrstu; set => vrstu = value; }
        public string Id { get => id; set => id = value; }
    }
}
