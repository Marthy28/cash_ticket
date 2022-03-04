using System;

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
                    saisiePrix();
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

        static public void saisiePrix()
        {

            bool success = false;
            string price = string.Empty;
            string quantitity = string.Empty;
            int priceInt = 0;
            int quantityInt = 0;

            while (success == false)
            {
                Console.WriteLine("------- Ajouter un prix ------");
                Console.WriteLine("Le prix : ");
                price = Console.In.ReadLine();
                if (!int.TryParse(price, out priceInt))
                {
                    Console.WriteLine("Saisissez un entier");
                }
                else
                {
                    Console.WriteLine("La quantité : ");
                    quantitity = Console.In.ReadLine();
                    if (!int.TryParse(quantitity, out quantityInt))
                    {
                        Console.WriteLine("Saisissez un entier");
                    }
                    success = true;
                }
            }

            Console.WriteLine($"total = {priceInt * quantityInt}");

        }

        static void reductionNotReduction(int total, float reduction)
        {
            float totalReduit = total - total * (reduction / 100);
            Console.WriteLine($"Montant pré réduction : {total}");
            Console.WriteLine($"Montant avec réduction : {totalReduit}");
        }
    }
}

