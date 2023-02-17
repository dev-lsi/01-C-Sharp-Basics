using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour     =int.Parse(Console.ReadLine());
            int minutes  = int.Parse(Console.ReadLine());
            int newMinutes = minutes+15;
            if (newMinutes <= 59)
            {
                
            }
            else if (hour < 23)
            {
                newMinutes = newMinutes % 60;
                hour = hour + 1;
            }
            else
            {
                newMinutes = newMinutes % 60;
                hour = 0;
            }
            
            
            if (newMinutes < 10)
                Console.WriteLine($"{hour}:0{newMinutes}");
            else
                Console.WriteLine($"{hour}:{newMinutes}");

        }
    }
}
