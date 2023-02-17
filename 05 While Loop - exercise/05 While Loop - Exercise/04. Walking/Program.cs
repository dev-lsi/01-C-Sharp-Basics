using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int steps = 0;
            int sumOfSteps = 0;

            while (sumOfSteps < 10000)
            {
                input = Console.ReadLine();
                
                if(input == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());
                    sumOfSteps = sumOfSteps + steps;
                    if (sumOfSteps < 10000)
                    {
                        Console.WriteLine($"{10000-sumOfSteps} more steps to reach goal.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Goal reached! Good job!");
                        Console.WriteLine($"{sumOfSteps-10000} steps over the goal!");
                        break;
                    }
                }
                else
                {
                    steps = int.Parse(input);
                    sumOfSteps += steps;
                    if (sumOfSteps < 10000)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Goal reached! Good job!");
                        Console.WriteLine($"{sumOfSteps - 10000} steps over the goal!");
                        break;
                    }
                }
            }
        }
    }
}
