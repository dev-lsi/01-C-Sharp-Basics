using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secPerMeter = double.Parse(Console.ReadLine());
            double periods = Math.Floor(distance / 15);
            double slow=periods*12.5;
            double timeIvan = (distance *secPerMeter) + slow;


            /*•	Ако Иван е подобрил Световния рекорд (времето му е по-малко от рекорда) отпечатваме:
            o	" Yes, he succeeded! The new world record is {времето на Иван} seconds."
              •	Ако НЕ е подобрил рекорда (времето му е по-голямо или равно на рекорда) отпечатваме:
            o	"No, he failed! He was {недостигащите секунди} seconds slower."
                Резултатът трябва да се форматира до втория знак след десетичната запетая.*/
            if (timeIvan < timeRecord)
            { 
                Console.WriteLine($" Yes, he succeeded! The new world record is {timeIvan:F2} seconds.");
            }
            else 
            { 
                Console.WriteLine($"No, he failed! He was {(timeIvan-timeRecord):F2} seconds slower.");
            }
        }
    }
}
