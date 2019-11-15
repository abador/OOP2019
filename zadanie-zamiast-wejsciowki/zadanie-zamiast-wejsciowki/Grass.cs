using System;


namespace zadanie_zamiast_wejsciowki
{
    class Grass : MapElement
    {
        public void PrintGrass()
        {
            this.icon = 'G';
            Console.WriteLine($"{this.icon}: x = {this.x}, y = {this.y}");

        }
    }
}
