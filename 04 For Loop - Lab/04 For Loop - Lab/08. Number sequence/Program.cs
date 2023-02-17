using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int smaller = int.MaxValue;
            int bigger = int.MinValue;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                
                int input = int.Parse(Console.ReadLine());

                if (input < smaller)
                {
                    smaller = input;
                }
                if(input > bigger)
                {
                    bigger = input;
                }   
            }
             
            Console.WriteLine($"Max number: {bigger}");
            Console.WriteLine($"Min number: {smaller}");

        }
    }
}
