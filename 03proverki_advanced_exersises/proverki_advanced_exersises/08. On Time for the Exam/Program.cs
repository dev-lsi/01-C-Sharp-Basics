using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examSumMinutes = examHour * 60 + examMinutes;
            int arrivalSumMinutes = arrivalHour * 60 + arrivalMinutes;

            int diverse = examSumMinutes - arrivalSumMinutes;
            if(diverse<0)
            {
                Console.WriteLine("Late");
            }  
            else if (diverse == 0 || diverse <= 30)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Early");
            }

            int hours = Math.Abs(diverse / 60);
            int minutes = Math.Abs(diverse % 60);

            
            if (diverse > 0 & minutes < 10)
            {
                if (hours == 0)
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{hours}:0{minutes} hours before the start");
                }
            }
            if (diverse > 0 & minutes >= 10)
            {
                if (hours == 0)
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{hours}:{minutes} hours before the start");
                }
            }
            if (diverse < 0 & minutes < 10)
            {
                if (hours == 0)
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{hours}:0{minutes} hours after the start");
                }
            }
            if (diverse < 0 & minutes >= 10)
            {
                if (hours == 0)
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{hours}:{minutes} hours after the start");
                }
            }





        }
    }
}
