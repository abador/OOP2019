using System;
using System.Collections.Generic;
using System.Text;

namespace Wejściówka
{
    class Tree: MapElement
    {
        public void PTree()
        {
            this.icon = 'T';
            Console.WriteLine(this.icon + " x=" + this.x + " y=" + this.y);

        }
    }
}
