using System;

namespace _01._Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.	Име на авиокомпанията - текст
2.	Брой билети за	 възрастни – цяло число в диапазона [1…400]
3.	Брой детски билети – цяло число в диапазона [25…120]
4.	Нетна цена на билет за възрастен – реално число в диапазона [100.0…1600.0]
5.	Цената на такса обслужване - реално число в диапазона [10.0…50.0]
*/
            string companyName = Console.ReadLine();
            int matureTicketsNumber = int.Parse(Console.ReadLine());
            int cildrenTicketsNumber = int.Parse(Console.ReadLine());
            double ticketPrice= double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double matureSumPrice = matureTicketsNumber * ticketPrice;
            double childrenSumPrice = cildrenTicketsNumber * ticketPrice;
            childrenSumPrice = childrenSumPrice * 0.3;
            
            double SumPrice = (matureSumPrice + childrenSumPrice)+tax*(matureTicketsNumber+ cildrenTicketsNumber);
            double profit = SumPrice * 0.2;
            Console.WriteLine($"The profit of your agency from {companyName} tickets is {profit:f2} lv.");
            
        }
    }
}
