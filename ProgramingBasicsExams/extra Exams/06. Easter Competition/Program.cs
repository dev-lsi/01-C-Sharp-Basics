using System;

namespace _06._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 0;
            int gradeSum = 0;
            int MaxgradeSum = int.MinValue;
            string bestCook = "";
            
            int numberOfCackes = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOfCackes; i++)
            {
                string name = Console.ReadLine();

                while(name != "Stop")
                {
                    string input = Console.ReadLine();
                    
                    if (input == "Stop")
                    {
                        if (gradeSum > MaxgradeSum)
                        {
                            bestCook = name;
                            MaxgradeSum = gradeSum;
                            Console.WriteLine($"{name} has {gradeSum} points.");
                            Console.WriteLine($"{name} is the new number 1!");
                            gradeSum = 0;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{name} has {gradeSum} points.");
                            gradeSum = 0;
                            break;
                        }
                        
                    }
                    else
                    {
                        grade = int.Parse(input);
                        gradeSum = gradeSum + grade;
                        continue;
                    }

                }
                
            }
           Console.WriteLine($"{bestCook} won competition with {MaxgradeSum} points!");
        }
    }
}
