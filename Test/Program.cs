using System;


namespace Finanztabelle
    {
        class Program
        {
            static void Main(string[] args)
            {

                double k = Convert.ToDouble(Console.ReadLine());
                double p = Convert.ToDouble(Console.ReadLine());
                double n = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine($"{"Jahr",4} {"Guthaben",10} {"Zinsen",8} {"K.Zinsen",10} {"Bilanz",8}");

                for (int i = 1; i <= n; i++)
                {

                    Console.WriteLine($"{i,4} {k,10:F2} {"Zinsen",8} {"K.Zinsen",10} {"Bilanz",8}");
                }
            }
        }
    }

  