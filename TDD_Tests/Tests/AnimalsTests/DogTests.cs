using TDD_Nov.Animals;
public class DogTests
{
    [Fact]
    public void Dog_ShouldMakeWoofOrBarkSound()
    {
        Dog dog = new Dog("Lassie", 5, 5);
        Assert.Equal("Woof", dog.MakeSound());
    }

    [Fact]
    public void Dog_ShouldMakeBarkSoundWhenSmallerThanFour()
    {
        Dog dog = new Dog("Buddy", 2, 2);
        Assert.Equal("Bark bark!", dog.MakeSound());
    }

    [Fact]
    public void Dog_MoveWithoutSpeed_ShouldReturnCorrectMessage()
    {
        Dog dog = new Dog("Sparky", 5, 5);
        Assert.Equal($"{dog.Name} is moving!", dog.Move());
    }

    [Fact]
    public void Dog_MoveWithSpeed_ShouldReturnCorrectMessage()
    {
        Dog dog = new Dog("Sparky", 5, 5);
        Assert.Equal($"{dog.Name} is moving at a speed of {3} km/h", dog.Move(3));
    }
}