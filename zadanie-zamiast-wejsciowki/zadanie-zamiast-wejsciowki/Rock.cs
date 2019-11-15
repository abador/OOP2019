using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_zamiast_wejsciowki
{
    class Rock : MapElement
    {
        public void PrintRock()
        {
            this.icon = 'R';
            Console.WriteLine($"{this.icon}: x = {this.x}, y = {this.y}");

        }
    }
}
