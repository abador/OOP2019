using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            Bomb b1 = new Bomb(2,4);
            b1.showCoor();
            b1.showCoorbomb();
            b1.isCorrect();
            Console.ReadKey();
        }
    }
}
