using System;

namespace _03._Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int rest = num % 2;

            if (rest == 0)
            {
                Console.WriteLine("even");
            }
            else 
            {
                Console.WriteLine("odd");
            }
            
        }
    }
}
