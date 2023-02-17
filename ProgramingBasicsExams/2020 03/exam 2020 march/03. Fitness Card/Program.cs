using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Пол	Gym	 Boxing	 Yoga	Zumba	Dances	Pilates
              мъж	$42	  $41	 $45	$34	     $51	  $39
             жена	$35	  $37	 $42	$31	     $53	  $37
            */
            double budget = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double price = 0;

            if (gender == 'm')
            {
                switch (sport)
                {
                    case "Gym": price = 42.00; break;
                    case "Boxing": price = 41.00; break;
                    case "Yoga": price = 45.00; break;
                    case "Zumba": price = 34.00; break;
                    case "Dances": price = 51.00; break;
                    case "Pilates": price = 39.00; break;
                    default:break;

                }
            }
            else if (gender == 'f')
            {
                switch (sport)
                {
                    case "Gym": price = 35.00; break;
                    case "Boxing": price = 37.00; break;
                    case "Yoga": price = 42.00; break;
                    case "Zumba": price = 31.00; break;
                    case "Dances": price = 53.00; break;
                    case "Pilates": price = 37.00; break;
                }
            }
            
            if (age <= 19)
            {
                price = price - price * 0.2;
            }
            
            if (budget >= price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${(price-budget):f2} more.");
            }

        }
    }
}
