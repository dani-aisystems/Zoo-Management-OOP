using System;

public class Parrot : Animal, IFlyable
{
    public Parrot(string name, int age, double weight)
        : base(name, age, weight)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{this.Name} казва: Здравей!");
    }

    public override void Eat()
    {
        Console.WriteLine($"{this.Name} яде семена и плодове.");
    }

    public void Fly()
    {
        Console.WriteLine($"{this.Name} лети над клетката.");
    }
}
