using System;

namespace Datenfeld_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 20; 
            int[] n = new int[k];
            double summe = 0;

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"Geben Sie die {i} Note ein");
                n[i] = Convert.ToInt32(Console.ReadLine());


            }

            Console.Clear();
            
            for(int p = 0 ; p < n.Length; p++ )
            {
                summe = summe + n[p];
                Console.WriteLine(n[p]      );




            }
            summe = summe / k;
            Console.WriteLine($"Der Durschnit Betregt {summe:F2}/0");

        }
    }
}
