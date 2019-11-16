using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Properties
{
    class point
    {
        public int x;
        public int y;
        public point(int x,int y)
        {
            this.x = x;
            this.y = y;

        }
        public void Wypisz()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);

        }
    }
}
