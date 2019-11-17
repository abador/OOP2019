using System;

namespace Wejściówka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("151212");
            Console.WriteLine(151212 % 4);

            Mapa map = new Mapa(5);
            map.generate();
            map.list();
            map.show();

            
        }
    }
}
