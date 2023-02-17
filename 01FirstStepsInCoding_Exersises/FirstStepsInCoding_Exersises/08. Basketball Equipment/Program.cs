using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());

            double shoes = yearTax*0.6;
            double suit = shoes*0.8;
            double ball = suit/4;
            double accessories = ball/5;

            double spendings = yearTax + shoes + suit + ball + accessories;

            Console.WriteLine(spendings);
        }
    }
}
