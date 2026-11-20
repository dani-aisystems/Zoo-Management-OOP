using System;

public class Penguin : Animal, ISwimmable
{
    public Penguin(string name, int age, double weight)
        : base(name, age, weight)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{this.Name} крещи шумно.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{this.Name} яде риба и скариди.");
    }

    public void Swim()
    {
        Console.WriteLine($"{this.Name} плува бързо под водата.");
    }
}
