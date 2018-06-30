using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registar.Models
{
    public class Automobil
    {
        public int AutomobilID { get; set; }
        public string Tablice { get; set; }
        public Brend Brend { get; set; }
    }
}
