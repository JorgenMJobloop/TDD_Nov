public class Person
{
    public string? Name;
    public int Age;
    public List<string> Hobbies = new List<string>();
    private const int MaxAge = 122;

    public Person(string name, int age, List<string> hobbies)
    {
        Name = name;
        Age = age;
        Hobbies = hobbies;
    }

    /// <summary>
    /// Get the name of a person (passed from primary constructor)
    /// </summary>
    /// <returns>string</returns>
    /// <exception cref="Exception">Throws an exception if our Name field is null</exception>
    public string GetName()
    {
        if (Name == null)
        {
            throw new Exception(nameof(Name));
        }
        return Name;
    }
    /// <summary>
    /// Get the age of a person (passed from primary constructor)
    /// </summary>
    /// <returns>int</returns>
    public int GetAge()
    {
        if (Age >= MaxAge)
        {
            throw new ArgumentException();
        }
        return Age;
    }

    public string GetHobbies()
    {
        return string.Join(", ", Hobbies);
    }
}