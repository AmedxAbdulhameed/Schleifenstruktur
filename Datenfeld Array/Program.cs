using System;

namespace Datenfeld_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 20; 
            int[] n = new int[k];
            for (int i = 0; i < k; i++)
            {
                  Console.WriteLine($"Geben Sie die {i} Note ein");
                n[i] = Convert.ToInt32(Console.ReadLine());
     
            }
            for(int p = 0 ; p < n.Length; p++ )
            {
                Console.WriteLine(n[p]);

            }

        }
    }
}
