using System;

namespace problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	1 грам мазнини = 9 калории
            //•	1 грам протеини = 4 калории
            //•	1 грам въглехидрати = 4 калории

            //•	Процент на мазнините - цяло число в интервала[0…100]
            //•	Процент на протеините - цяло число в интервала[0…100]
            //•	Процент на въглехидратите - цяло число в интервала[0…100]
            //•	Общ брой калории - цяло число в интервала[1000…15000]
            //•	Процент на съдържанието на вода - цяло число в интервала[0…100]
            
            double prOils = int.Parse(Console.ReadLine());
            double prProteins = int.Parse(Console.ReadLine());
            double prShugars = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());
            double prWater = int.Parse(Console.ReadLine());

            
            
            double gramsOils=     prOils * calories/100.0 / 9;
            double gramsProt =    prProteins*calories/100.0 / 4;
            double gramsShugars = prShugars * calories/100.0 / 4;

            double foodWeight = gramsOils + gramsProt + gramsShugars;
            double caloriesPerGram = calories / foodWeight;
            double myCal = caloriesPerGram * (100-prWater)/100;



            Console.WriteLine($"{myCal:f4}");

        }
    }
}
