using System;

namespace Aufgabe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte das Alter von Student 1 eingeben und mit Enter bestätigen : ");
            int Age_of_student_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte das Alter von Student 2 eingeben und mit Enter bestätigen : ");
            int Age_of_student_2 = Convert.ToInt32(Console.ReadLine());
            if (Age_of_student_1 > Age_of_student_2)
            {
                Console.WriteLine("Stundet 1 ist jünger als Student 2");
            } else if(Age_of_student_2 > Age_of_student_1)
            {
                Console.WriteLine("Stundet 2 ist jünger als Student 1");
            } else
            {
                Console.WriteLine("Die beide Studenten sind im gleichen Alter ");
            }


        }
    }
}
