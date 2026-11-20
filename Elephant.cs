using System;

public class Elephant : Animal, IRunnable
{
    public Elephant(string name, int age, double weight)
        : base(name, age, weight)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{this.Name} тръби силно.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{this.Name} яде трева, листа и плодове.");
    }

    public void Run()
    {
        Console.WriteLine($"{this.Name} бяга тежко и земята трепери.");
    }
}
