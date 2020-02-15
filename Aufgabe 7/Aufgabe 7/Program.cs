using System;

namespace Aufgabe_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte eine Ganzzahl , deren Teilbarkeit getestet werden soll , eingeben und mit Enter bestätigen :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte einen ganzzahligen Teiler eingeben und mit Enter bestätigen :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 % num2;
            if(result==0)
            {
                Console.WriteLine( num1 + "  Ist ohne Rest teilbar durch  " + num2);
            } else
            {
                Console.WriteLine(num1+ "  Ist ohne Rest nicht teilbar durch  "+ num2);
            }
            
        }
    }
}
