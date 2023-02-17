using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double longn = double.Parse(Console.ReadLine());
            double weight= double.Parse(Console.ReadLine());
            double height= double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volumeInLiters = ((longn * weight * height)/1000);
           
            double clearVolumeinLiters = (volumeInLiters - (volumeInLiters*percent/100));

            Console.WriteLine(clearVolumeinLiters);
        }
    }
}
