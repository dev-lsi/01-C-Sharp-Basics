using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double restoToReturn = double.Parse(Console.ReadLine()); //2.40 
            restoToReturn *= 100;  //240 ................................^
            //double ostatuk = 0;
            double counter = 0;

            while (restoToReturn != 0)
            {
                if (restoToReturn >= 200)
                {
                    counter++;
                    restoToReturn -= 200;
                }
                else if (restoToReturn >= 100)
                {
                    counter++;
                    restoToReturn -= 100;
                }
                else if (restoToReturn >= 50)
                {
                    counter++;
                    restoToReturn -= 50;
                }
                else if (restoToReturn >= 20)
                {
                    counter++;
                    restoToReturn -= 20;
                }
                else if (restoToReturn >= 10)
                {
                    counter++;
                    restoToReturn -= 10;
                }
                else if (restoToReturn >= 5)
                {
                    counter++;
                    restoToReturn -= 5;
                }
                else if (restoToReturn >= 2)
                {
                    counter++;
                    restoToReturn -= 2;
                }
                else if (restoToReturn >= 1)
                {
                    counter++;
                    restoToReturn -= 1;
                }
                else if (restoToReturn<1)
                {
                    restoToReturn = 0;
                }

            }
            Console.WriteLine($"{counter}");
        }
    }
}
