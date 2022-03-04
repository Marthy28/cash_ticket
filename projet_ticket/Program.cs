using System;
using System.Collections.Generic;
using System.Linq;

namespace projet_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                Menu();
        }

        static public void Menu()
        {
            Console.WriteLine("------ Action ------");
            Console.WriteLine("1- Consulter Reduction");
            Console.WriteLine("2- Consulter Taux TVA");
            Console.WriteLine("3- Saisir prix");

            string res = Console.In.ReadLine();
            Console.Clear();
            switch (res)
            {
                case "1":
                    reductionTaux();
                    break;
                case "2":
                    codeTVA();
                    break;
                case "3":
                    CreationTicket();
                    break;

            }

            Console.WriteLine("------ Press enter to continue ------");
            Console.In.ReadLine();
            Console.Clear();
        }

        static public void reductionTaux()
        {
            Console.WriteLine("------ Valeur des remises ------");
            Console.WriteLine("1000 - 3%");
            Console.WriteLine("5000 - 5%");
            Console.WriteLine("7000 - 7%");
            Console.WriteLine("10000 - 10%");
            Console.WriteLine("50000 - 15%");
        }

        static public void codeTVA()
        {
            Console.WriteLine("------ Codes Tva ------");
            Console.WriteLine("TN - 20%");
            Console.WriteLine("TI - 10%");
            Console.WriteLine("TR - 5,5%");
            Console.WriteLine("TP - 2,1%");
        }

        static float calculReduction(float total)
        {
            float reduction;

            switch (total)
            {
                case var expression when total is < 5000 and >= 1000:
                    reduction = 3;
                    break;
                case var expression when total is < 7000 and >= 5000:
                    reduction = 5;
                    break;
                case var expression when total is < 15000 and >= 7000:
                    reduction = 7;
                    break;
                case var expression when total is < 15000 and >= 10000:
                    reduction = 10;
                    break;
                case var expression when total is >= 15000:
                    reduction = 15;
                    break;
                default:
                    reduction = 0;
                    break;
            }
            //Console.WriteLine("Entrez TVA :");
            //string tva = Console.In.ReadLine();
            //line.tauxTVA = int.Parse(tva);
            //
            //float totalTTC = total + total * (float.Parse(tva) / 100);
            //float totalReduit = totalTTC - totalTTC * (reduction / 100);
            float totalReduit = total - total * (reduction / 100);

            return totalReduit;

        }
        static Ligne AddArticle()
        {
            Console.WriteLine("------- Ajouter des articles ------");
            Console.WriteLine("Le prix : ");
            int priceInt;
            int quantityInt;

            string price = Console.In.ReadLine();
            while (!int.TryParse(price, out priceInt))
            {
                Console.WriteLine("Saisissez un entier : ");
                price = Console.In.ReadLine();
            }
            
            Console.WriteLine("La quantité : ");

            string quantitity = Console.In.ReadLine();
            if (!int.TryParse(quantitity, out quantityInt))
            {
                Console.WriteLine("Saisissez un entier : ");
                quantitity = Console.In.ReadLine();
            }

            var article = new Article();
            article.Price = priceInt;

            var ligne = new Ligne();
            ligne.article = article;
            ligne.quantite = quantityInt;
            ligne.totalHT = priceInt * quantityInt;
            return ligne;
        }

        public static void CreationTicket()
        {
            List<Ligne> lignes = new List<Ligne>();


            string res = String.Empty;
            while (res != "N")
            {
                res = string.Empty;
                var ligne = AddArticle();
                lignes.Add(ligne);

                while (!(res == "Y" || res == "N"))
                {
                    Console.WriteLine("Voulez vous saisir un autre article ? (Y-N)");
                    res = Console.In.ReadLine().ToUpper();
                }
            }
            float total = 0;
            foreach (Ligne line in lignes)
            {
                Console.WriteLine($"Montant HT : {line.totalHT}");
                Console.WriteLine($"Montant TTC : {line.totalHT}");

                total += line.totalHT;
            }

            Console.WriteLine($"Total :{calculReduction(total)}");

        }
    }
}

