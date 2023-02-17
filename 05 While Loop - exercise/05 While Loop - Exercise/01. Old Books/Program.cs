using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            string input = Console.ReadLine();
            int counter = 0;

            while (input != "No More Books")
            {
                counter++;

                if (input == bookName)
                {
                    Console.WriteLine($"You checked {counter -1} books and found it.");
                    break;
                }
                else if (input != bookName)
                {
                    input = Console.ReadLine();
                    continue;
                }
            }
            if (input == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
