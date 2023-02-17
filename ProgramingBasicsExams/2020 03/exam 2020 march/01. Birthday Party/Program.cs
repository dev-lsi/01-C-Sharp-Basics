using System;

namespace _01._Birthday_Party
{
    class Program
    {
        static void Main(string[] args)
        {
          //  •	Торта  – цената ѝ е 20 % от наема на залата
          //  •	Напитки – цената им е 45 % по - малко от тази на тортата
          //  •	Аниматор – цената му е 1 / 3 от цената за наема на залата

            

            double price = double.Parse(Console.ReadLine());
            double budget = 0;

            budget = price + (price * 0.2) + (price * 0.2) - ((price * 0.2) * 0.45) + (price / 3);
            Console.WriteLine(budget);





        }
    }
}
