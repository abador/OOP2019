using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Osoba
    {
        public string Imie;
        public string Nazwisko;

        virtual public void WypiszInfo()
        {
            Console.WriteLine("Imie" + Imie);
            Console.WriteLine("Nazwisko" + Nazwisko);
        }

    }

    class Student:Osoba
    {
        public int rokStudiów;
        public int numerGrupy;
        public int numerAlbumu;

        public Student(int rokStudiów, int numerGrupy, int numerAlbumu)
        {
            this.rokStudiów = rokStudiów;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }

        override public void WypiszInfo()
        {
            Console.WriteLine("rokStudiów" + rokStudiów);
            Console.WriteLine("numerGrupy" + numerGrupy);
            Console.WriteLine("numerAlbumu" + numerAlbumu);
        }


    }

    class Figura
    {
        protected int a;
        protected int b;
        protected int c;

  
        public int ObliczPole()
        {
            return this.a * this.b * this.c;
        }

        public void Lista()
        {
            var list = new List<Kwadrat>();
            var list1 = new List<Trójkąt>();

            foreach(int a in )
            {
                Console.WriteLine(ObliczPole(a));
            }
        }
    }

    class Kwadrat:Figura
    {
        private int ObliczPole(int a)
        {
            return this.a * this.a;
        }
    }

    class Trójkąt:Figura
    {
        private int ObliczPole(int a, int b)
        {
            return (this.a * this.b) / 2;
        }
    }
}
