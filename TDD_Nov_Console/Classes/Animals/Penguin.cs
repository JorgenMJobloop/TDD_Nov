namespace TDD_Nov.Animals;

public class Penguin : Animal
{
    public Penguin(string name, int age) : base(name, age)
    {
    }

    public override string MakeSound()
    {
        return "Honk";
    }
}