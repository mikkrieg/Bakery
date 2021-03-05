using System;
using Bakery.Models;

namespace Bakery
{
    public class Program
    {
        public static void Main()
        {
            Program myBakery = new Program();
            Program.Greeting();
            int costOfBread = myBakery.CallBreadCost();
            int costOfPastries = myBakery.CallPastryCost();
            int costOfDonuts = myBakery.CallDonutCost();
            Program.OutputPrice(costOfBread, costOfPastries, costOfDonuts);
        }
        public static void Greeting()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Hello! Welcome to Mikey's Bakery! We have loaves of bread, pastries and donuts for sale!");
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
            Bread bread = new Bread();
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
            Pastry pastry = new Pastry();
            Console.WriteLine("How many pastries would you like?");
            int pastryAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Great! " + pastryAmount + " pastries coming right up!");
            Console.WriteLine("------------------------");
            pastry.PastryCost(pastryAmount);
            int totalPastryCost = pastry.PastryPrice;
            return totalPastryCost;
        }
        public int CallDonutCost()
        {
            Donut donut = new Donut();
            Console.WriteLine("How many donuts would you like?");
            int donutAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Great! " + donutAmount + " donuts are ready for you to take home!");
            Console.WriteLine("------------------------");
            donut.DonutCost(donutAmount);
            int totalDonutCost = donut.DonutPrice;
            return totalDonutCost;
        }
        public static void OutputPrice(int totalBread, int totalPastry, int totalDonuts)
        {
            Console.WriteLine("Your total will be:" );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("$" + ( totalBread + totalPastry + totalDonuts));
            Console.ResetColor();
            Console.WriteLine("------------------------");
            Console.WriteLine("Thank you for your purchase, have a great rest of your day!");
        }
    }
}