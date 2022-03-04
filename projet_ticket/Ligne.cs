using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_ticket
{
    public class Ligne
    {
        public Article article { get; set; }
        public int quantite { get; set; }
        public float totalHT { get; set; }
        public float totalTTC { get; set; }
        public float tauxTVA { get; set; }
        public string codeTVA { get; set; }
    }

}
