﻿using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            
            int secondsSum = firstTime + secondTime + thirdTime;
            int minutes = secondsSum / 60;
            int seconds = secondsSum % 60;
            
            if (seconds >= 10)
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
               

        }
    }
}
