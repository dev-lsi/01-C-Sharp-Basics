using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int allFood = int.Parse(Console.ReadLine());
            allFood = allFood * 1000;
            string input = Console.ReadLine();
            int foodEaten = 0;

            while (input != "Adopted")
            {
                foodEaten = foodEaten + int.Parse(input);
                input = Console.ReadLine();
            }
            if (foodEaten <= allFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {allFood-foodEaten} grams.");
            }
            else if (foodEaten > allFood)
            {
                Console.WriteLine($"Food is not enough. You need {foodEaten-allFood} grams more.");

            }


        }
    }
}
