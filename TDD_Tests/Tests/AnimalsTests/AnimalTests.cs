using TDD_Nov;
using TDD_Nov.Animals;
public class AnimalTests
{
    [Fact]
    public void Animal_ShouldThrowExceptionIfAgeIsLessThanZero()
    {
        Assert.Throws<Exception>(() => new Dog("Max", -1, 1));
    }

    [Fact]
    public void Animal_ShouldThrowExceptionIfFoodIsEmptyOrWhiteSpace()
    {
        Cat cat = new Cat("Luna", 2);
        Assert.Throws<ArgumentException>(() => cat.EatFood(""));
    }
}