using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());
            double numOfPersons = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;


            for (int i = 1; i <= numberOfGroups; i++)
            {
                numOfPersons = int.Parse(Console.ReadLine());
                
                if (numOfPersons <= 5) 
                {
                    p1 = p1 + numOfPersons;
                }
                else if (numOfPersons <= 12)
                {
                    p2 = p2 + numOfPersons;
                }
                else if (numOfPersons <= 25)
                {
                    p3 = p3 + numOfPersons;
                }
                else if (numOfPersons <= 40)
                {
                    p4 = p4 + numOfPersons;
                }
                else if (numOfPersons > 40)
                {
                    p5 = p5 + numOfPersons;
                }
            }

            numOfPersons = p1 + p2 + p3 + p4 + p5;
            
            
            p1 = p1 / numOfPersons * 100;
            
            p2 = p2 / numOfPersons * 100;
            
            p3 = p3 / numOfPersons * 100;
            
            p4 = p4 / numOfPersons * 100;
            
            p5 = p5 / numOfPersons * 100;
            
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");


        }
    }
}
