using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            //int judgeName = str.length();

            for(int i = 1; i <= n; i++)
            {
                string judgeName = Console.ReadLine();
                int judgeNameLength = judgeName.Length;
                double judgePoints = double.Parse(Console.ReadLine());
                points = points + (judgePoints * judgeNameLength / 2);
                
                if (points >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }

            if (points < 1250.5)
            {
                points = 1250.5 - points;
                Console.WriteLine($"Sorry, {actorName} you need {points:f1} more!");
            }
          

        }
    }
}
