using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registar.Models
{
    public class Osoba
    {
        public int OsobaID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Int64 JMBG { get; set; }
        public string VozackaDozvola { get; set; }
        public Automobil Automobil { get; set; }
        public Spol Spol { get; set; }
    }
}
