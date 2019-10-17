using System;

namespace zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 6

            Console.WriteLine("Podaj liczbe od 5 do 15");
            int wartosc = int.Parse(Console.ReadLine());
            if (wartosc > 15 || wartosc < 5)
            {
                Console.WriteLine("Podales zla liczbe. Program zostanie zakonczony.");
                System.Environment.Exit(0);
            }
            while(wartosc > -1)
            {
                Console.WriteLine("Wartosc wynosi {0}", wartosc);
                wartosc--;
            }
        }
    }
}
