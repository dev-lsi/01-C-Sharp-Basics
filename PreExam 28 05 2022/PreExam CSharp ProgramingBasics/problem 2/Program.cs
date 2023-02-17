using System;

namespace problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double dear1foodKg = double.Parse(Console.ReadLine());
            double dear2foodKg = double.Parse(Console.ReadLine());
            double dear3foodKg = double.Parse(Console.ReadLine());

            dear1foodKg = dear1foodKg * days;
            dear2foodKg = dear2foodKg * days;
            dear3foodKg = dear3foodKg * days;
            
            double totalFoodNeeded = dear1foodKg+ dear2foodKg+ dear3foodKg;
            double diff = foodKg - totalFoodNeeded;
            

            if (diff >= 0)
            {
                diff = Math.Floor(diff);
                Console.WriteLine($"{diff} kilos of food left.");
            }
            else if (diff < 0)
            {
                diff = Math.Abs(diff);
                diff = Math.Ceiling(diff);
                Console.WriteLine($"{diff} more kilos of food are needed.");
            }




        }

    }
}
