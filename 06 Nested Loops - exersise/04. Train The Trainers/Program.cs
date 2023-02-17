using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfGudges = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();
            double gradeSum = 0;
            double averageGrade = 0;
            double averageGradeSum = 0;
            int presentationsCounter = 0;
           // string nameOfPresentation = Console.ReadLine();

            while (nameOfPresentation != "Finish")
            {
                presentationsCounter++;

                for (int i = 1; i <= numberOfGudges; i++)
                {
                    double currentGrade = double.Parse(Console.ReadLine());
                    gradeSum += currentGrade;
                }
                averageGrade = gradeSum / numberOfGudges;
                Console.WriteLine($"{nameOfPresentation} - {averageGrade:f2}.");
                averageGradeSum = averageGradeSum + averageGrade;
                gradeSum = 0;
                nameOfPresentation = Console.ReadLine();
               
            }
            averageGradeSum = averageGradeSum / presentationsCounter;
            Console.WriteLine($"Student's final assessment is {averageGradeSum:f2}.");

        }
    }
}
