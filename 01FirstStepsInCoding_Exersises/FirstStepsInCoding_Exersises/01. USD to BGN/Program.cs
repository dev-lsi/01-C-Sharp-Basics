using System;

namespace _01._USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 USD = 1.79549 BGN.
            double usd = double.Parse(Console.ReadLine());
            double changeRatio = 1.79549;
            double bgn = usd * changeRatio;
            Console.WriteLine(bgn);
        }
    }
}
