using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int num = 0;
            int sum = 0;
            int diff = 0;

            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());


                sum = sum + num;
                
                    if (num >= maxNum)
                {
                    maxNum=num;
                }
                
                
            }
             diff = Math.Abs(sum - maxNum- maxNum);
            
            if (diff == 0)
            {
                //"Yes" и на нов ред "Sum = "  + неговата стойност
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNum);
            }
            else
            {
                //"No" и на нов ред "Diff = " + разликата между най-големия 
                
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }   
    }
}
