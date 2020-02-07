using System;

namespace _2programy
{
    class Program
    {
        static void Main(string[] args)
        {
            // WYŚWIETL W KONSOLI PROSTOKĄT O SZEROKOŚCI X ORAZ WYSOKOŚCI v
            //X ORAZ Y PODAJE UŻYTKOWNIK, PROSTOKĄT ZBUDOWANY JEST Z "*"

            //Console.Write("Podaj szerokość:");
            //string xs = Console.ReadLine();

            //Console.Write("Podaj wysokośc:");
            //string yw = Console.ReadLine();

            //int x = int.Parse(xs);
            //int y = int.Parse(yw);

            //for (int i = 0; i < y; i++)
            //{
            //    for (int j = 0; j < x; j++)
            //    {
            //        Console.Write("*"); 
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();

            //zadanie 2 
            //Gra W ZGADYWANIE LICZBY WYLOSOWANEJ PRZEZ KOMPUTER
            //KOMPUTER LOSUJE LICZBĘ Z ZAKRESU 1-10
            //UŻYTKOWNIK pRÓBUJE ODGADNĄĆ WYLOSOWANĄ LICZBĘ
            // JEŻELI LICZBA JEST WIĘKSZA LUB MNIEJSZA OD WYLOSOWANEJ WYŚWIETL KOMUNIKAT
            //kIEDY UŻYTKOWNIK ODGAGNIE LICZBĘ, WYŚWIETL INFORMACJĘ O WYGRANEJ

            Random rnd = new Random();
            int los = (rnd.Next(1,11));      //przedział od 1 do 10włącznie 

            int mojaLiczba;
            int ileRazy = 0;

            Console.WriteLine("zgadnij liczbę od 1 do 10");
            do 
            {

               
                Console.Write("Podaj Liczbę:");
                mojaLiczba = int.Parse(Console.ReadLine());
                if (mojaLiczba > 10 || mojaLiczba < 1)
                {
                    Console.WriteLine("liczba z poza zakresu");
                }
                else
                    ileRazy++;
                    if (mojaLiczba > los)
                    {
                        Console.WriteLine("Podałeś za dużą liczbę");
                    }
                    else if (mojaLiczba < los)
                    {
                        Console.WriteLine("Podałeś za małą liczbę");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("sukces!!!! za {0} razem", ileRazy);
                    }
                
            } while (los != mojaLiczba);

            Console.ReadKey();
        }
    }
}
