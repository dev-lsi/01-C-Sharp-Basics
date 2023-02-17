using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //буква	       a	e	i	o	u
            //стойност     1    2   3   4   5
            
            string inputString = Console.ReadLine();
            char character='y';
            int stringLength = inputString.Length;
            int sum = 0;
            
            for(int i = 0; i < stringLength; i++)
            {
                character = inputString[i];
                
                switch (character)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                         break;
                    default:
                        break;

                }
                
            }
            Console.WriteLine($"{sum}");



        }
    }
}
