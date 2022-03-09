using System;

namespace Noten_Berechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -2;
            for (int index = (-8 / a); index >= -7; index -= 3) ;
            {
                Console.WriteLine(index);
            }
        }
    }
}
