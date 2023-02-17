using System;

namespace _01._Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int kozunaci = int.Parse(Console.ReadLine());
            int koriEggs = int.Parse(Console.ReadLine());
            int kgKurabii = int.Parse(Console.ReadLine());

            // •Козунак  – 3.20 лв.
            //•	Яйца –  4.35 лв.за кора с 12 яйца
            //•	Курабии – 5.40 лв.за килограм
            //•	Боя за яйца - 0.15 лв.за яйце

            double pkozunaci = kozunaci * 3.2;
            double pkoriEggs = koriEggs * 4.35;
            double pkgKurabii= kgKurabii*5.40;
            double eggPaint = koriEggs * 12 * 0.15;

            double spendings = pkozunaci + pkoriEggs + pkgKurabii + eggPaint;
            Console.WriteLine($"{spendings:f2}");

        }
    }
}
