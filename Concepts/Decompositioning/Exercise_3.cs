namespace Decompositioning;

public class Exercise_3 : Exercise
{
    protected override void Demonstrate()
    {
        Console.WriteLine(string.Join(" ", TextFormatterCorrectSolution.FormatUppercase(["hello", "world", "in", "upper", "case"])));
        Console.WriteLine("-------------------");

        Console.WriteLine(string.Join(" ", TextFormatter.FormatLowercase(["I", "AM", "LOWER", "CASED", "NOW"])));
    }
}

public static class TextFormatter
{
    public static List<string> FormatUppercase(List<string> words)
    {
        return FormatString(words, "upper");
    }

    public static List<string> FormatLowercase(List<string> words)
    {
        return FormatString(words, "lower");
    }

    private static List<string> FormatString(List<string> words, string formatType)
    { 
        var result = new List<string>();

        foreach (string word in words)
        {
            result.Add(
                formatType.Equals("upper" , StringComparison.CurrentCultureIgnoreCase)
                    ? word.ToUpper()
                    : word.ToLower()
                );
        }

        return result;
    }
}