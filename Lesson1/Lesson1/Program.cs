using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Polecenia 1-7

            string bob = "Hello Bob.";
            string eva = "Hello Eva.";
            string userName;
            Console.WriteLine("Podaj swoje imie, a nastepnie wcisnij ENTER");
            userName = "Hello " + Console.ReadLine() + ".";
            Console.WriteLine("Hello world.");
            Console.Write(bob + " " + eva + " " + userName);
            Console.WriteLine(Console.ReadLine());

            #endregion
            #region Polecenie 9

            int liczba1 = 5;
            int liczba2 = 10;
            int wynik;
            Console.WriteLine(liczba1 + liczba2);
            Console.WriteLine(liczba2 / liczba1);
            Console.WriteLine(liczba1 * liczba2);
            Console.WriteLine(liczba1 - liczba2);
            Console.WriteLine(liczba1 + " + " + liczba2 + " = " + liczba1 + liczba2); //skąd taki wynik?
            Console.WriteLine(liczba1 + " + " + liczba2 + " = " + (liczba1 + liczba2)); //dlaczego tutaj działa?

            #endregion
            #region Polecenia 10 -12

            bool prawda = true;
            int zmienna = 5;
            Console.WriteLine(prawda);
            Console.WriteLine(!prawda);
            Console.WriteLine(true & false);
            Console.WriteLine(true | false);
            Console.WriteLine(5 < 2);
            Console.WriteLine(5 > 2);
            Console.WriteLine(5 == 2);
            Console.WriteLine(zmienna = 2); //co tu się stanie i dlaczego? różnica między = a ==
            Console.WriteLine(5 != 2);

            #endregion
            #region Polecenia 15 - 18

            int inkrementacja = 5;
            inkrementacja++;
            inkrementacja++;
            inkrementacja++;
            inkrementacja++;
            inkrementacja++;
            inkrementacja++;

            #endregion 
            Console.ReadLine();
        }
    }
}