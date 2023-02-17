using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
           /*От конзолата се четат точно два реда:
           •	Градусите - цяло число в интервала [10…42]
           •	Текст, време от денонощието - с възможности - 
                "Morning", "Afternoon", "Evening"
           */
            int degrees = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            string outfit="s";
            string shoes = "s";
            
            if(dayTime== "Morning")
            {
                if (degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (dayTime == "Afternoon")
            {
                if (degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");



            //отпечата на конзолата на един ред:
            //"It's {градуси} degrees, get your {облекло} and {обувки}."
        }
    }
}
