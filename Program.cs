using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wejsciowka
{
    class Szkola
    {
        public int liczbaUczniow;
        public int liczbaLawek;

        public int SprawdzLawki()
        {
            if (liczbaUczniow / 2 > liczbaLawek)
            {
                Console.WriteLine("Liczba ławek jest niewystarczająca dla wszystkich uczniów.");
            }
            else
                Console.WriteLine("Liczba ławek jest wystarczająca dla wszystkich uczniów.");
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Szkola liceum = new Szkola();
            liceum.liczbaUczniow = 25;
            liceum.liczbaLawek = 10;
            Console.WriteLine("Szkola: liceum");
            liceum.SprawdzLawki();

            Szkola podstawowa = new Szkola();
            podstawowa.liczbaUczniow = 13;
            podstawowa.liczbaLawek = 10;
            Console.WriteLine(Environment.NewLine + "Szkola: podstawowa");
            podstawowa.SprawdzLawki();

            Console.ReadKey();
        }
    }
}
