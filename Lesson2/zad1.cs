using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("podaj temperature w stopniach C\n");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write(i+"C\n");
            double z = (i * 1.8) + 32;
            Console.Write(z + "F");
            Console.ReadKey();



        }
    }
}
