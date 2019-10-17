using System;

namespace zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            do
            {
                Console.WriteLine("Podaj liczbę większą niż 5.");
                liczba = int.Parse(Console.ReadLine());

                if (liczba > 5)
                {
                    Console.WriteLine("Dobra liczba. Koniec programu.");
                    System.Environment.Exit(0);
                }

                Console.WriteLine("Zła liczba.");

            } while (liczba <= 5);
        }
    }
}