using System;
using Bakery.Bread;
using Bakery.Pastry;
using Bakery.Donut;

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
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Hello! Welcome to Mikey's Bakery! We have loaves of bread, pastries and Donuts for sale!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Today we have some specials deals!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Buy two loaves of bread and get one free!");
            Console.WriteLine("We also offer 3 pastries for $5");
            Console.WriteLine("A dozen donuts is only $10!");
            Console.WriteLine("Single Loaves are $5 each, single donuts and pastries are $2!");
            Console.WriteLine("-----------------------------------");
        }

        public int CallBreadCost()
        {
            Loaves bread = new Loaves();
            Console.WriteLine("How many loaves of bread would you like?");
            int loavesOfBread = int.Parse(Console.ReadLine());
            Console.WriteLine("Sounds Good! " + loavesOfBread + " loaves of bread inbound!");
            Console.WriteLine("------------------------");
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
            Console.WriteLine("------------------------");
            pastry.PastryCost(pastryAmount);
            int totalPastryCost = pastry.PastryPrice;
            return totalPastryCost;
        }

        public void OutputPrice(int totalBread, int totalPastry)
        {
            Console.WriteLine("Your total will be:" );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("$" + ( totalBread + totalPastry));
            Console.ResetColor();
            Console.WriteLine("------------------------");
            Console.WriteLine("Thank you for your purchase!");
        }
    }
}