using System;
using System.Collections.Generic;
using System.IO;

namespace kasa
{
    public interface ICloneable
    {
        void Copy();    
    }
    public class Produkt: ICloneable
    {
        public string nazwa;
        public double cenaJednostkowa;
        public double ilosc;

        public Produkt(string nazwa, double cenaJednostkowa, double ilosc)
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;
        }

        public void Copy() { }

    }

    public class Koszyk
    {
        public List<Produkt> zakupy = new List<Produkt>();
    }

    public class Aplikacja : Koszyk
    {
        public char klawisz;
        public int wybor;
        public double suma;

        public void WczytajKlawisz()
        {
            Console.WriteLine("Dzień dobry." + Environment.NewLine + "Wybierz zadanie. Wybierz odpowiedni klawisz." + Environment.NewLine + "Legenda:" + Environment.NewLine);
            Console.WriteLine("P - dodaj produkt do koszyka." + Environment.NewLine + "K - skopiuj ostatnio wprowadzony produkt." + Environment.NewLine + "Z - pokaż zawartość koszyka" + Environment.NewLine + "S - pokaż sumę do zapłaty"
                 + Environment.NewLine + "X - skasuj produkt z listy (musisz wcześniej znać numer na liście)" + Environment.NewLine + "W - wydrukuj paragon" + Environment.NewLine + "N - dodaj nowy koszyk" + Environment.NewLine +
                 "E - zakończ działanie programu" + Environment.NewLine);

        }

        public void WykonajDzialanie()
        {
            Produkt chleb = new Produkt("chleb", 3.00, 1);
            Produkt bułka = new Produkt("bułka", 0.75, 1);
            Produkt rogal = new Produkt("rogal", 1.50, 1);
            Console.WriteLine(Environment.NewLine + "Podaj klawisz:");
                klawisz = Console.ReadKey().KeyChar;
                if (klawisz == 'p' || klawisz == 'P')
                {
                    /* nazwa produktu, cena jednostkowa, ilość */
                    Console.WriteLine(Environment.NewLine + "Który produkt chcesz dodać do koszyka?");
                    Console.WriteLine("1. chleb" + Environment.NewLine + "2. bułka" + Environment.NewLine + "3. rogal" + Environment.NewLine +
                        "Wprowadź wartość, którą jesteś zainteresowany.");
                wybor = Console.ReadKey().KeyChar;

                if (wybor == 1) zakupy.Add(chleb);
                if (wybor == 2) zakupy.Add(bułka);
                if (wybor == 3) zakupy.Add(rogal);

                }

                if (klawisz == 'k' || klawisz == 'K')
                {
                    Console.WriteLine(Environment.NewLine + "Który produkt chcesz skopiować do koszyka?" + Environment.NewLine);
                    Console.WriteLine("1. chleb" + Environment.NewLine + "2. bułka" + Environment.NewLine + "3. rogal" + Environment.NewLine +
                        "Wprowadź wartość, którą jesteś zainteresowany.");
                    wybor = Console.ReadKey().KeyChar;

                    if (wybor == 1) chleb.Copy();
                    if (wybor == 2) bułka.Copy();
                    if (wybor == 3) rogal.Copy();

                    Console.ReadKey();
                }

                if (klawisz == 'z' || klawisz == 'Z')
                {
                    Console.WriteLine(Environment.NewLine + "Wyświetlam listę zakupów:" + Environment.NewLine);
                    foreach (Produkt aProdukt in zakupy)
                    {
                        Console.WriteLine(aProdukt);
                    }

                    Console.ReadKey();
                }

                if (klawisz == 's' || klawisz == 'S')
                {
                    Console.WriteLine(Environment.NewLine + "Wyświetlam sumę za zakupy:" + Environment.NewLine);
                    foreach (Produkt d in zakupy)
                    {
                        suma = d.ilosc * d.cenaJednostkowa;
                        Console.WriteLine("Suma:" + suma);
                    }

                    Console.ReadKey();
                }

                if (klawisz == 'x' || klawisz == 'X')
                {
                    Console.WriteLine(Environment.NewLine + "Wybierz produkt do skasowania z listy");
                    wybor = int.Parse(Console.ReadLine());
                    zakupy.RemoveAt(wybor - 1);

                    Console.ReadKey();
                }

                if (klawisz == 'w' || klawisz == 'W')
                {
                    DateTime aktualna_data = DateTime.Now;
                    string data = aktualna_data.ToString("ddMMyyyyHHmmSS.txt");
                    using (StreamWriter sw = File.AppendText(data))
                    {
                        foreach (Produkt zakupy in zakupy)
                        {
                            Console.WriteLine(Environment.NewLine + "Nazwa produktu:" + zakupy.nazwa + "Cena:" + zakupy.cenaJednostkowa + "Ilość:" + zakupy.ilosc);
                        }
                    }

                    Console.ReadKey();
                }

                if (klawisz == 'n' || klawisz == 'N')
                {
                    Console.WriteLine(Environment.NewLine + "Usuwam poprzednią listę." + Environment.NewLine + "Tworzę nową listę.");
                    zakupy.Clear();

                    Console.ReadKey();
                }
                if (klawisz == 'e' || klawisz == 'E')
                { 
                    Console.WriteLine("Program zostanie zakończony.");
                    Environment.Exit(1);
                }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Aplikacja kasa = new Aplikacja();
            kasa.WczytajKlawisz();
            kasa.WykonajDzialanie();
        }
    }
}

