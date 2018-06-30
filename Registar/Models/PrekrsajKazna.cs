using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Registar.Models
{
    public class PrekrsajKazna
    {
        public int PrekrsajKaznaID   { get; set; }
        //int PrekrsajID { get; set; }
        //int KaznaID { get; set; }
        public virtual Kazna Kazna { get; set; }
        public virtual Prekrsaj Prekrsaj { get; set; }
    }
}
