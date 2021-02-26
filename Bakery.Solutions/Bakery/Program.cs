using System;
using Bakery.Bread;
using Bakery.Pastry;

namespace Bakery
{
    public class Program
    {
        public static void Main()
        {
            Greeting();
            OutputPrice();
        }

        public void Greeting()
        {
            Console.WriteLine("Hello! Welcome to Mikey's Bakery! We have loaves of bread and pastries for sale!");
            Console.WriteLine("Today we have some specials deals!");
            Console.WriteLine("Buy two loaves of bread and get one free! We also offer 3 pastries for $5");
            Console.WriteLine("Single Loaves are $5 each and single pastries are $2 each!");
        }

        public int CallBreadCost(int loavesOfBread)
        {
            Loaves bread = new Loaves();
            Console.WriteLine("How many loaves of bread would you like?");
            int loavesOfBread = int.Parse(Console.ReadLine());
            int totalBreadCost = bread.BreadCost(loavesOfBread);
            return totalBreadCost;
            
        }

        public int CallPastryCost(int amountOfPastries)
        {
            Pastries pastry = new Pastries();
            Console.WriteLine("How many pastries would you like?");
            int amountOfPastries = int.Parse(Console.ReadLine());
            int totalPastryCost = pastry.PastryCost(amountOfPastries);
            return totalPastryCost;
        }

        public void OutputPrice(int totalB)
        {
            Console.WriteLine("Your total will be: $" + ( + pastry.PastryPrice));
            Console.WriteLine("Thank you for your purchase!");
        }
    }
}