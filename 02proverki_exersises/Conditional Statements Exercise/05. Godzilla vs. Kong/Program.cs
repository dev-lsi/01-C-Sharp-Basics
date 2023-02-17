using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double priceSuit = double.Parse(Console.ReadLine());
            priceSuit = priceSuit * actors;
            double decor = budget * 0.1;
            double spendings = 0;

            if (actors > 150)
            {
                priceSuit = priceSuit * 0.9;
                spendings = priceSuit + decor;
            }
            else
            {
                spendings = priceSuit + decor;
            }

            
            if (spendings > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {(spendings - budget):F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {(budget-spendings):F2} leva left.");

            }
            

        }
    }
}
