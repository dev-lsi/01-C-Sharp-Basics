using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {


            string myText = Console.ReadLine();
            int textLength = myText.Length;
            char letter;


            for(int i = 0; i < textLength; i++)
            {
                letter = myText[i];
                Console.WriteLine($"{letter}");
            }

        }
    }
}
