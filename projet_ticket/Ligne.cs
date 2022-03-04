using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_ticket
{
    public class Ligne
    {
        public Ligne(Article article, int quantite, int totalHT, int totalTTC, int tauxTVA, string codeTVA)
        {
            this.article = article;
            this.quantite = quantite;
            this.totalHT = totalHT;
            this.totalTTC = totalTTC;
            this.tauxTVA = tauxTVA;
            this.codeTVA = codeTVA;
        }

        public Article article { get; set; }
        public int quantite { get; set; }
        public int totalHT { get; set; }
        public int totalTTC { get; set; }
        public int tauxTVA { get; set; }
        public string codeTVA { get; set; }
    }

}
