namespace TDD_Nov.Services;

public class AnimalService
{
    private readonly List<Animal> _animals;

    public AnimalService(IEnumerable<Animal> animals)
    {
        _animals = animals.ToList();
    }

    /// <summary>
    /// Lambda method (LINQ)
    /// </summary>
    /// <param name="age">the age of the animal</param>
    /// <returns>all animals older than age parameter</returns>
    public IEnumerable<Animal> GetAnimalsOlderThan(int age) => _animals.Where(animal => animal.Age > age);

    /// <summary>
    /// Same method as the one above, but not as a lambda
    /// </summary>
    /// <param name="age">the age of the animal</param>
    /// <returns>all animals older than age parameter</returns>
    public IEnumerable<Animal> GetAnimalsOlderThanRegularSignature(int age)
    {
        var allAnimalsOlderThanParam = _animals.Where(animalAgeVariable => animalAgeVariable.Age > age);
        return allAnimalsOlderThanParam;
    }
    /// <summary>
    /// Find a animal, by passing it's name as an argument to this method
    /// </summary>
    /// <param name="name">the name of the animal</param>
    /// <returns>any single animal by it's name</returns>
    public Animal? FindAnimalByName(string name) => _animals.FirstOrDefault(animal => animal.Name!.Equals(name, StringComparison.OrdinalIgnoreCase));
    /// <summary>
    /// Get all animal sounds, no matter what animal it is.
    /// </summary>
    /// <returns>the sound of all animals</returns>
    public IEnumerable<string> GetAllAnimalSounds()
    {
        return _animals.Select(animal => animal.MakeSound());
    }

    public IEnumerable<Animal> SortAnimalsByAge()
    {
        return _animals.OrderBy(animal => animal.Age);
    }
}