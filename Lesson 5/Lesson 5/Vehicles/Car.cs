using Interfaces;
using System;


namespace Vehicles
{
    public class Car : Vehicle
    {
        public override void Ride() => Console.WriteLine("I ride a car");
        
    }
}
