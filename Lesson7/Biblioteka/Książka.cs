using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Książka:Pozycja
    {
        private int liczbaStron;
        public Autor autor;
        public Katalog dzialTematyczny;
        public Książka(int liczbaStron,Autor autor1,string tytuł,string wydawnictwo, int  id,int rokWydania,Katalog dzialTematyczny)
            :base(tytuł,wydawnictwo,id,rokWydania) 
        {
            this.liczbaStron = liczbaStron;
            this.autor = autor1;
            this.dzialTematyczny = dzialTematyczny;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine("ID Książki: " + base.id);
            Console.WriteLine("Dział Tematyczny: " + dzialTematyczny.dzialTematyczny);
            Console.WriteLine("Imie autora: " + autor.imie);
            Console.WriteLine("Nazwisko autora: " + autor.nazwisko);
            Console.WriteLine("Tytuł: " + base.tytuł);
            Console.WriteLine("Wydawnictwo: " + base.wydawnictwo);
            Console.WriteLine("Rok wydania książki: " + base.rokWydania);
            Console.WriteLine("Liczbastron: " + this.liczbaStron);
        }
    }
}
