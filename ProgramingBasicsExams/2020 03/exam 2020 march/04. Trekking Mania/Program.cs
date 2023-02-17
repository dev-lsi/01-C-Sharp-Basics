using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());
            double allPersons = 0;
            double musala = 0;
            double montblan = 0;
            double kilimandj = 0;
            double everest = 0;
            double k2 = 0;

            for(int i = 1; i <= numberOfGroups; i++)
            {
                int personsInGroup=int.Parse(Console.ReadLine());
                allPersons = allPersons + personsInGroup;
                
                if (personsInGroup <= 5)
                {
                    musala = musala + personsInGroup;
                }
                else if (personsInGroup <= 12)
                {
                    montblan = montblan + personsInGroup;
                }
                else if (personsInGroup <= 25)
                {
                    kilimandj = kilimandj + personsInGroup;
                }
                else if (personsInGroup <= 40)
                {
                    k2 = k2 + personsInGroup;
                }
                else
                {
                    everest = everest + personsInGroup;
                }
            }
            
            allPersons = musala + montblan + kilimandj + k2 + everest;
            
            musala = musala / allPersons * 100;
            montblan= montblan/ allPersons * 100;
            kilimandj= kilimandj / allPersons * 100;
            k2 = k2 / allPersons * 100;
            everest = everest / allPersons * 100;

            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{montblan:f2}%");
            Console.WriteLine($"{kilimandj:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");

        }
    }
}
