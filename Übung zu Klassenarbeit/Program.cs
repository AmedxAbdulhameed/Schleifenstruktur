using System;

namespace Übung_zu_Klassenarbeit
{
    class Program
    {
        static void Main(string[] args)
        {
            string J,G,Z,KZ,B;

            J = "Jahr";
            G = "Guthaben";
            Z = "Zinsen";
            KZ = "K.Zinsen";
            B = "Bilanz";

            Console.WriteLine("Geben Sie Ihr Kapital ein");

            double K = Convert.ToInt32(Console.ReadLine());
            double p = Convert.ToInt32(Console.ReadLine());
            double n = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("{0,3} {1,10} {2,8} {3,10} {4,8}",J,G,Z,KZ,B);
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("{0,13}{1,2}{2,22}", K,n,p);
            



        }
    }
}
