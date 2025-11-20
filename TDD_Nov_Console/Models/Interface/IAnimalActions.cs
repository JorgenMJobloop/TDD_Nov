namespace TDD_Nov.Models;

public interface IAnimalActions
{
    /// <summary>
    /// Animal : Eat a piece of food
    /// </summary>
    void EatFood(string food);
    /// <summary>
    /// Animal : Makes a sound
    /// </summary>
    /// <returns>The sound an animal makes</returns>
    string MakeSound();
}