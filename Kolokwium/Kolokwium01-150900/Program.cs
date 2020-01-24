using System;
using System.Collections.Generic;
using System.Linq;
using Kolokwium01_150900.EmployerClass;
using Kolokwium01_150900.CarClass;
using Kolokwium01_150900.Exception;
using Kolokwium01_150900.FigureClass;
using Kolokwium01_150900.StudentClass;

namespace Kolokwium01_150900
{
    class Program 
    {
        public static string GetType(int variable) => $"Type: int";
        public static string GetType(string str) => $"Type: string";
        public static string GetType(int a, string b) => $"Type: int, Type: string";
        public static string GetType(bool boolean) => $"Type: boolean";
        public static string GetType(int a, int b, bool c) => $"Type: int, Type: int, Type: boolean";

        static void Main(string[] args)
        {
            //ex1
            var newCar = Car.CarCreateObject(500F, "254FC", 2005, "Fiat", 2.0F);
            var secondCar = Car.CarCreateObject(250F, "25EC", 2000, "Audi", 2.0F);

            Console.WriteLine($"Consumption: {newCar.CountConsumption((float)500.4, Car.typeOfRoad.t1)}");
            Console.WriteLine($"Consumption: {secondCar.CountConsumption((float)234.2, Car.typeOfRoad.t_0_8)}");
            //ex2
            int b = 4;
            Console.WriteLine($"{Program.GetType(b)}");
            string str = "test";
            Console.WriteLine($"{Program.GetType(str)}");
            b = 5;
            str = "test2";
            Console.WriteLine($"{Program.GetType(b, str)}");
            bool bol = false;
            Program.GetType(bol);
            Console.WriteLine($"{Program.GetType(bol)}");
            int a = 5;
            b = 4;
            bol = true;
            Console.WriteLine($"{Program.GetType(a, b, bol)}");
            // ex4

            var employers = new List<Employer>();

            var test = new Employer();
            test.firstName = "test";
            test.secondName = "test";
            var test2 = new Violinist();
            test2.firstName = "Test2";
            test2.secondName = "Test2";
            var test3 = new Bookkeeper();
            test3.firstName = "test3";
            test3.secondName = "test3";
            var test4 = new Salesman();
            test4.firstName = "test4";
            test4.secondName = "test4";
        
            employers.Add(test);
            employers.Add(test2);
            employers.Add(test3);
            employers.Add(test4);

            foreach (var i in employers)
            {
                Console.WriteLine($"name: {i.firstName}, secondname: {i.secondName}");
                i.Work();
            }

            //EX5

            var student = new Student("Juan", "Pablo");
            var studentOne = new Student("Test", "Test");
            var studentThree = new Student("Arek", "Cieloszczyk");
            var studentFour = new Student("Bartek", "Test");
            var studentFive = new Student("Ksfkasf", "dasdas");
            var studentSix = new Student("Ksfkasf", "Zdasdas");

            var students = new List<Student>();

            students.Add(student);
            students.Add(studentOne);
            students.Add(studentThree);
            students.Add(studentFour);
            students.Add(studentFive);
            students.Add(studentSix);

            
            var sortedList = students.OrderBy(x => x.secondName);

            foreach (var i in students)
            {
                Console.WriteLine($"{i.name}, {i.secondName}");
            }

            //ex with figure

            var d = new Point();

            d.TakeDataFromInput();
            d.PrintInfo();

            var f = new Triangle();

            try
            {
                f.TakeDataFromInput();
                f.PrintInfo();
            }
            catch (CantCreateATriangle)
            {
                Console.WriteLine("Can't create a triangle.");
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
            }

            var g = new Rectangle();

            g.TakeDataFromInput();
            g.PrintInfo();


            Console.ReadKey(); 
        }
    }
}
