using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registar.Models
{
    public class PolicajacPS
    {
        public int  PolicajacPSID { get; set; }
        public virtual Policajac Policajac { get; set; }
        public virtual PolicijskaStanica PolicijskaStanica { get; set; }

    }

}
