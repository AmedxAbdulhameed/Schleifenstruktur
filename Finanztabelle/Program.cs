using System;

namespace Finanztabelle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bitte geben Sie ihr Kapital ein");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie ihren Zinssatz ein");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie ihre Anlagedauer ein");
            double n = Convert.ToDouble(Console.ReadLine());


            double kn = k, z = 0, zk = 0, b = 0;

            Console.WriteLine($"{"Jahr",4} {"Guthaben",10} {"Zinsen",8} {"K.Zinsen",10} {"Bilanz",8}");
            Console.WriteLine("----------------------------------------------------------");
            for (int i = 1; i <= n; i++)
            {
                z = kn * (p / 100);
                zk = zk + z;
                b = kn + z;

                if (i == n)
                    Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"{i,4}|{kn,10:F2}E|{z,8}E|{zk,10}E|{b,8}E");
            }
        }
    }
}
