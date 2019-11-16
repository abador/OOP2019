using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Properties
{
    class Tree : MapElement
    {
        public int x = new int();
        public int y;
        public char drzewo = 'G';
        public Tree(int x, int y, char icon) : base(x, y, icon)
        {
            this.x = x;
            this.y = y;
            base.icon = this.drzewo;


        }
        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("drzewo");
        }
    }
}
