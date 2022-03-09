using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konsolen-Rechner in C#\r");
            Console.WriteLine("-----------------------\n");

       
            Console.WriteLine("Tippen Sie eine Zahl ein und drücken Sie Enter");
            string eingabe1;
            eingabe1 = Console.ReadLine();


            Console.WriteLine("Tippen Sie noch eine Zahl ein und drücken Sie Enter");
            string eingabe2;
            eingabe2 = Console.ReadLine();



            Console.WriteLine("Wählen Sie eine der folgenden Optionen aus:");
            Console.WriteLine("\ta - Addition");
            Console.WriteLine("\ts - Subtraktion");
            Console.WriteLine("\tm - Multiplikation");
            Console.WriteLine("\td - Dividieren");
            Console.WriteLine("Deine Option?");




            Console.Write("Drücken Sie eine Taste um den Rechner zu schließen");
            Console.ReadKey();
        }
    }
}
