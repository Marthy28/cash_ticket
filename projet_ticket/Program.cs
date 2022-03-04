using System;

namespace projet_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            reductionTaux();
            saisiePrix();

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

        static public void saisiePrix()
        {

            bool success = false;
            string price = string.Empty;
            string quantitity = string.Empty;
            int priceInt =0;
            int quantityInt=0;

            while (success == false)
            {
                Console.WriteLine("------- Ajouter un prix ------");
                Console.WriteLine("Le prix : ");
                price = Console.In.ReadLine();
                Console.WriteLine("Sélectionner la quantité");
                quantitity = Console.In.ReadLine();
                if (!int.TryParse(price, out priceInt))
                {
                    Console.WriteLine("Saisissez un entier");
                }
                else
                {
                    if (!int.TryParse(quantitity, out quantityInt))
                    {
                        Console.WriteLine("Saisissez un entier");
                    }
                    success = true;
                }
            }

            Console.WriteLine($"total = {priceInt * quantityInt}");

        }
    }
}

