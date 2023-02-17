using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)

        {
            string username = Console.ReadLine();
            string pass = Console.ReadLine();
            


            while (true)
            {
                string password = Console.ReadLine();
                
                if (password == pass)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }
                
            }

            
        }
    }
}
