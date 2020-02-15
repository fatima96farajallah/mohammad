using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            String num = "test";
            Console.WriteLine("Bitte eine zahl eingeben und mit Enter bestätigen :");
            num = Console.ReadLine();
            Console.WriteLine("Eingegebener Zahl ( Als Text ) :");
            Console.WriteLine(num);

        }
    }
}
