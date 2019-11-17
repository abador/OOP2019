using System;
using System.Collections.Generic;
using System.Text;

namespace Wejściówka
{
    class Rock : MapElement
    {
        public void PRock()
        {
            this.icon = 'R';
            Console.WriteLine(this.icon + " x=" + this.x + " y=" + this.y);

        }

    }
}
