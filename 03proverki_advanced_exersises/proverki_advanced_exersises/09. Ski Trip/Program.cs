using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            /*	"room for one person" – 18.00 лв за нощувка
              	"apartment" – 25.00 лв за нощувка 
              	"president apartment" – 35.00 лв за нощувка
            */
            //input
            //•	Първи ред -дни за престой -цяло число в интервала[0...365]
            //•	Втори ред -вид помещение -
            //     "room for one person", "apartment" или "president apartment"
            //•	Трети ред -оценка - "positive"  или "negative"

            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string grade = Console.ReadLine();
            double price = 0;
            

            //roomType vs price
            //calculations
            //grade

            if (roomType == "president apartment")
            {
                price = 35.00;
                if (days < 10)
                {
                    price = price - price * 0.1;
                }
                if (days <= 15)
                {
                    price = price - price * 0.15;
                }
                else
                {
                    price = price - price * 0.20;
                }

            }
            else if (roomType == "apartment")
            {
                price = 25.00;
                if (days < 10)
                {
                    price = price - price * 0.30;
                }
                if (days <= 15)
                {
                    price = price - price * 0.35;
                }
                else
                {
                    price = price - price * 0.50;
                }
            }
            else
            {
                price = price = 18.00;
            }
            //check the grade
            if (grade == "positive")
            {
                price = price + price * 0.25;
            }
            else
            {
                price =  price - price * 0.10;
            }
            //output
            price = price * (days - 1);
            Console.WriteLine($"{price:f2}");


        }  
    }
}
