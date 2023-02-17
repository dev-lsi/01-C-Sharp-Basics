using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = (Console.ReadLine());
            // string number2 = (Console.ReadLine());


            for (int i = 0; i <= number1.Length - 1; i++)
            {
                //int lenght1 = number1.Length;
                //Console.WriteLine($"{lenght1}");
                int mynum = int.Parse(number1[i]);
                Console.WriteLine($"{mynum}");
            }
            

        }
    }
}
