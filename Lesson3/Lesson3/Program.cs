using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             int liczba1, liczba2 = 30, liczba3 = 0;
             int[] table = new int[2];
             try { 
                 //liczba1 = liczba2 / liczba3;
                 //table[25] = 2;
                 throw new IndexOutOfRangeException();
             }
             catch(IndexOutOfRangeException e)
             {
                 Console.WriteLine(e.Message);
             }
             catch(Exception e)
             {
                 Console.WriteLine(e.Message);
             }
             finally
             {
                 Console.WriteLine("FINALLY");
             }
             */
            double wynik = 0;
            try
            {
                Obliczenia a = new Obliczenia(5, 0);
                wynik = a.Dzielenie();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                wynik = -1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(wynik);
            }

            Console.ReadKey();
        }
    }
}
