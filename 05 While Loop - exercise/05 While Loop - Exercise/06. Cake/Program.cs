using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLenghtA = int.Parse(Console.ReadLine());
            int cakeLenghtB = int.Parse(Console.ReadLine());
            int allPcs = cakeLenghtA * cakeLenghtB;
            int pcsLeft = allPcs;
            
            int pcsToTake = 0;
            string input = "";

           input = Console.ReadLine();  // pcsToTake or STOP

            while (pcsLeft > 0)
            {
                

                if (input == "STOP")
                {
                    Console.WriteLine($"{pcsLeft} pieces are left.");
                    break;
                }
                else if (input != "STOP")
                {
                    pcsToTake = int.Parse(input);
                    pcsLeft = pcsLeft - pcsToTake;

                    if (pcsLeft > 0)
                    {

                        input = Console.ReadLine();  
                        
                    }
                    else if (pcsLeft <= 0)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(pcsLeft)} pieces more.");
                        break;
                    }
                }
            }
        }
    }
}
