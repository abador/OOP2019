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

            map.list();
            map.show();

            // random the player's position from all available grass fields on the map

            int x = 0, y = 0;

            Random random = new Random();

            for (int i = 0; i < map.data.GetLength(0); i++)
                for (int j = 0; j < map.data.GetLength(1); j++)
                    if (map.data[i, j] is Grass)
                    {
                        x = i;
                        y = j;

                        if (random.Next(0, 100) >= 60)
                            break;
                    }

            User user = new User("Player", 0, x, y);

            user.print();

            Console.ReadKey();
        }
    }
}
