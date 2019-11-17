using System;
using System.Collections.Generic;
using System.Text;

namespace pracadomowa
{
    class Mapa : IMapa
    {
        public int x;
        public int y;
        void IMapa.generate()
        {
            int[,] mapka = new int[this.x, this.y];
        }

        void IMapa.list()
        {
            throw new NotImplementedException();
        }

        void IMapa.show()
        {
            throw new NotImplementedException();
        }
    }
    class Point
    {
        private int x;
        private int y;
        public void print()
        {
            Console.Write(this.x + this.y);
        }
    }
    class MapElement : Point
    {
       public char icon;
        public void print()
        {

            Console.Write(this.icon);
        }
    }
    class Grass : MapElement
    {
        public int x;
        public int y;
        public char trawa = 'G';
        public Grass(int x, int y, char icon)
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
    class Tree : MapElement
    {
        public int x = new int();
        public int y;
        public char drzewo = 'G';
        public Tree(int x, int y, char icon)
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
    class Rock : MapElement
    {
        public int x;
        public int y;
        public char rock = 'R';
        public Rock(int x, int y, char icon)
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
    class Enemy : MapElement // na początku dałem grass ale wyskakuje błąd ?? 
    {
        public int level;
        public string name;
        public int x;
        public int y;
        public Enemy(int level, string name, int x, int y)
        {
            this.name = name;
            this.level = level;
            this.x = x;
            this.y = y;
        }
        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(level);
        }


    }
}