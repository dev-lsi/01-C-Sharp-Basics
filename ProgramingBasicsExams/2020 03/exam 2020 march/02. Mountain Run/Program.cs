using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldRecord = double.Parse(Console.ReadLine()); //s  v=m/s
            double distance = double.Parse(Console.ReadLine()); //m
            double velocityPesho = double.Parse(Console.ReadLine()); //m/s na50m se zab 30sec.
            double delay = 0;

            delay = (distance / 50);
            
            delay = Math.Floor(delay) * 30;
           
            double timePesho = (distance * velocityPesho) + delay;
         
            if(oldRecord - timePesho <= 0)
            {
                timePesho = timePesho-oldRecord;
                Console.WriteLine($"No! He was {timePesho:f2} seconds slower.");
            }
            else if(oldRecord - timePesho > 0)
            {
               
                Console.WriteLine($" Yes! The new record is {timePesho:f2} seconds.");
            }


        }
    }
}
