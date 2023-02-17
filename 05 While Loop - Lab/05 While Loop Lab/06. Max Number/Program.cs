using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int maxNum = int.MinValue;
            int input = 0;
            int sum = 0;

            string inputStr = Console.ReadLine();
            
            while (inputStr != "Stop!")
            {
                input = int.Parse(inputStr);
                sum += input;

                if (input >= maxNum)
                {
                  maxNum = input;
                }
                inputStr = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
