using System;

namespace Übung_zu_Klassenarbeit
{
    class Program
    {
        static void Main(string[] args)
        {
            double K = 0, z = 0, kz = 0, kn = 0, b=0;
            string J,G,Z,KZ,B;

            J = "Jahr";
            G = "Guthaben";
            Z = "Zinsen";
            KZ = "K.Zinsen";
            B = "Bilanz";

            Console.WriteLine("Geben Sie Ihr Kapital ein");
            K = Convert.ToInt32(Console.ReadLine());
            kn = K;
            Console.WriteLine("Geben Sie Zinssatz in prozent ein");
            double p = Convert.ToInt32(Console.ReadLine());
           
            
            Console.WriteLine("Geben Sie Ihre Jahre ein");
            double n = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("{0,3}    {1,10}    {2,8}    {3,10}    {4,8}", J,G,Z,KZ,B);
            Console.WriteLine("---------------------------------------------------------");



            for (int i = 1; i <= n; i++)
            {
                z = kn * (p/100);
                kz = kz + z;
                b = kn + z;
                

                kn = kn + z;
                if (i==n) 
                {
                    Console.WriteLine("---------------------------------------------------------");
                }

                Console.WriteLine($"{i,3} | {kn,10:F2}$ | {z,8:F2}$ | {kz,10:F2}$ | {b,8:F2}$");
                kn = kn + z;

            }   
        }
    }
}
