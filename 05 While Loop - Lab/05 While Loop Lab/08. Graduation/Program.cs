using System;

namespace DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double rate = 0;
            int grade = 1;
            int fails = 0;
            double rateSum = 0;

            while (grade <= 12)
            {
                rate = double.Parse(Console.ReadLine());

                if (rate < 4)
                {
                    fails++;
                    if (fails == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (rate >= 4)
                {
                    //grade++;
                    rateSum = rateSum + rate;
                    //fails = 0;
                    if (grade == 12)
                    {
                        rateSum = rateSum / grade;

                        Console.WriteLine($"{name} graduated. Average grade: {rateSum:f2}");
                        break;
                    }
                    else
                    {
                        grade++;
                        fails = 0;
                        continue;
                    }
                }

            }
            
        }
    }
}
