namespace Decompositioning;

public class Exercise_3_CorrectSolution : Exercise
{
    protected override void Demonstrate()
    {
        Console.WriteLine(string.Join(" ", TextFormatterCorrectSolution.FormatUppercase(["hello", "world", "in", "upper", "case"])));
        Console.WriteLine("-------------------");
        
        Console.WriteLine(string.Join(" ", TextFormatterCorrectSolution.FormatLowercase(["I", "AM", "LOWER", "CASED", "NOW"])));
    }
}

public static class TextFormatterCorrectSolution
{
    public static List<string> FormatUppercase(List<string> words)
        => FormatString(words, word => word.ToUpper());
    
    public static List<string> FormatLowercase(List<string> words)
        => FormatString(words, word => word.ToLower());

    private static List<string> FormatString(List<string> words, Func<string, string> transform)
    {
        var result = new List<string>();

        foreach (string word in words)
        {
            result.Add(transform(word));
        }

        return result;
    }
}