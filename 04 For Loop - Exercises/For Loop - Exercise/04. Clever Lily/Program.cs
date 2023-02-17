using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashMachine = double.Parse(Console.ReadLine());
            int priceToy= int.Parse(Console.ReadLine());
            int counter = 0;
            double money = 0;
            double addMoney = 0;

            double sum = 0;



            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    addMoney = addMoney + 10;
                    money = money + addMoney;
                    money--;
                }
                else
                {
                    counter++;  
                }
            }
                  priceToy = priceToy * counter;
                  money = (money + priceToy)-priceWashMachine;
                
            //•	Ако парите на Лили са достатъчни:
                //o   "Yes! {N}" - където N е остатъка пари след покупката
                //•	Ако парите не са достатъчни:
                //o   "No! {М}" - където M е сумата, която не достига

                if (money>=0)
                {
                    Console.WriteLine($"Yes! {money:f2}");
                }
                else
                {
                    Console.WriteLine($"No! {Math.Abs(money):f2}");
                }

            
        }
    }
}
