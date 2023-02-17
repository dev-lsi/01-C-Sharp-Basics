using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoins = double.Parse(Console.ReadLine());
            double iuans = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());

            //1 биткойн = 1168 лева.
            //1 китайски юан = 0.15 долара.
            //1 долар = 1.76 лева.
            //1 евро = 1.95 лева.

            double leva = bitcoins * 1168;
            double dolars = iuans * 0.15;
            leva = leva + dolars * 1.76;
            double euro = leva / 1.95;
            euro = euro - euro * comision/100 ;
            
            Console.WriteLine($"{euro:f2}");
        }
    }
}
