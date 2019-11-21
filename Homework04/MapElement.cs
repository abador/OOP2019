using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    class MapElement : Point
    {
        public char icon;

        public MapElement(int x, int y) : base(x, y)
        {
            this.x = base.x;
            this.y = base.y;
        }
    }
}
