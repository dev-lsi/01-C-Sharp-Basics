using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            double salary= double.Parse(Console.ReadLine());
            string tabName = "";
            double globa = 0;

            for (int i = 1; i <= tabs; i++)
            {
                tabName = Console.ReadLine();

                if (tabName == "Facebook" || tabName == "Instagram" || tabName == "Reddit")
                {
                    switch (tabName)
                    {
                        case "Facebook": globa = 150; break;
                        case "Instagram": globa = 100; break;
                        case "Reddit":globa = 50; break;
                        default: break;

                    }
                    salary = salary - globa;
                    if (salary <= 0)
                    { 
                        Console.WriteLine($"You have lost your salary."); 
                        break; 
                    }
                }

            }
            if (salary > 0)
            {
                Console.WriteLine($"{Math.Round(salary)}");
            }  
            
        }
    }
}
