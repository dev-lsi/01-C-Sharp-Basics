using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първи ред - брой незадоволителни оценки -цяло число в интервала[1…5]
            //•	След това многократно се четат по два реда:
            //o Име на задача -текст(низ)
            //o Оценка -цяло число в интервала[2…6]

            int numOfpoorGrades = int.Parse(Console.ReadLine());
            string nameOfProblem = Console.ReadLine();
            string lastName = nameOfProblem;
            double grade = double.Parse(Console.ReadLine());
            double gradeSum = 0;
            int counter = 0;
            int allCounter = 0;

            while (nameOfProblem != "Enough")
            {
                allCounter++;
                gradeSum = gradeSum + grade;

                if (grade <= 4)
                {
                    counter++;
                    if (counter == numOfpoorGrades)
                    {
                        Console.WriteLine($"You need a break, {counter} poor grades.");
                        break;
                    }
                    else
                    {
                        nameOfProblem = Console.ReadLine();
                        grade = double.Parse(Console.ReadLine());
                        continue;
                    }
                }
                else if (grade > 4)
                {
                    lastName = nameOfProblem;
                    nameOfProblem = Console.ReadLine();
                    if (nameOfProblem == "Enough")
                    {
                        break;
                    }
                    else
                    {
                        grade = double.Parse(Console.ReadLine());
                    }
                }

            }
            if (nameOfProblem == "Enough")
            {
                Console.WriteLine($"Average score: {(gradeSum / allCounter):f2}");
                Console.WriteLine($"Number of problems: {allCounter}");
                Console.WriteLine($"Last problem: {lastName}");
            }
        }
    }
}
