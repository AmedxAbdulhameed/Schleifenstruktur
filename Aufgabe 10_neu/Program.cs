using System;

namespace Aufgabe_10_neu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie die Höhe des Baumes an!!");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int FS = (n - 1) - i;
                int S = 1 + (i * 2);

                #region Freiestellen
                for (int q = 0; q < FS; q++)
                {
                    Console.Write(" ");
                }
                #endregion

                #region Sterne
                for (int q = 0; q < S; q++)
                {
                    Console.Write("*");
                }
                #endregion
                Console.WriteLine();

            }
        }
    }
}
