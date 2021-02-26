using System;
using Bakery.Bread;
using Bakery.Pastry;

namespace Bakery
{
    public class Program
    {
        public static void Main()
        {
            Program myBakery = new Program();
            myBakery.Greeting();
            int costOfBread = myBakery.CallBreadCost();
            int costOfPastries = myBakery.CallPastryCost();
            myBakery.OutputPrice(costOfBread, costOfPastries);
        }

        public void Greeting()
        {
            Console.WriteLine("Hello! Welcome to Mikey's Bakery! We have loaves of bread and pastries for sale!");
            Console.WriteLine("Today we have some specials deals!");
            Console.WriteLine("Buy two loaves of bread and get one free! We also offer 3 pastries for $5");
            Console.WriteLine("Single Loaves are $5 each and single pastries are $2 each!");
        }

        public int CallBreadCost()
        {
            Loaves bread = new Loaves();
            Console.WriteLine("How many loaves of bread would you like?");
            int loavesOfBread = int.Parse(Console.ReadLine());
            Console.WriteLine("Sounds Good! " + loavesOfBread + " loaves of bread inbound!");
            bread.BreadCost(loavesOfBread);
            int totalBreadCost = bread.BreadPrice;
            return totalBreadCost;
            
        }

        public int CallPastryCost()
        {
            Pastries pastry = new Pastries();
            Console.WriteLine("How many pastries would you like?");
            int pastryAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Great! " + pastryAmount + " pastries coming right up!");
            pastry.PastryCost(pastryAmount);
            int totalPastryCost = pastry.PastryPrice;
            return totalPastryCost;
        }

        public void OutputPrice(int totalBread, int totalPastry)
        {
            Console.WriteLine("Your total will be: $" + ( totalBread + totalPastry));
            Console.WriteLine("Thank you for your purchase!");
        }
    }
}