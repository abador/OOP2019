using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Properties
{
    class Enemy : point
    {
        public int level;
        public string name;
        public int x;
        public int y;

        public Enemy(int level,string name,int x ,int y) : base(x,y)
        {
            this.level = level;
            this.name = name;
            this.x = x;
            this.y = y;


        }

    }
}
