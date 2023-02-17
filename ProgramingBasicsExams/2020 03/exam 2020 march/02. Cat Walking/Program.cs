using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int walkingMinutes = int.Parse(Console.ReadLine());
            int walkings = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            walkingMinutes = walkingMinutes * walkings;
            int burnedCalories = walkingMinutes * 5;
            
            if (burnedCalories >= calories/2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else if (burnedCalories < calories/2)
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");

            }

        }
    }
}
