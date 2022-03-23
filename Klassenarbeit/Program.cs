using System;

namespace Klassenarbeit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schrittgröße");

            double SG = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Maximalwert");
            double MW = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{"Widerstand",10}{"Strom",10}");





            if (MW > 150)
            {
                for (double R = 150; R <= MW; R += SG)
                {
                    Console.WriteLine($"{R,7:F2}Ohm{(230 / R),9:F2}A");
                }
            }
            else if (MW < 150)
            {
                for (double R = 150; R >= MW; R -= SG)
                {
                    Console.WriteLine($"{R,7:F2}Ohm{(230 / R),9:F2}A");
                }
            }


        }
    }
}
