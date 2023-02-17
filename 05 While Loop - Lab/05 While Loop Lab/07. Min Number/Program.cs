using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;
            int num = 0;

            while (input != "Stop")
            {
                num = int.Parse(input);

                if (num < min)
                {
                    min = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
