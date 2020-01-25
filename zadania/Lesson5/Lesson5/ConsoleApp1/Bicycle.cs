using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bicycle : Vehicle, IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jadę rowerem");
        }
    }
}
