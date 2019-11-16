using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Properties
{
    interface IMapa
    {
         void generate(); //generowanie mapy na podstawie podanych wymiarów

         void list(); //wyśœietlenie informacji na temat każdego elementu dodanego do mapy
         void show(); // wyświetlenie 
    }
}
