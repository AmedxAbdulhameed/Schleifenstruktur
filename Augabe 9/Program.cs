using System;

namespace Augabe_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int anzahl = 0;
            double K=0;
            double p=0;
            double K_n=0;

            Console.WriteLine("Geben Sie Ihr Kapital ein");
            K= Convert.ToDouble(Console.ReadLine());
            K_n = K;
            Console.WriteLine("Geben Sie Ihr Zinssatz ein");
            p = Convert.ToDouble(Console.ReadLine());

            do
            {
                anzahl++;

                K_n = K_n + K_n * (p / 100);

            
            }
            while (K_n <= K*2);

           
            Console.WriteLine($"Es dauert {anzahl} Jahre");
           
        }
    }
}
