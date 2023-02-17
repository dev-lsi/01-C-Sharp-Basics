using System;

namespace _02._Numbers_N__1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i > 0 ; i-- )
            {
                //number = number - 1;
                Console.WriteLine(number);
                number -= 1;

                
            }
            
        }
    }
}
