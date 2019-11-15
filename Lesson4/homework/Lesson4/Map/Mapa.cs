using System;
using Lesson4;

namespace Map
{
    class Mapa : IMapa
    {
        public MapElement[,] data;

        public void generate()
        {
            int[] size = new int[2];

            bool error;
            
            do
            {
                error = false;

                Console.Write("Podaj wymiary mapy <x, y>: ");

                string[] input = Console.ReadLine().Split(',');

                if (input.Length != size.Length)
                    error = true;
                else
                    for (int i = 0; i < size.Length; i++)
                        if (!Int32.TryParse(input[i], out size[i]))
                            error = true;
                        else if (size[i] < 1 || size[i] > 10)
                            error = true;
            } while (error);

            this.data = new MapElement[size[0], size[1]];

            Random random = new Random();

            // I want to make sure that at least one grass field is generated

            for (int i = 0; i < size.Length; i++)
                size[i] = random.Next(0, this.data.GetLength(i) - 1);

            this.data[size[0], size[1]] = new Grass(size[0], size[1]);

            for (int i = 0; i < this.data.GetLength(0); i++)
                for (int j = 0; j < this.data.GetLength(1); j++)
                {
                    if (i == size[0] && j == size[1])
                        continue;

                    int number = random.Next(0, 10);

                    if (number <= 1)
                        this.data[i, j] = new Rock(i, j);
                    else if (number <= 4)
                        this.data[i, j] = new Tree(i, j);
                    else
                        this.data[i, j] = new Grass(i, j);
                }
        }

        public void list()
        {
            for (int i = 0; i < this.data.GetLength(0); i++)
                for (int j = 0; j < this.data.GetLength(1); j++)
                    this.data[i, j].print();
        }

        public void show()
        {
            for (int i = 0; i < this.data.GetLength(0); i++)
            {
                for (int j = 0; j < this.data.GetLength(1); j++)
                    Console.Write(this.data[i, j].icon);

                Console.WriteLine();
            }
        }
    }
}
