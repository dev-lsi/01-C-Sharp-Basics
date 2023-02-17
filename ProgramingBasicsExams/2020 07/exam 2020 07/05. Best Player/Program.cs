using System;

namespace _05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int goals = 0;
            int maxGoals = int.MinValue;
            string bestPlayerName = "";
           
            bool hattrick = false;

            while (name != "END")
            {
                goals = int.Parse(Console.ReadLine());

                if (goals >= 3)
                {
                    hattrick = true;
                }
                
                if (goals >= 10)
                {
                    bestPlayerName = name;
                    maxGoals = goals;
                    break;
                }
                else if (goals > maxGoals)
                {
                    maxGoals = goals;
                    bestPlayerName = name;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayerName} is the best player!");
            if (hattrick == true)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
