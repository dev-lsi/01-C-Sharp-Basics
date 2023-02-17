using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double deposit = double.Parse(Console.ReadLine());
            int montsPeriod = int.Parse(Console.ReadLine());
            double yearRatio = double.Parse(Console.ReadLine());
            double sum = deposit + (montsPeriod * ((deposit * (yearRatio/100)) / 12));
            Console.WriteLine(sum);
            
        }
    }
}
