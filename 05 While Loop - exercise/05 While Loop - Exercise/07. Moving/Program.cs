using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int volume = a * b * c;
            string input = Console.ReadLine();
            int boxesMovedIn = 0;
            int freeSpace = volume;

            while (freeSpace >= 0)
            {
                
                if (input == "Done")
                {
                    Console.WriteLine($"{volume} Cubic meters left.");
                    break;
                }
                else 
                { 
                    boxesMovedIn = int.Parse(input);
                    volume = volume - boxesMovedIn;
                    //volume = volume - freeSpace;
                    
                    if (volume < 0)
                    {
                        Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                        break;
                    }
                    else if (volume >= 0)
                    {
                        input = Console.ReadLine();
                    }
                }
            }
        }
    }
}
