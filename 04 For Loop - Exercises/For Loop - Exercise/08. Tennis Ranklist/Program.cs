using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numOfTournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            double points=0;
            double counter = 0;
            double percent = 0;
            
            for(int i=1; i <= numOfTournaments; i++)
            {
                string pointsstr = Console.ReadLine();
                if (pointsstr == "W")
                {
                    points = points + 2000;
                    counter++;
                }
                else if(pointsstr == "F")
                {
                    points = points + 1200;

                }
                else if(pointsstr=="SF")
                {
                    points = points + 720;

                }
            }
            Console.WriteLine($"Final points: {points+startPoints}");

            points = points / numOfTournaments;
            percent = counter / numOfTournaments * 100;
            Console.WriteLine($"Average points: {Math.Floor(points)}");
            Console.WriteLine($"{percent:f2}%");


            
        }
    }
}
