using System;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int maxEggs = 0;
            string colorMaxEggs = "";
            int currChek = 0;


            int eggs = int.Parse(Console.ReadLine());

            for (int i = 1; i <= eggs; i++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    redEggs++;
                    currChek = redEggs;
                   
                }
                else if (color == "orange")
                {
                    orangeEggs++;
                    currChek = orangeEggs;

                }
                else if (color == "blue")
                {
                    blueEggs++;
                    currChek = blueEggs;

                }
                else if (color == "green")
                {
                    greenEggs++;
                    currChek = greenEggs;

                }

                if (currChek > maxEggs)
                {
                    maxEggs = currChek;
                    colorMaxEggs = color;
                }


            }
            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            
            Console.WriteLine($"Max eggs: {maxEggs} -> {colorMaxEggs}");


            //•	"Red eggs: {брой на червените яйца}"
            //•	"Orange eggs: {брой на оранжевите яйца}"
            //•	"Blue eggs: {брой на сините яйца}"
            //•	"Green eggs: {брой на зелените яйца}"
            //•	"Max eggs: {максимален брой на яйцата от цвят} -> {цвят}"

        }
    }
}
