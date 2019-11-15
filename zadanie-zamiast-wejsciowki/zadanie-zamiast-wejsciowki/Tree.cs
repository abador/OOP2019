using System;


namespace zadanie_zamiast_wejsciowki
{
    class Tree : MapElement
    {
        public void PrintTree()
        {
            this.icon = 'T';
            Console.WriteLine($"{this.icon}: x = {this.x}, y = {this.y}");

        }
    }
}
