using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string eva = "variable";
            string userName;
            Console.WriteLine("Podaj swoje imie, a nastepnie wcisnij ENTER");
            userName =  Console.ReadLine();
            if (userName != "")
            {
                Console.WriteLine("Hello " + userName + ".");
            }
            else {
                Console.WriteLine("Nie podałes imienia");
            }
            Console.ReadLine();
        }
    }
}
