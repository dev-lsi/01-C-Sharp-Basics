using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            double price = 0;

            if(day=="Monday"||day=="Tuesday"||day=="Friday")
            {
                price = 12;
            }
            else if (day == "Wednesday" || day == "Thursday")
            {
                price = 14;
            }
            else if(day=="Saturday"||day=="Sunday")
            {
                price = 16;
            }
            Console.WriteLine($"{price}");
            /*switch (day)
            {
                case "Monday":price =12;break;
                case "Tuesday": price =12; break;
                case "Wednesday": price =14; break;
                case "Thursday": price =14; break;
                case "Friday": price =12; break;
                case "Saturday": price =16; break;
                case "Sunday": price =16; break;
                
                default:break;   
            }
                Console.WriteLine($"{price}");*/
        }
    }
}
