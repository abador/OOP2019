using System;
using System.Collections.Generic;
using System.Text;

namespace pracadomowa
{
    interface IMapa
    {
        public void generate(); //generowanie mapy na podstawie podanych wymiarów
        public void list(); //wyśœietlenie informacji na temat każdego elementu dodanego do mapy
        public void show(); // wyświetlenie mapy
    }
}
