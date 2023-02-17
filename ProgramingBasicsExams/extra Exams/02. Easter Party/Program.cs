using System;

namespace _02._Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double couvert = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cake = budget * 0.10;


            if (guests > 20)
            {
                couvert = couvert * 0.75;
            }
            else if (guests > 15)
            {
                couvert = couvert * 0.80;
            }
            else if (guests >= 10)
            {
                couvert =couvert*0.85;
            }

            double diff = (budget - (cake + (couvert * guests)));
;
            if (diff >= 0)
            {
                Console.WriteLine($"It is party time! {diff:f2} leva left.");
            }
            else if (diff < 0)
            {
                Console.WriteLine($"No party! {Math.Abs(diff):f2} leva needed.");
            }
        }
    }
}
