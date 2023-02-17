using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int qNylon = int.Parse(Console.ReadLine());
            int qPaint = int.Parse(Console.ReadLine());
            int qDisolv = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());

            double priceNylon =1.5;
            double pricePaint =14.5;
            double priceDisolv =5;

            double bill = (qPaint * 1.1* pricePaint) + ((qNylon + 2) * priceNylon)+ (qDisolv * priceDisolv) + 0.4;
            double salary = bill * 0.3 * workingHours;
            double sum = bill + salary;

            Console.WriteLine(sum);
        }
    }
}
