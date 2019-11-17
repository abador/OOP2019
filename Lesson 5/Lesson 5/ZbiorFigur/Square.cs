using Interfaces;
using System;


namespace ZbiorFigur
{
    public class Square : Point, IZbiorFigur, ICloneable
    {
        
        
        private void LoadingSquare()
        {
            for (int i = 0; i < square.Length; i++)
                square[i] = new Point();
        }

        public Square()
        {

        }


        int dlugosc;
        string odc;
        public void Input()
        {
            
            do
            {
                Console.WriteLine("Podaj dlugosc odcinka kwadratu: ");
                odc = Console.ReadLine();

            } while (!Int32.TryParse(odc, out this.dlugosc));

            LoadingSquare();

            this.square[0].x = 1;
            this.square[0].y = 1;
            
            this.square[1].x = 1;
            this.square[1].y += dlugosc;
            
            this.square[2].x += dlugosc;
            this.square[2].y += dlugosc;
            
            this.square[3].x += dlugosc;
            this.square[3].y = 1;
            

        }
        
        public void LiczObwod()
        {
            Console.WriteLine($"Obwod tego kwadratu = {dlugosc * 4}");
        }

        public override string ToString()
        {

            return $"Wspolrzedne wierzcholkow kwadratu:\n" +
                $"A: x-{square[0].x}, y-{square[0].y}\n" +
                $"B: x-{square[1].x}, y-{square[1].y}\n" +
                $"C: x-{square[2].x}, y-{square[2].y}\n" +
                $"D: x-{square[3].x}, y-{square[3].y}\n";
        }

        public void Show()
        {
            
            Console.WriteLine($".{new string(' ', this.dlugosc)}.{new string('\n', this.dlugosc-1)}" +
                $".{new string(' ', this.dlugosc)}.");
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
        
        
        
        

    }
}
