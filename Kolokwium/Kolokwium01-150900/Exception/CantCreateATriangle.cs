using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium01_150900.Exception
{
    class CantCreateATriangle : System.Exception
    {
        public CantCreateATriangle()
        {

        }

        public CantCreateATriangle(string message) : base(message)
        {

        }

        public CantCreateATriangle(string message, System.Exception inner) : base(message, inner)
        {

        }
    }
}
