using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input
            string name = Console.ReadLine();
            double movieTime = double.Parse(Console.ReadLine());
            double allTime= double.Parse(Console.ReadLine());
            double lunchTime = allTime * 1/8;
            //Console.WriteLine($"CHECK lunchTime {lunchTime}");
            double restTime = allTime * 0.25;
            //Console.WriteLine($"CHECK restTime {restTime}");
            double freeTime = allTime - (lunchTime + restTime);
            //Console.WriteLine($"CHECK freeTime {freeTime}");


            //exit
            if (freeTime>=movieTime)
            { 
              Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(freeTime - movieTime)} minutes free time.");
            }
            else
            {
              Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(movieTime-freeTime)} more minutes.");
            }

        }
    }
}
