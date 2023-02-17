using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            double savings = double.Parse(Console.ReadLine());
            string action = "";
            double money = 0;
            int spendingDays = 0;
            int allDays = 0;

            while(savings < excursionPrice)
            {
                allDays++;
                action = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                if(action== "spend")
                {
                    spendingDays++;
                    savings = savings - money;
                    if(savings<0)
                    {
                        savings = 0;
                    }
                    if (spendingDays == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine($"{allDays}");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (action == "save")
                {
                    spendingDays = 0;
                    savings = savings + money;
                    if(savings>= excursionPrice)
                    {
                        Console.WriteLine($"You saved the money for {allDays} days.");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

            }
        }
    }
}
