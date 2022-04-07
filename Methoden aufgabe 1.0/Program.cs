using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
       

        int anzahl = 0;
        Console.WriteLine("Bite geben Sie einen Text ein");
        string ausgabe = Convert.ToString(Console.ReadLine());

        if (ausgabe == "exit")
        {

            Environment.Exit(0);

        }

        int ausgabe2 = 0;

        bool flag;
        do
        {
            flag = false;
            Console.WriteLine("Bitte Anzahl geben");
            try
            {
                ausgabe2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Falsche Eingabe");
                flag = true;
            }

        } while (flag);

  

        anzahl = ausgabeTextMalX(ausgabe, ausgabe2);

        Console.Write("\nAnzahlder Buchstaben: {0}", anzahl);
        Console.ReadKey();

    }



    static int  ausgabeTextMalX (string ausgabe,int durchlauf)
    {
        Console.Clear();
        for (int a=0;a < durchlauf;a++)
        {
            Console.WriteLine(ausgabe);
        }
   







        return ausgabe.Length*durchlauf;
















        //Von Amed und Dean erledigt

    }







}
