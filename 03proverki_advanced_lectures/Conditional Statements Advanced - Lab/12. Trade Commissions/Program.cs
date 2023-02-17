using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        /*Град	0 ≤ s ≤ 500	500 < s ≤ 1 000	1 000 < s ≤ 10 000	s > 10 000
          Sofia	    5%	          7%	           8%	         12%
          Varna	    4.5%	      7.5%	           10%	         13%
         Plovdiv	5.5%	      8%	           12%	         14.5%
*/
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comissionPercent = 0;
            bool isValid = (sales >= 0 && (city =="Varna" || city =="Plovdiv" || city =="Sofia"));
            
            if (!isValid)
            {
                Console.WriteLine("error");
            }
            else
            {
                switch (city)
                {
                    case "Sofia":
                        if (sales >= 0 && sales <= 500) 
                        { 
                            comissionPercent = 5; 
                        }
                        else if (sales > 500 && sales <= 1000) 
                        { 
                            comissionPercent = 7; 
                        }
                        else if (sales > 1000 && sales <= 10000) 
                        { 
                            comissionPercent = 8; 
                        }
                        else if (sales > 10000) 
                        { 
                            comissionPercent = 12; 
                        }
                        break;
                    case "Varna":
                        if (sales >= 0 && sales <= 500) 
                        { 
                            comissionPercent = 4.5; 
                        }
                        else if (sales > 500 && sales <= 1000) 
                        { 
                            comissionPercent = 7.5; 
                        }
                        else if (sales > 1000 && sales <= 10000) 
                        { 
                            comissionPercent = 10; 
                        }
                        else if(sales > 10000) 
                        { 
                            comissionPercent = 13; 
                        }
                        break;
                    case "Plovdiv":
                        if (sales >= 0 && sales <= 500) 
                        { 
                            comissionPercent = 5.5; 
                        }
                        else if (sales > 500 && sales <= 1000) 
                        { 
                            comissionPercent = 8; 
                        }
                        else if (sales > 1000 && sales <= 10000) 
                        { 
                            comissionPercent = 12; 
                        }
                        else if (sales > 10000) 
                        { 
                            comissionPercent = 14.5; 
                        }
                        break;
                    default:
                        break;
                       
                }
                double comission = sales * comissionPercent / 100;
                Console.WriteLine($"{comission:F2}");
            }
                 
        }
    }
}
