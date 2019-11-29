using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            var pracownicy = new List<Pracownik>();

            for (var i = 0; i < 20; i++)
                pracownicy.Add(new Pracownik($"test_{i}", $"test_{i}"));

            pracownicy[5].nazwisko = "Kowalski";
            pracownicy[6].nazwisko = "Mierzeja";
            pracownicy[7].nazwisko = "Bazydło";

            pracownicy[5].ZmienPodstawePensji(5000);

            pracownicy[1].ZmienKontrakt();
            pracownicy[1].ZmienPodstawePensji(5000);

            pracownicy[6].ZmienKontrakt();
            pracownicy[6].ZmienPodstawePensji(3000);

            pracownicy[11].ZmienKontrakt();
            pracownicy[11].ZmienPodstawePensji(2500);

            pracownicy[15].ZmienKontrakt();
            pracownicy[15].ZmienPodstawePensji(4700);

            foreach (Pracownik pracownik in SortujPoNazwisku(pracownicy))
                Console.WriteLine(pracownik);

            Console.WriteLine();

            var test = pracownicy[15].GlebokaKopia();

            test.imie = "Agata";
            test.ZmienPodstawePensji(100);

            Console.WriteLine($"{test}\n");

            //

            pracownicy.Add(test);

            test = pracownicy[11].GlebokaKopia();

            test.imie = "Janusz";
            test.ZmienPodstawePensji(150);

            Console.WriteLine($"{test}\n");

            pracownicy.Add(test);

            test = pracownicy[12].GlebokaKopia();

            test.imie = "Konrad";
            test.ZmienPodstawePensji(500);

            Console.WriteLine($"{test}\n");

            pracownicy.Add(test);

            //

            foreach (Pracownik pracownik in pracownicy.OrderBy(o => o.kontrakt.Pensja(o.kontrakt.typKontaktu == Kontrakt.typyKontaktu.etat ? 15 : 0)).ToList())
                Console.WriteLine($"{pracownik} - {(pracownik.kontrakt.typKontaktu == Kontrakt.typyKontaktu.etat ? 15 : 0)}");

            Console.ReadKey();
        }

        static List<Pracownik> SortujPoNazwisku(List<Pracownik> lista) => lista.OrderBy(o => o.nazwisko).ToList();
    }
}
