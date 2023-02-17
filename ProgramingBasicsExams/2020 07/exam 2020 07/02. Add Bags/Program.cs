using System;

namespace _02._Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.	Цената на багаж над 20кг - реално число в диапазона [10.0…80.0]
             2 .	Килограми на багажа – реално число в диапазона [1.0…32.0]
             3.	Дни до пътуването – цяло число в диапазона [1…60]
             4.	Брой багажи – цяло число в диапазона [1…10]
            */
            double priceOver20kg = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            int daysToFly = int.Parse(Console.ReadLine());
            int numberOfLugages = int.Parse(Console.ReadLine());
            double tax = 0;
            //according weight
            if (weight < 10)
            {
                tax =priceOver20kg*0.2;
            }
            else if (weight <= 20)
            { 
                tax = priceOver20kg*0.5;
            }
            else
            {
               // tax = double.Parse(Console.ReadLine());
                tax = priceOver20kg;
            }
            //according days

            if (daysToFly > 30)
            {
                tax =tax+tax*0.1;
            }
            else if (daysToFly < 7)
            {
                tax =tax+tax*0.4;
            }
            else
            {
                tax =tax+tax*0.15;
            }
            //
            tax = tax * numberOfLugages;
            Console.WriteLine($"The total price of bags is: {tax:f2} lv. ");
        }
    }
}
