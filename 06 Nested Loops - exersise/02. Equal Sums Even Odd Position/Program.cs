using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int currentNum = 0;
            int oddSum = 0;
            int evenSum = 0;


            for (int i = firstNum; i <= secondNum; i++)
            {
                currentNum = i;
                string currentString = currentNum.ToString();
                int currentNumLength = currentString.Length;
                
                for (int j = 1; j <= currentNumLength; j++)
                {
                    char currentChar = currentString[j-1];
                    int charNumb = int.Parse(currentChar.ToString());
                    if (j == 1 || j % 2 != 0)
                    {
                        oddSum = oddSum + charNumb;
                    }
                    else if (j % 2 == 0)
                    {
                        evenSum = evenSum + charNumb;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write($"{currentNum} ");
                }
                oddSum = 0;
                evenSum = 0;
                
            }

        }
    }
}
