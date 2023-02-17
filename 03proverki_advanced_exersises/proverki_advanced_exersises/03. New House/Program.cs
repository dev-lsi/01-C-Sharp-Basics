using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            //   цвете                     Роза    Далия   Лале    Нарцис   Гладиола
            //Цена на брой в лева            5     3.80    2.80       3        2.50

            //• Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //•	Брой цветя -цяло число в интервала[10…1000]
            //•	Бюджет - цяло число в интервала[50…2500]
            
            string flowerType = Console.ReadLine();
            int flowerQuantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;

            //•	Ако Нели купи повече от 80 Рози - 10% отстъпка от крайната цена
            //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
            if (flowerType == "Roses")
            {
                if (flowerQuantity <= 80)
                {
                    price = 5.00;
                }
                else
                {
                    price =5.00;
                    price = price - price * 0.1;
                }
                
            }
            else if(flowerType == "Dahlias")
            {
                if (flowerQuantity <= 90)
                {
                    price = 3.8;
                }
                else
                {
                    price =3.8;
                    price = price - price * 0.15;
                }
            }
            else if (flowerType == "Tulips")
            {
                if (flowerQuantity <= 80)
                {
                    price = 2.8;
                }
                else
                {
                    price =2.8;
                    price = price - price * 0.15;
                }
            }
            else if (flowerType == "Narcissus")
            {
                if (flowerQuantity >= 120)
                {
                    price = 3.00;
                }
                else
                {
                    price =3.00;
                    price = price + price * 0.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                if (flowerQuantity >= 80)
                {
                    price = 2.50;
                }
                else
                {
                    price =2.50;
                    price = price + price * 0.20;
                }
            }
            
            //Да се отпечата на конзолата на един ред:
            //•	Ако бюджета им е достатъчен -
            //"Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
            //•	Ако бюджета им е НЕ достатъчен -"Not enough money, you need {нужната сума} leva more."
            //Сумата да бъде форматирана до втория знак след десетичната запетая.

            double balance = budget - price * flowerQuantity;
            
            if (balance >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flowerType} and {balance:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(Math.Abs(balance)):f2} leva more.");
            }

        }
    }
}
