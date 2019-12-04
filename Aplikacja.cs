using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2
{
    class Aplikacja:Koszyk
    {
        public char klawisz;
        public double suma;
        public int numer;
        public void WczytajKlawisz()
        {
            Console.WriteLine("Dzieńdobry!");
            Console.WriteLine("Co chcesz zrobić? Naciśnij odpowiedni klawisz.");
            Console.WriteLine("Legenda:");
            Console.WriteLine("P - dodaj produkt do koszyka");
            Console.WriteLine("K - skopiuj ostatnio wprowadzony produkt");
            Console.WriteLine("Z - pokaż zawartość koszyka");
            Console.WriteLine("S - pokaż sumę do zapłaty");
            Console.WriteLine("X - skasuj produkt z listy(musisz znacz wcześniej numer na liście)");
            Console.WriteLine("W - Wydrukuj paragon");
            Console.WriteLine("N - dodaj nowy koszyk");
            Console.WriteLine("E- zakończ działanie programu");
        }
        public void wykonajDzialanie()
        {

            klawisz = 'a';
            Produkt nowy = new Produkt();
            do
            {
                klawisz = Console.ReadKey().KeyChar;
                if (klawisz == 'P'||klawisz =='p')
                {
                    
                    Console.WriteLine();
                    Console.WriteLine("Podaj nazwe produktu");
                    nowy.nazwa = Console.ReadLine();
                    Console.WriteLine("Podaj jednostkę");
                    nowy.jednostka = Console.ReadLine();
                    Console.WriteLine("Podaj jednostkową cenę produktu");
                    nowy.cenaJednostkowa = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Podaj ilość");
                    nowy.ilosc = Convert.ToDouble(Console.ReadLine());
                    Zakupy.Add(new Produkt { cenaJednostkowa = nowy.cenaJednostkowa,jednostka=nowy.jednostka, ilosc = nowy.ilosc, nazwa = nowy.nazwa, razem=nowy.cenaJednostkowa*nowy.ilosc });
                    
                    
                }
                if(klawisz == 'Z'|| klawisz =='z')
                {
                    Console.WriteLine();
                    Console.WriteLine("|Nazwa produktu|Cena jednostkowa|Jednostka|Ilość|Suma zł|");
                    foreach(var i  in Zakupy )
                    {
                        Console.WriteLine("|" + i.nazwa + "|" + i.cenaJednostkowa + "|"+i.jednostka+"|" + i.ilosc+"|"+i.razem);
                    }
                }
                if(klawisz == 'k'|| klawisz == 'K')
                {
                    Console.WriteLine();
                    nowy.Kopiowanie();
                    {
                        Zakupy.Add(new Produkt { cenaJednostkowa = nowy.cenaJednostkowa,jednostka=nowy.jednostka, ilosc = nowy.ilosc, nazwa = nowy.nazwa,razem = nowy.cenaJednostkowa*nowy.ilosc});
                    }
                }
                if(klawisz=='S'||klawisz=='s')
                {
                    Console.WriteLine();
                    foreach (var i in Zakupy)
                    {
                        suma += i.razem;
                    }
                    Console.WriteLine("Suma do zapłaty to:" + suma);


                }
                if(klawisz=='X'||klawisz=='x')
                {
                    Console.WriteLine();
                    Console.WriteLine("Podaj indeks listy która ma zostać usunięta(Lista zaczyna się od 1):");
                    numer = int.Parse(Console.ReadLine());
                    Zakupy.RemoveAt(numer-1);
                }
                if(klawisz == 'N'|| klawisz =='n')
                {
                    Console.WriteLine();
                    Zakupy.Clear();
                }
                if (klawisz == 'W' || klawisz == 'w')
                {

                    DateTime dt = DateTime.Now;
                    string data = dt.ToString("ddMyyyyHHmmss");
                    Console.WriteLine();
                    try
                    {
                        using (StreamWriter streamW = new StreamWriter((data), true))
                        {
                            streamW.WriteLine("|Nazwa produktu|Cena jednostkowa|Jednostka|Ilość|Suma zł|");
                            foreach(var i in Zakupy)
                            {
                                streamW.WriteLine("|" + i.nazwa + "|" + i.cenaJednostkowa + "|" + i.jednostka + "|" + i.ilosc + "|" + i.razem);
                            }
                            suma = 0;
                            foreach (var i in Zakupy)
                            {
                                suma += i.razem;
                            }
                            streamW.WriteLine("Suma do zapłaty to:" + suma);
                        }
                        Zakupy.Clear();
                    }
                    catch(Exception)
                    {
                        
                        Console.WriteLine("Błąd");
                    }
                }
               
            } while(klawisz != 'E');

        }
    }
}
