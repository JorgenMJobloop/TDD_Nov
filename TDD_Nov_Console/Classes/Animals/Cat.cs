namespace TDD_Nov.Animals;

public class Cat : Animal
{
    public Cat(string name, int age)
        : base(name, age)
    {
    }

    // private helper method, that is called in MakeSound()

    private bool IsKitten(int age)
    {
        Age = age;
        if (Age <= 3)
        {
            return true;
        }
        return false;
    }

    public override string MakeSound()
    {
        if (IsKitten(Age))
        {
            return "Purr";
        }
        return "Meow";
    }
}