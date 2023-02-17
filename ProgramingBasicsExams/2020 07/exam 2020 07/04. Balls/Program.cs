using System;

namespace _04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            /*•	Ако топката е “red” точките ни се повишават с 5.
              •	Ако топката е “orange” точките ни се повишават с 10.
              •	Ако топката е “yellow” точките ни се повишават с 15.
              •	Ако топката е “white” точките ни се повишават с 20.
              •	Ако топката е “black” точките ни се делят на 2
*/
            int n = int.Parse(Console.ReadLine());
            double points = 0;
            int redCounter = 0;
            int orangeCounter = 0;
            int yellowCounter = 0;
            int whiteCounter = 0;
            int blackCounter = 0;
            int otherBallsCounter = 0;

            for (int i = 1; i <= n; i++)
            {
                string color = Console.ReadLine();
                //check color,set points,set counter.
                if (color == "red")
                {
                    points += 5;
                    redCounter++;
                }
                else if (color == "orange")
                {
                    points +=10;
                    orangeCounter++;
                }
                else if (color == "yellow")
                {
                    points +=15;
                    yellowCounter++;
                }
                else if (color == "white")
                {
                    points +=20;
                    whiteCounter++;
                }
                else if (color == "black")
                {
                    points =Math.Floor(points/2);
                    blackCounter++;
                }
                else
                {
                    otherBallsCounter++;
                    continue;
                }
            }

            
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redCounter}");
            Console.WriteLine($"Orange balls: {orangeCounter}");
            Console.WriteLine($"Yellow balls: {yellowCounter}");
            Console.WriteLine($"White balls: {whiteCounter}");
            Console.WriteLine($"Other colors picked: {otherBallsCounter}");
            Console.WriteLine($"Divides from black balls: {blackCounter}");

        }
    }
}
