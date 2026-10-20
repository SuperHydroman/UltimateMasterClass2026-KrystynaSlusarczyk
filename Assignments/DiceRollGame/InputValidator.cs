namespace DiceRollGame;

public static class InputValidator
{
    public static bool Validate(string input, int expected)
    {

        if (int.TryParse(input, out int result))
        {
            if (result == expected)
                return true;

            Console.WriteLine("Wrong number");
        }
        else Console.WriteLine("Incorrect input");

        return false;
    }
}