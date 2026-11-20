using System;

public abstract class Animal
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public double Weight { get; private set; }

    protected Animal(string name, int age, double weight)
    {
        this.Name = name;
        this.Age = age;
        this.Weight = weight;
    }

    public abstract void MakeSound();

    public virtual void Eat()
    {
        Console.WriteLine($"{this.Name} яде.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Име: {this.Name}, възраст: {this.Age} г., тегло: {this.Weight} кг");
    }
}
