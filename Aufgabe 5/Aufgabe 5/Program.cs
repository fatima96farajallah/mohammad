using System;

namespace Aufgabe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine("Bitte einen Radius eingeben und mit Enter bestätigen :");
            double denRadius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("für den Radius = " + denRadius);
            double Durchmesser = denRadius * 2;
            Console.WriteLine("Durchmesser = " + Durchmesser);
            double Umfang = 2 * denRadius * pi;
            Console.WriteLine("Umfang = " + Umfang);
            double Fläche = (denRadius* denRadius) * pi;
            Console.WriteLine("Fläche = " + Fläche);

        }
    }
}
