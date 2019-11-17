using Interfaces;
using PersonClass;
using System;
using Tests;
using Vehicles;
using ZbiorFigur;
using Zwierzaki;

namespace Lesson_5
{
    class Program
    {
        static void Main()
        {
            Car auto = new Car();
            Bicycle bike = new Bicycle();

            bike.Ride();
            auto.Ride();

            Person person = new Person();
            ISkrzypek person2 = new Person();
            IGitarzysta person3 = new Person();

            person.Play();
            person2.Play();
            person3.Play();

            Test ob1 = new Test();
            Test ob2 = new Test();
            Test ob3 = new Test();

            ob1.numb = 255;
            ob1.poleTestowe.word = "Word";
            
            ob2 = ob1; 

            ob3 = (Test)ob1.DeepCopy(); //Copy() kopiuje tylko prymitywne zmienne

            ob1.numb = 347;
            ob1.poleTestowe.word = "Duck";
            Console.WriteLine($"ob1 = {ob1.numb}-{ob1.poleTestowe.word}\n" +
                $"ob2 = {ob2.numb}-{ob2.poleTestowe.word}\n" +
                $"ob3 = {ob3.numb}-{ob3.poleTestowe.word}");

            Krokodyl krokodyl1 = new Krokodyl("Janek", 40);
            Krokodyl krokodyl2 = new Krokodyl("Franek", 50);
            Krokodyl krokodyl3 = new Krokodyl("Kazik", 30);

            krokodyl1 = krokodyl2;
            krokodyl3 = (Krokodyl)krokodyl2.Clone();
            krokodyl2.imie = "Nowe";//nie trzeba deepClone

            Console.WriteLine($"krokodyl1 imie = {krokodyl1.imie}\n" +
                $"krokodyl2 imie = {krokodyl2.imie}\n" +
                $"krokodyl3 imie = {krokodyl3.imie}");

            Square kwadrat = new Square();

            kwadrat.Input();
            kwadrat.LiczObwod();
            kwadrat.Show();
            Console.WriteLine(kwadrat);

            Circle kolo = new Circle();

            kolo.Input();
            kolo.LiczObwod();
            kolo.Show();
            Console.WriteLine(kolo);
            


            
       


            Console.ReadLine();
        }
    }
}
