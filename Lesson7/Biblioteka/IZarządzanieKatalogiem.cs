using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    interface IZarządzanieKatalogiem
    {
        void WyszukajPoTytule(string tytuł);
        void WyszukajPoId(int id);
        void WypiszWszystko();
    }
}
