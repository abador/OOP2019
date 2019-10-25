using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
 
    int PodajCeneZaMetr(int liczbaLudnosci)
    {
        int cena = liczbaLudnosci * 0.01;
        return cena;
    }

    class Miasto
    {
        public int liczbaLudnosci;
        public string NazwaMiasta;
        PodajCeneZaMetr(public int liczbaLudnosci);


    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
