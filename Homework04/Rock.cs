using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    class Rock : MapElement
    {
        public char iconRock = 'R';
        public int x;
        public int y;
        public Rock(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
            base.icon = this.icon;
        }

        public void rockShow()
        {
            Console.WriteLine("Kamień: " + "(" + this.x + "," + this.y + ")");
        }
    }
}
