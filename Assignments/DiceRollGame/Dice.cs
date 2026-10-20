namespace DiceRollGame;

public static class Dice
{
    public static int Roll()
    {
        Random rng = new();
        return rng.Next(1, 7); // 1 - 6
    }
}