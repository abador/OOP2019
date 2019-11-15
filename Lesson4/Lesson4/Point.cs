using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
    class Point
    {
        public int x;
        public int y;

        public void print()
        {
            Console.WriteLine("{0}|{1}", this.x, this.y);
        }
    }
    class MapElement : Point
    {
        public char icon;
    }
    class Grass : MapElement
    {
        public Grass(int x, int y)
        {
            this.icon = 'G';
            this.x = x;
            this.y = y;
        }
        public new void print()
        {
            Console.WriteLine("Trawa {0}|{1}", this.x, this.y);
        }
    }
    class Tree : MapElement
    {
        public Tree(int x, int y)
        {
            this.icon = 'T';
            this.x = x;
            this.y = y;

        }
        public new void print()
        {
            Console.WriteLine("Drzewo {0}|{1}", this.x, this.y);
        }
    }
    class Rock : MapElement
    {
        public Rock(int x, int y)
        {
            this.icon = 'R';
            this.x = x;
            this.y = y;
        }
        public new void print()
        {
            Console.WriteLine("Kamien {0}|{1}", this.x, this.y);
        }
    }
    class Bomb : MapElement
    {
        public int bombX, bombY;
        Random r = new Random();
        public Bomb()
        {
            this.bombX = r.Next(0, 256);
            this.bombY = r.Next(0, 256);
        }
        public bool checkCoords(int x, int y) => x == this.bombX && y == this.bombY ? true : false;
        public new void print()
        {
            Console.WriteLine("Bomba {0}|{1}", this.x, this.y);
        }
    }




}
