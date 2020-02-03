using System;

namespace Lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            //operatory arytmetyczne +dodawanie -odejmowanie /dzielenie *mnozenie %wylicza reszte z dzielenia

            int a = 4;
            int b = 10;
            int c;
            //a + b = c;
            // a -= b;     //skrócony zapis dla działań arytmetycznych
            // a += 1;         //zwiększ o jeden tak zwana ikrementacja mozna zapisac jako a++
            // a++;         //ikrementacja zwiększanie o jeden
            // a--;         //dekrementacja zmniejszanie o 1
            //c = b % a;

            // operatory logiczne zwracają true or folse > < >= <= (dla równych wartości używać == dwa razy równa się) (!= czy zmienne się róznią)

            //bool d = 1 != 2;
            //bool d = 1 >= 2;
            //bool d = 1 == 2;

            // int v = 2 + 2 * 2;
            // int v = (2 + 2) * 2;

            //operator jednoargumentowy !oznacza ze cos jest odwrócone !2==2 to fałsz
            //bool d = !(2==2)

            //bool x = 1 == 1 && 1 !=1;              //&& koniunkcja logiczna (oznacza AND albo i)
            //bool z = 1 == 1 || 2 != 2 || false;              // || alternatywa (oznacza OR albo LUB)

            //bool x = true || true && false;         // kolejność wykonywania najpierw True i False = False1, potem True lub False1 = true
            //bool x = (true || true) && false;        // kolejność wykonywania najpierw True lub True w nawiasie, potem True i false = false

            //Metody matematyczne (potęgowanie, pierwiastki, wartość bezwzględna)
            //Math.Pow(2, 3);
            //Math.Sqrt(9);
            //Math.Abs(-5);


            //Console.WriteLine(z);
            Console.WriteLine(Math.Abs(-5));
            Console.ReadKey();
        }
    }
}
