namespace Decompositioning.Exercise_9.Products;

public class Dvd : Product
{
    private string Author { get; }
    private string Isbn { get; }

    public Dvd(string title, string author, string isbn) : base(title)
    {
        Author = author;
        Isbn = isbn;
    }
}