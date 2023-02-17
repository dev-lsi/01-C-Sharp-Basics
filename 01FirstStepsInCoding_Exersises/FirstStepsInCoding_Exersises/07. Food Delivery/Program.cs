using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChicken = int.Parse(Console.ReadLine());
            int menuFish = int.Parse(Console.ReadLine());
            int menuVegan = int.Parse(Console.ReadLine());

            double priceChicken = 10.35;
            double priceFish = 12.40;
            double priceVegan = 8.15;
            double priceDelivery = 2.50;
            
            double priceMenu = (menuFish * priceFish) + (menuChicken * priceChicken) + (menuVegan * priceVegan);
            double priceDessert = priceMenu * 0.2;

            double bill = priceMenu + priceDessert + priceDelivery;
            
            Console.WriteLine(bill);
        }
    }
}
