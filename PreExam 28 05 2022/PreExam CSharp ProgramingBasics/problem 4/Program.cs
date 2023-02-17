using System;

namespace problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int days = int.Parse(Console.ReadLine());
            double totalQuantity = 0;
            double totalGraduses = 0;


            for (int i = 1; i <= days; i++)
            {
                double rakiaQuantity = double.Parse(Console.ReadLine());
                double rakiaGraduses = double.Parse(Console.ReadLine());
                totalQuantity = totalQuantity + rakiaQuantity;
                totalGraduses = totalGraduses + rakiaGraduses * rakiaQuantity;


            }
            totalGraduses = totalGraduses / totalQuantity;
            Console.WriteLine($"Liter: {totalQuantity:f2}");
            Console.WriteLine($"Degrees: {totalGraduses:f2}");
            if (totalGraduses<38)
            {
                Console.WriteLine($"Not good, you should baking!");
            }
            else if (totalGraduses<=42)
            {
                Console.WriteLine($"Super!");
            }
            else if (totalGraduses>42)
            {
                Console.WriteLine($"Dilution with distilled water!");
            }

            

        }
    }
}
