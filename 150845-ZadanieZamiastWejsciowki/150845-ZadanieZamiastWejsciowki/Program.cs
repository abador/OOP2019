using System;
using _150845_ZadanieZamiastWejsciowki.MapClass;
using _150845_ZadanieZamiastWejsciowki.MapElements;

namespace _150845_ZadanieZamiastWejsciowki
{
    class Program
    {
        static void Main()
        {
            Mapa nowa = new Mapa();

            nowa.Generate();
            nowa.List();
            nowa.Show();

            Console.ReadKey();
        }
    }
}
