using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Builder bob = new Builder { Name = "Bob", Age = 35, Gender = "Male", Specialization = "Carpenter" };
        Sailor jack = new Sailor { Name = "Jack", Age = 45, Gender = "Male", ShipType = "Fishing boat" };
        Pilot emily = new Pilot { Name = "Emily", Age = 30, Gender = "Female", AircraftType = "Airbus A320" };


        bob.Build();
        jack.Sail();
        emily.Fly();

    }
}
