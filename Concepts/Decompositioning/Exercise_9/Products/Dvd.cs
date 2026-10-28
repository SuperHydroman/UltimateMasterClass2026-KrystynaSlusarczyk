namespace Decompositioning.Exercise_9.Products;

public class Dvd : Product
{
    private string Director { get; }
    private string DurationInMinutes { get; }

    public Dvd(string title, string director, string durationInMinutes) : base(title)
    {
        Director = director;
        DurationInMinutes = durationInMinutes;
    }
}