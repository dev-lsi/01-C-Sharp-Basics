using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double price = 0;
            
            //checking the season
            
            switch(season)
            {
                case "Spring":
                    price = 3000;
                break;
                case "Winter":
                        price = 2600;
                    break;
                default:
                    price = 4200;
                    break;
            }

            // checking the number of the fishermen and discounting

            if (fishermen <= 6)
            {
                price = price - price * 0.1;
            }
            else if (fishermen <= 11)
            {
                price = price - price * 0.15;
            }
            else
            {
                price = price - price * 0.25;
            }

            //check for additional discounts

            if(season!="Autumn" && (fishermen % 2) == 0)
            {
                price = price - price * 0.05;
            }
            else
            {
                price = price*1;
            }

            //output
            
            double balance = budget-price;
            if (balance >= 0)
            {
                Console.WriteLine($"Yes! You have {balance:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(Math.Abs(balance)):f2} leva.");
            }

        }
    }
}
