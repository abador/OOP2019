using System;

namespace zamiastwejsciowki
{
    class Program
    {
        static void Main(string[] args)
        {
            int WymiarX;
            int WymiarY;
            int Rzedy;
            int Kolumny;
            Console.WriteLine("Podaj wymiar x");
            WymiarX = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wymiar y");
            WymiarY = Int32.Parse(Console.ReadLine());

            static string[,] CreateTable(int x,int y)
            {
                return new string[x, y];
            }

            string[,] Map = CreateTable(WymiarX,WymiarY);


            Random rnd = new Random();
            //Console.WriteLine("0 1 2 3 4 5 6 7 8 9...");
            Console.Write("  ");
            for (Kolumny = 0; Kolumny <= WymiarX; Kolumny++)
            {
                Console.Write("_ ");
            }
            Console.WriteLine();
            for (Rzedy = 0; Rzedy <= WymiarY; Rzedy++)
            {
                Console.Write("¦ ");
                for (Kolumny = 0; Kolumny <= WymiarX; Kolumny++)
                {
                    int num = rnd.Next(6);
                    switch (num)
                    {
                        case 1:
                            Map[Rzedy, Kolumny] = "G";
                            break;
                        case 2:
                            Map[Rzedy, Kolumny] = "T";
                            break;
                        case 3:
                            Map[Rzedy, Kolumny] = "R";
                            break;
                        default:
                            Console.Write("");
                            break;
                    }
                }
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
