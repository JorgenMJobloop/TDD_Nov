public class PersonTests
{
    private readonly Person person = new Person("John Doe", 32, ["Programming", "Gaming", "Music", "Hiking", "Kayaking"]);

    [Fact]
    public void Hobbies_ShouldNotBeEmptyCollection()
    {
        Assert.NotEmpty(person.Hobbies);
    }

    [Fact]
    public void GetName_ShouldReturnName()
    {
        Assert.Equal("John Doe", person.Name);
    }

    [Fact]
    public void GetAge_ShouldReturnAge()
    {
        var expected = 32;
        Assert.Equal(expected, person.Age);
    }

    [Fact]
    public void GetAge_ShouldThrowErrorIfPersonIsOlderThan122()
    {

        Person person1 = new Person("", 123, []);
        Assert.Throws<ArgumentException>(() => person1.GetAge());
    }

    [Fact]
    public void Hobbies_ShouldContainKayaking()
    {
        Assert.Contains(person.Hobbies[4], "Kayaking");
    }

    [Fact]
    public void Hobbies_ShouldContainHiking()
    {
        foreach (var h in person.Hobbies)
        {
            if (h.Contains("Hiking"))
            {
                Assert.Matches("Hiking", h);
            }
        }
    }

    [Fact]
    public void Hobbies_ShouldNotContain()
    {
        foreach (var h in person.Hobbies)
        {
            Assert.DoesNotContain(h, "Skiing");
        }
    }
}