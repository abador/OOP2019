using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    class Tree : MapElement
    {
        public char iconRock = 'T';
        public int x;
        public int y;
        public Tree(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
            base.icon = this.icon;
        }

        public void treeshow()
        {
            Console.WriteLine("Drzewo: " + "(" + this.x + "," + this.y + ")");
        }
    }
}
