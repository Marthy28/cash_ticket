using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_ticket
{
    public class Ligne
    {
        public Article Article { get; set; }
        public int Quantite { get; set; }
        public int TotalHT { get; set; }
        public int TotalTTC { get; set; }
        public int TauxTVA { get; set; }
        public string CodeTVA { get; set; }
    }
}
