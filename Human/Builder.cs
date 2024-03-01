using System;

public class Builder : Human
{
    public string Specialization { get; set; }

    public void Build()
    {
        Console.WriteLine($"{Name} is building something as a {Specialization}.");
    }
}
