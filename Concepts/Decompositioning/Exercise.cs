namespace Decompositioning;

public abstract class Exercise
{
    public void Run()
    {
        string runningMessage = GetType().Name.Replace('_', ' ');
        Console.WriteLine($"===================\n" +
                          $"Running {runningMessage}!\n" +
                          $"-------------------");
        
        Demonstrate();
        
        Console.WriteLine("===================");
        Console.WriteLine();
    }

    protected abstract void Demonstrate();
}