using System;

namespace _03._Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfJoinerys = int.Parse(Console.ReadLine());
            double price = 0;
            //Вид на дограмите – текст "90X130" или "100X150" или "130X180" или "200X300";
            string typeOfJoynery = Console.ReadLine();
            //С доставка - "With delivery"           
            // Без доставка -"Without delivery"
            string delivery = Console.ReadLine();
            
            if (numberOfJoinerys < 10)
            {
                Console.WriteLine($"Invalid order");
            }
            else
            {
                //set prices
                if (typeOfJoynery == "90X130")
                {
                    price = 110;
                    if (numberOfJoinerys > 60)
                    {
                        price = price * 0.92;
                    }
                    else if (numberOfJoinerys > 30)
                    {
                        price = price * 0.95;
                    }
                }
                else if (typeOfJoynery == "100X150")
                {
                    price = 140;
                    if (numberOfJoinerys > 80)
                    {
                        price = price * 0.90;
                    }
                    else if (numberOfJoinerys > 40)
                    {
                        price = price * 0.94;
                    }
                }
                else if (typeOfJoynery == "130X180")
                {
                    price = 190;
                    if (numberOfJoinerys > 50)
                    {
                        price = price * 0.88;
                    }
                    else if (numberOfJoinerys > 20)
                    {
                        price = price * 0.93;
                    }
                }
                else if (typeOfJoynery == "200X300")
                {
                    price = 250;
                    if (numberOfJoinerys > 50)
                    {
                        price = price * 0.86;
                    }
                    else if (numberOfJoinerys > 25)
                    {
                        price = price * 0.91;
                    }
                }
                // for delivery check
                if (delivery == "With delivery")
                {
                    price = (price * numberOfJoinerys) + 60;
                }
                else if (delivery == "Without delivery")
                {
                    price = price * numberOfJoinerys;
                }

                if (numberOfJoinerys > 99)
                {
                    price = price * 0.96;
                }
                
                Console.WriteLine($"{price:f2} BGN");

            }
        }
    }
}
