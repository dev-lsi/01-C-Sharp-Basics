using System;

namespace _03_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //                    Торта               Суфле            Баклава
            //До 15 декември      24 лв./ бр.      6.66 лв./ бр.    12.60 лв./ бр.
            //След 15 декември    28.70 лв./ бр.   9.80 лв./ бр.    16.98 лв./ бр.

            //•	При поръчка от 100 лв.до 200 лв. -> 15 % отстъпка
            //•	При поръчка над 200 лв. -> 25 % отстъпка
            //•	До 15 декември включително -> 10 % допълнителна отстъпка от крайната цена

            

            string kindOfProduct = Console.ReadLine();
            int numberOfProducts = int.Parse(Console.ReadLine());
            int dayOfOrder= int.Parse(Console.ReadLine());
            double price = 0;

            if(kindOfProduct== "Cake")
            {
                if (dayOfOrder <= 15)
                {
                    price =24.00;
                }
                else
                {
                    price =28.70;
                }
            }
            else if (kindOfProduct == "Souffle")
            {
                if (dayOfOrder < 15)
                {
                    price =6.66;
                }
                else
                {
                    price =9.80;
                }
            }
            else if (kindOfProduct == "Baklava")
            {
                if (dayOfOrder <= 15)
                {
                    price =12.60;
                }
                else
                {
                    price =16.98;
                }
            }
            price = price * numberOfProducts;


            if (dayOfOrder <= 22)
            {
                if (price > 200)
                {
                    price = price * 0.75;
                }
                else if (price > 100)
                {
                    price = price * 0.85;

                }
            }

            if (dayOfOrder <= 15)
            {
                price = price * 0.9;
            }


            Console.WriteLine($"{price:f2}");

        }
    }
}
