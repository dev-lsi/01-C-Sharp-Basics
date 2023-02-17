using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред е месецът – May, June, July, August, September или October
            //•	На втория ред е броят на нощувките – цяло число в интервала[0... 200]
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;
            //check monts set prices
            switch (month)
            {
                case "May":
                case "October":
                    priceApartment =65.00;
                    priceStudio =50.00;
                    break;
                case "June":
                case "September":
                    priceApartment = 68.70;
                    priceStudio = 75.20;
                    break;
                case "July":
                case "August":
                    priceApartment =77.00;
                    priceStudio =76.00;
                    break;
                default:
                    break;
            }
            string typeOfRoom = "";
            //check for discounts
            if (days > 14)
            {
                priceApartment = priceApartment - priceApartment * 0.1;
            }
            else
            {
                priceApartment = priceApartment*1;
            }
            
            if ((days > 7 & days <= 14) & (month == "May" || month == "October"))
            {
                priceStudio = priceStudio - priceStudio * 0.05;
            }
            else if ((days > 14) & (month == "May" || month == "October"))
            {
                priceStudio = priceStudio - priceStudio * 0.30;
            }
            else if ((days > 14) & (month == "June" || month == "September"))
            {
                priceStudio = priceStudio - priceStudio * 0.20;
            }
            else
            {

            }
            
           
            /*Да се отпечатат на конзолата 2 реда:
              •	На първия ред: “Apartment: {цена за целият престой} lv.”
              •	На втория ред: “Studio: {цена за целият престой} lv.“
            Цената за целия престой форматирана с точност до два знака след десетичната запетая.
            */
            priceApartment = priceApartment * days;
            priceStudio = priceStudio * days;
            Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");


        }
    }
}
