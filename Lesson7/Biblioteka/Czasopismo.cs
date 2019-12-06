using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    
     public class Czasopismo:Pozycja
    {
        private int numer;

        public Czasopismo(int numer, string tytuł, string wydawnictwo, int id, int rokWydania)
            :base ( tytuł,  wydawnictwo,  id,  rokWydania)
        {
            this.numer = numer;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine("ID Czasopisma: " + base.id);
            Console.WriteLine("Tytuł: " + base.tytuł);
            Console.WriteLine("Wydawnicwo: " + base.wydawnictwo);
            Console.WriteLine("Rok wydania: " + base.rokWydania);
            Console.WriteLine("Numer czasopisma: " + this.numer);
        }
    }
}
