using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Properties
{
    class Rock : MapElement
    {
        public int x;
        public int y;
        public char rock = 'R';
        public Rock(int x, int y, char icon) : base(x, y, icon)
        {
            this.x = x;
            this.y = y;
            base.icon = this.rock;


        }
        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("rock");
        }
    }
}

