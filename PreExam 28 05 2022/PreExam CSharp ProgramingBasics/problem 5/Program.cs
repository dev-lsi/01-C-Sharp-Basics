using System;

namespace problem_5
{
    class Program
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();
            
            int currHeight = 5364;
            int daysCounter = 0;
            int metersToday = 0;

            while (input != "END")
            {
                
                if (input == "Yes")
                {
                    daysCounter++;
                }
                if (daysCounter >= 5)
                {
                    break;
                }
                else
                {
                    
                    metersToday = int.Parse(Console.ReadLine());
                    currHeight = currHeight + metersToday;
                    
                    if (currHeight < 8848)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else if (currHeight >= 8848)
                    {
                        break;
                    }
                }
            }
            if(currHeight >= 8848)
            {
                Console.WriteLine($"Goal reached for {daysCounter+1} days!");
            }
            else
            {
                Console.WriteLine($"Failed!");
                Console.WriteLine($"{currHeight}");

            }

            //  •	Ако Атанас е изкачил Еверест:
            //            "Goal reached for {брой дни които Атанас е изкачвал върха} days!"
            //•	Ако Атанас НЕ е изкачил Еверест:
            //     "Failed!"
            //     "{достигнатите от Атанас метри}"

        }
    }
}
