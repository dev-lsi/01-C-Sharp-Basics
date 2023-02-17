using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityPens = double.Parse(Console.ReadLine());
            double quantityMarkers = double.Parse(Console.ReadLine());
            double quantityLiquid = double.Parse(Console.ReadLine());
            double discountPercent = double.Parse(Console.ReadLine());

            double pricePens = 5.8;
            double priceMarkers = 7.2;
            double priceLiquid = 1.2;

            double price = quantityPens * pricePens + quantityMarkers * priceMarkers + quantityLiquid * priceLiquid;
            double discount = price * discountPercent / 100;
            double priceFinal = price - discount;
            
            Console.WriteLine(priceFinal);
        }
    }
}
