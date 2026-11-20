using System;

public class Dolphin : Animal, ISwimmable
{
    public Dolphin(string name, int age, double weight)
        : base(name, age, weight)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{this.Name} издава свирещи звуци.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{this.Name} яде риба.");
    }

    public void Swim()
    {
        Console.WriteLine($"{this.Name} плува и скача над водата.");
    }
}
