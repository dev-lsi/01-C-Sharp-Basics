using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                double area = squareSide * squareSide;
                Console.WriteLine("{0:F3}",area);
            }
            else
            if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = sideA * sideB;
                Console.WriteLine("{0:F3}", area);
            }
            else
            if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area =sideA*height/2;
                Console.WriteLine("{0:F3}", area);
            }
            else
            if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = radius * radius * Math.PI;
                Console.WriteLine("{0:F3}", area);
            }





        }
    }
}
