using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            String num = "test";
            Console.WriteLine("Bitte eine zahl eingeben und mit Enter bestätigen :");
            num = Console.ReadLine();
            int number = Convert.ToInt32(num);
            Console.WriteLine("Eingegebener Zahl nach Convert.ToInt32(Text) :");
            Console.WriteLine(number);
        }
    }
}
