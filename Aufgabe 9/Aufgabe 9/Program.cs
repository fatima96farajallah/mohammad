using System;
using System.Linq;
namespace Aufgabe_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] data = { 17, 17, 17, 18, 21, 23, 16, 13, 11, 13, 13, 13, 15 };
            foreach(int i in data)
            {
                sum += i;
                Array.Sort(data);
            }
            double Durchschnittstemperatur = sum / data.Length;
            Console.WriteLine(" Durchschnittstemperatur = " + Durchschnittstemperatur);
            Console.WriteLine(" Maximale Temperatur " + data.Max());
            Console.WriteLine(" Minimale  Temperatur " + data.Min());
            Console.WriteLine(" +-------------+-------------+");
            Console.WriteLine(" |  Datensatz  |  Temperatur |");
            Console.WriteLine(" +-------------+-------------+");
           for (int i =0; i<data.Length;i++)
            {
                 Console.WriteLine( " |"+i +   "|   "+ data[i]+"        |");
                 Console.WriteLine( " +-------------+-------------+");

            }



        }
    }
}
