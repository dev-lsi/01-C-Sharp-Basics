using System;

namespace _06._Max_Number2
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
