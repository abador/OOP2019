using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
        class Katalog : Pozycja, IZarządzanieKatalogiem
    {
        public string dzialTematyczny;
        public List<Pozycja> Listapozycji;
        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
            this.Listapozycji = new List<Pozycja>();
        }
        public void DodajPozycje(Pozycja pozycja)
        {
            this.Listapozycji.Add(pozycja);
        }

        public void WyszukajPoTytule(string Tytuł)
        {
            foreach (Pozycja x in this.Listapozycji)
            {
                if (x.tytuł == tytuł)
                    x.WypiszInfo();
            }
        }

        public void WyszukajPoId(int id)
        {
            foreach (Pozycja x in this.Listapozycji)
            {
                if (x.id == id)
                    x.WypiszInfo();
            }
        }

        public void WypiszWszystko()
        {
            foreach (Pozycja x in this.Listapozycji)
            {
                x.WypiszInfo();
            }
        }
        public override void WypiszInfo()
        {
            Console.WriteLine("Dział tematyczny: " + this.dzialTematyczny);
        }
    }
}
