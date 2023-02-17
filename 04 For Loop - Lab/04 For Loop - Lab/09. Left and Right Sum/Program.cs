﻿using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = n;
            
            int leftSum = 0;
            int rightSum = 0;
            
            for (int i = 1; i <= n; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
               
            }
            for (int j=1; j <=m; j++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());

            }


            if (leftSum == rightSum)
                Console.WriteLine("Yes, sum = " + leftSum);
            else
            {
                int diff = Math.Abs(rightSum - leftSum);
                Console.WriteLine("No, diff = " + diff);
            }

        }
    }
}
