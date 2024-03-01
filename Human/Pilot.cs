using System;

public class Pilot : Human
{
    public string AircraftType { get; set; }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying an {AircraftType}.");
    }
}
