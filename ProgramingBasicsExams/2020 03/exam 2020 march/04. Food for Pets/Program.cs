using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double allFood = double.Parse(Console.ReadLine());
            int eatenByDog = 0;
            int eatenByCat = 0;
            int dailyEatenByDog = 0;
            int dailyEatenByCat = 0;
            //int daysCounter = 0;
            double biscuitCounter = 0;
            double dayFood =0;
            double allEatenFood=0;
            double percent = 0;
            
            for(int i = 1; i <= days; i++)
            {
                
                dailyEatenByDog = int.Parse(Console.ReadLine());
                dailyEatenByCat = int.Parse(Console.ReadLine());
                dayFood = dailyEatenByCat + dailyEatenByDog;
                allEatenFood = allEatenFood + dayFood;
                
                if (i % 3 == 0)
                {
                    biscuitCounter = biscuitCounter + dayFood * 0.1;
                }
                eatenByDog = eatenByDog + dailyEatenByDog;
                eatenByCat = eatenByCat + dailyEatenByCat;
            }
            /*•	"Total eaten biscuits: {количество изядени бисквитки}gr."
              •	"{процент изядена храна}% of the food has been eaten."
              •	"{процент изядена храна от кучето}% eaten from the dog."
              •	"{процент изядена храна от котката}% eaten from the cat."
            */
            biscuitCounter = Math.Round(biscuitCounter);

            Console.WriteLine($"Total eaten biscuits: {biscuitCounter}gr.");
            
            percent = (allEatenFood / allFood) * 100;
            Console.WriteLine($"{percent:f2}% of the food has been eaten.");
            
            percent = (eatenByDog / allEatenFood) * 100;
            Console.WriteLine($"{percent:f2}% eaten from the dog.");
            
            percent = (eatenByCat / allEatenFood) * 100;
            Console.WriteLine($"{percent:f2}% eaten from the cat.");
            


        }
    }
}
