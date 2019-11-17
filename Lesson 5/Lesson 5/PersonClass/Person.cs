using Interfaces;
using System;


namespace PersonClass
{
    public class Person : IGitarzysta, ISkrzypek
    {
        
        public void Play()
        {
            Console.WriteLine("Gram ale nie wiem na czym"); ;
        }


        void IGitarzysta.Play()
        {
            Console.WriteLine("Gram na gitarze");
        }

        void ISkrzypek.Play()
        {
            Console.WriteLine("Gram na skrzypcach");
        }


    }
}
