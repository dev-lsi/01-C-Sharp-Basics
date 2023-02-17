using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double rest = 0;
            double counter = 0;
            int cicleCounter = 1;

            while (money != 0)
            {
                
                rest = money % 10;
                Console.WriteLine($"rest = {rest}");
                if(rest)
            }
        }
    }
}
