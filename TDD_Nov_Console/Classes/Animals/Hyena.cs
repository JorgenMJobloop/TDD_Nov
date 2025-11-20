namespace TDD_Nov.Animals;

public class Hyena : Animal
{
    public Hyena(string name, int age) : base(name, age)
    {
    }

    public override string MakeSound()
    {
        return "Giggle";
    }
}