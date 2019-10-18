using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 4
            float netto;
            float podatek;
            float brutto;
            Console.Write("Podaj wartość netto: ");
            netto = float.Parse(Console.ReadLine());
            Console.Write("Podaj stosowaną stawkę podatkową (%): ");
            podatek = 1 + (float.Parse(Console.ReadLine())/100);
            brutto = netto * podatek;
            Console.WriteLine("Wartość brutto wynosi: {0}", brutto);
            Console.ReadKey();
        }
    }
}
