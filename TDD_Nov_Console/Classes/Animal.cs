using TDD_Nov.Models;


/// <summary>
/// Base class (super class)
/// </summary>
public abstract class Animal : IAnimalActions
{
    public string? Name { get; set; }
    public int Age { get; set; }

    protected Animal(string name, int age)
    {
        if (age < 0)
        {
            throw new Exception("Age cannot be less than 0");
        }
        Name = name;
        Age = age;
    }


    // This is marked abstract, which means that any classes that inherits from Animal, will override this the specific sound for each different animal.
    public abstract string MakeSound();

    public void EatFood(string food)
    {
        if (string.IsNullOrWhiteSpace(food))
        {
            throw new ArgumentException("We have to feed the animals food!");
        }

        Console.WriteLine($"{Name} is eating {food}");
    }

    // method overloading
    // This method will be overloaded
    public virtual string Move()
    {
        return $"{Name} is moving!";
    }

    // the method below has overloaded the one above.
    public virtual string Move(int speed)
    {
        return $"{Name} is moving at a speed of {speed} km/h";
    }
}