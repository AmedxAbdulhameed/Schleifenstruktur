using System;

namespace Firmenzugehörigkeit
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Seit wann arbeiten Sie bei uns?");
            int a = Convert.ToInt32(Console.ReadLine());

            while (a <= 0)
            {
                Console.WriteLine("Seit wann arbeiten Sie bei uns?");
                a = Convert.ToInt32(Console.ReadLine());
            }



            if (a == 20)
            {
                Console.WriteLine("Herzlichen Glückwunsch zum 20-jährigen Dienstjubiläum.");
            }
            else if (a == 40)
            {
                Console.WriteLine("Herzlichen Dank für 40 Jahre Energie, Einsatz und Teamgeist.");
            }



        }
    }
}
