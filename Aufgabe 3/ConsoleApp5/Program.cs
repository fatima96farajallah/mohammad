using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y , result;
            x=3.5;
            y=4.6;
            Console.WriteLine("x = 3,5  y=4,6");
            result = x + y;
            Console.WriteLine("Das Ergebnis der Addition x+y =" + result);
            result = x - y;
            Console.WriteLine("Das Ergebnis der Subtraktion x-y =" + result);
            result = x * y;
            Console.WriteLine("Das Ergebnis der Multiplikation x*y =" + result);
            result = x / y;
            Console.WriteLine("Das Ergebnis der Division x/y =" + result);

        }
    }
}
