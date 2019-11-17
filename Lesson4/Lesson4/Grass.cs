using System;
using System.Collections.Generic;
using System.Text;

namespace Wejściówka
{
    class Grass: MapElement
    {
        public void PGrass()
        {
            this.icon = 'G';
            Console.WriteLine(this.icon + " x=" + this.x + " y=" + this.y);

        }
    }
}
