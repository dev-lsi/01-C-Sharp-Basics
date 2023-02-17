using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber= int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int goldNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isFound = false;

            for (int i = startNumber; i <= endNumber; i++)
            {
                for (int j = startNumber; j <= endNumber; j++)
                {
                    counter++;

                    if (i + j == goldNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {goldNumber})");
                        isFound = true;
                        break;
                    }
                    
                }
                if (isFound)
                {
                    break;
                }

            }

            if (!isFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {goldNumber}");
            }
            
        }
    }
}
