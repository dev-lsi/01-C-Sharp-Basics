using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int nextNum = int.Parse(Console.ReadLine());
            int sum = nextNum;

            while (sum<num)
            {
                nextNum = int.Parse(Console.ReadLine());
                sum = sum + nextNum;
            }
                Console.WriteLine($"{sum}");



        }
    }
}
