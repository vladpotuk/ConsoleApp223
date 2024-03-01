using System;

public class Sailor : Human
{
    public string ShipType { get; set; }

    public void Sail()
    {
        Console.WriteLine($"{Name} is sailing on a {ShipType}.");
    }
}
