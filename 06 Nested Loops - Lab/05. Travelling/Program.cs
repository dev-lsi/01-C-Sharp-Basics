using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            bool isEnd = false;

            while (destination != "End")
            {
                double price = double.Parse(Console.ReadLine());
                double money = 0;
                while (money < price)
                {
                    money = money + double.Parse(Console.ReadLine());

                    if (money >= price)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        destination = Console.ReadLine();
                        if (destination == "End")
                           { 
                            isEnd = true; 
                           }
                        money = 0;
                        break;
                    }
                    if (money < price)
                    {
                        continue;
                    }
                }
                if (isEnd) { break; }

            }

        }
    }
}
