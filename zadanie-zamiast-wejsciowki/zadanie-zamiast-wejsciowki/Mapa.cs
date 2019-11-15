using System;


namespace zadanie_zamiast_wejsciowki
{
    class Mapa : Point, IMapa
    {
        private MapElement[,] tab;

        
        public void Generate(int lenghtX, int lenghtY)
        {
            this.x = lenghtX;
            this.y = lenghtY;
            
            this.tab = new MapElement[this.x, this.y];

            for(int i=0; i<this.x; i++)
            {
                for(int j=0; j<this.y; j++)
                {
                    Random rnd = new Random();
                    int los = rnd.Next(1, 4);

                    switch (los)
                    {
                        case 1:
                            tab[i, j] = new Grass();
                            break;
                        case 2:
                            tab[i, j] = new Tree();
                            break;
                        case 3:
                            tab[i, j] = new Rock();
                            break;

                    }

                }
            }
        }

        public void List()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
