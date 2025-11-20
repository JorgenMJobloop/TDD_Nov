namespace TDD_Nov.Animals;

public class Dog : Animal
{
    /// <summary>
    /// An arbitrary size, a chihuaha is a 2, a Golden retriever is 8 etc.
    /// This field is encapsulated, it is exposed publically in the primary Dog constructor.
    /// </summary>
    private int Size;
    // We utilize the base class's protected constructor.
    public Dog(string name, int age, int size)
        : base(name, age)
    {
        Size = size;
    }

    // by calling the "override" keyword, we archive "polymorphism" in Object-oriented programming paradigme.
    public override string MakeSound()
    {
        if (Size < 4)
        {
            return "Bark bark!";
        }
        return "Woof";
    }
}