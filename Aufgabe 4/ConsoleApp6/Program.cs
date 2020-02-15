using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double Höhe = 1.5;
            double Breite = 2;
            double Tiefe = 1.75;
            double Volumen = Höhe * Breite * Tiefe;
            Console.WriteLine("Volumen = " + Volumen+ "m2");
            double AluminiumMasse = Volumen * 2700;
            double StahlMasse = Volumen * 7850;
            double HolzMasse = Volumen * 690;
            Console.WriteLine("Berechnete Masse für Aluminium  = " + AluminiumMasse + "kg");
            Console.WriteLine("Berechnete Masse für  Stahl  = " + StahlMasse + "kg");
            Console.WriteLine("Berechnete Masse für Holz  = " + HolzMasse + "kg");

        }
    }
}
