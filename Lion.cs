using System;

public class Lion : Animal, IRunnable
{
    public Lion(string name, int age, double weight)
        : base(name, age, weight)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{this.Name} реве: Рррр!");
    }

    public override void Eat()
    {
        Console.WriteLine($"{this.Name} яде месо.");
    }

    public void Run()
    {
        Console.WriteLine($"{this.Name} бяга бързо из саваната.");
    }
}
