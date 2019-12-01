using Enumerations;
using Interfaces;
using Makulatura;
using System;
using System.Collections.Generic;

namespace Biblioteka
{
    public class Katalog : Pozycja, IZarzadzanieKatalogiem
    {
        

        public List<Pozycja> listaPozycji;
        
        public Katalog(DzialTematyczny dzialTematyczny)
        {
            base.DzialTematyczny = dzialTematyczny;
            this.listaPozycji = new List<Pozycja>();

        }

        public override void WypiszInfo()
        {
            foreach (Pozycja i in this.listaPozycji)
            {
                i.WypiszInfo();
            }
        }

        public void WyszukajPoID(int id)
        {
            foreach (Pozycja i in this.listaPozycji)
            {
                if (i.ID == id)
                    i.WypiszInfo();
            }
        }

        public void WyszukajPoTytule(string tytul)
        {
            foreach (Pozycja i in this.listaPozycji)
            {
                if (i.Tytul == tytul)
                    i.WypiszInfo();
            }
        }

        public void DodajPozycje(Pozycja pozycja)
        {
            this.listaPozycji.Add(pozycja);
        }
        

    }
}
