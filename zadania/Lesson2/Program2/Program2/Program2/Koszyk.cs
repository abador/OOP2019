using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Koszyk : Produkt
    {
        
       List<Produkt> produkty;
        List<Produkt> Produkty
        {
            get
            {
                if(produkty.Count == 0)
                {
                    Load
                }
            }
        }
       static Koszyk()
        {
            Produkty = new List<Produkt>();
        }
    }
}
