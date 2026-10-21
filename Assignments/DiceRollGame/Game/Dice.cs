namespace DiceRollGame;

public class Dice
{
    private readonly Random _random;
    private const int SidesCount = 6;

    public Dice(Random random)
    {
        _random = random;
    }
    
    public int Roll() 
        => _random.Next(1, SidesCount + 1); // 1 - 6

    public void Describe()
        => Console.WriteLine($"This is a dice with {SidesCount} sides");
}