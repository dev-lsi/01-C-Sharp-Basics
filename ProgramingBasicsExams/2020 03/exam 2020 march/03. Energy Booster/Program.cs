using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Плод - текст с възможности: "Watermelon", "Mango", "Pineapple" или "Raspberry"
            //2.Размерът на сета -текст с възможности: "small" или "big"
            //3.Брой на поръчаните сетове - цяло число в интервала[1 … 10000]
            /*	  Диня 	           Манго	        Ананас	     Малина
2 броя (small)	56 лв./бр.	    36.66 лв./бр.	42.10 лв./бр.	20 лв./бр.
5 броя (big)	28.70 лв./бр.	19.60 лв./бр.	24.80 лв./бр.	15.20 лв./бр.
*/
            string fruitType = Console.ReadLine();
            string setType =Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            if (setType == "small")
            {
                switch (fruitType)
                {
                    case "Watermelon":price = 56.00;break;
                    case "Mango": price = 36.66; break;
                    case "Pineapple": price = 42.10; break;
                    case "Raspberry": price = 20.00; break;
                    default: break;
                }
            }
            else if (setType == "big")
            {
                switch (fruitType)
                {
                    case "Watermelon": price = 28.70; break;
                    case "Mango": price = 19.60; break;
                    case "Pineapple": price = 24.80; break;
                    case "Raspberry": price = 15.20; break;
                    default: break;
                }
            }
            if (setType == "small")
            {
                price = price * 2;

            }
            else if (setType == "big")
            {
                price = price * 5;
            }
            
            price = price * quantity;
            
            if (price > 1000)
            {
                price = price / 2;
            }
            else if (price >= 400)
            {
                price = price - price * 0.15;
            }
            
            Console.WriteLine($"{price:f2} lv.");
            


        }
    }
}
