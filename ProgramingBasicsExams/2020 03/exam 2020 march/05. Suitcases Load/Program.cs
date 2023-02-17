using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxVolume = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double newCaseVolume = 0;
            double casesVolume = 0;
            int counter = 0;
            
            while (input != "End")
            {
                counter++;
                newCaseVolume = double.Parse(input);
                if (counter % 3 == 0)
                {
                    newCaseVolume = newCaseVolume + newCaseVolume * 0.1;
                }
               
                if (maxVolume >= newCaseVolume)
                {
                    maxVolume = maxVolume - newCaseVolume;
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"No more space!");
                    Console.WriteLine($"Statistic: {counter-1} suitcases loaded.");
                    break;
                }
                
            }
            if (input == "End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
                Console.WriteLine($"Statistic: {counter} suitcases loaded.");
            }
            
            
            
            /*•	При получаване на командата "End" се печата:
               "Congratulations! All suitcases are loaded!"
              •	Ако обемът на куфара е по-голям от оставащото пространство в багажника:
                "No more space!"
              •	Накрая винаги се отпечатва статистика – колко багажа са натоварени:
                "Statistic: {брой натоварени багажи} suitcases loaded."
*/
        }
    }
}
