using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           // bool isPrime = false;
            int primeSum = 0;
            int nonPrimeSum = 0;


            while (input != "stop")
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    
                }
                else if (number == 0)
                {
                    input = Console.ReadLine();
                }
                else if (number == 1)
                {
                    input = Console.ReadLine();                    
                }
                else if (number == 2)
                {
                    primeSum = primeSum + number;
                    input = Console.ReadLine();
                    
                }
                else
                {
                  for(int i = 2; i <= number; i++)
                  {
                      if (number % i == 0 && i!=number) 
                        {
                            nonPrimeSum += number;
                            input = Console.ReadLine();
                            break;
                        }
                      else if (number % i != 0)
                        {
                            continue;
                        }
                      else if (i == number)
                        {
                            primeSum = primeSum + number;
                            input = Console.ReadLine();
                            break;
                        }
                  }
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
