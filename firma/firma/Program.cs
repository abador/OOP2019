using firma.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firma
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Pracownik daniel = new Pracownik("Daniel","zamojski", typKontraktu.staz, 2000);
            daniel.Pensja(100);
            
            daniel.Awans(typKontraktu.etat);

            Console.WriteLine(daniel.Pensja(50));
            List<Pracownik> pracownicy = new List<Pracownik>();
            pracownicy.Add(new Pracownik("Kacper", "woznicki", typKontraktu.staz,2100));
            pracownicy.Add(new Pracownik("Ewa", "jeden", typKontraktu.staz, 2100));
            pracownicy.Add(new Pracownik("Ania", "dwa", typKontraktu.etat, 3000));
            pracownicy.Add(new Pracownik("Ola", "trzy", typKontraktu.etat, 4000));
            pracownicy.Add(new Pracownik("Piotr", "cztery", typKontraktu.staz, 2000));
            pracownicy.Add(new Pracownik("Kamil", "piec", typKontraktu.staz, 2000));
            pracownicy.Add(new Pracownik("Mateusz", "szesc", typKontraktu.staz, 2000));
            pracownicy.Add(new Pracownik("Pawel", "siedem", typKontraktu.etat, 5100));
            pracownicy.Add(new Pracownik("Alina", "osiem", typKontraktu.etat, 3100));
            pracownicy.Add(new Pracownik("Tadeusz", "dziewiec", typKontraktu.etat, 6100));
            pracownicy.Sort();
            foreach(Pracownik aPracownik in pracownicy)
            {
                aPracownik.WypiszNazwisko();
            }
            Console.ReadKey();


        }
    }
}
