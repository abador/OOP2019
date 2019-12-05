namespace Biblioteka
{
    interface IZarzadzanieKatalogiem
    {
        void WyszukajPoTytule(string title);
        void WyszukajPoId(int index);
        void WypiszWszystko();

    }
}