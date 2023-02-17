using System;

namespace problem_3
{
    class Program
    {
        static void Main(string[] args)
        {

            double weightKg = double.Parse(Console.ReadLine());
            string deliveryType = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double pricePerKm = 0;
            double standardPrice = 0;
            double expressPrice = 0;
            double adds = 0;


            // За пратки по - леки от 1 кг – 3 стотинки на километър.
            //•	От 1 кг до 10 кг – 5 стотинки на километър.
            //•	От 10 кг вкл. до 40 кг – 10 стотинки на километър.
            //•	От 40 кг вкл. до 90  кг – 15 стотинки на километър.
            //•	От 90 кг вкл. до 150 кг – 20 стотинки на километър

            //•	За пратки по - леки от 1 кг – на килограм по 80 % от съответната цена на километър
            //•	От 1 кг до 10  кг – на килограм по 40 % от съответната цена на километър
            //•	От 10 кг вкл. до 40 кг – на килограм по 5 % от съответната цена на километър
            //•	От 40 кг вкл. до 90  кг – на килограм по 2 % от съответната цена на километър
            //•	От 90 кг вкл. до 150 кг – на килограм по 1 % от съответната цена на километър
            
            
                if (weightKg < 1)
                {
                    pricePerKm = 3;
                    standardPrice = pricePerKm * distance;
                    adds = pricePerKm * 0.8 * weightKg* distance;
                    expressPrice = standardPrice + adds;
                }
                else if (weightKg < 10)
                {
                pricePerKm = 5;
                standardPrice = pricePerKm * distance;
                adds = pricePerKm * 0.4 * weightKg* distance;
                expressPrice = standardPrice + adds;
                }
                else if (weightKg < 40)
                {
                    pricePerKm = 10;
                standardPrice = pricePerKm * distance;
                adds = pricePerKm * 0.05 * weightKg* distance;
                expressPrice = standardPrice + adds;
                }
                else if (weightKg < 90)
                {
                    pricePerKm = 15;
                standardPrice = pricePerKm * distance;
                adds = pricePerKm * 0.02 * weightKg*distance;
                expressPrice = standardPrice + adds;
                }
                else if (weightKg < 150)
                {
                   pricePerKm = 20;
                   standardPrice = pricePerKm * distance;
                   adds= pricePerKm * 0.01 * weightKg* distance;
                   expressPrice = standardPrice + adds;
                }

                
                if(deliveryType== "standard")
                {
                
                Console.WriteLine($"The delivery of your shipment with weight of {weightKg:f3} kg. would cost {standardPrice/100:f2} lv.");
                }
                else if(deliveryType== "express")
                {
                Console.WriteLine($"The delivery of your shipment with weight of {weightKg:f3} kg. would cost {expressPrice/100:f2} lv.");
                }




        }
    }
}
