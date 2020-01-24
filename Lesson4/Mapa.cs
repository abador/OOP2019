using System;
using System.Collections.Generic;
using System.Text;

namespace Zaliczenie
{
    class Mapa:, IMapa
    {
        public int ShowMap(int wielkosc)
        {
            int[]rozmiar = new int[wielkosc];
        }
    }

    class Point
    {
        public int x;
        public int y;

        public void print()
        {
            Console.WriteLine("X" + x);
            Console.WriteLine("Y" + y);
        }
    }

    class MapElement:Point
    {
        public char icon;
        public void print()
        {
            Console.WriteLine("Icon" + icon);
        }
    }

    class Grass:MapElement
    {
        public int trawa;
        MapElement G = new MapElement();
        public void print()
        {
            Console.WriteLine("Współrzędne" + (trawa + x + y));
        }
    }

    class Tree:MapElement
    {
        public int drzewo;
        MapElement T = new MapElement();
        public void print()
        {
            Console.WriteLine("Współrzędne" + (drzewo + x + y));
        }

    }

    class Rock:MapElement
    {
        public int kamień;
        MapElement R = new MapElement();
        public void print()
        {
            Console.WriteLine("Współrzędne" + (kamień + x + y));
        }
    }    
}
