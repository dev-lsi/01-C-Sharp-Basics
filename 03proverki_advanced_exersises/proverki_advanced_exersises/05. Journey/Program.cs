using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double price = 0;
            string sleepPlace = "";
            
            //check the destination - depends on budget
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if(season=="summer")
                {
                    price = budget*0.3;
                }
                else
                {
                  price = budget * 0.7;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                price = budget*0.9;
            }
            else
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    price = budget * 0.4;

                }
                else
                {
                    price = budget * 0.8;
                }
            }
            //check the sleepPlase
            if (destination != "Europe")
            {
                if (season == "summer")
                {
                    sleepPlace = "Camp";
                }
                else
                {
                    sleepPlace = "Hotel";
                }
            }
            else if(destination == "Europe")
            {
                sleepPlace = "Hotel";
            }

            //•	Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe”
            //•	Втори ред – “{ Вид почивка} – { Похарчена сума}“
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{ sleepPlace} - { price:f2}");

        }
    }
}
