using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    class Bomb : Point // dziedziczy współrzędne
    {
        Random random = new Random();
        public int level;
        public string name; 
        public int x, y;
        public int bx, by;
        public Bomb(int x, int y) : base(x, y)
        {
            this.x = base.x;
            this.y = base.y;
            this.bx = random.Next(0, 11);
            this.by = random.Next(0, 11);
        }
        public void showCoorbomb()
        {
            Console.WriteLine("Współrzędne bomby: " + "(" + this.bx + "," + this.by + ")");
        }
        public void isCorrect()
        {
            if((this.x == this.bx) && (this.y == this.by))
                {
                    Console.WriteLine("Trafiony!");
                }
            else
                {
                    Console.WriteLine("Pudło!");
                }
        }
    }
}
