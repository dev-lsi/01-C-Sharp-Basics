using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int kids = 0;
            int standard = 0;
            int student = 0;
            int soldTickets = 0;

            string movie = Console.ReadLine();

            while (movie != "Finish")
            {

                int seats = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {

                    if (ticketType == "kid")
                    {
                        kids++;
                    }
                    else if (ticketType == "student")
                    {
                        student++;
                    }
                    else if (ticketType == "standard")
                    {
                        standard++;
                    }
                    soldTickets++;
                    
                    if (seats == soldTickets)
                    {
                        break;
                    }
                    else
                    {
                        ticketType = Console.ReadLine();
                    }

                }
                Console.WriteLine($"{movie} - {(soldTickets * 100.0) / seats:f2}% full.");
                soldTickets = 0;
                movie = Console.ReadLine();
            }
            int totalSold = (kids + standard + student);
            Console.WriteLine($"Total tickets: {totalSold}");
            Console.WriteLine($"{(student*100.0/ totalSold):f2}% student tickets.");
            Console.WriteLine($"{(standard*100.0/totalSold):f2}% standard tickets.");
            Console.WriteLine($"{(kids*100.0 / totalSold):f2}% kids tickets.");

            

        }
    }
}
