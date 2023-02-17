using System;

namespace _05_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Закупеното количество храна за кученцето в килограми – цяло число в интервала[1 …100]
            //•	На всеки следващ ред до получаване на команда Adopted ще получавате колко грама изяжда кученцето на всяко хранене -цяло число в интервала[10 …1000]
            
            int allFood = int.Parse(Console.ReadLine());
            allFood = allFood * 1000;
           
            string input = Console.ReadLine();
            
            int currFoodEaten = 0;
            int totalFoodEaten = 0;

            while (input != "Adopted")
            {
                currFoodEaten = int.Parse(input);
                totalFoodEaten = totalFoodEaten + currFoodEaten;
                input = Console.ReadLine();

            }

            int balance = allFood - totalFoodEaten;
           
                if (balance >=0 )
            {
                Console.WriteLine($"Food is enough! Leftovers: {balance} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(balance)} grams more.");
            }


            //  Ако количеството храна е достатъчно да се отпечата:
            // 	"Food is enough! Leftovers: {останала храна} grams."
            //	Ако количеството храна не е достатъчно да се отпечата:
            //  "Food is not enough. You need {нужно количество храна} grams more."

        }
    }
}
