using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            double priceExcursion = double.Parse(Console.ReadLine());
            int pcsPussles = int.Parse(Console.ReadLine());
            int pcsDolls = int.Parse(Console.ReadLine());
            int pcsBears = int.Parse(Console.ReadLine());
            int pcsMinions= int.Parse(Console.ReadLine());
            int pcsTrucks = int.Parse(Console.ReadLine());
            
            
            double pricePussle = 2.6;
            double priceDoll = 3;
            double priceBear = 4.1;
            double priceMinion = 8.2;
            double priceTruck = 2;

            int pieces = pcsPussles + pcsDolls + pcsBears + pcsMinions + pcsTrucks;
            
            double priceToys = pcsPussles*pricePussle + pcsDolls*priceDoll + 
                   pcsBears*priceBear + pcsMinions*priceMinion + pcsTrucks*priceTruck;
            
            double discount = priceToys*0.25;
            double rent = 0.9;
            double bill = 0;
            
            

            if (pieces >= 50)
            {
                bill = (priceToys - discount) * rent;
                
            }
            else
            {
                bill = priceToys * rent;
            }

            
            double balance = bill - priceExcursion;
            


            if (balance >= 0)
            { 
                Console.WriteLine($"Yes! {balance:F2} lv left.");
                
            }
            else
            {
                balance = Math.Abs(balance);
                Console.WriteLine($"Not enough money! {balance:F2} lv needed."); 
            }


        }
    }
}
