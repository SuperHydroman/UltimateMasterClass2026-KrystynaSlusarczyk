namespace Decompositioning.Exercise_9.Products;

public class Dvd : Product
{
    private string Director { get; }
    private int DurationInMinutes { get; }

    public Dvd(string title, string director, int durationInMinutes) : base(title)
    {
        Director = director;
        DurationInMinutes = durationInMinutes;
    }
}