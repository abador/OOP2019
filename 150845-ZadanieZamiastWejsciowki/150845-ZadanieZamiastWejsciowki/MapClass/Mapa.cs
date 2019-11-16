using _150845_ZadanieZamiastWejsciowki.Interfaces;
using _150845_ZadanieZamiastWejsciowki.MapElements;
using System;

namespace _150845_ZadanieZamiastWejsciowki.MapClass
{
    class Mapa : IMapa
    {

        MapElement[,] tab;

        int x;
        int y;

        string rozmiarX;
        string rozmiarY;

        public void Generate()
        {
            do
            {
                Console.WriteLine("Podaj rozmiar pierwszego wymiaru: ");
                rozmiarX = Console.ReadLine();

                Console.WriteLine("Podaj rozmiar drugiego wymiaru: ");
                rozmiarY = Console.ReadLine();


            } while ((!Int32.TryParse(rozmiarX, out this.x) || !Int32.TryParse(rozmiarY, out this.y)) || x < 0);

            string name;
            Console.WriteLine("Podaj imie uzytkownika: ");
            name = Console.ReadLine();
            
            
            
            tab = new MapElement[x, y];
            
            Random rnd = new Random();
            
            for (int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    int los = rnd.Next(1, 100);

                    if (los <= 50)
                        tab[i, j] = new Grass(i, j);
                    else if (los > 50 && los <= 75)
                        tab[i, j] = new Tree(i, j);
                    else if (los > 75 && los <= 100)
                        tab[i, j] = new Rock(i, j);

                    los = 0;
                    
                }
            }

            int licznik = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    int los = rnd.Next(1, 10);
                    if (tab[i, j].Icon == 'G' && los == 2)
                    {
                        tab[i, j] = new User(name, i, j);
                        licznik++;
                        goto Found;
                    }
                    los = 0;
                    
                    if((i == x - 1 && j == j - 1) && licznik == 0)
                    {
                        i = 0;
                        j = 0;
                    }
                    
                        
                }
                
            }
        Found:
            ;








        }

        public void List()
        {
            for(int i=0; i< x; i++)
            {
                for(int j=0; j<y; j++)
                {
                    tab[i, j].Print();
                }
            }

        }

        public void Show()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(tab[i, j].Icon);
                }
                Console.Write("\n");
                
            }
        }
    }
}
