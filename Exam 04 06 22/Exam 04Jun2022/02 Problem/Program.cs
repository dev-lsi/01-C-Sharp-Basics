using System;

namespace _02_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред - името на футболният фен – текст
            //•	На втория ред - предвиденият бюджет  – реално число в диапазона[1.0… 100 000.0]
            //•	На третия ред - брой бутилки бира – цяло число в диапазона[1… 100 000]
            //•	На четвърти ред - брой пакети чипс – цяло число в диапазона[1… 100 000]

            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numberOfBotlles= int.Parse(Console.ReadLine());
            int numberOfCipsPacks = int.Parse(Console.ReadLine());

            double pricePerBeers = numberOfBotlles * 1.20;
            double priceForChips = pricePerBeers * 0.45;
            priceForChips = priceForChips * numberOfCipsPacks;
            priceForChips = Math.Ceiling(priceForChips);
            double totalPrice = pricePerBeers + priceForChips;

            if(budget >= totalPrice)
            {
                Console.WriteLine($"{name} bought a snack and has {(budget - totalPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {(budget - totalPrice)*(-1):f2} more leva!");

            }


            // • Ако бюджетът е достатъчен за закупуването на продуктите: 
            // "{име} bought a snack and has {останали пари} leva left."
            //•	Ако бюджетът НЕ е достатъчен:
            // "{име} needs {нужни пари} more leva!"


        }
    }
}
