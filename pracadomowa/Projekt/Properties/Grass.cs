using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Properties
{
    class Grass:MapElement
    {
        public int x;
        public int y;
        public char trawa='G';
        public Grass(int x, int y,char icon) : base(x, y, icon)
        {
            this.x = x;
            this.y = y;
            base.icon = this.trawa;


        }
        public void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("trawa");
        }

        
        


    }
}
