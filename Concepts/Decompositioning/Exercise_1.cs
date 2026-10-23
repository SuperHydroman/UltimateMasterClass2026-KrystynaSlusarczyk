namespace Decompositioning;

public class Exercise_1 : Exercise
{
    protected override void Demonstrate()
    {
        UserRegistration.Register("Gideon", 24);
    }
}

public static class UserRegistration
{
    public static void Register(string username, int age)
    {
        if (IsValidUsername(username) && IsValidAge(age))
            Console.WriteLine($"Registered: {username}");
    }

    private static bool IsValidAge(int age)
    {
        if (age >= 18) return true;
        
        Console.WriteLine("User must be 18 or older");
        return false;

    }

    private static bool IsValidUsername(string username)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            Console.WriteLine("Invalid username");
            return false;
        }

        return true;
    }
}