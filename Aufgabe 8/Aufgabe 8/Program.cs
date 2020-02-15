using System;

namespace Aufgabe_8
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =1; i<=100;i++)
            {
                for(int j=1;j<=10;j++)
                {
                    int result;
                    String str = i + " * " + j + " = ";
                    result = i * j;
                    Console.WriteLine(str + result);
                }
            }
        }
    }
}
