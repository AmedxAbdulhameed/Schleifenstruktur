using System;

namespace Aufgabe_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoehe = 0;
            int l = 0;
            do
            {
                Console.Write("Geben Sie eine Höhe für den Baum ein( >3 ): ");
            }
            while (!int.TryParse(Console.ReadLine(), out hoehe) && hoehe > 2);
            l = hoehe;
            for (int i = 1; i < ((int)hoehe / 3.0) * 2; i += 2)
            {

                for (int j = i; j <= i + 4; j += 2)
                {
                    for (int m = l; m > 0; m--)
                        Console.Write(" ");
                    for (int k = 0; k < j; k++)
                        Console.Write("*");
                    l -= 1;
                    Console.WriteLine();
                }
                l += 2;
            }
            for (int i = 0; i < hoehe % 3; i++)
            {
                for (int j = 0; j < hoehe - 1; j++)
                    Console.Write(" ");
                Console.WriteLine("###");
            }
        }
    }
}
