using System;
using System.Collections.Generic;
using System.Text;

namespace Wejściówka
{
    class Mapa : Imapa
    {
        public void generate()
        {
            int x, y;
            string a;

            
            Console.WriteLine("Podaj wymiary mapy x,y");
            do
            {
                
                Console.WriteLine("x:");
                string liczba = Console.ReadLine();
                x = int.Parse(liczba);
              
            } while (x < 0);
            do
            {

                Console.WriteLine("y:");
                string liczba = Console.ReadLine();
                y = int.Parse(liczba);

            } while (y < 0);
            Console.Write(" ");
            for (int i =0;i<x;i++)
            {
                Console.Write("--");
            }
            Console.WriteLine("");
            for (int i = 0; i < y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < x; j++)
                {
                    Console.Write("  ");
                }
                Console.Write("|");
                Console.WriteLine("");
            }
            Console.Write(" ");
            for (int i = 0; i < x; i++)
            {
                Console.Write("--");
            }
            




        }

        public void list()
        {
            
        }

        public void show()
        {
           
        }
        int[] tab;
        public Mapa(int dlugość)
        {
            this.tab = new int[dlugość];
        }
    }
}
