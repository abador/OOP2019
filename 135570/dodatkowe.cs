using System;
public class main
{
    public static void Main()
    {
        int a = 5, b = 9, c = 11;
        double x, y, z;
        x = (double)a;
        y = (double)b;
        z = (double)c;
        Console.WriteLine("a/b= {0}", x/y);
        Console.WriteLine("a/c= {0}", x/z);
        Console.WriteLine("b/c= {0}", y/z);
        Console.WriteLine("b/a= {0}", y/x);
        Console.WriteLine("c/a= {0}", z/a);
        Console.WriteLine("c/b= {0}", z/y);
        Console.ReadKey();

        sbyte f = 127;
        f++;
        Console.WriteLine("sbyte f 127++ = {0}", f);
        //sbyte przechowuje wartości z zakresu od -128 do 127, dlatego kolejna wartość w "ciągu" to -128.
    }
}

/*
W program101.cs zmienne i, j i k nie mają przypisanej wartości. 
Można zedytować 6. linię kodu określając ich wartości, aby program się kompilował.


*/
