using System;

namespace _01._Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int rest = 0;

            for(int i=1; i <= 1000; i++)
            {
                rest = num;
                rest = rest % 10;
                
                
                if (rest == 7)
                {
                    Console.WriteLine(num);
                    num += 1;
                }
                else
                {
                    num += 1;
                }
            }
        }
    }
}
