using Interfaces;
using System;


namespace Vehicles
{
    public class Vehicle : IRideable
    {
        public virtual void Ride()
        {
            Console.WriteLine("I ride a vehicle");
        }
    }
}
