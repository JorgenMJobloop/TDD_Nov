namespace TDD_Nov.Animals;

public class Parrot : Animal
{
    public Parrot(string name, int age) : base(name, age)
    {
    }

    public override string MakeSound()
    {
        return "Squawk";
    }
}