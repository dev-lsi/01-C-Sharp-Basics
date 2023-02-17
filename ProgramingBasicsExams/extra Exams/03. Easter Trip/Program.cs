using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string date = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double price = 0;

            //Дестинация  21 - 23 март  24 - 27 март  28 - 31 март
            //Франция        30 лв.        35 лв.        40 лв.
            //Италия         28 лв.        32 лв.        39 лв.
            //Германия        32 лв.       37 лв.        43 лв.

            if (destination== "France")
            {
                if (date == "21-23")
                {
                    price =30;
                }
                if (date == "24-27")
                {
                    price =35;
                }
                if (date == "28-31")
                {
                    price =40;
                }
            }
            else if (destination == "Italy")
            {
                if (date == "21-23")
                {
                    price =28;
                }
                if (date == "24-27")
                {
                    price =32;
                }
                if (date == "28-31")
                {
                    price =39;
                }
            }
            else if (destination == "Germany")
            {
                if (date == "21-23")
                {
                    price =32;
                }
                if (date == "24-27")
                {
                    price =37;
                }
                if (date == "28-31")
                {
                    price =43;
                }
            }

            price = price * nights;
            Console.WriteLine($"Easter trip to {destination} : {price:f2} leva.");

            // "Easter trip to {дестинация} : {разходи за екскурзията:f2} leva."

        }
    }
}
