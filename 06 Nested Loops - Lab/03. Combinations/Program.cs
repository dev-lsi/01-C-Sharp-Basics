using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldNumber=int.Parse(Console.ReadLine());
            int counter = 0;
            
            for(int n1 = 0; n1 <= goldNumber; n1++)
            {
                for (int n2 = 0; n2 <= goldNumber; n2++)
                {
                    for (int n3 = 0; n3 <= goldNumber; n3++)
                    {
                        if (n1 + n2 + n3 == goldNumber)
                        {
                            counter++;
                        }
                        
                    }
                }
            }
            
            Console.WriteLine($"{counter}");

        }
    }
}
