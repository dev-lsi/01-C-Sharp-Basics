using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            
            //int i = 1;
            for (int i = 1; i<=n; i++)
            {
                if (i % 2 !=0 ) 
                {
                    oddSum = oddSum + int.Parse(Console.ReadLine()); 
                }
                else 
                { 
                    evenSum = evenSum + int.Parse(Console.ReadLine()); 
                }
            }

            // output
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + oddSum);
            }
            else
            {
                int diff = Math.Abs(oddSum - evenSum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }

        }
    }
}
