using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            int maxFloors = floors;

            for (int i = floors; i > 0; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (maxFloors == floors)
                    {
                        Console.Write($"L{i}{j} ");
                        
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                       
                    }
                    else if (i % 2 != 0)
                    {
                        Console.Write($"A{i}{j} ");
                        
                    }
                }
                floors--;
                Console.WriteLine();
            }


        }
    }
}
