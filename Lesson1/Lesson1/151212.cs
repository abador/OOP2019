using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 2, 3, 6, 8, 11 };
            for (int liczba = 0; liczba < tablica.Length; liczba++)
            {
                Console.Write(tablica[liczba]+ ",");
            }
            for (int liczba = 0; liczba < tablica.Length; liczba++)
            {
                Console.WriteLine(tablica[liczba]);
            }
            for (int liczba = tablica.Length-1; liczba >=0; liczba--)
            {
                Console.Write(tablica[liczba] + " ");
            }
            string zmienna;
            Console.WriteLine("");
            Console.WriteLine("Podaj 3 liczby całkowite");
            zmienna = (Console.ReadLine());
            int zmienna1 = int.Parse(zmienna);
            zmienna = Console.ReadLine();
            int zmienna2 = int.Parse(zmienna);
            zmienna = Console.ReadLine();
            int zmienna3 = int.Parse(zmienna);
            int wynik = 0;
            if (zmienna1 == zmienna2 & zmienna1 == zmienna3)
                Console.WriteLine("Można stworzyć taki trójkąt");
            else

            {
                if (zmienna1 >= zmienna2 & zmienna1 >= zmienna3)
                {
                    wynik = zmienna1;
                    if (wynik <= zmienna2 + zmienna3)
                    {
                        Console.WriteLine("Można stworzyć taki trójkąt");

                    }
                    else
                        Console.WriteLine("Nie można stworzyć takiego trójkąta");
                }
                if (zmienna2 >= zmienna1 & zmienna2 >= zmienna3)
                {
                    wynik = zmienna2;
                    if (wynik <= zmienna1 + zmienna3)
                    {
                        Console.WriteLine("Można stworzyć taki trójkąt");

                    }
                    else
                        Console.WriteLine("Nie można stworzyć takiego trójkąta");
                }
                if (zmienna3 >= zmienna2 & zmienna3 >= zmienna1)
                {
                    wynik = zmienna3;
                    if (wynik <= zmienna2 + zmienna3)
                    {
                        Console.WriteLine("Można stworzyć taki trójkąt");

                    }
                    else
                        Console.WriteLine("Nie można stworzyć takiego trójkąta");
                }
            }
            int zmienna4;
            Console.WriteLine("Podaj liczbe z przedziału 5-15");
            zmienna = Console.ReadLine();
            zmienna4 = int.Parse(zmienna);
            if (zmienna4 >= 5 & zmienna4 <= 15)
            {
                Console.WriteLine("Podano właściwą liczbę");
            }
            else
                Console.WriteLine("Podano niewłaściwą liczbę");
           while(zmienna4>-1)
            {
                Console.WriteLine(zmienna4);
                zmienna4 -= 1;

            }
            int zmienna5 = 4;
            do
            {
                Console.WriteLine("Podaj liczbę większą od 4 mniejszą od 22 oraz różną od 11");
                zmienna = Console.ReadLine();
                zmienna5 = int.Parse(zmienna);
            } while (!(zmienna5 > 4 & zmienna5 < 22 & zmienna5 != 11));
            Console.WriteLine("Podano właściwą liczbę");
            Console.ReadKey();
        }
    }
}
