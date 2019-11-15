using System;
using System.Collections.Generic;
using System.Text;

namespace zamiastwejsciowki
{
    class Mapa : IMapa
    {
        public MapElement[,] array;
        public void generate()
        {
            throw new NotImplementedException();
        }

        public void list()
        {
            throw new NotImplementedException();
        }

        public void show()
        {
            throw new NotImplementedException();
        }
    }
    class Point
    {
        public int x;
        public int y;
        public void print()
        {
            Console.WriteLine(this.x + "," + this.y);
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    class Icon : Attribute
    {
        private string v;

        public Icon(string v)
        {
            this.v = v;
        }
    }
    class MapElement : Point
    {
        static public char Znaczek;
        [Icon("")]
        public void Ikona (char Litera)
        { }

    }
    class Grass : MapElement
    {
        [Icon("G")]
        public void Litera()
        {
            Console.Write("G");
        }
        public void Print()
        {
            Console.WriteLine("Trawa, " + this.x + "," + this.y);
        }
    }
    class Tree : MapElement
    {
        public void Print()
        {
            Console.WriteLine("Drzewo, " + this.x + "," + this.y);
        }
    }
    class Rock : MapElement
    {
        public void Print()
        {
            Console.WriteLine("Kamien, " + this.x + "," + this.y);
        }
    }
    class Enemy : MapElement
    {
        public void Print()
        {
            Console.WriteLine("Przeciwnik, " + this.x + "," + this.y);
        }
    }
}
