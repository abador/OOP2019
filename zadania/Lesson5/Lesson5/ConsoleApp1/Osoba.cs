using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Osoba : IGitarzysta, ISkrzypek
    {
        public void Graj()
        {
            Console.WriteLine("Gram ale nie wiem na czym");           
        }
        void IGitarzysta.Graj()
        {
            Console.WriteLine("Gram na gitarze");
        }
        void ISkrzypek.Graj()
        {
            Console.WriteLine("Gram na skrzypcach");
        }
    }
}
