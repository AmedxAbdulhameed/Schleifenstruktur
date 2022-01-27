using System;

namespace Aufgabe_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int anzahl = 0;




            int e;




            do




            {




                anzahl++;




                Console.WriteLine("Geben Sie Ihren PIN ein");




                e = Convert.ToInt32(Console.ReadLine());




            } while (e != 1234);




            Console.WriteLine(anzahl);
        }
    }
}
