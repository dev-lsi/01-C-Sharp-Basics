using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 0;

            for(int row =1; row <= n; row++)
            {
                for(int col = 1; col <= row; col++)
                {
                    currentNumber++;
                    Console.Write($"{currentNumber} ");
                    if (currentNumber == n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (currentNumber == n)
                {
                    break;
                }

            }
        }
    }
}
