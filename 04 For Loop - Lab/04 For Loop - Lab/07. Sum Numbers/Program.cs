using System;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int input = 0;
            
            for(int i = 0; i < n; i++)
            {
                input = int.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
