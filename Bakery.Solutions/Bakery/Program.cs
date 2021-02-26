using System;
using Bakery.Bread;
using Bakery.Pastry;

namespace Bakery
{
    public class Program
    {
        public static void Main()
        {
            Loaves bread = new Loaves();
            Pastries pastry = new Pastries();
            Console.WriteLine("Hello! Welcome to Mikey's Bakery! We have loaves of bread and pastries for sale!");
            Console.WriteLine("Today we have some specials deals!");
            Console.WriteLine("Buy two loaves of bread and get one free! We also offer 3 pastries for $5");
            Console.WriteLine("Single Loaves are $5 each and single pastries are $2 each!");
            Console.WriteLine("How many loaves of bread would you like?");
            int loavesOfBread = int.Parse(Console.ReadLine());
            bread.BreadCost(loavesOfBread);
            Console.WriteLine("How many pastries would you like?");
            int amountOfPastries = int.Parse(Console.ReadLine());
            pastry.PastryCost(amountOfPastries);
            Console.WriteLine("Your total will be: $" + (bread.BreadPrice + pastry.PastryPrice));
            Console.WriteLine("Thank you for your purchase!");
        }
    }
}