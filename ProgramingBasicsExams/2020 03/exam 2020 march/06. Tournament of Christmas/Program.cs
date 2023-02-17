using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
           int days=int.Parse(Console.ReadLine());
            //string sport = "";
            string result ="";
            int winsCounter=0;
            int dalyGamesCounter = 0;
            double daylysavedMoney = 0;
            double allSavedMoney = 0;
            int windayCounter = 0;
           
            for (int i = 1; i <= days; i++)
            {
                string input = Console.ReadLine();

                while (input != "Finish")
                {
                    dalyGamesCounter++;
                    result = Console.ReadLine();
                    if (result == "win")
                    {
                        winsCounter++;
                        daylysavedMoney = daylysavedMoney + 20;
                    }
                    else if (result == "lose")
                    {
                        
                    }
                    input = Console.ReadLine();
                }
                if ((dalyGamesCounter / 2) < winsCounter)
                {
                    daylysavedMoney = daylysavedMoney + daylysavedMoney * 0.1;
                    allSavedMoney = allSavedMoney + daylysavedMoney;
                    windayCounter++;
                }
                else
                {
                    allSavedMoney = allSavedMoney + daylysavedMoney;
                }
                daylysavedMoney = 0;
                winsCounter = 0;
                dalyGamesCounter = 0;

            }
            if (windayCounter > days / 2)
            {
                allSavedMoney = allSavedMoney + allSavedMoney * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {allSavedMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {allSavedMoney:f2}");
            }

        }
    }
}
