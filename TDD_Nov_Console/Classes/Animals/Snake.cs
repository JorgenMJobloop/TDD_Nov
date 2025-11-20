namespace TDD_Nov.Animals;

public class Snake : Animal
{
    public Snake(string name, int age) : base(name, age)
    {
    }

    public override string MakeSound()
    {
        return "Hiss";
    }
}