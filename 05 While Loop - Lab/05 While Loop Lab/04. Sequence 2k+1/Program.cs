using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int progress = 1;

            while (progress <= number)
            {
                Console.WriteLine($"{progress}");
                progress = (progress * 2)+1;
                

               
            }
        }
    }
}
