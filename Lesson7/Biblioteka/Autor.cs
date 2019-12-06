using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Autor:Osoba
    {
        private string narodowosc;
        public Autor(string narodowosc,string imie,string nazwisko)
            :base(imie,nazwisko)
        {
            this.narodowosc = narodowosc;
        }
    }
}
