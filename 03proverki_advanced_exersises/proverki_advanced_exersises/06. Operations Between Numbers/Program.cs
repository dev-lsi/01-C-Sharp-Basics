using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0;
            string myString = "";
            if (operation == '+' || operation == '-' || operation == '*')
            {
                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        myString = $"{num1} + {num2} = {result}";
                        break;
                    case '-':
                        result = num1 - num2;
                        myString = $"{num1} - {num2} = {result}";

                        break;
                    case '*':
                        result = num1 * num2;
                        myString = $"{num1} * {num2} = {result}";

                        break;
                    default:
                        break;
                }

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{myString} - even");
                }
                else
                {
                    Console.WriteLine($"{myString} - odd");
                }
            }
            else if (num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            else if (operation == '/')
            {
                result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result:f2}");
            }
            else
            {
                result = num1 % num2;
                Console.WriteLine($"{num1} % {num2} = {result}");
            }
        }
    }
}
