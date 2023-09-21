using System;

namespace ifElseStatement;

class Program
{
    static void Main(string[] args)
    {
        // Karar Yapıları Ornek

        /*
         *  Soru 1) Kızınca tüküren hayvan hangisidir?
         *  a)Lama
         *  b)Deve
         *  Soru 2) Dünyaya en yakın olan gezegen hangisidir?
         *  a) Venüs
         *  b) Mars
         *  Soru 3) 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?
         *  a)7
         *  b)12
         */

        int numberOfCorrectAnswer = 0;

        Console.WriteLine("Soru 1) Kızınca tüküren hayvan hangisidir?");
        Console.WriteLine("a)Lama");
        Console.WriteLine("b)Deve");

        string answer = Console.ReadLine();

        if (answer == "a")
        {
            numberOfCorrectAnswer +=1 ;
        }

        Console.WriteLine("Soru 2) Dünyaya en yakın olan gezegen hangisidir?");
        Console.WriteLine("a)Venüs");
        Console.WriteLine("b)Mars");

        answer = Console.ReadLine();

        if (answer == "a")
        {
            numberOfCorrectAnswer += 1;
        }

        Console.WriteLine("Soru 3) 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
        Console.WriteLine("a)7");
        Console.WriteLine("b)12");

        answer= Console.ReadLine();

        if (answer == "b)")
        {
            numberOfCorrectAnswer += 1;
        }
         
        if (numberOfCorrectAnswer >= 2)
        {
            Console.WriteLine("Büyük ödülün sahibi oldunuz.");
        }
        else
        {
            Console.WriteLine("Kaybettiniz.");
        }
    }
}
