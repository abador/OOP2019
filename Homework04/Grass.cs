using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    class Grass : MapElement
    {
        public char iconGrass = 'G';
        public int x;
        public int y;
        public Grass(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
            base.icon = this.icon;
        }

        public void grassShow()
        {
            Console.WriteLine("Trawa: " + "(" + this.x + "," + this.y + ")");
        }
    }
}
