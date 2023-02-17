using System;

namespace _01_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //• Цена за отпечатване на една страница -реално число в интервала(0.00…1.50]
            //•	Цена за отпечатване на една корица -реално число в интервала(0.00…5.00]
            //•	Процентно намаление за отпечатване на хартия -цяло число в интервала(0…100]
            //•	Сумата, която трябва да се заплати на дизайнер - реално число в интервала(0.00…150.00]
            //•	Процент от цялата дължима сума, който е заплатен от екипа - цяло число в интервала[0…100]
            double pricePerPage = double.Parse(Console.ReadLine());
            double pricePer1Cover = double.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());
            double pricePerDesign= double.Parse(Console.ReadLine());
            double paidByStuff = int.Parse(Console.ReadLine());

            double initialPrice = pricePerPage * 899 + pricePer1Cover * 2;
            initialPrice = initialPrice -initialPrice* discountPercent / 100;
            initialPrice = initialPrice + pricePerDesign;
            initialPrice = initialPrice - initialPrice * paidByStuff / 100;

            Console.WriteLine($"Avtonom should pay {initialPrice:f2} BGN.");

            //"Avtonom should pay {money:f2} BGN."
        }
    }
}
