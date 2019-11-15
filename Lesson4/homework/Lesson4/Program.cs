using System;
using Map;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapa map = new Mapa();

            map.generate();
            Console.WriteLine();

            map.list();
            Console.WriteLine();

            map.show();
            Console.WriteLine();

            // random the player's position from all available grass fields on the map

            int x = 0, y = 0;

            Random random = new Random();

            foreach(MapElement me in map.data)
            {
                if(me is Grass)
                {
                    x = me.x;
                    y = me.y;

                    if (random.Next(0, 100) >= 90)
                        break;
                }
            }

            User user = new User("Player", 0, x, y);

            user.print();

            Console.ReadKey();
        }
    }
}
