using System;

namespace _06_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLocation = int.Parse(Console.ReadLine());

            double totalDiggedForCurrLocation = 0;
            double goldDiggedToday = 0;

            for (int i = 1; i <= numberOfLocation; i++)
            {
                double averageGoldExpected = double.Parse(Console.ReadLine());
                int daysForDigging = int.Parse(Console.ReadLine());
                

                for(int j=1;j<= daysForDigging; j++)
                {
                 goldDiggedToday = double.Parse(Console.ReadLine());
                 totalDiggedForCurrLocation = totalDiggedForCurrLocation + goldDiggedToday;
                    
                }
                double averageDiggedForCurrLocation = totalDiggedForCurrLocation / daysForDigging;

                if (averageDiggedForCurrLocation >= averageGoldExpected)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageDiggedForCurrLocation:f2}.");
                }
                else
                {

                    double balance = averageGoldExpected - averageDiggedForCurrLocation;
                    Console.WriteLine($"You need {balance:f2} gold.");
                }
                goldDiggedToday = 0;
                totalDiggedForCurrLocation = 0;
            }
        }
    }
}
