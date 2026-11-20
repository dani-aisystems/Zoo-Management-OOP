using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<Animal> animals = new List<Animal>();

        animals.Add(new Lion("Симба", 5, 190));
        animals.Add(new Elephant("Дъмбо", 10, 1200));
        animals.Add(new Parrot("Коко", 2, 1));
        animals.Add(new Dolphin("Флипър", 7, 250));
        animals.Add(new Penguin("Пинго", 3, 20));

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("===== ЗООПАРК =====");
            Console.WriteLine("1. Информация за животните");
            Console.WriteLine("2. Звуци на животните");
            Console.WriteLine("3. Хранене");
            Console.WriteLine("4. Животни, които плуват");
            Console.WriteLine("5. Животни, които летят");
            Console.WriteLine("6. Животни, които бягат");
            Console.WriteLine("7. Най-тежко животно");
            Console.WriteLine("8. Търсене по име");
            Console.WriteLine("9. Средна възраст");
            Console.WriteLine("0. Изход");
            Console.Write("Избор: ");

            string choice = Console.ReadLine();

            if (choice == null || choice == "0")
            {
                Console.WriteLine("Довиждане!");
                return;
            }

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    ShowAnimals(animals);
                    break;
                case "2":
                    MakeSounds(animals);
                    break;
                case "3":
                    FeedAnimals(animals);
                    break;
                case "4":
                    ShowSwimmers(animals);
                    break;
                case "5":
                    ShowFlyers(animals);
                    break;
                case "6":
                    ShowRunners(animals);
                    break;
                case "7":
                    ShowHeaviest(animals);
                    break;
                case "8":
                    SearchByName(animals);
                    break;
                case "9":
                    ShowAverageAge(animals);
                    break;
                default:
                    Console.WriteLine("Невалиден избор!");
                    break;
            }
        }
    }

    static void ShowAnimals(List<Animal> animals)
    {
        Console.WriteLine("--- Информация за животните ---");

        foreach (Animal animal in animals)
        {
            animal.DisplayInfo();
        }
    }

    static void MakeSounds(List<Animal> animals)
    {
        Console.WriteLine("--- Звуци ---");

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }

    static void FeedAnimals(List<Animal> animals)
    {
        Console.WriteLine("--- Хранене ---");

        foreach (Animal animal in animals)
        {
            animal.Eat();
        }
    }

    static void ShowSwimmers(List<Animal> animals)
    {
        Console.WriteLine("--- Животни, които плуват ---");

        foreach (Animal animal in animals)
        {
            if (animal is ISwimmable)
            {
                ISwimmable swimmer = (ISwimmable)animal;
                swimmer.Swim();
            }
        }
    }

    static void ShowFlyers(List<Animal> animals)
    {
        Console.WriteLine("--- Животни, които летят ---");

        foreach (Animal animal in animals)
        {
            if (animal is IFlyable)
            {
                IFlyable flyer = (IFlyable)animal;
                flyer.Fly();
            }
        }
    }

    static void ShowRunners(List<Animal> animals)
    {
        Console.WriteLine("--- Животни, които бягат ---");

        foreach (Animal animal in animals)
        {
            if (animal is IRunnable)
            {
                IRunnable runner = (IRunnable)animal;
                runner.Run();
            }
        }
    }

    static void ShowHeaviest(List<Animal> animals)
    {
        Console.WriteLine("--- Най-тежко животно ---");

        Animal heaviest = animals[0];

        foreach (Animal animal in animals)
        {
            if (animal.Weight > heaviest.Weight)
            {
                heaviest = animal;
            }
        }

        heaviest.DisplayInfo();
    }

    static void SearchByName(List<Animal> animals)
    {
        Console.WriteLine("--- Търсене по име ---");
        Console.Write("Въведете име: ");
        string name = Console.ReadLine();

        if (name == null)
        {
            return;
        }

        bool found = false;

        foreach (Animal animal in animals)
        {
            if (animal.Name.ToLower() == name.Trim().ToLower())
            {
                animal.DisplayInfo();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Няма животно с име {name}.");
        }
    }

    static void ShowAverageAge(List<Animal> animals)
    {
        Console.WriteLine("--- Средна възраст ---");

        int sum = 0;

        foreach (Animal animal in animals)
        {
            sum += animal.Age;
        }

        double average = (double)sum / animals.Count;

        Console.WriteLine($"Средната възраст на животните е {average:F2} г.");
    }
}
