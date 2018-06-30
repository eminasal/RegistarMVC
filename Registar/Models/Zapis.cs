using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registar.Models
{
    public class Zapis
    {
        public int ZapisID { get; set; }
        public Policajac PolicajacID { get; set; }
        public Osoba OsobaID { get; set; }
        public Prekrsaj PrekrsajID { get; set; }
        public DateTime Datum { get; set; }
    }
}
