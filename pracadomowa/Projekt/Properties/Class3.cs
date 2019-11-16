using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Properties
{
    class MapElement : point
    {
        public char icon;
        public MapElement(int x, int y, char icon) : base(x,y) 
        {
            this.x = base.x;
            this.y = base.y;
            this.icon = icon;
        }
    }
}
