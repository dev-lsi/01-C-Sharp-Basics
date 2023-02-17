using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            /*V една кинозала столовете са наредени в правоъгълна форма в r реда и c колони. 
             * Има три вида прожекции с билети на различни цени:
            •	Premiere – премиерна прожекция, на цена 12.00 лева.
            •	Normal – стандартна прожекция, на цена 7.50 лева.
            •	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
            Напишете програма, която чете 
            тип прожекция (стринг), 
            брой редове и 
            брой колони в залата (цели числа), въведени от потребителя, 
            и изчислява общите приходи от билети при пълна зала. 
            Резултатът да се отпечата във формат като в примерите по-долу, 
            с 2 знака след десетичната точка.  */

            string typeOfProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double price = 0;
            

            if (typeOfProjection == "Premiere")
            {
                price = 12.00;
                
            }
            else if(typeOfProjection== "Normal")
            {
                price = 7.50;
            }
            else
            {
                price = 5.00;
            }

            int seats = rows * columns;
            double income = seats * price;
            Console.WriteLine($"{income:f2} leva");

        }
    }
}
