using System;

public class Pacjent
{
    public string imie;
    public string nazwisko;
    public double wzrost;
    public double waga;
	public Pacjent()
	{
	}
    public double obliczBMI()
    {
            double bmi = waga / (wzrost*wzrost);
        //wzrost podawaj w metrach!!!
        Console.WriteLine("bmi = " + bmi);
        if (bmi < 18.5) Console.WriteLine("niedowaga");
        if (bmi >= 18.5 && bmi <= 24.9) Console.WriteLine("prawidłowa");
        if (bmi >= 25 && bmi <= 29.9) Console.WriteLine("nadwaga");
        if (bmi > 30) Console.WriteLine("otyłość");
        return bmi;
    }
}
