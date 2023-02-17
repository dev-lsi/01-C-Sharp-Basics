using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {   //user input
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            //prices
            double priceVideo = 250;
            double sumPriseVideo = priceVideo * videoCards;
            
            double priceProcessors = sumPriseVideo * 0.35;
            double sumPriceProcessors = priceProcessors * processors;
            //Console.WriteLine($"CHECK {sumPriceProcessors}");
            
            double priceRAM = sumPriseVideo * 0.1;
            double sumPriceRAM = priceRAM * ram; 
            //Console.WriteLine($"CHECK {sumPriceRAM}");

            double spendings =sumPriseVideo+sumPriceProcessors+sumPriceRAM;

            if (videoCards > processors)
            {
                spendings = spendings * 0.85;
            }
            

            //exit
            if (budget >= spendings)
            {
               Console.WriteLine($"You have {(budget - spendings):F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(spendings-budget):F2} leva more!");
            }
        }
    }
}
