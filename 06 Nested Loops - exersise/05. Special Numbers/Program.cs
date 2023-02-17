using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nN = int.Parse(Console.ReadLine());

            for(int num = 1111; num <= 9999; num++)
            {
                string numStr = num.ToString();

                for(int j = 0; j <= 3; j++)
                {
                    char currChar = numStr[j];
                    int currDiggit = int.Parse(currChar.ToString());
                    if (currDiggit == 0)
                    {
                        break;
                    }
                    else if (nN % currDiggit != 0)
                    {
                        break;
                    }
                    else if (nN % currDiggit == 0)
                    {
                        if (j == 3)
                        {
                            Console.Write($"{num} ");
                            break;
                        }
                        continue;  
                    }
                    
                }
                

            }

        }
    }
}
