using System;


namespace Lekcja2.Classes
{
    class Koszyk
    {
        private Produkt[] listaTowarow = new Produkt[50];
        private int ilosc;
        private int cena;

        public void Add(Produkt towar)
        {
            listaTowarow[ilosc++] = towar;
            cena += towar.Cena;
        }

        public void CenaKoszyka()
        {
            Console.WriteLine($"Suma koszyka wynosi {cena} zl");
        }

        public void ShowKoszyk()
        {
            for(int i=0; i<ilosc; i++)
            {
                Console.WriteLine($"{i + 1} {listaTowarow[i].Nazwa} - {listaTowarow[i].Cena} zl");
            }
        }

        


    }
}
