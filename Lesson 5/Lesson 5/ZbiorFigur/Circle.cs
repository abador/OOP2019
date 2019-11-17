using Interfaces;
using System;

namespace ZbiorFigur
{
    public class Circle : Point, IZbiorFigur, ICloneable
    {
        

        public object Clone()
        {
            return MemberwiseClone();
        }

        private void LoadingCircle()
        {
            for (int i = 0; i < circle.Length; i++)
                circle[i] = new Point();
        }

        int dlugosc;
        string odc;
        public void Input()
        {
            do
            {
                Console.WriteLine("Podaj dlugosc promienia: ");
                odc = Console.ReadLine();

            } while (!Int32.TryParse(odc, out this.dlugosc));

            LoadingCircle();

            this.circle[0].x = 0;
            this.circle[0].y = 0;
            this.circle[1].x += dlugosc;
            this.circle[1].y += dlugosc;


        }

        public void LiczObwod()
        {
            Console.WriteLine($"Obwod kola = {2 * dlugosc}pi");
        }

        public override string ToString()
        {
            return $"Wspolrzedne promienia i srodka okregu:\n" +
                $"s: x-{circle[0].x}, y-{circle[0].y}\n" +
                $"r: Od x-{circle[0].x}, y-{circle[0].y} do x-{circle[1].x}, y-{circle[1].y}";
        }

        public void Show()
        {
            Console.WriteLine($".{new string('-', dlugosc)}" +
                $".");
        }


    }
}
