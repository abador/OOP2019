using System;


namespace zadanie_zamiast_wejsciowki
{
    class Point
    {
        protected int x;
        protected int y;

        public void Print()
        {
            Console.WriteLine($"Wspolrzedna x = {x}\n" +
                $"Wspolrzedna y = {y}");
        }
    }
}
